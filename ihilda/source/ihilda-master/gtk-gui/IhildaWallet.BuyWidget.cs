
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class BuyWidget
	{
		private global::Gtk.VBox vbox5;

		private global::Gtk.Label label10;

		private global::Gtk.Table table4;

		private global::Gtk.ComboBoxEntry amountcomboboxentry;

		private global::Gtk.ComboBoxEntry comboboxentry1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button button114;

		private global::Gtk.Button button115;

		private global::Gtk.Button button111;

		private global::Gtk.Button button112;

		private global::Gtk.Button button123;

		private global::Gtk.Button button113;

		private global::Gtk.Button button119;

		private global::Gtk.Button button116;

		private global::Gtk.Button button120;

		private global::Gtk.Button button117;

		private global::Gtk.Button button118;

		private global::Gtk.Button button121;

		private global::Gtk.Button button122;

		private global::Gtk.HBox hbox2;

		private global::Gtk.HScale hscale2;

		private global::Gtk.Label label2;

		private global::Gtk.Label infobar;

		private global::Gtk.Label label1;

		private global::Gtk.Label label11;

		private global::Gtk.Label label12;

		private global::Gtk.Label label13;

		private global::Gtk.Label label14;

		private global::Gtk.Label label15;

		private global::Gtk.Label label16;

		private global::Gtk.Label label18;

		private global::Gtk.Label label19;

		private global::Gtk.Label label20;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.ComboBoxEntry maxcomboboxentry;

		private global::Gtk.ComboBoxEntry pricecomboboxentry;

		private global::Gtk.HSeparator hseparator3;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Button buybutton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.BuyWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.BuyWidget";
			// Container child IhildaWallet.BuyWidget.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("<b><u>Buy ICE</u></b>");
			this.label10.UseMarkup = true;
			this.vbox5.Add(this.label10);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.label10]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.table4 = new global::Gtk.Table(((uint)(7)), ((uint)(3)), false);
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(6));
			this.table4.ColumnSpacing = ((uint)(6));
			// Container child table4.Gtk.Table+TableChild
			this.amountcomboboxentry = global::Gtk.ComboBoxEntry.NewText();
			this.amountcomboboxentry.Name = "amountcomboboxentry";
			this.table4.Add(this.amountcomboboxentry);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table4[this.amountcomboboxentry]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.comboboxentry1 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry1.Name = "comboboxentry1";
			this.table4.Add(this.comboboxentry1);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table4[this.comboboxentry1]));
			w3.TopAttach = ((uint)(6));
			w3.BottomAttach = ((uint)(7));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button114 = new global::Gtk.Button();
			this.button114.CanFocus = true;
			this.button114.Name = "button114";
			this.button114.UseUnderline = true;
			this.button114.Label = global::Mono.Unix.Catalog.GetString("1%");
			this.hbox1.Add(this.button114);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button114]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button115 = new global::Gtk.Button();
			this.button115.CanFocus = true;
			this.button115.Name = "button115";
			this.button115.UseUnderline = true;
			this.button115.Label = global::Mono.Unix.Catalog.GetString("2%");
			this.hbox1.Add(this.button115);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button115]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button111 = new global::Gtk.Button();
			this.button111.CanFocus = true;
			this.button111.Name = "button111";
			this.button111.UseUnderline = true;
			this.button111.Label = global::Mono.Unix.Catalog.GetString("5 %");
			this.hbox1.Add(this.button111);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button111]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button112 = new global::Gtk.Button();
			this.button112.CanFocus = true;
			this.button112.Name = "button112";
			this.button112.UseUnderline = true;
			this.button112.Label = global::Mono.Unix.Catalog.GetString("10%");
			this.hbox1.Add(this.button112);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button112]));
			w7.Position = 3;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button123 = new global::Gtk.Button();
			this.button123.CanFocus = true;
			this.button123.Name = "button123";
			this.button123.UseUnderline = true;
			this.button123.Label = global::Mono.Unix.Catalog.GetString("15%");
			this.hbox1.Add(this.button123);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button123]));
			w8.Position = 4;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button113 = new global::Gtk.Button();
			this.button113.CanFocus = true;
			this.button113.Name = "button113";
			this.button113.UseUnderline = true;
			this.button113.Label = global::Mono.Unix.Catalog.GetString("25%");
			this.hbox1.Add(this.button113);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button113]));
			w9.Position = 5;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button119 = new global::Gtk.Button();
			this.button119.CanFocus = true;
			this.button119.Name = "button119";
			this.button119.UseUnderline = true;
			this.button119.Label = global::Mono.Unix.Catalog.GetString("33%");
			this.hbox1.Add(this.button119);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button119]));
			w10.Position = 6;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button116 = new global::Gtk.Button();
			this.button116.CanFocus = true;
			this.button116.Name = "button116";
			this.button116.UseUnderline = true;
			this.button116.Label = global::Mono.Unix.Catalog.GetString("50%");
			this.hbox1.Add(this.button116);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button116]));
			w11.Position = 7;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button120 = new global::Gtk.Button();
			this.button120.CanFocus = true;
			this.button120.Name = "button120";
			this.button120.UseUnderline = true;
			this.button120.Label = global::Mono.Unix.Catalog.GetString("66%");
			this.hbox1.Add(this.button120);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button120]));
			w12.Position = 8;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button117 = new global::Gtk.Button();
			this.button117.CanFocus = true;
			this.button117.Name = "button117";
			this.button117.UseUnderline = true;
			this.button117.Label = global::Mono.Unix.Catalog.GetString("75%");
			this.hbox1.Add(this.button117);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button117]));
			w13.Position = 9;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button118 = new global::Gtk.Button();
			this.button118.CanFocus = true;
			this.button118.Name = "button118";
			this.button118.UseUnderline = true;
			this.button118.Label = global::Mono.Unix.Catalog.GetString("80%");
			this.hbox1.Add(this.button118);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button118]));
			w14.Position = 10;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button121 = new global::Gtk.Button();
			this.button121.CanFocus = true;
			this.button121.Name = "button121";
			this.button121.UseUnderline = true;
			this.button121.Label = global::Mono.Unix.Catalog.GetString("90%");
			this.hbox1.Add(this.button121);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button121]));
			w15.Position = 11;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button122 = new global::Gtk.Button();
			this.button122.CanFocus = true;
			this.button122.Name = "button122";
			this.button122.UseUnderline = true;
			this.button122.Label = global::Mono.Unix.Catalog.GetString("100%");
			this.hbox1.Add(this.button122);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button122]));
			w16.Position = 12;
			w16.Expand = false;
			w16.Fill = false;
			this.table4.Add(this.hbox1);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table4[this.hbox1]));
			w17.TopAttach = ((uint)(3));
			w17.BottomAttach = ((uint)(4));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.hscale2 = new global::Gtk.HScale(null);
			this.hscale2.CanFocus = true;
			this.hscale2.Name = "hscale2";
			this.hscale2.Adjustment.Upper = 100D;
			this.hscale2.Adjustment.PageIncrement = 10D;
			this.hscale2.Adjustment.StepIncrement = 1D;
			this.hscale2.DrawValue = true;
			this.hscale2.Digits = 2;
			this.hscale2.ValuePos = ((global::Gtk.PositionType)(1));
			this.hbox2.Add(this.hscale2);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.hscale2]));
			w18.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("%");
			this.hbox2.Add(this.label2);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label2]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			this.table4.Add(this.hbox2);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table4[this.hbox2]));
			w20.TopAttach = ((uint)(2));
			w20.BottomAttach = ((uint)(3));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.infobar = new global::Gtk.Label();
			this.infobar.Name = "infobar";
			this.infobar.LabelProp = global::Mono.Unix.Catalog.GetString("<span fgcolor=\"red\">This is an infobar</span>");
			this.infobar.UseMarkup = true;
			this.table4.Add(this.infobar);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table4[this.infobar]));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Mark As");
			this.table4.Add(this.label1);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table4[this.label1]));
			w22.TopAttach = ((uint)(6));
			w22.BottomAttach = ((uint)(7));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.Xalign = 0F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Amount to <span foreground=\"green\">Buy</span>");
			this.label11.UseMarkup = true;
			this.table4.Add(this.label11);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table4[this.label11]));
			w23.TopAttach = ((uint)(1));
			w23.BottomAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("ICE");
			this.table4.Add(this.label12);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table4[this.label12]));
			w24.TopAttach = ((uint)(1));
			w24.BottomAttach = ((uint)(2));
			w24.LeftAttach = ((uint)(2));
			w24.RightAttach = ((uint)(3));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label();
			this.label13.Name = "label13";
			this.label13.Xalign = 0F;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("Price of each");
			this.table4.Add(this.label13);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table4[this.label13]));
			w25.TopAttach = ((uint)(4));
			w25.BottomAttach = ((uint)(5));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label14 = new global::Gtk.Label();
			this.label14.Name = "label14";
			this.label14.Xalign = 0F;
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString("Max order value");
			this.table4.Add(this.label14);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table4[this.label14]));
			w26.TopAttach = ((uint)(5));
			w26.BottomAttach = ((uint)(6));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label();
			this.label15.Name = "label15";
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString("XRP");
			this.table4.Add(this.label15);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table4[this.label15]));
			w27.TopAttach = ((uint)(4));
			w27.BottomAttach = ((uint)(5));
			w27.LeftAttach = ((uint)(2));
			w27.RightAttach = ((uint)(3));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label16 = new global::Gtk.Label();
			this.label16.Name = "label16";
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString("XRP");
			this.table4.Add(this.label16);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table4[this.label16]));
			w28.TopAttach = ((uint)(5));
			w28.BottomAttach = ((uint)(6));
			w28.LeftAttach = ((uint)(2));
			w28.RightAttach = ((uint)(3));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label18 = new global::Gtk.Label();
			this.label18.Name = "label18";
			this.table4.Add(this.label18);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table4[this.label18]));
			w29.TopAttach = ((uint)(6));
			w29.BottomAttach = ((uint)(7));
			w29.LeftAttach = ((uint)(2));
			w29.RightAttach = ((uint)(3));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label19 = new global::Gtk.Label();
			this.label19.Name = "label19";
			this.table4.Add(this.label19);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table4[this.label19]));
			w30.LeftAttach = ((uint)(2));
			w30.RightAttach = ((uint)(3));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label20 = new global::Gtk.Label();
			this.label20.Name = "label20";
			this.table4.Add(this.label20);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table4[this.label20]));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.table4.Add(this.label3);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table4[this.label3]));
			w32.TopAttach = ((uint)(2));
			w32.BottomAttach = ((uint)(3));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.table4.Add(this.label4);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table4[this.label4]));
			w33.TopAttach = ((uint)(3));
			w33.BottomAttach = ((uint)(4));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.table4.Add(this.label5);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table4[this.label5]));
			w34.TopAttach = ((uint)(2));
			w34.BottomAttach = ((uint)(3));
			w34.LeftAttach = ((uint)(2));
			w34.RightAttach = ((uint)(3));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.table4.Add(this.label6);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table4[this.label6]));
			w35.TopAttach = ((uint)(3));
			w35.BottomAttach = ((uint)(4));
			w35.LeftAttach = ((uint)(2));
			w35.RightAttach = ((uint)(3));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.maxcomboboxentry = global::Gtk.ComboBoxEntry.NewText();
			this.maxcomboboxentry.Name = "maxcomboboxentry";
			this.table4.Add(this.maxcomboboxentry);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table4[this.maxcomboboxentry]));
			w36.TopAttach = ((uint)(5));
			w36.BottomAttach = ((uint)(6));
			w36.LeftAttach = ((uint)(1));
			w36.RightAttach = ((uint)(2));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.pricecomboboxentry = global::Gtk.ComboBoxEntry.NewText();
			this.pricecomboboxentry.Name = "pricecomboboxentry";
			this.table4.Add(this.pricecomboboxentry);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table4[this.pricecomboboxentry]));
			w37.TopAttach = ((uint)(4));
			w37.BottomAttach = ((uint)(5));
			w37.LeftAttach = ((uint)(1));
			w37.RightAttach = ((uint)(2));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox5.Add(this.table4);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.table4]));
			w38.Position = 1;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hseparator3 = new global::Gtk.HSeparator();
			this.hseparator3.Name = "hseparator3";
			this.vbox5.Add(this.hseparator3);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hseparator3]));
			w39.Position = 2;
			w39.Expand = false;
			w39.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Homogeneous = true;
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.buybutton = new global::Gtk.Button();
			this.buybutton.CanFocus = true;
			this.buybutton.Name = "buybutton";
			this.buybutton.UseUnderline = true;
			this.buybutton.Label = global::Mono.Unix.Catalog.GetString("_Proceed to Order Manager (<span fgcolor=\"green\">Buy</span>)");
			this.hbox6.Add(this.buybutton);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.buybutton]));
			w40.Position = 0;
			this.vbox5.Add(this.hbox6);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox6]));
			w41.Position = 3;
			w41.Expand = false;
			w41.Fill = false;
			this.Add(this.vbox5);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
