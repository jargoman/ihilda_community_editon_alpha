
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class SendRipple
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Label label11;

		private global::Gtk.HSeparator hseparator4;

		private global::Gtk.Label infobar;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.Table table1;

		private global::Gtk.Label balanceLabel;

		private global::Gtk.ComboBoxEntry destinationcomboboxentry;

		private global::Gtk.ComboBoxEntry destinationTagcomboboxentry;

		private global::Gtk.HBox hbox1;

		private global::Gtk.ComboBoxEntry amountcomboboxentry;

		private global::Gtk.ComboBoxEntry unitsSelectBox;

		private global::Gtk.HBox hbox3;

		private global::Gtk.HScale hscale2;

		private global::Gtk.Label label2;

		private global::Gtk.HBox hbox4;

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

		private global::Gtk.Label label1;

		private global::Gtk.Label label12;

		private global::Gtk.Label label14;

		private global::Gtk.Label label16;

		private global::Gtk.Label label17;

		private global::Gtk.Label label3;

		private global::IhildaWallet.MemoWidget memowidget1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Button sendNativeButton;

		private global::Gtk.HSeparator hseparator5;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.SendRipple
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.SendRipple";
			// Container child IhildaWallet.SendRipple.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(5));
			// Container child vbox2.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("<span size=\"x-large\"><b><u>Send Native Currency</u></b></span>");
			this.label11.UseMarkup = true;
			this.vbox2.Add(this.label11);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label11]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator4 = new global::Gtk.HSeparator();
			this.hseparator4.Name = "hseparator4";
			this.vbox2.Add(this.hseparator4);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator4]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.infobar = new global::Gtk.Label();
			this.infobar.Name = "infobar";
			this.infobar.Xalign = 0F;
			this.infobar.LabelProp = global::Mono.Unix.Catalog.GetString("Use this interface to send XRP to another account");
			this.infobar.UseMarkup = true;
			this.vbox2.Add(this.infobar);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.infobar]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vbox2.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator1]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			w4.Padding = ((uint)(2));
			// Container child vbox2.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(6)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.balanceLabel = new global::Gtk.Label();
			this.balanceLabel.Name = "balanceLabel";
			this.balanceLabel.Xalign = 0F;
			this.balanceLabel.LabelProp = global::Mono.Unix.Catalog.GetString("   --   unsynced   --   ");
			this.balanceLabel.Selectable = true;
			this.table1.Add(this.balanceLabel);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.balanceLabel]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.destinationcomboboxentry = global::Gtk.ComboBoxEntry.NewText();
			this.destinationcomboboxentry.Name = "destinationcomboboxentry";
			this.table1.Add(this.destinationcomboboxentry);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.destinationcomboboxentry]));
			w6.TopAttach = ((uint)(4));
			w6.BottomAttach = ((uint)(5));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.destinationTagcomboboxentry = global::Gtk.ComboBoxEntry.NewText();
			this.destinationTagcomboboxentry.Name = "destinationTagcomboboxentry";
			this.table1.Add(this.destinationTagcomboboxentry);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.destinationTagcomboboxentry]));
			w7.TopAttach = ((uint)(5));
			w7.BottomAttach = ((uint)(6));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.amountcomboboxentry = global::Gtk.ComboBoxEntry.NewText();
			this.amountcomboboxentry.Name = "amountcomboboxentry";
			this.hbox1.Add(this.amountcomboboxentry);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.amountcomboboxentry]));
			w8.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.unitsSelectBox = global::Gtk.ComboBoxEntry.NewText();
			this.unitsSelectBox.AppendText(global::Mono.Unix.Catalog.GetString("XRP"));
			this.unitsSelectBox.AppendText(global::Mono.Unix.Catalog.GetString("drops"));
			this.unitsSelectBox.WidthRequest = 100;
			this.unitsSelectBox.Name = "unitsSelectBox";
			this.unitsSelectBox.Active = 0;
			this.hbox1.Add(this.unitsSelectBox);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.unitsSelectBox]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			this.table1.Add(this.hbox1);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.hbox1]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.hscale2 = new global::Gtk.HScale(null);
			this.hscale2.CanFocus = true;
			this.hscale2.Name = "hscale2";
			this.hscale2.Adjustment.Upper = 100D;
			this.hscale2.Adjustment.PageIncrement = 10D;
			this.hscale2.Adjustment.StepIncrement = 1D;
			this.hscale2.DrawValue = true;
			this.hscale2.Digits = 2;
			this.hscale2.ValuePos = ((global::Gtk.PositionType)(1));
			this.hbox3.Add(this.hscale2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.hscale2]));
			w11.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("%");
			this.hbox3.Add(this.label2);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label2]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.table1.Add(this.hbox3);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.hbox3]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.button114 = new global::Gtk.Button();
			this.button114.CanFocus = true;
			this.button114.Name = "button114";
			this.button114.UseUnderline = true;
			this.button114.Label = global::Mono.Unix.Catalog.GetString("1%");
			this.hbox4.Add(this.button114);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.button114]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.button115 = new global::Gtk.Button();
			this.button115.CanFocus = true;
			this.button115.Name = "button115";
			this.button115.UseUnderline = true;
			this.button115.Label = global::Mono.Unix.Catalog.GetString("2%");
			this.hbox4.Add(this.button115);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.button115]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.button111 = new global::Gtk.Button();
			this.button111.CanFocus = true;
			this.button111.Name = "button111";
			this.button111.UseUnderline = true;
			this.button111.Label = global::Mono.Unix.Catalog.GetString("5 %");
			this.hbox4.Add(this.button111);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.button111]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.button112 = new global::Gtk.Button();
			this.button112.CanFocus = true;
			this.button112.Name = "button112";
			this.button112.UseUnderline = true;
			this.button112.Label = global::Mono.Unix.Catalog.GetString("10%");
			this.hbox4.Add(this.button112);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.button112]));
			w17.Position = 3;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.button123 = new global::Gtk.Button();
			this.button123.CanFocus = true;
			this.button123.Name = "button123";
			this.button123.UseUnderline = true;
			this.button123.Label = global::Mono.Unix.Catalog.GetString("15%");
			this.hbox4.Add(this.button123);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.button123]));
			w18.Position = 4;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.button113 = new global::Gtk.Button();
			this.button113.CanFocus = true;
			this.button113.Name = "button113";
			this.button113.UseUnderline = true;
			this.button113.Label = global::Mono.Unix.Catalog.GetString("25%");
			this.hbox4.Add(this.button113);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.button113]));
			w19.Position = 5;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.button119 = new global::Gtk.Button();
			this.button119.CanFocus = true;
			this.button119.Name = "button119";
			this.button119.UseUnderline = true;
			this.button119.Label = global::Mono.Unix.Catalog.GetString("33%");
			this.hbox4.Add(this.button119);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.button119]));
			w20.Position = 6;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.button116 = new global::Gtk.Button();
			this.button116.CanFocus = true;
			this.button116.Name = "button116";
			this.button116.UseUnderline = true;
			this.button116.Label = global::Mono.Unix.Catalog.GetString("50%");
			this.hbox4.Add(this.button116);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.button116]));
			w21.Position = 7;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.button120 = new global::Gtk.Button();
			this.button120.CanFocus = true;
			this.button120.Name = "button120";
			this.button120.UseUnderline = true;
			this.button120.Label = global::Mono.Unix.Catalog.GetString("66%");
			this.hbox4.Add(this.button120);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.button120]));
			w22.Position = 8;
			w22.Expand = false;
			w22.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.button117 = new global::Gtk.Button();
			this.button117.CanFocus = true;
			this.button117.Name = "button117";
			this.button117.UseUnderline = true;
			this.button117.Label = global::Mono.Unix.Catalog.GetString("75%");
			this.hbox4.Add(this.button117);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.button117]));
			w23.Position = 9;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.button118 = new global::Gtk.Button();
			this.button118.CanFocus = true;
			this.button118.Name = "button118";
			this.button118.UseUnderline = true;
			this.button118.Label = global::Mono.Unix.Catalog.GetString("80%");
			this.hbox4.Add(this.button118);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.button118]));
			w24.Position = 10;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.button121 = new global::Gtk.Button();
			this.button121.CanFocus = true;
			this.button121.Name = "button121";
			this.button121.UseUnderline = true;
			this.button121.Label = global::Mono.Unix.Catalog.GetString("90%");
			this.hbox4.Add(this.button121);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.button121]));
			w25.Position = 11;
			w25.Expand = false;
			w25.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.button122 = new global::Gtk.Button();
			this.button122.CanFocus = true;
			this.button122.Name = "button122";
			this.button122.UseUnderline = true;
			this.button122.Label = global::Mono.Unix.Catalog.GetString("100%");
			this.hbox4.Add(this.button122);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.button122]));
			w26.Position = 12;
			w26.Expand = false;
			w26.Fill = false;
			this.table1.Add(this.hbox4);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table1[this.hbox4]));
			w27.TopAttach = ((uint)(3));
			w27.BottomAttach = ((uint)(4));
			w27.LeftAttach = ((uint)(1));
			w27.RightAttach = ((uint)(2));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w28.TopAttach = ((uint)(2));
			w28.BottomAttach = ((uint)(3));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.Xalign = 0F;
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Amount</b>");
			this.label12.UseMarkup = true;
			this.table1.Add(this.label12);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table1[this.label12]));
			w29.TopAttach = ((uint)(1));
			w29.BottomAttach = ((uint)(2));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label14 = new global::Gtk.Label();
			this.label14.Name = "label14";
			this.label14.Xalign = 0F;
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Balance</b>");
			this.label14.UseMarkup = true;
			this.table1.Add(this.label14);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table1[this.label14]));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label16 = new global::Gtk.Label();
			this.label16.Name = "label16";
			this.label16.Xalign = 0F;
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Destination</b>");
			this.label16.UseMarkup = true;
			this.table1.Add(this.label16);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table1[this.label16]));
			w31.TopAttach = ((uint)(4));
			w31.BottomAttach = ((uint)(5));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label17 = new global::Gtk.Label();
			this.label17.Name = "label17";
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Destination Tag</b>");
			this.label17.UseMarkup = true;
			this.table1.Add(this.label17);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table1[this.label17]));
			w32.TopAttach = ((uint)(5));
			w32.BottomAttach = ((uint)(6));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w33.TopAttach = ((uint)(3));
			w33.BottomAttach = ((uint)(4));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add(this.table1);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.table1]));
			w34.Position = 4;
			// Container child vbox2.Gtk.Box+BoxChild
			this.memowidget1 = new global::IhildaWallet.MemoWidget();
			this.memowidget1.Events = ((global::Gdk.EventMask)(256));
			this.memowidget1.Name = "memowidget1";
			this.vbox2.Add(this.memowidget1);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.memowidget1]));
			w35.Position = 5;
			w35.Expand = false;
			w35.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Homogeneous = true;
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.sendNativeButton = new global::Gtk.Button();
			this.sendNativeButton.CanFocus = true;
			this.sendNativeButton.Name = "sendNativeButton";
			this.sendNativeButton.UseUnderline = true;
			this.sendNativeButton.Label = global::Mono.Unix.Catalog.GetString("Proceed to Payment Manager (Send Xrp)");
			this.hbox2.Add(this.sendNativeButton);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.sendNativeButton]));
			w36.Position = 0;
			this.vbox2.Add(this.hbox2);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w37.PackType = ((global::Gtk.PackType)(1));
			w37.Position = 6;
			w37.Expand = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator5 = new global::Gtk.HSeparator();
			this.hseparator5.Name = "hseparator5";
			this.vbox2.Add(this.hseparator5);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator5]));
			w38.PackType = ((global::Gtk.PackType)(1));
			w38.Position = 7;
			w38.Expand = false;
			w38.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}