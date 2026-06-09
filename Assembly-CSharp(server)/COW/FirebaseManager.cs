using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Firebase;
using Firebase.Analytics;
using Firebase.Messaging;
using Il2CppDummyDll;
using InterApp;

namespace COW
{
	// Token: 0x02001241 RID: 4673
	[Token(Token = "0x2001241")]
	public static class FirebaseManager
	{
		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060047A5 RID: 18341 RVA: 0x000155B8 File Offset: 0x000137B8
		[Token(Token = "0x17000825")]
		public static bool UseFirebase
		{
			[Token(Token = "0x60047A5")]
			[Address(RVA = "0x1B95BB0", Offset = "0x1B95BB0", VA = "0x7BBC395BB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060047A6 RID: 18342 RVA: 0x000155D0 File Offset: 0x000137D0
		// (set) Token: 0x060047A7 RID: 18343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000826")]
		public static bool ShouldUseFirebase
		{
			[Token(Token = "0x60047A6")]
			[Address(RVA = "0x1B95D3C", Offset = "0x1B95D3C", VA = "0x7BBC395D3C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60047A7")]
			[Address(RVA = "0x1B95E1C", Offset = "0x1B95E1C", VA = "0x7BBC395E1C")]
			set
			{
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060047A8 RID: 18344 RVA: 0x000155E8 File Offset: 0x000137E8
		[Token(Token = "0x17000827")]
		public static bool CanUseFirebase
		{
			[Token(Token = "0x60047A8")]
			[Address(RVA = "0x1B95DBC", Offset = "0x1B95DBC", VA = "0x7BBC395DBC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060047A9 RID: 18345 RVA: 0x00015600 File Offset: 0x00013800
		// (set) Token: 0x060047AA RID: 18346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000828")]
		public static bool IsInited
		{
			[Token(Token = "0x60047A9")]
			[Address(RVA = "0x1B9603C", Offset = "0x1B9603C", VA = "0x7BBC39603C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DB20", Offset = "0x113DB20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60047AA")]
			[Address(RVA = "0x1B9643C", Offset = "0x1B9643C", VA = "0x7BBC39643C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DB30", Offset = "0x113DB30")]
			private set
			{
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060047AB RID: 18347 RVA: 0x00015618 File Offset: 0x00013818
		// (set) Token: 0x060047AC RID: 18348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000829")]
		public static bool IsIniting
		{
			[Token(Token = "0x60047AB")]
			[Address(RVA = "0x1B95FD4", Offset = "0x1B95FD4", VA = "0x7BBC395FD4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DB40", Offset = "0x113DB40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60047AC")]
			[Address(RVA = "0x1B964AC", Offset = "0x1B964AC", VA = "0x7BBC3964AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DB50", Offset = "0x113DB50")]
			private set
			{
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060047AD RID: 18349 RVA: 0x00015630 File Offset: 0x00013830
		// (set) Token: 0x060047AE RID: 18350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700082A")]
		public static bool IsOK
		{
			[Token(Token = "0x60047AD")]
			[Address(RVA = "0x1B960A4", Offset = "0x1B960A4", VA = "0x7BBC3960A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DB60", Offset = "0x113DB60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60047AE")]
			[Address(RVA = "0x1B9651C", Offset = "0x1B9651C", VA = "0x7BBC39651C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DB70", Offset = "0x113DB70")]
			private set
			{
			}
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047AF")]
		[Address(RVA = "0x1B9610C", Offset = "0x1B9610C", VA = "0x7BBC39610C")]
		private static void Shutdown()
		{
		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047B0")]
		[Address(RVA = "0x1B9689C", Offset = "0x1B9689C", VA = "0x7BBC39689C")]
		public static void Init([Optional] Action callback)
		{
		}

		// Token: 0x04007129 RID: 28969
		[Token(Token = "0x4007129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _PendingShutdown;

		// Token: 0x0400712A RID: 28970
		[Token(Token = "0x400712A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F64C", Offset = "0x112F64C")]
		private static bool <IsInited>k__BackingField;

		// Token: 0x0400712B RID: 28971
		[Token(Token = "0x400712B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F65C", Offset = "0x112F65C")]
		private static bool <IsIniting>k__BackingField;

		// Token: 0x0400712C RID: 28972
		[Token(Token = "0x400712C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F66C", Offset = "0x112F66C")]
		private static bool <IsOK>k__BackingField;

		// Token: 0x0400712D RID: 28973
		[Token(Token = "0x400712D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static HashSet<Action> _InitCallbacks;

		// Token: 0x02001242 RID: 4674
		[Token(Token = "0x2001242")]
		public static class Crashlytics
		{
			// Token: 0x1700082B RID: 2091
			// (get) Token: 0x060047B2 RID: 18354 RVA: 0x00015648 File Offset: 0x00013848
			// (set) Token: 0x060047B3 RID: 18355 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700082B")]
			public static bool UseCrashlytics
			{
				[Token(Token = "0x60047B2")]
				[Address(RVA = "0x1B97FCC", Offset = "0x1B97FCC", VA = "0x7BBC397FCC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60047B3")]
				[Address(RVA = "0x1B980D0", Offset = "0x1B980D0", VA = "0x7BBC3980D0")]
				set
				{
				}
			}

			// Token: 0x1700082C RID: 2092
			// (get) Token: 0x060047B4 RID: 18356 RVA: 0x00015660 File Offset: 0x00013860
			// (set) Token: 0x060047B5 RID: 18357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700082C")]
			public static bool CrashlyticsInited
			{
				[Token(Token = "0x60047B4")]
				[Address(RVA = "0x1B981F4", Offset = "0x1B981F4", VA = "0x7BBC3981F4")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DB80", Offset = "0x113DB80")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60047B5")]
				[Address(RVA = "0x1B98244", Offset = "0x1B98244", VA = "0x7BBC398244")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DB90", Offset = "0x113DB90")]
				private set
				{
				}
			}

			// Token: 0x060047B6 RID: 18358 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047B6")]
			[Address(RVA = "0x1B97284", Offset = "0x1B97284", VA = "0x7BBC397284")]
			internal static void Init()
			{
			}

			// Token: 0x060047B7 RID: 18359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047B7")]
			[Address(RVA = "0x1B9658C", Offset = "0x1B9658C", VA = "0x7BBC39658C")]
			internal static void Shutdown()
			{
			}

			// Token: 0x060047B8 RID: 18360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047B8")]
			[Address(RVA = "0x1B9829C", Offset = "0x1B9829C", VA = "0x7BBC39829C")]
			public static void SetUserId(string userId)
			{
			}

			// Token: 0x060047B9 RID: 18361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047B9")]
			[Address(RVA = "0x1B98378", Offset = "0x1B98378", VA = "0x7BBC398378")]
			public static void SetKeyValue(string key, string value)
			{
			}

			// Token: 0x060047BA RID: 18362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047BA")]
			[Address(RVA = "0x1B9846C", Offset = "0x1B9846C", VA = "0x7BBC39846C")]
			public static void Log(string msg)
			{
			}

			// Token: 0x060047BB RID: 18363 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047BB")]
			[Address(RVA = "0x1B98548", Offset = "0x1B98548", VA = "0x7BBC398548")]
			public static void Report(Exception exception)
			{
			}

			// Token: 0x0400712E RID: 28974
			[Token(Token = "0x400712E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F67C", Offset = "0x112F67C")]
			private static bool <CrashlyticsInited>k__BackingField;
		}

		// Token: 0x02001243 RID: 4675
		[Token(Token = "0x2001243")]
		public static class Analytics
		{
			// Token: 0x1700082D RID: 2093
			// (get) Token: 0x060047BC RID: 18364 RVA: 0x00015678 File Offset: 0x00013878
			[Token(Token = "0x1700082D")]
			public static bool UseAnalytics
			{
				[Token(Token = "0x60047BC")]
				[Address(RVA = "0x1B97928", Offset = "0x1B97928", VA = "0x7BBC397928")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700082E RID: 2094
			// (get) Token: 0x060047BD RID: 18365 RVA: 0x00015690 File Offset: 0x00013890
			// (set) Token: 0x060047BE RID: 18366 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700082E")]
			public static bool AnalyticsInited
			{
				[Token(Token = "0x60047BD")]
				[Address(RVA = "0x1B97A1C", Offset = "0x1B97A1C", VA = "0x7BBC397A1C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DBA0", Offset = "0x113DBA0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60047BE")]
				[Address(RVA = "0x1B97A6C", Offset = "0x1B97A6C", VA = "0x7BBC397A6C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DBB0", Offset = "0x113DBB0")]
				private set
				{
				}
			}

			// Token: 0x060047BF RID: 18367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047BF")]
			[Address(RVA = "0x1B973C4", Offset = "0x1B973C4", VA = "0x7BBC3973C4")]
			public static void Init()
			{
			}

			// Token: 0x060047C0 RID: 18368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047C0")]
			[Address(RVA = "0x1B9667C", Offset = "0x1B9667C", VA = "0x7BBC39667C")]
			internal static void Shutdown()
			{
			}

			// Token: 0x060047C1 RID: 18369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047C1")]
			[Address(RVA = "0x1B97AC4", Offset = "0x1B97AC4", VA = "0x7BBC397AC4")]
			public static void SetUserId(string userId)
			{
			}

			// Token: 0x060047C2 RID: 18370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047C2")]
			[Address(RVA = "0x1B97BC0", Offset = "0x1B97BC0", VA = "0x7BBC397BC0")]
			public static void SetUserProperty(string key, string value)
			{
			}

			// Token: 0x060047C3 RID: 18371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047C3")]
			[Address(RVA = "0x1B97CD4", Offset = "0x1B97CD4", VA = "0x7BBC397CD4")]
			public static void LogEvent(string eventName, [Optional] Dictionary<string, string> parameters)
			{
			}

			// Token: 0x0400712F RID: 28975
			[Token(Token = "0x400712F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F68C", Offset = "0x112F68C")]
			private static bool <AnalyticsInited>k__BackingField;

			// Token: 0x02001244 RID: 4676
			[Token(Token = "0x2001244")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAFA0", Offset = "0x10EAFA0")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x060047C5 RID: 18373 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60047C5")]
				[Address(RVA = "0x1B97F18", Offset = "0x1B97F18", VA = "0x7BBC397F18")]
				public <>c()
				{
				}

				// Token: 0x060047C6 RID: 18374 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60047C6")]
				[Address(RVA = "0x1B97F20", Offset = "0x1B97F20", VA = "0x7BBC397F20")]
				internal Parameter <LogEvent>b__10_0(KeyValuePair<string, string> pair)
				{
					return null;
				}

				// Token: 0x04007130 RID: 28976
				[Token(Token = "0x4007130")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly FirebaseManager.Analytics.<>c <>9;

				// Token: 0x04007131 RID: 28977
				[Token(Token = "0x4007131")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public static Converter<KeyValuePair<string, string>, Parameter> <>9__10_0;
			}
		}

		// Token: 0x02001245 RID: 4677
		[Token(Token = "0x2001245")]
		public static class Messaging
		{
			// Token: 0x1700082F RID: 2095
			// (get) Token: 0x060047C7 RID: 18375 RVA: 0x000156A8 File Offset: 0x000138A8
			[Token(Token = "0x1700082F")]
			public static bool UseMessaging
			{
				[Token(Token = "0x60047C7")]
				[Address(RVA = "0x1B98624", Offset = "0x1B98624", VA = "0x7BBC398624")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000830 RID: 2096
			// (get) Token: 0x060047C8 RID: 18376 RVA: 0x000156C0 File Offset: 0x000138C0
			// (set) Token: 0x060047C9 RID: 18377 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000830")]
			public static bool MessagingInited
			{
				[Token(Token = "0x60047C8")]
				[Address(RVA = "0x1B98718", Offset = "0x1B98718", VA = "0x7BBC398718")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DBC0", Offset = "0x113DBC0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60047C9")]
				[Address(RVA = "0x1B98768", Offset = "0x1B98768", VA = "0x7BBC398768")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DBD0", Offset = "0x113DBD0")]
				private set
				{
				}
			}

			// Token: 0x060047CA RID: 18378 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047CA")]
			[Address(RVA = "0x1B9752C", Offset = "0x1B9752C", VA = "0x7BBC39752C")]
			public static void Init()
			{
			}

			// Token: 0x060047CB RID: 18379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047CB")]
			[Address(RVA = "0x1B9678C", Offset = "0x1B9678C", VA = "0x7BBC39678C")]
			internal static void Shutdown()
			{
			}

			// Token: 0x060047CC RID: 18380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047CC")]
			[Address(RVA = "0x1B987C0", Offset = "0x1B987C0", VA = "0x7BBC3987C0")]
			public static void OnTokenReceived(object sender, TokenReceivedEventArgs token)
			{
			}

			// Token: 0x060047CD RID: 18381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047CD")]
			[Address(RVA = "0x1B988C0", Offset = "0x1B988C0", VA = "0x7BBC3988C0")]
			public static void OnMessageReceived(object sender, MessageReceivedEventArgs e)
			{
			}

			// Token: 0x060047CE RID: 18382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047CE")]
			[Address(RVA = "0x1B9896C", Offset = "0x1B9896C", VA = "0x7BBC39896C")]
			public static void SubscribeTopic(string topic, Action<string, bool, string> callback)
			{
			}

			// Token: 0x060047CF RID: 18383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047CF")]
			[Address(RVA = "0x1B98AD8", Offset = "0x1B98AD8", VA = "0x7BBC398AD8")]
			public static void UnsubscribeTopic(string topic, Action<string, bool, string> callback)
			{
			}

			// Token: 0x04007132 RID: 28978
			[Token(Token = "0x4007132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F69C", Offset = "0x112F69C")]
			private static bool <MessagingInited>k__BackingField;

			// Token: 0x02001246 RID: 4678
			[Token(Token = "0x2001246")]
			public class FirebaseMessagingDelegate : OpenedWithParamsDelegate
			{
				// Token: 0x060047D0 RID: 18384 RVA: 0x000156D8 File Offset: 0x000138D8
				[Token(Token = "0x60047D0")]
				[Address(RVA = "0x1B9957C", Offset = "0x1B9957C", VA = "0x7BBC39957C", Slot = "5")]
				public override bool CanProcess(Dictionary<string, string> parameters)
				{
					return default(bool);
				}

				// Token: 0x060047D1 RID: 18385 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60047D1")]
				[Address(RVA = "0x1B995F0", Offset = "0x1B995F0", VA = "0x7BBC3995F0", Slot = "6")]
				public override OpenedWithParamsDelegate.OpenedWithParams Process(Dictionary<string, string> parameters)
				{
					return null;
				}

				// Token: 0x060047D2 RID: 18386 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60047D2")]
				[Address(RVA = "0x1B997C4", Offset = "0x1B997C4", VA = "0x7BBC3997C4")]
				public FirebaseMessagingDelegate()
				{
				}

				// Token: 0x04007133 RID: 28979
				[Token(Token = "0x4007133")]
				public const string MSG_ID_KEY = "google.message_id";

				// Token: 0x04007134 RID: 28980
				[Token(Token = "0x4007134")]
				public const string DEEP_LINK_URL_KEY = "freefire.deeplink.url";

				// Token: 0x04007135 RID: 28981
				[Token(Token = "0x4007135")]
				public const string WEB_VIEW_URL_KEY = "freefire.webview.url";

				// Token: 0x04007136 RID: 28982
				[Token(Token = "0x4007136")]
				public const string WEB_VIEW_STYLE_KEY = "freefire.webview.style";

				// Token: 0x04007137 RID: 28983
				[Token(Token = "0x4007137")]
				public const string BROWSER_URL_KEY = "freefire.browser.url";
			}

			// Token: 0x02001247 RID: 4679
			[Token(Token = "0x2001247")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAFB0", Offset = "0x10EAFB0")]
			private sealed class <>c__DisplayClass10_0
			{
				// Token: 0x060047D3 RID: 18387 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60047D3")]
				[Address(RVA = "0x1B98AD0", Offset = "0x1B98AD0", VA = "0x7BBC398AD0")]
				public <>c__DisplayClass10_0()
				{
				}

				// Token: 0x060047D4 RID: 18388 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60047D4")]
				[Address(RVA = "0x1B98C44", Offset = "0x1B98C44", VA = "0x7BBC398C44")]
				internal void <SubscribeTopic>b__0(System.Threading.Tasks.Task task)
				{
				}

				// Token: 0x04007138 RID: 28984
				[Token(Token = "0x4007138")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string topic;

				// Token: 0x04007139 RID: 28985
				[Token(Token = "0x4007139")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Action<string, bool, string> callback;
			}

			// Token: 0x02001248 RID: 4680
			[Token(Token = "0x2001248")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAFC0", Offset = "0x10EAFC0")]
			private sealed class <>c__DisplayClass10_1
			{
				// Token: 0x060047D5 RID: 18389 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60047D5")]
				[Address(RVA = "0x1B99030", Offset = "0x1B99030", VA = "0x7BBC399030")]
				public <>c__DisplayClass10_1()
				{
				}

				// Token: 0x060047D6 RID: 18390 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60047D6")]
				[Address(RVA = "0x1B99038", Offset = "0x1B99038", VA = "0x7BBC399038")]
				internal void <SubscribeTopic>b__1()
				{
				}

				// Token: 0x0400713A RID: 28986
				[Token(Token = "0x400713A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool isOK;

				// Token: 0x0400713B RID: 28987
				[Token(Token = "0x400713B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string errorMessage;

				// Token: 0x0400713C RID: 28988
				[Token(Token = "0x400713C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public FirebaseManager.Messaging.<>c__DisplayClass10_0 CS$<>8__locals1;
			}

			// Token: 0x02001249 RID: 4681
			[Token(Token = "0x2001249")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAFD0", Offset = "0x10EAFD0")]
			private sealed class <>c__DisplayClass11_0
			{
				// Token: 0x060047D7 RID: 18391 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60047D7")]
				[Address(RVA = "0x1B98C3C", Offset = "0x1B98C3C", VA = "0x7BBC398C3C")]
				public <>c__DisplayClass11_0()
				{
				}

				// Token: 0x060047D8 RID: 18392 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60047D8")]
				[Address(RVA = "0x1B990E0", Offset = "0x1B990E0", VA = "0x7BBC3990E0")]
				internal void <UnsubscribeTopic>b__0(System.Threading.Tasks.Task task)
				{
				}

				// Token: 0x0400713D RID: 28989
				[Token(Token = "0x400713D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string topic;

				// Token: 0x0400713E RID: 28990
				[Token(Token = "0x400713E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Action<string, bool, string> callback;
			}

			// Token: 0x0200124A RID: 4682
			[Token(Token = "0x200124A")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAFE0", Offset = "0x10EAFE0")]
			private sealed class <>c__DisplayClass11_1
			{
				// Token: 0x060047D9 RID: 18393 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60047D9")]
				[Address(RVA = "0x1B994CC", Offset = "0x1B994CC", VA = "0x7BBC3994CC")]
				public <>c__DisplayClass11_1()
				{
				}

				// Token: 0x060047DA RID: 18394 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60047DA")]
				[Address(RVA = "0x1B994D4", Offset = "0x1B994D4", VA = "0x7BBC3994D4")]
				internal void <UnsubscribeTopic>b__1()
				{
				}

				// Token: 0x0400713F RID: 28991
				[Token(Token = "0x400713F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool isOK;

				// Token: 0x04007140 RID: 28992
				[Token(Token = "0x4007140")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string errorMessage;

				// Token: 0x04007141 RID: 28993
				[Token(Token = "0x4007141")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public FirebaseManager.Messaging.<>c__DisplayClass11_0 CS$<>8__locals1;
			}
		}

		// Token: 0x0200124B RID: 4683
		[Token(Token = "0x200124B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAFF0", Offset = "0x10EAFF0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060047DC RID: 18396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047DC")]
			[Address(RVA = "0x1B96D40", Offset = "0x1B96D40", VA = "0x7BBC396D40")]
			public <>c()
			{
			}

			// Token: 0x060047DD RID: 18397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047DD")]
			[Address(RVA = "0x1B96D48", Offset = "0x1B96D48", VA = "0x7BBC396D48")]
			internal void <Init>b__22_0(System.Threading.Tasks.Task<DependencyStatus> task)
			{
			}

			// Token: 0x060047DE RID: 18398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047DE")]
			[Address(RVA = "0x1B9705C", Offset = "0x1B9705C", VA = "0x7BBC39705C")]
			internal void <Init>b__22_2()
			{
			}

			// Token: 0x060047DF RID: 18399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60047DF")]
			[Address(RVA = "0x1B97798", Offset = "0x1B97798", VA = "0x7BBC397798")]
			internal void <Init>b__22_1()
			{
			}

			// Token: 0x04007142 RID: 28994
			[Token(Token = "0x4007142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly FirebaseManager.<>c <>9;

			// Token: 0x04007143 RID: 28995
			[Token(Token = "0x4007143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action <>9__22_2;

			// Token: 0x04007144 RID: 28996
			[Token(Token = "0x4007144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action <>9__22_1;

			// Token: 0x04007145 RID: 28997
			[Token(Token = "0x4007145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Action<System.Threading.Tasks.Task<DependencyStatus>> <>9__22_0;
		}
	}
}
