
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class NetworkSettings
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Label label4;

		private global::Gtk.HSeparator hseparator12;

		private global::Gtk.Table table2;

		private global::Gtk.Entry agententry;

		private global::Gtk.Label label3;

		private global::Gtk.Label label5;

		private global::Gtk.Label label7;

		private global::Gtk.Entry localentry;

		private global::Gtk.ScrolledWindow scrolledwindow2;

		private global::Gtk.TextView servertextview;

		private global::Gtk.ScrolledWindow scrolledwindow1;

		private global::IhildaWallet.ServerInfoWidget serverinfowidget1;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Button connectbutton;

		private global::Gtk.Button disconnectbutton;

		private global::Gtk.CheckButton autoconnectbutton;

		private global::Gtk.Button testnetbutton1;

		private global::Gtk.Button button43;

		private global::IhildaWallet.ConnectedDisplayWidget connecteddisplaywidget1;

		private global::Gtk.HSeparator hseparator13;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.NetworkSettings
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.NetworkSettings";
			// Container child IhildaWallet.NetworkSettings.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(5));
			// Container child vbox2.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.HeightRequest = 30;
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("<b><u><big>Network Settings </big></u></b>");
			this.label4.UseMarkup = true;
			this.vbox2.Add(this.label4);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label4]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator12 = new global::Gtk.HSeparator();
			this.hseparator12.Name = "hseparator12";
			this.vbox2.Add(this.hseparator12);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator12]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table(((uint)(3)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.agententry = new global::Gtk.Entry();
			this.agententry.CanFocus = true;
			this.agententry.Name = "agententry";
			this.agententry.IsEditable = true;
			this.agententry.InvisibleChar = '●';
			this.table2.Add(this.agententry);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2[this.agententry]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.Yalign = 0.1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Server URL\'s</b>");
			this.label3.UseMarkup = true;
			this.table2.Add(this.label3);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2[this.label3]));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Local URL</b>");
			this.label5.UseMarkup = true;
			this.table2.Add(this.label5);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2[this.label5]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.Xalign = 0F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("<b>User Agent</b>");
			this.label7.UseMarkup = true;
			this.table2.Add(this.label7);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2[this.label7]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.localentry = new global::Gtk.Entry();
			this.localentry.CanFocus = true;
			this.localentry.Name = "localentry";
			this.localentry.IsEditable = true;
			this.localentry.InvisibleChar = '●';
			this.table2.Add(this.localentry);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2[this.localentry]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow2.HeightRequest = 75;
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			this.servertextview = new global::Gtk.TextView();
			this.servertextview.CanFocus = true;
			this.servertextview.Name = "servertextview";
			this.scrolledwindow2.Add(this.servertextview);
			this.table2.Add(this.scrolledwindow2);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table2[this.scrolledwindow2]));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			this.vbox2.Add(this.table2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.table2]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w11 = new global::Gtk.Viewport();
			w11.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.serverinfowidget1 = null;
			w11.Add(this.serverinfowidget1);
			this.scrolledwindow1.Add(w11);
			this.vbox2.Add(this.scrolledwindow1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.scrolledwindow1]));
			w14.Position = 3;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.connectbutton = new global::Gtk.Button();
			this.connectbutton.CanFocus = true;
			this.connectbutton.Name = "connectbutton";
			this.connectbutton.UseUnderline = true;
			this.connectbutton.Label = global::Mono.Unix.Catalog.GetString("Connect");
			this.hbox8.Add(this.connectbutton);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.connectbutton]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.disconnectbutton = new global::Gtk.Button();
			this.disconnectbutton.CanFocus = true;
			this.disconnectbutton.Name = "disconnectbutton";
			this.disconnectbutton.UseUnderline = true;
			this.disconnectbutton.Label = global::Mono.Unix.Catalog.GetString("Disconnect");
			this.hbox8.Add(this.disconnectbutton);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.disconnectbutton]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.autoconnectbutton = new global::Gtk.CheckButton();
			this.autoconnectbutton.CanFocus = true;
			this.autoconnectbutton.Name = "autoconnectbutton";
			this.autoconnectbutton.Label = global::Mono.Unix.Catalog.GetString("Auto Reconnect");
			this.autoconnectbutton.DrawIndicator = true;
			this.autoconnectbutton.UseUnderline = true;
			this.hbox8.Add(this.autoconnectbutton);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.autoconnectbutton]));
			w17.Position = 2;
			// Container child hbox8.Gtk.Box+BoxChild
			this.testnetbutton1 = new global::Gtk.Button();
			this.testnetbutton1.CanFocus = true;
			this.testnetbutton1.Name = "testnetbutton1";
			this.testnetbutton1.UseUnderline = true;
			this.testnetbutton1.Label = global::Mono.Unix.Catalog.GetString("Testnet Default");
			this.hbox8.Add(this.testnetbutton1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.testnetbutton1]));
			w18.PackType = ((global::Gtk.PackType)(1));
			w18.Position = 3;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.button43 = new global::Gtk.Button();
			this.button43.CanFocus = true;
			this.button43.Name = "button43";
			this.button43.UseUnderline = true;
			this.button43.Label = global::Mono.Unix.Catalog.GetString("Default Settings");
			this.hbox8.Add(this.button43);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.button43]));
			w19.PackType = ((global::Gtk.PackType)(1));
			w19.Position = 4;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.connecteddisplaywidget1 = null;
			this.hbox8.Add(this.connecteddisplaywidget1);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.connecteddisplaywidget1]));
			w20.PackType = ((global::Gtk.PackType)(1));
			w20.Position = 5;
			w20.Expand = false;
			w20.Fill = false;
			this.vbox2.Add(this.hbox8);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox8]));
			w21.PackType = ((global::Gtk.PackType)(1));
			w21.Position = 4;
			w21.Expand = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator13 = new global::Gtk.HSeparator();
			this.hseparator13.Name = "hseparator13";
			this.vbox2.Add(this.hseparator13);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator13]));
			w22.PackType = ((global::Gtk.PackType)(1));
			w22.Position = 5;
			w22.Expand = false;
			w22.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.localentry.Activated += new global::System.EventHandler(this.OnLocalentryActivated);
			this.agententry.Activated += new global::System.EventHandler(this.OnAgententryActivated);
			this.connectbutton.Clicked += new global::System.EventHandler(this.OnConnectbuttonClicked);
			this.disconnectbutton.Clicked += new global::System.EventHandler(this.OnDisconnectbuttonClicked);
			this.autoconnectbutton.Toggled += new global::System.EventHandler(this.OnAutoconnectbuttonToggled);
		}
	}
}
