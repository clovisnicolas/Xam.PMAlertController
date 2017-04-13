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
	[Register("_TtC17PMAlertController13PMAlertAction", true)]
	public unsafe partial class PMAlertAction : global::UIKit.UIButton {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("_TtC17PMAlertController13PMAlertAction");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PMAlertAction (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected PMAlertAction (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PMAlertAction (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithTitle:style:action:")]
		[CompilerGenerated]
		public unsafe PMAlertAction (string title, PMAlertActionStyle style, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action action)
			: base (NSObjectFlag.Empty)
		{
			var nstitle = NSString.CreateNative (title);
			BlockLiteral *block_ptr_action;
			BlockLiteral block_action;
			if (action == null){
				block_ptr_action = null;
			} else {
				block_action = new BlockLiteral ();
				block_ptr_action = &block_action;
				block_action.SetupBlock (Trampolines.SDAction.Handler, action);
			}
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr (this.Handle, Selector.GetHandle ("initWithTitle:style:action:"), nstitle, (UInt64)style, (IntPtr) block_ptr_action), "initWithTitle:style:action:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_IntPtr (this.Handle, Selector.GetHandle ("initWithTitle:style:action:"), nstitle, (UInt32)style, (IntPtr) block_ptr_action), "initWithTitle:style:action:");
				}
			} else {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithTitle:style:action:"), nstitle, (UInt64)style, (IntPtr) block_ptr_action), "initWithTitle:style:action:");
				} else {
					InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithTitle:style:action:"), nstitle, (UInt32)style, (IntPtr) block_ptr_action), "initWithTitle:style:action:");
				}
			}
			NSString.ReleaseNative (nstitle);
			if (block_ptr_action != null)
				block_ptr_action->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public virtual PMAlertActionStyle ActionStyle {
			[Export ("actionStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				PMAlertActionStyle ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PMAlertActionStyle) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("actionStyle"));
					} else {
						ret = (PMAlertActionStyle) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("actionStyle"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PMAlertActionStyle) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("actionStyle"));
					} else {
						ret = (PMAlertActionStyle) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("actionStyle"));
					}
				}
				return ret;
			}
			
			[Export ("setActionStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setActionStyle:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setActionStyle:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setActionStyle:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setActionStyle:"), (UInt32)value);
					}
				}
			}
		}
		
		public partial class PMAlertActionAppearance : global::UIKit.UIButton.UIButtonAppearance {
			protected internal PMAlertActionAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new PMAlertActionAppearance Appearance {
			get { return new PMAlertActionAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new PMAlertActionAppearance GetAppearance<T> () where T: PMAlertAction {
			return new PMAlertActionAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new PMAlertActionAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new PMAlertActionAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new PMAlertActionAppearance GetAppearance (UITraitCollection traits) {
			return new PMAlertActionAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new PMAlertActionAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new PMAlertActionAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new PMAlertActionAppearance GetAppearance<T> (UITraitCollection traits) where T: PMAlertAction {
			return new PMAlertActionAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new PMAlertActionAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: PMAlertAction{
			return new PMAlertActionAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class PMAlertAction */
}
