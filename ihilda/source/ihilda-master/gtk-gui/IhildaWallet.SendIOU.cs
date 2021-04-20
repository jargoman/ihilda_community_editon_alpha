
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class SendIOU
	{
		private global::Gtk.VBox vbox3;

		private global::Gtk.Label label11;

		private global::Gtk.HSeparator hseparator6;

		private global::Gtk.Label infobar;

		private global::Gtk.Table table3;

		private global::Gtk.Entry destinationentry;

		private global::Gtk.ComboBoxEntry destinationTagcomboboxentry;

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

		private global::Gtk.ComboBoxEntry amountentry;

		private global::Gtk.CheckButton checkbuttonpartial;

		private global::Gtk.HBox hbox4;

		private global::Gtk.HScale hscale2;

		private global::Gtk.Label label2;

		private global::Gtk.HBox hbox5;

		private global::Gtk.ComboBoxEntry currencycomboboxentry;

		private global::Gtk.Label balancelabel;

		private global::Gtk.Label label14;

		private global::Gtk.ComboBoxEntry issuerentry;

		private global::Gtk.Label label1;

		private global::Gtk.Label label12;

		private global::Gtk.Label label13;

		private global::Gtk.Label label16;

		private global::Gtk.Label label17;

		private global::Gtk.Label label18;

		private global::Gtk.Label label3;

		private global::IhildaWallet.MemoWidget memowidget1;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Button sendIOUButton;

		private global::Gtk.HSeparator hseparator7;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.SendIOU
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.SendIOU";
			// Container child IhildaWallet.SendIOU.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			this.vbox3.BorderWidth = ((uint)(5));
			// Container child vbox3.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("<span size=\"x-large\"><b><u>Send IOU</u></b></span>");
			this.label11.UseMarkup = true;
			this.vbox3.Add(this.label11);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.label11]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hseparator6 = new global::Gtk.HSeparator();
			this.hseparator6.Name = "hseparator6";
			this.vbox3.Add(this.hseparator6);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hseparator6]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			w2.Padding = ((uint)(5));
			// Container child vbox3.Gtk.Box+BoxChild
			this.infobar = new global::Gtk.Label();
			this.infobar.Name = "infobar";
			this.infobar.Xalign = 0F;
			this.infobar.LabelProp = global::Mono.Unix.Catalog.GetString("<span fgcolor=\"green\">Use this interface to send an IOU from one account to anoth" +
					"er</span>");
			this.infobar.UseMarkup = true;
			this.vbox3.Add(this.infobar);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.infobar]));
			w3.Position = 2;
			// Container child vbox3.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table(((uint)(7)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.destinationentry = new global::Gtk.Entry();
			this.destinationentry.CanFocus = true;
			this.destinationentry.Name = "destinationentry";
			this.destinationentry.IsEditable = true;
			this.destinationentry.InvisibleChar = '●';
			this.table3.Add(this.destinationentry);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table3[this.destinationentry]));
			w4.TopAttach = ((uint)(5));
			w4.BottomAttach = ((uint)(6));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.destinationTagcomboboxentry = global::Gtk.ComboBoxEntry.NewText();
			this.destinationTagcomboboxentry.Name = "destinationTagcomboboxentry";
			this.table3.Add(this.destinationTagcomboboxentry);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table3[this.destinationTagcomboboxentry]));
			w5.TopAttach = ((uint)(6));
			w5.BottomAttach = ((uint)(7));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
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
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button114]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button115 = new global::Gtk.Button();
			this.button115.CanFocus = true;
			this.button115.Name = "button115";
			this.button115.UseUnderline = true;
			this.button115.Label = global::Mono.Unix.Catalog.GetString("2%");
			this.hbox1.Add(this.button115);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button115]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button111 = new global::Gtk.Button();
			this.button111.CanFocus = true;
			this.button111.Name = "button111";
			this.button111.UseUnderline = true;
			this.button111.Label = global::Mono.Unix.Catalog.GetString("5 %");
			this.hbox1.Add(this.button111);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button111]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button112 = new global::Gtk.Button();
			this.button112.CanFocus = true;
			this.button112.Name = "button112";
			this.button112.UseUnderline = true;
			this.button112.Label = global::Mono.Unix.Catalog.GetString("10%");
			this.hbox1.Add(this.button112);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button112]));
			w9.Position = 3;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button123 = new global::Gtk.Button();
			this.button123.CanFocus = true;
			this.button123.Name = "button123";
			this.button123.UseUnderline = true;
			this.button123.Label = global::Mono.Unix.Catalog.GetString("15%");
			this.hbox1.Add(this.button123);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button123]));
			w10.Position = 4;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button113 = new global::Gtk.Button();
			this.button113.CanFocus = true;
			this.button113.Name = "button113";
			this.button113.UseUnderline = true;
			this.button113.Label = global::Mono.Unix.Catalog.GetString("25%");
			this.hbox1.Add(this.button113);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button113]));
			w11.Position = 5;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button119 = new global::Gtk.Button();
			this.button119.CanFocus = true;
			this.button119.Name = "button119";
			this.button119.UseUnderline = true;
			this.button119.Label = global::Mono.Unix.Catalog.GetString("33%");
			this.hbox1.Add(this.button119);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button119]));
			w12.Position = 6;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button116 = new global::Gtk.Button();
			this.button116.CanFocus = true;
			this.button116.Name = "button116";
			this.button116.UseUnderline = true;
			this.button116.Label = global::Mono.Unix.Catalog.GetString("50%");
			this.hbox1.Add(this.button116);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button116]));
			w13.Position = 7;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button120 = new global::Gtk.Button();
			this.button120.CanFocus = true;
			this.button120.Name = "button120";
			this.button120.UseUnderline = true;
			this.button120.Label = global::Mono.Unix.Catalog.GetString("66%");
			this.hbox1.Add(this.button120);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button120]));
			w14.Position = 8;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button117 = new global::Gtk.Button();
			this.button117.CanFocus = true;
			this.button117.Name = "button117";
			this.button117.UseUnderline = true;
			this.button117.Label = global::Mono.Unix.Catalog.GetString("75%");
			this.hbox1.Add(this.button117);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button117]));
			w15.Position = 9;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button118 = new global::Gtk.Button();
			this.button118.CanFocus = true;
			this.button118.Name = "button118";
			this.button118.UseUnderline = true;
			this.button118.Label = global::Mono.Unix.Catalog.GetString("80%");
			this.hbox1.Add(this.button118);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button118]));
			w16.Position = 10;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button121 = new global::Gtk.Button();
			this.button121.CanFocus = true;
			this.button121.Name = "button121";
			this.button121.UseUnderline = true;
			this.button121.Label = global::Mono.Unix.Catalog.GetString("90%");
			this.hbox1.Add(this.button121);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button121]));
			w17.Position = 11;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button122 = new global::Gtk.Button();
			this.button122.CanFocus = true;
			this.button122.Name = "button122";
			this.button122.UseUnderline = true;
			this.button122.Label = global::Mono.Unix.Catalog.GetString("100%");
			this.hbox1.Add(this.button122);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button122]));
			w18.Position = 12;
			w18.Expand = false;
			w18.Fill = false;
			this.table3.Add(this.hbox1);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table3[this.hbox1]));
			w19.TopAttach = ((uint)(4));
			w19.BottomAttach = ((uint)(5));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.amountentry = global::Gtk.ComboBoxEntry.NewText();
			this.amountentry.Name = "amountentry";
			this.hbox2.Add(this.amountentry);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.amountentry]));
			w20.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.checkbuttonpartial = new global::Gtk.CheckButton();
			this.checkbuttonpartial.CanFocus = true;
			this.checkbuttonpartial.Name = "checkbuttonpartial";
			this.checkbuttonpartial.Label = global::Mono.Unix.Catalog.GetString("partial");
			this.checkbuttonpartial.Active = true;
			this.checkbuttonpartial.DrawIndicator = true;
			this.checkbuttonpartial.UseUnderline = true;
			this.hbox2.Add(this.checkbuttonpartial);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.checkbuttonpartial]));
			w21.PackType = ((global::Gtk.PackType)(1));
			w21.Position = 1;
			w21.Expand = false;
			this.table3.Add(this.hbox2);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table3[this.hbox2]));
			w22.TopAttach = ((uint)(2));
			w22.BottomAttach = ((uint)(3));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.hscale2 = new global::Gtk.HScale(null);
			this.hscale2.CanFocus = true;
			this.hscale2.Name = "hscale2";
			this.hscale2.Adjustment.Upper = 100D;
			this.hscale2.Adjustment.PageIncrement = 10D;
			this.hscale2.Adjustment.StepIncrement = 1D;
			this.hscale2.DrawValue = true;
			this.hscale2.Digits = 2;
			this.hscale2.ValuePos = ((global::Gtk.PositionType)(1));
			this.hbox4.Add(this.hscale2);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.hscale2]));
			w23.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("%");
			this.hbox4.Add(this.label2);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label2]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			this.table3.Add(this.hbox4);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table3[this.hbox4]));
			w25.TopAttach = ((uint)(3));
			w25.BottomAttach = ((uint)(4));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.currencycomboboxentry = global::Gtk.ComboBoxEntry.NewText();
			this.currencycomboboxentry.Name = "currencycomboboxentry";
			this.hbox5.Add(this.currencycomboboxentry);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.currencycomboboxentry]));
			w26.Position = 0;
			// Container child hbox5.Gtk.Box+BoxChild
			this.balancelabel = new global::Gtk.Label();
			this.balancelabel.Name = "balancelabel";
			this.balancelabel.LabelProp = global::Mono.Unix.Catalog.GetString("   --   unsynced   --   ");
			this.balancelabel.Selectable = true;
			this.hbox5.Add(this.balancelabel);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.balancelabel]));
			w27.PackType = ((global::Gtk.PackType)(1));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label14 = new global::Gtk.Label();
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Balance</b>");
			this.label14.UseMarkup = true;
			this.hbox5.Add(this.label14);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label14]));
			w28.PackType = ((global::Gtk.PackType)(1));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			this.table3.Add(this.hbox5);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table3[this.hbox5]));
			w29.LeftAttach = ((uint)(1));
			w29.RightAttach = ((uint)(2));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.issuerentry = global::Gtk.ComboBoxEntry.NewText();
			this.issuerentry.Name = "issuerentry";
			this.table3.Add(this.issuerentry);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table3[this.issuerentry]));
			w30.TopAttach = ((uint)(1));
			w30.BottomAttach = ((uint)(2));
			w30.LeftAttach = ((uint)(1));
			w30.RightAttach = ((uint)(2));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.table3.Add(this.label1);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table3[this.label1]));
			w31.TopAttach = ((uint)(3));
			w31.BottomAttach = ((uint)(4));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.Xalign = 0F;
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Amount</b>");
			this.label12.UseMarkup = true;
			this.table3.Add(this.label12);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table3[this.label12]));
			w32.TopAttach = ((uint)(2));
			w32.BottomAttach = ((uint)(3));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label();
			this.label13.Name = "label13";
			this.label13.Xalign = 0F;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Currency</b>");
			this.label13.UseMarkup = true;
			this.table3.Add(this.label13);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table3[this.label13]));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label16 = new global::Gtk.Label();
			this.label16.Name = "label16";
			this.label16.Xalign = 0F;
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Destination</b>");
			this.label16.UseMarkup = true;
			this.table3.Add(this.label16);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table3[this.label16]));
			w34.TopAttach = ((uint)(5));
			w34.BottomAttach = ((uint)(6));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label17 = new global::Gtk.Label();
			this.label17.Name = "label17";
			this.label17.Xalign = 0F;
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Issuer</b>");
			this.label17.UseMarkup = true;
			this.table3.Add(this.label17);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table3[this.label17]));
			w35.TopAttach = ((uint)(1));
			w35.BottomAttach = ((uint)(2));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label18 = new global::Gtk.Label();
			this.label18.Name = "label18";
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Destination Tag</b>");
			this.label18.UseMarkup = true;
			this.table3.Add(this.label18);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table3[this.label18]));
			w36.TopAttach = ((uint)(6));
			w36.BottomAttach = ((uint)(7));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.table3.Add(this.label3);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table3[this.label3]));
			w37.TopAttach = ((uint)(4));
			w37.BottomAttach = ((uint)(5));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add(this.table3);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.table3]));
			w38.Position = 3;
			// Container child vbox3.Gtk.Box+BoxChild
			this.memowidget1 = new global::IhildaWallet.MemoWidget();
			this.memowidget1.Events = ((global::Gdk.EventMask)(256));
			this.memowidget1.Name = "memowidget1";
			this.vbox3.Add(this.memowidget1);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.memowidget1]));
			w39.Position = 4;
			w39.Expand = false;
			w39.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Homogeneous = true;
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.sendIOUButton = new global::Gtk.Button();
			this.sendIOUButton.CanFocus = true;
			this.sendIOUButton.Name = "sendIOUButton";
			this.sendIOUButton.UseUnderline = true;
			this.sendIOUButton.Label = global::Mono.Unix.Catalog.GetString("Proceed to Payment Manager (Send IOU)");
			this.hbox3.Add(this.sendIOUButton);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.sendIOUButton]));
			w40.Position = 0;
			this.vbox3.Add(this.hbox3);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox3]));
			w41.PackType = ((global::Gtk.PackType)(1));
			w41.Position = 5;
			w41.Expand = false;
			w41.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hseparator7 = new global::Gtk.HSeparator();
			this.hseparator7.Name = "hseparator7";
			this.vbox3.Add(this.hseparator7);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hseparator7]));
			w42.PackType = ((global::Gtk.PackType)(1));
			w42.Position = 6;
			w42.Expand = false;
			w42.Fill = false;
			this.Add(this.vbox3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
