
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class TrustSetter
	{
		private global::Gtk.VBox vbox6;

		private global::Gtk.Label label26;

		private global::Gtk.HSeparator hseparator10;

		private global::Gtk.Table table1;

		private global::Gtk.CheckButton checkbutton5;

		private global::Gtk.ComboBoxEntry comboboxentry1;

		private global::Gtk.ComboBoxEntry comboboxentry2;

		private global::Gtk.ComboBoxEntry comboboxentry3;

		private global::Gtk.ComboBoxEntry comboboxentry4;

		private global::Gtk.ComboBoxEntry comboboxentry5;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button button2;

		private global::Gtk.Button button93;

		private global::Gtk.HSeparator hseparator2;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.TrustSetter
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.TrustSetter";
			// Container child IhildaWallet.TrustSetter.Gtk.Container+ContainerChild
			this.vbox6 = new global::Gtk.VBox();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.label26 = new global::Gtk.Label();
			this.label26.Name = "label26";
			this.label26.LabelProp = global::Mono.Unix.Catalog.GetString("<big><b><u>Trust Set</u></b></big>");
			this.label26.UseMarkup = true;
			this.label26.Justify = ((global::Gtk.Justification)(2));
			this.vbox6.Add(this.label26);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.label26]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			w1.Padding = ((uint)(5));
			// Container child vbox6.Gtk.Box+BoxChild
			this.hseparator10 = new global::Gtk.HSeparator();
			this.hseparator10.Name = "hseparator10";
			this.vbox6.Add(this.hseparator10);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hseparator10]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(6)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.checkbutton5 = new global::Gtk.CheckButton();
			this.checkbutton5.CanFocus = true;
			this.checkbutton5.Name = "checkbutton5";
			this.checkbutton5.Label = global::Mono.Unix.Catalog.GetString(" allow rippling ");
			this.checkbutton5.DrawIndicator = true;
			this.checkbutton5.UseUnderline = true;
			this.table1.Add(this.checkbutton5);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.checkbutton5]));
			w3.TopAttach = ((uint)(3));
			w3.BottomAttach = ((uint)(4));
			w3.RightAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxentry1 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry1.Name = "comboboxentry1";
			this.table1.Add(this.comboboxentry1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.comboboxentry1]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(3));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxentry2 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry2.Name = "comboboxentry2";
			this.table1.Add(this.comboboxentry2);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.comboboxentry2]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxentry3 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry3.Name = "comboboxentry3";
			this.table1.Add(this.comboboxentry3);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.comboboxentry3]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxentry4 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry4.Name = "comboboxentry4";
			this.table1.Add(this.comboboxentry4);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.comboboxentry4]));
			w7.TopAttach = ((uint)(4));
			w7.BottomAttach = ((uint)(5));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxentry5 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry5.Name = "comboboxentry5";
			this.table1.Add(this.comboboxentry5);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.comboboxentry5]));
			w8.TopAttach = ((uint)(5));
			w8.BottomAttach = ((uint)(6));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Quality In");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w9.TopAttach = ((uint)(4));
			w9.BottomAttach = ((uint)(5));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Quality Out");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w10.TopAttach = ((uint)(5));
			w10.BottomAttach = ((uint)(6));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Currency </b>");
			this.label3.UseMarkup = true;
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Issuer</b>");
			this.label4.UseMarkup = true;
			this.table1.Add(this.label4);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Amount </b>");
			this.label5.UseMarkup = true;
			this.table1.Add(this.label5);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("(optional)");
			this.table1.Add(this.label6);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.label6]));
			w14.TopAttach = ((uint)(5));
			w14.BottomAttach = ((uint)(6));
			w14.LeftAttach = ((uint)(2));
			w14.RightAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("(optional)");
			this.table1.Add(this.label7);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.label7]));
			w15.TopAttach = ((uint)(4));
			w15.BottomAttach = ((uint)(5));
			w15.LeftAttach = ((uint)(2));
			w15.RightAttach = ((uint)(3));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox6.Add(this.table1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.table1]));
			w16.Position = 2;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Homogeneous = true;
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button2 = new global::Gtk.Button();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString("Sign and submit");
			this.hbox1.Add(this.button2);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button2]));
			w17.Position = 0;
			w17.Expand = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button93 = new global::Gtk.Button();
			this.button93.CanFocus = true;
			this.button93.Name = "button93";
			this.button93.UseUnderline = true;
			this.button93.Label = global::Mono.Unix.Catalog.GetString("Sign offline");
			this.hbox1.Add(this.button93);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button93]));
			w18.Position = 1;
			w18.Expand = false;
			this.vbox6.Add(this.hbox1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox1]));
			w19.PackType = ((global::Gtk.PackType)(1));
			w19.Position = 3;
			w19.Expand = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator();
			this.hseparator2.Name = "hseparator2";
			this.vbox6.Add(this.hseparator2);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hseparator2]));
			w20.PackType = ((global::Gtk.PackType)(1));
			w20.Position = 4;
			w20.Expand = false;
			w20.Fill = false;
			this.Add(this.vbox6);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.comboboxentry4.Hide();
			this.comboboxentry5.Hide();
			this.label1.Hide();
			this.label2.Hide();
			this.label6.Hide();
			this.label7.Hide();
			this.Hide();
		}
	}
}
