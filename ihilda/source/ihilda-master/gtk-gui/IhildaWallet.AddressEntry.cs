
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class AddressEntry
	{
		private global::Gtk.VBox vbox3;

		private global::Gtk.ComboBoxEntry comboboxentry;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.AddressEntry
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.AddressEntry";
			// Container child IhildaWallet.AddressEntry.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.comboboxentry = global::Gtk.ComboBoxEntry.NewText();
			this.comboboxentry.Name = "comboboxentry";
			this.vbox3.Add(this.comboboxentry);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.comboboxentry]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			this.Add(this.vbox3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
