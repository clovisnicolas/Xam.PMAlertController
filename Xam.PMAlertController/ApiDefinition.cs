namespace Xam.PMAlertController
{
	using System;
	using Foundation;
	using ObjCRuntime;
	using UIKit;

	// @interface PMAlertAction : UIButton
	[BaseType(typeof(UIButton), Name = "_TtC17PMAlertController13PMAlertAction")]
	[DisableDefaultCtor]
	interface PMAlertAction
	{
		// @property (nonatomic) enum PMAlertActionStyle actionStyle;
		[Export("actionStyle", ArgumentSemantic.Assign)]
		PMAlertActionStyle ActionStyle { get; set; }

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title style:(enum PMAlertActionStyle)style action:(void (^ _Nullable)(void))action;
		[Export("initWithTitle:style:action:")]
		IntPtr Constructor([NullAllowed] string title, PMAlertActionStyle style, [NullAllowed] Action action);
	}

	// @interface PMAlertController : UIViewController
	[BaseType(typeof(UIViewController), Name = "_TtC17PMAlertController17PMAlertController")]
	interface PMAlertController
	{
		// @property (nonatomic, weak) UIImageView * _Null_unspecified alertMaskBackground __attribute__((iboutlet));
		[Export("alertMaskBackground", ArgumentSemantic.Weak)]
		UIImageView AlertMaskBackground { get; set; }

		// @property (nonatomic, weak) UIView * _Null_unspecified alertView __attribute__((iboutlet));
		[Export("alertView", ArgumentSemantic.Weak)]
		UIView AlertView { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * _Null_unspecified alertViewWidthConstraint __attribute__((iboutlet));
		[Export("alertViewWidthConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint AlertViewWidthConstraint { get; set; }

		// @property (nonatomic, weak) UIView * _Null_unspecified headerView __attribute__((iboutlet));
		[Export("headerView", ArgumentSemantic.Weak)]
		UIView HeaderView { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * _Null_unspecified headerViewHeightConstraint __attribute__((iboutlet));
		[Export("headerViewHeightConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint HeaderViewHeightConstraint { get; set; }

		// @property (nonatomic, weak) UIImageView * _Null_unspecified alertImage __attribute__((iboutlet));
		[Export("alertImage", ArgumentSemantic.Weak)]
		UIImageView AlertImage { get; set; }

		// @property (nonatomic, weak) UILabel * _Null_unspecified alertTitle __attribute__((iboutlet));
		[Export("alertTitle", ArgumentSemantic.Weak)]
		UILabel AlertTitle { get; set; }

		// @property (nonatomic, weak) UILabel * _Null_unspecified alertDescription __attribute__((iboutlet));
		[Export("alertDescription", ArgumentSemantic.Weak)]
		UILabel AlertDescription { get; set; }

		// @property (nonatomic, weak) UIStackView * _Null_unspecified alertActionStackView __attribute__((iboutlet));
		[Export("alertActionStackView", ArgumentSemantic.Weak)]
		UIStackView AlertActionStackView { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * _Null_unspecified alertStackViewHeightConstraint __attribute__((iboutlet));
		[Export("alertStackViewHeightConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint AlertStackViewHeightConstraint { get; set; }

		// @property (nonatomic) CGFloat ALERT_STACK_VIEW_HEIGHT;
		[Export("ALERT_STACK_VIEW_HEIGHT")]
		nfloat ALERT_STACK_VIEW_HEIGHT { get; set; }

		// @property (copy, nonatomic) NSArray<UITextField *> * _Nonnull textFields;
		[Export("textFields", ArgumentSemantic.Copy)]
		UITextField[] TextFields { get; set; }

		// @property (nonatomic) BOOL gravityDismissAnimation;
		[Export("gravityDismissAnimation")]
		bool GravityDismissAnimation { get; set; }

		// @property (nonatomic) BOOL dismissWithBackgroudTouch;
		[Export("dismissWithBackgroudTouch")]
		bool DismissWithBackgroudTouch { get; set; }

		// -(void)viewDidAppear:(BOOL)animated;
		[Export("viewDidAppear:")]
		void ViewDidAppear(bool animated);

		// -(void)viewDidDisappear:(BOOL)animated;
		[Export("viewDidDisappear:")]
		void ViewDidDisappear(bool animated);

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title description:(NSString * _Nonnull)description image:(UIImage * _Nullable)image style:(enum PMAlertControllerStyle)style;
		[Export("initWithTitle:description:image:style:")]
		IntPtr Constructor(string title, string description, [NullAllowed] UIImage image, PMAlertControllerStyle style);

		// -(void)addAction:(PMAlertAction * _Nonnull)alertAction;
		[Export("addAction:")]
		void AddAction(PMAlertAction alertAction);

		// -(void)addTextField:(void (^ _Nonnull)(UITextField * _Nullable))configuration;
		[Export("addTextField:")]
		void AddTextField(Action<UITextField> configuration);

		// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
		[Export("initWithNibName:bundle:")]
		IntPtr Constructor([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

		// -(BOOL)textFieldShouldReturn:(UITextField * _Nonnull)textField;
		[Export("textFieldShouldReturn:")]
		bool TextFieldShouldReturn(UITextField textField);
	}

}
