
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class CurrencyWidget
	{
		private global::Gtk.Table table2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.CurrencyWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.CurrencyWidget";
			// Container child IhildaWallet.CurrencyWidget.Gtk.Container+ContainerChild
			this.table2 = new global::Gtk.Table(((uint)(1)), ((uint)(3)), true);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("<b>XRP</b>");
			this.label3.UseMarkup = true;
			this.label3.Selectable = true;
			this.table2.Add(this.label3);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table2[this.label3]));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("100,000,000,000,000.000,000,000");
			this.label4.Selectable = true;
			this.table2.Add(this.label4);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2[this.label4]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(3));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
