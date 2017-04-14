using System;

using UIKit;

namespace Xam.PMAlertController.Sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.twoChoicesButton.TouchUpInside += TwoChoicesButton_TouchUpInside;
			this.threeChoicesButton.TouchUpInside += ThreeChoicesButton_TouchUpInside;

			// Perform any additional setup after loading the view, typically from a nib.
		}

		void TwoChoicesButton_TouchUpInside(object sender, EventArgs e)
		{
			var alertVC = new PMAlertController("Welcome",
												"This is a sample for PMAlertController with two choices available",
												UIImage.FromBundle("home"),
												PMAlertControllerStyle.Walkthrough);

			alertVC.AddAction(new PMAlertAction("Cool", PMAlertActionStyle.Default, null));
			alertVC.AddAction(new PMAlertAction("I don't care", PMAlertActionStyle.Cancel, null));

			this.PresentViewController(alertVC, true, null);
		}

		void ThreeChoicesButton_TouchUpInside(object sender, EventArgs e)
		{
			var alertVC = new PMAlertController("Welcome back",
												"This is a sample for PMAlertController with more than two choices available",
												UIImage.FromBundle("home"),
												PMAlertControllerStyle.Walkthrough);

			var customAction = new PMAlertAction("Awesome", PMAlertActionStyle.Default, null);
			customAction.SetTitleColor(UIColor.FromRGB(80, 190, 135), UIControlState.Normal);
			alertVC.AddAction(customAction);
			alertVC.AddAction(new PMAlertAction("Cool", PMAlertActionStyle.Default, null));
			alertVC.AddAction(new PMAlertAction("I don't care", PMAlertActionStyle.Default, null));
			alertVC.AddAction(new PMAlertAction("Cancel", PMAlertActionStyle.Cancel, null));

			this.PresentViewController(alertVC, true, null);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
