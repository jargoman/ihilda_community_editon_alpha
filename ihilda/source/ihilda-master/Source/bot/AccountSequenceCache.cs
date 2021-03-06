﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Codeplex.Data;
using IhildaWallet.Networking;
using RippleLibSharp.Commands.Accounts;
using RippleLibSharp.Commands.Tx;
using RippleLibSharp.Network;
using RippleLibSharp.Result;
using RippleLibSharp.Transactions;
using RippleLibSharp.Util;

namespace IhildaWallet
{
	public class AccountSequenceCache
	{
		private AccountSequenceCache (string account)
		{
			this.Account = account;
			this.actualSettingsFileName = account + settingsFileName;
			settingsPath = FileHelper.GetSettingsPath (actualSettingsFileName);
			// must be called after settingspathset
			this.SequenceCache = Load ();

			
		}

		public static AccountSequenceCache GetCacheForAccount (string account)
		{
			AccountSequenceCache accountSequence = null;
			//lock (lockSeq) {
				if (account == null) {
					throw new NullReferenceException ();
				}

				if (CacheManager == null) {
					return null;
				}

				bool success = CacheManager.TryGetValue (account, out AccountSequenceCache accountSequenceCache);
				if (success) {
					return accountSequenceCache;
				}
				

				accountSequence = new AccountSequenceCache (account);

				CacheManager.Add (account, accountSequence);
			//}
			return accountSequence;

		}

		private static Dictionary<string, AccountSequenceCache> CacheManager = new Dictionary<string, AccountSequenceCache> ();

		private readonly string Account;
		public void UpdateOrdersCache (AutomatedOrder order /*, string account*/)
		{

			Task.Run (delegate {
				lock (lockSeq) {
					if (order == null) {
						return;
					}

					string id = order.Bot_ID;
					Logging.WriteLog ("Synccache : " + (id ?? "null"));

					Dictionary<string, AutomatedOrder> dict = this.SequenceCache;
					if (dict == null) {
						//dict = new Dictionary<string, AutomatedOrder> (orders.Count ());
						dict = new Dictionary<string, AutomatedOrder> ();
					} else if (dict.ContainsKey (id)) {
						return;
					}


					dict.Add (id, order);


					if (order.Previous_Bot_ID != null) {

						dict.Remove (order.Previous_Bot_ID);
					}
				}
			});


		}


		public void RemoveAndSavePrevious (IEnumerable<AutomatedOrder> orders)
		{
			if (orders == null || !orders.Any()) {
				return;

			}

			foreach (AutomatedOrder order in orders) {

				if (order?.Previous_Bot_ID != null) {
					RemoveAndSave (order.Previous_Bot_ID);
				}

			}

		}

		public void RemoveAndSave (AutomatedOrder order)
		{
			string id = order?.Bot_ID;
			if (id == null) {
				return;
			}
			RemoveAndSave (id);
		}

		public void RemoveAndSave (string key)
		{
			lock (lockSeq) {
				Dictionary<string, AutomatedOrder> dict = this.SequenceCache;
				bool updated = dict != null && dict.Remove(key);

				if (updated) {



					ConfStruct confstruct = new ConfStruct (dict.Values);

					string conf = DynamicJson.Serialize (confstruct);

					FileHelper.SaveConfig (settingsPath, conf);
				}
			}
		}


		public void UpdateAndSave (AutomatedOrder order /*, string account*/)
		{
			if (order == null) {
				return;
			}

			lock (lockSeq) {
				string id = order.Bot_ID;
				Logging.WriteLog ("Synccache : " + (id ?? "null"));

				Dictionary<string, AutomatedOrder> dict = this.SequenceCache;
				if (dict == null) {
					//dict = new Dictionary<string, AutomatedOrder> (orders.Count ());
					dict = new Dictionary<string, AutomatedOrder> ();
				} else if (dict.ContainsKey (id)) {
					return;
				}


				dict.Add (id, order);

				if (order.Previous_Bot_ID != null) {

					dict.Remove (order.Previous_Bot_ID);
				}

				IEnumerable<AutomatedOrder> offers = dict.Values;

				//var settingsPath = FileHelper.GetSettingsPath (actualSettingsFileName);

				//ConfStruct confstruct = new ConfStruct( orderDict.Values );
				ConfStruct confstruct = new ConfStruct (offers);

				string conf = DynamicJson.Serialize (confstruct);

				FileHelper.SaveConfig (settingsPath, conf);
			}
		}



		public void SyncOrdersCache (CancellationToken token)
		{

#if DEBUG
			string method_sig = clsstr + DebugRippleLibSharp.both_parentheses;
			if (DebugIhildaWallet.AccountSequenceCache) {
				Logging.WriteLog (method_sig, DebugRippleLibSharp.beginn);
			}
#endif


			try {
				token.ThrowIfCancellationRequested ();
				if (Account == null) {
#if DEBUG
					if (DebugIhildaWallet.AccountSequenceCache) {
						Logging.WriteLog (method_sig, nameof (Account) + DebugRippleLibSharp.null_str);
					}
#endif
					return;
				}

				NetworkInterface networkInterface = NetworkController.CurrentInterface;

				if (networkInterface == null) {
					return;
				}

				Task<IEnumerable<Response<AccountOffersResult>>> task = AccountOffers.GetFullOfferList (Account, networkInterface, token);


				if (task == null) {
					return;
				}

				try {

					do {
						if (OnOrderCacheEvent != null) {
							OrderCachedEventArgs cachedEventArgs = new OrderCachedEventArgs () {
								UIpump = true
							};
							OnOrderCacheEvent.Invoke (this, cachedEventArgs);
						}
						task.Wait (1000, token);
					} while (!task.IsCanceled && !task.IsCompleted && !task.IsFaulted && !token.IsCancellationRequested);

				} catch (Exception e) when (e is TaskCanceledException || e is OperationCanceledException) {
					return;
				}


				IEnumerable<Response<AccountOffersResult>> responses = task.Result;

				Dictionary<string, AutomatedOrder> cached = Load ();





				foreach (Response<AccountOffersResult> resp in responses) {

					var offs = resp?.result?.offers;
					if (offs == null) {

						if (OnOrderCacheEvent != null) {
							OrderCachedEventArgs cachedEventArgs = new OrderCachedEventArgs {
								GetOrder = null,
								GetSuccess = false,
								Message = "No offers in server response"
							};

							OnOrderCacheEvent.Invoke (this, cachedEventArgs);
						}

						continue;
					}

					//List<AutomatedOrder> auts_list = new List<AutomatedOrder> ();

					int ordercount = 0;
					foreach (Offer o in offs) {


						string id = o.Account + o.Sequence.ToString ();

						if (cached != null && cached.ContainsKey (id)) {
							if (OnOrderCacheEvent != null) {
								string message = "Order with sequence " + o.Sequence.ToString () + " already in cache\n";
								OrderCachedEventArgs cachedEventArgs = new OrderCachedEventArgs () {
									GetOrder = o,
									GetSuccess = true,
									Message = message
								};


								OnOrderCacheEvent.Invoke (this, cachedEventArgs);
							}
							continue;
						}

						string acc = o.Account;
						uint seq = o.Sequence;
						Task<Response<string>> seqTask = tx.GetTxFromAccountAndSequenceDataAPI (acc, seq, token);
						if (seqTask == null) {


							if (OnOrderCacheEvent != null) {
								string message = 
									"Failed to retrive order with sequence " + 
									o.Sequence.ToString () + 
									 " possible network issues\n";


								OrderCachedEventArgs cachedEventArgs = new OrderCachedEventArgs {
									GetOrder = o,
									GetSuccess = false,
									Message = message
								};


								OnOrderCacheEvent.Invoke (this, cachedEventArgs);
							}


							token.WaitHandle.WaitOne (5000);
							continue;
						}


						seqTask.Wait (token);


						Response<string> response = seqTask.Result;
						if (response == null) {

							if (OnOrderCacheEvent != null) {
								string message = "Failed to retrive order with sequence " + o.Sequence.ToString () + " response is null\n";
								OrderCachedEventArgs cachedEventArgs = new OrderCachedEventArgs {
									GetOrder = o,
									GetSuccess = false,
									Message = message
								};


								OnOrderCacheEvent.Invoke (this, cachedEventArgs);
							}


							token.WaitHandle.WaitOne (5000);
							continue;
						}
						string s = response.result;
						var txstruct = response.transaction;
						//txstruct.tx.
						AutomatedOrder ao = AutomatedOrder.ReconsctructFromTransaction (txstruct.tx);

						if (ao == null) {
							if (OnOrderCacheEvent != null) {
								string message = "Failed to retrive order with sequence " + o.Sequence.ToString () + " unable to reconstruct order from tx\n";
								OrderCachedEventArgs cachedEventArgs = new OrderCachedEventArgs {
									GetOrder = o,
									GetSuccess = false,
									Message = message
								};


								OnOrderCacheEvent.Invoke (this, cachedEventArgs);
							}
							continue;
						}


						if (OnOrderCacheEvent != null) {
							string message = "Caching order with sequence " + o.Sequence.ToString () + "\n";
							OrderCachedEventArgs cachedEventArgs = new OrderCachedEventArgs {
								GetOrder = o,
								GetSuccess = true,
								Message = message
							};


							OnOrderCacheEvent.Invoke (this, cachedEventArgs);
						}

						UpdateOrdersCache (ao /*, account */);

						if (ordercount++ % 5 == 4) {
							if (OnOrderCacheEvent != null) {
								OrderCachedEventArgs cachedEventArgs = new OrderCachedEventArgs {
									GetOrder = null,
									GetSuccess = true,
									Message = "Saving cache to file\n"
								};

								OnOrderCacheEvent.Invoke (this, cachedEventArgs);
							}

							this.Save ();
						}

					}

					if (OnOrderCacheEvent != null && ordercount % 5 != 0) {
						OrderCachedEventArgs cachedEventArgs = new OrderCachedEventArgs {
							GetOrder = null,
							GetSuccess = true,
							Message = "Saving cache to file\n"
						};

						OnOrderCacheEvent.Invoke (this, cachedEventArgs);
					}

					this.Save ();

					/*
					if (!auts_list.Any ()) {
						continue;
					}*/



				}



			} catch (Exception ex) when (ex is OperationCanceledException || ex is TaskCanceledException) {

#if DEBUG
				if (DebugIhildaWallet.AccountSequenceCache) {
					Logging.ReportException (method_sig, ex);
				}
#endif
				return;
			}

		}


		public Dictionary<String, AutomatedOrder> SequenceCache;

		public Dictionary<String, AutomatedOrder> Load ()
		{


			//var settingsPath = FileHelper.GetSettingsPath (account + settingsFileName);
			string str = null;
			str = FileHelper.GetJsonConf (settingsPath);
			if (str == null) {
				return null;
			}
			ConfStruct jsconf = null;

			try {
				jsconf = DynamicJson.Parse (str);

			} catch (Exception e) {
				Logging.WriteLog (e?.Message + e?.StackTrace);
				return null;
			}

			if (jsconf == null) {
				return null;
			}

			IEnumerable<AutomatedOrder> ords = jsconf?.Orders;

			if (ords == null || !ords.Any ()) {
				return null;
			}


			Dictionary<String, AutomatedOrder> orderDict = null;

			if (ProgramVariables.preferLinq) {
				orderDict = ords.ToDictionary ((AutomatedOrder arg) => arg.Bot_ID, (AutomatedOrder arg) => arg);

			} else {
				orderDict = new Dictionary<String, AutomatedOrder> ();
				foreach (AutomatedOrder order in ords) {
					string key = order.Bot_ID;

					if (key != null) {
						//orderDict.TryAdd (key, order);
						orderDict.Add (key, order);
					}
				}
			}

			//KeyValuePair<String, AutomatedOrder> valuePair = 





			/*
				   
			*/
			return orderDict;

			//lock (lockSeq) {







			//}


		}




		private class ConfStruct
		{
			public ConfStruct (IEnumerable<AutomatedOrder> ords)
			{


				if (ords == null) {
					return;
				}
				Orders = ords;
				this.Orders = ords.ToArray ();

				/*
				int count = ords.Count ();

				var it = ords.GetEnumerator ();



				this.Orders = new AutomatedOrder [count];

				for (int i = 0; i < count; i++) {
					it.MoveNext ();
					Orders [i] = it.Current;

				}
				
				*/			

			}

			public ConfStruct ()
			{

			}


			public IEnumerable <AutomatedOrder> Orders {
				get;
				set;
			}

			/*
			public int latestLedger {
				get;
				set;
			}
			*/

		}


		public static void DeleteSettingsFile (string account)
		{
			var settingsPath = FileHelper.GetSettingsPath (account + settingsFileName);
			//lock (lockobj) {

				if (File.Exists (settingsPath)) {
					File.Delete (settingsPath);
				}
			//}

		}

		public void Save ()
		{
			IEnumerable<AutomatedOrder> offers = null;
			string conf = null;
			lock (lockSeq) {

				offers = this.SequenceCache?.Values;

				if (offers == null) {
					return;
				}
				//var settingsPath = FileHelper.GetSettingsPath (actualSettingsFileName);

				ConfStruct confstruct = new ConfStruct (offers);

				conf = DynamicJson.Serialize (confstruct);
			}

			if (conf == null) {
				return;
			}

			FileHelper.SaveConfig (settingsPath, conf);
			
		}

#pragma warning disable IDE0044 // Add readonly modifier
		private object lockSeq = new object ();
#pragma warning restore IDE0044 // Add readonly modifier

		public event EventHandler<OrderCachedEventArgs> OnOrderCacheEvent;

		public const string settingsFileName = "OrderManagementBot.jsn";
		public string actualSettingsFileName = null;
		public string settingsPath = null;
#if DEBUG
		public const string clsstr = nameof (OrderManagementBot) + DebugRippleLibSharp.both_parentheses;
#endif

	}



	public class OrderCachedEventArgs : EventArgs
	{

		public bool UIpump {
			get;
			set;
		}

		public bool GetSuccess {
			get;
			set;
		}

		public Offer GetOrder {
			get;
			set;
		}

		public string Message {
			get;
			set;
		}

	}

}
