//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace Xam.PMAlertController {
	[Register("_TtC17PMAlertController17PMAlertController", true)]
	public unsafe partial class PMAlertController : global::UIKit.UIViewController {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("_TtC17PMAlertController17PMAlertController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PMAlertController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PMAlertController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PMAlertController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PMAlertController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithTitle:description:image:style:")]
		[CompilerGenerated]
		public PMAlertController (string title, string description, global::UIKit.UIImage image, PMAlertControllerStyle style)
			: base (NSObjectFlag.Empty)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (description == null)
				throw new ArgumentNullException ("description");
			var nstitle = NSString.CreateNative (title);
			var nsdescription = NSString.CreateNative (description);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64 (this.Handle, Selector.GetHandle ("initWithTitle:description:image:style:"), nstitle, nsdescription, image == null ? IntPtr.Zero : image.Handle, (UInt64)style), "initWithTitle:description:image:style:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt32 (this.Handle, Selector.GetHandle ("initWithTitle:description:image:style:"), nstitle, nsdescription, image == null ? IntPtr.Zero : image.Handle, (UInt32)style), "initWithTitle:description:image:style:");
				}
			} else {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64 (this.SuperHandle, Selector.GetHandle ("initWithTitle:description:image:style:"), nstitle, nsdescription, image == null ? IntPtr.Zero : image.Handle, (UInt64)style), "initWithTitle:description:image:style:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt32 (this.SuperHandle, Selector.GetHandle ("initWithTitle:description:image:style:"), nstitle, nsdescription, image == null ? IntPtr.Zero : image.Handle, (UInt32)style), "initWithTitle:description:image:style:");
				}
			}
			NSString.ReleaseNative (nstitle);
			NSString.ReleaseNative (nsdescription);
			
		}
		
		[Export ("initWithNibName:bundle:")]
		[CompilerGenerated]
		public PMAlertController (string nibNameOrNil, NSBundle nibBundleOrNil)
			: base (NSObjectFlag.Empty)
		{
			var nsnibNameOrNil = NSString.CreateNative (nibNameOrNil);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithNibName:bundle:"), nsnibNameOrNil, nibBundleOrNil == null ? IntPtr.Zero : nibBundleOrNil.Handle), "initWithNibName:bundle:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithNibName:bundle:"), nsnibNameOrNil, nibBundleOrNil == null ? IntPtr.Zero : nibBundleOrNil.Handle), "initWithNibName:bundle:");
			}
			NSString.ReleaseNative (nsnibNameOrNil);
			
		}
		
		[Export ("addAction:")]
		[CompilerGenerated]
		public virtual void AddAction (PMAlertAction alertAction)
		{
			if (alertAction == null)
				throw new ArgumentNullException ("alertAction");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addAction:"), alertAction.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addAction:"), alertAction.Handle);
			}
		}
		
		[Export ("addTextField:")]
		[CompilerGenerated]
		public unsafe virtual void AddTextField ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<global::UIKit.UITextField> configuration)
		{
			if (configuration == null)
				throw new ArgumentNullException ("configuration");
			BlockLiteral *block_ptr_configuration;
			BlockLiteral block_configuration;
			block_configuration = new BlockLiteral ();
			block_ptr_configuration = &block_configuration;
			block_configuration.SetupBlock (Trampolines.SDActionArity1V0.Handler, configuration);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addTextField:"), (IntPtr) block_ptr_configuration);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addTextField:"), (IntPtr) block_ptr_configuration);
			}
			block_ptr_configuration->CleanupBlock ();
			
		}
		
		[Export ("viewDidAppear:")]
		[CompilerGenerated]
		public virtual void ViewDidAppear (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("viewDidAppear:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("viewDidAppear:"), animated);
			}
		}
		
		[Export ("viewDidDisappear:")]
		[CompilerGenerated]
		public virtual void ViewDidDisappear (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("viewDidDisappear:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("viewDidDisappear:"), animated);
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat ALERT_STACK_VIEW_HEIGHT {
			[Export ("ALERT_STACK_VIEW_HEIGHT")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("ALERT_STACK_VIEW_HEIGHT"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ALERT_STACK_VIEW_HEIGHT"));
				}
			}
			
			[Export ("setALERT_STACK_VIEW_HEIGHT:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setALERT_STACK_VIEW_HEIGHT:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setALERT_STACK_VIEW_HEIGHT:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_AlertActionStackView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIStackView AlertActionStackView {
			[Export ("alertActionStackView", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIStackView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIStackView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("alertActionStackView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIStackView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alertActionStackView")));
				}
				MarkDirty ();
				__mt_AlertActionStackView_var = ret;
				return ret;
			}
			
			[Export ("setAlertActionStackView:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAlertActionStackView:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAlertActionStackView:"), value.Handle);
				}
				MarkDirty ();
				__mt_AlertActionStackView_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_AlertDescription_var;
		[CompilerGenerated]
		public virtual global::UIKit.UILabel AlertDescription {
			[Export ("alertDescription", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UILabel ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("alertDescription")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alertDescription")));
				}
				MarkDirty ();
				__mt_AlertDescription_var = ret;
				return ret;
			}
			
			[Export ("setAlertDescription:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAlertDescription:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAlertDescription:"), value.Handle);
				}
				MarkDirty ();
				__mt_AlertDescription_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_AlertImage_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImageView AlertImage {
			[Export ("alertImage", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("alertImage")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alertImage")));
				}
				MarkDirty ();
				__mt_AlertImage_var = ret;
				return ret;
			}
			
			[Export ("setAlertImage:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAlertImage:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAlertImage:"), value.Handle);
				}
				MarkDirty ();
				__mt_AlertImage_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_AlertMaskBackground_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImageView AlertMaskBackground {
			[Export ("alertMaskBackground", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("alertMaskBackground")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alertMaskBackground")));
				}
				MarkDirty ();
				__mt_AlertMaskBackground_var = ret;
				return ret;
			}
			
			[Export ("setAlertMaskBackground:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAlertMaskBackground:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAlertMaskBackground:"), value.Handle);
				}
				MarkDirty ();
				__mt_AlertMaskBackground_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_AlertStackViewHeightConstraint_var;
		[CompilerGenerated]
		public virtual global::UIKit.NSLayoutConstraint AlertStackViewHeightConstraint {
			[Export ("alertStackViewHeightConstraint", ArgumentSemantic.Weak)]
			get {
				global::UIKit.NSLayoutConstraint ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.NSLayoutConstraint> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("alertStackViewHeightConstraint")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.NSLayoutConstraint> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alertStackViewHeightConstraint")));
				}
				MarkDirty ();
				__mt_AlertStackViewHeightConstraint_var = ret;
				return ret;
			}
			
			[Export ("setAlertStackViewHeightConstraint:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAlertStackViewHeightConstraint:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAlertStackViewHeightConstraint:"), value.Handle);
				}
				MarkDirty ();
				__mt_AlertStackViewHeightConstraint_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_AlertTitle_var;
		[CompilerGenerated]
		public virtual global::UIKit.UILabel AlertTitle {
			[Export ("alertTitle", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UILabel ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("alertTitle")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alertTitle")));
				}
				MarkDirty ();
				__mt_AlertTitle_var = ret;
				return ret;
			}
			
			[Export ("setAlertTitle:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAlertTitle:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAlertTitle:"), value.Handle);
				}
				MarkDirty ();
				__mt_AlertTitle_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_AlertView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView AlertView {
			[Export ("alertView", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("alertView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alertView")));
				}
				MarkDirty ();
				__mt_AlertView_var = ret;
				return ret;
			}
			
			[Export ("setAlertView:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAlertView:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAlertView:"), value.Handle);
				}
				MarkDirty ();
				__mt_AlertView_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_AlertViewWidthConstraint_var;
		[CompilerGenerated]
		public virtual global::UIKit.NSLayoutConstraint AlertViewWidthConstraint {
			[Export ("alertViewWidthConstraint", ArgumentSemantic.Weak)]
			get {
				global::UIKit.NSLayoutConstraint ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.NSLayoutConstraint> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("alertViewWidthConstraint")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.NSLayoutConstraint> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alertViewWidthConstraint")));
				}
				MarkDirty ();
				__mt_AlertViewWidthConstraint_var = ret;
				return ret;
			}
			
			[Export ("setAlertViewWidthConstraint:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAlertViewWidthConstraint:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAlertViewWidthConstraint:"), value.Handle);
				}
				MarkDirty ();
				__mt_AlertViewWidthConstraint_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool DismissWithBackgroudTouch {
			[Export ("dismissWithBackgroudTouch")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("dismissWithBackgroudTouch"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dismissWithBackgroudTouch"));
				}
			}
			
			[Export ("setDismissWithBackgroudTouch:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDismissWithBackgroudTouch:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDismissWithBackgroudTouch:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool GravityDismissAnimation {
			[Export ("gravityDismissAnimation")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("gravityDismissAnimation"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("gravityDismissAnimation"));
				}
			}
			
			[Export ("setGravityDismissAnimation:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setGravityDismissAnimation:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setGravityDismissAnimation:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_HeaderView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView HeaderView {
			[Export ("headerView", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("headerView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("headerView")));
				}
				MarkDirty ();
				__mt_HeaderView_var = ret;
				return ret;
			}
			
			[Export ("setHeaderView:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHeaderView:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setHeaderView:"), value.Handle);
				}
				MarkDirty ();
				__mt_HeaderView_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_HeaderViewHeightConstraint_var;
		[CompilerGenerated]
		public virtual global::UIKit.NSLayoutConstraint HeaderViewHeightConstraint {
			[Export ("headerViewHeightConstraint", ArgumentSemantic.Weak)]
			get {
				global::UIKit.NSLayoutConstraint ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.NSLayoutConstraint> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("headerViewHeightConstraint")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.NSLayoutConstraint> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("headerViewHeightConstraint")));
				}
				MarkDirty ();
				__mt_HeaderViewHeightConstraint_var = ret;
				return ret;
			}
			
			[Export ("setHeaderViewHeightConstraint:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHeaderViewHeightConstraint:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setHeaderViewHeightConstraint:"), value.Handle);
				}
				MarkDirty ();
				__mt_HeaderViewHeightConstraint_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UITextField[] TextFields {
			[Export ("textFields", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UITextField[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<global::UIKit.UITextField>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textFields")));
				} else {
					ret = NSArray.ArrayFromHandle<global::UIKit.UITextField>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("textFields")));
				}
				return ret;
			}
			
			[Export ("setTextFields:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTextFields:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTextFields:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AlertActionStackView_var = null;
				__mt_AlertDescription_var = null;
				__mt_AlertImage_var = null;
				__mt_AlertMaskBackground_var = null;
				__mt_AlertStackViewHeightConstraint_var = null;
				__mt_AlertTitle_var = null;
				__mt_AlertViewWidthConstraint_var = null;
				__mt_AlertView_var = null;
				__mt_HeaderViewHeightConstraint_var = null;
				__mt_HeaderView_var = null;
			}
		}
	} /* class PMAlertController */
}
