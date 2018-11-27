/*
 *	License : Le Ice Sense 
 */

using System;
using System.Threading;
using System.Threading.Tasks;
using Gtk;
using System.Collections.Generic;
using Codeplex.Data;
using RippleLibSharp.Keys;
using RippleLibSharp.Transactions;
using RippleLibSharp.Transactions.TxTypes;
using RippleLibSharp.Network;
using IhildaWallet.Networking;
using RippleLibSharp.Result;
using RippleLibSharp.Commands.Accounts;
using RippleLibSharp.Util;
using IhildaWallet.Util;

namespace IhildaWallet
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class SendIOU : Gtk.Bin
	{
		public SendIOU ()
		{
#if DEBUG
			if (DebugIhildaWallet.SendIOU) {
				Logging.WriteLog ("SendIOU : const");
			}
#endif
			this.Build ();

#if DEBUG
			if (DebugIhildaWallet.SendIOU) {
				Logging.WriteLog ("SendIOU : Build complete");
			}
#endif

			// lol all these didn't work :/
			//this.currencycomboboxentry.Changed += new EventHandler (this.OnCurrencycomboboxentryChanged);
			//this.currencycomboboxentry.EditingDone += new EventHandler (this.OnCurrencycomboboxentryChanged);
			//this.currencycomboboxentry.SelectionReceived += //this.OnCurrencycomboboxentryChanged;
			this.currencycomboboxentry.Entry.Activated += this.OnCurrencycomboboxentryChanged;
			this.currencycomboboxentry.SelectionReceived += this.OnCurrencycomboboxentryReceived;
			this.currencycomboboxentry.Changed += this.OnCurrencycomboboxentryChanged;

			//this.currencycomboboxentry.PropertyNotifyEvent += new Gtk.PropertyNotifyEventHandler (this.OnCurrencycomboboxentryChanged);
			//this.currencycomboboxentry.SelectionNotifyEvent += OnCurrencycomboboxentryChanged;



			this.issuerentry.Entry.Activated += this.OnIssuerentryActivated;

			this.issuerentry.SelectionReceived += this.OnSelectionReceivedEvent;
			this.issuerentry.Changed += this.OnCurrencycomboboxentryChanged;
			//this.issuerentry.Changed
			this.amountentry.Activated += this.OnAmountentryActivated;
			this.sendMaxEntry.Activated += this.OnSendMaxEntryActivated;
			this.destinationentry.Activated += this.OnDestinationentryActivated;

			this.sendIOUButton.Clicked += this.OnSendIOUButtonClicked;
			//this.ChooseButton.Clicked += new EventHandler(this.OnChooseButtonClicked);




			Task.Factory.StartNew (async () => {

				while (!tokenSource.IsCancellationRequested) {
					await Task.Delay (30000, tokenSource.Token);
					Update ();
				};
			}
			);


		}

		~SendIOU ()
		{
			tokenSource.Cancel ();
			tokenSource.Dispose ();
		}

		private CancellationTokenSource tokenSource = new CancellationTokenSource();


//#pragma warning disable RECS0122 // Initializing field with default value is redundant
		//public static SendIOU currentInstance = null;
//#pragma warning restore RECS0122 // Initializing field with default value is redundant
		//private double highestLedger = 0;




		public void SendIOUPayment (String destination, decimal amount, String currency, String issuer, decimal sendmax)
		{
#if DEBUG
			if (DebugIhildaWallet.SendIOU) {
				Logging.WriteLog ("SendIOU : sendIOUPayment");

			}
#endif


			RippleWallet rw = _rippleWallet;

			if (rw == null) {
				// TODO debug
				return;
			}


			RippleAddress payee = null;
			RippleAddress issu = null;
			RippleAddress payer = rw.GetStoredReceiveAddress ();

			/*
			try {
				seed = new RippleSeedAddress(secret);


			} catch (Exception exc) {
				MessageDialog.showMessage("Invalid Secret\n" + exc.Message);
				return;
			}
			*/

			try {
				payee = new RippleAddress (destination);

			} catch (Exception exc) {
				MessageDialog.ShowMessage ("Invalid destination address\n" + exc.Message);
				return;
			}

			try {

				issu = new RippleAddress (issuer);

			} catch (Exception exc) {
				MessageDialog.ShowMessage ("Invalid currency issuer\n" + exc.Message);
				return;
			}

			try {

				payer = new RippleAddress (rw.GetStoredReceiveAddress ());
#if DEBUG
				if (DebugIhildaWallet.SendIOU) {
					Logging.WriteLog (payer.ToString ());
				}
#endif


			} catch (Exception exc) {
				MessageDialog.ShowMessage ("Invalid account address\n" + exc.Message);
				return;
			}


#if DEBUG
			if (DebugIhildaWallet.SendIOU) {
				Logging.WriteLog ("SendIOU : sendIOUPayment : preparing to send payment");
			}
#endif

			RippleCurrency amnt = new RippleCurrency (amount, issu, currency);


			RippleCurrency sndmx = null;


#if DEBUG
			if (DebugIhildaWallet.SendIOU) {
				Logging.WriteLog ("amnt = " + amnt.ToString () + ", dafee = " + ", sndmx = " + sndmx ?? "null");
			}
#endif

			RipplePaymentTransaction tx = new RipplePaymentTransaction (payer, payee, amnt, sndmx);
			if (part) {
				tx.flags |= tx.tfPartialPayment;
			}

			//RipplePaymentTransaction[] arr = new RipplePaymentTransaction[] { tx } ;

			LicenseType licenseT = Util.LicenseType.PAYMENT;
			if (LeIceSense.IsLicenseExempt (amnt) ) {
				licenseT = LicenseType.NONE;
			}

			Application.Invoke (
				delegate {
					PaymentSubmitWindow paymentWindow = new PaymentSubmitWindow (rw, licenseT);
					paymentWindow.SetPayments (tx);
					paymentWindow.Show ();
				}
			);



			/*
			 * 
			NetworkInterface ni = NetworkController.getNetworkInterfaceGuiThread();
			if (ni == null) {
				NetworkController.doNetworkingDialogNonGUIThread ();
				return;
			}

			SignOptions opts = SignOptions.loadSignOptions();
			uint lls = 0;
			if (opts != null) {
				lls = opts.lastLedgerOffset;
			}

			if (lls < 5) {
				lls = SignOptions.DEFAUL_LAST_LEDGER_SEQ;
			}

			rw.getStoredReceiveAddress();

			tx.autoRequestSequence (rw.getStoredReceiveAddress(), ni);
			Tuple<UInt32,UInt32> fs = FeeSettings.getFeeAndLastLedgerFromSettings (ni);
			if (fs == null) {
				return;
			}

			tx.fee = fs.Item1.ToString ();
			tx.LastLedgerSequence = fs.Item2 + lls;



			RippleSeedAddress rsa = rw.getDecryptedSeed ();

			if (opts.useLocalRippledRPC) {
				Logging.writeLog("Signing using rpc");
				tx.signLocalRippled (rsa);
				Logging.writeLog ("Signed rpc");
			}

			else {
				Logging.writeLog("Signing using RippleLibSharp");
				tx.sign(rsa);
				Logging.writeLog("Signed RippleLibSharp");

			}


			//tx.sign(rsa);

			Task< Response <RippleSubmitTxResult>> task = NetworkController.uiTxNetworkSubmit (tx, ni);
			task.Wait ();

			*/
		}


		public void Sendiou ()
		{
#if DEBUG
			if (DebugIhildaWallet.SendIOU) {
				Logging.WriteLog ("SendIOU : method sendIOU begin");
			}
#endif


			String issuer = this.issuerentry.ActiveText;


			String destination = this.destinationentry.Text;

			String amount = this.amountentry.Text;


			String currency = currencycomboboxentry.ActiveText;

			String sendmax = this.sendMaxEntry.Text;




			if (destination == null || destination.Trim ().Equals ("")) {
				MessageDialog.ShowMessage ("Please enter a destination address");
				return;
			}
			destination = destination.Trim ();

			if (currency == null || currency.Trim ().Equals ("")) {
				MessageDialog.ShowMessage ("Please choose a currency to send");
				return;
			}
			currency = currency.Trim ();

			if (amount == null || amount.Trim ().Equals ("")) {
				MessageDialog.ShowMessage ("Please enter an amount of " + currency + " to send");
			}
			amount = amount.Trim ();

			/* // Maybe I should allow self payments??
			if (account.Equals(destination)) {
				MessageDialog.showMessage ("You're trying to send to yourself?");
				return;
			}
			*/

#if DEBUG
			if (DebugIhildaWallet.SendIOU) {
				Logging.WriteLog (
					"SendIOU : method sendIOU() : " +


					"\n\tdestination = " + DebugIhildaWallet.ToAssertString (destination) +
					"\n\tamount = " + DebugIhildaWallet.ToAssertString (amount) +
					"\n\tcurrency = " + DebugIhildaWallet.ToAssertString (currency) +
					"\n\tissuer = " + DebugIhildaWallet.ToAssertString (issuer) +
					"\n\tsendmax = " + DebugIhildaWallet.ToAssertString (sendmax) + "\n"
					);
			}
#endif

			Thread th = new Thread (new ParameterizedThreadStart (SendIOUThread));

			ThreadParam par = new ThreadParam (amount, destination, currency, issuer, sendmax);

			th.Start (par);

		}

		private void SendIOUThread (object param)
		{
#if DEBUG
			if (DebugIhildaWallet.SendIOU) {
				Logging.WriteLog ("SendIOU : sendIOUThread begin");
			}

#endif


			Decimal max = 0;
			Decimal amountd = 0;

			if (!(param is ThreadParam tp)) {
				throw new InvalidCastException ("Unable to cast object to type threadParam");
			}

#if DEBUG
			if (DebugIhildaWallet.SendIOU) {

				//Logging.write("Units = " + tp.currency);

				Logging.WriteLog ("Send IOU : requesting Server Info\n");
			}
#endif

			//ServerInfoWidget.refresh_blocking ();

#if DEBUG
			if (DebugIhildaWallet.SendIOU) {
				//	Logging.writeLog ("Send IOU : refresh_blocking returned, ServerInfo.transaction_fee = " + ServerInfo.serverInfo.transaction_fee.ToString ());
			}
#endif


			//amountd = 


			Decimal? dee = RippleCurrency.ParseDecimal (tp.amount);





			if (dee != null) {
				amountd = (decimal)dee;
			} else {
				MessageDialog.ShowMessage ("Send Amount is not a valid Decimal");
				return;
			}

			if (amountd < 0) {
				MessageDialog.ShowMessage ("Sending negative amounts is not supported. Please enter a valid amount");
				return;
			}

			if (tp.sendmax == null) {
				tp.sendmax = "";
#if DEBUG
				if (DebugIhildaWallet.SendIOU) {
					Logging.WriteLog ("Setting sendmax to blank value because it was null");
				}
#endif
			}

			if (!("".Equals (tp.sendmax.Trim ()))) { // if sendmax is not blank


				Decimal? m = RippleCurrency.ParseDecimal (tp.sendmax.Trim ());  // and is a valid number
				MessageDialog.ShowMessage ("SendMax is formatted incorrectly");

				if (m == null) {
					return;
				}

				max = (Decimal)m;

			} else {
				max = amountd;
			}





			SendIOUPayment (tp.destination, amountd, tp.currency, tp.issuer, max);

		}

		private class ThreadParam
		{
			public ThreadParam (String amount, String destination, String currency, String issuer, String sendmax)
			{
				this.amount = amount;
				this.destination = destination;


				this.currency = currency;
				this.sendmax = sendmax;
				this.issuer = issuer;
			}

			public String amount;
			public String destination;

			public String currency;
			public String sendmax;
			public String issuer;
		}


		protected void OnSendIOUButtonClicked (object sender, EventArgs e)
		{

			Sendiou ();
		}

		/*
		protected void OnChooseButtonClicked (object sender, EventArgs e)
		{

		}
		*/


		public void UpdateBalance (string address)
		{

			CancellationToken token = tokenSource.Token;

			if (address == null) {
				return;
			}

			string cur = null;
			RippleAddress issuer = null;

			ManualResetEvent mre = new ManualResetEvent (false);
			mre.Reset ();

			Gtk.Application.Invoke (

				delegate {

					if (this.currencycomboboxentry == null) {
						// TODO bug

						return;
					}
					try {
						cur = this.currencycomboboxentry.ActiveText;

					}

#pragma warning disable 0168
					catch (Exception e) {
#pragma warning restore 0168
						cur = null;
						mre.Set ();
						return;
					}

					try {
						issuer = this.issuerentry.ActiveText;
					}

#pragma warning disable 0168
					catch (Exception e) {
#pragma warning restore 0168
						issuer = null;
					}
					mre.Set ();
				} // end delegate

			);  // end invoke

			mre.WaitOne ();
			WaitHandle.WaitAny (new [] { mre, token.WaitHandle });
			if (cur == null) {
				return;
			}


			NetworkInterface ni = NetworkController.CurrentInterface;

			if (ni == null) {
				return;
			}

			RippleCurrency result = null;

			string s = null;
			if (issuer == null) {
				Decimal d = AccountLines.GetCurrencyAsSingleBalance (address, cur, ni, token);
				s = d.ToString ();

			} else {

				result = AccountLines.GetBalanceForIssuer (cur, issuer, address, ni, token);
				s = result?.amount.ToString ();

			}

			Gtk.Application.Invoke ( (object sender, EventArgs e) => { 
				
				this.balancelabel.Text = s ?? "";
			
			} );





		} // end public void updateBalance

		private void UpdateCurrencyIssuers (RippleAddress rippleAddress)
		{

			CancellationToken token = tokenSource.Token;

			//RippleWallet rw = _rippleWallet;
			string address = rippleAddress;
			if (address == null) {
				return;
			}

			NetworkInterface ni = NetworkController.CurrentInterface;
			if (ni == null) {
				return;
			}

			ManualResetEvent manualResetEvent = new ManualResetEvent (false);
			manualResetEvent.Reset ();
			String cur = null;
			Gtk.Application.Invoke (delegate {
				if (ni == null) {
					return;
				}

				cur = this.currencycomboboxentry.ActiveText;
				manualResetEvent.Set ();






			});

			//manualResetEvent.WaitOne ();

			WaitHandle.WaitAny (new [] { manualResetEvent, token.WaitHandle });

			if (cur == null) {
				return;

			}

			List<String> lis = AccountLines.GetIssuersForCurrency (cur, address, ni, token);
			if (lis == null) {
				return;
			}

			if (lis.Count < 1) {
				// TODO infobar
				return;
			}

			Gtk.Application.Invoke (
				delegate {
					ListStore store = new ListStore (typeof (string));

					foreach (String s in lis) {
						store.AppendValues (s);
					}

					this.issuerentry.Model = store;

				}
			);

		}

		public void ClearUI () {
			Application.Invoke (
				delegate {

					balancelabel.Text = "";

				}
			);
		}

		public void Update ()
		{
			RippleAddress ra = _rippleWallet?.GetStoredReceiveAddress ();
			if (ra == null) {
				
				return;
			}
			this.UpdateCurrencies ();
			this.UpdateBalance (ra.ToString ());
			this.UpdateCurrencyIssuers (ra);

		}

		// no idea why this won't fire ????
		void OnCurrencycomboboxentryReceived (object sender, EventArgs e)
		{
			//MainWindow.currentInstance.getRippleWallet ();



			this.issuerentry.GrabFocus ();
			this.issuerentry.Entry.GrabFocus();

			Task.Run (
				(System.Action)Update
			);

		}

		protected void OnCurrencycomboboxentryChanged (object sender, EventArgs e)
		{	
			



			//this.issuerentry.GrabFocus ();
			//this.issuerentry.Entry.GrabFocus();

			Task.Run (
				(System.Action)Update
			);


		}

		protected void OnIssuerentryActivated (object sender, EventArgs e)
		{
			if (this.amountentry == null) {
				return;
			}

			this.amountentry.GrabFocus ();
		}

		protected void OnAmountentryActivated (object sender, EventArgs e)
		{
			if (sendMaxEntry==null) {
				// TODO
				return;
			}

			this.sendMaxEntry.GrabFocus ();
		}

		protected void OnDestinationentryActivated (object sender, EventArgs e)
		{
			if (this.sendIOUButton == null) {
				return;
			}

			this.sendIOUButton.GrabFocus ();
		}


		public void SetCurrencies (String[] currencies) {


			#if DEBUG
			String method_sig = clsstr + "setCurrencies (String[] currencies) : ";
			if (DebugIhildaWallet.SendIOU) {
				Logging.WriteLog(method_sig + "currencies = ", currencies);
			}
			#endif
			Gtk.Application.Invoke (delegate {
				#if DEBUG
				if (DebugIhildaWallet.SendIOU) {
					Logging.WriteLog(method_sig + "gtk invoke");
				}
				#endif

				ListStore store = new ListStore(typeof(string));


				if (currencies!=null) {
					foreach (String s in currencies) {

						store.AppendValues(s);

					}
				}


				this.currencycomboboxentry.Model = store;
				#if DEBUG
				if (DebugIhildaWallet.SendIOU) {
					Logging.WriteLog("chs");

				}
				#endif

			});
		}


		protected void OnSendMaxEntryActivated (object sender, EventArgs e)
		{
			if (this.destinationentry==null) {
				return;
			}

			this.destinationentry.GrabFocus ();
		}		


		void OnSelectionReceivedEvent (object sender, EventArgs e)
		{
			if (this.amountentry == null) {
				return;
			}

			this.amountentry.GrabFocus ();

			//throw new NotImplementedException ();
		}

		protected void Currencychanged (object sender, EventArgs e)
		{
			
			this.issuerentry.GrabFocus ();
			this.issuerentry.Entry.GrabFocus();

			Task.Run ((System.Action)Update);
		}



		public void SetRippleWallet (RippleWallet rippleWallet)
		{
			
			this._rippleWallet = rippleWallet;
			Update ();
		}

		private RippleWallet _rippleWallet {
			get;
			set;
		}

		static bool part = true;

		private void UpdateCurrencies ()
		{

			CancellationToken token = tokenSource.Token;
			string account = _rippleWallet?.GetStoredReceiveAddress ();
			if (account == null) {
				return;
			}

			NetworkInterface ni = NetworkController.CurrentInterface;
			if (ni == null) {
				return;
			}

			Task <Response <AccountCurrenciesResult>> task = AccountCurrencies.GetResult (account, ni, token);
			if (task == null) {
				return;
			}

			task.Wait (token);
			Response<AccountCurrenciesResult> response = task.Result;


			AccountCurrenciesResult accountCurrenciesResult = response.result;

			string[] sendCurrencies = accountCurrenciesResult.send_currencies;

			SetCurrencies ( sendCurrencies );
		}

		protected void Partialtoggled (object sender, EventArgs e)
		{
			if (sender is CheckButton c) {
				part = c.Active;
			}
		}

		private ListStore ListStoreObj {
			get;
			set;
		}

		#if DEBUG
		private static readonly string clsstr = nameof (Sendiou) + DebugRippleLibSharp.colon;
		#endif





	}
}

