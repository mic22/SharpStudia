
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox2;
	private global::Gtk.HPaned hpaned3;
	private global::Gtk.DrawingArea drawingarea2;
	private global::Gtk.Image image3;
	private global::Gtk.FileChooserButton filechooserbutton3;
	private global::Gtk.HBox hbox4;
	private global::Gtk.VBox vbox3;
	private global::Gtk.Label label4;
	private global::Gtk.Entry entry3;
	private global::Gtk.Button button2;
	private global::Gtk.VBox vbox4;
	private global::Gtk.VBox vbox5;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hpaned3 = new global::Gtk.HPaned ();
		this.hpaned3.CanFocus = true;
		this.hpaned3.Name = "hpaned3";
		this.hpaned3.Position = 216;
		// Container child hpaned3.Gtk.Paned+PanedChild
		this.drawingarea2 = new global::Gtk.DrawingArea ();
		this.drawingarea2.Name = "drawingarea2";
		this.hpaned3.Add (this.drawingarea2);
		global::Gtk.Paned.PanedChild w1 = ((global::Gtk.Paned.PanedChild)(this.hpaned3 [this.drawingarea2]));
		w1.Resize = false;
		// Container child hpaned3.Gtk.Paned+PanedChild
		this.image3 = new global::Gtk.Image ();
		this.image3.Name = "image3";
		this.hpaned3.Add (this.image3);
		global::Gtk.Paned.PanedChild w2 = ((global::Gtk.Paned.PanedChild)(this.hpaned3 [this.image3]));
		w2.Resize = false;
		this.vbox2.Add (this.hpaned3);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hpaned3]));
		w3.Position = 0;
		// Container child vbox2.Gtk.Box+BoxChild
		this.filechooserbutton3 = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Wybór pliku"), ((global::Gtk.FileChooserAction)(0)));
		this.filechooserbutton3.Name = "filechooserbutton3";
		this.vbox2.Add (this.filechooserbutton3);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.filechooserbutton3]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Podaj nazwe pliku");
		this.vbox3.Add (this.label4);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.label4]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.entry3 = new global::Gtk.Entry ();
		this.entry3.CanFocus = true;
		this.entry3.Name = "entry3";
		this.entry3.IsEditable = true;
		this.entry3.InvisibleChar = '•';
		this.vbox3.Add (this.entry3);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.entry3]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.button2 = new global::Gtk.Button ();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString ("Zapisz");
		this.vbox3.Add (this.button2);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.button2]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		this.hbox4.Add (this.vbox3);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.vbox3]));
		w8.Position = 0;
		w8.Expand = false;
		w8.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		this.hbox4.Add (this.vbox4);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.vbox4]));
		w9.Position = 1;
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbox5 = new global::Gtk.VBox ();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		this.hbox4.Add (this.vbox5);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.vbox5]));
		w10.Position = 2;
		this.vbox2.Add (this.hbox4);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox4]));
		w11.Position = 2;
		w11.Expand = false;
		w11.Fill = false;
		this.Add (this.vbox2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 1006;
		this.DefaultHeight = 1126;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.filechooserbutton3.SelectionChanged += new global::System.EventHandler (this.OnFilechooserbutton3SelectionChanged);
	}
}