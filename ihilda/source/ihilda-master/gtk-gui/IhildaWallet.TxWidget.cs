
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class TxWidget
	{
		private global::Gtk.EventBox eventbox1;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Table table2;

		private global::Gtk.Label dateLabel;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Button optionsbutton;

		private global::Gtk.Label txidlabel;

		private global::Gtk.ScrolledWindow scrolledwindow1;

		private global::Gtk.Table table1;

		private global::Gtk.Frame frame2;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label txlabel;

		private global::Gtk.Label GtkLabel1;

		private global::Gtk.Frame frame3;

		private global::Gtk.Alignment GtkAlignment1;

		private global::Gtk.Label metalabel;

		private global::Gtk.Label GtkLabel2;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.TxWidget
			global::Stetic.BinContainer.Attach(this);
			this.HeightRequest = 300;
			this.Name = "IhildaWallet.TxWidget";
			// Container child IhildaWallet.TxWidget.Gtk.Container+ContainerChild
			this.eventbox1 = new global::Gtk.EventBox();
			this.eventbox1.Name = "eventbox1";
			// Container child eventbox1.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 7;
			this.vbox2.BorderWidth = ((uint)(16));
			// Container child vbox2.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table(((uint)(3)), ((uint)(3)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.dateLabel = new global::Gtk.Label();
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Xalign = 0F;
			this.dateLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Saturday April 7, 03:42:07");
			this.table2.Add(this.dateLabel);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table2[this.dateLabel]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(3));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("transaction type");
			this.table2.Add(this.label1);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2[this.label1]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YOptions = ((global::Gtk.AttachOptions)(2));
			// Container child table2.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Transaction Id </b>");
			this.label2.UseMarkup = true;
			this.table2.Add(this.label2);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2[this.label2]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Transaction Type</b>");
			this.label3.UseMarkup = true;
			this.table2.Add(this.label3);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2[this.label3]));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Date and Time</b>");
			this.label4.UseMarkup = true;
			this.table2.Add(this.label4);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2[this.label4]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.optionsbutton = new global::Gtk.Button();
			this.optionsbutton.CanFocus = true;
			this.optionsbutton.Name = "optionsbutton";
			this.optionsbutton.UseUnderline = true;
			this.optionsbutton.Label = global::Mono.Unix.Catalog.GetString("options");
			this.table2.Add(this.optionsbutton);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2[this.optionsbutton]));
			w6.LeftAttach = ((uint)(2));
			w6.RightAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.txidlabel = new global::Gtk.Label();
			this.txidlabel.Name = "txidlabel";
			this.txidlabel.Xalign = 0F;
			this.txidlabel.LabelProp = global::Mono.Unix.Catalog.GetString("tx id");
			this.table2.Add(this.txidlabel);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2[this.txidlabel]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(3));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add(this.table2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.table2]));
			w8.Position = 0;
			w8.Expand = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w9 = new global::Gtk.Viewport();
			w9.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport1.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(10));
			this.table1.BorderWidth = ((uint)(3));
			// Container child table1.Gtk.Table+TableChild
			this.frame2 = new global::Gtk.Frame();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(1));
			this.frame2.LabelYalign = 0F;
			this.frame2.BorderWidth = ((uint)(4));
			// Container child frame2.Gtk.Container+ContainerChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.txlabel = new global::Gtk.Label();
			this.txlabel.Name = "txlabel";
			this.txlabel.Xpad = 7;
			this.txlabel.Ypad = 3;
			this.txlabel.Xalign = 0F;
			this.txlabel.Yalign = 0F;
			this.txlabel.LabelProp = global::Mono.Unix.Catalog.GetString("tx_summary");
			this.txlabel.UseMarkup = true;
			this.txlabel.Wrap = true;
			this.txlabel.Selectable = true;
			this.txlabel.MaxWidthChars = 100;
			this.txlabel.SingleLineMode = true;
			this.hbox2.Add(this.txlabel);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.txlabel]));
			w10.Position = 0;
			this.frame2.Add(this.hbox2);
			this.GtkLabel1 = new global::Gtk.Label();
			this.GtkLabel1.Name = "GtkLabel1";
			this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString("<b><i>Transaction</i></b>");
			this.GtkLabel1.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel1;
			this.table1.Add(this.frame2);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.frame2]));
			w12.RightAttach = ((uint)(3));
			w12.YOptions = ((global::Gtk.AttachOptions)(2));
			// Container child table1.Gtk.Table+TableChild
			this.frame3 = new global::Gtk.Frame();
			this.frame3.Name = "frame3";
			this.frame3.ShadowType = ((global::Gtk.ShadowType)(1));
			this.frame3.BorderWidth = ((uint)(4));
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.metalabel = new global::Gtk.Label();
			this.metalabel.Name = "metalabel";
			this.metalabel.Xpad = 7;
			this.metalabel.Ypad = 3;
			this.metalabel.Xalign = 0F;
			this.metalabel.Yalign = 0F;
			this.metalabel.LabelProp = global::Mono.Unix.Catalog.GetString("meta summary");
			this.metalabel.UseMarkup = true;
			this.metalabel.Wrap = true;
			this.metalabel.Selectable = true;
			this.GtkAlignment1.Add(this.metalabel);
			this.frame3.Add(this.GtkAlignment1);
			this.GtkLabel2 = new global::Gtk.Label();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString("<b><i>Affected Nodes</i></b>");
			this.GtkLabel2.UseMarkup = true;
			this.frame3.LabelWidget = this.GtkLabel2;
			this.table1.Add(this.frame3);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.frame3]));
			w15.TopAttach = ((uint)(1));
			w15.BottomAttach = ((uint)(2));
			w15.RightAttach = ((uint)(3));
			w15.YOptions = ((global::Gtk.AttachOptions)(2));
			w9.Add(this.table1);
			this.scrolledwindow1.Add(w9);
			this.vbox2.Add(this.scrolledwindow1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.scrolledwindow1]));
			w18.Position = 1;
			this.eventbox1.Add(this.vbox2);
			this.Add(this.eventbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
