
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class PairPopup
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Label titlelabel;

		private global::Gtk.TextView textview1;

		private global::Gtk.ComboBoxEntry comboboxentry1;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.PairPopup
			this.Name = "IhildaWallet.PairPopup";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child IhildaWallet.PairPopup.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.titlelabel = new global::Gtk.Label();
			this.titlelabel.Name = "titlelabel";
			this.titlelabel.LabelProp = global::Mono.Unix.Catalog.GetString("<u><big><b>Trade Pair Select</b></big></u>");
			this.titlelabel.UseMarkup = true;
			this.vbox2.Add(this.titlelabel);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.titlelabel]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.textview1 = new global::Gtk.TextView();
			this.textview1.Buffer.Text = global::Mono.Unix.Catalog.GetString("Choose a pair of currencies to trade.\nexample: USD/CAD");
			this.textview1.CanFocus = true;
			this.textview1.Name = "textview1";
			this.vbox2.Add(this.textview1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.textview1]));
			w3.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.comboboxentry1 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry1.Name = "comboboxentry1";
			this.vbox2.Add(this.comboboxentry1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.comboboxentry1]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			w1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(w1[this.vbox2]));
			w5.Position = 0;
			// Internal child IhildaWallet.PairPopup.ActionArea
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
			this.DefaultWidth = 380;
			this.DefaultHeight = 156;
			this.Show();
		}
	}
}
