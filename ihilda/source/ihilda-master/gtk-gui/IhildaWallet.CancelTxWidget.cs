
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class CancelTxWidget
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Label label2;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.Label label1;

		private global::Gtk.ComboBoxEntry comboboxentry1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button cancelOrderButton;

		private global::Gtk.Button AbortCancellationButton;

		private global::Gtk.Label label3;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.CancelTxWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.CancelTxWidget";
			// Container child IhildaWallet.CancelTxWidget.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("<b><u>Cancel A Pending Transaction</u></b>");
			this.label2.UseMarkup = true;
			this.vbox2.Add(this.label2);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label2]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vbox2.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator1]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("TxId");
			this.vbox2.Add(this.label1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label1]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.comboboxentry1 = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry1.Name = "comboboxentry1";
			this.vbox2.Add(this.comboboxentry1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.comboboxentry1]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.cancelOrderButton = new global::Gtk.Button();
			this.cancelOrderButton.CanFocus = true;
			this.cancelOrderButton.Name = "cancelOrderButton";
			this.cancelOrderButton.UseUnderline = true;
			this.cancelOrderButton.Label = global::Mono.Unix.Catalog.GetString("Cancel Order");
			this.hbox1.Add(this.cancelOrderButton);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.cancelOrderButton]));
			w5.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.AbortCancellationButton = new global::Gtk.Button();
			this.AbortCancellationButton.CanFocus = true;
			this.AbortCancellationButton.Name = "AbortCancellationButton";
			this.AbortCancellationButton.UseUnderline = true;
			this.AbortCancellationButton.Label = global::Mono.Unix.Catalog.GetString("Abort Cancellation");
			this.hbox1.Add(this.AbortCancellationButton);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.AbortCancellationButton]));
			w6.Position = 1;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w7.Position = 4;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 0.04F;
			this.label3.Yalign = 0.1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Cancel a transaction using it\'s transaction hash\n\nNote : Orders can be viewed and" +
					" cancelled with the orders widget");
			this.label3.UseMarkup = true;
			this.vbox2.Add(this.label3);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label3]));
			w8.Position = 5;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}