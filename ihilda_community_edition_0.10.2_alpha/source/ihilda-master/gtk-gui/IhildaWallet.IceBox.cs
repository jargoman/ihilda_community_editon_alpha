
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class IceBox
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView textview1;

		private global::IhildaWallet.PathsTree pathstree1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button button332;

		private global::Gtk.Button button331;

		private global::Gtk.Button button333;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.IceBox
			this.Name = "IhildaWallet.IceBox";
			this.Title = global::Mono.Unix.Catalog.GetString("Ice Box");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child IhildaWallet.IceBox.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textview1 = new global::Gtk.TextView();
			this.textview1.CanFocus = true;
			this.textview1.Name = "textview1";
			this.GtkScrolledWindow.Add(this.textview1);
			this.vbox2.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.pathstree1 = new global::IhildaWallet.PathsTree();
			this.pathstree1.Events = ((global::Gdk.EventMask)(256));
			this.pathstree1.Name = "pathstree1";
			this.vbox2.Add(this.pathstree1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.pathstree1]));
			w3.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Homogeneous = true;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button332 = new global::Gtk.Button();
			this.button332.CanFocus = true;
			this.button332.Name = "button332";
			this.button332.UseUnderline = true;
			this.button332.Label = global::Mono.Unix.Catalog.GetString("Cancel");
			this.hbox1.Add(this.button332);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button332]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button331 = new global::Gtk.Button();
			this.button331.CanFocus = true;
			this.button331.Name = "button331";
			this.button331.UseUnderline = true;
			this.button331.Label = global::Mono.Unix.Catalog.GetString("Refresh");
			this.hbox1.Add(this.button331);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button331]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button333 = new global::Gtk.Button();
			this.button333.CanFocus = true;
			this.button333.Name = "button333";
			this.button333.UseUnderline = true;
			this.button333.Label = global::Mono.Unix.Catalog.GetString("Purchase Ice");
			this.hbox1.Add(this.button333);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button333]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 856;
			this.DefaultHeight = 446;
			this.Show();
		}
	}
}
