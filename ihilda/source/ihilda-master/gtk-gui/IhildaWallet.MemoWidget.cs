
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class MemoWidget
	{
		private global::Gtk.Table table1;

		private global::Gtk.Button addmemobutton;

		private global::Gtk.Button clearmemobutton;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView treeview1;

		private global::Gtk.Label label18;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.MemoWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.MemoWidget";
			// Container child IhildaWallet.MemoWidget.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.addmemobutton = new global::Gtk.Button();
			this.addmemobutton.CanFocus = true;
			this.addmemobutton.Name = "addmemobutton";
			this.addmemobutton.UseUnderline = true;
			this.addmemobutton.Xalign = 0F;
			this.addmemobutton.Yalign = 1F;
			this.addmemobutton.Label = global::Mono.Unix.Catalog.GetString("Add Memo");
			this.table1.Add(this.addmemobutton);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.addmemobutton]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.clearmemobutton = new global::Gtk.Button();
			this.clearmemobutton.CanFocus = true;
			this.clearmemobutton.Name = "clearmemobutton";
			this.clearmemobutton.UseUnderline = true;
			this.clearmemobutton.Xalign = 0F;
			this.clearmemobutton.Yalign = 1F;
			this.clearmemobutton.Label = global::Mono.Unix.Catalog.GetString("Clear Memos");
			this.table1.Add(this.clearmemobutton);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.clearmemobutton]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeview1 = new global::Gtk.TreeView();
			this.treeview1.CanFocus = true;
			this.treeview1.Name = "treeview1";
			this.GtkScrolledWindow.Add(this.treeview1);
			this.table1.Add(this.GtkScrolledWindow);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.GtkScrolledWindow]));
			w4.BottomAttach = ((uint)(3));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label18 = new global::Gtk.Label();
			this.label18.Name = "label18";
			this.label18.Xalign = 0.1F;
			this.label18.Yalign = 0.3F;
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Memos</b>");
			this.label18.UseMarkup = true;
			this.table1.Add(this.label18);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.label18]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
