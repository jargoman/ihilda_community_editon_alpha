
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class ConnectedDisplayWidget
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.Table table3;

		private global::Gtk.Label connectStatusLabel;

		private global::Gtk.Label label1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.ConnectedDisplayWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.ConnectedDisplayWidget";
			// Container child IhildaWallet.ConnectedDisplayWidget.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table(((uint)(1)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.connectStatusLabel = new global::Gtk.Label();
			this.connectStatusLabel.Name = "connectStatusLabel";
			this.connectStatusLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<span foreground=\"red\">Disconnected</span>");
			this.connectStatusLabel.UseMarkup = true;
			this.table3.Add(this.connectStatusLabel);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table3[this.connectStatusLabel]));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Network</b>");
			this.label1.UseMarkup = true;
			this.table3.Add(this.label1);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table3[this.label1]));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add(this.table3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table3]));
			w3.Position = 0;
			this.Add(this.hbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}