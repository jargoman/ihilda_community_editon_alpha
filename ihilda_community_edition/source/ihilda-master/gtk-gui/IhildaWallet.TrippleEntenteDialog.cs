
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class TrippleEntenteDialog
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Label label6;

		private global::Gtk.Notebook notebook2;

		private global::Gtk.VBox vbox5;

		private global::Gtk.Label label5;

		private global::Gtk.Entry passentry;

		private global::Gtk.Label label2;

		private global::Gtk.VBox vbox3;

		private global::IhildaWallet.PinCodeWidget pincodewidget1;

		private global::Gtk.Label label3;

		private global::Gtk.VBox vbox7;

		private global::IhildaWallet.PrismWidget prismwidget1;

		private global::Gtk.Label label7;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.TrippleEntenteDialog
			this.Name = "IhildaWallet.TrippleEntenteDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child IhildaWallet.TrippleEntenteDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("The Tripple Entente");
			this.vbox2.Add(this.label6);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label6]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.notebook2 = new global::Gtk.Notebook();
			this.notebook2.CanFocus = true;
			this.notebook2.Name = "notebook2";
			this.notebook2.CurrentPage = 2;
			// Container child notebook2.Gtk.Notebook+NotebookChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Enter your password");
			this.vbox5.Add(this.label5);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.label5]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.passentry = new global::Gtk.Entry();
			this.passentry.CanFocus = true;
			this.passentry.Name = "passentry";
			this.passentry.IsEditable = true;
			this.passentry.Visibility = false;
			this.passentry.InvisibleChar = '●';
			this.vbox5.Add(this.passentry);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.passentry]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.notebook2.Add(this.vbox5);
			// Notebook tab
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Password");
			this.notebook2.SetTabLabel(this.vbox5, this.label2);
			this.label2.ShowAll();
			// Container child notebook2.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.pincodewidget1 = new global::IhildaWallet.PinCodeWidget();
			this.pincodewidget1.Events = ((global::Gdk.EventMask)(256));
			this.pincodewidget1.Name = "pincodewidget1";
			this.vbox3.Add(this.pincodewidget1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.pincodewidget1]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			this.notebook2.Add(this.vbox3);
			global::Gtk.Notebook.NotebookChild w7 = ((global::Gtk.Notebook.NotebookChild)(this.notebook2[this.vbox3]));
			w7.Position = 1;
			// Notebook tab
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("2 factor auth");
			this.notebook2.SetTabLabel(this.vbox3, this.label3);
			this.label3.ShowAll();
			// Container child notebook2.Gtk.Notebook+NotebookChild
			this.vbox7 = new global::Gtk.VBox();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.prismwidget1 = new global::IhildaWallet.PrismWidget();
			this.prismwidget1.Events = ((global::Gdk.EventMask)(256));
			this.prismwidget1.Name = "prismwidget1";
			this.vbox7.Add(this.prismwidget1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.prismwidget1]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			this.notebook2.Add(this.vbox7);
			global::Gtk.Notebook.NotebookChild w9 = ((global::Gtk.Notebook.NotebookChild)(this.notebook2[this.vbox7]));
			w9.Position = 2;
			// Notebook tab
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("prism");
			this.notebook2.SetTabLabel(this.vbox7, this.label7);
			this.label7.ShowAll();
			this.vbox2.Add(this.notebook2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.notebook2]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			w1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(w1[this.vbox2]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Internal child IhildaWallet.TrippleEntenteDialog.ActionArea
			global::Gtk.HButtonBox w12 = this.ActionArea;
			w12.Name = "dialog1_ActionArea";
			w12.Spacing = 10;
			w12.BorderWidth = ((uint)(5));
			w12.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget(this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w12[this.buttonCancel]));
			w13.Expand = false;
			w13.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget(this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w14 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w12[this.buttonOk]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 613;
			this.DefaultHeight = 388;
			this.Show();
		}
	}
}
