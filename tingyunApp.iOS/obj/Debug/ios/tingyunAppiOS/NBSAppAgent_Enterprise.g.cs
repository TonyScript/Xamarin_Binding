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
	public unsafe static partial class NBSAppAgent_Enterprise  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NBSAppAgent");
		
		[Export ("httpsAllowAnyCert")]
		[CompilerGenerated]
		public static void HttpsAllowAnyCert (this NBSAppAgent This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("httpsAllowAnyCert"));
		}
		
		[Export ("setHttpEnabled:")]
		[CompilerGenerated]
		public static void SetHttpEnabled (this NBSAppAgent This, bool isEnable)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setHttpEnabled:"), isEnable);
		}
		
		[Export ("setRedirectURL:")]
		[CompilerGenerated]
		public static void SetRedirectURL (this NBSAppAgent This, string URL)
		{
			if (URL == null)
				throw new ArgumentNullException ("URL");
			var nsURL = NSString.CreateNative (URL);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setRedirectURL:"), nsURL);
			NSString.ReleaseNative (nsURL);
			
		}
		
	} /* class NBSAppAgent_Enterprise */
}
