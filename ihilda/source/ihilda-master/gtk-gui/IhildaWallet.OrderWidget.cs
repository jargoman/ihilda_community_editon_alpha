
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class OrderWidget
	{
		private global::Gtk.Frame frame1;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Table table1;

		private global::Gtk.Button button793;

		private global::Gtk.Button button795;

		private global::Gtk.Label buylabel;

		private global::Gtk.CheckButton checkbutton1;

		private global::Gtk.Label pricelabel;

		private global::Gtk.Label pricelabel1;

		private global::Gtk.Label pricelabel2;

		private global::Gtk.Label soldlabel;

		private global::Gtk.Label soldlabel1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.OrderWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.OrderWidget";
			// Container child IhildaWallet.OrderWidget.Gtk.Container+ContainerChild
			this.frame1 = new global::Gtk.Frame();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(2));
			this.frame1.LabelYalign = 0F;
			this.frame1.BorderWidth = ((uint)(4));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 23;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.button793 = new global::Gtk.Button();
			this.button793.CanFocus = true;
			this.button793.Name = "button793";
			this.button793.UseUnderline = true;
			this.button793.Label = global::Mono.Unix.Catalog.GetString("Cancel");
			this.table1.Add(this.button793);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.button793]));
			w1.TopAttach = ((uint)(2));
			w1.BottomAttach = ((uint)(3));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.button795 = new global::Gtk.Button();
			this.button795.CanFocus = true;
			this.button795.Name = "button795";
			this.button795.UseUnderline = true;
			this.button795.Label = global::Mono.Unix.Catalog.GetString("Options");
			this.table1.Add(this.button795);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.button795]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.buylabel = new global::Gtk.Label();
			this.buylabel.Name = "buylabel";
			this.buylabel.Xalign = 0F;
			this.buylabel.LabelProp = global::Mono.Unix.Catalog.GetString("bought");
			this.table1.Add(this.buylabel);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.buylabel]));
			w3.LeftAttach = ((uint)(2));
			w3.RightAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.checkbutton1 = new global::Gtk.CheckButton();
			this.checkbutton1.WidthRequest = 109;
			this.checkbutton1.CanFocus = true;
			this.checkbutton1.Name = "checkbutton1";
			this.checkbutton1.Label = global::Mono.Unix.Catalog.GetString("123456789999");
			this.checkbutton1.DrawIndicator = true;
			this.checkbutton1.UseUnderline = true;
			this.checkbutton1.FocusOnClick = false;
			this.checkbutton1.Xalign = 0F;
			this.checkbutton1.Yalign = 0F;
			this.table1.Add(this.checkbutton1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.checkbutton1]));
			w4.XOptions = ((global::Gtk.AttachOptions)(6));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.pricelabel = new global::Gtk.Label();
			this.pricelabel.Name = "pricelabel";
			this.pricelabel.Xalign = 0F;
			this.pricelabel.LabelProp = global::Mono.Unix.Catalog.GetString("price");
			this.table1.Add(this.pricelabel);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.pricelabel]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.LeftAttach = ((uint)(2));
			w5.RightAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.pricelabel1 = new global::Gtk.Label();
			this.pricelabel1.Name = "pricelabel1";
			this.pricelabel1.Xalign = 0F;
			this.pricelabel1.LabelProp = global::Mono.Unix.Catalog.GetString("<big><b>Price</b></big>");
			this.pricelabel1.UseMarkup = true;
			this.table1.Add(this.pricelabel1);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.pricelabel1]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.pricelabel2 = new global::Gtk.Label();
			this.pricelabel2.Name = "pricelabel2";
			this.pricelabel2.Xalign = 0F;
			this.pricelabel2.LabelProp = global::Mono.Unix.Catalog.GetString("<big><b><span foreground=\"green\">Buy</span></b></big>");
			this.pricelabel2.UseMarkup = true;
			this.table1.Add(this.pricelabel2);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.pricelabel2]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.soldlabel = new global::Gtk.Label();
			this.soldlabel.Name = "soldlabel";
			this.soldlabel.Xalign = 0F;
			this.soldlabel.LabelProp = global::Mono.Unix.Catalog.GetString("sold");
			this.table1.Add(this.soldlabel);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.soldlabel]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(2));
			w8.RightAttach = ((uint)(3));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.soldlabel1 = new global::Gtk.Label();
			this.soldlabel1.Name = "soldlabel1";
			this.soldlabel1.Xalign = 0F;
			this.soldlabel1.LabelProp = global::Mono.Unix.Catalog.GetString("<big><b><span foreground=\"red\">Sell</span></b></big>");
			this.soldlabel1.UseMarkup = true;
			this.table1.Add(this.soldlabel1);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.soldlabel1]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table1]));
			w10.Position = 0;
			this.GtkAlignment.Add(this.hbox1);
			this.frame1.Add(this.GtkAlignment);
			this.Add(this.frame1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
