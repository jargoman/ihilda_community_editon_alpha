
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class CustomPopupWindow
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Label label1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.CustomPopupWindow
			this.Name = "IhildaWallet.CustomPopupWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("CustomPopupWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.AcceptFocus = false;
			this.Decorated = false;
			this.DestroyWithParent = true;
			this.Gravity = ((global::Gdk.Gravity)(9));
			// Container child IhildaWallet.CustomPopupWindow.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("label");
			this.label1.UseMarkup = true;
			this.vbox2.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label1]));
			w1.Position = 0;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 244;
			this.DefaultHeight = 17;
			this.Hide();
		}
	}
}
