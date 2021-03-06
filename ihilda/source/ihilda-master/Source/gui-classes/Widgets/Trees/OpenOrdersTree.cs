﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

using Gtk;
using IhildaWallet.Networking;
using RippleLibSharp.Commands.Accounts;
using RippleLibSharp.Keys;
using RippleLibSharp.Network;
using RippleLibSharp.Result;
using RippleLibSharp.Transactions;
using RippleLibSharp.Transactions.TxTypes;
using RippleLibSharp.Util;
using System.Text;

namespace IhildaWallet
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class OpenOrdersTree : Gtk.Bin
	{
		public OpenOrdersTree ()
		{
			this.Build ();
			listStore = new ListStore (
				typeof (string), // #
				typeof (bool), // select
				typeof (string), // buy
				typeof (string),  // sell
				typeof (string),  // price
				typeof (string),   // cost
				typeof (string), // marking
				typeof (string),   //status
				typeof (string));  // result

			CellRendererToggle toggle = new CellRendererToggle {
				Activatable = true
			};

			toggle.Toggled += ItemToggled;

			CellRendererText txtr = new CellRendererText {
				Editable = false
			};


			treeview1.AppendColumn ("#", txtr, "markup", 0);
			treeview1.AppendColumn ("Select", toggle, "active", 1);

			//this.treeview1.AppendColumn ("<span fgcolor=\"green\">Buy</span>", txtr, "markup", 1);

			this.treeview1.AppendColumn ("Buy", txtr, "markup", 2);
			this.treeview1.AppendColumn ("Sell", txtr, "markup", 3);
			this.treeview1.AppendColumn ("Price", txtr, "markup", 4);
			this.treeview1.AppendColumn ("Cost", txtr, "markup", 5);
			this.treeview1.AppendColumn ("Marking", txtr, "markup", 6);
			this.treeview1.AppendColumn ("Status", txtr, "markup", 7);
			this.treeview1.AppendColumn ("Result", txtr, "markup", 8);

			this.treeview1.ButtonReleaseEvent += (object o, ButtonReleaseEventArgs args) => {

#if DEBUG
				if (DebugIhildaWallet.OpenOrdersTree) {
					Logging.WriteLog ("ButtonReleaseEvent at x=" + args.Event.X.ToString () + " y=" + args.Event.Y.ToString ());
				}

#endif

				int x = Convert.ToInt32 (args.Event.X);
				int y = Convert.ToInt32 (args.Event.Y);
				if (!treeview1.GetPathAtPos (x, y, out TreePath path)) {
					return;
				}

				if (!listStore.GetIter (out TreeIter iter, path)) {
					return;
				}

				int index = path.Indices [0];

				AutomatedOrder ao = _offers [index];
				if (ao == null) {

					return;
				}

				if (args.Event.Button == 3) {

#if DEBUG
					Logging.WriteLog ("Right click \n");
#endif


					OrderRightClicked (ao, index);


				}
			};
		}

		public void SetIsSubmitted (string path, string message)
		{
			if (message == null)
				message = "";

			TextHighlighter highlighter = new TextHighlighter {
				Highlightcolor = ProgramVariables.darkmode ? TextHighlighter.CHARTREUSE : TextHighlighter.GREEN
			};
			string s = highlighter.Highlight (/*"Success : " + */message);

			Application.Invoke ((object sender, EventArgs e) => {
				if (listStore.GetIterFromString (out TreeIter iter, path)) {
					listStore.SetValue (iter, 7, s);
				}
			});

		}

		public void SetFailed (string path, string message)
		{
			TextHighlighter highlighter = new TextHighlighter ();

			highlighter.Highlightcolor = TextHighlighter.RED;
			string s = highlighter.Highlight (message ?? "failed");

			Gtk.Application.Invoke ((object sender, EventArgs e) => {
				if (listStore.GetIterFromString (out TreeIter iter, path)) {
					listStore.SetValue (iter, 7, s);
				}
			});

		}


		public void OrderRightClicked (AutomatedOrder ao, int index)
		{

			Gtk.Menu menu = new Menu ();

			Gtk.MenuItem cancel = new MenuItem ("Cancel");
			cancel.Show ();
			menu.Add (cancel);

			cancel.Activated += (object sender, EventArgs e) => {
#if DEBUG
				if (DebugIhildaWallet.OpenOrdersTree) {
					Logging.WriteLog ("Cancel order " + ao.index + " selected");
				}
#endif
				Task.Run (
					delegate {
						tokenSource = _parent.InitTokenSource ();

						_parent.SetInfoBar ( ao.index + ": Cancel order selected");

						NetworkInterface networkInterface = NetworkController.GetNetworkInterfaceNonGUIThread ();
						if (networkInterface == null || !networkInterface.IsConnected()) {
							_parent.SetInfoBar (ao.index + ": Unable to cancel order. No network connectivity");
						}



						PasswordAttempt passwordAttempt = new PasswordAttempt ();

						passwordAttempt.InvalidPassEvent += (object s, EventArgs ev) =>
						{
							bool shou = AreYouSure.AskQuestionNonGuiThread (
							"Invalid password",
							"Unable to decrypt seed. Invalid password.\nWould you like to try again?"
							);
						};

						passwordAttempt.MaxPassEvent += (object s, EventArgs ev) =>
						{
							string mess = "Max password attempts";

							MessageDialog.ShowMessage (mess);
							//WriteToOurputScreen ("\n" + mess + "\n");
						};


						// TODO token
						DecryptResponse response = passwordAttempt.DoRequest (_rippleWallet, new CancellationTokenSource().Token);




						RippleIdentifier rippleSeedAddress = response.Seed;
						if (rippleSeedAddress.GetHumanReadableIdentifier () == null) {

							return;

						}

						_parent.SetInfoBar (ao.index + ": Getting account sequence");
						uint se = Convert.ToUInt32 (AccountInfo.GetSequence (ao.Account, networkInterface, tokenSource.Token));


						//bool b = CancelOrderAtIndex ( _rippleWallet.GetStoredReceiveAddress(), se, networkInterface, rippleSeedAddress );
						CancelOrderAtIndex (_rippleWallet.GetStoredReceiveAddress (), index, se, networkInterface, rippleSeedAddress);
					}
				);




			};

			MenuItem similar = new MenuItem (
				"Select all orders buying "
				+ ao.TakerPays.currency
				+ " for "
				+ ao.TakerGets.currency);

			similar.Show ();
			menu.Add (similar);

			similar.Activated += (object sender, EventArgs e) => {
#if DEBUG
				if (DebugIhildaWallet.OpenOrdersTree) {

				}
#endif

				for (int i = 0; i < _offers.Length; i++) {
					string takerPaysCurrency1 = _offers [i]?.TakerPays?.currency;
					string takerPaysCurrency2 = ao?.TakerPays?.currency;
					string takerGetsCurrency1 = _offers [i]?.TakerGets?.currency;
					string takerGetsCurrency2 = ao?.TakerGets?.currency;
					if (takerPaysCurrency1 == null || takerPaysCurrency2 == null) {
						continue;
					}

					if (takerGetsCurrency1 == null || takerGetsCurrency2 == null) {
						continue;
					}

					_offers [i].Selected |= (takerPaysCurrency1.Equals (takerPaysCurrency2) &&
						takerGetsCurrency1.Equals (takerGetsCurrency2)
);


				}

				SetOffers (_offers);
			};



			MenuItem same = new MenuItem (
				"Select all orders buying "
				+ ao.TakerPays.ToString ()
				+ " for "
				+ ao.TakerGets.ToString ());

			same.Show ();
			menu.Add (same);

			same.Activated += (object sender, EventArgs e) => {
#if DEBUG
				if (DebugIhildaWallet.OpenOrdersTree) {

				}
#endif

				for (int i = 0; i < _offers.Length; i++) {
					string takerPaysCurrency1 = _offers [i]?.TakerPays?.currency;
					string takerPaysCurrency2 = ao?.TakerPays?.currency;
					string takerGetsCurrency1 = _offers [i]?.TakerGets?.currency;
					string takerGetsCurrency2 = ao?.TakerGets?.currency;

					string takerPaysIssuer1 = _offers [i]?.TakerPays?.issuer;
					string takerPaysIssuer2 = ao?.TakerPays?.issuer;
					string takerGetsIssuer1 = _offers [i]?.TakerGets?.issuer;
					string takerGetsIssuer2 = ao?.TakerGets?.issuer;


					if (takerPaysCurrency1 == null || takerPaysCurrency2 == null) {
						continue;
					}

					if (takerGetsCurrency1 == null || takerGetsCurrency2 == null) {
						continue;
					}

					if (takerPaysIssuer1 == null || takerPaysIssuer2 == null) {
						continue;
					}

					if (takerGetsIssuer1 == null || takerGetsIssuer2 == null) {
						continue;
					}

					_offers [i].Selected |= (takerPaysCurrency1.Equals (takerPaysCurrency2) &&
						takerGetsCurrency1.Equals (takerGetsCurrency2) &&
						takerPaysIssuer1.Equals (takerPaysIssuer2) &&
						takerGetsIssuer1.Equals (takerGetsIssuer2)
);


				}

				SetOffers (_offers);
			};

			menu.Popup ();

		}


		public bool CancelOrderAtIndex (string account, int index, uint sequence, NetworkInterface ni, RippleIdentifier rsa)
		{

#if DEBUG
			string method_sig = clsstr + nameof (CancelOrderAtIndex) + DebugRippleLibSharp.right_parentheses;
			if (DebugIhildaWallet.OrdersTreeWidget) {
				Logging.WriteLog (method_sig + DebugRippleLibSharp.beginn);
			}
#endif

			try {


			//

			retry:
				AutomatedOrder off = this._offers [index];
				String signingAccount = null;

				if (rsa is RippleSeedAddress se) {
					signingAccount = se.GetPublicRippleAddress ()?.ToString ();
				} else if (rsa is RipplePrivateKey privateKey) {
					signingAccount = privateKey.GetPublicKey ().GetAddress ();
				} else {

					string message = "Signing key type not supported";
					_parent.SetInfoBar (off.index + ": " + message);
					throw new NotSupportedException (message + "/n");
				}
				//rsa?.GetPublicRippleAddress ()?.ToString ();

				if (signingAccount == null) {
					string message = "Invalid signing address";
					MessageDialog.ShowMessage ("Invalid Seed", message);

					_parent.SetInfoBar (off.index + ": " + message);
					return false;
				}



				if (!signingAccount.Equals (off.Account) && account != off.Account) {
					MessageDialog.ShowMessage ("Wrong Wallet!!", "Order's master account does not belong to signing seed. ");
					//bool answ = AreYouSure.AskQuestion ();
					return false;
				}

				this.SetIsSubmitted (index.ToString (), "Queued");


				SignOptions opts = SignOptions.LoadSignOptions ();

				this.SetIsSubmitted (index.ToString (), "Requesting Fee");

				FeeSettings feeSettings = FeeSettings.LoadSettings ();
				feeSettings.OnFeeSleep += (object sender, FeeSleepEventArgs e) => {
					this.SetIsSubmitted (

						index.ToString (),

						"Fee "
						+ (string)(e?.FeeAndLastLedger?.Fee.ToString () ?? "null")
						+ " is too high, waiting on lower fee");
				};

				// TODO possibly use a real token
				ParsedFeeAndLedgerResp tupe = feeSettings.GetFeeAndLastLedgerFromSettings (ni, new CancellationToken ());

				if (tokenSource?.IsCancellationRequested == true) {

					this.SetFailed (index.ToString (), "Aborted");
					//stop = false;
					return false;
				}

				if (tupe == null) {
					this.SetFailed (index.ToString (), "Parsed Fee and Last ledger object nul");
					return false;
				}
				if (tupe.HasError) {
					this.SetFailed (index.ToString (), tupe.ErrorMessage);
					return false;
				}

				//UInt32 f = tupe.Item1; 
				UInt32 f = (UInt32)tupe.Fee;

				RippleCancelTransaction tx = new RippleCancelTransaction {
					Account = off.Account,

					OfferSequence = off.Sequence,

					fee = f.ToString (),

					Sequence = sequence // note: don't update se++ with forloop, update it with each order 

				};




				uint lls = 0;
				if (opts != null) {
					lls = opts.LastLedgerOffset;
				}

				if (lls < 5) {
					lls = SignOptions.DEFAUL_LAST_LEDGER_SEQ;
				}


				tx.LastLedgerSequence = (UInt32)tupe.LastLedger + lls;

				if (tx.fee.amount == 0) {
					this.SetFailed (index.ToString (), "Invalid Fee zero");
					throw new Exception ();
				}

				if (tx.Sequence == 0) {
					this.SetFailed (index.ToString (), "Invalid Sequence zero");
					throw new Exception ();
				}

				if (opts == null) {
					// TODO get user to choose and save choice
				}

				switch (opts.SigningLibrary) {
				case "Rippled":
					this.SetIsSubmitted (index.ToString (), "Signing using rpc");
					tx.SignLocalRippled (rsa);
					this.SetIsSubmitted (index.ToString (), "Signed rpc");
					break;
				case "RippleLibSharp":
					this.SetIsSubmitted (index.ToString (), "Signing using RippleLibSharp");
					tx.SignRippleLibSharp (rsa);
					this.SetIsSubmitted (index.ToString (), "Signed RippleLibSharp");
					break;
				case "RippleDotNet":
					this.SetIsSubmitted (index.ToString (), "Signing using RippleDotNet");
					tx.SignRippleDotNet (rsa);
					this.SetIsSubmitted (index.ToString (), "Signed RippleDotNet");
					break;
				default:
					throw new NotSupportedException ("Invalid sign option " + opts.SigningLibrary);
				}

				if (tokenSource?.IsCancellationRequested == true) {
					this.SetFailed (index.ToString (), "Aborted");
					//stop = false;
					return false;
				}



				Task<Response<RippleSubmitTxResult>> task = null;

				try {
					task = NetworkController.UiTxNetworkSubmit (tx, ni, new CancellationToken ());
					this.SetIsSubmitted (index.ToString (), "Submitted via websocket");
					task.Wait ();


				} catch (Exception e) {

					Logging.WriteLog (e.Message);
					this.SetFailed (index.ToString (), "Network Error");
					return false;
				}

				/*
				finally {
					//Logging.writeLog (method_sig + "sleep");
					// may or may not keep a slight delay here for orders to process
				}
				*/

				var r = task.Result;

				if (r == null || r.status == null || !r.status.Equals ("success")) {
					this.SetFailed (index.ToString (), "Error");
#if DEBUG
					if (DebugIhildaWallet.OrdersTreeWidget) {
						Logging.WriteLog ("Error canceling transaction ");
						Logging.WriteLog (tx.ToJson ());
					}
#endif


					return false;

				}



				RippleSubmitTxResult res = r.result;

				if (res == null) {

					this.SetFailed (index.ToString (), "Bug?");
					return false;
				}


				//tefPAST_SEQ

				Ter ter;

				try {
					ter = (Ter)Enum.Parse (typeof (Ter), res.engine_result, true);
					//ter = (Ter)Ter.Parse (typeof(Ter), een, true);

				} catch (ArgumentNullException exc) {
#if DEBUG
					if (DebugIhildaWallet.OrderPreviewSubmitWidget) {
						Logging.ReportException (method_sig, exc);
					}
#endif

					return false;
				} catch (OverflowException overFlowException) {
#if DEBUG
					if (DebugIhildaWallet.OrderPreviewSubmitWidget) {
						Logging.ReportException (method_sig, overFlowException);
					}
#endif

					return false;
				} catch (ArgumentException argumentException) {
#if DEBUG
					if (DebugIhildaWallet.OrderPreviewSubmitWidget) {
						Logging.ReportException (method_sig, argumentException);
					}
#endif


					return false;
				} catch (Exception e) {
#if DEBUG
					if (DebugIhildaWallet.OrderPreviewSubmitWidget) {
						Logging.ReportException (method_sig, e);
					}
#endif

					return false;
				}


				switch (ter) {

				/*
				case null:
					this.SetIsSubmitted (index.ToString (), "null");
					return false;
					*/

				case Ter.terQUEUED:
					Thread.Sleep (5);
					this.SetIsSubmitted (index.ToString (), res.engine_result);
					this._offers [index].Succeeded = true;
					return true;

				case Ter.tefALREADY:
				case Ter.tesSUCCESS:
					this.SetIsSubmitted (index.ToString (), res.engine_result);
					this._offers [index].Succeeded = true;
					return true;

				case Ter.terPRE_SEQ:
				case Ter.tefPAST_SEQ:
				case Ter.tefMAX_LEDGER:
					this.SetFailed (index.ToString (), res.engine_result);
					return false;

				case Ter.telCAN_NOT_QUEUE:
					this.SetFailed (index.ToString (), res.engine_result + " retrying");
					goto retry;

				case Ter.telINSUF_FEE_P:
					this.SetFailed (index.ToString (), res.engine_result);
					return false;

				case Ter.tecNO_ISSUER:
					this.SetFailed (index.ToString (), res.engine_result);
					return false;

				case Ter.tecUNFUNDED_OFFER:
					this.SetFailed (index.ToString (), res.engine_result);
					return false;

				case Ter.srcActMalformed:
					this.SetFailed (index.ToString (), res.engine_result);
					return false;

				default:
					this.SetIsSubmitted (index.ToString (), "Response not imlemented " + res.engine_result);
					return false;

				}




			}

#pragma warning disable 0168
			catch (Exception e) {
#pragma warning restore 0168


#if DEBUG
				if (DebugIhildaWallet.OrdersTreeWidget) {
					Logging.ReportException (method_sig, e);
				}
#endif

				this.SetFailed (index.ToString (), "EXception Thrown in code");
				return false;

			}

		}


		public void ClearOffers ()
		{
			this._offers = null;
			Application.Invoke ((object sender, EventArgs e) => {
				listStore.Clear ();
			});

		}

		public void SetOffers (IEnumerable<AutomatedOrder> offers)
		{

			int count = offers.Count ();

			this._offers = new AutomatedOrder [count];

			Gtk.Application.Invoke ((object sender, EventArgs e) => {
				listStore.Clear ();
				//});

				int index = 0;
				foreach (AutomatedOrder offer in offers) {

					AutomatedOrder order = new AutomatedOrder (offer) {
						Selected = offer.Selected,
						Succeeded = offer.Succeeded,
						// user viewable index is one greater than array index
						index = (index + 1).ToString()
					};

					Decimal price = order.TakerGets.GetNativeAdjustedPriceAt (order.TakerPays);
					Decimal cost = order.TakerPays.GetNativeAdjustedPriceAt (order.TakerGets);
					price = Math.Round (price, 15);
					cost = Math.Round (cost, 15);
					this._offers [index++] = order;

					StringBuilder paysbuilder = new StringBuilder ();
					StringBuilder getsbuilder = new StringBuilder ();




					if (order.TakerPays != null) {

						paysbuilder.Append (order?.TakerPays?.currency ?? "null currency");
						paysbuilder.Append (" ");

						if (order.TakerPays.IsNative) {
							paysbuilder.AppendLine ((order?.TakerPays.amount / 1000000).ToString ());
						} else {
							paysbuilder.AppendLine (order?.TakerPays.amount.ToString ());
						}

						if (order?.taker_pays.issuer != null) {
							paysbuilder.Append (order?.taker_pays?.issuer);
						}
					} else {
						paysbuilder.Append ("taker pays is null");
					}

					if (order.TakerGets != null) {
						getsbuilder.Append (order?.TakerGets?.currency ?? "null currency");
						getsbuilder.Append (" ");

						if (order.TakerGets.IsNative) {
							getsbuilder.AppendLine ((order.taker_gets.amount / 1000000).ToString ());
						} else {
							getsbuilder.AppendLine (order.taker_gets.amount.ToString ());
						}
						if (order?.TakerGets?.issuer != null) {
							getsbuilder.Append (order?.taker_gets.issuer);
						}
					} else {

						getsbuilder.Append ("taker gets is null");
					}

					listStore.AppendValues (
						(index).ToString (),
						order.Selected,
						paysbuilder.ToString (),
						getsbuilder.ToString (),
						price.ToString (),
						cost.ToString (),
						order.BotMarking ?? "",
						order.Succeeded ? "Submitted" : "",
						""
					);

				}


				treeview1.Model = listStore;
			});


		}

		public void AppendOrders (AutomatedOrder [] offers)
		{
			int offset = 0;
			if (this._offers == null) {

				this._offers = new AutomatedOrder [offers.Length];
			} else {

				offset = this._offers.Length;
				var snew = new AutomatedOrder [offers.Length + offset];
				Array.Copy (_offers, snew, _offers.Length);
				this._offers = snew;


			}
			Gtk.Application.Invoke ((object sender, EventArgs e) => {
				//listStore.Clear ();

				for (int i = 0; i < offers.Length; i++) {

					AutomatedOrder o = new AutomatedOrder (offers [i]);

					Decimal price = o.TakerGets.GetNativeAdjustedPriceAt (o.TakerPays);
					Decimal cost = o.TakerPays.GetNativeAdjustedPriceAt (o.TakerGets);

					listStore.AppendValues (
						(i + 1).ToString (),
						o.Selected,
						o.TakerPays.ToString (),
						o.TakerGets.ToString (),
						price.ToString (),
						cost.ToString (),
						o?.BotMarking ?? "",
						"",
						"");

					//o.selected = true;

					this._offers [i + offset] = o;

				}


				treeview1.Model = listStore;
			});

		}


		private void ItemToggled (object sender, ToggledArgs args)
		{

			//string s = args.Path;
			int index = Convert.ToInt32 (args.Path);

			if (listStore.GetIterFromString (out TreeIter iter, args.Path)) {
				bool val = (bool)listStore.GetValue (iter, 1);
				listStore.SetValue (iter, 1, !val);


				_offers [index].Selected = !val;
			}
		}





		ListStore listStore;
		public AutomatedOrder [] _offers {
			get;
			set;
		}


		public void SetRippleWallet (RippleWallet rippleWallet)
		{
			this._rippleWallet = rippleWallet;
		}

		public void SetParent (OrdersTreeWidget parent)
		{
			this._parent = parent;
		}

		private OrdersTreeWidget _parent;

		private RippleWallet _rippleWallet {
			get { return _wallet; }
			set { _wallet = value; }
		}

		private RippleWallet _wallet = null;

		public CancellationTokenSource tokenSource = null;

#if DEBUG
		private const String clsstr = nameof (OpenOrdersTree) + DebugRippleLibSharp.colon;

#endif
	}
}

