
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class DepthChartWidget
	{
		private global::Gtk.Notebook notebook1;

		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label1;

		private global::Gtk.ProgressBar progressbar1;

		private global::Gtk.CheckButton darkmodecheckbox;

		private global::Gtk.HBox hbox1;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label2;

		private global::Gtk.HScale hscale1;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label3;

		private global::Gtk.HScale hscale2;

		private global::Gtk.DrawingArea drawingarea1;

		private global::Gtk.Label label5;

		private global::IhildaWallet.OrderClusterWidget orderclusterwidget1;

		private global::Gtk.Label label6;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.DepthChartWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.DepthChartWidget";
			// Container child IhildaWallet.DepthChartWidget.Gtk.Container+ContainerChild
			this.notebook1 = new global::Gtk.Notebook();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xpad = 4;
			this.label1.Ypad = 4;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("<b><span font-size=\"large\">XRP:ICE</span></b>");
			this.label1.UseMarkup = true;
			this.hbox2.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.progressbar1 = new global::Gtk.ProgressBar();
			this.progressbar1.Name = "progressbar1";
			this.hbox2.Add(this.progressbar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.progressbar1]));
			w2.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.darkmodecheckbox = new global::Gtk.CheckButton();
			this.darkmodecheckbox.CanFocus = true;
			this.darkmodecheckbox.Name = "darkmodecheckbox";
			this.darkmodecheckbox.Label = global::Mono.Unix.Catalog.GetString("Dark Mode");
			this.darkmodecheckbox.DrawIndicator = true;
			this.darkmodecheckbox.UseUnderline = true;
			this.hbox2.Add(this.darkmodecheckbox);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.darkmodecheckbox]));
			w3.PackType = ((global::Gtk.PackType)(1));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox2.Add(this.hbox2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Homogeneous = true;
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Bids");
			this.hbox3.Add(this.label2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label2]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.hscale1 = new global::Gtk.HScale(null);
			this.hscale1.CanFocus = true;
			this.hscale1.Name = "hscale1";
			this.hscale1.Inverted = true;
			this.hscale1.Adjustment.Lower = 5D;
			this.hscale1.Adjustment.Upper = 300D;
			this.hscale1.Adjustment.PageIncrement = 10D;
			this.hscale1.Adjustment.StepIncrement = 1D;
			this.hscale1.Adjustment.Value = 100D;
			this.hscale1.DrawValue = true;
			this.hscale1.Digits = 0;
			this.hscale1.ValuePos = ((global::Gtk.PositionType)(0));
			this.hbox3.Add(this.hscale1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.hscale1]));
			w6.Position = 1;
			this.hbox1.Add(this.hbox3);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.hbox3]));
			w7.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Asks");
			this.hbox4.Add(this.label3);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label3]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.hscale2 = new global::Gtk.HScale(null);
			this.hscale2.CanFocus = true;
			this.hscale2.Name = "hscale2";
			this.hscale2.Adjustment.Lower = 5D;
			this.hscale2.Adjustment.Upper = 300D;
			this.hscale2.Adjustment.PageIncrement = 10D;
			this.hscale2.Adjustment.StepIncrement = 1D;
			this.hscale2.Adjustment.Value = 100D;
			this.hscale2.DrawValue = true;
			this.hscale2.Digits = 0;
			this.hscale2.ValuePos = ((global::Gtk.PositionType)(0));
			this.hbox4.Add(this.hscale2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.hscale2]));
			w9.Position = 1;
			this.hbox1.Add(this.hbox4);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.hbox4]));
			w10.Position = 1;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.drawingarea1 = new global::Gtk.DrawingArea();
			this.drawingarea1.Name = "drawingarea1";
			this.vbox2.Add(this.drawingarea1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.drawingarea1]));
			w12.Position = 2;
			this.notebook1.Add(this.vbox2);
			// Notebook tab
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Chart");
			this.notebook1.SetTabLabel(this.vbox2, this.label5);
			this.label5.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.orderclusterwidget1 = new global::IhildaWallet.OrderClusterWidget();
			this.orderclusterwidget1.Events = ((global::Gdk.EventMask)(256));
			this.orderclusterwidget1.Name = "orderclusterwidget1";
			this.notebook1.Add(this.orderclusterwidget1);
			global::Gtk.Notebook.NotebookChild w14 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.orderclusterwidget1]));
			w14.Position = 1;
			// Notebook tab
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Order Cluster");
			this.notebook1.SetTabLabel(this.orderclusterwidget1, this.label6);
			this.label6.ShowAll();
			this.Add(this.notebook1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
