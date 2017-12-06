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

namespace tingyunApp.iOS {
	[Register("NBSAppAgent", true)]
	public unsafe partial class NBSAppAgent : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NBSAppAgent");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NBSAppAgent () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NBSAppAgent (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NBSAppAgent (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("leaveBreadcrumb:")]
		[CompilerGenerated]
		public static void LeaveBreadcrumb (string breadcrumb)
		{
			if (breadcrumb == null)
				throw new ArgumentNullException ("breadcrumb");
			var nsbreadcrumb = NSString.CreateNative (breadcrumb);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("leaveBreadcrumb:"), nsbreadcrumb);
			NSString.ReleaseNative (nsbreadcrumb);
			
		}
		
		[Export ("setCustomerData:forKey:")]
		[CompilerGenerated]
		public static void SetCustomerData (string data, string key)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsdata = NSString.CreateNative (data);
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setCustomerData:forKey:"), nsdata, nskey);
			NSString.ReleaseNative (nsdata);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("setIgnoreBlock:")]
		[CompilerGenerated]
		public unsafe static void SetIgnoreBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity1V0))]global::System.Func<bool> block)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (Trampolines.SDFuncArity1V0.Handler, block);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setIgnoreBlock:"), (IntPtr) block_ptr_block);
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("setSetOption:")]
		[CompilerGenerated]
		public static void SetSetOption (int option)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setSetOption:"), option);
		}
		
		[Export ("setUserIdentifier:")]
		[CompilerGenerated]
		public static void SetUserIdentifier (string userId)
		{
			if (userId == null)
				throw new ArgumentNullException ("userId");
			var nsuserId = NSString.CreateNative (userId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setUserIdentifier:"), nsuserId);
			NSString.ReleaseNative (nsuserId);
			
		}
		
		[Export ("startWithAppID:")]
		[CompilerGenerated]
		public static void StartWithAppID (string appId)
		{
			if (appId == null)
				throw new ArgumentNullException ("appId");
			var nsappId = NSString.CreateNative (appId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("startWithAppID:"), nsappId);
			NSString.ReleaseNative (nsappId);
			
		}
		
		[Export ("startWithAppID:channelId:")]
		[CompilerGenerated]
		public static void StartWithAppID (string appId, string channelId)
		{
			if (appId == null)
				throw new ArgumentNullException ("appId");
			if (channelId == null)
				throw new ArgumentNullException ("channelId");
			var nsappId = NSString.CreateNative (appId);
			var nschannelId = NSString.CreateNative (channelId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("startWithAppID:channelId:"), nsappId, nschannelId);
			NSString.ReleaseNative (nsappId);
			NSString.ReleaseNative (nschannelId);
			
		}
		
		[Export ("startWithAppID:rateOfLaunch:")]
		[CompilerGenerated]
		public static void StartWithAppID (string appId, global::System.Double rate)
		{
			if (appId == null)
				throw new ArgumentNullException ("appId");
			var nsappId = NSString.CreateNative (appId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double (class_ptr, Selector.GetHandle ("startWithAppID:rateOfLaunch:"), nsappId, rate);
			NSString.ReleaseNative (nsappId);
			
		}
		
		[Export ("startWithAppID:location:")]
		[CompilerGenerated]
		public static void StartWithAppID (string appId, bool locationAllowed)
		{
			if (appId == null)
				throw new ArgumentNullException ("appId");
			var nsappId = NSString.CreateNative (appId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (class_ptr, Selector.GetHandle ("startWithAppID:location:"), nsappId, locationAllowed);
			NSString.ReleaseNative (nsappId);
			
		}
		
		[Export ("startWithAppID:location:rateOfLaunch:channelId:")]
		[CompilerGenerated]
		public static void StartWithAppID (string appId, bool locationAllowed, global::System.Double rate, string channelId)
		{
			if (appId == null)
				throw new ArgumentNullException ("appId");
			if (channelId == null)
				throw new ArgumentNullException ("channelId");
			var nsappId = NSString.CreateNative (appId);
			var nschannelId = NSString.CreateNative (channelId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_Double_IntPtr (class_ptr, Selector.GetHandle ("startWithAppID:location:rateOfLaunch:channelId:"), nsappId, locationAllowed, rate, nschannelId);
			NSString.ReleaseNative (nsappId);
			NSString.ReleaseNative (nschannelId);
			
		}
		
		[Export ("trackEvent:")]
		[CompilerGenerated]
		public static void TrackEvent (string eventID)
		{
			if (eventID == null)
				throw new ArgumentNullException ("eventID");
			var nseventID = NSString.CreateNative (eventID);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("trackEvent:"), nseventID);
			NSString.ReleaseNative (nseventID);
			
		}
		
	} /* class NBSAppAgent */
}
