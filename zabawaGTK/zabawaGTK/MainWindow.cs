using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnFilechooserbutton3SelectionChanged (object sender, EventArgs e)
	{
		image3.File=filechooserbutton3.Uri.Substring(6);
	}


}
