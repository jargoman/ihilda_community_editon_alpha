
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class TrippleEntenteCreationDialog
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Label label6;

		private global::Gtk.Notebook notebook2;

		private global::Gtk.VBox vbox5;

		private global::Gtk.Table table1;

		private global::Gtk.Entry confentry;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Entry passentry;

		private global::Gtk.Label label2;

		private global::Gtk.VBox vbox3;

		private global::IhildaWallet.PinCodeWidget pincodewidget1;

		private global::Gtk.Label label3;

		private global::Gtk.VBox vbox7;

		private global::IhildaWallet.PrismWidget prismwidget2;

		private global::Gtk.Label label7;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.TrippleEntenteCreationDialog
			this.Name = "IhildaWallet.TrippleEntenteCreationDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child IhildaWallet.TrippleEntenteCreationDialog.VBox
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
			this.notebook2.CurrentPage = 1;
			// Container child notebook2.Gtk.Notebook+NotebookChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.confentry = new global::Gtk.Entry();
			this.confentry.CanFocus = true;
			this.confentry.Name = "confentry";
			this.confentry.IsEditable = true;
			this.confentry.Visibility = false;
			this.confentry.InvisibleChar = '●';
			this.table1.Add(this.confentry);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.confentry]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("confirm password");
			this.table1.Add(this.label4);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Enter your password");
			this.table1.Add(this.label5);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.passentry = new global::Gtk.Entry();
			this.passentry.CanFocus = true;
			this.passentry.Name = "passentry";
			this.passentry.IsEditable = true;
			this.passentry.Visibility = false;
			this.passentry.InvisibleChar = '●';
			this.table1.Add(this.passentry);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.passentry]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox5.Add(this.table1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.table1]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
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
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.pincodewidget1]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			this.notebook2.Add(this.vbox3);
			global::Gtk.Notebook.NotebookChild w10 = ((global::Gtk.Notebook.NotebookChild)(this.notebook2[this.vbox3]));
			w10.Position = 1;
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
			this.prismwidget2 = new global::IhildaWallet.PrismWidget();
			this.prismwidget2.Events = ((global::Gdk.EventMask)(256));
			this.prismwidget2.Name = "prismwidget2";
			this.vbox7.Add(this.prismwidget2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.prismwidget2]));
			w11.Position = 0;
			this.notebook2.Add(this.vbox7);
			global::Gtk.Notebook.NotebookChild w12 = ((global::Gtk.Notebook.NotebookChild)(this.notebook2[this.vbox7]));
			w12.Position = 2;
			// Notebook tab
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("prism");
			this.notebook2.SetTabLabel(this.vbox7, this.label7);
			this.label7.ShowAll();
			this.vbox2.Add(this.notebook2);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.notebook2]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			w1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(w1[this.vbox2]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Internal child IhildaWallet.TrippleEntenteCreationDialog.ActionArea
			global::Gtk.HButtonBox w15 = this.ActionArea;
			w15.Name = "dialog1_ActionArea";
			w15.Spacing = 10;
			w15.BorderWidth = ((uint)(5));
			w15.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget(this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w15[this.buttonCancel]));
			w16.Expand = false;
			w16.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget(this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w17 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w15[this.buttonOk]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 854;
			this.DefaultHeight = 375;
			this.Show();
		}
	}
}
