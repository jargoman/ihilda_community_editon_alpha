
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class SentementCreateDialog
	{
		private global::Gtk.VBox vbox3;

		private global::Gtk.Table table2;

		private global::Gtk.ComboBoxEntry comboboxentry2;

		private global::Gtk.ComboBoxEntry comboboxentry3;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.SentementCreateDialog
			this.Name = "IhildaWallet.SentementCreateDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child IhildaWallet.SentementCreateDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.comboboxentry2 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry2.Name = "comboboxentry2";
			this.table2.Add(this.comboboxentry2);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2[this.comboboxentry2]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.comboboxentry3 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry3.Name = "comboboxentry3";
			this.table2.Add(this.comboboxentry3);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2[this.comboboxentry3]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Asset");
			this.table2.Add(this.label3);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2[this.label3]));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Sentiment");
			this.table2.Add(this.label4);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2[this.label4]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add(this.table2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.table2]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			w1.Add(this.vbox3);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(w1[this.vbox3]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Internal child IhildaWallet.SentementCreateDialog.ActionArea
			global::Gtk.HButtonBox w8 = this.ActionArea;
			w8.Name = "dialog1_ActionArea";
			w8.Spacing = 10;
			w8.BorderWidth = ((uint)(5));
			w8.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget(this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w8[this.buttonCancel]));
			w9.Expand = false;
			w9.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget(this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w8[this.buttonOk]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 266;
			this.DefaultHeight = 110;
			this.Show();
		}
	}
}
