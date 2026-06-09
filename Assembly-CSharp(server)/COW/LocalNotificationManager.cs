using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020012CD RID: 4813
	[Token(Token = "0x20012CD")]
	public static class LocalNotificationManager
	{
		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06004BB8 RID: 19384 RVA: 0x00016B30 File Offset: 0x00014D30
		[Token(Token = "0x17000853")]
		public static long CurrentUTCTimeStampMS
		{
			[Token(Token = "0x6004BB8")]
			[Address(RVA = "0x1A4E758", Offset = "0x1A4E758", VA = "0x7BBC24E758")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06004BB9 RID: 19385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB9")]
		[Address(RVA = "0x1A4E8A8", Offset = "0x1A4E8A8", VA = "0x7BBC24E8A8")]
		public static void Init()
		{
		}

		// Token: 0x06004BBA RID: 19386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBA")]
		[Address(RVA = "0x1A4EB00", Offset = "0x1A4EB00", VA = "0x7BBC24EB00")]
		private static void LogVerbose(string log)
		{
		}

		// Token: 0x06004BBB RID: 19387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBB")]
		[Address(RVA = "0x1A4EB9C", Offset = "0x1A4EB9C", VA = "0x7BBC24EB9C")]
		private static void Log(string log)
		{
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBC")]
		[Address(RVA = "0x1A4EC04", Offset = "0x1A4EC04", VA = "0x7BBC24EC04")]
		private static void LogError(string log)
		{
		}

		// Token: 0x06004BBD RID: 19389 RVA: 0x00016B48 File Offset: 0x00014D48
		[Token(Token = "0x6004BBD")]
		[Address(RVA = "0x1A4EC6C", Offset = "0x1A4EC6C", VA = "0x7BBC24EC6C")]
		public static TimeSpan UTC_To_Local()
		{
			return default(TimeSpan);
		}

		// Token: 0x06004BBE RID: 19390 RVA: 0x00016B60 File Offset: 0x00014D60
		[Token(Token = "0x6004BBE")]
		[Address(RVA = "0x1A4E7E8", Offset = "0x1A4E7E8", VA = "0x7BBC24E7E8")]
		private static long TimeStampMS(DateTime dateTime)
		{
			return 0L;
		}

		// Token: 0x06004BBF RID: 19391 RVA: 0x00016B78 File Offset: 0x00014D78
		[Token(Token = "0x6004BBF")]
		[Address(RVA = "0x1A4ECE8", Offset = "0x1A4ECE8", VA = "0x7BBC24ECE8")]
		public static long NextTimeStampMS_Local(long notifyTimeOfDay_Local_MS)
		{
			return 0L;
		}

		// Token: 0x06004BC0 RID: 19392 RVA: 0x00016B90 File Offset: 0x00014D90
		[Token(Token = "0x6004BC0")]
		[Address(RVA = "0x1A4EDD4", Offset = "0x1A4EDD4", VA = "0x7BBC24EDD4")]
		public static long NextTimeStampMS_UTC(long notifyTimeOfDay_UTC_MS)
		{
			return 0L;
		}

		// Token: 0x06004BC1 RID: 19393 RVA: 0x00016BA8 File Offset: 0x00014DA8
		[Token(Token = "0x6004BC1")]
		[Address(RVA = "0x1A4EFC0", Offset = "0x1A4EFC0", VA = "0x7BBC24EFC0")]
		public static int GetNotifyID(LocalNotificationManager.NotifyType notifyType)
		{
			return 0;
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC2")]
		[Address(RVA = "0x1A4EFC8", Offset = "0x1A4EFC8", VA = "0x7BBC24EFC8")]
		public static string GetPrefKey(LocalNotificationManager.NotifyType notifyType)
		{
			return null;
		}

		// Token: 0x06004BC3 RID: 19395 RVA: 0x00016BC0 File Offset: 0x00014DC0
		[Token(Token = "0x6004BC3")]
		[Address(RVA = "0x1A4F078", Offset = "0x1A4F078", VA = "0x7BBC24F078")]
		public static bool IsSupported()
		{
			return default(bool);
		}

		// Token: 0x06004BC4 RID: 19396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC4")]
		[Address(RVA = "0x1A4F080", Offset = "0x1A4F080", VA = "0x7BBC24F080")]
		public static LocalNotificationManager.NotifyConfiguration GetNotifyConfiguration(LocalNotificationManager.NotifyType type)
		{
			return null;
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC5")]
		[Address(RVA = "0x1A4F16C", Offset = "0x1A4F16C", VA = "0x7BBC24F16C")]
		public static void SetNotifyConfiguration(LocalNotificationManager.NotifyType type, LocalNotificationManager.NotifyConfiguration configuration)
		{
		}

		// Token: 0x06004BC6 RID: 19398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC6")]
		[Address(RVA = "0x1A4F208", Offset = "0x1A4F208", VA = "0x7BBC24F208")]
		public static LocalNotificationManager.NotifyInfo GetNotifyInfo(LocalNotificationManager.NotifyType type)
		{
			return null;
		}

		// Token: 0x06004BC7 RID: 19399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC7")]
		[Address(RVA = "0x1A4F2F4", Offset = "0x1A4F2F4", VA = "0x7BBC24F2F4")]
		public static void SetNotifyInfo(LocalNotificationManager.NotifyType type, LocalNotificationManager.NotifyInfo info)
		{
		}

		// Token: 0x06004BC8 RID: 19400 RVA: 0x00016BD8 File Offset: 0x00014DD8
		[Token(Token = "0x6004BC8")]
		[Address(RVA = "0x1A4F390", Offset = "0x1A4F390", VA = "0x7BBC24F390")]
		public static bool IsScheduled(LocalNotificationManager.NotifyType notifyType)
		{
			return default(bool);
		}

		// Token: 0x06004BC9 RID: 19401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC9")]
		[Address(RVA = "0x1A4F458", Offset = "0x1A4F458", VA = "0x7BBC24F458")]
		private static LocalNotificationManager.NotifyData GetNotifyData(LocalNotificationManager.NotifyType notifyType)
		{
			return null;
		}

		// Token: 0x06004BCA RID: 19402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCA")]
		[Address(RVA = "0x1A4F7A8", Offset = "0x1A4F7A8", VA = "0x7BBC24F7A8")]
		private static void SetNotifyData(LocalNotificationManager.NotifyType notifyType, LocalNotificationManager.NotifyData notifyData)
		{
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCB")]
		[Address(RVA = "0x1A4F880", Offset = "0x1A4F880", VA = "0x7BBC24F880")]
		public static void ScheduleDailyWithLocalTimeOfDay(LocalNotificationManager.NotifyType notifyType, int hour, int minute, int second, int times, int firstDay = 0)
		{
		}

		// Token: 0x06004BCC RID: 19404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCC")]
		[Address(RVA = "0x1A4FBAC", Offset = "0x1A4FBAC", VA = "0x7BBC24FBAC")]
		public static void ScheduleDailyWithLocalTimeOfDay_MS(LocalNotificationManager.NotifyType notifyType, long timeOfDayMS, int times, int firstDay = 0)
		{
		}

		// Token: 0x06004BCD RID: 19405 RVA: 0x00016BF0 File Offset: 0x00014DF0
		[Token(Token = "0x6004BCD")]
		[Address(RVA = "0x1A4EDBC", Offset = "0x1A4EDBC", VA = "0x7BBC24EDBC")]
		public static long PositiveRemainder(long a, long b)
		{
			return 0L;
		}

		// Token: 0x06004BCE RID: 19406 RVA: 0x00016C08 File Offset: 0x00014E08
		[Token(Token = "0x6004BCE")]
		[Address(RVA = "0x1A50204", Offset = "0x1A50204", VA = "0x7BBC250204")]
		public static bool GetShouldNotify(LocalNotificationManager.NotifyType notifyType)
		{
			return default(bool);
		}

		// Token: 0x06004BCF RID: 19407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCF")]
		[Address(RVA = "0x1A5027C", Offset = "0x1A5027C", VA = "0x7BBC25027C")]
		public static void SetShouldNotify(LocalNotificationManager.NotifyType notifyType, bool shouldNotify)
		{
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD0")]
		[Address(RVA = "0x1A5030C", Offset = "0x1A5030C", VA = "0x7BBC25030C")]
		private static void _AddToPendingTasks(LocalNotificationManager._Task task)
		{
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD1")]
		[Address(RVA = "0x1A5053C", Offset = "0x1A5053C", VA = "0x7BBC25053C")]
		private static void _ProcessPendingTasks()
		{
		}

		// Token: 0x06004BD2 RID: 19410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD2")]
		[Address(RVA = "0x1A516E0", Offset = "0x1A516E0", VA = "0x7BBC2516E0")]
		private static void _AuthorizeAndExecute()
		{
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD3")]
		[Address(RVA = "0x1A4FDA0", Offset = "0x1A4FDA0", VA = "0x7BBC24FDA0")]
		public static void Schedule(LocalNotificationManager.NotifyType notifyType, long time_ms, int times, int interval_ms, bool isUTC = true, string overrideTitle = "", string overrideContent = "")
		{
		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD4")]
		[Address(RVA = "0x1A50C20", Offset = "0x1A50C20", VA = "0x7BBC250C20")]
		private static void _Schedule(LocalNotificationManager.NotifyType notifyType, long time_ms, int times, int interval_ms, string overrideTitle = "", string overrideContent = "")
		{
		}

		// Token: 0x06004BD5 RID: 19413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD5")]
		[Address(RVA = "0x1A52200", Offset = "0x1A52200", VA = "0x7BBC252200")]
		private static void _Scheduled()
		{
		}

		// Token: 0x06004BD6 RID: 19414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD6")]
		[Address(RVA = "0x1A51914", Offset = "0x1A51914", VA = "0x7BBC251914")]
		public static void Unschedule(LocalNotificationManager.NotifyType notifyType)
		{
		}

		// Token: 0x06004BD7 RID: 19415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD7")]
		[Address(RVA = "0x1A50A38", Offset = "0x1A50A38", VA = "0x7BBC250A38")]
		private static void _Unschedule(LocalNotificationManager.NotifyType notifyType)
		{
		}

		// Token: 0x06004BD8 RID: 19416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD8")]
		[Address(RVA = "0x1A52278", Offset = "0x1A52278", VA = "0x7BBC252278")]
		private static void _Unscheduled()
		{
		}

		// Token: 0x06004BD9 RID: 19417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD9")]
		[Address(RVA = "0x1A4E940", Offset = "0x1A4E940", VA = "0x7BBC24E940")]
		public static void UnscheduleAll()
		{
		}

		// Token: 0x06004BDA RID: 19418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BDA")]
		[Address(RVA = "0x1A509C8", Offset = "0x1A509C8", VA = "0x7BBC2509C8")]
		private static void _UnscheduleAll()
		{
		}

		// Token: 0x040073A4 RID: 29604
		[Token(Token = "0x40073A4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DateTime APOCH_UTC;

		// Token: 0x040073A5 RID: 29605
		[Token(Token = "0x40073A5")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int MSPerDay;

		// Token: 0x040073A6 RID: 29606
		[Token(Token = "0x40073A6")]
		private const bool DEFAULT_NOTIFY = true;

		// Token: 0x040073A7 RID: 29607
		[Token(Token = "0x40073A7")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<LocalNotificationManager.NotifyType, LocalNotificationManager.NotifyConfiguration> _NotifyConfigurations;

		// Token: 0x040073A8 RID: 29608
		[Token(Token = "0x40073A8")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Dictionary<LocalNotificationManager.NotifyType, LocalNotificationManager.NotifyInfo> _NotifyInfos;

		// Token: 0x040073A9 RID: 29609
		[Token(Token = "0x40073A9")]
		[FieldOffset(Offset = "0x20")]
		private static LocalNotificationManager.AuthroizationPhase _AuthorizationPhase;

		// Token: 0x040073AA RID: 29610
		[Token(Token = "0x40073AA")]
		[FieldOffset(Offset = "0x24")]
		private static PlatformUtility.LocalNotificationAuthorizationStatus _AuthorizationStatus;

		// Token: 0x040073AB RID: 29611
		[Token(Token = "0x40073AB")]
		[FieldOffset(Offset = "0x28")]
		private static Queue<LocalNotificationManager._Task> _PendingTasks;

		// Token: 0x040073AC RID: 29612
		[Token(Token = "0x40073AC")]
		[FieldOffset(Offset = "0x30")]
		private static LocalNotificationManager._Task _ExecutingTask;

		// Token: 0x020012CE RID: 4814
		[Token(Token = "0x20012CE")]
		public enum NotifyType
		{
			// Token: 0x040073AE RID: 29614
			[Token(Token = "0x40073AE")]
			RebateCardRedeeming = 1,
			// Token: 0x040073AF RID: 29615
			[Token(Token = "0x40073AF")]
			IAPBundleCountdown,
			// Token: 0x040073B0 RID: 29616
			[Token(Token = "0x40073B0")]
			FreeGachaCooldown_0 = 10,
			// Token: 0x040073B1 RID: 29617
			[Token(Token = "0x40073B1")]
			FreeGachaCooldown_1,
			// Token: 0x040073B2 RID: 29618
			[Token(Token = "0x40073B2")]
			FreeGachaCooldown_2,
			// Token: 0x040073B3 RID: 29619
			[Token(Token = "0x40073B3")]
			FreeGachaCooldown_Max,
			// Token: 0x040073B4 RID: 29620
			[Token(Token = "0x40073B4")]
			Retention_0 = 20,
			// Token: 0x040073B5 RID: 29621
			[Token(Token = "0x40073B5")]
			Retention_1,
			// Token: 0x040073B6 RID: 29622
			[Token(Token = "0x40073B6")]
			Retention_2,
			// Token: 0x040073B7 RID: 29623
			[Token(Token = "0x40073B7")]
			Retention_3,
			// Token: 0x040073B8 RID: 29624
			[Token(Token = "0x40073B8")]
			Retention_4,
			// Token: 0x040073B9 RID: 29625
			[Token(Token = "0x40073B9")]
			Retention_Max,
			// Token: 0x040073BA RID: 29626
			[Token(Token = "0x40073BA")]
			Veteran_Activate = 30,
			// Token: 0x040073BB RID: 29627
			[Token(Token = "0x40073BB")]
			Veteran_Reminder,
			// Token: 0x040073BC RID: 29628
			[Token(Token = "0x40073BC")]
			NewPlayerActivity,
			// Token: 0x040073BD RID: 29629
			[Token(Token = "0x40073BD")]
			BooyahDayActivity,
			// Token: 0x040073BE RID: 29630
			[Token(Token = "0x40073BE")]
			LiveTvEsport = 35,
			// Token: 0x040073BF RID: 29631
			[Token(Token = "0x40073BF")]
			ActivityStart_0 = 40,
			// Token: 0x040073C0 RID: 29632
			[Token(Token = "0x40073C0")]
			ActivityStart_1,
			// Token: 0x040073C1 RID: 29633
			[Token(Token = "0x40073C1")]
			ActivityStart_2,
			// Token: 0x040073C2 RID: 29634
			[Token(Token = "0x40073C2")]
			ActivityStart_3,
			// Token: 0x040073C3 RID: 29635
			[Token(Token = "0x40073C3")]
			ActivityStart_4,
			// Token: 0x040073C4 RID: 29636
			[Token(Token = "0x40073C4")]
			ActivityStart_5,
			// Token: 0x040073C5 RID: 29637
			[Token(Token = "0x40073C5")]
			ActivityStart_6,
			// Token: 0x040073C6 RID: 29638
			[Token(Token = "0x40073C6")]
			ActivityStart_7,
			// Token: 0x040073C7 RID: 29639
			[Token(Token = "0x40073C7")]
			ActivityStart_MAX
		}

		// Token: 0x020012CF RID: 4815
		[Token(Token = "0x20012CF")]
		public class NotifyInfo
		{
			// Token: 0x06004BDC RID: 19420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BDC")]
			[Address(RVA = "0x1A52FC4", Offset = "0x1A52FC4", VA = "0x7BBC252FC4")]
			public NotifyInfo()
			{
			}

			// Token: 0x040073C8 RID: 29640
			[Token(Token = "0x40073C8")]
			[FieldOffset(Offset = "0x10")]
			public int Id;

			// Token: 0x040073C9 RID: 29641
			[Token(Token = "0x40073C9")]
			[FieldOffset(Offset = "0x18")]
			public string ChannelId;

			// Token: 0x040073CA RID: 29642
			[Token(Token = "0x40073CA")]
			[FieldOffset(Offset = "0x20")]
			public string LocKey_ChannelName;

			// Token: 0x040073CB RID: 29643
			[Token(Token = "0x40073CB")]
			[FieldOffset(Offset = "0x28")]
			public string LocKey_ChannelDescription;

			// Token: 0x040073CC RID: 29644
			[Token(Token = "0x40073CC")]
			[FieldOffset(Offset = "0x30")]
			public Func<string> Title;

			// Token: 0x040073CD RID: 29645
			[Token(Token = "0x40073CD")]
			[FieldOffset(Offset = "0x38")]
			public Func<string> SubTitle;

			// Token: 0x040073CE RID: 29646
			[Token(Token = "0x40073CE")]
			[FieldOffset(Offset = "0x40")]
			public Func<string> Content;

			// Token: 0x040073CF RID: 29647
			[Token(Token = "0x40073CF")]
			[FieldOffset(Offset = "0x48")]
			public PlatformUtility.LocalNotificationImportance ChannelImportance;

			// Token: 0x040073D0 RID: 29648
			[Token(Token = "0x40073D0")]
			[FieldOffset(Offset = "0x50")]
			public Func<int> MaxRandomDelay_MS;

			// Token: 0x040073D1 RID: 29649
			[Token(Token = "0x40073D1")]
			[FieldOffset(Offset = "0x58")]
			public LocalNotificationManager.NotifyInfo.ReturnUrl Url;

			// Token: 0x020012D0 RID: 4816
			// (Invoke) Token: 0x06004BDE RID: 19422
			[Token(Token = "0x20012D0")]
			public delegate string ReturnUrl(params object[] parameters);
		}

		// Token: 0x020012D1 RID: 4817
		[Token(Token = "0x20012D1")]
		public class NotifyConfiguration
		{
			// Token: 0x06004BE1 RID: 19425 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BE1")]
			[Address(RVA = "0x1A52FB4", Offset = "0x1A52FB4", VA = "0x7BBC252FB4")]
			public NotifyConfiguration()
			{
			}

			// Token: 0x040073D2 RID: 29650
			[Token(Token = "0x40073D2")]
			[FieldOffset(Offset = "0x10")]
			public bool DefaultNotify;
		}

		// Token: 0x020012D2 RID: 4818
		[Token(Token = "0x20012D2")]
		[Serializable]
		private class NotifyData
		{
			// Token: 0x06004BE2 RID: 19426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BE2")]
			[Address(RVA = "0x1A4F7A0", Offset = "0x1A4F7A0", VA = "0x7BBC24F7A0")]
			public NotifyData()
			{
			}

			// Token: 0x040073D3 RID: 29651
			[Token(Token = "0x40073D3")]
			[FieldOffset(Offset = "0x10")]
			public long ExpireAt;

			// Token: 0x040073D4 RID: 29652
			[Token(Token = "0x40073D4")]
			[FieldOffset(Offset = "0x18")]
			public bool DoNotify;
		}

		// Token: 0x020012D3 RID: 4819
		[Token(Token = "0x20012D3")]
		private enum Action
		{
			// Token: 0x040073D6 RID: 29654
			[Token(Token = "0x40073D6")]
			UnscheduleAll,
			// Token: 0x040073D7 RID: 29655
			[Token(Token = "0x40073D7")]
			Unschedule,
			// Token: 0x040073D8 RID: 29656
			[Token(Token = "0x40073D8")]
			Schedule
		}

		// Token: 0x020012D4 RID: 4820
		[Token(Token = "0x20012D4")]
		private class _Task
		{
			// Token: 0x06004BE3 RID: 19427 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BE3")]
			[Address(RVA = "0x1A51A58", Offset = "0x1A51A58", VA = "0x7BBC251A58")]
			public _Task()
			{
			}

			// Token: 0x040073D9 RID: 29657
			[Token(Token = "0x40073D9")]
			[FieldOffset(Offset = "0x10")]
			public LocalNotificationManager.Action Action;

			// Token: 0x040073DA RID: 29658
			[Token(Token = "0x40073DA")]
			[FieldOffset(Offset = "0x14")]
			public LocalNotificationManager.NotifyType Type;

			// Token: 0x040073DB RID: 29659
			[Token(Token = "0x40073DB")]
			[FieldOffset(Offset = "0x18")]
			public long TimeMS;

			// Token: 0x040073DC RID: 29660
			[Token(Token = "0x40073DC")]
			[FieldOffset(Offset = "0x20")]
			public int Times;

			// Token: 0x040073DD RID: 29661
			[Token(Token = "0x40073DD")]
			[FieldOffset(Offset = "0x24")]
			public int IntervalMS;

			// Token: 0x040073DE RID: 29662
			[Token(Token = "0x40073DE")]
			[FieldOffset(Offset = "0x28")]
			public string overrideTitle;

			// Token: 0x040073DF RID: 29663
			[Token(Token = "0x40073DF")]
			[FieldOffset(Offset = "0x30")]
			public string overrideContent;
		}

		// Token: 0x020012D5 RID: 4821
		[Token(Token = "0x20012D5")]
		private enum AuthroizationPhase
		{
			// Token: 0x040073E1 RID: 29665
			[Token(Token = "0x40073E1")]
			None,
			// Token: 0x040073E2 RID: 29666
			[Token(Token = "0x40073E2")]
			Getting,
			// Token: 0x040073E3 RID: 29667
			[Token(Token = "0x40073E3")]
			Authorizing,
			// Token: 0x040073E4 RID: 29668
			[Token(Token = "0x40073E4")]
			Done
		}

		// Token: 0x020012D6 RID: 4822
		[Token(Token = "0x20012D6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB0C8", Offset = "0x10EB0C8")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004BE5 RID: 19429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BE5")]
			[Address(RVA = "0x1A53040", Offset = "0x1A53040", VA = "0x7BBC253040")]
			public <>c()
			{
			}

			// Token: 0x06004BE6 RID: 19430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BE6")]
			[Address(RVA = "0x1A53048", Offset = "0x1A53048", VA = "0x7BBC253048")]
			internal void <_AuthorizeAndExecute>b__43_0(PlatformUtility.LocalNotificationAuthorizationStatus status)
			{
			}

			// Token: 0x06004BE7 RID: 19431 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BE7")]
			[Address(RVA = "0x1A531F4", Offset = "0x1A531F4", VA = "0x7BBC2531F4")]
			internal void <_AuthorizeAndExecute>b__43_1(bool granted)
			{
			}

			// Token: 0x06004BE8 RID: 19432 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BE8")]
			[Address(RVA = "0x1A532A8", Offset = "0x1A532A8", VA = "0x7BBC2532A8")]
			internal string <.cctor>b__52_0()
			{
				return null;
			}

			// Token: 0x06004BE9 RID: 19433 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BE9")]
			[Address(RVA = "0x1A53354", Offset = "0x1A53354", VA = "0x7BBC253354")]
			internal string <.cctor>b__52_1()
			{
				return null;
			}

			// Token: 0x06004BEA RID: 19434 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BEA")]
			[Address(RVA = "0x1A53400", Offset = "0x1A53400", VA = "0x7BBC253400")]
			internal string <.cctor>b__52_2(object[] parameters)
			{
				return null;
			}

			// Token: 0x06004BEB RID: 19435 RVA: 0x00016C20 File Offset: 0x00014E20
			[Token(Token = "0x6004BEB")]
			[Address(RVA = "0x1A53510", Offset = "0x1A53510", VA = "0x7BBC253510")]
			internal int <.cctor>b__52_3()
			{
				return 0;
			}

			// Token: 0x06004BEC RID: 19436 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BEC")]
			[Address(RVA = "0x1A53580", Offset = "0x1A53580", VA = "0x7BBC253580")]
			internal string <.cctor>b__52_4()
			{
				return null;
			}

			// Token: 0x06004BED RID: 19437 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BED")]
			[Address(RVA = "0x1A5362C", Offset = "0x1A5362C", VA = "0x7BBC25362C")]
			internal string <.cctor>b__52_5()
			{
				return null;
			}

			// Token: 0x06004BEE RID: 19438 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BEE")]
			[Address(RVA = "0x1A536CC", Offset = "0x1A536CC", VA = "0x7BBC2536CC")]
			internal string <.cctor>b__52_6(object[] parameters)
			{
				return null;
			}

			// Token: 0x06004BEF RID: 19439 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BEF")]
			[Address(RVA = "0x1A537DC", Offset = "0x1A537DC", VA = "0x7BBC2537DC")]
			internal string <.cctor>b__52_7()
			{
				return null;
			}

			// Token: 0x06004BF0 RID: 19440 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BF0")]
			[Address(RVA = "0x1A53888", Offset = "0x1A53888", VA = "0x7BBC253888")]
			internal string <.cctor>b__52_8()
			{
				return null;
			}

			// Token: 0x06004BF1 RID: 19441 RVA: 0x00016C38 File Offset: 0x00014E38
			[Token(Token = "0x6004BF1")]
			[Address(RVA = "0x1A53934", Offset = "0x1A53934", VA = "0x7BBC253934")]
			internal int <.cctor>b__52_9()
			{
				return 0;
			}

			// Token: 0x06004BF2 RID: 19442 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BF2")]
			[Address(RVA = "0x1A539A4", Offset = "0x1A539A4", VA = "0x7BBC2539A4")]
			internal string <.cctor>b__52_10()
			{
				return null;
			}

			// Token: 0x06004BF3 RID: 19443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BF3")]
			[Address(RVA = "0x1A53A50", Offset = "0x1A53A50", VA = "0x7BBC253A50")]
			internal string <.cctor>b__52_11()
			{
				return null;
			}

			// Token: 0x06004BF4 RID: 19444 RVA: 0x00016C50 File Offset: 0x00014E50
			[Token(Token = "0x6004BF4")]
			[Address(RVA = "0x1A53AFC", Offset = "0x1A53AFC", VA = "0x7BBC253AFC")]
			internal int <.cctor>b__52_12()
			{
				return 0;
			}

			// Token: 0x06004BF5 RID: 19445 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BF5")]
			[Address(RVA = "0x1A53B6C", Offset = "0x1A53B6C", VA = "0x7BBC253B6C")]
			internal string <.cctor>b__52_13()
			{
				return null;
			}

			// Token: 0x06004BF6 RID: 19446 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BF6")]
			[Address(RVA = "0x1A53C18", Offset = "0x1A53C18", VA = "0x7BBC253C18")]
			internal string <.cctor>b__52_14()
			{
				return null;
			}

			// Token: 0x06004BF7 RID: 19447 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BF7")]
			[Address(RVA = "0x1A53CC4", Offset = "0x1A53CC4", VA = "0x7BBC253CC4")]
			internal string <.cctor>b__52_15(object[] parameters)
			{
				return null;
			}

			// Token: 0x06004BF8 RID: 19448 RVA: 0x00016C68 File Offset: 0x00014E68
			[Token(Token = "0x6004BF8")]
			[Address(RVA = "0x1A53F3C", Offset = "0x1A53F3C", VA = "0x7BBC253F3C")]
			internal int <.cctor>b__52_16()
			{
				return 0;
			}

			// Token: 0x06004BF9 RID: 19449 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BF9")]
			[Address(RVA = "0x1A53FAC", Offset = "0x1A53FAC", VA = "0x7BBC253FAC")]
			internal string <.cctor>b__52_17()
			{
				return null;
			}

			// Token: 0x06004BFA RID: 19450 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BFA")]
			[Address(RVA = "0x1A54058", Offset = "0x1A54058", VA = "0x7BBC254058")]
			internal string <.cctor>b__52_18()
			{
				return null;
			}

			// Token: 0x06004BFB RID: 19451 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BFB")]
			[Address(RVA = "0x1A54104", Offset = "0x1A54104", VA = "0x7BBC254104")]
			internal string <.cctor>b__52_19(object[] parameters)
			{
				return null;
			}

			// Token: 0x06004BFC RID: 19452 RVA: 0x00016C80 File Offset: 0x00014E80
			[Token(Token = "0x6004BFC")]
			[Address(RVA = "0x1A5419C", Offset = "0x1A5419C", VA = "0x7BBC25419C")]
			internal int <.cctor>b__52_20()
			{
				return 0;
			}

			// Token: 0x040073E5 RID: 29669
			[Token(Token = "0x40073E5")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LocalNotificationManager.<>c <>9;

			// Token: 0x040073E6 RID: 29670
			[Token(Token = "0x40073E6")]
			[FieldOffset(Offset = "0x8")]
			public static Action<bool> <>9__43_1;

			// Token: 0x040073E7 RID: 29671
			[Token(Token = "0x40073E7")]
			[FieldOffset(Offset = "0x10")]
			public static Action<PlatformUtility.LocalNotificationAuthorizationStatus> <>9__43_0;
		}
	}
}
