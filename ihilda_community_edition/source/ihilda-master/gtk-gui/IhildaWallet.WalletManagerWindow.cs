
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class WalletManagerWindow
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.VBox vbox2;

		private global::Gtk.HSeparator hseparator1;

		private global::IhildaWallet.WalletManagerWidget walletmanagerwidget1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.WalletManagerWindow
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "IhildaWallet.WalletManagerWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Wallet Manager");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource("IhildaWallet.Images.xrp_25x22.png");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child IhildaWallet.WalletManagerWindow.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vbox2.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.walletmanagerwidget1 = new global::IhildaWallet.WalletManagerWidget();
			this.walletmanagerwidget1.Events = ((global::Gdk.EventMask)(256));
			this.walletmanagerwidget1.Name = "walletmanagerwidget1";
			this.vbox2.Add(this.walletmanagerwidget1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.walletmanagerwidget1]));
			w3.Position = 1;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 1261;
			this.DefaultHeight = 527;
			this.Show();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		}
	}
}
