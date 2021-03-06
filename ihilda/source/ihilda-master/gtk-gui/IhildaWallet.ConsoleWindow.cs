
// This file has been generated by the GUI designer. Do not modify.
namespace IhildaWallet
{
	public partial class ConsoleWindow
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action FileAction;

		private global::Gtk.Action newScriptAction;

		private global::Gtk.Action openScriptAction;

		private global::Gtk.Action saveHistoryAction;

		private global::Gtk.Action saveHistoryAsAction;

		private global::Gtk.Action saveConsoleTextAction;

		private global::Gtk.Action saveConsoleTextAsAction;

		private global::Gtk.Action closeConsoleAction;

		private global::Gtk.Action quitAction;

		private global::Gtk.Action fileAction;

		private global::Gtk.VBox vbox2;

		private global::IhildaWallet.Console console1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget IhildaWallet.ConsoleWindow
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.FileAction = new global::Gtk.Action("FileAction", global::Mono.Unix.Catalog.GetString("File"), null, null);
			this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString("File");
			w1.Add(this.FileAction, null);
			this.newScriptAction = new global::Gtk.Action("newScriptAction", global::Mono.Unix.Catalog.GetString("new script"), null, null);
			this.newScriptAction.ShortLabel = global::Mono.Unix.Catalog.GetString("new script");
			w1.Add(this.newScriptAction, null);
			this.openScriptAction = new global::Gtk.Action("openScriptAction", global::Mono.Unix.Catalog.GetString("open script"), null, null);
			this.openScriptAction.ShortLabel = global::Mono.Unix.Catalog.GetString("open script");
			w1.Add(this.openScriptAction, null);
			this.saveHistoryAction = new global::Gtk.Action("saveHistoryAction", global::Mono.Unix.Catalog.GetString("save history"), null, null);
			this.saveHistoryAction.ShortLabel = global::Mono.Unix.Catalog.GetString("save history");
			w1.Add(this.saveHistoryAction, null);
			this.saveHistoryAsAction = new global::Gtk.Action("saveHistoryAsAction", global::Mono.Unix.Catalog.GetString("save history as"), null, null);
			this.saveHistoryAsAction.ShortLabel = global::Mono.Unix.Catalog.GetString("save history as");
			w1.Add(this.saveHistoryAsAction, null);
			this.saveConsoleTextAction = new global::Gtk.Action("saveConsoleTextAction", global::Mono.Unix.Catalog.GetString("save console text"), null, null);
			this.saveConsoleTextAction.ShortLabel = global::Mono.Unix.Catalog.GetString("save console text");
			w1.Add(this.saveConsoleTextAction, null);
			this.saveConsoleTextAsAction = new global::Gtk.Action("saveConsoleTextAsAction", global::Mono.Unix.Catalog.GetString("save console text as"), null, null);
			this.saveConsoleTextAsAction.ShortLabel = global::Mono.Unix.Catalog.GetString("save console text as");
			w1.Add(this.saveConsoleTextAsAction, null);
			this.closeConsoleAction = new global::Gtk.Action("closeConsoleAction", global::Mono.Unix.Catalog.GetString("close console"), null, null);
			this.closeConsoleAction.ShortLabel = global::Mono.Unix.Catalog.GetString("close console");
			w1.Add(this.closeConsoleAction, null);
			this.quitAction = new global::Gtk.Action("quitAction", global::Mono.Unix.Catalog.GetString("quit"), null, null);
			this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString("quit");
			w1.Add(this.quitAction, null);
			this.fileAction = new global::Gtk.Action("fileAction", global::Mono.Unix.Catalog.GetString("file"), null, null);
			this.fileAction.ShortLabel = global::Mono.Unix.Catalog.GetString("file");
			w1.Add(this.fileAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "IhildaWallet.ConsoleWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Console");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource("IhildaWallet.Images.xrp_25x22.png");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child IhildaWallet.ConsoleWindow.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.console1 = new global::IhildaWallet.Console();
			this.console1.Events = ((global::Gdk.EventMask)(256));
			this.console1.Name = "console1";
			this.vbox2.Add(this.console1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.console1]));
			w2.Position = 0;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 987;
			this.DefaultHeight = 459;
			this.Show();
		}
	}
}
