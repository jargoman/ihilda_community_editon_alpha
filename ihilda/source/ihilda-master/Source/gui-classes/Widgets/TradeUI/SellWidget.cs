using System;
using System.Threading;
using System.Threading.Tasks;
using RippleLibSharp.Transactions;
using RippleLibSharp.Transactions.TxTypes;
using RippleLibSharp.Util;
using RippleLibSharp.Keys;
using RippleLibSharp.Network;
using RippleLibSharp.Result;
using IhildaWallet.Networking;
using Gtk;

using RippleLibSharp.Commands.Accounts;
using IhildaWallet.Util;

namespace IhildaWallet
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class SellWidget : Gtk.Bin
	{
		public SellWidget ()
		{
			Build ();
			//while(Gtk.Application.EventsPending())
			//	Gtk.Application.RunIteration();

			this.amountcomboboxentry.Changed += (object sender, EventArgs e) => {
				CalculateMax();
			};

			this.pricecomboboxentry.Changed += (object sender, EventArgs e) => {
				CalculateMax ();
			};

			this.sellbutton.Clicked += (object sender, EventArgs e) => {
				CreateOffer ();
			};

			Label l = (Label)this.sellbutton.Child;
			l.UseMarkup = true;

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
			string acc = _rippleWallet.Account;

			NetworkInterface ni = NetworkController.GetNetworkInterfaceGuiThread ();

			CancellationTokenSource tokenSource = new CancellationTokenSource ();
			CancellationToken token = tokenSource.Token;
			double val = hscale2.Value;

			if (!_TradePair.Currency_Base.IsNative) {
				var cur = AccountLines.GetBalanceForIssuer
				(
					_TradePair.Currency_Base.currency,
					_TradePair.Currency_Base.issuer,
					acc,
					ni,
					token
				);

				double bal = (double)cur.amount;

				double res = bal * val / 100;

				amountcomboboxentry.Entry.Text = res.ToString ();
			} else {

				Task<Response<AccountInfoResult>> task = 
					AccountInfo.GetResult (acc, ni, token);

				task.Wait (token);

				Response<AccountInfoResult> resp = task.Result;
				AccountInfoResult res = resp.result;

				var reserve = res.GetReserveRequirements (ni, token);

				RippleCurrency rippleCurrency = new RippleCurrency (res.account_data.Balance);

				double bal = (double)(rippleCurrency.amount - reserve.amount) / 1000000 * val / 100;

				amountcomboboxentry.Entry.Text = bal.ToString ();

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


		public void CreateOffer ()
		{
			#if DEBUG
			string method_sig = clsstr + nameof (CreateOffer) + DebugRippleLibSharp.both_parentheses;
			if (DebugIhildaWallet.SellWidget) {
				Logging.WriteLog (method_sig + DebugRippleLibSharp.beginn);
			}
#endif


			TextHighlighter highlighter = new TextHighlighter ();


			if ( 
				this.amountcomboboxentry == null 
				|| this.pricecomboboxentry == null 
				|| this.maxcomboboxentry == null
			) {
				// todo gui in state of disarray, debug
				#if DEBUG
				if (DebugIhildaWallet.SellWidget) {
					Logging.WriteLog (  method_sig + "this.amountcomboboxentry == null || this.pricecomboboxentry == null || this.maxcomboboxentry == null\n" );
				}
				#endif
				return;
			}

			if (this._TradePair == null) {
				// todo debug. warn user?
				#if DEBUG
				if (DebugIhildaWallet.SellWidget) {
					Logging.WriteLog (method_sig + "this._tradePair == null\n");	
				}
				#endif
				return;
			}

			

			//RippleWallet rw = MainWindow.currentInstance.getRippleWallet();

			/*
			RippleWallet rw = WalletManager.selectedWallet;
			if (rw == null) {
				#if DEBUG
				if (Debug.SellWidget) {
					Logging.writeLog (method_sig + "w == null, returning\n");
				}
				#endif
			}
			RippleSeedAddress seed = rw.getDecryptedSeed ();

			#if DEBUG
			if (Debug.SellWidget) {
				Logging.writeLog (method_sig + "rw = ", Debug.toAssertString(rw));
				Logging.writeLog (method_sig + "seed = ", Debug.toAssertString(seed));
			}
			#endif
			*/

			TradePair tp = this._TradePair.DeepCopy();
			if (tp == null) {
				#if DEBUG
				if (DebugIhildaWallet.SellWidget) {
					Logging.WriteLog (method_sig + "tp == null, returning\n");
				}
				#endif
				return;
			}

			#if DEBUG
			if (DebugIhildaWallet.SellWidget) {
				Logging.WriteLog (method_sig + "tp.currency_base =" + tp.Currency_Base.ToString());
				Logging.WriteLog (method_sig + "tp.currency_counter =" + tp.Currency_Counter.ToString());
			}
			#endif





			SellOffer off = new SellOffer();

			//off.taker_gets = tp.currency_base;
			//off.taker_pays = tp.currency_counter;

			off.SetFromTradePair (tp);

			Decimal? getamount = RippleCurrency.ParseDecimal(amountcomboboxentry.ActiveText );
			if (getamount == null) {

				string message = off.taker_pays.currency + " getamount is formatted incorrectly\n";
				highlighter.Highlightcolor = TextHighlighter.RED;
				infobar.Markup = highlighter.Highlight (message);

				// TODO color amnt entry to red
				#if DEBUG
				if (DebugIhildaWallet.SellWidget) {
					Logging.WriteLog (method_sig + "getamount == null\n");
				}
				#endif
				return;
			}

			Decimal? payamount = RippleCurrency.ParseDecimal( maxcomboboxentry.ActiveText );
			if (getamount == null) {

				string message = off.taker_gets.currency + " payamount is formatted incorrectly\n";

				highlighter.Highlightcolor = TextHighlighter.RED;
				infobar.Markup = highlighter.Highlight (message);

#if DEBUG
				if (DebugIhildaWallet.SellWidget) {
					Logging.WriteLog (method_sig + "payamount == null\n");
				}
				#endif
				return;
			}

			Decimal? price = RippleCurrency.ParseDecimal (this.pricecomboboxentry.ActiveText);
			if (price == null) {
				string message = "price is formatted incorrectly\n";
				highlighter.Highlightcolor = TextHighlighter.RED;
				infobar.Markup = highlighter.Highlight (message);
				return;
			}

			bool sane = _parent.SafetyCheck ((Decimal)price, "sell");
			if (!sane) {
				return;
			}
			string mark = comboboxentry1.ActiveText;

			off.BotMarking = mark;

			off.taker_pays.amount = off.taker_pays.IsNative ? (Decimal)payamount * 1000000 : (Decimal)payamount;
			off.taker_gets.amount = off.taker_gets.IsNative ? (Decimal)getamount * 1000000 : (Decimal)getamount;

			LicenseType licenseT = Util.LicenseType.TRADING;
			if (LeIceSense.IsLicenseExempt (off.taker_gets) || LeIceSense.IsLicenseExempt (off.taker_pays)) {
				licenseT = LicenseType.NONE;
			}

			if (AutomationWarning) {

				bool ignored = AreYouSure.AutomatedTradingWarning ();
				if (!ignored) return;
			}

			OrderSubmitWindow win = new OrderSubmitWindow (_rippleWallet);

			win.SetOrders ( new AutomatedOrder[] { off });

			/*
			off.Account = rw.getStoredReceiveAddress();

			NetworkInterface ni = NetworkController.getNetworkInterfaceGuiThread();
			if (ni == null) {
				NetworkController.doNetworkingDialogNonGUIThread ();

			}

			RippleOfferTransaction rot = new RippleOfferTransaction(rw.getStoredReceiveAddress(), off);
			UInt32? seq = AccountInfo.getSequence (off.Account, ni);
			if (seq == null) {
				//TODO deal with error

				return;
			}

			rot.Sequence = (UInt32)seq;

			Tuple<UInt32,UInt32> f = FeeSettings.getFeeAndLastLedgerFromSettings (ni);
			if (f == null) {
				return;
			}
			rot.fee = f.Item1.ToString ();
			rot.LastLedgerSequence = f.Item2;


			rot.sign(seed);

			Task< Response <RippleSubmitTxResult>> task = NetworkController.uiTxNetworkSubmit (rot, ni);
			task.Wait ();
			//rot.submit(ni);

			*/
		}

		private void CalculateMax ()
			{
#if DEBUG
				string method_sig = clsstr + nameof (CalculateMax) + DebugRippleLibSharp.both_parentheses;
				if (DebugIhildaWallet.SellWidget) {
					Logging.WriteLog (method_sig + DebugRippleLibSharp.beginn);
				}
#endif


				TextHighlighter highlighter = new TextHighlighter ();

				/*
				ComboBoxEntry combo = sender as ComboBoxEntry;
				if (combo == null) {
					if (Debug.BuyWidget) {
						Logging.writeLog(method_sig + "combo == null\n");
					}

					return;
				}
				*/

				String text = this.amountcomboboxentry.ActiveText;
#if DEBUG
				if (DebugIhildaWallet.SellWidget) {
					Logging.WriteLog (method_sig + "this.amountcomboboxentry.ActiveText = " + DebugIhildaWallet.ToAssertString (text) + "\n");
				}
#endif

				Decimal? am = RippleCurrency.ParseDecimal (text);
				if (am == null) {

					var message = "Amount is formatted incorrectly";
					highlighter.Highlightcolor = TextHighlighter.RED;
					infobar.Markup = highlighter.Highlight (message);
#if DEBUG
				if (DebugIhildaWallet.SellWidget) {
						Logging.WriteLog (method_sig + "am==null, returning\n");
					}
#endif
					return;
				}

				String text2 = this.pricecomboboxentry.ActiveText;
#if DEBUG
				if (DebugIhildaWallet.SellWidget) {
					Logging.WriteLog (method_sig + "this.pricecomboboxentry.ActiveText = " + DebugIhildaWallet.ToAssertString (text2) + "\n");
				}
#endif
				Decimal? pr = RippleCurrency.ParseDecimal (text2);

				if (pr == null) {

					//MessageDialog.showMessage ("Price is formatted incorrectly\n");
#if DEBUG
					if (DebugIhildaWallet.SellWidget) {
						Logging.WriteLog (method_sig + "pr==null, returning\n");
					}
#endif
					return;
				}

				try {
					Decimal d = (Decimal)(am * pr);
					maxcomboboxentry.Entry.Text = d.ToString ();
				}

#pragma warning disable 0168
			catch (Exception ee) {
#pragma warning restore 0168

					// TODO color
#if DEBUG
					if (DebugIhildaWallet.SellWidget) {
						Logging.WriteLog (method_sig + "Exception thrown\n");
						Logging.WriteLog (ee.Message);
					}
#endif
					return;
				}


			

		}

		public TradePair TradePairInstance {

			get {
				return _TradePair;
			}

			set{
				this._TradePair = value;

				bool requirements = (this._TradePair != null) && this._TradePair.HasRequirements ();

				String b = requirements ? _TradePair.Currency_Base.currency : "";
				String c = requirements ? _TradePair.Currency_Counter.currency : ""; 

				Gtk.Application.Invoke (
				delegate {

						label10.Markup = "<span foreground=\"red\"><b><u>Sell " + b + "</u></b></span>";
					label12.Text = b;
					label15.Text = c;
					label16.Text = c;
				}
				);
			} 
		}

		public void SetOffer (Offer off) {
			#if DEBUG
			string method_sig = clsstr + "setOffer (Offer off = " + DebugIhildaWallet.ToAssertString(off) + ") : ";
			if (DebugIhildaWallet.SellWidget) {
				Logging.WriteLog (method_sig + DebugRippleLibSharp.begin);
			}
			#endif

			AutomationWarning = true;

			if (off == null) {
				#if DEBUG
				if (DebugIhildaWallet.SellWidget) {
					Logging.WriteLog (method_sig + "off == null\n");
				}
				#endif

				Application.Invoke (
					delegate {
						this.amountcomboboxentry.Entry.Text = "";
						this.pricecomboboxentry.Entry.Text = "";
						this.maxcomboboxentry.Entry.Text = "";
					}
				);

				return;
			}

			if (off.taker_gets != null) {
				#if DEBUG
				if (DebugIhildaWallet.SellWidget) {
					Logging.WriteLog (method_sig + "off.TakerGets != null\n");
				}
				#endif

				Decimal amount = off.taker_gets.amount;
				if (off.taker_gets.IsNative) {
					amount /= 1000000;
				}

				string tex = amount.ToString ();

				Application.Invoke (
					delegate {
						if (amountcomboboxentry?.Entry != null) {

						}
						this.amountcomboboxentry.Entry.Text = tex;
					}
				);

			}

			if (off.taker_pays != null) {
				#if DEBUG
				if (DebugIhildaWallet.SellWidget) {

				}
				#endif

				string tex = off.taker_gets.GetNativeAdjustedPriceAt (off.TakerPays).ToString();

				Application.Invoke (
					delegate {
						this.pricecomboboxentry.Entry.Text = tex;
					}
				);

			}
		}

		public void SetPrice (Decimal price)
		{
			pricecomboboxentry.Entry.Text = price.ToString ();
		}

		public void SetAmount (Decimal amount)
		{
			amountcomboboxentry.Entry.Text = amount.ToString ();
		}

		public void SetAmountMax ()
		{
			this.hscale2.Value = 100.0;
		}


		public void SetRippleWallet (RippleWallet rippleWallet)
		{
			this._rippleWallet = rippleWallet;
		}

		public void SetParent (TradeWindow parent)
		{
			this._parent = parent;
		}

		private TradeWindow _parent = null;

		private RippleWallet _rippleWallet {
			get;
			set;
		}

		public bool AutomationWarning { get; set; }


#pragma warning disable RECS0122 // Initializing field with default value is redundant
		private TradePair _TradePair = null;
#pragma warning restore RECS0122 // Initializing field with default value is redundant

#if DEBUG
		private static readonly string clsstr = nameof (SellWidget) + DebugRippleLibSharp.colon;
		#endif
	}
}

