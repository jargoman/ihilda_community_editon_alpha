
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class LedgerConstraintsWidget
	{
		private global::Gtk.Table table3;

		private global::Gtk.CheckButton checkbutton1;

		private global::Gtk.ComboBoxEntry comboboxentry4;

		private global::Gtk.ComboBoxEntry comboboxentry5;

		private global::Gtk.ComboBoxEntry comboboxentry6;

		private global::Gtk.Label label10;

		private global::Gtk.Label label11;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		private global::Gtk.Label label9;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.LedgerConstraintsWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.LedgerConstraintsWidget";
			// Container child IhildaWallet.LedgerConstraintsWidget.Gtk.Container+ContainerChild
			this.table3 = new global::Gtk.Table(((uint)(5)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			this.table3.BorderWidth = ((uint)(10));
			// Container child table3.Gtk.Table+TableChild
			this.checkbutton1 = new global::Gtk.CheckButton();
			this.checkbutton1.CanFocus = true;
			this.checkbutton1.Name = "checkbutton1";
			this.checkbutton1.Label = global::Mono.Unix.Catalog.GetString("forward");
			this.checkbutton1.DrawIndicator = true;
			this.checkbutton1.UseUnderline = true;
			this.table3.Add(this.checkbutton1);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table3[this.checkbutton1]));
			w1.TopAttach = ((uint)(4));
			w1.BottomAttach = ((uint)(5));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.comboboxentry4 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry4.Name = "comboboxentry4";
			this.table3.Add(this.comboboxentry4);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table3[this.comboboxentry4]));
			w2.TopAttach = ((uint)(3));
			w2.BottomAttach = ((uint)(4));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.comboboxentry5 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry5.Name = "comboboxentry5";
			this.table3.Add(this.comboboxentry5);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table3[this.comboboxentry5]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.comboboxentry6 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry6.Name = "comboboxentry6";
			this.table3.Add(this.comboboxentry6);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table3[this.comboboxentry6]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.Xalign = 0F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Last Processed Ledger ");
			this.table3.Add(this.label10);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table3[this.label10]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.Xalign = 0F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Starting Ledger");
			this.table3.Add(this.label11);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table3[this.label11]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.Xalign = 0F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Limit");
			this.table3.Add(this.label7);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table3[this.label7]));
			w7.TopAttach = ((uint)(3));
			w7.BottomAttach = ((uint)(4));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.Xalign = 0F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Ledger Max");
			this.table3.Add(this.label8);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table3[this.label8]));
			w8.TopAttach = ((uint)(2));
			w8.BottomAttach = ((uint)(3));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("none");
			this.label9.Selectable = true;
			this.table3.Add(this.label9);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table3[this.label9]));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.label10.Hide();
			this.label9.Hide();
			this.Hide();
		}
	}
}