
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class EncryptionTypeDialog
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Label label1;

		private global::Gtk.ComboBoxEntry comboboxentry1;

		private global::Gtk.TextView textview1;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.EncryptionTypeDialog
			this.Name = "IhildaWallet.EncryptionTypeDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child IhildaWallet.EncryptionTypeDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("label1");
			this.vbox2.Add(this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.comboboxentry1 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry1.Name = "comboboxentry1";
			this.vbox2.Add(this.comboboxentry1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.comboboxentry1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.textview1 = new global::Gtk.TextView();
			this.textview1.CanFocus = true;
			this.textview1.Name = "textview1";
			this.textview1.Editable = false;
			this.vbox2.Add(this.textview1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.textview1]));
			w4.Position = 2;
			w1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(w1[this.vbox2]));
			w5.Position = 0;
			// Internal child IhildaWallet.EncryptionTypeDialog.ActionArea
			global::Gtk.HButtonBox w6 = this.ActionArea;
			w6.Name = "dialog1_ActionArea";
			w6.Spacing = 10;
			w6.BorderWidth = ((uint)(5));
			w6.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget(this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w7 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w6[this.buttonCancel]));
			w7.Expand = false;
			w7.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget(this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w6[this.buttonOk]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
		}
	}
}
