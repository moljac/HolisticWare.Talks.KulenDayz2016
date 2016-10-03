#  HolisticWare.Talks.KulenDayz2016

## Xamarin.iOS Intro to UI Programming

1. 	Application Dissection/Decomposition
	1	Project Settings
	2.	Info.plist
	3.	Entitlements.plist
2. 	Application Launching
	1.	Storyboard
		AppLaunch01SingleViewStoryboard
		1.	Main.cs
		2.	AppDelegate.cs 
		3.	Add StoryboardCustom.storyboard
	2.	Code 
		AppLaunch01SingleViewXib
		1.	Remove Main.storyboard
		2.	Info.plist  - remove Main Interface
		3.	AppDelegate.FinishedLaunching()
			//-------------------------------------------------------------------
			//  1.  Window
			// create a new window instance based on the screen size
			UIWindow window = new UIWindow(UIScreen.MainScreen.Bounds);
			this.Window = window;

			//  2.  Create UIViewController
			UIViewController controller = 
											new UIViewController()
											//new UIViewControllerCustom()
											;
			// controller.View.BackgroundColor = UIColor.Red;

			//  3.  Assign RootView Controller
			Window.RootViewController = controller;

			// make the window key (main/primary) and visible
			window.MakeKeyAndVisible();
			//-------------------------------------------------------------------
		4.	New File Add
			ViewController
			ViewControllerCode.xib
		3.	ViewControllerCode.ViewDidLoad()

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
			//-----------------------------------------------------------------
			
	3.	XIB
		AppLaunch01SingleViewXib
		1.	Remove Main.storyboard
			Objective-C exception thrown.  
			Name: NSInvalidArgumentException 
			Reason: Could not find a storyboard named 'Main' in bundle NSBundle 
		2.	Info.plist
			Main Interface remove storyboard
		3.	New File Add
			Empty User Interface
			ViewControllerXibOnly.xib
		4.	Info.plist 
			Main Interface
			Select -  ViewControllerXibOnly
		5.	New File Add
			ViewController
			ViewControllerXib.xib
		4.	Info.plist 
			Main Interface
			Select -  ViewControllerXib


