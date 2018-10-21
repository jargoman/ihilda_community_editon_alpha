
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class OrdersWidget
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label label1;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.HBox hbox12;

		private global::Gtk.Label label4;

		private global::Gtk.ComboBoxEntry comboboxentry1;

		private global::Gtk.Button cancelSelectedButton;

		private global::Gtk.Button selectAllButton;

		private global::Gtk.Button syncbutton;

		private global::Gtk.Label infoBarLabel;

		private global::Gtk.ScrolledWindow scrolledwindow1;

		private global::Gtk.VBox vbox2;

		private global::IhildaWallet.OrderWidget orderwidget1;

		private global::IhildaWallet.OrderWidget orderwidget2;

		private global::IhildaWallet.OrderWidget orderwidget3;

		private global::IhildaWallet.OrderWidget orderwidget4;

		private global::IhildaWallet.OrderWidget orderwidget5;

		private global::IhildaWallet.OrderWidget orderwidget6;

		private global::IhildaWallet.OrderWidget orderwidget7;

		private global::IhildaWallet.OrderWidget orderwidget8;

		private global::IhildaWallet.OrderWidget orderwidget9;

		private global::IhildaWallet.OrderWidget orderwidget10;

		private global::IhildaWallet.PagerWidget pagerwidget1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.OrdersWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.OrdersWidget";
			// Container child IhildaWallet.OrdersWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("<big><b><u>Orders</u></b></big>");
			this.label1.UseMarkup = true;
			this.vbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			w1.Padding = ((uint)(5));
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vbox1.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparator1]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox12 = new global::Gtk.HBox();
			this.hbox12.Name = "hbox12";
			this.hbox12.Spacing = 6;
			// Container child hbox12.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("View Account : ");
			this.hbox12.Add(this.label4);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.label4]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.comboboxentry1 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry1.Name = "comboboxentry1";
			this.hbox12.Add(this.comboboxentry1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.comboboxentry1]));
			w4.Position = 1;
			// Container child hbox12.Gtk.Box+BoxChild
			this.cancelSelectedButton = new global::Gtk.Button();
			this.cancelSelectedButton.CanFocus = true;
			this.cancelSelectedButton.Name = "cancelSelectedButton";
			this.cancelSelectedButton.UseUnderline = true;
			this.cancelSelectedButton.Label = global::Mono.Unix.Catalog.GetString("Cancel Selected");
			this.hbox12.Add(this.cancelSelectedButton);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.cancelSelectedButton]));
			w5.PackType = ((global::Gtk.PackType)(1));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.selectAllButton = new global::Gtk.Button();
			this.selectAllButton.CanFocus = true;
			this.selectAllButton.Name = "selectAllButton";
			this.selectAllButton.UseUnderline = true;
			this.selectAllButton.Label = global::Mono.Unix.Catalog.GetString("Select Page");
			this.hbox12.Add(this.selectAllButton);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.selectAllButton]));
			w6.PackType = ((global::Gtk.PackType)(1));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.syncbutton = new global::Gtk.Button();
			this.syncbutton.CanFocus = true;
			this.syncbutton.Name = "syncbutton";
			this.syncbutton.UseUnderline = true;
			this.syncbutton.Label = global::Mono.Unix.Catalog.GetString("Refresh");
			this.hbox12.Add(this.syncbutton);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.syncbutton]));
			w7.PackType = ((global::Gtk.PackType)(1));
			w7.Position = 4;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox1.Add(this.hbox12);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox12]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.infoBarLabel = new global::Gtk.Label();
			this.infoBarLabel.Name = "infoBarLabel";
			this.infoBarLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<span fgcolor=\"red\">This is an infobar</span>");
			this.infoBarLabel.UseMarkup = true;
			this.vbox1.Add(this.infoBarLabel);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.infoBarLabel]));
			w9.Position = 3;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.VscrollbarPolicy = ((global::Gtk.PolicyType)(0));
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w10 = new global::Gtk.Viewport();
			w10.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Homogeneous = true;
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.orderwidget1 = new global::IhildaWallet.OrderWidget();
			this.orderwidget1.Events = ((global::Gdk.EventMask)(256));
			this.orderwidget1.Name = "orderwidget1";
			this.orderwidget1.Selected = false;
			this.vbox2.Add(this.orderwidget1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.orderwidget1]));
			w11.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.orderwidget2 = new global::IhildaWallet.OrderWidget();
			this.orderwidget2.Events = ((global::Gdk.EventMask)(256));
			this.orderwidget2.Name = "orderwidget2";
			this.orderwidget2.Selected = false;
			this.vbox2.Add(this.orderwidget2);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.orderwidget2]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.orderwidget3 = new global::IhildaWallet.OrderWidget();
			this.orderwidget3.Events = ((global::Gdk.EventMask)(256));
			this.orderwidget3.Name = "orderwidget3";
			this.orderwidget3.Selected = false;
			this.vbox2.Add(this.orderwidget3);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.orderwidget3]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.orderwidget4 = new global::IhildaWallet.OrderWidget();
			this.orderwidget4.Events = ((global::Gdk.EventMask)(256));
			this.orderwidget4.Name = "orderwidget4";
			this.orderwidget4.Selected = false;
			this.vbox2.Add(this.orderwidget4);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.orderwidget4]));
			w14.Position = 3;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.orderwidget5 = new global::IhildaWallet.OrderWidget();
			this.orderwidget5.Events = ((global::Gdk.EventMask)(256));
			this.orderwidget5.Name = "orderwidget5";
			this.orderwidget5.Selected = false;
			this.vbox2.Add(this.orderwidget5);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.orderwidget5]));
			w15.Position = 4;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.orderwidget6 = new global::IhildaWallet.OrderWidget();
			this.orderwidget6.Events = ((global::Gdk.EventMask)(256));
			this.orderwidget6.Name = "orderwidget6";
			this.orderwidget6.Selected = false;
			this.vbox2.Add(this.orderwidget6);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.orderwidget6]));
			w16.Position = 5;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.orderwidget7 = new global::IhildaWallet.OrderWidget();
			this.orderwidget7.Events = ((global::Gdk.EventMask)(256));
			this.orderwidget7.Name = "orderwidget7";
			this.orderwidget7.Selected = false;
			this.vbox2.Add(this.orderwidget7);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.orderwidget7]));
			w17.Position = 6;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.orderwidget8 = new global::IhildaWallet.OrderWidget();
			this.orderwidget8.Events = ((global::Gdk.EventMask)(256));
			this.orderwidget8.Name = "orderwidget8";
			this.orderwidget8.Selected = false;
			this.vbox2.Add(this.orderwidget8);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.orderwidget8]));
			w18.Position = 7;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.orderwidget9 = new global::IhildaWallet.OrderWidget();
			this.orderwidget9.Events = ((global::Gdk.EventMask)(256));
			this.orderwidget9.Name = "orderwidget9";
			this.orderwidget9.Selected = false;
			this.vbox2.Add(this.orderwidget9);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.orderwidget9]));
			w19.Position = 8;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.orderwidget10 = new global::IhildaWallet.OrderWidget();
			this.orderwidget10.Events = ((global::Gdk.EventMask)(256));
			this.orderwidget10.Name = "orderwidget10";
			this.orderwidget10.Selected = false;
			this.vbox2.Add(this.orderwidget10);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.orderwidget10]));
			w20.Position = 9;
			w20.Expand = false;
			w20.Fill = false;
			w10.Add(this.vbox2);
			this.scrolledwindow1.Add(w10);
			this.vbox1.Add(this.scrolledwindow1);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.scrolledwindow1]));
			w23.Position = 4;
			// Container child vbox1.Gtk.Box+BoxChild
			this.pagerwidget1 = new global::IhildaWallet.PagerWidget();
			this.pagerwidget1.Events = ((global::Gdk.EventMask)(256));
			this.pagerwidget1.Name = "pagerwidget1";
			this.vbox1.Add(this.pagerwidget1);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.pagerwidget1]));
			w24.PackType = ((global::Gtk.PackType)(1));
			w24.Position = 5;
			w24.Expand = false;
			w24.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.infoBarLabel.Hide();
			this.vbox1.Hide();
			this.Hide();
		}
	}
}
