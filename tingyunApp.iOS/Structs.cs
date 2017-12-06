using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace tingyunApp.iOS
{
	static class CFunctions
	{
		// extern void NBSDispatch_async (dispatch_queue_t queue, dispatch_block_t block);
		//[DllImport ("__Internal")]
		//static extern void NBSDispatch_async (DispatchQueue queue, dispatch_block_t block);

		// extern void NBSDispatch_sync (dispatch_queue_t queue, dispatch_block_t block);
		//[DllImport ("__Internal")]
		//static extern void NBSDispatch_sync (DispatchQueue queue, dispatch_block_t block);

		// extern void NBSDispatch_after (dispatch_time_t when, dispatch_queue_t queue, dispatch_block_t block);
		//[DllImport ("__Internal")]
		//static extern void NBSDispatch_after (ulong when, DispatchQueue queue, dispatch_block_t block);

		// extern void NBSDispatch_apply (size_t iterations, dispatch_queue_t queue, void (^block)(size_t));
		//[DllImport ("__Internal")]
		//static extern void NBSDispatch_apply (nuint iterations, DispatchQueue queue, Action<nuint> block);

		// extern void nbsCustomerAPI_logStart (NSString *eventName, id self, SEL _cmd);
		[DllImport ("__Internal")]
		static extern void nbsCustomerAPI_logStart (NSString eventName, NSObject self, Selector _cmd);

		// extern void nbsCustomerAPI_logFinish (NSString *eventName, SEL _cmd);
		[DllImport ("__Internal")]
		static extern void nbsCustomerAPI_logFinish (NSString eventName, Selector _cmd);
	}
}
