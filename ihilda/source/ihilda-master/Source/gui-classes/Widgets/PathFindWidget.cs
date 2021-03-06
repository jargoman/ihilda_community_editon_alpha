﻿using System;
using System.Threading;
using System.Threading.Tasks;
using RippleLibSharp.Commands.Stipulate;
using RippleLibSharp.Result;
using RippleLibSharp.Keys;
using RippleLibSharp.Transactions;
using RippleLibSharp.Network;
using IhildaWallet.Networking;
using System.Text;

using RippleLibSharp.Util;

namespace IhildaWallet
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class PathFindWidget : Gtk.Bin
	{
		public PathFindWidget ()
		{
			this.Build ();

			if (pathstree1 == null) {
				pathstree1 = new PathsTree ();
				pathstree1.Show ();

				vbox3.Add (pathstree1);
			}


			this.refreshButton.Clicked += Refresh_Button_Clicked;

			this.comboboxentry3.Changed += (object sender, EventArgs e) => {
				string cur = this.comboboxentry3.ActiveText;
				if (RippleCurrency.NativeCurrency == cur) {
					label6.Visible = false;
					comboboxentry4.Visible = false;
					comboboxentry4.Entry.Text = "";
					return;
				}

				label6.Visible = true;
				comboboxentry4.Visible = true;
			};


			this.destinationTagcomboboxentry.Entry.Changed += (sender, e) => {
				string tag = this.destinationTagcomboboxentry.Entry.Text;

				pathstree1.DestinationTag = tag;
			};


			pathstree1.MemoWidget = memowidget1;
		}


		private CancellationTokenSource tokenSource = null;
		void Refresh_Button_Clicked (object sender, EventArgs e)
		{

			TextHighlighter highlighter = new TextHighlighter ();

			tokenSource?.Cancel ();
			tokenSource = new CancellationTokenSource ();
			CancellationToken token = new CancellationToken ();
			//string source_account = null;

			RippleWallet rw = _rippleWallet;

			// TODO security/stability check. 
			//What are the implications of the selectedwallet changing between pathfind request and signature
			//

			if (rw == null) {
				// todo debug
				return;
			}

			string destination_account = comboboxentry1.Entry.Text;

			string destination_tag = destinationTagcomboboxentry.Entry.Text;

			string amount = comboboxentry2.Entry.Text;
			string currency = comboboxentry3.Entry.Text;
			string issuer = comboboxentry4.Entry.Text;


			Decimal amountd = 0;
			Decimal? dee = RippleCurrency.ParseDecimal (amount);  // Payment amount is not a valid string ect
			if (dee != null) {
				amountd = (decimal)dee;
			} else {
				var message = "Payment Amount is formatted incorretly";
				highlighter.Highlightcolor = TextHighlighter.RED;
				label7.Text = highlighter.Highlight (message);
				return;
			}

			if (amountd < 0) {
				string message = "Sending negative amounts is not supported. Please enter a valid amount";
				highlighter.Highlightcolor = TextHighlighter.RED;
				label7.Text = highlighter.Highlight (message);
				return;
			}

			RippleCurrency rc = null; 

			if (currency == RippleCurrency.NativeCurrency) {
				rc = new RippleCurrency (amountd * 1000000);
			} else {
				rc = new RippleCurrency (amountd, issuer, currency);
			}

			//Thread thread = new Thread (
			Task.Run (
				delegate {


					NetworkInterface ni = NetworkController.GetNetworkInterfaceNonGUIThread ();
					if (ni == null) {
						return;
					}

					Task<Response<PathFindResult>> task = PathFind.GetResult (
						rw.GetStoredReceiveAddress (),
						destination_account,
						rc,
						ni,
						token

					);


					if (task == null) {
						return;
					}

					task.Wait (token);


					Response<PathFindResult> response = task.Result;
					if (response == null) {

						SetInfoBar ("response == null");
						return;
					}

					if (response.HasError ()) {
						StringBuilder stringBuilder = new StringBuilder ();
						stringBuilder.Append (nameof (response.error_code));
						stringBuilder.Append (" : ");
						stringBuilder.Append (response.error_code?.ToString () ?? "null");
						stringBuilder.Append (" ");
						stringBuilder.Append (nameof (response.error_message));
						stringBuilder.Append (" : ");
						stringBuilder.Append (response.error_message);

						SetInfoBar (stringBuilder.ToString ());
						return;
					}


					PathFindResult result = response.result;
					if (result == null) {
						SetInfoBar ("response == null");
						return;
					}
					this.pathstree1.SetPathFindResult (result);
				}
				, token);
			//);

			//thread.Start ();











		}

		public void SetInfoBar (string message)
		{
			Gtk.Application.Invoke (
				delegate {

					label7.Text = message;
				}
			);
		}



		public void SetRippleWallet (RippleWallet rippleWallet)
		{
			this._rippleWallet = rippleWallet;
			this.pathstree1.SetRippleWallet ( rippleWallet );
		}

		private RippleWallet _rippleWallet {
			get;
			set;
		}


	}
}

