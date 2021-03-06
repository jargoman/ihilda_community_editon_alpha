
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class SplashOptionsWidget
	{
		private global::Gtk.Table table1;

		private global::Gtk.Label label15;

		private global::Gtk.Label label17;

		private global::Gtk.Label label18;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Button pathbutton;

		private global::Gtk.Label pathlabel;

		private global::Gtk.CheckButton showsplashcheckbutton;

		private global::Gtk.Entry splashdelayentry;

		private global::Gtk.Entry splashheightentry;

		private global::Gtk.Entry splashwidthentry;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.SplashOptionsWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "IhildaWallet.SplashOptionsWidget";
			// Container child IhildaWallet.SplashOptionsWidget.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(4)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label();
			this.label15.Name = "label15";
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString("customize");
			this.table1.Add(this.label15);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.label15]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label17 = new global::Gtk.Label();
			this.label17.Name = "label17";
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString("Initial Splash delay");
			this.table1.Add(this.label17);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.label17]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label18 = new global::Gtk.Label();
			this.label18.Name = "label18";
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString("milliseconds (max=500)");
			this.table1.Add(this.label18);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.label18]));
			w3.LeftAttach = ((uint)(3));
			w3.RightAttach = ((uint)(4));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Splash image width");
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Splash image height");
			this.table1.Add(this.label4);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.LeftAttach = ((uint)(2));
			w5.RightAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.pathbutton = new global::Gtk.Button();
			this.pathbutton.CanFocus = true;
			this.pathbutton.Name = "pathbutton";
			this.pathbutton.UseUnderline = true;
			this.pathbutton.Label = global::Mono.Unix.Catalog.GetString("Path");
			this.table1.Add(this.pathbutton);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.pathbutton]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.pathlabel = new global::Gtk.Label();
			this.pathlabel.WidthRequest = 100;
			this.pathlabel.Name = "pathlabel";
			this.pathlabel.LabelProp = global::Mono.Unix.Catalog.GetString("C:/Programs/ihilda/splash.png");
			this.table1.Add(this.pathlabel);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.pathlabel]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(2));
			w7.RightAttach = ((uint)(4));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.showsplashcheckbutton = new global::Gtk.CheckButton();
			this.showsplashcheckbutton.CanFocus = true;
			this.showsplashcheckbutton.Name = "showsplashcheckbutton";
			this.showsplashcheckbutton.Label = global::Mono.Unix.Catalog.GetString("show splash screen");
			this.showsplashcheckbutton.DrawIndicator = true;
			this.showsplashcheckbutton.UseUnderline = true;
			this.table1.Add(this.showsplashcheckbutton);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.showsplashcheckbutton]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.splashdelayentry = new global::Gtk.Entry();
			this.splashdelayentry.CanFocus = true;
			this.splashdelayentry.Name = "splashdelayentry";
			this.splashdelayentry.IsEditable = true;
			this.splashdelayentry.InvisibleChar = '•';
			this.table1.Add(this.splashdelayentry);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.splashdelayentry]));
			w9.LeftAttach = ((uint)(2));
			w9.RightAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.splashheightentry = new global::Gtk.Entry();
			this.splashheightentry.CanFocus = true;
			this.splashheightentry.Name = "splashheightentry";
			this.splashheightentry.IsEditable = true;
			this.splashheightentry.InvisibleChar = '•';
			this.table1.Add(this.splashheightentry);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.splashheightentry]));
			w10.TopAttach = ((uint)(2));
			w10.BottomAttach = ((uint)(3));
			w10.LeftAttach = ((uint)(3));
			w10.RightAttach = ((uint)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.splashwidthentry = new global::Gtk.Entry();
			this.splashwidthentry.CanFocus = true;
			this.splashwidthentry.Name = "splashwidthentry";
			this.splashwidthentry.IsEditable = true;
			this.splashwidthentry.InvisibleChar = '•';
			this.table1.Add(this.splashwidthentry);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.splashwidthentry]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
