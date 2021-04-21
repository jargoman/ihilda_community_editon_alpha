
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class PaperWalletWindow
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.EventBox eventbox1;

		private global::Gtk.Table table1;

		private global::Gtk.Label addresslabel;

		private global::Gtk.Image image5;

		private global::Gtk.Image image6;

		private global::Gtk.Label secretlabel;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Label label5;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView textview3;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Button button138;

		private global::Gtk.CheckButton checkbutton1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.PaperWalletWindow
			this.Name = "IhildaWallet.PaperWalletWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("PaperWalletWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child IhildaWallet.PaperWalletWindow.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.eventbox1 = new global::Gtk.EventBox();
			this.eventbox1.Name = "eventbox1";
			// Container child eventbox1.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.addresslabel = new global::Gtk.Label();
			this.addresslabel.Name = "addresslabel";
			this.addresslabel.Xalign = 0F;
			this.addresslabel.LabelProp = global::Mono.Unix.Catalog.GetString("<span fgcolor=\"green\">address</span>");
			this.addresslabel.UseMarkup = true;
			this.table1.Add(this.addresslabel);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.addresslabel]));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.image5 = new global::Gtk.Image();
			this.image5.Name = "image5";
			this.image5.Xalign = 0F;
			this.table1.Add(this.image5);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.image5]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			// Container child table1.Gtk.Table+TableChild
			this.image6 = new global::Gtk.Image();
			this.image6.Name = "image6";
			this.image6.Xalign = 0F;
			this.table1.Add(this.image6);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.image6]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			// Container child table1.Gtk.Table+TableChild
			this.secretlabel = new global::Gtk.Label();
			this.secretlabel.Name = "secretlabel";
			this.secretlabel.Xalign = 0F;
			this.secretlabel.LabelProp = global::Mono.Unix.Catalog.GetString("<span fgcolor=\"red\">secret</span>");
			this.secretlabel.UseMarkup = true;
			this.table1.Add(this.secretlabel);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.secretlabel]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			this.eventbox1.Add(this.table1);
			this.vbox2.Add(this.eventbox1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.eventbox1]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xpad = 5;
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Notes :");
			this.vbox3.Add(this.label5);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.label5]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textview3 = new global::Gtk.TextView();
			this.textview3.TooltipMarkup = "Any text typed in this box will be printed to the paper wallet";
			this.textview3.CanFocus = true;
			this.textview3.Name = "textview3";
			this.GtkScrolledWindow.Add(this.textview3);
			this.vbox3.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.GtkScrolledWindow]));
			w9.Position = 1;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.button138 = new global::Gtk.Button();
			this.button138.CanFocus = true;
			this.button138.Name = "button138";
			this.button138.UseUnderline = true;
			this.button138.Label = global::Mono.Unix.Catalog.GetString("Save PDF");
			this.hbox2.Add(this.button138);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.button138]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.checkbutton1 = new global::Gtk.CheckButton();
			this.checkbutton1.CanFocus = true;
			this.checkbutton1.Name = "checkbutton1";
			this.checkbutton1.Label = global::Mono.Unix.Catalog.GetString("Show Secret");
			this.checkbutton1.DrawIndicator = true;
			this.checkbutton1.UseUnderline = true;
			this.hbox2.Add(this.checkbutton1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.checkbutton1]));
			w11.PackType = ((global::Gtk.PackType)(1));
			w11.Position = 1;
			w11.Expand = false;
			this.vbox3.Add(this.hbox2);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox2]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			this.vbox2.Add(this.vbox3);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox3]));
			w13.Position = 1;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 942;
			this.DefaultHeight = 469;
			this.image6.Hide();
			this.secretlabel.Hide();
			this.Show();
		}
	}
}