using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GarenaMSDK
{
	// Token: 0x02002BD3 RID: 11219
	[Token(Token = "0x2002BD3")]
	public static class SDKIAP_Android
	{
		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x0600F86D RID: 63597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001210")]
		public static AndroidJavaClass IAP
		{
			[Token(Token = "0x600F86D")]
			[Address(RVA = "0x273AE40", Offset = "0x273AE40", VA = "0x7BBCF3AE40")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F86E RID: 63598 RVA: 0x00047820 File Offset: 0x00045A20
		[Token(Token = "0x600F86E")]
		[Address(RVA = "0x273AED4", Offset = "0x273AED4", VA = "0x7BBCF3AED4")]
		public static bool IsGooglePlayServicesAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600F86F RID: 63599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F86F")]
		[Address(RVA = "0x273AF5C", Offset = "0x273AF5C", VA = "0x7BBCF3AF5C")]
		public static void SetLocale(string language, string region)
		{
		}

		// Token: 0x0600F870 RID: 63600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F870")]
		[Address(RVA = "0x273B08C", Offset = "0x273B08C", VA = "0x7BBCF3B08C")]
		public static void GetRebateOptions(int serverId, int roleId)
		{
		}

		// Token: 0x0600F871 RID: 63601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F871")]
		[Address(RVA = "0x273B27C", Offset = "0x273B27C", VA = "0x7BBCF3B27C")]
		public static void GetRebateOptions(int serverId, int roleId, long[] rebateIds)
		{
		}

		// Token: 0x0600F872 RID: 63602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F872")]
		[Address(RVA = "0x273B5D8", Offset = "0x273B5D8", VA = "0x7BBCF3B5D8")]
		public static void OnGetRebateOptions(string getRebateOptionsResult)
		{
		}

		// Token: 0x0600F873 RID: 63603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F873")]
		[Address(RVA = "0x273B804", Offset = "0x273B804", VA = "0x7BBCF3B804")]
		public static void ClearIAPItems()
		{
		}

		// Token: 0x0600F874 RID: 63604 RVA: 0x00047838 File Offset: 0x00045A38
		[Token(Token = "0x600F874")]
		[Address(RVA = "0x273B884", Offset = "0x273B884", VA = "0x7BBCF3B884")]
		public static bool LoadPaymentOptions(int serverId, int roleId, string virtualCurrencyName, bool allItems, long rebateId, bool localizedPrice)
		{
			return default(bool);
		}

		// Token: 0x0600F875 RID: 63605 RVA: 0x00047850 File Offset: 0x00045A50
		[Token(Token = "0x600F875")]
		[Address(RVA = "0x273BFF0", Offset = "0x273BFF0", VA = "0x7BBCF3BFF0")]
		public static bool LoadPaymentOptions(int serverId, int roleId, string virtualCurrencyName, bool localizedPrice, int[] itemIds, long[] rebateIds)
		{
			return default(bool);
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x0600F876 RID: 63606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001211")]
		private static string PaymentChannelID
		{
			[Token(Token = "0x600F876")]
			[Address(RVA = "0x273C7A8", Offset = "0x273C7A8", VA = "0x7BBCF3C7A8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F877 RID: 63607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F877")]
		[Address(RVA = "0x273C7F0", Offset = "0x273C7F0", VA = "0x7BBCF3C7F0")]
		public static void OnPaymentOptionsLoaded(string result)
		{
		}

		// Token: 0x0600F878 RID: 63608 RVA: 0x00047868 File Offset: 0x00045A68
		[Token(Token = "0x600F878")]
		[Address(RVA = "0x273CB54", Offset = "0x273CB54", VA = "0x7BBCF3CB54")]
		public static bool ProcessPaymentWithChannelItem(int serverId, int roleId, string virtualCurrencyName, string itemIdentifier)
		{
			return default(bool);
		}

		// Token: 0x0600F879 RID: 63609 RVA: 0x00047880 File Offset: 0x00045A80
		[Token(Token = "0x600F879")]
		[Address(RVA = "0x273D060", Offset = "0x273D060", VA = "0x7BBCF3D060")]
		public static bool ProcessPayment(int serverId, int roleId, string virtualCurrencyName, long rebateId)
		{
			return default(bool);
		}

		// Token: 0x0600F87A RID: 63610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F87A")]
		[Address(RVA = "0x273D4E4", Offset = "0x273D4E4", VA = "0x7BBCF3D4E4")]
		public static void onPaymentProcessed_Exception(string transactionInfo)
		{
		}

		// Token: 0x0600F87B RID: 63611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F87B")]
		[Address(RVA = "0x273D620", Offset = "0x273D620", VA = "0x7BBCF3D620")]
		public static void onPaymentProcessed(string transactionInfo)
		{
		}

		// Token: 0x0600F87C RID: 63612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F87C")]
		[Address(RVA = "0x273D75C", Offset = "0x273D75C", VA = "0x7BBCF3D75C")]
		public static void Redeem(long rebateId = 0L, int serverId = 0, int roleId = 0)
		{
		}

		// Token: 0x0600F87D RID: 63613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F87D")]
		[Address(RVA = "0x273D9D4", Offset = "0x273D9D4", VA = "0x7BBCF3D9D4")]
		public static void OnRedeemed(string redeemResult)
		{
		}

		// Token: 0x0600F87E RID: 63614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F87E")]
		[Address(RVA = "0x273DC3C", Offset = "0x273DC3C", VA = "0x7BBCF3DC3C")]
		public static string scanGoogleIAPInventory(int serverId, int roleId)
		{
			return null;
		}

		// Token: 0x0600F87F RID: 63615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F87F")]
		[Address(RVA = "0x273DE34", Offset = "0x273DE34", VA = "0x7BBCF3DE34")]
		public static void onScanGoogleIAPInventoryResult(string result)
		{
		}

		// Token: 0x04011C2A RID: 72746
		[Token(Token = "0x4011C2A")]
		[FieldOffset(Offset = "0x0")]
		private static AndroidJavaClass _IAP;

		// Token: 0x04011C2B RID: 72747
		[Token(Token = "0x4011C2B")]
		private const string PAYMENT_CHANNEL_ID_GOOGLE_PLAY = "201069";

		// Token: 0x02002BD4 RID: 11220
		[Token(Token = "0x2002BD4")]
		[Serializable]
		public enum TransactionStatus
		{
			// Token: 0x04011C2D RID: 72749
			[Token(Token = "0x4011C2D")]
			Created = 6001,
			// Token: 0x04011C2E RID: 72750
			[Token(Token = "0x4011C2E")]
			Opening,
			// Token: 0x04011C2F RID: 72751
			[Token(Token = "0x4011C2F")]
			Opened,
			// Token: 0x04011C30 RID: 72752
			[Token(Token = "0x4011C30")]
			Processed,
			// Token: 0x04011C31 RID: 72753
			[Token(Token = "0x4011C31")]
			Closed,
			// Token: 0x04011C32 RID: 72754
			[Token(Token = "0x4011C32")]
			ClosedWithError
		}

		// Token: 0x02002BD5 RID: 11221
		[Token(Token = "0x2002BD5")]
		[Serializable]
		public enum ResultCode
		{
			// Token: 0x04011C34 RID: 72756
			[Token(Token = "0x4011C34")]
			Success,
			// Token: 0x04011C35 RID: 72757
			[Token(Token = "0x4011C35")]
			Cancel,
			// Token: 0x04011C36 RID: 72758
			[Token(Token = "0x4011C36")]
			Error
		}

		// Token: 0x02002BD6 RID: 11222
		[Token(Token = "0x2002BD6")]
		[Serializable]
		public class TransactionInfo
		{
			// Token: 0x0600F880 RID: 63616 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F880")]
			[Address(RVA = "0x273E734", Offset = "0x273E734", VA = "0x7BBCF3E734")]
			public TransactionInfo()
			{
			}

			// Token: 0x04011C37 RID: 72759
			[Token(Token = "0x4011C37")]
			[FieldOffset(Offset = "0x10")]
			public int status;

			// Token: 0x04011C38 RID: 72760
			[Token(Token = "0x4011C38")]
			[FieldOffset(Offset = "0x14")]
			public int transactionStatus;

			// Token: 0x04011C39 RID: 72761
			[Token(Token = "0x4011C39")]
			[FieldOffset(Offset = "0x18")]
			public int resultCode;

			// Token: 0x04011C3A RID: 72762
			[Token(Token = "0x4011C3A")]
			[FieldOffset(Offset = "0x1C")]
			public int errorCode;

			// Token: 0x04011C3B RID: 72763
			[Token(Token = "0x4011C3B")]
			[FieldOffset(Offset = "0x20")]
			public string transactionId;

			// Token: 0x04011C3C RID: 72764
			[Token(Token = "0x4011C3C")]
			[FieldOffset(Offset = "0x28")]
			public string name;

			// Token: 0x04011C3D RID: 72765
			[Token(Token = "0x4011C3D")]
			[FieldOffset(Offset = "0x30")]
			public string icon;

			// Token: 0x04011C3E RID: 72766
			[Token(Token = "0x4011C3E")]
			[FieldOffset(Offset = "0x38")]
			public int appPoints;

			// Token: 0x04011C3F RID: 72767
			[Token(Token = "0x4011C3F")]
			[FieldOffset(Offset = "0x40")]
			public long rebateId;

			// Token: 0x04011C40 RID: 72768
			[Token(Token = "0x4011C40")]
			[FieldOffset(Offset = "0x48")]
			public int remainingDays;

			// Token: 0x04011C41 RID: 72769
			[Token(Token = "0x4011C41")]
			[FieldOffset(Offset = "0x50")]
			public string transactionError;

			// Token: 0x04011C42 RID: 72770
			[Token(Token = "0x4011C42")]
			[FieldOffset(Offset = "0x58")]
			public string errorMessage;
		}

		// Token: 0x02002BD7 RID: 11223
		[Token(Token = "0x2002BD7")]
		[Serializable]
		public class RebateOptionItem
		{
			// Token: 0x0600F881 RID: 63617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F881")]
			[Address(RVA = "0x273E6A4", Offset = "0x273E6A4", VA = "0x7BBCF3E6A4")]
			public RebateOptionItem()
			{
			}

			// Token: 0x04011C43 RID: 72771
			[Token(Token = "0x4011C43")]
			[FieldOffset(Offset = "0x10")]
			public long rebateId;

			// Token: 0x04011C44 RID: 72772
			[Token(Token = "0x4011C44")]
			[FieldOffset(Offset = "0x18")]
			public int rebateAmount;

			// Token: 0x04011C45 RID: 72773
			[Token(Token = "0x4011C45")]
			[FieldOffset(Offset = "0x1C")]
			public int remainingDays;

			// Token: 0x04011C46 RID: 72774
			[Token(Token = "0x4011C46")]
			[FieldOffset(Offset = "0x20")]
			public int rebateDays;

			// Token: 0x04011C47 RID: 72775
			[Token(Token = "0x4011C47")]
			[FieldOffset(Offset = "0x24")]
			public bool validToPurchase;

			// Token: 0x04011C48 RID: 72776
			[Token(Token = "0x4011C48")]
			[FieldOffset(Offset = "0x25")]
			public bool validToRedeem;

			// Token: 0x04011C49 RID: 72777
			[Token(Token = "0x4011C49")]
			[FieldOffset(Offset = "0x26")]
			public bool owned;

			// Token: 0x04011C4A RID: 72778
			[Token(Token = "0x4011C4A")]
			[FieldOffset(Offset = "0x28")]
			public string name;

			// Token: 0x04011C4B RID: 72779
			[Token(Token = "0x4011C4B")]
			[FieldOffset(Offset = "0x30")]
			public string description;
		}

		// Token: 0x02002BD8 RID: 11224
		[Token(Token = "0x2002BD8")]
		[Serializable]
		public class GetRebateOptionsResult
		{
			// Token: 0x0600F882 RID: 63618 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F882")]
			[Address(RVA = "0x273E694", Offset = "0x273E694", VA = "0x7BBCF3E694")]
			public GetRebateOptionsResult()
			{
			}

			// Token: 0x04011C4C RID: 72780
			[Token(Token = "0x4011C4C")]
			[FieldOffset(Offset = "0x10")]
			public int result;

			// Token: 0x04011C4D RID: 72781
			[Token(Token = "0x4011C4D")]
			[FieldOffset(Offset = "0x18")]
			public SDKIAP_Android.RebateOptionItem[] options;
		}

		// Token: 0x02002BD9 RID: 11225
		[Token(Token = "0x2002BD9")]
		[Serializable]
		public class RedeemResultItem
		{
			// Token: 0x0600F883 RID: 63619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F883")]
			[Address(RVA = "0x273E70C", Offset = "0x273E70C", VA = "0x7BBCF3E70C")]
			public RedeemResultItem()
			{
			}

			// Token: 0x04011C4E RID: 72782
			[Token(Token = "0x4011C4E")]
			[FieldOffset(Offset = "0x10")]
			public long rebateId;

			// Token: 0x04011C4F RID: 72783
			[Token(Token = "0x4011C4F")]
			[FieldOffset(Offset = "0x18")]
			public int appPoint;

			// Token: 0x04011C50 RID: 72784
			[Token(Token = "0x4011C50")]
			[FieldOffset(Offset = "0x1C")]
			public int remainingDays;
		}

		// Token: 0x02002BDA RID: 11226
		[Token(Token = "0x2002BDA")]
		[Serializable]
		public class RedeemResponse
		{
			// Token: 0x0600F884 RID: 63620 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F884")]
			[Address(RVA = "0x273E6FC", Offset = "0x273E6FC", VA = "0x7BBCF3E6FC")]
			public RedeemResponse()
			{
			}

			// Token: 0x04011C51 RID: 72785
			[Token(Token = "0x4011C51")]
			[FieldOffset(Offset = "0x10")]
			public int result;

			// Token: 0x04011C52 RID: 72786
			[Token(Token = "0x4011C52")]
			[FieldOffset(Offset = "0x14")]
			public int totalRedeemed;

			// Token: 0x04011C53 RID: 72787
			[Token(Token = "0x4011C53")]
			[FieldOffset(Offset = "0x18")]
			public SDKIAP_Android.RedeemResultItem[] redeemList;
		}

		// Token: 0x02002BDB RID: 11227
		[Token(Token = "0x2002BDB")]
		[Serializable]
		public class RedeemResult
		{
			// Token: 0x0600F885 RID: 63621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F885")]
			[Address(RVA = "0x273E704", Offset = "0x273E704", VA = "0x7BBCF3E704")]
			public RedeemResult()
			{
			}

			// Token: 0x04011C54 RID: 72788
			[Token(Token = "0x4011C54")]
			[FieldOffset(Offset = "0x10")]
			public int result;

			// Token: 0x04011C55 RID: 72789
			[Token(Token = "0x4011C55")]
			[FieldOffset(Offset = "0x18")]
			public SDKIAP_Android.RedeemResponse response;
		}

		// Token: 0x02002BDC RID: 11228
		[Token(Token = "0x2002BDC")]
		[Serializable]
		public class Denomination
		{
			// Token: 0x0600F886 RID: 63622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F886")]
			[Address(RVA = "0x273E68C", Offset = "0x273E68C", VA = "0x7BBCF3E68C")]
			public Denomination()
			{
			}

			// Token: 0x04011C56 RID: 72790
			[Token(Token = "0x4011C56")]
			[FieldOffset(Offset = "0x10")]
			public int appPoints;

			// Token: 0x04011C57 RID: 72791
			[Token(Token = "0x4011C57")]
			[FieldOffset(Offset = "0x18")]
			public string iconUrl;

			// Token: 0x04011C58 RID: 72792
			[Token(Token = "0x4011C58")]
			[FieldOffset(Offset = "0x20")]
			public bool isPromo;

			// Token: 0x04011C59 RID: 72793
			[Token(Token = "0x4011C59")]
			[FieldOffset(Offset = "0x28")]
			public string itemId;

			// Token: 0x04011C5A RID: 72794
			[Token(Token = "0x4011C5A")]
			[FieldOffset(Offset = "0x30")]
			public string name;

			// Token: 0x04011C5B RID: 72795
			[Token(Token = "0x4011C5B")]
			[FieldOffset(Offset = "0x38")]
			public string price;

			// Token: 0x04011C5C RID: 72796
			[Token(Token = "0x4011C5C")]
			[FieldOffset(Offset = "0x40")]
			public int promoPoints;

			// Token: 0x04011C5D RID: 72797
			[Token(Token = "0x4011C5D")]
			[FieldOffset(Offset = "0x44")]
			public int rebateId;

			// Token: 0x04011C5E RID: 72798
			[Token(Token = "0x4011C5E")]
			[FieldOffset(Offset = "0x48")]
			public SDKIAP_Android.Subscription subscription;
		}

		// Token: 0x02002BDD RID: 11229
		[Token(Token = "0x2002BDD")]
		[Serializable]
		public class Subscription
		{
			// Token: 0x0600F887 RID: 63623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F887")]
			[Address(RVA = "0x273E72C", Offset = "0x273E72C", VA = "0x7BBCF3E72C")]
			public Subscription()
			{
			}

			// Token: 0x04011C5F RID: 72799
			[Token(Token = "0x4011C5F")]
			[FieldOffset(Offset = "0x10")]
			public int period;

			// Token: 0x04011C60 RID: 72800
			[Token(Token = "0x4011C60")]
			[FieldOffset(Offset = "0x14")]
			public int status;

			// Token: 0x04011C61 RID: 72801
			[Token(Token = "0x4011C61")]
			[FieldOffset(Offset = "0x18")]
			public int lastPaymentTime;

			// Token: 0x04011C62 RID: 72802
			[Token(Token = "0x4011C62")]
			[FieldOffset(Offset = "0x20")]
			public long gracePeriodExpiryTime;

			// Token: 0x04011C63 RID: 72803
			[Token(Token = "0x4011C63")]
			[FieldOffset(Offset = "0x28")]
			public long onHoldSince;
		}

		// Token: 0x02002BDE RID: 11230
		[Token(Token = "0x2002BDE")]
		[Serializable]
		public class Channel
		{
			// Token: 0x0600F888 RID: 63624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F888")]
			[Address(RVA = "0x273E684", Offset = "0x273E684", VA = "0x7BBCF3E684")]
			public Channel()
			{
			}

			// Token: 0x04011C64 RID: 72804
			[Token(Token = "0x4011C64")]
			[FieldOffset(Offset = "0x10")]
			public int category;

			// Token: 0x04011C65 RID: 72805
			[Token(Token = "0x4011C65")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x04011C66 RID: 72806
			[Token(Token = "0x4011C66")]
			[FieldOffset(Offset = "0x20")]
			public string channelId;

			// Token: 0x04011C67 RID: 72807
			[Token(Token = "0x4011C67")]
			[FieldOffset(Offset = "0x28")]
			public float discount;

			// Token: 0x04011C68 RID: 72808
			[Token(Token = "0x4011C68")]
			[FieldOffset(Offset = "0x30")]
			public string description;

			// Token: 0x04011C69 RID: 72809
			[Token(Token = "0x4011C69")]
			[FieldOffset(Offset = "0x38")]
			public int flag;

			// Token: 0x04011C6A RID: 72810
			[Token(Token = "0x4011C6A")]
			[FieldOffset(Offset = "0x40")]
			public string iconUrl;

			// Token: 0x04011C6B RID: 72811
			[Token(Token = "0x4011C6B")]
			[FieldOffset(Offset = "0x48")]
			public SDKIAP_Android.Denomination[] items;
		}

		// Token: 0x02002BDF RID: 11231
		[Token(Token = "0x2002BDF")]
		[Serializable]
		public class LoadPaymentOptionsResult
		{
			// Token: 0x0600F889 RID: 63625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F889")]
			[Address(RVA = "0x273E69C", Offset = "0x273E69C", VA = "0x7BBCF3E69C")]
			public LoadPaymentOptionsResult()
			{
			}

			// Token: 0x04011C6C RID: 72812
			[Token(Token = "0x4011C6C")]
			[FieldOffset(Offset = "0x10")]
			public SDKIAP_Android.Channel[] paymentChannels;

			// Token: 0x04011C6D RID: 72813
			[Token(Token = "0x4011C6D")]
			[FieldOffset(Offset = "0x18")]
			public string exception;
		}

		// Token: 0x02002BE0 RID: 11232
		[Token(Token = "0x2002BE0")]
		[Serializable]
		public class ScanGoogleIAPInventoryResult
		{
			// Token: 0x0600F88A RID: 63626 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F88A")]
			[Address(RVA = "0x273E714", Offset = "0x273E714", VA = "0x7BBCF3E714")]
			public ScanGoogleIAPInventoryResult()
			{
			}

			// Token: 0x04011C6E RID: 72814
			[Token(Token = "0x4011C6E")]
			[FieldOffset(Offset = "0x10")]
			public SDKIAP_Android.ScanGoogleIAPInventoryResult.Result[] results;

			// Token: 0x02002BE1 RID: 11233
			[Token(Token = "0x2002BE1")]
			[Serializable]
			public class Result
			{
				// Token: 0x0600F88B RID: 63627 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600F88B")]
				[Address(RVA = "0x273E71C", Offset = "0x273E71C", VA = "0x7BBCF3E71C")]
				public Result()
				{
				}

				// Token: 0x04011C6F RID: 72815
				[Token(Token = "0x4011C6F")]
				[FieldOffset(Offset = "0x10")]
				public string error;

				// Token: 0x04011C70 RID: 72816
				[Token(Token = "0x4011C70")]
				[FieldOffset(Offset = "0x18")]
				public bool success;

				// Token: 0x04011C71 RID: 72817
				[Token(Token = "0x4011C71")]
				[FieldOffset(Offset = "0x20")]
				public SDKIAP_Android.ScanGoogleIAPInventoryResult.Result.ItemInfo item;

				// Token: 0x02002BE2 RID: 11234
				[Token(Token = "0x2002BE2")]
				[Serializable]
				public class ItemInfo
				{
					// Token: 0x0600F88C RID: 63628 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600F88C")]
					[Address(RVA = "0x273E724", Offset = "0x273E724", VA = "0x7BBCF3E724")]
					public ItemInfo()
					{
					}

					// Token: 0x04011C72 RID: 72818
					[Token(Token = "0x4011C72")]
					[FieldOffset(Offset = "0x10")]
					public bool isPromotion;

					// Token: 0x04011C73 RID: 72819
					[Token(Token = "0x4011C73")]
					[FieldOffset(Offset = "0x18")]
					public string itemName;

					// Token: 0x04011C74 RID: 72820
					[Token(Token = "0x4011C74")]
					[FieldOffset(Offset = "0x20")]
					public int amount;

					// Token: 0x04011C75 RID: 72821
					[Token(Token = "0x4011C75")]
					[FieldOffset(Offset = "0x28")]
					public string itemSku;
				}
			}
		}

		// Token: 0x02002BE3 RID: 11235
		[Token(Token = "0x2002BE3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FF7D4", Offset = "0x10FF7D4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600F88E RID: 63630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F88E")]
			[Address(RVA = "0x273E3E8", Offset = "0x273E3E8", VA = "0x7BBCF3E3E8")]
			public <>c()
			{
			}

			// Token: 0x0600F88F RID: 63631 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F88F")]
			[Address(RVA = "0x273E3F0", Offset = "0x273E3F0", VA = "0x7BBCF3E3F0")]
			internal string <GetRebateOptions>b__18_0(long id)
			{
				return null;
			}

			// Token: 0x0600F890 RID: 63632 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F890")]
			[Address(RVA = "0x273E418", Offset = "0x273E418", VA = "0x7BBCF3E418")]
			internal SDKIAP.RebateOption <OnGetRebateOptions>b__19_0(SDKIAP_Android.RebateOptionItem input)
			{
				return null;
			}

			// Token: 0x0600F891 RID: 63633 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F891")]
			[Address(RVA = "0x273E574", Offset = "0x273E574", VA = "0x7BBCF3E574")]
			internal string <LoadPaymentOptions>b__22_0(int id)
			{
				return null;
			}

			// Token: 0x0600F892 RID: 63634 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F892")]
			[Address(RVA = "0x273E59C", Offset = "0x273E59C", VA = "0x7BBCF3E59C")]
			internal string <LoadPaymentOptions>b__22_1(long id)
			{
				return null;
			}

			// Token: 0x0600F893 RID: 63635 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F893")]
			[Address(RVA = "0x273E5C4", Offset = "0x273E5C4", VA = "0x7BBCF3E5C4")]
			internal SDKIAP.RebateRedeemResult <OnRedeemed>b__32_0(SDKIAP_Android.RedeemResultItem input)
			{
				return null;
			}

			// Token: 0x04011C76 RID: 72822
			[Token(Token = "0x4011C76")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SDKIAP_Android.<>c <>9;

			// Token: 0x04011C77 RID: 72823
			[Token(Token = "0x4011C77")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<long, string> <>9__18_0;

			// Token: 0x04011C78 RID: 72824
			[Token(Token = "0x4011C78")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<SDKIAP_Android.RebateOptionItem, SDKIAP.RebateOption> <>9__19_0;

			// Token: 0x04011C79 RID: 72825
			[Token(Token = "0x4011C79")]
			[FieldOffset(Offset = "0x18")]
			public static Converter<int, string> <>9__22_0;

			// Token: 0x04011C7A RID: 72826
			[Token(Token = "0x4011C7A")]
			[FieldOffset(Offset = "0x20")]
			public static Converter<long, string> <>9__22_1;

			// Token: 0x04011C7B RID: 72827
			[Token(Token = "0x4011C7B")]
			[FieldOffset(Offset = "0x28")]
			public static Converter<SDKIAP_Android.RedeemResultItem, SDKIAP.RebateRedeemResult> <>9__32_0;
		}
	}
}
