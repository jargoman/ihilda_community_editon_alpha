
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class OptionsWidget
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label label1;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.ScrolledWindow scrolledwindow1;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Notebook notebook1;

		private global::IhildaWallet.SplashOptionsWidget splashoptionswidget1;

		private global::Gtk.Label label16;

		private global::IhildaWallet.FeeOptionsWidget feeoptionswidget1;

		private global::Gtk.Label label2;

		private global::IhildaWallet.SignOptionsWidget signoptionswidget1;

		private global::Gtk.Label label6;

		private global::IhildaWallet.OrderBookOptionsWidget orderbookoptionswidget1;

		private global::Gtk.Label label9;

		private global::Gtk.VBox vbox5;

		private global::Gtk.CheckButton checkbutton13;

		private global::Gtk.Table table5;

		private global::Gtk.Button button1;

		private global::Gtk.Button button10;

		private global::Gtk.Button button11;

		private global::Gtk.Button button12;

		private global::Gtk.Button button2;

		private global::Gtk.Button button3;

		private global::Gtk.Button button4;

		private global::Gtk.Button button5;

		private global::Gtk.Button button6;

		private global::Gtk.Button button7;

		private global::Gtk.Button button8;

		private global::Gtk.Button button9;

		private global::Gtk.CheckButton checkbutton10;

		private global::Gtk.CheckButton checkbutton11;

		private global::Gtk.CheckButton checkbutton12;

		private global::Gtk.CheckButton checkbutton7;

		private global::Gtk.CheckButton checkbutton8;

		private global::Gtk.CheckButton checkbutton9;

		private global::Gtk.Label label11;

		private global::Gtk.Label label12;

		private global::Gtk.Label label13;

		private global::Gtk.Label label21;

		private global::Gtk.Label label23;

		private global::Gtk.Label label25;

		private global::Gtk.Label OnAutoFailLabel;

		private global::Gtk.Label OnNetFailLabel;

		private global::Gtk.Label OnOrderFilledLabel;

		private global::Gtk.Label OnPaymentReceivedLabel;

		private global::Gtk.Label OnTxFailLabel;

		private global::Gtk.Label OnTxSubmitLabel;

		private global::Gtk.Label label10;

		private global::Gtk.HSeparator hseparator2;

		private global::Gtk.HSeparator hseparator5;

		private global::Gtk.HSeparator hseparator4;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button button293;

		private global::Gtk.Button savebutton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.OptionsWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.OptionsWidget";
			// Container child IhildaWallet.OptionsWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("<big><b><u>Options</u></b></big>");
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
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.VscrollbarPolicy = ((global::Gtk.PolicyType)(0));
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w3 = new global::Gtk.Viewport();
			w3.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 4;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.splashoptionswidget1 = new global::IhildaWallet.SplashOptionsWidget();
			this.splashoptionswidget1.Events = ((global::Gdk.EventMask)(256));
			this.splashoptionswidget1.Name = "splashoptionswidget1";
			this.notebook1.Add(this.splashoptionswidget1);
			// Notebook tab
			this.label16 = new global::Gtk.Label();
			this.label16.Name = "label16";
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString("<u>Splash Settings</u>");
			this.label16.UseMarkup = true;
			this.notebook1.SetTabLabel(this.splashoptionswidget1, this.label16);
			this.label16.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.feeoptionswidget1 = new global::IhildaWallet.FeeOptionsWidget();
			this.feeoptionswidget1.Events = ((global::Gdk.EventMask)(256));
			this.feeoptionswidget1.Name = "feeoptionswidget1";
			this.notebook1.Add(this.feeoptionswidget1);
			global::Gtk.Notebook.NotebookChild w5 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.feeoptionswidget1]));
			w5.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("<u>Xrp Fee Options</u>");
			this.label2.UseMarkup = true;
			this.notebook1.SetTabLabel(this.feeoptionswidget1, this.label2);
			this.label2.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.signoptionswidget1 = new global::IhildaWallet.SignOptionsWidget();
			this.signoptionswidget1.Events = ((global::Gdk.EventMask)(256));
			this.signoptionswidget1.Name = "signoptionswidget1";
			this.notebook1.Add(this.signoptionswidget1);
			global::Gtk.Notebook.NotebookChild w6 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.signoptionswidget1]));
			w6.Position = 2;
			// Notebook tab
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Signature");
			this.label6.UseMarkup = true;
			this.label6.UseUnderline = true;
			this.notebook1.SetTabLabel(this.signoptionswidget1, this.label6);
			this.label6.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.orderbookoptionswidget1 = new global::IhildaWallet.OrderBookOptionsWidget();
			this.orderbookoptionswidget1.Events = ((global::Gdk.EventMask)(256));
			this.orderbookoptionswidget1.Name = "orderbookoptionswidget1";
			this.notebook1.Add(this.orderbookoptionswidget1);
			global::Gtk.Notebook.NotebookChild w7 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.orderbookoptionswidget1]));
			w7.Position = 3;
			// Notebook tab
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("OrderBook Options");
			this.notebook1.SetTabLabel(this.orderbookoptionswidget1, this.label9);
			this.label9.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.checkbutton13 = new global::Gtk.CheckButton();
			this.checkbutton13.CanFocus = true;
			this.checkbutton13.Name = "checkbutton13";
			this.checkbutton13.Label = global::Mono.Unix.Catalog.GetString("Play default fallback sounds");
			this.checkbutton13.Active = true;
			this.checkbutton13.DrawIndicator = true;
			this.checkbutton13.UseUnderline = true;
			this.vbox5.Add(this.checkbutton13);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.checkbutton13]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.table5 = new global::Gtk.Table(((uint)(6)), ((uint)(5)), false);
			this.table5.Name = "table5";
			this.table5.RowSpacing = ((uint)(6));
			this.table5.ColumnSpacing = ((uint)(6));
			// Container child table5.Gtk.Table+TableChild
			this.button1 = new global::Gtk.Button();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("Choose file");
			this.table5.Add(this.button1);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table5[this.button1]));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.button10 = new global::Gtk.Button();
			this.button10.CanFocus = true;
			this.button10.Name = "button10";
			this.button10.UseUnderline = true;
			this.button10.Label = global::Mono.Unix.Catalog.GetString("Play");
			this.table5.Add(this.button10);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table5[this.button10]));
			w10.TopAttach = ((uint)(4));
			w10.BottomAttach = ((uint)(5));
			w10.LeftAttach = ((uint)(4));
			w10.RightAttach = ((uint)(5));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.button11 = new global::Gtk.Button();
			this.button11.CanFocus = true;
			this.button11.Name = "button11";
			this.button11.UseUnderline = true;
			this.button11.Label = global::Mono.Unix.Catalog.GetString("Choose file");
			this.table5.Add(this.button11);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table5[this.button11]));
			w11.TopAttach = ((uint)(5));
			w11.BottomAttach = ((uint)(6));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.button12 = new global::Gtk.Button();
			this.button12.CanFocus = true;
			this.button12.Name = "button12";
			this.button12.UseUnderline = true;
			this.button12.Label = global::Mono.Unix.Catalog.GetString("Play");
			this.table5.Add(this.button12);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table5[this.button12]));
			w12.TopAttach = ((uint)(5));
			w12.BottomAttach = ((uint)(6));
			w12.LeftAttach = ((uint)(4));
			w12.RightAttach = ((uint)(5));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.button2 = new global::Gtk.Button();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString("Choose file");
			this.table5.Add(this.button2);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table5[this.button2]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.button3 = new global::Gtk.Button();
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = global::Mono.Unix.Catalog.GetString("Choose file");
			this.table5.Add(this.button3);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table5[this.button3]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.button4 = new global::Gtk.Button();
			this.button4.CanFocus = true;
			this.button4.Name = "button4";
			this.button4.UseUnderline = true;
			this.button4.Label = global::Mono.Unix.Catalog.GetString("Play");
			this.table5.Add(this.button4);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table5[this.button4]));
			w15.LeftAttach = ((uint)(4));
			w15.RightAttach = ((uint)(5));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.button5 = new global::Gtk.Button();
			this.button5.CanFocus = true;
			this.button5.Name = "button5";
			this.button5.UseUnderline = true;
			this.button5.Label = global::Mono.Unix.Catalog.GetString("Play");
			this.table5.Add(this.button5);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table5[this.button5]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.LeftAttach = ((uint)(4));
			w16.RightAttach = ((uint)(5));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.button6 = new global::Gtk.Button();
			this.button6.CanFocus = true;
			this.button6.Name = "button6";
			this.button6.UseUnderline = true;
			this.button6.Label = global::Mono.Unix.Catalog.GetString("Play");
			this.table5.Add(this.button6);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table5[this.button6]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.LeftAttach = ((uint)(4));
			w17.RightAttach = ((uint)(5));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.button7 = new global::Gtk.Button();
			this.button7.CanFocus = true;
			this.button7.Name = "button7";
			this.button7.UseUnderline = true;
			this.button7.Label = global::Mono.Unix.Catalog.GetString("Choose file");
			this.table5.Add(this.button7);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table5[this.button7]));
			w18.TopAttach = ((uint)(3));
			w18.BottomAttach = ((uint)(4));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.button8 = new global::Gtk.Button();
			this.button8.CanFocus = true;
			this.button8.Name = "button8";
			this.button8.UseUnderline = true;
			this.button8.Label = global::Mono.Unix.Catalog.GetString("Play");
			this.table5.Add(this.button8);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table5[this.button8]));
			w19.TopAttach = ((uint)(3));
			w19.BottomAttach = ((uint)(4));
			w19.LeftAttach = ((uint)(4));
			w19.RightAttach = ((uint)(5));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.button9 = new global::Gtk.Button();
			this.button9.CanFocus = true;
			this.button9.Name = "button9";
			this.button9.UseUnderline = true;
			this.button9.Label = global::Mono.Unix.Catalog.GetString("Choose file");
			this.table5.Add(this.button9);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table5[this.button9]));
			w20.TopAttach = ((uint)(4));
			w20.BottomAttach = ((uint)(5));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.checkbutton10 = new global::Gtk.CheckButton();
			this.checkbutton10.CanFocus = true;
			this.checkbutton10.Name = "checkbutton10";
			this.checkbutton10.Label = global::Mono.Unix.Catalog.GetString("enable");
			this.checkbutton10.DrawIndicator = true;
			this.checkbutton10.UseUnderline = true;
			this.table5.Add(this.checkbutton10);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table5[this.checkbutton10]));
			w21.TopAttach = ((uint)(3));
			w21.BottomAttach = ((uint)(4));
			w21.LeftAttach = ((uint)(2));
			w21.RightAttach = ((uint)(3));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.checkbutton11 = new global::Gtk.CheckButton();
			this.checkbutton11.CanFocus = true;
			this.checkbutton11.Name = "checkbutton11";
			this.checkbutton11.Label = global::Mono.Unix.Catalog.GetString("enable");
			this.checkbutton11.DrawIndicator = true;
			this.checkbutton11.UseUnderline = true;
			this.table5.Add(this.checkbutton11);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table5[this.checkbutton11]));
			w22.TopAttach = ((uint)(4));
			w22.BottomAttach = ((uint)(5));
			w22.LeftAttach = ((uint)(2));
			w22.RightAttach = ((uint)(3));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.checkbutton12 = new global::Gtk.CheckButton();
			this.checkbutton12.CanFocus = true;
			this.checkbutton12.Name = "checkbutton12";
			this.checkbutton12.Label = global::Mono.Unix.Catalog.GetString("enable");
			this.checkbutton12.DrawIndicator = true;
			this.checkbutton12.UseUnderline = true;
			this.table5.Add(this.checkbutton12);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table5[this.checkbutton12]));
			w23.TopAttach = ((uint)(5));
			w23.BottomAttach = ((uint)(6));
			w23.LeftAttach = ((uint)(2));
			w23.RightAttach = ((uint)(3));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.checkbutton7 = new global::Gtk.CheckButton();
			this.checkbutton7.CanFocus = true;
			this.checkbutton7.Name = "checkbutton7";
			this.checkbutton7.Label = global::Mono.Unix.Catalog.GetString("enable");
			this.checkbutton7.DrawIndicator = true;
			this.checkbutton7.UseUnderline = true;
			this.table5.Add(this.checkbutton7);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table5[this.checkbutton7]));
			w24.LeftAttach = ((uint)(2));
			w24.RightAttach = ((uint)(3));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.checkbutton8 = new global::Gtk.CheckButton();
			this.checkbutton8.CanFocus = true;
			this.checkbutton8.Name = "checkbutton8";
			this.checkbutton8.Label = global::Mono.Unix.Catalog.GetString("enable");
			this.checkbutton8.DrawIndicator = true;
			this.checkbutton8.UseUnderline = true;
			this.table5.Add(this.checkbutton8);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table5[this.checkbutton8]));
			w25.TopAttach = ((uint)(1));
			w25.BottomAttach = ((uint)(2));
			w25.LeftAttach = ((uint)(2));
			w25.RightAttach = ((uint)(3));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.checkbutton9 = new global::Gtk.CheckButton();
			this.checkbutton9.CanFocus = true;
			this.checkbutton9.Name = "checkbutton9";
			this.checkbutton9.Label = global::Mono.Unix.Catalog.GetString("enable");
			this.checkbutton9.DrawIndicator = true;
			this.checkbutton9.UseUnderline = true;
			this.table5.Add(this.checkbutton9);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table5[this.checkbutton9]));
			w26.TopAttach = ((uint)(2));
			w26.BottomAttach = ((uint)(3));
			w26.LeftAttach = ((uint)(2));
			w26.RightAttach = ((uint)(3));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.Xalign = 0F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("On order filled");
			this.table5.Add(this.label11);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table5[this.label11]));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.Xalign = 0F;
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("On payment recieved");
			this.table5.Add(this.label12);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table5[this.label12]));
			w28.TopAttach = ((uint)(1));
			w28.BottomAttach = ((uint)(2));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label();
			this.label13.Name = "label13";
			this.label13.Xalign = 0F;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("On transaction submit");
			this.table5.Add(this.label13);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table5[this.label13]));
			w29.TopAttach = ((uint)(2));
			w29.BottomAttach = ((uint)(3));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label21 = new global::Gtk.Label();
			this.label21.Name = "label21";
			this.label21.Xalign = 0F;
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString("On tx submit fail");
			this.table5.Add(this.label21);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table5[this.label21]));
			w30.TopAttach = ((uint)(3));
			w30.BottomAttach = ((uint)(4));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label23 = new global::Gtk.Label();
			this.label23.Name = "label23";
			this.label23.Xalign = 0F;
			this.label23.LabelProp = global::Mono.Unix.Catalog.GetString("On network fail");
			this.table5.Add(this.label23);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table5[this.label23]));
			w31.TopAttach = ((uint)(4));
			w31.BottomAttach = ((uint)(5));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label25 = new global::Gtk.Label();
			this.label25.Name = "label25";
			this.label25.Xalign = 0F;
			this.label25.LabelProp = global::Mono.Unix.Catalog.GetString("On automate fail");
			this.table5.Add(this.label25);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table5[this.label25]));
			w32.TopAttach = ((uint)(5));
			w32.BottomAttach = ((uint)(6));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.OnAutoFailLabel = new global::Gtk.Label();
			this.OnAutoFailLabel.Name = "OnAutoFailLabel";
			this.OnAutoFailLabel.LabelProp = global::Mono.Unix.Catalog.GetString("OnAutoFailLabel");
			this.table5.Add(this.OnAutoFailLabel);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table5[this.OnAutoFailLabel]));
			w33.TopAttach = ((uint)(5));
			w33.BottomAttach = ((uint)(6));
			w33.LeftAttach = ((uint)(3));
			w33.RightAttach = ((uint)(4));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.OnNetFailLabel = new global::Gtk.Label();
			this.OnNetFailLabel.Name = "OnNetFailLabel";
			this.OnNetFailLabel.LabelProp = global::Mono.Unix.Catalog.GetString("OnNetFailLabel");
			this.table5.Add(this.OnNetFailLabel);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table5[this.OnNetFailLabel]));
			w34.TopAttach = ((uint)(4));
			w34.BottomAttach = ((uint)(5));
			w34.LeftAttach = ((uint)(3));
			w34.RightAttach = ((uint)(4));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.OnOrderFilledLabel = new global::Gtk.Label();
			this.OnOrderFilledLabel.Name = "OnOrderFilledLabel";
			this.OnOrderFilledLabel.LabelProp = global::Mono.Unix.Catalog.GetString("OnOrderFilledLabel");
			this.table5.Add(this.OnOrderFilledLabel);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table5[this.OnOrderFilledLabel]));
			w35.LeftAttach = ((uint)(3));
			w35.RightAttach = ((uint)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.OnPaymentReceivedLabel = new global::Gtk.Label();
			this.OnPaymentReceivedLabel.Name = "OnPaymentReceivedLabel";
			this.OnPaymentReceivedLabel.LabelProp = global::Mono.Unix.Catalog.GetString("OnPaymentReceivedLabel");
			this.table5.Add(this.OnPaymentReceivedLabel);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table5[this.OnPaymentReceivedLabel]));
			w36.TopAttach = ((uint)(1));
			w36.BottomAttach = ((uint)(2));
			w36.LeftAttach = ((uint)(3));
			w36.RightAttach = ((uint)(4));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.OnTxFailLabel = new global::Gtk.Label();
			this.OnTxFailLabel.Name = "OnTxFailLabel";
			this.OnTxFailLabel.LabelProp = global::Mono.Unix.Catalog.GetString("OnTxFailLabel");
			this.table5.Add(this.OnTxFailLabel);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table5[this.OnTxFailLabel]));
			w37.TopAttach = ((uint)(3));
			w37.BottomAttach = ((uint)(4));
			w37.LeftAttach = ((uint)(3));
			w37.RightAttach = ((uint)(4));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.OnTxSubmitLabel = new global::Gtk.Label();
			this.OnTxSubmitLabel.Name = "OnTxSubmitLabel";
			this.OnTxSubmitLabel.LabelProp = global::Mono.Unix.Catalog.GetString("OnTxSubmitLabel");
			this.table5.Add(this.OnTxSubmitLabel);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table5[this.OnTxSubmitLabel]));
			w38.TopAttach = ((uint)(2));
			w38.BottomAttach = ((uint)(3));
			w38.LeftAttach = ((uint)(3));
			w38.RightAttach = ((uint)(4));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox5.Add(this.table5);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.table5]));
			w39.Position = 1;
			w39.Expand = false;
			w39.Fill = false;
			this.notebook1.Add(this.vbox5);
			global::Gtk.Notebook.NotebookChild w40 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.vbox5]));
			w40.Position = 4;
			// Notebook tab
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Sounds");
			this.notebook1.SetTabLabel(this.vbox5, this.label10);
			this.label10.ShowAll();
			this.vbox3.Add(this.notebook1);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.notebook1]));
			w41.Position = 0;
			w41.Expand = false;
			w41.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator();
			this.hseparator2.Name = "hseparator2";
			this.vbox3.Add(this.hseparator2);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hseparator2]));
			w42.Position = 1;
			w42.Expand = false;
			w42.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hseparator5 = new global::Gtk.HSeparator();
			this.hseparator5.Name = "hseparator5";
			this.vbox3.Add(this.hseparator5);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hseparator5]));
			w43.Position = 2;
			w43.Expand = false;
			w43.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hseparator4 = new global::Gtk.HSeparator();
			this.hseparator4.Name = "hseparator4";
			this.vbox3.Add(this.hseparator4);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hseparator4]));
			w44.Position = 3;
			w44.Expand = false;
			w44.Fill = false;
			w3.Add(this.vbox3);
			this.scrolledwindow1.Add(w3);
			this.vbox1.Add(this.scrolledwindow1);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.scrolledwindow1]));
			w47.Position = 2;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Homogeneous = true;
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button293 = new global::Gtk.Button();
			this.button293.CanFocus = true;
			this.button293.Name = "button293";
			this.button293.UseUnderline = true;
			this.button293.Label = global::Mono.Unix.Catalog.GetString("Cancel");
			this.hbox1.Add(this.button293);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button293]));
			w48.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.savebutton = new global::Gtk.Button();
			this.savebutton.CanFocus = true;
			this.savebutton.Name = "savebutton";
			this.savebutton.UseUnderline = true;
			this.savebutton.Label = global::Mono.Unix.Catalog.GetString("Save Settings");
			this.hbox1.Add(this.savebutton);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.savebutton]));
			w49.Position = 1;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w50.Position = 3;
			w50.Expand = false;
			w50.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
