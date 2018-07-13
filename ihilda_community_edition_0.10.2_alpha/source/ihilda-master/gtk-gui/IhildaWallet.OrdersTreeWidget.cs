
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class OrdersTreeWidget
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label label1;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.HBox hbox12;

		private global::Gtk.Label label4;

		private global::Gtk.ComboBoxEntry comboboxentry1;

		private global::Gtk.Button button74;

		private global::Gtk.Button cancelbutton;

		private global::Gtk.Button selectButon;

		private global::Gtk.Button syncbutton;

		private global::Gtk.Label infoBarLabel;

		private global::IhildaWallet.OpenOrdersTree openorderstree1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.OrdersTreeWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.OrdersTreeWidget";
			// Container child IhildaWallet.OrdersTreeWidget.Gtk.Container+ContainerChild
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
			this.button74 = new global::Gtk.Button();
			this.button74.CanFocus = true;
			this.button74.Name = "button74";
			this.button74.UseUnderline = true;
			this.button74.Label = global::Mono.Unix.Catalog.GetString("Stop");
			this.hbox12.Add(this.button74);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.button74]));
			w5.PackType = ((global::Gtk.PackType)(1));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.cancelbutton = new global::Gtk.Button();
			this.cancelbutton.CanFocus = true;
			this.cancelbutton.Name = "cancelbutton";
			this.cancelbutton.UseUnderline = true;
			this.cancelbutton.Label = global::Mono.Unix.Catalog.GetString("Cancel Selected");
			this.hbox12.Add(this.cancelbutton);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.cancelbutton]));
			w6.PackType = ((global::Gtk.PackType)(1));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.selectButon = new global::Gtk.Button();
			this.selectButon.CanFocus = true;
			this.selectButon.Name = "selectButon";
			this.selectButon.UseUnderline = true;
			this.selectButon.Label = global::Mono.Unix.Catalog.GetString("Select All");
			this.hbox12.Add(this.selectButon);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.selectButon]));
			w7.PackType = ((global::Gtk.PackType)(1));
			w7.Position = 4;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.syncbutton = new global::Gtk.Button();
			this.syncbutton.CanFocus = true;
			this.syncbutton.Name = "syncbutton";
			this.syncbutton.UseUnderline = true;
			this.syncbutton.Label = global::Mono.Unix.Catalog.GetString("Refresh");
			this.hbox12.Add(this.syncbutton);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.syncbutton]));
			w8.PackType = ((global::Gtk.PackType)(1));
			w8.Position = 5;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox1.Add(this.hbox12);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox12]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.infoBarLabel = new global::Gtk.Label();
			this.infoBarLabel.Name = "infoBarLabel";
			this.infoBarLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<span fgcolor=\"red\">This is an infobar</span>");
			this.infoBarLabel.UseMarkup = true;
			this.vbox1.Add(this.infoBarLabel);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.infoBarLabel]));
			w10.Position = 3;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.openorderstree1 = new global::IhildaWallet.OpenOrdersTree();
			this.openorderstree1.Events = ((global::Gdk.EventMask)(256));
			this.openorderstree1.Name = "openorderstree1";
			this.vbox1.Add(this.openorderstree1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.openorderstree1]));
			w11.Position = 4;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.vbox1.Hide();
			this.Hide();
		}
	}
}
