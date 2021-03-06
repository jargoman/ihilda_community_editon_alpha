using System;
using System.Threading;
using System.Threading.Tasks;
using Gtk;
using IhildaWallet.Networking;
using IhildaWallet.Util;
using RippleLibSharp.Commands.Accounts;
using RippleLibSharp.Commands.Stipulate;
using RippleLibSharp.Network;
using RippleLibSharp.Result;
using RippleLibSharp.Transactions;
using RippleLibSharp.Util;

namespace IhildaWallet
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class BuyWidget : Gtk.Bin
	{
		public BuyWidget ()
		{
			this.Build ();
			//while(Gtk.Application.EventsPending())
			//	Gtk.Application.RunIteration();

			this.amountcomboboxentry.Changed += (object sender, EventArgs e) => {
					
				CalculateMax();
					
			};

			this.pricecomboboxentry.Changed += (object sender, EventArgs e) => {
				CalculateMax();
			};

			this.buybutton.Clicked += (object sender, EventArgs e) => {
				CreateOffer();
			};

			Label l = (Label)this.buybutton.Child;
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

		public void ScaleMethod (double value, string pri)
		{
#if DEBUG
			string method_sig = clsstr + nameof (ScaleMethod) + DebugRippleLibSharp.colon;

#endif

			TextHighlighter highlighter = new TextHighlighter ();


			string acc = _rippleWallet.Account;



			NetworkInterface ni = NetworkController.GetNetworkInterfaceNonGUIThread ();

			CancellationTokenSource tokenSource = new CancellationTokenSource ();
			CancellationToken token = tokenSource.Token;

			Decimal? price = RippleCurrency.ParseDecimal (pri);

			if (price == null) {

				Task<Response<BookOfferResult>> sellTask =
				BookOffers.GetResult (
					_tradePair.Currency_Base,
					_tradePair.Currency_Counter,
					2,
					ni,
					tokenSource.Token
				);

				sellTask.Wait ();

				var result = sellTask?.Result;

				var res = result?.result;

				var offs = res?.offers;

				if (offs == null || offs.Length < 1) {

					var mess = "Price is formatted incorrectly";

					highlighter.Highlightcolor = TextHighlighter.RED;
					string sss = highlighter.Highlight (mess);

					Gtk.Application.Invoke (delegate {

						infobar.Markup = sss;
					}
					);

#if DEBUG
					if (DebugIhildaWallet.BuyWidget) {
						Logging.WriteLog (method_sig + "offs==null, returning\n");
					}
#endif

					return;
				}

				var highestBid = offs [0];
				price = highestBid.TakerPays.GetNativeAdjustedCostAt (highestBid.TakerGets);
				if (price == null) {

#if DEBUG
					if (DebugIhildaWallet.BuyWidget) {
						Logging.WriteLog (method_sig + "price==null, returning\n");
					}
#endif
					return;
				}

				var bidLabelText = price.ToString ();

				var message = "Price isn't specified using " + bidLabelText;

				highlighter.Highlightcolor = TextHighlighter.RED;
				string ss = highlighter.Highlight (message);

				Gtk.Application.Invoke ( delegate {
					pricecomboboxentry.Entry.Text = price.ToString ();
					infobar.Markup = ss;
				}
				);

			
			}


			if (!_tradePair.Currency_Counter.IsNative) {
				var cur = AccountLines.GetBalanceForIssuer
				(
					_tradePair.Currency_Counter.currency,
					_tradePair.Currency_Counter.issuer,
					acc,
					ni,
					token
				);

				double bal = (double)cur.amount;

				double res = bal * value / 100;

				var amount = res / (double)price;


				var ss = amount.ToString ();
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

				var amount = bal / (double)price;

				string ss = amount.ToString ();
				Gtk.Application.Invoke ( delegate {
					amountcomboboxentry.Entry.Text = ss;
				});
			}

		}

		void Hscale2_ValueChanged (object sender, EventArgs e)
		{
#if DEBUG
			string method_sig = clsstr + nameof (Hscale2_ValueChanged) + DebugRippleLibSharp.colon;
#endif
			double val = hscale2.Value;



			String text2 = this.pricecomboboxentry.ActiveText;


#if DEBUG
			if (DebugIhildaWallet.BuyWidget) {
				Logging.WriteLog (method_sig + "this.pricecomboboxentry.ActiveText = " + DebugIhildaWallet.ToAssertString (text2) + "\n");
			}
#endif

			Task.Run ( delegate {
				ScaleMethod (val, text2); 
			});

		}


		void PercentageClicked (object sender, EventArgs e)
		{
			if (sender is Button b) {
				string s = b?.Label.TrimEnd('%');
				double d = Convert.ToDouble (s);

				hscale2.Value = d;
			}
		}


		private void CalculateMax () {
			#if DEBUG
			string method_sig = clsstr + nameof (CalculateMax) + DebugRippleLibSharp.both_parentheses;
			if (DebugIhildaWallet.BuyWidget) {
				Logging.WriteLog(method_sig + DebugRippleLibSharp.beginn);
			}
#endif

			/*
			ComboBoxEntry combo = sender as ComboBoxEntry;
			if (combo == null) {
				if (Debug.BuyWidget) {
					Logging.writeLog(method_sig + "combo == null\n");
				}

				return;
			}
			*/

			TextHighlighter highlighter = new TextHighlighter ();

			String text = this.amountcomboboxentry.ActiveText;
			#if DEBUG
			if (DebugIhildaWallet.BuyWidget) {
				Logging.WriteLog(method_sig + "this.amountcomboboxentry.ActiveText = " + DebugIhildaWallet.ToAssertString(text) + "\n");
			}
			#endif

			Decimal? am =  RippleCurrency.ParseDecimal(text);
			if (am==null) {
				var message = "Amount is formatted incorrectly \n";
				highlighter.Highlightcolor = TextHighlighter.RED;
				infobar.Markup = highlighter.Highlight (message);
				// Todo color amount entry red

#if DEBUG
				if (DebugIhildaWallet.BuyWidget) {
					Logging.WriteLog(method_sig + "am==null, returning\n");
				}
				#endif
				return;
			}

			String text2 = this.pricecomboboxentry.ActiveText;
			#if DEBUG
			if (DebugIhildaWallet.BuyWidget) {
				Logging.WriteLog(method_sig + "this.pricecomboboxentry.ActiveText = " + DebugIhildaWallet.ToAssertString(text2) + "\n");
			}
			#endif
			Decimal? pr = RippleCurrency.ParseDecimal( text2 );

			if (pr == null) {

				var message = "Price is formatted incorrectly";
				highlighter.Highlightcolor = TextHighlighter.RED;
				infobar.Markup = highlighter.Highlight (message);

#if DEBUG
				if (DebugIhildaWallet.BuyWidget) {
					Logging.WriteLog(method_sig + "pr==null, returning\n");
				}
				#endif
				return;
			}

			try {
				Decimal d = (Decimal)(am * pr);
				maxcomboboxentry.Entry.Text = d.ToString();
			}	

			#pragma warning disable 0168
			catch ( Exception ee ) {
			#pragma warning restore 0168

				// todo color
				#if DEBUG
				if (DebugIhildaWallet.BuyWidget) {
					Logging.WriteLog(method_sig + DebugRippleLibSharp.exceptionMessage);
					Logging.WriteLog(ee.Message);
				}
				#endif
				return;
			}	

		}


		public void SetOffer (Offer off)
		{
#if DEBUG
			string method_sig = clsstr + nameof (SetOffer) + DebugRippleLibSharp.left_parentheses + nameof (Offer) + DebugRippleLibSharp.space_char + nameof (off) + DebugRippleLibSharp.equals + DebugIhildaWallet.ToAssertString (off) + DebugRippleLibSharp.right_parentheses;
			if (DebugIhildaWallet.BuyWidget) {
				Logging.WriteLog (method_sig + DebugRippleLibSharp.begin);
			}
#endif


			AutomationWarning = true;

			if (off == null) {
#if DEBUG
				if (DebugIhildaWallet.BuyWidget) {
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

			if (off.taker_pays != null) {
#if DEBUG
				if (DebugIhildaWallet.BuyWidget) {
					Logging.WriteLog (method_sig + "off.TakerGets != null\n");
				}
#endif

				Decimal amount = off.taker_pays.amount;
				if (off.taker_pays.IsNative) {
					amount /= 1000000;
				}

				string tex = amount.ToString ();

				Application.Invoke (
					delegate {
						Entry entry = this.amountcomboboxentry?.Entry;
						if (entry != null) {
							entry.Text = tex;
						}

					}
				);

			}

			if (off.taker_gets != null) {
#if DEBUG
				if (DebugIhildaWallet.BuyWidget) {
					Logging.WriteLog (method_sig + "off.TakerPays != null\n");
				}
#endif

				string tex = off.taker_pays.GetNativeAdjustedPriceAt (off.taker_gets).ToString ();

				Application.Invoke (delegate {

					this.pricecomboboxentry.Entry.Text = tex;
				});

			}


		}

		//public void setTradePair (TradePair tradepair) {

		//}

		public TradePair TradePairInstance {
			 
			get {
				#if DEBUG
				string method_sig = clsstr + nameof (TradePair) + " get"  + DebugRippleLibSharp.colon;
				if (DebugIhildaWallet.BuyWidget) {
					Logging.WriteLog (method_sig + DebugRippleLibSharp.returning + DebugIhildaWallet.ToAssertString(_tradePair));
				}
				#endif
				return _tradePair;
			}

			set{
				#if DEBUG
				string method_sig = clsstr + nameof (TradePairInstance) + DebugRippleLibSharp.space_char + "set" + DebugRippleLibSharp.colon;
				if (DebugIhildaWallet.BuyWidget) {
					Logging.WriteLog (method_sig + DebugRippleLibSharp.begin );
				}
#endif
				_tradePair = value;

				#if DEBUG
				if (DebugIhildaWallet.BuyWidget) {
					Logging.WriteLog (method_sig + "value set to " + DebugIhildaWallet.ToAssertString(_tradePair));
				}
				#endif


				bool requirements = _tradePair != null && this._tradePair.HasRequirements();


				String a = requirements ? _tradePair.Currency_Base.currency : "";
				String b = requirements ? _tradePair.Currency_Counter.currency : "";

				Application.Invoke ( delegate {
					#if DEBUG
					string event_sig = method_sig + DebugIhildaWallet.gtkInvoke;
					if (DebugIhildaWallet.BuyWidget) {
						Logging.WriteLog( event_sig + nameof (a) + DebugRippleLibSharp.equals + DebugIhildaWallet.ToAssertString(a) + DebugRippleLibSharp.comma + nameof (b) + DebugRippleLibSharp.equals + DebugIhildaWallet.ToAssertString(b));
					}
					#endif
					label10.Markup = "<span foreground=\"green\"><b><u>Buy " + a + "</u></b></span>";
					label12.Text = a;
					label15.Text = b;
					label16.Text = b;
				}
				);
			} 
		}

		public void CreateOffer ()
		{
			#if DEBUG
			string method_sig = clsstr + nameof (CreateOffer) + DebugRippleLibSharp.both_parentheses;
			if (DebugIhildaWallet.BuyWidget) {
				Logging.WriteLog (method_sig + DebugRippleLibSharp.beginn);
			}
#endif


			TextHighlighter highlighter = new TextHighlighter ();

			if (amountcomboboxentry == null || pricecomboboxentry == null || maxcomboboxentry == null) {
				// todo gui in state of disarray, debug
				return;
			}

			if (_tradePair == null) {
				// todo debug. warn user?
				#if DEBUG
				if (DebugIhildaWallet.BuyWidget) {
					Logging.WriteLog (method_sig + nameof (_tradePair) + " == null\n");	
				}
				#endif
				return;
			}

			//RippleWallet rw = MainWindow.currentInstance.getRippleWallet();
			RippleWallet rw = _rippleWallet;
			if (rw == null) {
				#if DEBUG
				if (DebugIhildaWallet.BuyWidget) {
					Logging.WriteLog (method_sig + "w == null, returning\n");
				}
#endif

				// TODO warn user // shouldn't happen actually, make sure this is set by the time it's used
				return;
			}

			//RippleSeedAddress seed = rw.GetDecryptedSeed ();

			#if DEBUG
			if (DebugIhildaWallet.BuyWidget) {
				Logging.WriteLog (method_sig + nameof (rw) + DebugRippleLibSharp.equals + DebugIhildaWallet.ToAssertString(rw));

				// The log might be aware not to print the secret
				//Logging.WriteLog (method_sig + nameof (seed) + DebugRippleLibSharp.equals + DebugIhildaWallet.ToAssertString(seed));

			}
			#endif


			TradePair tp = this._tradePair.DeepCopy();
			if (tp == null) {
				#if DEBUG
				if (DebugIhildaWallet.BuyWidget) {
					Logging.WriteLog ("tp == null, returning\n");
				}
				#endif
				return;
			}

			#if DEBUG
			if (DebugIhildaWallet.BuyWidget) {
				Logging.WriteLog ("tp.currency_base =" + tp.Currency_Base.ToString());
				Logging.WriteLog ("tp.currency_counter =" + tp.Currency_Counter.ToString());
			}
#endif



			BuyOffer off = new BuyOffer {
				Account = rw.Account
			};

			//off.taker_gets = tp.currency_counter;
			//off.taker_pays = tp.currency_base;

			off.SetFromTradePair (tp);

			Decimal? payamount = RippleCurrency.ParseDecimal(amountcomboboxentry.ActiveText);
			if (payamount == null) {
				var message = off.taker_pays.currency + " payamount is formatted incorrectly \n";
				highlighter.Highlightcolor = TextHighlighter.RED;
				infobar.Markup = highlighter.Highlight (message);
				return;
			}

			Decimal? getamount = RippleCurrency.ParseDecimal( maxcomboboxentry.ActiveText );
			if (getamount == null) {
				var message = off.taker_gets.currency + " getamount is formatted incorrectly \n";
				highlighter.Highlightcolor = TextHighlighter.RED;
				infobar.Markup= highlighter.Highlight (message);
				return;
			}

			Decimal? price = RippleCurrency.ParseDecimal (pricecomboboxentry.ActiveText);
			if (price == null) {
				string message = "price is formatted incorrectly\n";
				highlighter.Highlightcolor = TextHighlighter.RED;
				infobar.Markup = highlighter.Highlight (message);
				return;
			}

			bool sane = _parent.SafetyCheck ((Decimal)price, "buy");
			if (!sane) {
				return;
			}

			string mark = comboboxentry1.ActiveText;

			off.BotMarking = mark;

			off.taker_pays.amount = off.taker_pays.IsNative ? (Decimal)payamount * 1000000 : (Decimal)payamount;
			off.taker_gets.amount = off.taker_gets.IsNative ? (Decimal)getamount * 1000000 : (Decimal)getamount;

			//off.Account = rw.getStoredReceiveAddress();

			//RippleOfferTransaction tx = new RippleOfferTransaction(rw.getStoredReceiveAddress(), off);


			if (AutomationWarning) {

				bool ignored = AreYouSure.AutomatedTradingWarning ();
				if (!ignored) return;
			}

			/*

			LicenseType licenseT = Util.LicenseType.TRADING;
			if (LeIceSense.IsLicenseExempt (off.taker_gets) || LeIceSense.IsLicenseExempt (off.taker_pays)) {
				licenseT = LicenseType.NONE;
			}

			

			OrderSubmitWindow win = new OrderSubmitWindow (_rippleWallet, licenseT);
	    		*/

			OrderSubmitWindow win = new OrderSubmitWindow (_rippleWallet);
			win.SetOrders ( new AutomatedOrder[] { off });

			/*
			NetworkInterface ni = NetworkController.getNetworkInterfaceGuiThread();
			if (ni == null) {
				NetworkController.doNetworkingDialogNonGUIThread ();
				return;
			}
			tx.autoRequestSequence (off.Account, ni);

			Tuple<UInt32,UInt32> f = FeeSettings.getFeeAndLastLedgerFromSettings (ni);
			if (f == null) {
				return;
			}
			tx.fee = f.Item1.ToString ();

			tx.LastLedgerSequence = f.Item2;


			tx.sign(seed);







			Task< Response <RippleSubmitTxResult>> task = 
				NetworkController.uiTxNetworkSubmit (tx, ni);
			task.Wait ();

			*/

		}


		public bool AutomationWarning { get; set; }

		public void SetParent (TradeWindow parent)
		{
			this._parent = parent;
		}

		private TradeWindow _parent = null;

		public void SetRippleWallet (RippleWallet rippleWallet)
		{
			this._rippleWallet = rippleWallet;
		}

		private RippleWallet _rippleWallet = null;

#pragma warning disable RECS0122 // Initializing field with default value is redundant
		private TradePair _tradePair = null;
#pragma warning restore RECS0122 // Initializing field with default value is redundant

#if DEBUG
		private static readonly string clsstr = nameof(BuyWidget) + DebugRippleLibSharp.colon;
#endif
	}
}

