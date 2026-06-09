using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BCA RID: 11210
	[Token(Token = "0x2002BCA")]
	public static class SDKIAP
	{
		// Token: 0x0600F84D RID: 63565 RVA: 0x00047730 File Offset: 0x00045930
		[Token(Token = "0x600F84D")]
		[Address(RVA = "0x224F480", Offset = "0x224F480", VA = "0x7BBCA4F480")]
		public static bool IsOK(ErrorCode errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600F84E RID: 63566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F84E")]
		[Address(RVA = "0x22538E0", Offset = "0x22538E0", VA = "0x7BBCA538E0")]
		public static string FormatIAPItemIdentifier(string itemID)
		{
			return null;
		}

		// Token: 0x0600F84F RID: 63567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F84F")]
		[Address(RVA = "0x2253954", Offset = "0x2253954", VA = "0x7BBCA53954")]
		internal static void RestoreIAP(int serverId = 0, int roleId = 0)
		{
		}

		// Token: 0x0600F850 RID: 63568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F850")]
		[Address(RVA = "0x2251824", Offset = "0x2251824", VA = "0x7BBCA51824")]
		internal static void LogVerbose(string log)
		{
		}

		// Token: 0x0600F851 RID: 63569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F851")]
		[Address(RVA = "0x22515FC", Offset = "0x22515FC", VA = "0x7BBCA515FC")]
		internal static void Log(string log)
		{
		}

		// Token: 0x0600F852 RID: 63570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F852")]
		[Address(RVA = "0x225408C", Offset = "0x225408C", VA = "0x7BBCA5408C")]
		internal static void LogError(string log)
		{
		}

		// Token: 0x0600F853 RID: 63571 RVA: 0x00047748 File Offset: 0x00045948
		[Token(Token = "0x600F853")]
		[Address(RVA = "0x2254140", Offset = "0x2254140", VA = "0x7BBCA54140")]
		public static bool CanLoadIAPItemsOnDemand()
		{
			return default(bool);
		}

		// Token: 0x0600F854 RID: 63572 RVA: 0x00047760 File Offset: 0x00045960
		[Token(Token = "0x600F854")]
		[Address(RVA = "0x2254148", Offset = "0x2254148", VA = "0x7BBCA54148")]
		public static bool CanGetRebateOptionsOnDemand()
		{
			return default(bool);
		}

		// Token: 0x0600F855 RID: 63573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F855")]
		[Address(RVA = "0x224FA94", Offset = "0x224FA94", VA = "0x7BBCA4FA94")]
		internal static void GetRebateOptions()
		{
		}

		// Token: 0x0600F856 RID: 63574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F856")]
		[Address(RVA = "0x2250D54", Offset = "0x2250D54", VA = "0x7BBCA50D54")]
		internal static void GetRebateOptionsByRebateIds(long[] rebateIds)
		{
		}

		// Token: 0x0600F857 RID: 63575 RVA: 0x00047778 File Offset: 0x00045978
		[Token(Token = "0x600F857")]
		[Address(RVA = "0x2254150", Offset = "0x2254150", VA = "0x7BBCA54150")]
		public static bool ShouldLoadRebateIAPItems()
		{
			return default(bool);
		}

		// Token: 0x0600F858 RID: 63576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F858")]
		[Address(RVA = "0x2254158", Offset = "0x2254158", VA = "0x7BBCA54158")]
		internal static void ClearIAPItems()
		{
		}

		// Token: 0x0600F859 RID: 63577 RVA: 0x00047790 File Offset: 0x00045990
		[Token(Token = "0x600F859")]
		[Address(RVA = "0x224F2DC", Offset = "0x224F2DC", VA = "0x7BBCA4F2DC")]
		internal static bool LoadIAPItems(int serverId, int roleId, bool localized, bool allItems = true, long rebateId = 0L)
		{
			return default(bool);
		}

		// Token: 0x0600F85A RID: 63578 RVA: 0x000477A8 File Offset: 0x000459A8
		[Token(Token = "0x600F85A")]
		[Address(RVA = "0x2250490", Offset = "0x2250490", VA = "0x7BBCA50490")]
		internal static bool LoadIAPItems(int serverId, int roleId, bool localized, int[] itemIds, long[] rebateIds)
		{
			return default(bool);
		}

		// Token: 0x0600F85B RID: 63579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F85B")]
		[Address(RVA = "0x2254160", Offset = "0x2254160", VA = "0x7BBCA54160")]
		public static void SetLocale(string language, string region)
		{
		}

		// Token: 0x0600F85C RID: 63580 RVA: 0x000477C0 File Offset: 0x000459C0
		[Token(Token = "0x600F85C")]
		[Address(RVA = "0x2254168", Offset = "0x2254168", VA = "0x7BBCA54168")]
		public static bool IsSupportIAP()
		{
			return default(bool);
		}

		// Token: 0x0600F85D RID: 63581 RVA: 0x000477D8 File Offset: 0x000459D8
		[Token(Token = "0x600F85D")]
		[Address(RVA = "0x22514D0", Offset = "0x22514D0", VA = "0x7BBCA514D0")]
		internal static bool IAP([Optional] string productIdentifier, long rebateId = 0L, int quantity = 1, int serverId = 0, int roleId = 0)
		{
			return default(bool);
		}

		// Token: 0x0600F85E RID: 63582 RVA: 0x000477F0 File Offset: 0x000459F0
		[Token(Token = "0x600F85E")]
		[Address(RVA = "0x225248C", Offset = "0x225248C", VA = "0x7BBCA5248C")]
		internal static bool RedeemRebate(int rebateId = 0, int serverId = 0, int roleId = 0)
		{
			return default(bool);
		}

		// Token: 0x0600F85F RID: 63583 RVA: 0x00047808 File Offset: 0x00045A08
		[Token(Token = "0x600F85F")]
		[Address(RVA = "0x2254170", Offset = "0x2254170", VA = "0x7BBCA54170")]
		public static bool ShouldScanIAPInventory()
		{
			return default(bool);
		}

		// Token: 0x0600F860 RID: 63584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F860")]
		[Address(RVA = "0x2254178", Offset = "0x2254178", VA = "0x7BBCA54178")]
		internal static string ScanIAPInventory(int serverId = 0, int roleId = 0)
		{
			return null;
		}

		// Token: 0x04011BF2 RID: 72690
		[Token(Token = "0x4011BF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string IAPItemIdentifierTemplate;

		// Token: 0x04011BF3 RID: 72691
		[Token(Token = "0x4011BF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string VirtualCurrencyName;

		// Token: 0x04011BF4 RID: 72692
		[Token(Token = "0x4011BF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static Action<SDKIAP.IAPItem[], ErrorCode, string> OnLoadedIAPItems;

		// Token: 0x04011BF5 RID: 72693
		[Token(Token = "0x4011BF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static Action<SDKIAP_Android.TransactionInfo> OnPaymentProcessedOrException;

		// Token: 0x04011BF6 RID: 72694
		[Token(Token = "0x4011BF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal static Action<SDKIAP.ScanIAPInventoryResult[]> OnScanIAPInventoryResult;

		// Token: 0x04011BF7 RID: 72695
		[Token(Token = "0x4011BF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal static Action<SDKIAP.RebateOption[], ErrorCode, string> OnLoadedRebateOptions;

		// Token: 0x04011BF8 RID: 72696
		[Token(Token = "0x4011BF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal static Action<SDKIAP.RebateRedeemResult[], ErrorCode, string> OnRedeemedRebateOptions;

		// Token: 0x04011BF9 RID: 72697
		[Token(Token = "0x4011BF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static SDKIAP.LogCallback OnLogVerbose;

		// Token: 0x04011BFA RID: 72698
		[Token(Token = "0x4011BFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static SDKIAP.LogCallback OnLog;

		// Token: 0x04011BFB RID: 72699
		[Token(Token = "0x4011BFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static SDKIAP.LogCallback OnLogError;

		// Token: 0x02002BCB RID: 11211
		[Token(Token = "0x2002BCB")]
		[Serializable]
		public class IAPItem
		{
			// Token: 0x0600F862 RID: 63586 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F862")]
			[Address(RVA = "0x22541FC", Offset = "0x22541FC", VA = "0x7BBCA541FC")]
			public static SDKIAP.IAPItem _(SDKIAP_Android.Denomination denomination)
			{
				return null;
			}

			// Token: 0x0600F863 RID: 63587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F863")]
			[Address(RVA = "0x22543A0", Offset = "0x22543A0", VA = "0x7BBCA543A0")]
			public IAPItem()
			{
			}

			// Token: 0x04011BFC RID: 72700
			[Token(Token = "0x4011BFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string ItemIdentifier;

			// Token: 0x04011BFD RID: 72701
			[Token(Token = "0x4011BFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool Promotion;

			// Token: 0x04011BFE RID: 72702
			[Token(Token = "0x4011BFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int VirtualCurrencyAmount;

			// Token: 0x04011BFF RID: 72703
			[Token(Token = "0x4011BFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int PromotionAmount;

			// Token: 0x04011C00 RID: 72704
			[Token(Token = "0x4011C00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string ActualCurrencyName;

			// Token: 0x04011C01 RID: 72705
			[Token(Token = "0x4011C01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float ActualCurrencyAmount;

			// Token: 0x04011C02 RID: 72706
			[Token(Token = "0x4011C02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string PriceString;

			// Token: 0x04011C03 RID: 72707
			[Token(Token = "0x4011C03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int RebateId;

			// Token: 0x04011C04 RID: 72708
			[Token(Token = "0x4011C04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public SDKIAP.Subscription Subscription;
		}

		// Token: 0x02002BCC RID: 11212
		[Token(Token = "0x2002BCC")]
		[Serializable]
		public class Subscription
		{
			// Token: 0x0600F864 RID: 63588 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F864")]
			[Address(RVA = "0x2254400", Offset = "0x2254400", VA = "0x7BBCA54400")]
			public static SDKIAP.Subscription _(SDKIAP_Android.Subscription subscription)
			{
				return null;
			}

			// Token: 0x0600F865 RID: 63589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F865")]
			[Address(RVA = "0x22545A8", Offset = "0x22545A8", VA = "0x7BBCA545A8")]
			public Subscription()
			{
			}

			// Token: 0x04011C05 RID: 72709
			[Token(Token = "0x4011C05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SDKIAP.SubscriptionPeriod Period;

			// Token: 0x04011C06 RID: 72710
			[Token(Token = "0x4011C06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public SDKIAP.SubscriptionStatus Status;

			// Token: 0x04011C07 RID: 72711
			[Token(Token = "0x4011C07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int LastPaymentTime;

			// Token: 0x04011C08 RID: 72712
			[Token(Token = "0x4011C08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public long GracePeriodExpiryTime;

			// Token: 0x04011C09 RID: 72713
			[Token(Token = "0x4011C09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public long OnHoldSince;
		}

		// Token: 0x02002BCD RID: 11213
		[Token(Token = "0x2002BCD")]
		[Serializable]
		public enum SubscriptionStatus
		{
			// Token: 0x04011C0B RID: 72715
			[Token(Token = "0x4011C0B")]
			None = -1,
			// Token: 0x04011C0C RID: 72716
			[Token(Token = "0x4011C0C")]
			Active,
			// Token: 0x04011C0D RID: 72717
			[Token(Token = "0x4011C0D")]
			Expired,
			// Token: 0x04011C0E RID: 72718
			[Token(Token = "0x4011C0E")]
			Cancelled,
			// Token: 0x04011C0F RID: 72719
			[Token(Token = "0x4011C0F")]
			Revoked,
			// Token: 0x04011C10 RID: 72720
			[Token(Token = "0x4011C10")]
			Transferred,
			// Token: 0x04011C11 RID: 72721
			[Token(Token = "0x4011C11")]
			Scheduled
		}

		// Token: 0x02002BCE RID: 11214
		[Token(Token = "0x2002BCE")]
		[Serializable]
		public enum SubscriptionPeriod
		{
			// Token: 0x04011C13 RID: 72723
			[Token(Token = "0x4011C13")]
			None,
			// Token: 0x04011C14 RID: 72724
			[Token(Token = "0x4011C14")]
			Week_1,
			// Token: 0x04011C15 RID: 72725
			[Token(Token = "0x4011C15")]
			Month_1,
			// Token: 0x04011C16 RID: 72726
			[Token(Token = "0x4011C16")]
			Month_3,
			// Token: 0x04011C17 RID: 72727
			[Token(Token = "0x4011C17")]
			Month_6,
			// Token: 0x04011C18 RID: 72728
			[Token(Token = "0x4011C18")]
			Year_1
		}

		// Token: 0x02002BCF RID: 11215
		[Token(Token = "0x2002BCF")]
		[Serializable]
		public class RebateOption
		{
			// Token: 0x0600F866 RID: 63590 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F866")]
			[Address(RVA = "0x2254540", Offset = "0x2254540", VA = "0x7BBCA54540")]
			public RebateOption()
			{
			}

			// Token: 0x04011C19 RID: 72729
			[Token(Token = "0x4011C19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long RebateId;

			// Token: 0x04011C1A RID: 72730
			[Token(Token = "0x4011C1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int RebateAmount;

			// Token: 0x04011C1B RID: 72731
			[Token(Token = "0x4011C1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int RemainingDays;

			// Token: 0x04011C1C RID: 72732
			[Token(Token = "0x4011C1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int TotalDays;

			// Token: 0x04011C1D RID: 72733
			[Token(Token = "0x4011C1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool CanPurchase;

			// Token: 0x04011C1E RID: 72734
			[Token(Token = "0x4011C1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			public bool CanRedeem;

			// Token: 0x04011C1F RID: 72735
			[Token(Token = "0x4011C1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
			public bool Owned;

			// Token: 0x04011C20 RID: 72736
			[Token(Token = "0x4011C20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string Name;

			// Token: 0x04011C21 RID: 72737
			[Token(Token = "0x4011C21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string Description;
		}

		// Token: 0x02002BD0 RID: 11216
		[Token(Token = "0x2002BD0")]
		[Serializable]
		public class RebateRedeemResult
		{
			// Token: 0x0600F867 RID: 63591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F867")]
			[Address(RVA = "0x2254598", Offset = "0x2254598", VA = "0x7BBCA54598")]
			public RebateRedeemResult()
			{
			}

			// Token: 0x04011C22 RID: 72738
			[Token(Token = "0x4011C22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long RebateId;

			// Token: 0x04011C23 RID: 72739
			[Token(Token = "0x4011C23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int RebateAmount;

			// Token: 0x04011C24 RID: 72740
			[Token(Token = "0x4011C24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int RemainingDays;
		}

		// Token: 0x02002BD1 RID: 11217
		[Token(Token = "0x2002BD1")]
		[Serializable]
		public class ScanIAPInventoryResult
		{
			// Token: 0x0600F868 RID: 63592 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F868")]
			[Address(RVA = "0x22545A0", Offset = "0x22545A0", VA = "0x7BBCA545A0")]
			public ScanIAPInventoryResult()
			{
			}

			// Token: 0x04011C25 RID: 72741
			[Token(Token = "0x4011C25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string ItemIdentifier;

			// Token: 0x04011C26 RID: 72742
			[Token(Token = "0x4011C26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int VirtualCurrencyAmount;

			// Token: 0x04011C27 RID: 72743
			[Token(Token = "0x4011C27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool IsPromotion;

			// Token: 0x04011C28 RID: 72744
			[Token(Token = "0x4011C28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
			public bool Success;

			// Token: 0x04011C29 RID: 72745
			[Token(Token = "0x4011C29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string Error;
		}

		// Token: 0x02002BD2 RID: 11218
		// (Invoke) Token: 0x0600F86A RID: 63594
		[Token(Token = "0x2002BD2")]
		public delegate void LogCallback(string log);
	}
}
