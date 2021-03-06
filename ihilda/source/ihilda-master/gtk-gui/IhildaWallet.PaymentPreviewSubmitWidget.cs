
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class PaymentPreviewSubmitWidget
	{
		private global::Gtk.VBox vbox2;

		private global::IhildaWallet.PaymentsTree paymentstree1;

		private global::Gtk.Label infoBarlabel;

		private global::Gtk.HBox hbox1;

		private global::IhildaWallet.WalletSwitchWidget walletswitchwidget1;

		private global::Gtk.Button submitButton;

		private global::Gtk.Button stopButton;

		private global::Gtk.Button removeButton;

		private global::Gtk.Button selectButton;

		private global::Gtk.Button resetButton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.PaymentPreviewSubmitWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.PaymentPreviewSubmitWidget";
			// Container child IhildaWallet.PaymentPreviewSubmitWidget.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.paymentstree1 = new global::IhildaWallet.PaymentsTree();
			this.paymentstree1.Events = ((global::Gdk.EventMask)(256));
			this.paymentstree1.Name = "paymentstree1";
			this.vbox2.Add(this.paymentstree1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.paymentstree1]));
			w1.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.infoBarlabel = new global::Gtk.Label();
			this.infoBarlabel.Name = "infoBarlabel";
			this.infoBarlabel.Xalign = 0F;
			this.infoBarlabel.LabelProp = global::Mono.Unix.Catalog.GetString("This is an info bar");
			this.vbox2.Add(this.infoBarlabel);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.infoBarlabel]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.walletswitchwidget1 = new global::IhildaWallet.WalletSwitchWidget();
			this.walletswitchwidget1.Events = ((global::Gdk.EventMask)(256));
			this.walletswitchwidget1.Name = "walletswitchwidget1";
			this.hbox1.Add(this.walletswitchwidget1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.walletswitchwidget1]));
			w3.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.submitButton = new global::Gtk.Button();
			this.submitButton.CanFocus = true;
			this.submitButton.Name = "submitButton";
			this.submitButton.UseUnderline = true;
			this.submitButton.Label = global::Mono.Unix.Catalog.GetString("Submit");
			this.hbox1.Add(this.submitButton);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.submitButton]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.stopButton = new global::Gtk.Button();
			this.stopButton.CanFocus = true;
			this.stopButton.Name = "stopButton";
			this.stopButton.UseUnderline = true;
			this.stopButton.Label = global::Mono.Unix.Catalog.GetString("Stop");
			this.hbox1.Add(this.stopButton);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.stopButton]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.removeButton = new global::Gtk.Button();
			this.removeButton.CanFocus = true;
			this.removeButton.Name = "removeButton";
			this.removeButton.UseUnderline = true;
			this.removeButton.Label = global::Mono.Unix.Catalog.GetString("Remove");
			this.hbox1.Add(this.removeButton);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.removeButton]));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.selectButton = new global::Gtk.Button();
			this.selectButton.CanFocus = true;
			this.selectButton.Name = "selectButton";
			this.selectButton.UseUnderline = true;
			this.selectButton.Label = global::Mono.Unix.Catalog.GetString("Select All or None");
			this.hbox1.Add(this.selectButton);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.selectButton]));
			w7.Position = 4;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.resetButton = new global::Gtk.Button();
			this.resetButton.CanFocus = true;
			this.resetButton.Name = "resetButton";
			this.resetButton.UseUnderline = true;
			this.resetButton.Label = global::Mono.Unix.Catalog.GetString("Reset To Default");
			this.hbox1.Add(this.resetButton);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.resetButton]));
			w8.Position = 5;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.infoBarlabel.Hide();
			this.Hide();
		}
	}
}
