
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Sparrow;
using System.Drawing;

namespace SparrowTest
{

	// The name AppDelegateIPhone is referenced in the MainWindowIPhone.xib file.
	public partial class AppDelegateIPhone : UIApplicationDelegate
	{
		// This method is invoked when the application has loaded its UI and its ready to run
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// If you have defined a view, add it here:
			// window.AddSubview (navigationController.View);
			
			SPAudioEngine.StartWithCategory(Sparrow.SPAudioSessionCategory.AmbientSound);
			SPStage.SupportHighResolutions = true;
			
			SizeF screenSize = UIScreen.MainScreen.Bounds.Size;
			Game game = new Game (screenSize.Width, screenSize.Height);
			sparrowView.Stage = game;
			sparrowView.MultipleTouchEnabled = true;
			sparrowView.FrameRate = 30;
			
			sparrowView.Start ();
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

