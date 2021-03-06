﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Gtk;
using IhildaWallet.Networking;
using IhildaWallet.Util;
using RippleLibSharp.Commands.Accounts;
using RippleLibSharp.Keys;
using RippleLibSharp.Network;
using RippleLibSharp.Result;
using RippleLibSharp.Transactions;
using RippleLibSharp.Transactions.TxTypes;
using RippleLibSharp.Trust;
using RippleLibSharp.Util;

namespace IhildaWallet
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class DividendWidget : Gtk.Bin
	{
		public DividendWidget ()
		{
			this.Build ();

			//bool sen = false;

			/*
			mincheckbox.Sensitive = sen;
			maxcheckbox.Sensitive = sen;
			mincomboboxentry.Sensitive = sen;
			maxcomboboxentry.Sensitive = sen;
			sharetickercomboboxentry.Sensitive = sen;
			shareIssuerComboboxentry.Sensitive = sen;
			label4.Sensitive = sen;
			label3.Sensitive = sen;
			*/

			mincheckbox.Clicked += (object sender, EventArgs e) => {
				bool sensitive = mincheckbox.Active;
				mincomboboxentry.Sensitive = sensitive;
			};

			maxcheckbox.Clicked += (object sender, EventArgs e) => {
				bool sensitive = maxcheckbox.Active;
				maxcomboboxentry.Sensitive = sensitive;
			};

			this.includecheckbox.Clicked += (object sender, EventArgs e) => {
				filechooserbutton1.Sensitive = this.includecheckbox.Active;
			};

			this.excludecheckbox.Clicked += (object sender, EventArgs e) => {
				filechooserbutton2.Sensitive = this.excludecheckbox.Active;
			};

			button217.Clicked += Button217_Clicked;

			sharetickercomboboxentry.Changed += (object sender, EventArgs e) => {

				sharetictokensource?.Cancel ();
				sharetictokensource = new CancellationTokenSource ();
				var token = sharetictokensource.Token;

				string str = sharetickercomboboxentry.ActiveText;
				if (RippleCurrency.NativeCurrency == str) {
					this.shareissuercomboboxentry.Entry.Text = "";
					this.shareissuercomboboxentry.Visible = false;
					this.label4.Visible = false;
					return;
				}

				this.shareissuercomboboxentry.Visible = true;
				this.label4.Visible = true;

				Task.Run (delegate {

					NetworkInterface networkInterface = NetworkController.GetNetworkInterfaceNonGUIThread ();
					if (networkInterface == null) {
						return;
					}
					string account = _rippleWallet?.GetStoredReceiveAddress ();
					if (account == null) {
						return;
					}
					IEnumerable<string> issuers = AccountLines.GetIssuersForCurrency (str, account, networkInterface, token);



					SetShareComboIssuers (issuers);


				}, token);
			};

			divcurcomboboxentry.Changed += (object sender, EventArgs e) => {

				divCurrTokenSource?.Cancel ();
				divCurrTokenSource = new CancellationTokenSource ();
				var token = divCurrTokenSource.Token;

				string str = divcurcomboboxentry.ActiveText;
				if (RippleCurrency.NativeCurrency == str) {
					this.divissuercomboboxentry.Entry.Text = "";
					this.divissuercomboboxentry.Visible = false;
					this.label8.Visible = false;
					return;
				}

				this.divissuercomboboxentry.Visible = true;
				this.label8.Visible = true;

				Task.Run (delegate {

					NetworkInterface networkInterface = NetworkController.GetNetworkInterfaceNonGUIThread ();
					if (networkInterface == null) {
						return;
					}
					string account = _rippleWallet?.GetStoredReceiveAddress ();
					if (account == null) {
						return;
					}
					IEnumerable<string> issuers = AccountLines.GetIssuersForCurrency (str, account, networkInterface, token);



					SetDivComboIssuers (issuers);


				});

			};

			divissuercomboboxentry.Changed += DivIssuercomboboxentry_Changed;

			shareissuercomboboxentry.Changed += ShareIssuerComboboxentry_Changed;

			button114.Clicked += PercentageClicked;
			button115.Clicked += PercentageClicked;
			button111.Clicked += PercentageClicked;
			button112.Clicked += PercentageClicked;

			button123.Clicked += PercentageClicked;
			button113.Clicked += PercentageClicked;
			button119.Clicked += PercentageClicked;

			button116.Clicked += PercentageClicked;

			button120.Clicked += PercentageClicked;

			button117.Clicked += PercentageClicked;

			button118.Clicked += PercentageClicked;

			button121.Clicked += PercentageClicked;

			button122.Clicked += PercentageClicked;
			hscale2.ValueChanged += Hscale2_ValueChanged;

		}

		void Hscale2_ValueChanged (object sender, EventArgs e)
		{
#if DEBUG
			string method_sig = clsstr + nameof (Hscale2_ValueChanged) + DebugRippleLibSharp.colon;
#endif
			double val = hscale2.Value;

			string cur = divcurcomboboxentry?.Entry?.Text;

			if (cur == null) {

				string message = "Must set sending currency to use percentage shortcuts";
				if (ProgramVariables.darkmode) {
					divcurcomboboxentry.ModifyBase (StateType.Normal, new Gdk.Color (0xff, 0xAA, 0xBB));

					infobar.Text = "<span fgcolor=\"#FFAABB\">" + message + "</span>";

				} else {
					divcurcomboboxentry.ModifyBase (StateType.Normal, new Gdk.Color (0xFF, 0x00, 0x00));
					infobar.Text = "<span fgcolor=\"#Red\">" + message + "</span>";
				}
				return;
			}



			string issuer = divissuercomboboxentry?.Entry?.Text;

			if (!RippleCurrency.NativeCurrency.Equals (cur) && issuer == null) {

				string message = "Must set issuer to use percentage shortcuts for non xrp currencies";
				if (ProgramVariables.darkmode) {
					divissuercomboboxentry.ModifyBase (StateType.Normal, new Gdk.Color (0xff, 0xAA, 0xBB));

					infobar.Text = "<span fgcolor=\"#FFAABB\">" + message + "</span>";

				} else {
					divissuercomboboxentry.ModifyBase (StateType.Normal, new Gdk.Color (0xFF, 0x00, 0x00));
					infobar.Text = "<span fgcolor=\"#Red\">" + message + "</span>";
				}

				return;
			}


			Task.Run (delegate {
				ScaleMethod (val, cur, issuer);
			});

		}

		public void ScaleMethod (double value, string currency, string issuer)
		{
#if DEBUG
			string method_sig = clsstr + nameof (ScaleMethod) + DebugRippleLibSharp.colon;

#endif

			string acc = _rippleWallet.Account;



			NetworkInterface ni = NetworkController.GetNetworkInterfaceNonGUIThread ();

			CancellationTokenSource tokenSource = new CancellationTokenSource ();
			CancellationToken token = tokenSource.Token;


			if (!RippleCurrency.NativeCurrency.Equals (currency)) {
				var cur = AccountLines.GetBalanceForIssuer
				(
					currency,
					issuer,
					acc,
					ni,
					token
				);

				double bal = (double)cur.amount;

				double res = bal * value / 100;




				var ss = res.ToString ();
				Gtk.Application.Invoke (
				delegate {

					amountcomboboxentry.Entry.Text = ss;
				});

			} else {

				Task<Response<AccountInfoResult>> task =
					AccountInfo.GetResult (acc, ni, token);

				task.Wait (token);

				Response<AccountInfoResult> resp = task.Result;
				AccountInfoResult res = resp.result;

				RippleCurrency reserve = res.GetReserveRequirements (ni, token);

				RippleCurrency rippleCurrency = new RippleCurrency (res.account_data.Balance);

				double bal = (double)(rippleCurrency.amount - reserve.amount) / 1000000 * value / 100;



				string ss = bal.ToString ();
				Gtk.Application.Invoke (delegate {
					amountcomboboxentry.Entry.Text = ss;
				});
			}

		}

		void PercentageClicked (object sender, EventArgs e)
		{
			if (sender is Button b) {
				string s = b?.Label.TrimEnd ('%');
				double d = Convert.ToDouble (s);

				hscale2.Value = d;
			}
		}


		private CancellationTokenSource sharetictokensource = null;
		private CancellationTokenSource shareIssTokenSource = null;
		private CancellationTokenSource divCurrTokenSource = null;
		private CancellationTokenSource divIssTokenSource = null;

		void ShareIssuerComboboxentry_Changed (object sender, EventArgs e)
		{

#if DEBUG
			string method_sig = clsstr + nameof (ShareIssuerComboboxentry_Changed) + DebugRippleLibSharp.both_parentheses;


			if (DebugIhildaWallet.DividendWidget) {
				Logging.WriteLog (method_sig + DebugRippleLibSharp.beginn);
			}
#endif

			shareIssTokenSource?.Cancel ();
			shareIssTokenSource = new CancellationTokenSource ();
			var token = shareIssTokenSource.Token;

			string str = shareissuercomboboxentry.ActiveText;

			string account = null;

			try {
				account = new RippleAddress (str).ToString ();

			} catch (Exception ex) {

#if DEBUG
				if (DebugIhildaWallet.DividendWidget) {
					Logging.ReportException (method_sig, ex);
				}
#endif
				// TODO

				return;
			}

			if (account == null) {
				return;
			}

			Task.Run (delegate {
				NetworkInterface networkInterface = NetworkController.GetNetworkInterfaceNonGUIThread ();
				if (networkInterface == null) {
					return;
				}

				Task<Response<AccountCurrenciesResult>> task = AccountCurrencies.GetResult (account, networkInterface, token);
				if (task == null) {
					return;
				}
				task.Wait (token);

				Response<AccountCurrenciesResult> response = task.Result;
				if (response == null) {
					// TODO
					return;
				}

				AccountCurrenciesResult accountCurrenciesResult = response.result;

				if (accountCurrenciesResult == null) {
					// TODO
					return;
				}

				string [] currencies = accountCurrenciesResult?.send_currencies;
				if (currencies == null) {
					return;
				}

				if (!currencies.Any ()) {
					return;
				}

				SetTickerCurrencies (currencies);

			});
		}


		void DivIssuercomboboxentry_Changed (object sender, EventArgs e)
		{

#if DEBUG
			string method_sig = clsstr + nameof (DivIssuercomboboxentry_Changed) + DebugRippleLibSharp.both_parentheses;
			if (DebugIhildaWallet.DividendWidget) {
				Logging.WriteLog (method_sig + DebugRippleLibSharp.beginn);
			}
#endif

			divIssTokenSource?.Cancel ();
			divIssTokenSource = new CancellationTokenSource ();
			var token = divIssTokenSource.Token;

			string str = divissuercomboboxentry.ActiveText;
			string account = null;

			try {
				account = new RippleAddress (str).ToString ();

			} catch (Exception ex) {

#if DEBUG
				if (DebugIhildaWallet.DividendWidget) {
					Logging.ReportException (method_sig, ex);
				}
#endif
				// TODO

				return;
			}

			if (account == null) {
				return;
			}

			Task.Run (delegate {
				NetworkInterface networkInterface = NetworkController.GetNetworkInterfaceNonGUIThread ();
				if (networkInterface == null) {
					return;
				}

				Task<Response<AccountCurrenciesResult>> task = AccountCurrencies.GetResult (account, networkInterface, token);
				if (task == null) {
					return;
				}
				task.Wait (token);

				Response<AccountCurrenciesResult> response = task.Result;
				if (response == null) {
					// TODO
					return;
				}

				AccountCurrenciesResult accountCurrenciesResult = response.result;

				if (accountCurrenciesResult == null) {
					// TODO
					return;
				}

				string [] currencies = accountCurrenciesResult?.send_currencies;
				if (currencies == null) {
					return;
				}

				if (!currencies.Any ()) {
					return;
				}

				SetDivCurrencies (currencies);

			});
		}

		public void SetDivCurrencies (IEnumerable<String> currencies)
		{
			if (currencies == null) {
				return;
			}

			if (!currencies.Any ()) {
				return;
			}

			Application.Invoke (delegate {
				ListStore store = new ListStore (typeof (string));

				foreach (String s in currencies) {
					store.AppendValues (s);
				}

				this.divcurcomboboxentry.Model = store;


			});
		}


		/*void ShareIssuercomboboxentry_Changed (object sender, EventArgs e)
		{
			string str = shareIssuerComboboxentry.ActiveText;
			string account = null;

			try {
				account = new RippleAddress (str).ToString ();

			} catch (Exception ex) {
				// TODO

				return;
			}

			if (account == null) {
				return;
			}

			Task.Run (delegate {
				NetworkInterface networkInterface = NetworkController.GetNetworkInterfaceNonGUIThread ();
				if (networkInterface == null) {
					return;
				}

				Task<Response<AccountCurrenciesResult>> task = AccountCurrencies.GetResult (account, networkInterface);
				if (task == null) {
					return;
				}
				task.Wait ();

				Response<AccountCurrenciesResult> response = task.Result;
				if (response == null) {
					// TODO
					return;
				}

				AccountCurrenciesResult accountCurrenciesResult = response.result;

				if (accountCurrenciesResult == null) {
					// TODO
					return;
				}

				string [] currencies = accountCurrenciesResult?.send_currencies;
				if (currencies == null) {
					return;
				}

				if (!currencies.Any ()) {
					return;
				}

				SetTickerCurrencies (currencies);
			});
		} */

		public void SetTickerCurrencies (IEnumerable<String> currencies)
		{
			if (currencies == null) {
				return;
			}

			if (!currencies.Any ()) {
				return;
			}

			Application.Invoke (delegate {
				ListStore store = new ListStore (typeof (string));

				foreach (String s in currencies) {
					store.AppendValues (s);
				}

				this.sharetickercomboboxentry.Model = store;


			});
		}


		public void SetShareComboIssuers (IEnumerable<string> issuers)
		{

			if (issuers == null) {
				return;
			}

			if (!issuers.Any()) {
				// TODO infobar
				return;
			}


			Application.Invoke (delegate {
				ListStore store = new ListStore (typeof (string));

				foreach (String s in issuers) {
					store.AppendValues (s);
				}

				this.shareissuercomboboxentry.Model = store;


			});
		}



		public void SetDivComboIssuers (IEnumerable<string> issuers)
		{

			if (issuers == null) {
				return;
			}

			if (!issuers.Any()) {
				// TODO infobar
				return;
			}


			Application.Invoke (delegate {
				ListStore store = new ListStore (typeof (string));

				foreach (String s in issuers) {
					store.AppendValues (s);
				}

				this.divissuercomboboxentry.Model = store;


			});
		}

		void Button217_Clicked (object sender, EventArgs eventArgs)
		{
#if DEBUG
			string method_sig = clsstr + nameof (Button217_Clicked) + DebugRippleLibSharp.both_parentheses;
			if (DebugIhildaWallet.DividendWidget) {
				Logging.WriteLog (method_sig + DebugRippleLibSharp.beginn);
			}
#endif


			bool reqInc = includecheckbox.Active;
			bool reqEx = excludecheckbox.Active;
			string file1 = null;
			string file2 = null;


			bool isMin = mincheckbox.Active;
			bool isMax = maxcheckbox.Active;

			Decimal? min = null;
			Decimal? max = null;

			TokenRequires tokenRequires = GetTokenRequires ();


			if (reqInc) {
				file1 = filechooserbutton1.Filename;
				if (string.IsNullOrWhiteSpace(file1)) {
					// TODO
					return;
				}
			}

			if (reqEx) {
				file2 = filechooserbutton2.Filename;
				if (string.IsNullOrWhiteSpace(file2)) {
					// TODO
					return;
				}
			}


			string amountStr = amountcomboboxentry.ActiveText;
			if (string.IsNullOrWhiteSpace (amountStr)) {
				// TODO
				return;
			}

			Decimal? amount = RippleCurrency.ParseDecimal (amountStr);
			if (amount == null) {
				return;
			}

			string divIssuer = divissuercomboboxentry.ActiveText;
			if (string.IsNullOrWhiteSpace (divIssuer)) {
				// TODO 
				return;
			}

			RippleAddress issuerAddress = null;
			try {
				issuerAddress = new RippleAddress (divIssuer);
			} catch (Exception e) {

#if DEBUG
				if (DebugIhildaWallet.DividendWidget) {
					Logging.ReportException (method_sig, e);
				}
#endif


				return;
			}

			if (issuerAddress == null) {
				// TODO. Will unrechable cose anyway
				return;
			}

			string divcur = divcurcomboboxentry.ActiveText;
			if (string.IsNullOrWhiteSpace (divcur)) {
				return;
			}



			RippleCurrency rippleCurrency = new RippleCurrency ((Decimal)amount, issuerAddress, divcur);

			if (isMin) {
				string minstr = mincomboboxentry.ActiveText;
				min = RippleCurrency.ParseDecimal (minstr);

				if (min == null) {
					// TODO if they checked the box they must enter a valid value. 
					return;
				}
			}

			if (isMax) {
				string maxstr = maxcomboboxentry.ActiveText;
				max = RippleCurrency.ParseDecimal (maxstr);
				if (max == null) {
					return;
				}
			}

			Task.Run (
				delegate {
					IEnumerable<Tuple <string, Decimal>> holders = GetTokenRequiresAccounts (tokenRequires);
					IEnumerable<string> includes = null;
					IEnumerable<string> excludes = null;
					if (reqEx) {
						//excludes = File.ReadLines (file2);
						excludes = File.ReadAllLines (file2);
						StringBuilder stringBuild = new StringBuilder ();
						foreach (string s in excludes) {
							stringBuild.AppendLine (s);

							try {
								RippleAddress rippleAddress = new RippleAddress (s);

							} catch (Exception e) {

#if DEBUG
								if (DebugIhildaWallet.DividendWidget) {
									Logging.ReportException (method_sig, e);
								}
#endif


								// TODO
								string title = "invalid address";
								string message = "Invalid address in exclude list file";
								MessageDialog.ShowMessage (title, message);
								return;
							}
						}

						//MessageDialog.ShowMessage ("Excludes", stringBuild.ToString ());


					}

					if (reqInc) {


						//includes = File.ReadLines (file1);
						includes = File.ReadAllLines (file1);
						StringBuilder stringB = new StringBuilder ();
						foreach (string s in includes) {
							stringB.AppendLine (s);

							try {
								RippleAddress rippleAddress = new RippleAddress (s);
							} catch (Exception e) {

#if DEBUG
								if (DebugIhildaWallet.DividendWidget) {
									Logging.ReportException (method_sig, e);
								}
#endif


								// TODO 
								string title = "invalid address";
								string message = "Invalid address in include list file";
								MessageDialog.ShowMessage (title, message);
								return;
							}
						}

						//MessageDialog.ShowMessage ("Includes", stringB.ToString ());



					}



				
					StringBuilder stringBuilder = new StringBuilder ();
					foreach (Tuple <string, Decimal > holder in holders) {
						stringBuilder.AppendLine (holder.Item1.ToString() + " " + holder.Item2);
					}

					//MessageDialog.ShowMessage ("Addresses", stringBuilder.ToString ());

						





					DoLogic (holders, includes, excludes, rippleCurrency, min, max);
				}
			);
		}

		public void DoLogic (IEnumerable<Tuple<string,Decimal>> tokenShare, IEnumerable<string> includes, IEnumerable<string> excludes, RippleCurrency rippleCurrency, Decimal? min, Decimal? max )
		{

			if (tokenShare == null) {
				// TODO
				return;
			}


			/*
			IEnumerable <Tuple<string, Decimal>> v = 
				from x in tokenShare where
			 x != null
			 && (includes == null || includes.Contains (x.Item1))
			 && (excludes == null || !excludes.Contains (x.Item1))
				&& ((min == null ) || (x.Item2 >= min))
				&& ((max == null) || (x.Item2 <= max))
				select x;
				*/
			if (includes != null) {
				tokenShare = from x in tokenShare where includes.Contains (x.Item1) select x;
			}

			if (excludes != null) {
				tokenShare = from x in tokenShare where !excludes.Contains (x.Item1) select x;
			}

			if (min != null) {
				tokenShare = from x in tokenShare where x.Item2 >= min select x;
			}

			if (max != null) {
				tokenShare = from x in tokenShare where x.Item2 <= max select x;
			}

			Decimal totalShare = (from x in tokenShare select x.Item2).Sum ();

			Decimal perShare = rippleCurrency.amount / totalShare;

			IEnumerable <RipplePaymentTransaction> paymentTransactions = from x in tokenShare 
				select new RipplePaymentTransaction () {						 
					Account = _rippleWallet.GetStoredReceiveAddress (),

					Amount = new RippleCurrency (x.Item2 * perShare, rippleCurrency.issuer, rippleCurrency.currency),
					Destination = x.Item1
			};

			LicenseType licenseT = Util.LicenseType.DIVIDEND;
			if (LeIceSense.IsLicenseExempt (rippleCurrency)) {
				licenseT = LicenseType.NONE;
			}

			Application.Invoke ( delegate {
				PaymentSubmitWindow paymentSubmitWindow = new PaymentSubmitWindow (_rippleWallet, licenseT);
				paymentSubmitWindow.SetPayments (paymentTransactions);
			});

		}

		public TokenRequires GetTokenRequires ()
		{


			Decimal? min = null;
			Decimal? max = null;

			if (mincheckbox.Active) {
				String minStr = mincomboboxentry.ActiveText;
				min = RippleCurrency.ParseDecimal (minStr);
				if (min == null) {
					return null;

				}

			}

			if (maxcheckbox.Active) {
				String maxStr = maxcomboboxentry.ActiveText;
				max = RippleCurrency.ParseDecimal (maxStr);
				if (max == null) {
					return null;
				}
			}


			TokenRequires tokenRequires = new TokenRequires {
				ShareIssuer = shareissuercomboboxentry.ActiveText,
				ShareTick = sharetickercomboboxentry.ActiveText,
				MinAmount = min,
				MaxAmount = max
			};




			return tokenRequires;
		}

		public IEnumerable<Tuple <string, Decimal>> GetTokenRequiresAccounts (TokenRequires tokenRequires)
		{
			NetworkInterface networkInterface = NetworkController.GetNetworkInterfaceNonGUIThread ();

			// TODO investigate possibly using a real cancellation token
			IEnumerable<Response<AccountLinesResult>> results = AccountLines.GetResultFull (tokenRequires.ShareIssuer, networkInterface, new CancellationToken());

			List< Tuple <string, Decimal> > assetHolders = new List< Tuple <string, Decimal>> ();

			foreach (Response<AccountLinesResult> response in results) {
				if (response == null) {
					throw new NotImplementedException ();
				}
				if (response.HasError ()) {
					// TODO
					throw new NotImplementedException ();
				}

				AccountLinesResult accountLinesResult = response.result;


				if (accountLinesResult == null) {
					return null;
				}

				TrustLine [] lines = accountLinesResult.lines;
				if (lines == null) {
					// TODO implement all these error cases.
					return null;
				}
				foreach (TrustLine v in lines) {
					if (v == null) {
						throw new NotImplementedException ();
					}
					Decimal balance = v.GetBalanceAsDecimal ();
					if (balance < 0) {
						string acc = v.account;
						if (acc == null) {
							
						}


						// TODO math.abs balance
						Tuple<string, Decimal> tuple = new Tuple<string, decimal> (acc, Math.Abs(balance));

						assetHolders.Add (tuple);
					}
				}
			}


			return assetHolders;

		}

		public void SetRippleWallet (RippleWallet rippleWallet)
		{
			this._rippleWallet = rippleWallet;
		}

		private RippleWallet _rippleWallet {
			get;
			set;
		}

#if DEBUG
		private const string clsstr = nameof (DividendWidget) + DebugRippleLibSharp.colon;
#endif
	}
}

