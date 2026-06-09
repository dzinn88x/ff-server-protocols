using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F3C RID: 3900
	[Token(Token = "0x2000F3C")]
	public static class PlatformUtility
	{
		// Token: 0x060037F3 RID: 14323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F3")]
		[Address(RVA = "0x246DCF8", Offset = "0x246DCF8", VA = "0x7BBCC6DCF8")]
		public static void Init(PlatformUtility.PlatformUtilityOption option)
		{
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F4")]
		[Address(RVA = "0x246DED8", Offset = "0x246DED8", VA = "0x7BBCC6DED8")]
		public static void SetLogCallbacks(PlatformUtility.LogCallback onLog, PlatformUtility.LogCallback onLogError)
		{
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F5")]
		[Address(RVA = "0x246DF44", Offset = "0x246DF44", VA = "0x7BBCC6DF44")]
		internal static void Log(string log)
		{
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F6")]
		[Address(RVA = "0x246E6E0", Offset = "0x246E6E0", VA = "0x7BBCC6E6E0")]
		internal static void LogError(string logError)
		{
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F7")]
		[Address(RVA = "0x246E748", Offset = "0x246E748", VA = "0x7BBCC6E748")]
		public static void SetUnitySendMessageGameObjectName(string gameObjectName)
		{
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F8")]
		[Address(RVA = "0x246E8B0", Offset = "0x246E8B0", VA = "0x7BBCC6E8B0")]
		public static PlatformUtility.OpenedWith GetOpenedWith()
		{
			return null;
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F9")]
		[Address(RVA = "0x246EAE8", Offset = "0x246EAE8", VA = "0x7BBCC6EAE8")]
		public static void ClearOpenedWith()
		{
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037FA")]
		[Address(RVA = "0x246EBE4", Offset = "0x246EBE4", VA = "0x7BBCC6EBE4")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x113B9E0", Offset = "0x113B9E0")]
		public static string GetOpenedByUrl()
		{
			return null;
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FB")]
		[Address(RVA = "0x246ECE8", Offset = "0x246ECE8", VA = "0x7BBCC6ECE8")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x113BA1C", Offset = "0x113BA1C")]
		public static void SetOpenedByUrl(string url)
		{
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FC")]
		[Address(RVA = "0x246EE50", Offset = "0x246EE50", VA = "0x7BBCC6EE50")]
		public static void SetCanHandleLowMemory(bool canHandle)
		{
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FD")]
		[Address(RVA = "0x246EFDC", Offset = "0x246EFDC", VA = "0x7BBCC6EFDC")]
		public static void CopyStringToClipboard(string content)
		{
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037FE")]
		[Address(RVA = "0x246F19C", Offset = "0x246F19C", VA = "0x7BBCC6F19C")]
		public static string CopyStringFromClipboard()
		{
			return null;
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FF")]
		[Address(RVA = "0x246F2A0", Offset = "0x246F2A0", VA = "0x7BBCC6F2A0")]
		public static void SaveImageToAlbum(byte[] imageData, string title, string description, Action<string> callback)
		{
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003800")]
		[Address(RVA = "0x246F4E0", Offset = "0x246F4E0", VA = "0x7BBCC6F4E0")]
		public static void CancelSaveImageToAlbumCallback()
		{
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003801")]
		[Address(RVA = "0x246F530", Offset = "0x246F530", VA = "0x7BBCC6F530")]
		public static void SendText(string title, string text)
		{
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x000114F0 File Offset: 0x0000F6F0
		[Token(Token = "0x6003802")]
		[Address(RVA = "0x246F818", Offset = "0x246F818", VA = "0x7BBCC6F818")]
		public static bool SendImage(string text, string filePath)
		{
			return default(bool);
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003803")]
		[Address(RVA = "0x246FBC0", Offset = "0x246FBC0", VA = "0x7BBCC6FBC0")]
		public static void NativeLog(string text)
		{
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06003804 RID: 14340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D0")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x115A368", Offset = "0x115A368")]
		public static string DeviceIdentifier
		{
			[Token(Token = "0x6003804")]
			[Address(RVA = "0x246FD28", Offset = "0x246FD28", VA = "0x7BBCC6FD28")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06003805 RID: 14341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D1")]
		public static string VersionCode
		{
			[Token(Token = "0x6003805")]
			[Address(RVA = "0x2470030", Offset = "0x2470030", VA = "0x7BBCC70030")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x00011508 File Offset: 0x0000F708
		[Token(Token = "0x6003806")]
		[Address(RVA = "0x24702A0", Offset = "0x24702A0", VA = "0x7BBCC702A0")]
		public static bool IsEmulator()
		{
			return default(bool);
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003807")]
		[Address(RVA = "0x247052C", Offset = "0x247052C", VA = "0x7BBCC7052C")]
		public static string GetNetworkType()
		{
			return null;
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003808")]
		[Address(RVA = "0x2470630", Offset = "0x2470630", VA = "0x7BBCC70630")]
		public static string GetNetworkName()
		{
			return null;
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003809")]
		[Address(RVA = "0x2470734", Offset = "0x2470734", VA = "0x7BBCC70734")]
		public static void ToggleBatteryReport(bool shouldReport)
		{
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x00011520 File Offset: 0x0000F720
		[Token(Token = "0x600380A")]
		[Address(RVA = "0x24708C0", Offset = "0x24708C0", VA = "0x7BBCC708C0")]
		public static float GetBatteryLevel()
		{
			return 0f;
		}

		// Token: 0x0600380B RID: 14347 RVA: 0x00011538 File Offset: 0x0000F738
		[Token(Token = "0x600380B")]
		[Address(RVA = "0x24709C4", Offset = "0x24709C4", VA = "0x7BBCC709C4")]
		public static int GetAppMemory()
		{
			return 0;
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x00011550 File Offset: 0x0000F750
		[Token(Token = "0x600380C")]
		[Address(RVA = "0x2470AD0", Offset = "0x2470AD0", VA = "0x7BBCC70AD0")]
		public static int GetAvailMemory()
		{
			return 0;
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x00011568 File Offset: 0x0000F768
		[Token(Token = "0x600380D")]
		[Address(RVA = "0x2470BE8", Offset = "0x2470BE8", VA = "0x7BBCC70BE8")]
		public static int GetTotalMemory()
		{
			return 0;
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x00011580 File Offset: 0x0000F780
		[Token(Token = "0x600380E")]
		[Address(RVA = "0x2470E38", Offset = "0x2470E38", VA = "0x7BBCC70E38")]
		public static bool IsTotalMemoryAboveThreshold(float number_gigabytes)
		{
			return default(bool);
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x00011598 File Offset: 0x0000F798
		[Token(Token = "0x600380F")]
		[Address(RVA = "0x2470E70", Offset = "0x2470E70", VA = "0x7BBCC70E70")]
		public static int GetLowMemoryThreshold()
		{
			return 0;
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x000115B0 File Offset: 0x0000F7B0
		[Token(Token = "0x6003810")]
		[Address(RVA = "0x2470F88", Offset = "0x2470F88", VA = "0x7BBCC70F88")]
		public static bool IsBatteryCharging()
		{
			return default(bool);
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x000115C8 File Offset: 0x0000F7C8
		[Token(Token = "0x6003811")]
		[Address(RVA = "0x247108C", Offset = "0x247108C", VA = "0x7BBCC7108C")]
		public static float GetWifiSignalLevel()
		{
			return 0f;
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x000115E0 File Offset: 0x0000F7E0
		[Token(Token = "0x6003812")]
		[Address(RVA = "0x2471190", Offset = "0x2471190", VA = "0x7BBCC71190")]
		public static int IntPtrBytes()
		{
			return 0;
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x000115F8 File Offset: 0x0000F7F8
		[Token(Token = "0x6003813")]
		[Address(RVA = "0x2471198", Offset = "0x2471198", VA = "0x7BBCC71198")]
		public static bool Is32BitsProcess()
		{
			return default(bool);
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x00011610 File Offset: 0x0000F810
		[Token(Token = "0x6003814")]
		[Address(RVA = "0x24711B8", Offset = "0x24711B8", VA = "0x7BBCC711B8")]
		public static bool Is64BitsProcess()
		{
			return default(bool);
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x00011628 File Offset: 0x0000F828
		[Token(Token = "0x6003815")]
		[Address(RVA = "0x24711D8", Offset = "0x24711D8", VA = "0x7BBCC711D8")]
		public static bool SupportInAppReview()
		{
			return default(bool);
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x00011640 File Offset: 0x0000F840
		[Token(Token = "0x6003816")]
		[Address(RVA = "0x24712C4", Offset = "0x24712C4", VA = "0x7BBCC712C4")]
		public static bool DoInAppReview(Action<bool> callback)
		{
			return default(bool);
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003817")]
		[Address(RVA = "0x24713E8", Offset = "0x24713E8", VA = "0x7BBCC713E8")]
		public static void SetTakenScreenshotCallback(Action action)
		{
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003818")]
		[Address(RVA = "0x247143C", Offset = "0x247143C", VA = "0x7BBCC7143C")]
		internal static void OnTakenScreenshot(string clue)
		{
		}

		// Token: 0x06003819 RID: 14361 RVA: 0x00011658 File Offset: 0x0000F858
		[Token(Token = "0x6003819")]
		[Address(RVA = "0x2471504", Offset = "0x2471504", VA = "0x7BBCC71504")]
		public static bool SupportsLocalNotification()
		{
			return default(bool);
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x00011670 File Offset: 0x0000F870
		[Token(Token = "0x600381A")]
		[Address(RVA = "0x247150C", Offset = "0x247150C", VA = "0x7BBCC7150C")]
		public static bool ShouldCheckForLocalNotificationAuthorization()
		{
			return default(bool);
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x00011688 File Offset: 0x0000F888
		[Token(Token = "0x600381B")]
		[Address(RVA = "0x2471514", Offset = "0x2471514", VA = "0x7BBCC71514")]
		public static bool ShouldSetupLocalNotificationChannels()
		{
			return default(bool);
		}

		// Token: 0x0600381C RID: 14364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600381C")]
		[Address(RVA = "0x247151C", Offset = "0x247151C", VA = "0x7BBCC7151C")]
		public static void SetupLocalNotificationChannel(string channel_id, string channel_name, string channel_description, PlatformUtility.LocalNotificationImportance importance)
		{
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600381D")]
		[Address(RVA = "0x24717C0", Offset = "0x24717C0", VA = "0x7BBCC717C0")]
		public static void GetLocalNotificationAuthorizationStatus(Action<PlatformUtility.LocalNotificationAuthorizationStatus> callback)
		{
		}

		// Token: 0x0600381E RID: 14366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600381E")]
		[Address(RVA = "0x2471824", Offset = "0x2471824", VA = "0x7BBCC71824")]
		public static void RequestLocalNotificationAuthorization(Action<bool> callback)
		{
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600381F")]
		[Address(RVA = "0x2471888", Offset = "0x2471888", VA = "0x7BBCC71888")]
		public static void ScheduleLocalNotification(int id, string channel_id, string title, string subtitle, string content, string url, long time_ms, int times, int interval_ms, Action done)
		{
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003820")]
		[Address(RVA = "0x2472088", Offset = "0x2472088", VA = "0x7BBCC72088")]
		public static void UnscheduleLocalNotification(int id, Action done)
		{
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003821")]
		[Address(RVA = "0x2472274", Offset = "0x2472274", VA = "0x7BBCC72274")]
		public static void UnscheduleAllLocalNotifications()
		{
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003822")]
		[Address(RVA = "0x2472370", Offset = "0x2472370", VA = "0x7BBCC72370")]
		public static void ClearAllNotifications()
		{
		}

		// Token: 0x04004A5E RID: 19038
		[Token(Token = "0x4004A5E")]
		[FieldOffset(Offset = "0x0")]
		private static PlatformUtility.LogCallback OnLog;

		// Token: 0x04004A5F RID: 19039
		[Token(Token = "0x4004A5F")]
		[FieldOffset(Offset = "0x8")]
		private static PlatformUtility.LogCallback OnLogError;

		// Token: 0x04004A60 RID: 19040
		[Token(Token = "0x4004A60")]
		[FieldOffset(Offset = "0x10")]
		internal static Action<string> _SaveImageToAlbumCallback;

		// Token: 0x04004A61 RID: 19041
		[Token(Token = "0x4004A61")]
		[FieldOffset(Offset = "0x18")]
		public static PlatformUtility.BatteryChargingChangedCallback OnBatteryChargingChanged;

		// Token: 0x04004A62 RID: 19042
		[Token(Token = "0x4004A62")]
		[FieldOffset(Offset = "0x20")]
		public static PlatformUtility.BatteryLevelChangedCallback OnBatteryLevelChanged;

		// Token: 0x04004A63 RID: 19043
		[Token(Token = "0x4004A63")]
		[FieldOffset(Offset = "0x28")]
		private static Action _OnTakenScreenshot;

		// Token: 0x02000F3D RID: 3901
		// (Invoke) Token: 0x06003824 RID: 14372
		[Token(Token = "0x2000F3D")]
		public delegate void LogCallback(string log);

		// Token: 0x02000F3E RID: 3902
		[Token(Token = "0x2000F3E")]
		public class PlatformUtilityOption
		{
			// Token: 0x06003827 RID: 14375 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003827")]
			[Address(RVA = "0x24732D8", Offset = "0x24732D8", VA = "0x7BBCC732D8")]
			public PlatformUtilityOption()
			{
			}

			// Token: 0x04004A64 RID: 19044
			[Token(Token = "0x4004A64")]
			[FieldOffset(Offset = "0x10")]
			public string AndroidFileProviderAuthorities;
		}

		// Token: 0x02000F3F RID: 3903
		[Token(Token = "0x2000F3F")]
		public class OpenedWith
		{
			// Token: 0x170006D2 RID: 1746
			// (get) Token: 0x06003828 RID: 14376 RVA: 0x000116A0 File Offset: 0x0000F8A0
			[Token(Token = "0x170006D2")]
			public bool HasParams
			{
				[Token(Token = "0x6003828")]
				[Address(RVA = "0x2472F14", Offset = "0x2472F14", VA = "0x7BBCC72F14")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170006D3 RID: 1747
			// (get) Token: 0x06003829 RID: 14377 RVA: 0x000116B8 File Offset: 0x0000F8B8
			[Token(Token = "0x170006D3")]
			public bool HasUrl
			{
				[Token(Token = "0x6003829")]
				[Address(RVA = "0x2472F74", Offset = "0x2472F74", VA = "0x7BBCC72F74")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600382A RID: 14378 RVA: 0x000116D0 File Offset: 0x0000F8D0
			[Token(Token = "0x600382A")]
			[Address(RVA = "0x2472F98", Offset = "0x2472F98", VA = "0x7BBCC72F98")]
			public static bool HasValue(PlatformUtility.OpenedWith ow)
			{
				return default(bool);
			}

			// Token: 0x0600382B RID: 14379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600382B")]
			[Address(RVA = "0x2472FE8", Offset = "0x2472FE8", VA = "0x7BBCC72FE8")]
			public void FromJson(string json)
			{
			}

			// Token: 0x0600382C RID: 14380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600382C")]
			[Address(RVA = "0x24732D0", Offset = "0x24732D0", VA = "0x7BBCC732D0")]
			public OpenedWith()
			{
			}

			// Token: 0x04004A65 RID: 19045
			[Token(Token = "0x4004A65")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, string> Params;

			// Token: 0x04004A66 RID: 19046
			[Token(Token = "0x4004A66")]
			[FieldOffset(Offset = "0x18")]
			public string Url;
		}

		// Token: 0x02000F40 RID: 3904
		// (Invoke) Token: 0x0600382E RID: 14382
		[Token(Token = "0x2000F40")]
		public delegate void BatteryChargingChangedCallback(bool charging);

		// Token: 0x02000F41 RID: 3905
		// (Invoke) Token: 0x06003832 RID: 14386
		[Token(Token = "0x2000F41")]
		public delegate void BatteryLevelChangedCallback(float level);

		// Token: 0x02000F42 RID: 3906
		[Token(Token = "0x2000F42")]
		public enum LocalNotificationImportance
		{
			// Token: 0x04004A68 RID: 19048
			[Token(Token = "0x4004A68")]
			Unspecified = -1000,
			// Token: 0x04004A69 RID: 19049
			[Token(Token = "0x4004A69")]
			None = 0,
			// Token: 0x04004A6A RID: 19050
			[Token(Token = "0x4004A6A")]
			Min,
			// Token: 0x04004A6B RID: 19051
			[Token(Token = "0x4004A6B")]
			Low,
			// Token: 0x04004A6C RID: 19052
			[Token(Token = "0x4004A6C")]
			Default,
			// Token: 0x04004A6D RID: 19053
			[Token(Token = "0x4004A6D")]
			High,
			// Token: 0x04004A6E RID: 19054
			[Token(Token = "0x4004A6E")]
			Max
		}

		// Token: 0x02000F43 RID: 3907
		[Token(Token = "0x2000F43")]
		public enum LocalNotificationAuthorizationStatus
		{
			// Token: 0x04004A70 RID: 19056
			[Token(Token = "0x4004A70")]
			NotDetermined,
			// Token: 0x04004A71 RID: 19057
			[Token(Token = "0x4004A71")]
			Denied,
			// Token: 0x04004A72 RID: 19058
			[Token(Token = "0x4004A72")]
			Authorized
		}

		// Token: 0x02000F44 RID: 3908
		[Token(Token = "0x2000F44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA470", Offset = "0x10EA470")]
		private sealed class <>c__DisplayClass50_0
		{
			// Token: 0x06003835 RID: 14389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003835")]
			[Address(RVA = "0x24714FC", Offset = "0x24714FC", VA = "0x7BBCC714FC")]
			public <>c__DisplayClass50_0()
			{
			}

			// Token: 0x06003836 RID: 14390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003836")]
			[Address(RVA = "0x247246C", Offset = "0x247246C", VA = "0x7BBCC7246C")]
			internal void <OnTakenScreenshot>b__0()
			{
			}

			// Token: 0x04004A73 RID: 19059
			[Token(Token = "0x4004A73")]
			[FieldOffset(Offset = "0x10")]
			public string clue;
		}
	}
}
