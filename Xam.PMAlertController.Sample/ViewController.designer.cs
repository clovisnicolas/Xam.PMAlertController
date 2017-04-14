// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Xam.PMAlertController.Sample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton threeChoicesButton { get; set; }

		[Outlet]
		UIKit.UIButton twoChoicesButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (twoChoicesButton != null) {
				twoChoicesButton.Dispose ();
				twoChoicesButton = null;
			}

			if (threeChoicesButton != null) {
				threeChoicesButton.Dispose ();
				threeChoicesButton = null;
			}
		}
	}
}
