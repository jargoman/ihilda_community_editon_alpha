
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class WalletShowWidget
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Label label1;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.Table table1;

		private global::Gtk.Button accountbutton;

		private global::Gtk.Label accountlabel;

		private global::Gtk.CheckButton checkbutton;

		private global::Gtk.Button namebutton;

		private global::Gtk.Label namelabel;

		private global::Gtk.Button secretbutton;

		private global::Gtk.Label secretlabel;

		private global::Gtk.HSeparator hseparator2;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.WalletShowWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.WalletShowWidget";
			// Container child IhildaWallet.WalletShowWidget.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("<span size=\"x-large\"><b><u>Wallet</u></b></span>");
			this.label1.UseMarkup = true;
			this.vbox2.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vbox2.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator1]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(10));
			// Container child table1.Gtk.Table+TableChild
			this.accountbutton = new global::Gtk.Button();
			this.accountbutton.CanFocus = true;
			this.accountbutton.Name = "accountbutton";
			this.accountbutton.UseUnderline = true;
			this.accountbutton.Label = global::Mono.Unix.Catalog.GetString("Account");
			this.table1.Add(this.accountbutton);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.accountbutton]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.accountlabel = new global::Gtk.Label();
			this.accountlabel.Name = "accountlabel";
			this.accountlabel.Xalign = 0F;
			this.accountlabel.Selectable = true;
			this.table1.Add(this.accountlabel);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.accountlabel]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.checkbutton = new global::Gtk.CheckButton();
			this.checkbutton.CanFocus = true;
			this.checkbutton.Name = "checkbutton";
			this.checkbutton.Label = global::Mono.Unix.Catalog.GetString("Show");
			this.checkbutton.DrawIndicator = true;
			this.checkbutton.UseUnderline = true;
			this.table1.Add(this.checkbutton);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.checkbutton]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.LeftAttach = ((uint)(2));
			w5.RightAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.namebutton = new global::Gtk.Button();
			this.namebutton.CanFocus = true;
			this.namebutton.Name = "namebutton";
			this.namebutton.UseUnderline = true;
			this.namebutton.Label = global::Mono.Unix.Catalog.GetString("Name");
			this.table1.Add(this.namebutton);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.namebutton]));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.namelabel = new global::Gtk.Label();
			this.namelabel.Name = "namelabel";
			this.namelabel.Xalign = 0F;
			this.namelabel.Selectable = true;
			this.table1.Add(this.namelabel);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.namelabel]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(3));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.secretbutton = new global::Gtk.Button();
			this.secretbutton.CanFocus = true;
			this.secretbutton.Name = "secretbutton";
			this.secretbutton.UseUnderline = true;
			this.secretbutton.Xalign = 0F;
			this.secretbutton.Yalign = 0F;
			this.secretbutton.Label = global::Mono.Unix.Catalog.GetString("Secret");
			this.table1.Add(this.secretbutton);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.secretbutton]));
			w8.TopAttach = ((uint)(2));
			w8.BottomAttach = ((uint)(3));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.secretlabel = new global::Gtk.Label();
			this.secretlabel.Name = "secretlabel";
			this.secretlabel.Xalign = 0F;
			this.table1.Add(this.secretlabel);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.secretlabel]));
			w9.TopAttach = ((uint)(2));
			w9.BottomAttach = ((uint)(3));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add(this.table1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.table1]));
			w10.Position = 2;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator();
			this.hseparator2.Name = "hseparator2";
			this.vbox2.Add(this.hseparator2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator2]));
			w11.Position = 3;
			w11.Expand = false;
			w11.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
