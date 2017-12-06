using System;
using Foundation;
using ObjCRuntime;
using Security;
using CoreTelephony;
using SystemConfiguration;

namespace tingyunApp.iOS
{
	// @interface NBSAppAgent : NSObject
	[BaseType(typeof(NSObject))]
	interface NBSAppAgent
	{
		// +(void)startWithAppID:(NSString *)appId;
		[Static]
		[Export("startWithAppID:")]
		void StartWithAppID(string appId);

		// +(void)startWithAppID:(NSString *)appId channelId:(NSString *)channelId;
		[Static]
		[Export("startWithAppID:channelId:")]
		void StartWithAppID(string appId, string channelId);

		// +(void)startWithAppID:(NSString *)appId rateOfLaunch:(double)rate;
		[Static]
		[Export("startWithAppID:rateOfLaunch:")]
		void StartWithAppID(string appId, double rate);

		// +(void)startWithAppID:(NSString *)appId location:(BOOL)locationAllowed;
		[Static]
		[Export("startWithAppID:location:")]
		void StartWithAppID(string appId, bool locationAllowed);

		// +(void)startWithAppID:(NSString *)appId location:(BOOL)locationAllowed rateOfLaunch:(double)rate channelId:(NSString *)channelId;
		[Static]
		[Export("startWithAppID:location:rateOfLaunch:channelId:")]
		void StartWithAppID(string appId, bool locationAllowed, double rate, string channelId);

		// +(void)setIgnoreBlock:(BOOL (^)(NSURLRequest *))block;
		[Static]
		[Export("setIgnoreBlock:")]
		void SetIgnoreBlock(Func<bool> block);

		// +(void)setCustomerData:(NSString *)data forKey:(NSString *)key;
		[Static]
		[Export("setCustomerData:forKey:")]
		void SetCustomerData(string data, string key);

		// +(void)setSetOption:(int)option;
		[Static]
		[Export("setSetOption:")]
		void SetSetOption(int option);

		// +(void)leaveBreadcrumb:(NSString *)breadcrumb;
		[Static]
		[Export("leaveBreadcrumb:")]
		void LeaveBreadcrumb(string breadcrumb);

		// +(void)setUserIdentifier:(NSString *)userId;
		[Static]
		[Export("setUserIdentifier:")]
		void SetUserIdentifier(string userId);

		// +(void)trackEvent:(NSString *)eventID;
		[Static]
		[Export("trackEvent:")]
		void TrackEvent(string eventID);
	}

	// @interface Enterprise (NBSAppAgent)
	[Category]
	[BaseType(typeof(NBSAppAgent))]
	interface NBSAppAgent_Enterprise
	{
		// +(void)setRedirectURL:(NSString *)URL;
		[Static]
		[Export("setRedirectURL:")]
		void SetRedirectURL(string URL);

		// +(void)setHttpEnabled:(BOOL)isEnable;
		[Static]
		[Export("setHttpEnabled:")]
		void SetHttpEnabled(bool isEnable);

		// +(void)httpsAllowAnyCert;
		[Static]
		[Export("httpsAllowAnyCert")]
		void HttpsAllowAnyCert();
	}
}

