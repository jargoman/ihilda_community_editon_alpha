
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class CascadedSellWidget
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label label10;

		private global::Gtk.Table table1;

		private global::Gtk.ComboBoxEntry amountentry;

		private global::Gtk.ComboBoxEntry amountmodentry;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.HSeparator hseparator2;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.ComboBoxEntry numberentry;

		private global::Gtk.ComboBoxEntry priceentry;

		private global::Gtk.ComboBoxEntry pricemodentry;

		private global::Gtk.Expander expander1;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Table table2;

		private global::Gtk.Label buytotallabel;

		private global::Gtk.Label costtotallabel;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		private global::Gtk.Label label9;

		private global::Gtk.Label pricetotallabel;

		private global::Gtk.Label selltotallabel;

		private global::Gtk.Label GtkLabel2;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Button sellbutton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.CascadedSellWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.CascadedSellWidget";
			// Container child IhildaWallet.CascadedSellWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("<b><u>Sell ICE</u></b>");
			this.label10.UseMarkup = true;
			this.vbox1.Add(this.label10);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label10]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(7)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.amountentry = global::Gtk.ComboBoxEntry.NewText();
			this.amountentry.Name = "amountentry";
			this.table1.Add(this.amountentry);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.amountentry]));
			w2.TopAttach = ((uint)(5));
			w2.BottomAttach = ((uint)(6));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.amountmodentry = global::Gtk.ComboBoxEntry.NewText();
			this.amountmodentry.Name = "amountmodentry";
			this.table1.Add(this.amountmodentry);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.amountmodentry]));
			w3.TopAttach = ((uint)(6));
			w3.BottomAttach = ((uint)(7));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.table1.Add(this.hseparator1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.hseparator1]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator2 = new global::Gtk.HSeparator();
			this.hseparator2.Name = "hseparator2";
			this.table1.Add(this.hseparator2);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.hseparator2]));
			w5.TopAttach = ((uint)(4));
			w5.BottomAttach = ((uint)(5));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Number of Orders");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Starting Price");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Price Modifier");
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w8.TopAttach = ((uint)(3));
			w8.BottomAttach = ((uint)(4));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Amount");
			this.table1.Add(this.label4);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w9.TopAttach = ((uint)(5));
			w9.BottomAttach = ((uint)(6));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Amount Modifier");
			this.table1.Add(this.label5);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w10.TopAttach = ((uint)(6));
			w10.BottomAttach = ((uint)(7));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.numberentry = global::Gtk.ComboBoxEntry.NewText();
			this.numberentry.Name = "numberentry";
			this.table1.Add(this.numberentry);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.numberentry]));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.priceentry = global::Gtk.ComboBoxEntry.NewText();
			this.priceentry.Name = "priceentry";
			this.table1.Add(this.priceentry);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.priceentry]));
			w12.TopAttach = ((uint)(2));
			w12.BottomAttach = ((uint)(3));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.pricemodentry = global::Gtk.ComboBoxEntry.NewText();
			this.pricemodentry.Name = "pricemodentry";
			this.table1.Add(this.pricemodentry);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.pricemodentry]));
			w13.TopAttach = ((uint)(3));
			w13.BottomAttach = ((uint)(4));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table1]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.expander1 = new global::Gtk.Expander(null);
			this.expander1.CanFocus = true;
			this.expander1.Name = "expander1";
			this.expander1.Expanded = true;
			// Container child expander1.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Homogeneous = true;
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table(((uint)(4)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.buytotallabel = new global::Gtk.Label();
			this.buytotallabel.Name = "buytotallabel";
			this.buytotallabel.Xalign = 0F;
			this.table2.Add(this.buytotallabel);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table2[this.buytotallabel]));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.costtotallabel = new global::Gtk.Label();
			this.costtotallabel.Name = "costtotallabel";
			this.costtotallabel.Xalign = 0F;
			this.table2.Add(this.costtotallabel);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table2[this.costtotallabel]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Buy Total");
			this.table2.Add(this.label6);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2[this.label6]));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.Xalign = 0F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Sell Total");
			this.table2.Add(this.label7);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table2[this.label7]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.Xalign = 0F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Price Total");
			this.table2.Add(this.label8);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table2[this.label8]));
			w19.TopAttach = ((uint)(2));
			w19.BottomAttach = ((uint)(3));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.Xalign = 0F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Cost Total");
			this.table2.Add(this.label9);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table2[this.label9]));
			w20.TopAttach = ((uint)(3));
			w20.BottomAttach = ((uint)(4));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.pricetotallabel = new global::Gtk.Label();
			this.pricetotallabel.Name = "pricetotallabel";
			this.pricetotallabel.Xalign = 0F;
			this.table2.Add(this.pricetotallabel);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table2[this.pricetotallabel]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.selltotallabel = new global::Gtk.Label();
			this.selltotallabel.Name = "selltotallabel";
			this.selltotallabel.Xalign = 0F;
			this.table2.Add(this.selltotallabel);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table2[this.selltotallabel]));
			w22.TopAttach = ((uint)(1));
			w22.BottomAttach = ((uint)(2));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add(this.table2);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.table2]));
			w23.Position = 0;
			this.expander1.Add(this.vbox3);
			this.GtkLabel2 = new global::Gtk.Label();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString("Total");
			this.GtkLabel2.UseUnderline = true;
			this.expander1.LabelWidget = this.GtkLabel2;
			this.vbox1.Add(this.expander1);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.expander1]));
			w25.Position = 2;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Homogeneous = true;
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.sellbutton = new global::Gtk.Button();
			this.sellbutton.CanFocus = true;
			this.sellbutton.Name = "sellbutton";
			this.sellbutton.UseUnderline = true;
			this.sellbutton.Label = "_Proceed to Order Manager ( <span fgcolor=\"red\">Sell</span> )";
			this.hbox6.Add(this.sellbutton);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.sellbutton]));
			w26.Position = 0;
			this.vbox1.Add(this.hbox6);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox6]));
			w27.PackType = ((global::Gtk.PackType)(1));
			w27.Position = 3;
			w27.Expand = false;
			w27.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
