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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Func<bool>))]
		internal delegate bool DFuncArity1V0 (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity1V0 {
			static internal readonly DFuncArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DFuncArity1V0))]
			static unsafe bool Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Func<bool>) (descriptor->Target);
				System.Boolean retval = del ();
				return retval;
			}
		} /* class SDFuncArity1V0 */
		
		internal class NIDFuncArity1V0 {
			IntPtr blockPtr;
			DFuncArity1V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDFuncArity1V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DFuncArity1V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDFuncArity1V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Func<bool> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Func<bool>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDFuncArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe bool Invoke ()
			{
				var ret = invoker (blockPtr);
				return ret;
			}
		} /* class NIDFuncArity1V0 */
	}
}
