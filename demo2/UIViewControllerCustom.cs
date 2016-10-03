using System;
using CoreGraphics;
using UIKit;

namespace demo2
{
	public partial class UIViewControllerCustom : UIViewController
	{
		public UIViewControllerCustom() : base("UIViewControllerCustom", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			this.View.BackgroundColor = UIColor.Green;

			UITextField t01 = new UITextField()
			{
				Frame = new CGRect(10, 200, this.View.Frame.Width - 20, 40),
				KeyboardType = UIKeyboardType.EmailAddress,
				BorderStyle = UITextBorderStyle.RoundedRect,
				Placeholder = "Email Address",
			};


			UIButton b01 = new UIButton(UIButtonType.Custom)
			{
				Frame = new CGRect(10, 250, View.Frame.Width - 20, 40),
				BackgroundColor = UIColor.FromRGB(0.5f, 0, 0),
			};
			b01.SetTitle("Press", UIControlState.Normal);

			UILabel l01 = new UILabel(new CGRect(10, 300, View.Frame.Width - 20, 40))
			{
				Text = "Label 1",
				TextAlignment = UITextAlignment.Center,
				TextColor = UIColor.Blue,
			};

			UILabel l02 = new UILabel(new CGRect(10, 350, View.Frame.Width - 20, 40))
			{
				Text = "Label 2",
				TextAlignment = UITextAlignment.Center,
				TextColor = UIColor.Blue,
			};

			//-----------------------------------------------------------------
			//// iOS API
			//this.View.AddSubview(t01);
			//this.View.AddSubviews(b01, l01);

			//// .net API
			//// ??????????? WHY ???????????????
			//this.View.Add(l02);

			//.............................................
			this.View = new UIView()
			{
				t01,
				l01,
				b01,
				l02,
			};
			this.View.BackgroundColor = UIColor.White;
			return;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


