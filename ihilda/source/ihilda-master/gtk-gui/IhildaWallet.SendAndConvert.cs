
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class SendAndConvert
	{
		private global::Gtk.VBox vbox4;

		private global::Gtk.Label label18;

		private global::Gtk.HSeparator hseparator8;

		private global::Gtk.Label infobar;

		private global::Gtk.Table table5;

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

		private global::Gtk.HScale hscale2;

		private global::Gtk.Label label2;

		private global::Gtk.HBox hbox5;

		private global::Gtk.ComboBoxEntry sendcurrencyentry;

		private global::Gtk.Label label14;

		private global::Gtk.Label balancelabel;

		private global::Gtk.HBox hbox6;

		private global::Gtk.ComboBoxEntry sendmaxentry;

		private global::Gtk.Label sendMaxCurrencyLabel;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Entry receiveamountentry;

		private global::Gtk.ComboBoxEntry destCurrencyEntry;

		private global::Gtk.ComboBoxEntry issuerentry;

		private global::Gtk.Label label1;

		private global::Gtk.Label label12;

		private global::Gtk.Label label13;

		private global::Gtk.Label label16;

		private global::Gtk.Label label17;

		private global::Gtk.Label label19;

		private global::Gtk.Label label21;

		private global::Gtk.Label label3;

		private global::IhildaWallet.MemoWidget memowidget1;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Button sendbutton;

		private global::Gtk.HSeparator hseparator9;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.SendAndConvert
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.SendAndConvert";
			// Container child IhildaWallet.SendAndConvert.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			this.vbox4.BorderWidth = ((uint)(5));
			// Container child vbox4.Gtk.Box+BoxChild
			this.label18 = new global::Gtk.Label();
			this.label18.Name = "label18";
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString("<span size=\"x-large\"><b><u>Send And Convert</u></b></span>");
			this.label18.UseMarkup = true;
			this.vbox4.Add(this.label18);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label18]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hseparator8 = new global::Gtk.HSeparator();
			this.hseparator8.Name = "hseparator8";
			this.vbox4.Add(this.hseparator8);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hseparator8]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.infobar = new global::Gtk.Label();
			this.infobar.Name = "infobar";
			this.infobar.Xalign = 0F;
			this.infobar.LabelProp = global::Mono.Unix.Catalog.GetString("<span fgcolor=\"green\">Make a cross currency payment</span> <span fgcolor=\"red\">  " +
					"      Note: It may be easier to use the path find instead</span>");
			this.infobar.UseMarkup = true;
			this.vbox4.Add(this.infobar);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.infobar]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.table5 = new global::Gtk.Table(((uint)(8)), ((uint)(2)), false);
			this.table5.Name = "table5";
			this.table5.RowSpacing = ((uint)(6));
			this.table5.ColumnSpacing = ((uint)(6));
			// Container child table5.Gtk.Table+TableChild
			this.destinationentry = new global::Gtk.Entry();
			this.destinationentry.CanFocus = true;
			this.destinationentry.Name = "destinationentry";
			this.destinationentry.IsEditable = true;
			this.destinationentry.InvisibleChar = '●';
			this.table5.Add(this.destinationentry);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table5[this.destinationentry]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.destinationTagcomboboxentry = global::Gtk.ComboBoxEntry.NewText();
			this.destinationTagcomboboxentry.Name = "destinationTagcomboboxentry";
			this.table5.Add(this.destinationTagcomboboxentry);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table5[this.destinationTagcomboboxentry]));
			w5.TopAttach = ((uint)(3));
			w5.BottomAttach = ((uint)(4));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
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
			this.table5.Add(this.hbox1);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table5[this.hbox1]));
			w19.TopAttach = ((uint)(7));
			w19.BottomAttach = ((uint)(8));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
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
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.hscale2]));
			w20.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("%");
			this.hbox2.Add(this.label2);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label2]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			this.table5.Add(this.hbox2);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table5[this.hbox2]));
			w22.TopAttach = ((uint)(6));
			w22.BottomAttach = ((uint)(7));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.sendcurrencyentry = global::Gtk.ComboBoxEntry.NewText();
			this.sendcurrencyentry.WidthRequest = 70;
			this.sendcurrencyentry.Name = "sendcurrencyentry";
			this.hbox5.Add(this.sendcurrencyentry);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.sendcurrencyentry]));
			w23.Position = 0;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label14 = new global::Gtk.Label();
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Balance</b>");
			this.label14.UseMarkup = true;
			this.hbox5.Add(this.label14);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label14]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.balancelabel = new global::Gtk.Label();
			this.balancelabel.Name = "balancelabel";
			this.balancelabel.LabelProp = global::Mono.Unix.Catalog.GetString("   --   unsynced   --   ");
			this.hbox5.Add(this.balancelabel);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.balancelabel]));
			w25.PackType = ((global::Gtk.PackType)(1));
			w25.Position = 2;
			w25.Expand = false;
			w25.Fill = false;
			this.table5.Add(this.hbox5);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table5[this.hbox5]));
			w26.LeftAttach = ((uint)(1));
			w26.RightAttach = ((uint)(2));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.sendmaxentry = global::Gtk.ComboBoxEntry.NewText();
			this.sendmaxentry.Name = "sendmaxentry";
			this.hbox6.Add(this.sendmaxentry);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.sendmaxentry]));
			w27.Position = 0;
			// Container child hbox6.Gtk.Box+BoxChild
			this.sendMaxCurrencyLabel = new global::Gtk.Label();
			this.sendMaxCurrencyLabel.WidthRequest = 40;
			this.sendMaxCurrencyLabel.Name = "sendMaxCurrencyLabel";
			this.sendMaxCurrencyLabel.LabelProp = global::Mono.Unix.Catalog.GetString("   ");
			this.hbox6.Add(this.sendMaxCurrencyLabel);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.sendMaxCurrencyLabel]));
			w28.PackType = ((global::Gtk.PackType)(1));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			this.table5.Add(this.hbox6);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table5[this.hbox6]));
			w29.TopAttach = ((uint)(5));
			w29.BottomAttach = ((uint)(6));
			w29.LeftAttach = ((uint)(1));
			w29.RightAttach = ((uint)(2));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.receiveamountentry = new global::Gtk.Entry();
			this.receiveamountentry.CanFocus = true;
			this.receiveamountentry.Name = "receiveamountentry";
			this.receiveamountentry.IsEditable = true;
			this.receiveamountentry.InvisibleChar = '●';
			this.hbox7.Add(this.receiveamountentry);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.receiveamountentry]));
			w30.Position = 0;
			// Container child hbox7.Gtk.Box+BoxChild
			this.destCurrencyEntry = global::Gtk.ComboBoxEntry.NewText();
			this.destCurrencyEntry.AppendText(global::Mono.Unix.Catalog.GetString("USD"));
			this.destCurrencyEntry.AppendText(global::Mono.Unix.Catalog.GetString("CAD"));
			this.destCurrencyEntry.AppendText(global::Mono.Unix.Catalog.GetString("GWC"));
			this.destCurrencyEntry.WidthRequest = 70;
			this.destCurrencyEntry.Name = "destCurrencyEntry";
			this.hbox7.Add(this.destCurrencyEntry);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.destCurrencyEntry]));
			w31.Position = 1;
			w31.Expand = false;
			w31.Fill = false;
			this.table5.Add(this.hbox7);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table5[this.hbox7]));
			w32.TopAttach = ((uint)(4));
			w32.BottomAttach = ((uint)(5));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(2));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.issuerentry = global::Gtk.ComboBoxEntry.NewText();
			this.issuerentry.Name = "issuerentry";
			this.table5.Add(this.issuerentry);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table5[this.issuerentry]));
			w33.TopAttach = ((uint)(1));
			w33.BottomAttach = ((uint)(2));
			w33.LeftAttach = ((uint)(1));
			w33.RightAttach = ((uint)(2));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.table5.Add(this.label1);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table5[this.label1]));
			w34.TopAttach = ((uint)(6));
			w34.BottomAttach = ((uint)(7));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.Xalign = 0F;
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Send Max</b>");
			this.label12.UseMarkup = true;
			this.table5.Add(this.label12);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table5[this.label12]));
			w35.TopAttach = ((uint)(5));
			w35.BottomAttach = ((uint)(6));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label();
			this.label13.Name = "label13";
			this.label13.Xalign = 0F;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Currency</b>");
			this.label13.UseMarkup = true;
			this.table5.Add(this.label13);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table5[this.label13]));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label16 = new global::Gtk.Label();
			this.label16.Name = "label16";
			this.label16.Xalign = 0F;
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString("<b>They Receive</b>");
			this.label16.UseMarkup = true;
			this.table5.Add(this.label16);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table5[this.label16]));
			w37.TopAttach = ((uint)(4));
			w37.BottomAttach = ((uint)(5));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label17 = new global::Gtk.Label();
			this.label17.Name = "label17";
			this.label17.Xalign = 0F;
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Issuer</b>");
			this.label17.UseMarkup = true;
			this.table5.Add(this.label17);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table5[this.label17]));
			w38.TopAttach = ((uint)(1));
			w38.BottomAttach = ((uint)(2));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label19 = new global::Gtk.Label();
			this.label19.Name = "label19";
			this.label19.Xalign = 0F;
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Destination</b>");
			this.label19.UseMarkup = true;
			this.table5.Add(this.label19);
			global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.table5[this.label19]));
			w39.TopAttach = ((uint)(2));
			w39.BottomAttach = ((uint)(3));
			w39.XOptions = ((global::Gtk.AttachOptions)(4));
			w39.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label21 = new global::Gtk.Label();
			this.label21.Name = "label21";
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Destination Tag</b>");
			this.label21.UseMarkup = true;
			this.table5.Add(this.label21);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.table5[this.label21]));
			w40.TopAttach = ((uint)(3));
			w40.BottomAttach = ((uint)(4));
			w40.XOptions = ((global::Gtk.AttachOptions)(4));
			w40.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.table5.Add(this.label3);
			global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.table5[this.label3]));
			w41.TopAttach = ((uint)(7));
			w41.BottomAttach = ((uint)(8));
			w41.XOptions = ((global::Gtk.AttachOptions)(4));
			w41.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox4.Add(this.table5);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.table5]));
			w42.Position = 3;
			// Container child vbox4.Gtk.Box+BoxChild
			this.memowidget1 = new global::IhildaWallet.MemoWidget();
			this.memowidget1.Events = ((global::Gdk.EventMask)(256));
			this.memowidget1.Name = "memowidget1";
			this.vbox4.Add(this.memowidget1);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.memowidget1]));
			w43.Position = 4;
			w43.Expand = false;
			w43.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Homogeneous = true;
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.sendbutton = new global::Gtk.Button();
			this.sendbutton.CanFocus = true;
			this.sendbutton.Name = "sendbutton";
			this.sendbutton.UseUnderline = true;
			this.sendbutton.Label = global::Mono.Unix.Catalog.GetString("Proceed to Payment Manager ( Send and Convert)");
			this.hbox8.Add(this.sendbutton);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.sendbutton]));
			w44.Position = 0;
			this.vbox4.Add(this.hbox8);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox8]));
			w45.PackType = ((global::Gtk.PackType)(1));
			w45.Position = 5;
			w45.Expand = false;
			w45.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hseparator9 = new global::Gtk.HSeparator();
			this.hseparator9.Name = "hseparator9";
			this.vbox4.Add(this.hseparator9);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hseparator9]));
			w46.PackType = ((global::Gtk.PackType)(1));
			w46.Position = 6;
			w46.Expand = false;
			w46.Fill = false;
			this.Add(this.vbox4);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.sendcurrencyentry.Changed += new global::System.EventHandler(this.OnComboboxentryChanged);
		}
	}
}
