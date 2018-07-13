
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class PrismWidget
	{
		private global::Gtk.Table table3;

		private global::Gtk.ComboBoxEntry animalentry;

		private global::Gtk.ComboBoxEntry cardentry;

		private global::Gtk.ComboBoxEntry colorentry;

		private global::Gtk.ComboBoxEntry elemententry;

		private global::Gtk.Label label1;

		private global::Gtk.Label label10;

		private global::Gtk.Label label11;

		private global::Gtk.Label label12;

		private global::Gtk.Label label8;

		private global::Gtk.Label label9;

		private global::Gtk.ComboBoxEntry planetentry;

		private global::Gtk.ComboBoxEntry suitentry;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.PrismWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.PrismWidget";
			// Container child IhildaWallet.PrismWidget.Gtk.Container+ContainerChild
			this.table3 = new global::Gtk.Table(((uint)(6)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.animalentry = global::Gtk.ComboBoxEntry.NewText();
			this.animalentry.Name = "animalentry";
			this.table3.Add(this.animalentry);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table3[this.animalentry]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.cardentry = global::Gtk.ComboBoxEntry.NewText();
			this.cardentry.Name = "cardentry";
			this.table3.Add(this.cardentry);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table3[this.cardentry]));
			w2.TopAttach = ((uint)(4));
			w2.BottomAttach = ((uint)(5));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.colorentry = global::Gtk.ComboBoxEntry.NewText();
			this.colorentry.Name = "colorentry";
			this.table3.Add(this.colorentry);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table3[this.colorentry]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.elemententry = global::Gtk.ComboBoxEntry.NewText();
			this.elemententry.Name = "elemententry";
			this.table3.Add(this.elemententry);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table3[this.elemententry]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Card");
			this.table3.Add(this.label1);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table3[this.label1]));
			w5.TopAttach = ((uint)(4));
			w5.BottomAttach = ((uint)(5));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Element");
			this.table3.Add(this.label10);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table3[this.label10]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Planet");
			this.table3.Add(this.label11);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table3[this.label11]));
			w7.TopAttach = ((uint)(3));
			w7.BottomAttach = ((uint)(4));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("Suit");
			this.table3.Add(this.label12);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table3[this.label12]));
			w8.TopAttach = ((uint)(5));
			w8.BottomAttach = ((uint)(6));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Color");
			this.table3.Add(this.label8);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table3[this.label8]));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Animal");
			this.table3.Add(this.label9);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table3[this.label9]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.planetentry = global::Gtk.ComboBoxEntry.NewText();
			this.planetentry.Name = "planetentry";
			this.table3.Add(this.planetentry);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table3[this.planetentry]));
			w11.TopAttach = ((uint)(3));
			w11.BottomAttach = ((uint)(4));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.suitentry = global::Gtk.ComboBoxEntry.NewText();
			this.suitentry.Name = "suitentry";
			this.table3.Add(this.suitentry);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table3[this.suitentry]));
			w12.TopAttach = ((uint)(5));
			w12.BottomAttach = ((uint)(6));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
