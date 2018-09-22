
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class OrderPreviewSubmitWidget
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView treeview1;

		private global::Gtk.Label label2;

		private global::Gtk.HBox hbox1;

		private global::IhildaWallet.WalletSwitchWidget walletswitchwidget1;

		private global::Gtk.Button SubmitButton;

		private global::Gtk.Button stopbutton;

		private global::Gtk.Button removebutton;

		private global::Gtk.Button selectbutton;

		private global::Gtk.Button analysisbutton;

		private global::Gtk.Button applyRuleButton;

		private global::Gtk.Button marketbutton;

		private global::Gtk.Button resetbutton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.OrderPreviewSubmitWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.OrderPreviewSubmitWidget";
			// Container child IhildaWallet.OrderPreviewSubmitWidget.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeview1 = new global::Gtk.TreeView();
			this.treeview1.CanFocus = true;
			this.treeview1.Name = "treeview1";
			this.GtkScrolledWindow.Add(this.treeview1);
			this.vbox2.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xpad = 10;
			this.label2.Ypad = 10;
			this.label2.Xalign = 0F;
			this.label2.Yalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("<span fgcolor=\"red\">This is an infobar</span>");
			this.label2.UseMarkup = true;
			this.vbox2.Add(this.label2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label2]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.walletswitchwidget1 = new global::IhildaWallet.WalletSwitchWidget();
			this.walletswitchwidget1.Events = ((global::Gdk.EventMask)(256));
			this.walletswitchwidget1.Name = "walletswitchwidget1";
			this.hbox1.Add(this.walletswitchwidget1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.walletswitchwidget1]));
			w4.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.SubmitButton = new global::Gtk.Button();
			this.SubmitButton.CanFocus = true;
			this.SubmitButton.Name = "SubmitButton";
			this.SubmitButton.UseUnderline = true;
			this.SubmitButton.Label = global::Mono.Unix.Catalog.GetString("Submit");
			this.hbox1.Add(this.SubmitButton);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.SubmitButton]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.stopbutton = new global::Gtk.Button();
			this.stopbutton.CanFocus = true;
			this.stopbutton.Name = "stopbutton";
			this.stopbutton.UseUnderline = true;
			this.stopbutton.Label = global::Mono.Unix.Catalog.GetString("Stop");
			this.hbox1.Add(this.stopbutton);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.stopbutton]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.removebutton = new global::Gtk.Button();
			this.removebutton.CanFocus = true;
			this.removebutton.Name = "removebutton";
			this.removebutton.UseUnderline = true;
			this.removebutton.Label = global::Mono.Unix.Catalog.GetString("Remove");
			this.hbox1.Add(this.removebutton);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.removebutton]));
			w7.Position = 3;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.selectbutton = new global::Gtk.Button();
			this.selectbutton.CanFocus = true;
			this.selectbutton.Name = "selectbutton";
			this.selectbutton.UseUnderline = true;
			this.selectbutton.Label = global::Mono.Unix.Catalog.GetString("Select All or None");
			this.hbox1.Add(this.selectbutton);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.selectbutton]));
			w8.Position = 4;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.analysisbutton = new global::Gtk.Button();
			this.analysisbutton.CanFocus = true;
			this.analysisbutton.Name = "analysisbutton";
			this.analysisbutton.UseUnderline = true;
			this.analysisbutton.Label = global::Mono.Unix.Catalog.GetString("Analysis");
			this.hbox1.Add(this.analysisbutton);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.analysisbutton]));
			w9.Position = 5;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.applyRuleButton = new global::Gtk.Button();
			this.applyRuleButton.CanFocus = true;
			this.applyRuleButton.Name = "applyRuleButton";
			this.applyRuleButton.UseUnderline = true;
			this.applyRuleButton.Label = global::Mono.Unix.Catalog.GetString("Apply Rule To Red");
			this.hbox1.Add(this.applyRuleButton);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.applyRuleButton]));
			w10.Position = 6;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.marketbutton = new global::Gtk.Button();
			this.marketbutton.CanFocus = true;
			this.marketbutton.Name = "marketbutton";
			this.marketbutton.UseUnderline = true;
			this.marketbutton.Label = global::Mono.Unix.Catalog.GetString("Market Compare");
			this.hbox1.Add(this.marketbutton);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.marketbutton]));
			w11.Position = 7;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.resetbutton = new global::Gtk.Button();
			this.resetbutton.CanFocus = true;
			this.resetbutton.Name = "resetbutton";
			this.resetbutton.UseUnderline = true;
			this.resetbutton.Label = global::Mono.Unix.Catalog.GetString("Reset to default");
			this.hbox1.Add(this.resetbutton);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.resetbutton]));
			w12.Position = 8;
			w12.Expand = false;
			w12.Fill = false;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.label2.Hide();
			this.Hide();
		}
	}
}
