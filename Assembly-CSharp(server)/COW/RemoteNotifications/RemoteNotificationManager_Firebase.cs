using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW.RemoteNotifications
{
	// Token: 0x02002693 RID: 9875
	[Token(Token = "0x2002693")]
	public class RemoteNotificationManager_Firebase : RemoteNotificationManager
	{
		// Token: 0x0600CC78 RID: 52344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC78")]
		[Address(RVA = "0x1755530", Offset = "0x1755530", VA = "0x7BBBF55530")]
		private void LogVerbose(string log)
		{
		}

		// Token: 0x0600CC79 RID: 52345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC79")]
		[Address(RVA = "0x1754784", Offset = "0x1754784", VA = "0x7BBBF54784")]
		internal RemoteNotificationManager_Firebase()
		{
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x0600CC7A RID: 52346 RVA: 0x00036DC8 File Offset: 0x00034FC8
		[Token(Token = "0x17000DB0")]
		private static bool DisableCacheForFirebaseAnalytics
		{
			[Token(Token = "0x600CC7A")]
			[Address(RVA = "0x17555D8", Offset = "0x17555D8", VA = "0x7BBBF555D8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x0600CC7B RID: 52347 RVA: 0x00036DE0 File Offset: 0x00034FE0
		[Token(Token = "0x17000DB1")]
		private static bool DisableCacheForFirebaseMessaging
		{
			[Token(Token = "0x600CC7B")]
			[Address(RVA = "0x17559A4", Offset = "0x17559A4", VA = "0x7BBBF559A4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x0600CC7C RID: 52348 RVA: 0x00036DF8 File Offset: 0x00034FF8
		[Token(Token = "0x17000DB2")]
		private static bool UseAnalyticsUserProperties
		{
			[Token(Token = "0x600CC7C")]
			[Address(RVA = "0x1755A48", Offset = "0x1755A48", VA = "0x7BBBF55A48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x0600CC7D RID: 52349 RVA: 0x00036E10 File Offset: 0x00035010
		[Token(Token = "0x17000DB3")]
		private static bool UseMessagingTopics
		{
			[Token(Token = "0x600CC7D")]
			[Address(RVA = "0x1755B04", Offset = "0x1755B04", VA = "0x7BBBF55B04")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600CC7E RID: 52350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CC7E")]
		[Address(RVA = "0x1755BC0", Offset = "0x1755BC0", VA = "0x7BBBF55BC0")]
		private string FormatFirebaseUserPropertyName(string key)
		{
			return null;
		}

		// Token: 0x0600CC7F RID: 52351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CC7F")]
		[Address(RVA = "0x1755C30", Offset = "0x1755C30", VA = "0x7BBBF55C30")]
		private string FormatUserPropertyPlayerPrefsKey(string key)
		{
			return null;
		}

		// Token: 0x0600CC80 RID: 52352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC80")]
		[Address(RVA = "0x1755CA0", Offset = "0x1755CA0", VA = "0x7BBBF55CA0")]
		private void LogUserInfo(string method)
		{
		}

		// Token: 0x0600CC81 RID: 52353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC81")]
		[Address(RVA = "0x1756290", Offset = "0x1756290", VA = "0x7BBBF56290")]
		private void UpdateUserInfo(bool force = false)
		{
		}

		// Token: 0x0600CC82 RID: 52354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC82")]
		[Address(RVA = "0x175656C", Offset = "0x175656C", VA = "0x7BBBF5656C")]
		private void _UpdateUserId(string userId)
		{
		}

		// Token: 0x0600CC83 RID: 52355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC83")]
		[Address(RVA = "0x17563F0", Offset = "0x17563F0", VA = "0x7BBBF563F0")]
		private void UpdateUserId(bool force = false)
		{
		}

		// Token: 0x0600CC84 RID: 52356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC84")]
		[Address(RVA = "0x1756760", Offset = "0x1756760", VA = "0x7BBBF56760")]
		private void ClearUserId()
		{
		}

		// Token: 0x0600CC85 RID: 52357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC85")]
		[Address(RVA = "0x17567C8", Offset = "0x17567C8", VA = "0x7BBBF567C8")]
		private void _UpdateUserProperty(RemoteNotificationManager_Firebase.UserProperty userProperty, string value)
		{
		}

		// Token: 0x0600CC86 RID: 52358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC86")]
		[Address(RVA = "0x175567C", Offset = "0x175567C", VA = "0x7BBBF5567C")]
		private void UpdateUserProperty(RemoteNotificationManager_Firebase.UserProperty userProperty, bool force = false)
		{
		}

		// Token: 0x0600CC87 RID: 52359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC87")]
		[Address(RVA = "0x1756D8C", Offset = "0x1756D8C", VA = "0x7BBBF56D8C")]
		private void ClearUserProperty(RemoteNotificationManager_Firebase.UserProperty userProperty)
		{
		}

		// Token: 0x0600CC88 RID: 52360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC88")]
		[Address(RVA = "0x1756E5C", Offset = "0x1756E5C", VA = "0x7BBBF56E5C", Slot = "5")]
		public override void AfterLoginSDK()
		{
		}

		// Token: 0x0600CC89 RID: 52361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC89")]
		[Address(RVA = "0x1756EB8", Offset = "0x1756EB8", VA = "0x7BBBF56EB8", Slot = "6")]
		public override void BeforeLoginServer()
		{
		}

		// Token: 0x0600CC8A RID: 52362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC8A")]
		[Address(RVA = "0x1756EBC", Offset = "0x1756EBC", VA = "0x7BBBF56EBC", Slot = "7")]
		public override void AfterLoginServer()
		{
		}

		// Token: 0x0600CC8B RID: 52363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC8B")]
		[Address(RVA = "0x1757110", Offset = "0x1757110", VA = "0x7BBBF57110", Slot = "9")]
		public override void AfterLogoutServer()
		{
		}

		// Token: 0x0600CC8C RID: 52364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC8C")]
		[Address(RVA = "0x175716C", Offset = "0x175716C", VA = "0x7BBBF5716C", Slot = "11")]
		public override void AfterLogoutSDK()
		{
		}

		// Token: 0x0600CC8D RID: 52365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC8D")]
		[Address(RVA = "0x17571C4", Offset = "0x17571C4", VA = "0x7BBBF571C4", Slot = "13")]
		public override void AfterChangeLanguage()
		{
		}

		// Token: 0x0600CC8E RID: 52366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC8E")]
		[Address(RVA = "0x1757224", Offset = "0x1757224", VA = "0x7BBBF57224", Slot = "17")]
		public override void AfterChangeClanID()
		{
		}

		// Token: 0x0600CC8F RID: 52367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC8F")]
		[Address(RVA = "0x1757284", Offset = "0x1757284", VA = "0x7BBBF57284", Slot = "19")]
		public override void AfterChangeElitePassBadgeNumber()
		{
		}

		// Token: 0x0600CC90 RID: 52368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC90")]
		[Address(RVA = "0x17572E4", Offset = "0x17572E4", VA = "0x7BBBF572E4", Slot = "15")]
		public override void AfterChangeFirstTimePaid()
		{
		}

		// Token: 0x0600CC91 RID: 52369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC91")]
		[Address(RVA = "0x1757344", Offset = "0x1757344", VA = "0x7BBBF57344", Slot = "21")]
		public override void AfterChangePlayerLevel()
		{
		}

		// Token: 0x0600CC92 RID: 52370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC92")]
		[Address(RVA = "0x17573A4", Offset = "0x17573A4", VA = "0x7BBBF573A4", Slot = "22")]
		public override void BeforeChangeGamesPlayedInRankedMatch()
		{
		}

		// Token: 0x0600CC93 RID: 52371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC93")]
		[Address(RVA = "0x17573A8", Offset = "0x17573A8", VA = "0x7BBBF573A8", Slot = "23")]
		public override void AfterChangeGamesPlayedInRankedMatch()
		{
		}

		// Token: 0x0600CC94 RID: 52372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CC94")]
		[Address(RVA = "0x17561C4", Offset = "0x17561C4", VA = "0x7BBBF561C4")]
		private string FormatTopicPlayerPrefsKey(RemoteNotificationManager_Firebase.UserPropertyTopic topic)
		{
			return null;
		}

		// Token: 0x0600CC95 RID: 52373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CC95")]
		[Address(RVA = "0x1757408", Offset = "0x1757408", VA = "0x7BBBF57408")]
		private string UserPropertyTopicValue(RemoteNotificationManager_Firebase.UserPropertyTopic topic)
		{
			return null;
		}

		// Token: 0x0600CC96 RID: 52374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC96")]
		[Address(RVA = "0x1756F78", Offset = "0x1756F78", VA = "0x7BBBF56F78")]
		private void UpdateUserPropertyTopic(RemoteNotificationManager_Firebase.UserPropertyTopic topic)
		{
		}

		// Token: 0x0600CC97 RID: 52375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC97")]
		[Address(RVA = "0x1757A14", Offset = "0x1757A14", VA = "0x7BBBF57A14")]
		private void _SubscribeTopic(string playerPrefsKey, string topic)
		{
		}

		// Token: 0x0600CC98 RID: 52376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC98")]
		[Address(RVA = "0x1757E9C", Offset = "0x1757E9C", VA = "0x7BBBF57E9C")]
		private void _OnSubscribedTopic(string topic, bool isOK, string error)
		{
		}

		// Token: 0x0600CC99 RID: 52377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC99")]
		[Address(RVA = "0x175759C", Offset = "0x175759C", VA = "0x7BBBF5759C")]
		private void _UnsubscribeTopic(string playerPrefsKey, string topic)
		{
		}

		// Token: 0x0600CC9A RID: 52378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC9A")]
		[Address(RVA = "0x17583F8", Offset = "0x17583F8", VA = "0x7BBBF583F8")]
		private void _OnUnsubscribedTopic(string topic, bool isOK, string error)
		{
		}

		// Token: 0x0600CC9B RID: 52379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC9B")]
		[Address(RVA = "0x1758068", Offset = "0x1758068", VA = "0x7BBBF58068")]
		private void _ProcessTopicTaskQueue()
		{
		}

		// Token: 0x0600CC9D RID: 52381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC9D")]
		[Address(RVA = "0x1758688", Offset = "0x1758688", VA = "0x7BBBF58688")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1148C38", Offset = "0x1148C38")]
		private void <.ctor>b__1_0()
		{
		}

		// Token: 0x0600CC9E RID: 52382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CC9E")]
		[Address(RVA = "0x1758A38", Offset = "0x1758A38", VA = "0x7BBBF58A38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1148C48", Offset = "0x1148C48")]
		private string <UserPropertyTopicValue>b__45_0(RemoteNotificationManager_Firebase.UserProperty p)
		{
			return null;
		}

		// Token: 0x0401004D RID: 65613
		[Token(Token = "0x401004D")]
		private const string PLAYER_PREFS_KEY_USER_PROPERTIES_TEMPLATE = "RNM_FIREBASE_USER_PROPERTIES_{0}";

		// Token: 0x0401004E RID: 65614
		[Token(Token = "0x401004E")]
		private const string PLAYER_PREFS_KEY_USER_ID = "RNM_FIREBASE_USER_ID";

		// Token: 0x0401004F RID: 65615
		[Token(Token = "0x401004F")]
		private const string FIREBASE_USER_PROPERTY_NAME_TEMPLATE = "ff_{0}";

		// Token: 0x04010050 RID: 65616
		[Token(Token = "0x4010050")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<RemoteNotificationManager_Firebase.UserProperty, RemoteNotificationManager_Firebase.UserPropertyInfo> USER_PROPERTIES;

		// Token: 0x04010051 RID: 65617
		[Token(Token = "0x4010051")]
		[FieldOffset(Offset = "0x18")]
		private string _PendingUserId;

		// Token: 0x04010052 RID: 65618
		[Token(Token = "0x4010052")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<RemoteNotificationManager_Firebase.UserProperty, string> _PendingUserProperties;

		// Token: 0x04010053 RID: 65619
		[Token(Token = "0x4010053")]
		private const string PLAYER_PREFS_KEY_USER_PROPERTY_TOPIC_TEMPLATE = "RNM_FIREBASE_USER_PROPERTY_TOPIC_{0}";

		// Token: 0x04010054 RID: 65620
		[Token(Token = "0x4010054")]
		private const string FIREBASE_USER_PROPERTY_TOPIC_TEMPLATE = "ff_{0}";

		// Token: 0x04010055 RID: 65621
		[Token(Token = "0x4010055")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<RemoteNotificationManager_Firebase.UserPropertyTopic, RemoteNotificationManager_Firebase.UserProperty[]> USER_PROPERTY_TOPICS;

		// Token: 0x04010056 RID: 65622
		[Token(Token = "0x4010056")]
		[FieldOffset(Offset = "0x28")]
		private RemoteNotificationManager_Firebase.TopicTask _PendingTopicTask;

		// Token: 0x04010057 RID: 65623
		[Token(Token = "0x4010057")]
		[FieldOffset(Offset = "0x30")]
		private Queue<RemoteNotificationManager_Firebase.TopicTask> _TopicTasks;

		// Token: 0x02002694 RID: 9876
		[Token(Token = "0x2002694")]
		private enum UserProperty
		{
			// Token: 0x04010059 RID: 65625
			[Token(Token = "0x4010059")]
			Environment,
			// Token: 0x0401005A RID: 65626
			[Token(Token = "0x401005A")]
			Region,
			// Token: 0x0401005B RID: 65627
			[Token(Token = "0x401005B")]
			Language,
			// Token: 0x0401005C RID: 65628
			[Token(Token = "0x401005C")]
			LastActiveServerTime,
			// Token: 0x0401005D RID: 65629
			[Token(Token = "0x401005D")]
			PlayerLevel,
			// Token: 0x0401005E RID: 65630
			[Token(Token = "0x401005E")]
			IsPaid,
			// Token: 0x0401005F RID: 65631
			[Token(Token = "0x401005F")]
			ElitePassBadgeNumber,
			// Token: 0x04010060 RID: 65632
			[Token(Token = "0x4010060")]
			ClanID,
			// Token: 0x04010061 RID: 65633
			[Token(Token = "0x4010061")]
			TimeZoneOffsetHours,
			// Token: 0x04010062 RID: 65634
			[Token(Token = "0x4010062")]
			TimeZoneStandardName,
			// Token: 0x04010063 RID: 65635
			[Token(Token = "0x4010063")]
			GamesPlayed_RankedMatch,
			// Token: 0x04010064 RID: 65636
			[Token(Token = "0x4010064")]
			Variant
		}

		// Token: 0x02002695 RID: 9877
		[Token(Token = "0x2002695")]
		private class UserPropertyInfo
		{
			// Token: 0x0600CC9F RID: 52383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CC9F")]
			[Address(RVA = "0x17555D0", Offset = "0x17555D0", VA = "0x7BBBF555D0")]
			public UserPropertyInfo()
			{
			}

			// Token: 0x04010065 RID: 65637
			[Token(Token = "0x4010065")]
			[FieldOffset(Offset = "0x10")]
			public string Key;

			// Token: 0x04010066 RID: 65638
			[Token(Token = "0x4010066")]
			[FieldOffset(Offset = "0x18")]
			public Func<string> Value;
		}

		// Token: 0x02002696 RID: 9878
		[Token(Token = "0x2002696")]
		private enum UserPropertyTopic
		{
			// Token: 0x04010068 RID: 65640
			[Token(Token = "0x4010068")]
			Basic
		}

		// Token: 0x02002697 RID: 9879
		[Token(Token = "0x2002697")]
		private class TopicTask
		{
			// Token: 0x0600CCA0 RID: 52384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CCA0")]
			[Address(RVA = "0x1757E94", Offset = "0x1757E94", VA = "0x7BBBF57E94")]
			public TopicTask()
			{
			}

			// Token: 0x04010069 RID: 65641
			[Token(Token = "0x4010069")]
			[FieldOffset(Offset = "0x10")]
			public bool IsSubscribe;

			// Token: 0x0401006A RID: 65642
			[Token(Token = "0x401006A")]
			[FieldOffset(Offset = "0x18")]
			public string Topic;

			// Token: 0x0401006B RID: 65643
			[Token(Token = "0x401006B")]
			[FieldOffset(Offset = "0x20")]
			public string PlayerPrefKey;
		}

		// Token: 0x02002698 RID: 9880
		[Token(Token = "0x2002698")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FE8C8", Offset = "0x10FE8C8")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600CCA2 RID: 52386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CCA2")]
			[Address(RVA = "0x1758B3C", Offset = "0x1758B3C", VA = "0x7BBBF58B3C")]
			public <>c()
			{
			}

			// Token: 0x0600CCA3 RID: 52387 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CCA3")]
			[Address(RVA = "0x1758B44", Offset = "0x1758B44", VA = "0x7BBBF58B44")]
			internal string <.ctor>b__1_1()
			{
				return null;
			}

			// Token: 0x0600CCA4 RID: 52388 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CCA4")]
			[Address(RVA = "0x1758BF8", Offset = "0x1758BF8", VA = "0x7BBBF58BF8")]
			internal string <.ctor>b__1_2()
			{
				return null;
			}

			// Token: 0x0600CCA5 RID: 52389 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CCA5")]
			[Address(RVA = "0x1758C60", Offset = "0x1758C60", VA = "0x7BBBF58C60")]
			internal string <.ctor>b__1_3()
			{
				return null;
			}

			// Token: 0x0600CCA6 RID: 52390 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CCA6")]
			[Address(RVA = "0x1758CF4", Offset = "0x1758CF4", VA = "0x7BBBF58CF4")]
			internal string <.ctor>b__1_4()
			{
				return null;
			}

			// Token: 0x0600CCA7 RID: 52391 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CCA7")]
			[Address(RVA = "0x1758D6C", Offset = "0x1758D6C", VA = "0x7BBBF58D6C")]
			internal string <.ctor>b__1_5()
			{
				return null;
			}

			// Token: 0x0600CCA8 RID: 52392 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CCA8")]
			[Address(RVA = "0x1758E24", Offset = "0x1758E24", VA = "0x7BBBF58E24")]
			internal string <.ctor>b__1_6()
			{
				return null;
			}

			// Token: 0x0600CCA9 RID: 52393 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CCA9")]
			[Address(RVA = "0x1758EFC", Offset = "0x1758EFC", VA = "0x7BBBF58EFC")]
			internal string <.ctor>b__1_7()
			{
				return null;
			}

			// Token: 0x0600CCAA RID: 52394 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CCAA")]
			[Address(RVA = "0x1758FB4", Offset = "0x1758FB4", VA = "0x7BBBF58FB4")]
			internal string <.ctor>b__1_8()
			{
				return null;
			}

			// Token: 0x0600CCAB RID: 52395 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CCAB")]
			[Address(RVA = "0x175906C", Offset = "0x175906C", VA = "0x7BBBF5906C")]
			internal string <.ctor>b__1_9()
			{
				return null;
			}

			// Token: 0x0600CCAC RID: 52396 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CCAC")]
			[Address(RVA = "0x1759154", Offset = "0x1759154", VA = "0x7BBBF59154")]
			internal string <.ctor>b__1_10()
			{
				return null;
			}

			// Token: 0x0600CCAD RID: 52397 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CCAD")]
			[Address(RVA = "0x17591D0", Offset = "0x17591D0", VA = "0x7BBBF591D0")]
			internal string <.ctor>b__1_11()
			{
				return null;
			}

			// Token: 0x0600CCAE RID: 52398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CCAE")]
			[Address(RVA = "0x175929C", Offset = "0x175929C", VA = "0x7BBBF5929C")]
			internal string <.ctor>b__1_12()
			{
				return null;
			}

			// Token: 0x0401006C RID: 65644
			[Token(Token = "0x401006C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly RemoteNotificationManager_Firebase.<>c <>9;

			// Token: 0x0401006D RID: 65645
			[Token(Token = "0x401006D")]
			[FieldOffset(Offset = "0x8")]
			public static Func<string> <>9__1_1;

			// Token: 0x0401006E RID: 65646
			[Token(Token = "0x401006E")]
			[FieldOffset(Offset = "0x10")]
			public static Func<string> <>9__1_2;

			// Token: 0x0401006F RID: 65647
			[Token(Token = "0x401006F")]
			[FieldOffset(Offset = "0x18")]
			public static Func<string> <>9__1_3;

			// Token: 0x04010070 RID: 65648
			[Token(Token = "0x4010070")]
			[FieldOffset(Offset = "0x20")]
			public static Func<string> <>9__1_4;

			// Token: 0x04010071 RID: 65649
			[Token(Token = "0x4010071")]
			[FieldOffset(Offset = "0x28")]
			public static Func<string> <>9__1_5;

			// Token: 0x04010072 RID: 65650
			[Token(Token = "0x4010072")]
			[FieldOffset(Offset = "0x30")]
			public static Func<string> <>9__1_6;

			// Token: 0x04010073 RID: 65651
			[Token(Token = "0x4010073")]
			[FieldOffset(Offset = "0x38")]
			public static Func<string> <>9__1_7;

			// Token: 0x04010074 RID: 65652
			[Token(Token = "0x4010074")]
			[FieldOffset(Offset = "0x40")]
			public static Func<string> <>9__1_8;

			// Token: 0x04010075 RID: 65653
			[Token(Token = "0x4010075")]
			[FieldOffset(Offset = "0x48")]
			public static Func<string> <>9__1_9;

			// Token: 0x04010076 RID: 65654
			[Token(Token = "0x4010076")]
			[FieldOffset(Offset = "0x50")]
			public static Func<string> <>9__1_10;

			// Token: 0x04010077 RID: 65655
			[Token(Token = "0x4010077")]
			[FieldOffset(Offset = "0x58")]
			public static Func<string> <>9__1_11;

			// Token: 0x04010078 RID: 65656
			[Token(Token = "0x4010078")]
			[FieldOffset(Offset = "0x60")]
			public static Func<string> <>9__1_12;
		}
	}
}
