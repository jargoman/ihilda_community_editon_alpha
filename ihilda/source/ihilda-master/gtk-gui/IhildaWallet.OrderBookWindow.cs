
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class OrderBookWindow
	{
		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button button316;

		private global::Gtk.ProgressBar progressbar1;

		private global::IhildaWallet.OrderBookWidget orderbookwidget1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.OrderBookWindow
			this.Name = "IhildaWallet.OrderBookWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Orderbook Window");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child IhildaWallet.OrderBookWindow.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button316 = new global::Gtk.Button();
			this.button316.CanFocus = true;
			this.button316.Name = "button316";
			this.button316.UseUnderline = true;
			this.button316.Label = global::Mono.Unix.Catalog.GetString("Refresh");
			this.hbox1.Add(this.button316);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button316]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.progressbar1 = new global::Gtk.ProgressBar();
			this.progressbar1.Name = "progressbar1";
			this.hbox1.Add(this.progressbar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.progressbar1]));
			w2.Position = 1;
			this.vbox3.Add(this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.orderbookwidget1 = new global::IhildaWallet.OrderBookWidget();
			this.orderbookwidget1.Events = ((global::Gdk.EventMask)(256));
			this.orderbookwidget1.Name = "orderbookwidget1";
			this.vbox3.Add(this.orderbookwidget1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.orderbookwidget1]));
			w4.Position = 1;
			this.Add(this.vbox3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 1187;
			this.DefaultHeight = 690;
			this.Show();
		}
	}
}
