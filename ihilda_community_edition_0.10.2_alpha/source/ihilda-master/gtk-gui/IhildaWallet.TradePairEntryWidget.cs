
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class TradePairEntryWidget
	{
		private global::Gtk.Table table3;

		private global::Gtk.ComboBoxEntry basecurrencycombobox;

		private global::Gtk.ComboBoxEntry baseissuercombobox;

		private global::Gtk.ComboBoxEntry countercurrencycombobox;

		private global::Gtk.ComboBoxEntry countercurrencycombobox1;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.TradePairEntryWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.TradePairEntryWidget";
			// Container child IhildaWallet.TradePairEntryWidget.Gtk.Container+ContainerChild
			this.table3 = new global::Gtk.Table(((uint)(3)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.basecurrencycombobox = global::Gtk.ComboBoxEntry.NewText();
			this.basecurrencycombobox.WidthRequest = 120;
			this.basecurrencycombobox.Name = "basecurrencycombobox";
			this.table3.Add(this.basecurrencycombobox);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table3[this.basecurrencycombobox]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(2));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.baseissuercombobox = global::Gtk.ComboBoxEntry.NewText();
			this.baseissuercombobox.Name = "baseissuercombobox";
			this.table3.Add(this.baseissuercombobox);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table3[this.baseissuercombobox]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.countercurrencycombobox = global::Gtk.ComboBoxEntry.NewText();
			this.countercurrencycombobox.WidthRequest = 120;
			this.countercurrencycombobox.Name = "countercurrencycombobox";
			this.table3.Add(this.countercurrencycombobox);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table3[this.countercurrencycombobox]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.countercurrencycombobox1 = global::Gtk.ComboBoxEntry.NewText();
			this.countercurrencycombobox1.Name = "countercurrencycombobox1";
			this.table3.Add(this.countercurrencycombobox1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table3[this.countercurrencycombobox1]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("<b><u>issuers</u></b>");
			this.label7.UseMarkup = true;
			this.table3.Add(this.label7);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table3[this.label7]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("<b><u>Currency Pair</u></b>");
			this.label8.UseMarkup = true;
			this.table3.Add(this.label8);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table3[this.label8]));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
