
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class TxWindow
	{
		private global::Gtk.VBox vbox3;

		private global::Gtk.Notebook notebook1;

		private global::IhildaWallet.TxViewWidget txviewwidget1;

		private global::Gtk.Label txtablabel;

		private global::IhildaWallet.OrdersWidget orderswidget1;

		private global::Gtk.Label label39;

		private global::IhildaWallet.OrdersTreeWidget orderstreewidget1;

		private global::Gtk.Label label40;

		private global::IhildaWallet.CanselTxWidget canseltxwidget1;

		private global::Gtk.Label label43;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.TxWindow
			this.Name = "IhildaWallet.TxWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Transactions");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.BorderWidth = ((uint)(2));
			// Container child IhildaWallet.TxWindow.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.txviewwidget1 = new global::IhildaWallet.TxViewWidget();
			this.txviewwidget1.Events = ((global::Gdk.EventMask)(256));
			this.txviewwidget1.Name = "txviewwidget1";
			this.notebook1.Add(this.txviewwidget1);
			// Notebook tab
			this.txtablabel = new global::Gtk.Label();
			this.txtablabel.Name = "txtablabel";
			this.txtablabel.LabelProp = global::Mono.Unix.Catalog.GetString("Transactions");
			this.notebook1.SetTabLabel(this.txviewwidget1, this.txtablabel);
			this.txtablabel.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.orderswidget1 = new global::IhildaWallet.OrdersWidget();
			this.orderswidget1.Events = ((global::Gdk.EventMask)(256));
			this.orderswidget1.Name = "orderswidget1";
			this.notebook1.Add(this.orderswidget1);
			global::Gtk.Notebook.NotebookChild w2 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.orderswidget1]));
			w2.Position = 1;
			// Notebook tab
			this.label39 = new global::Gtk.Label();
			this.label39.Name = "label39";
			this.label39.LabelProp = global::Mono.Unix.Catalog.GetString("Order Pager");
			this.notebook1.SetTabLabel(this.orderswidget1, this.label39);
			this.label39.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.orderstreewidget1 = new global::IhildaWallet.OrdersTreeWidget();
			this.orderstreewidget1.Events = ((global::Gdk.EventMask)(256));
			this.orderstreewidget1.Name = "orderstreewidget1";
			this.notebook1.Add(this.orderstreewidget1);
			global::Gtk.Notebook.NotebookChild w3 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.orderstreewidget1]));
			w3.Position = 2;
			// Notebook tab
			this.label40 = new global::Gtk.Label();
			this.label40.Name = "label40";
			this.label40.LabelProp = global::Mono.Unix.Catalog.GetString("Order Tree");
			this.notebook1.SetTabLabel(this.orderstreewidget1, this.label40);
			this.label40.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.canseltxwidget1 = new global::IhildaWallet.CanselTxWidget();
			this.canseltxwidget1.Events = ((global::Gdk.EventMask)(256));
			this.canseltxwidget1.Name = "canseltxwidget1";
			this.notebook1.Add(this.canseltxwidget1);
			global::Gtk.Notebook.NotebookChild w4 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.canseltxwidget1]));
			w4.Position = 3;
			// Notebook tab
			this.label43 = new global::Gtk.Label();
			this.label43.Name = "label43";
			this.label43.LabelProp = global::Mono.Unix.Catalog.GetString("Cancel");
			this.notebook1.SetTabLabel(this.canseltxwidget1, this.label43);
			this.label43.ShowAll();
			this.vbox3.Add(this.notebook1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.notebook1]));
			w5.Position = 0;
			this.Add(this.vbox3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 1221;
			this.DefaultHeight = 642;
			this.Show();
		}
	}
}
