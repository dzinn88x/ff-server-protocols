using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GarenaMSDK;
using Il2CppDummyDll;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C82 RID: 7298
	[Token(Token = "0x2001C82")]
	public static class PayUtility
	{
		// Token: 0x06009F1A RID: 40730 RVA: 0x000297A8 File Offset: 0x000279A8
		[Token(Token = "0x6009F1A")]
		[Address(RVA = "0x203E6CC", Offset = "0x203E6CC", VA = "0x7BBC83E6CC")]
		internal static DateTime SecondsAfterApoch(long seconds)
		{
			return default(DateTime);
		}

		// Token: 0x06009F1B RID: 40731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F1B")]
		[Address(RVA = "0x203E758", Offset = "0x203E758", VA = "0x7BBC83E758")]
		public static string USD(float price)
		{
			return null;
		}

		// Token: 0x06009F1C RID: 40732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F1C")]
		[Address(RVA = "0x203E7DC", Offset = "0x203E7DC", VA = "0x7BBC83E7DC")]
		public static string USD(string price)
		{
			return null;
		}

		// Token: 0x06009F1D RID: 40733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F1D")]
		[Address(RVA = "0x203E830", Offset = "0x203E830", VA = "0x7BBC83E830")]
		private static void Uninit()
		{
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06009F1E RID: 40734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A76")]
		private static string IAPItemIdentifierTemplate
		{
			[Token(Token = "0x6009F1E")]
			[Address(RVA = "0x203E898", Offset = "0x203E898", VA = "0x7BBC83E898")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009F1F RID: 40735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F1F")]
		[Address(RVA = "0x203E8E0", Offset = "0x203E8E0", VA = "0x7BBC83E8E0")]
		private static void Init()
		{
		}

		// Token: 0x06009F20 RID: 40736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F20")]
		[Address(RVA = "0x203EFCC", Offset = "0x203EFCC", VA = "0x7BBC83EFCC")]
		public static void LogVerbose(string log)
		{
		}

		// Token: 0x06009F21 RID: 40737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F21")]
		[Address(RVA = "0x203F068", Offset = "0x203F068", VA = "0x7BBC83F068")]
		private static void Log(string log)
		{
		}

		// Token: 0x06009F22 RID: 40738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F22")]
		[Address(RVA = "0x203F0D0", Offset = "0x203F0D0", VA = "0x7BBC83F0D0")]
		private static void LogError(string log)
		{
		}

		// Token: 0x06009F23 RID: 40739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F23")]
		[Address(RVA = "0x203F138", Offset = "0x203F138", VA = "0x7BBC83F138")]
		public static void Register(PayUtility.PaymentDelegate del)
		{
		}

		// Token: 0x06009F24 RID: 40740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F24")]
		[Address(RVA = "0x203F1F0", Offset = "0x203F1F0", VA = "0x7BBC83F1F0")]
		public static void Unregister(PayUtility.PaymentDelegate del)
		{
		}

		// Token: 0x06009F25 RID: 40741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F25")]
		[Address(RVA = "0x203F314", Offset = "0x203F314", VA = "0x7BBC83F314")]
		private static PayUtility.PaymentDelegate.ProductPurchasedResult Convert(SDKIAPTaskResult result)
		{
			return null;
		}

		// Token: 0x06009F26 RID: 40742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F26")]
		[Address(RVA = "0x203F414", Offset = "0x203F414", VA = "0x7BBC83F414")]
		private static void NotifyDelegates_ProductPurchased(SDKIAPTaskInfo info, SDKIAPTaskResult result, string productIdentifier, long rebateId)
		{
		}

		// Token: 0x06009F27 RID: 40743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F27")]
		[Address(RVA = "0x2040428", Offset = "0x2040428", VA = "0x7BBC840428")]
		private static void ClearTransactions()
		{
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06009F28 RID: 40744 RVA: 0x000297C0 File Offset: 0x000279C0
		// (set) Token: 0x06009F29 RID: 40745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A77")]
		public static bool ScanningIAPInventory
		{
			[Token(Token = "0x6009F28")]
			[Address(RVA = "0x2040578", Offset = "0x2040578", VA = "0x7BBC840578")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114547C", Offset = "0x114547C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6009F29")]
			[Address(RVA = "0x20405E0", Offset = "0x20405E0", VA = "0x7BBC8405E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114548C", Offset = "0x114548C")]
			private set
			{
			}
		}

		// Token: 0x06009F2A RID: 40746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F2A")]
		[Address(RVA = "0x2040650", Offset = "0x2040650", VA = "0x7BBC840650")]
		private static void ScanIAPInventory()
		{
		}

		// Token: 0x06009F2B RID: 40747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F2B")]
		[Address(RVA = "0x2040858", Offset = "0x2040858", VA = "0x7BBC840858")]
		public static void OnApplicationPause(bool paused)
		{
		}

		// Token: 0x06009F2C RID: 40748 RVA: 0x000297D8 File Offset: 0x000279D8
		[Token(Token = "0x6009F2C")]
		[Address(RVA = "0x203EDAC", Offset = "0x203EDAC", VA = "0x7BBC83EDAC")]
		public static uint ExtractProductId(string productIdentifier)
		{
			return 0U;
		}

		// Token: 0x06009F2D RID: 40749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F2D")]
		[Address(RVA = "0x203EF4C", Offset = "0x203EF4C", VA = "0x7BBC83EF4C")]
		public static string FormatProductIdentifier(int productId)
		{
			return null;
		}

		// Token: 0x06009F2E RID: 40750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F2E")]
		[Address(RVA = "0x204085C", Offset = "0x204085C", VA = "0x7BBC84085C")]
		public static PayItemData GetFetchedProduct(int productId)
		{
			return null;
		}

		// Token: 0x06009F2F RID: 40751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F2F")]
		[Address(RVA = "0x203FAE4", Offset = "0x203FAE4", VA = "0x7BBC83FAE4")]
		public static PayItemData GetFetchedProduct(string productIdentifier)
		{
			return null;
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06009F30 RID: 40752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A78")]
		public static Dictionary<long, RebateItemData> RebateItems
		{
			[Token(Token = "0x6009F30")]
			[Address(RVA = "0x20408C4", Offset = "0x20408C4", VA = "0x7BBC8408C4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06009F31 RID: 40753 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009F32 RID: 40754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A79")]
		private static PaymentAction _LastPaymentAction
		{
			[Token(Token = "0x6009F31")]
			[Address(RVA = "0x204092C", Offset = "0x204092C", VA = "0x7BBC84092C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114549C", Offset = "0x114549C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6009F32")]
			[Address(RVA = "0x2040994", Offset = "0x2040994", VA = "0x7BBC840994")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11454AC", Offset = "0x11454AC")]
			set
			{
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06009F33 RID: 40755 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009F34 RID: 40756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A7A")]
		public static string LastPaymentProductIdentifier
		{
			[Token(Token = "0x6009F33")]
			[Address(RVA = "0x203FA7C", Offset = "0x203FA7C", VA = "0x7BBC83FA7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11454BC", Offset = "0x11454BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6009F34")]
			[Address(RVA = "0x2040A00", Offset = "0x2040A00", VA = "0x7BBC840A00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11454CC", Offset = "0x11454CC")]
			private set
			{
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06009F35 RID: 40757 RVA: 0x000297F0 File Offset: 0x000279F0
		// (set) Token: 0x06009F36 RID: 40758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A7B")]
		public static bool IsLoggedIn
		{
			[Token(Token = "0x6009F35")]
			[Address(RVA = "0x20404B0", Offset = "0x20404B0", VA = "0x7BBC8404B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11454DC", Offset = "0x11454DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6009F36")]
			[Address(RVA = "0x2040A6C", Offset = "0x2040A6C", VA = "0x7BBC840A6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11454EC", Offset = "0x11454EC")]
			private set
			{
			}
		}

		// Token: 0x06009F37 RID: 40759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F37")]
		[Address(RVA = "0x2040ADC", Offset = "0x2040ADC", VA = "0x7BBC840ADC")]
		public static void AfterLogoutSDK()
		{
		}

		// Token: 0x06009F38 RID: 40760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F38")]
		[Address(RVA = "0x2040B40", Offset = "0x2040B40", VA = "0x7BBC840B40")]
		public static void AfterLoginSDK()
		{
		}

		// Token: 0x06009F39 RID: 40761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F39")]
		[Address(RVA = "0x2040D88", Offset = "0x2040D88", VA = "0x7BBC840D88")]
		public static void AfterLoginServer()
		{
		}

		// Token: 0x06009F3A RID: 40762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F3A")]
		[Address(RVA = "0x20415A8", Offset = "0x20415A8", VA = "0x7BBC8415A8")]
		public static void AfterLogoutServer()
		{
		}

		// Token: 0x06009F3B RID: 40763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F3B")]
		[Address(RVA = "0x2041484", Offset = "0x2041484", VA = "0x7BBC841484")]
		private static void UpdateTips()
		{
		}

		// Token: 0x06009F3C RID: 40764 RVA: 0x00029808 File Offset: 0x00027A08
		[Token(Token = "0x6009F3C")]
		[Address(RVA = "0x2040518", Offset = "0x2040518", VA = "0x7BBC840518")]
		public static bool IsSupportIAP()
		{
			return default(bool);
		}

		// Token: 0x06009F3D RID: 40765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F3D")]
		[Address(RVA = "0x20418A8", Offset = "0x20418A8", VA = "0x7BBC8418A8")]
		private static string GetMessageForNotSupportingIAP()
		{
			return null;
		}

		// Token: 0x06009F3E RID: 40766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F3E")]
		[Address(RVA = "0x2041954", Offset = "0x2041954", VA = "0x7BBC841954")]
		public static void ShowNotSupportingIAPMessageBox(uint gopos, bool standard = false)
		{
		}

		// Token: 0x06009F3F RID: 40767 RVA: 0x00029820 File Offset: 0x00027A20
		[Token(Token = "0x6009F3F")]
		[Address(RVA = "0x2041D6C", Offset = "0x2041D6C", VA = "0x7BBC841D6C")]
		public static bool SupportSubscription()
		{
			return default(bool);
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06009F40 RID: 40768 RVA: 0x00029838 File Offset: 0x00027A38
		[Token(Token = "0x17000A7C")]
		public static bool Pending
		{
			[Token(Token = "0x6009F40")]
			[Address(RVA = "0x2041DC8", Offset = "0x2041DC8", VA = "0x7BBC841DC8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009F41 RID: 40769 RVA: 0x00029850 File Offset: 0x00027A50
		[Token(Token = "0x6009F41")]
		[Address(RVA = "0x203FBB4", Offset = "0x203FBB4", VA = "0x7BBC83FBB4")]
		private static bool UpdateIAPItems(SDKIAPTaskInfo info, string[] itemIdentifiers, long[] rebateIds)
		{
			return default(bool);
		}

		// Token: 0x06009F42 RID: 40770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F42")]
		[Address(RVA = "0x2041E28", Offset = "0x2041E28", VA = "0x7BBC841E28")]
		private static void OnAllIAPItemsUpdated(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.IAPItem[] items)
		{
		}

		// Token: 0x06009F43 RID: 40771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F43")]
		[Address(RVA = "0x2042CB8", Offset = "0x2042CB8", VA = "0x7BBC842CB8")]
		private static void OnSomeIAPItemsUpdated(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.IAPItem[] items)
		{
		}

		// Token: 0x06009F44 RID: 40772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F44")]
		[Address(RVA = "0x2041EA8", Offset = "0x2041EA8", VA = "0x7BBC841EA8")]
		private static void ApplyUpdatedIAPItems(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.IAPItem[] items, bool replace)
		{
		}

		// Token: 0x06009F45 RID: 40773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F45")]
		[Address(RVA = "0x2042D38", Offset = "0x2042D38", VA = "0x7BBC842D38")]
		private static PayItemData ParsePayItemData(SDKIAP.IAPItem iapItem)
		{
			return null;
		}

		// Token: 0x06009F46 RID: 40774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F46")]
		[Address(RVA = "0x20417A8", Offset = "0x20417A8", VA = "0x7BBC8417A8")]
		private static void UpdateIAPProductTips()
		{
		}

		// Token: 0x06009F47 RID: 40775 RVA: 0x00029868 File Offset: 0x00027A68
		[Token(Token = "0x6009F47")]
		[Address(RVA = "0x2040280", Offset = "0x2040280", VA = "0x7BBC840280")]
		private static bool UpdateRebateItems(SDKIAPTaskInfo info, long[] rebateIds)
		{
			return default(bool);
		}

		// Token: 0x06009F48 RID: 40776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F48")]
		[Address(RVA = "0x2042FC4", Offset = "0x2042FC4", VA = "0x7BBC842FC4")]
		private static void OnAllRebateOptionsUpdated(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.RebateOption[] rebateOptions)
		{
		}

		// Token: 0x06009F49 RID: 40777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F49")]
		[Address(RVA = "0x204388C", Offset = "0x204388C", VA = "0x7BBC84388C")]
		private static void OnSomeRebateOptionsUpdated(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.RebateOption[] rebateOptions)
		{
		}

		// Token: 0x06009F4A RID: 40778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F4A")]
		[Address(RVA = "0x2043044", Offset = "0x2043044", VA = "0x7BBC843044")]
		private static void ApplyUpdatedRebateItems(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.RebateOption[] rebateOptions, bool replace)
		{
		}

		// Token: 0x06009F4B RID: 40779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F4B")]
		[Address(RVA = "0x204390C", Offset = "0x204390C", VA = "0x7BBC84390C")]
		private static RebateItemData ParseRebateItemData(SDKIAP.RebateOption rebateOption)
		{
			return null;
		}

		// Token: 0x06009F4C RID: 40780 RVA: 0x00029880 File Offset: 0x00027A80
		[Token(Token = "0x6009F4C")]
		[Address(RVA = "0x2043A6C", Offset = "0x2043A6C", VA = "0x7BBC843A6C")]
		private static bool ClearLastIAPAction()
		{
			return default(bool);
		}

		// Token: 0x06009F4D RID: 40781 RVA: 0x00029898 File Offset: 0x00027A98
		[Token(Token = "0x6009F4D")]
		[Address(RVA = "0x2043AFC", Offset = "0x2043AFC", VA = "0x7BBC843AFC")]
		private static bool RetryLastIAPAction()
		{
			return default(bool);
		}

		// Token: 0x06009F4E RID: 40782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F4E")]
		[Address(RVA = "0x20446C4", Offset = "0x20446C4", VA = "0x7BBC8446C4")]
		public static void RemindSubscriptionGracePeriod(PayUtility.SubscriptionGracePeriodReminderInfo info)
		{
		}

		// Token: 0x06009F4F RID: 40783 RVA: 0x000298B0 File Offset: 0x00027AB0
		[Token(Token = "0x6009F4F")]
		[Address(RVA = "0x2044784", Offset = "0x2044784", VA = "0x7BBC844784")]
		public static bool CanTryFixingGracePeriod()
		{
			return default(bool);
		}

		// Token: 0x06009F50 RID: 40784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F50")]
		[Address(RVA = "0x20447FC", Offset = "0x20447FC", VA = "0x7BBC8447FC")]
		public static void TryFixingGracePeriod()
		{
		}

		// Token: 0x06009F51 RID: 40785 RVA: 0x000298C8 File Offset: 0x00027AC8
		[Token(Token = "0x6009F51")]
		[Address(RVA = "0x2044890", Offset = "0x2044890", VA = "0x7BBC844890")]
		public static bool CanTryFixingOnHold()
		{
			return default(bool);
		}

		// Token: 0x06009F52 RID: 40786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F52")]
		[Address(RVA = "0x2044908", Offset = "0x2044908", VA = "0x7BBC844908")]
		public static void TryFixingOnHold()
		{
		}

		// Token: 0x06009F53 RID: 40787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F53")]
		[Address(RVA = "0x204499C", Offset = "0x204499C", VA = "0x7BBC84499C")]
		private static string IAPFailureSignature(string item_identifier, int rebate_id, ErrorCode errorCode)
		{
			return null;
		}

		// Token: 0x06009F54 RID: 40788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F54")]
		[Address(RVA = "0x2044FD8", Offset = "0x2044FD8", VA = "0x7BBC844FD8")]
		private static void ShowPaymentFailureMessageBox(SDKIAPTaskResult result, string item_identifier, int rebate_id, [Optional] Action onCancel)
		{
		}

		// Token: 0x06009F55 RID: 40789 RVA: 0x000298E0 File Offset: 0x00027AE0
		[Token(Token = "0x6009F55")]
		[Address(RVA = "0x2044270", Offset = "0x2044270", VA = "0x7BBC844270")]
		private static bool PurchaseProduct(SDKIAPTaskInfo info, [Optional] string productIdentifier, int quantity = 1)
		{
			return default(bool);
		}

		// Token: 0x06009F56 RID: 40790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F56")]
		[Address(RVA = "0x2045A7C", Offset = "0x2045A7C", VA = "0x7BBC845A7C")]
		private static void OnPurchaseProductSuccess(SDKIAPTaskInfo info, SDKIAPTaskResult result, string productIdentifier)
		{
		}

		// Token: 0x06009F57 RID: 40791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F57")]
		[Address(RVA = "0x2046184", Offset = "0x2046184", VA = "0x7BBC846184")]
		private static void OnPurchaseProductFailure(SDKIAPTaskInfo info, SDKIAPTaskResult result, string productIdentifier)
		{
		}

		// Token: 0x06009F58 RID: 40792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F58")]
		[Address(RVA = "0x20461FC", Offset = "0x20461FC", VA = "0x7BBC8461FC")]
		private static void CacheOfflineTransaction(string productIdentifier)
		{
		}

		// Token: 0x06009F59 RID: 40793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F59")]
		[Address(RVA = "0x2046408", Offset = "0x2046408", VA = "0x7BBC846408")]
		private static void ClearCachedOfflineTransaction(string productIdentifier)
		{
		}

		// Token: 0x06009F5A RID: 40794 RVA: 0x000298F8 File Offset: 0x00027AF8
		[Token(Token = "0x6009F5A")]
		[Address(RVA = "0x20457BC", Offset = "0x20457BC", VA = "0x7BBC8457BC")]
		private static bool CheckHasCachedOfflineTransaction(string productIdentifier)
		{
			return default(bool);
		}

		// Token: 0x06009F5B RID: 40795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F5B")]
		[Address(RVA = "0x2045B7C", Offset = "0x2045B7C", VA = "0x7BBC845B7C")]
		private static void OnPurchasedProduct(SDKIAPTaskInfo info, SDKIAPTaskResult result, string productIdentifier, bool success)
		{
		}

		// Token: 0x06009F5C RID: 40796 RVA: 0x00029910 File Offset: 0x00027B10
		[Token(Token = "0x6009F5C")]
		[Address(RVA = "0x2046590", Offset = "0x2046590", VA = "0x7BBC846590")]
		public static bool ShouldOverrideLocalPaymentItem(ErrorCode errorCode)
		{
			return default(bool);
		}

		// Token: 0x06009F5D RID: 40797 RVA: 0x00029928 File Offset: 0x00027B28
		[Token(Token = "0x6009F5D")]
		[Address(RVA = "0x2045A2C", Offset = "0x2045A2C", VA = "0x7BBC845A2C")]
		public static bool ShouldPromptRetry(ErrorCode errorCode)
		{
			return default(bool);
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06009F5E RID: 40798 RVA: 0x00029940 File Offset: 0x00027B40
		[Token(Token = "0x17000A7D")]
		private static bool ShowIAPFailureSignature
		{
			[Token(Token = "0x6009F5E")]
			[Address(RVA = "0x2044F1C", Offset = "0x2044F1C", VA = "0x7BBC844F1C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009F5F RID: 40799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F5F")]
		[Address(RVA = "0x20455DC", Offset = "0x20455DC", VA = "0x7BBC8455DC")]
		public static string ErrorCodeToString_IAP(int errorCode, string errorMessage = "")
		{
			return null;
		}

		// Token: 0x06009F60 RID: 40800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F60")]
		[Address(RVA = "0x20465AC", Offset = "0x20465AC", VA = "0x7BBC8465AC")]
		public static string GetPaymentNotificationString(InventoryTopupNtf topupNotification)
		{
			return null;
		}

		// Token: 0x06009F61 RID: 40801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F61")]
		[Address(RVA = "0x2046920", Offset = "0x2046920", VA = "0x7BBC846920")]
		public static string SubscriptionPeriodLocalizationKey(SubscriptionPeriod sp)
		{
			return null;
		}

		// Token: 0x06009F62 RID: 40802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F62")]
		[Address(RVA = "0x204699C", Offset = "0x204699C", VA = "0x7BBC84699C")]
		public static void ShowSubscriptionHint(PayUtility.SubscriptionHintOption option)
		{
		}

		// Token: 0x06009F63 RID: 40803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F63")]
		[Address(RVA = "0x2047170", Offset = "0x2047170", VA = "0x7BBC847170")]
		public static void PromptOnInsufficientDiamonds(UINavigationUtil.UINavigationFrom from, string msg = "", string title = "", string okText = "")
		{
		}

		// Token: 0x06009F64 RID: 40804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F64")]
		[Address(RVA = "0x2041A70", Offset = "0x2041A70", VA = "0x7BBC841A70")]
		public static void ShowPaymentMessageBox(string message, string title = "", string okText = "", [Optional] Action onOK, [Optional] Action onCancel, string note = "", UIPopupMessageBoxController.EButtonStyle buttonStyle = UIPopupMessageBoxController.EButtonStyle.None)
		{
		}

		// Token: 0x06009F65 RID: 40805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F65")]
		[Address(RVA = "0x2047408", Offset = "0x2047408", VA = "0x7BBC847408")]
		public static void ShowPaymentMessageBoxNotUseSpecialDepth(string message, string title = "", string okText = "", [Optional] Action onOK, [Optional] Action onCancel, string note = "", UIPopupMessageBox2Controller.EButtonStyle buttonStyle = UIPopupMessageBox2Controller.EButtonStyle.None)
		{
		}

		// Token: 0x06009F66 RID: 40806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F66")]
		[Address(RVA = "0x2047704", Offset = "0x2047704", VA = "0x7BBC847704")]
		private static void OnPurchaseRebateItemSuccess(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAPManager.RebateOptionPurchaseResult purchaseResult)
		{
		}

		// Token: 0x06009F67 RID: 40807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F67")]
		[Address(RVA = "0x2047B64", Offset = "0x2047B64", VA = "0x7BBC847B64")]
		private static void OnPurchaseRebateItemFailure(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAPManager.RebateOptionPurchaseResult purchaseResult)
		{
		}

		// Token: 0x06009F68 RID: 40808 RVA: 0x00029958 File Offset: 0x00027B58
		[Token(Token = "0x6009F68")]
		[Address(RVA = "0x2043C6C", Offset = "0x2043C6C", VA = "0x7BBC843C6C")]
		private static bool PurchaseRebateOption(SDKIAPTaskInfo info, string productIdentifier, long rebateId)
		{
			return default(bool);
		}

		// Token: 0x06009F69 RID: 40809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F69")]
		[Address(RVA = "0x2047E9C", Offset = "0x2047E9C", VA = "0x7BBC847E9C")]
		public static void RedeemRebateOption(int rebateId)
		{
		}

		// Token: 0x06009F6A RID: 40810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F6A")]
		[Address(RVA = "0x20482F0", Offset = "0x20482F0", VA = "0x7BBC8482F0")]
		private static void OnRebateOptionRedeemed(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.RebateRedeemResult[] results)
		{
		}

		// Token: 0x06009F6B RID: 40811 RVA: 0x00029970 File Offset: 0x00027B70
		[Token(Token = "0x6009F6B")]
		[Address(RVA = "0x20489A8", Offset = "0x20489A8", VA = "0x7BBC8489A8")]
		public static int GetRebateNextResetTime()
		{
			return 0;
		}

		// Token: 0x0400A60B RID: 42507
		[Token(Token = "0x400A60B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly DateTime APOCH_UTC;

		// Token: 0x0400A60C RID: 42508
		[Token(Token = "0x400A60C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _Inited;

		// Token: 0x0400A60D RID: 42509
		[Token(Token = "0x400A60D")]
		private const string IAP_ITEM_IDENTIFIER_TEMPLATE_GOOGLE_PLAY = "freefire.diamond.{0}";

		// Token: 0x0400A60E RID: 42510
		[Token(Token = "0x400A60E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<string, PayUtility.PaymentDelegate> _PaymentDelegates;

		// Token: 0x0400A60F RID: 42511
		[Token(Token = "0x400A60F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FBCC", Offset = "0x112FBCC")]
		private static bool <ScanningIAPInventory>k__BackingField;

		// Token: 0x0400A610 RID: 42512
		[Token(Token = "0x400A610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Dictionary<string, PayItemData> _FetchedProductsByIdentifier;

		// Token: 0x0400A611 RID: 42513
		[Token(Token = "0x400A611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Dictionary<long, RebateItemData> _RebateItems;

		// Token: 0x0400A612 RID: 42514
		[Token(Token = "0x400A612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FBDC", Offset = "0x112FBDC")]
		private static PaymentAction <_LastPaymentAction>k__BackingField;

		// Token: 0x0400A613 RID: 42515
		[Token(Token = "0x400A613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FBEC", Offset = "0x112FBEC")]
		private static string <LastPaymentProductIdentifier>k__BackingField;

		// Token: 0x0400A614 RID: 42516
		[Token(Token = "0x400A614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FBFC", Offset = "0x112FBFC")]
		private static bool <IsLoggedIn>k__BackingField;

		// Token: 0x0400A615 RID: 42517
		[Token(Token = "0x400A615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static SDKType LastSDKType;

		// Token: 0x0400A616 RID: 42518
		[Token(Token = "0x400A616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static string LastSDKID;

		// Token: 0x0400A617 RID: 42519
		[Token(Token = "0x400A617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static bool SDKAccountChanged;

		// Token: 0x0400A618 RID: 42520
		[Token(Token = "0x400A618")]
		private const string PLAYER_PREFS_KEY_OFFLINE_TRANSACTIONS = "OfflineTransactions";

		// Token: 0x0400A619 RID: 42521
		[Token(Token = "0x400A619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static Dictionary<ErrorCode, string> _PaymentErrorCodeToLocKey;

		// Token: 0x0400A61A RID: 42522
		[Token(Token = "0x400A61A")]
		private const int SecondsInDay = 86400;

		// Token: 0x0400A61B RID: 42523
		[Token(Token = "0x400A61B")]
		private const int RebateRedeemResetSecondsInDay_UTC = 68400;

		// Token: 0x02001C83 RID: 7299
		[Token(Token = "0x2001C83")]
		public abstract class PaymentDelegate
		{
			// Token: 0x17000A7E RID: 2686
			// (get) Token: 0x06009F6D RID: 40813
			[Token(Token = "0x17000A7E")]
			public abstract string Name { [Token(Token = "0x6009F6D")] get; }

			// Token: 0x17000A7F RID: 2687
			// (get) Token: 0x06009F6E RID: 40814 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06009F6F RID: 40815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A7F")]
			public virtual string[] ProductsInDemand
			{
				[Token(Token = "0x6009F6E")]
				[Address(RVA = "0x204A4FC", Offset = "0x204A4FC", VA = "0x7BBC84A4FC", Slot = "5")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11454FC", Offset = "0x11454FC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6009F6F")]
				[Address(RVA = "0x204A504", Offset = "0x204A504", VA = "0x7BBC84A504", Slot = "6")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114550C", Offset = "0x114550C")]
				set
				{
				}
			}

			// Token: 0x17000A80 RID: 2688
			// (get) Token: 0x06009F70 RID: 40816 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06009F71 RID: 40817 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A80")]
			public virtual long[] RebateOptionsInDemand
			{
				[Token(Token = "0x6009F70")]
				[Address(RVA = "0x204A50C", Offset = "0x204A50C", VA = "0x7BBC84A50C", Slot = "7")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114551C", Offset = "0x114551C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6009F71")]
				[Address(RVA = "0x204A514", Offset = "0x204A514", VA = "0x7BBC84A514", Slot = "8")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114552C", Offset = "0x114552C")]
				set
				{
				}
			}

			// Token: 0x06009F72 RID: 40818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F72")]
			[Address(RVA = "0x204A51C", Offset = "0x204A51C", VA = "0x7BBC84A51C", Slot = "9")]
			public virtual void OnProductsUpdated(string reason, bool result, string[] productIdentifiers)
			{
			}

			// Token: 0x06009F73 RID: 40819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F73")]
			[Address(RVA = "0x204A704", Offset = "0x204A704", VA = "0x7BBC84A704", Slot = "10")]
			public virtual void OnRebateOptionsUpdated(string reason, bool result, long[] rebateIds)
			{
			}

			// Token: 0x06009F74 RID: 40820 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009F74")]
			[Address(RVA = "0x204A708", Offset = "0x204A708", VA = "0x7BBC84A708", Slot = "11")]
			public virtual PayUtility.PaymentDelegate.ProductPurchasedReaction OnProductPurchased(string reason, PayUtility.PaymentDelegate.ProductPurchasedResult result, string productIdentifier, long rebateId)
			{
				return null;
			}

			// Token: 0x06009F75 RID: 40821 RVA: 0x00029988 File Offset: 0x00027B88
			[Token(Token = "0x6009F75")]
			[Address(RVA = "0x204A710", Offset = "0x204A710", VA = "0x7BBC84A710", Slot = "12")]
			public virtual bool OnRebateOptionRedeemed(string reason, bool result, PayUtility.RebateOptionRedeemResult redeemResult)
			{
				return default(bool);
			}

			// Token: 0x06009F76 RID: 40822 RVA: 0x000299A0 File Offset: 0x00027BA0
			[Token(Token = "0x6009F76")]
			[Address(RVA = "0x204A59C", Offset = "0x204A59C", VA = "0x7BBC84A59C")]
			public bool LackProducts(bool logVerbose = false)
			{
				return default(bool);
			}

			// Token: 0x06009F77 RID: 40823 RVA: 0x000299B8 File Offset: 0x00027BB8
			[Token(Token = "0x6009F77")]
			[Address(RVA = "0x204A718", Offset = "0x204A718", VA = "0x7BBC84A718")]
			public bool LackRebateOptions()
			{
				return default(bool);
			}

			// Token: 0x06009F78 RID: 40824 RVA: 0x000299D0 File Offset: 0x00027BD0
			[Token(Token = "0x6009F78")]
			[Address(RVA = "0x204A82C", Offset = "0x204A82C", VA = "0x7BBC84A82C", Slot = "13")]
			public virtual bool UpdateProducts(string reason)
			{
				return default(bool);
			}

			// Token: 0x06009F79 RID: 40825 RVA: 0x000299E8 File Offset: 0x00027BE8
			[Token(Token = "0x6009F79")]
			[Address(RVA = "0x204A92C", Offset = "0x204A92C", VA = "0x7BBC84A92C", Slot = "14")]
			public virtual bool UpdateRebateOptions(string reason)
			{
				return default(bool);
			}

			// Token: 0x06009F7A RID: 40826 RVA: 0x00029A00 File Offset: 0x00027C00
			[Token(Token = "0x6009F7A")]
			[Address(RVA = "0x204AA14", Offset = "0x204AA14", VA = "0x7BBC84AA14")]
			public bool PurchaseProduct(string reason, string productIdentifier)
			{
				return default(bool);
			}

			// Token: 0x06009F7B RID: 40827 RVA: 0x00029A18 File Offset: 0x00027C18
			[Token(Token = "0x6009F7B")]
			[Address(RVA = "0x204AAE8", Offset = "0x204AAE8", VA = "0x7BBC84AAE8")]
			public bool PurchaseRebateOption(string reason, string productIdentifier, long rebateId)
			{
				return default(bool);
			}

			// Token: 0x06009F7C RID: 40828 RVA: 0x00029A30 File Offset: 0x00027C30
			[Token(Token = "0x6009F7C")]
			[Address(RVA = "0x204A830", Offset = "0x204A830", VA = "0x7BBC84A830")]
			protected bool _DemandUpdateProducts(string reason)
			{
				return default(bool);
			}

			// Token: 0x06009F7D RID: 40829 RVA: 0x00029A48 File Offset: 0x00027C48
			[Token(Token = "0x6009F7D")]
			[Address(RVA = "0x204A930", Offset = "0x204A930", VA = "0x7BBC84A930")]
			protected bool _DemandUpdateRebateOptions(string reason)
			{
				return default(bool);
			}

			// Token: 0x06009F7E RID: 40830 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F7E")]
			[Address(RVA = "0x204ABC8", Offset = "0x204ABC8", VA = "0x7BBC84ABC8")]
			protected PaymentDelegate()
			{
			}

			// Token: 0x0400A61C RID: 42524
			[Token(Token = "0x400A61C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FC0C", Offset = "0x112FC0C")]
			private string[] <ProductsInDemand>k__BackingField;

			// Token: 0x0400A61D RID: 42525
			[Token(Token = "0x400A61D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FC1C", Offset = "0x112FC1C")]
			private long[] <RebateOptionsInDemand>k__BackingField;

			// Token: 0x02001C84 RID: 7300
			[Token(Token = "0x2001C84")]
			public class ProductPurchasedReaction
			{
				// Token: 0x06009F7F RID: 40831 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6009F7F")]
				[Address(RVA = "0x203FA74", Offset = "0x203FA74", VA = "0x7BBC83FA74")]
				public ProductPurchasedReaction()
				{
				}

				// Token: 0x0400A61E RID: 42526
				[Token(Token = "0x400A61E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool UpdateRebateOption;

				// Token: 0x0400A61F RID: 42527
				[Token(Token = "0x400A61F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
				public bool UpdateProduct;
			}

			// Token: 0x02001C85 RID: 7301
			[Token(Token = "0x2001C85")]
			public class ProductPurchasedResult
			{
				// Token: 0x06009F80 RID: 40832 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6009F80")]
				[Address(RVA = "0x203F40C", Offset = "0x203F40C", VA = "0x7BBC83F40C")]
				public ProductPurchasedResult()
				{
				}

				// Token: 0x0400A620 RID: 42528
				[Token(Token = "0x400A620")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool IsOK;

				// Token: 0x0400A621 RID: 42529
				[Token(Token = "0x400A621")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public ErrorCode Code;

				// Token: 0x0400A622 RID: 42530
				[Token(Token = "0x400A622")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string Msg;
			}
		}

		// Token: 0x02001C86 RID: 7302
		[Token(Token = "0x2001C86")]
		public class SubscriptionGracePeriodReminderInfo
		{
			// Token: 0x06009F81 RID: 40833 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F81")]
			[Address(RVA = "0x204ABD0", Offset = "0x204ABD0", VA = "0x7BBC84ABD0")]
			public SubscriptionGracePeriodReminderInfo()
			{
			}

			// Token: 0x0400A623 RID: 42531
			[Token(Token = "0x400A623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<PayUtility.SubscriptionGracePeriodReminderInfo> OnConfirm;

			// Token: 0x0400A624 RID: 42532
			[Token(Token = "0x400A624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<PayUtility.SubscriptionGracePeriodReminderInfo> OnCancel;
		}

		// Token: 0x02001C87 RID: 7303
		[Token(Token = "0x2001C87")]
		public struct SubscriptionHintOption
		{
			// Token: 0x0400A625 RID: 42533
			[Token(Token = "0x400A625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Subscription Subscription;

			// Token: 0x0400A626 RID: 42534
			[Token(Token = "0x400A626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 Position;

			// Token: 0x0400A627 RID: 42535
			[Token(Token = "0x400A627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string LocKey_Title;

			// Token: 0x0400A628 RID: 42536
			[Token(Token = "0x400A628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string LocKey_LastPaymentTime;

			// Token: 0x0400A629 RID: 42537
			[Token(Token = "0x400A629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string LocKey_NextPaymentTime;

			// Token: 0x0400A62A RID: 42538
			[Token(Token = "0x400A62A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string LocKey_Cancel;
		}

		// Token: 0x02001C88 RID: 7304
		[Token(Token = "0x2001C88")]
		public class RebateOptionRedeemResult
		{
			// Token: 0x06009F82 RID: 40834 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F82")]
			[Address(RVA = "0x20489A0", Offset = "0x20489A0", VA = "0x7BBC8489A0")]
			public RebateOptionRedeemResult()
			{
			}

			// Token: 0x0400A62B RID: 42539
			[Token(Token = "0x400A62B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long RebateID;

			// Token: 0x0400A62C RID: 42540
			[Token(Token = "0x400A62C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int RemainingDays;

			// Token: 0x0400A62D RID: 42541
			[Token(Token = "0x400A62D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int RedeemAmount;
		}

		// Token: 0x02001C89 RID: 7305
		[Token(Token = "0x2001C89")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB8C4", Offset = "0x10FB8C4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06009F84 RID: 40836 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F84")]
			[Address(RVA = "0x2049248", Offset = "0x2049248", VA = "0x7BBC849248")]
			public <>c()
			{
			}

			// Token: 0x06009F85 RID: 40837 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F85")]
			[Address(RVA = "0x2049250", Offset = "0x2049250", VA = "0x7BBC849250")]
			internal void <ScanIAPInventory>b__24_0(SDKIAPTaskInfo info, SDKIAP.ScanIAPInventoryResult[] results)
			{
			}

			// Token: 0x06009F86 RID: 40838 RVA: 0x00029A60 File Offset: 0x00027C60
			[Token(Token = "0x6009F86")]
			[Address(RVA = "0x204995C", Offset = "0x204995C", VA = "0x7BBC84995C")]
			internal int <UpdateIAPItems>b__60_0(string idStr)
			{
				return 0;
			}

			// Token: 0x06009F87 RID: 40839 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009F87")]
			[Address(RVA = "0x20499C0", Offset = "0x20499C0", VA = "0x7BBC8499C0")]
			internal string <UpdateIAPItems>b__60_1(int itemId)
			{
				return null;
			}

			// Token: 0x06009F88 RID: 40840 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009F88")]
			[Address(RVA = "0x20499E8", Offset = "0x20499E8", VA = "0x7BBC8499E8")]
			internal string <UpdateIAPItems>b__60_2(long rebateId)
			{
				return null;
			}

			// Token: 0x06009F89 RID: 40841 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009F89")]
			[Address(RVA = "0x2049A10", Offset = "0x2049A10", VA = "0x7BBC849A10")]
			internal string <ApplyUpdatedIAPItems>b__63_0(SDKIAP.IAPItem item)
			{
				return null;
			}

			// Token: 0x06009F8A RID: 40842 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009F8A")]
			[Address(RVA = "0x2049DCC", Offset = "0x2049DCC", VA = "0x7BBC849DCC")]
			internal string <ApplyUpdatedIAPItems>b__63_1(SDKIAP.IAPItem item)
			{
				return null;
			}

			// Token: 0x06009F8B RID: 40843 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009F8B")]
			[Address(RVA = "0x2049DF8", Offset = "0x2049DF8", VA = "0x7BBC849DF8")]
			internal string <ApplyUpdatedRebateItems>b__69_0(SDKIAP.RebateOption rebateOption)
			{
				return null;
			}

			// Token: 0x06009F8C RID: 40844 RVA: 0x00029A78 File Offset: 0x00027C78
			[Token(Token = "0x6009F8C")]
			[Address(RVA = "0x204A1EC", Offset = "0x204A1EC", VA = "0x7BBC84A1EC")]
			internal long <ApplyUpdatedRebateItems>b__69_1(SDKIAP.RebateOption rebateOption)
			{
				return 0L;
			}

			// Token: 0x06009F8D RID: 40845 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F8D")]
			[Address(RVA = "0x204A218", Offset = "0x204A218", VA = "0x7BBC84A218")]
			internal void <ShowPaymentFailureMessageBox>b__80_1()
			{
			}

			// Token: 0x0400A62E RID: 42542
			[Token(Token = "0x400A62E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly PayUtility.<>c <>9;

			// Token: 0x0400A62F RID: 42543
			[Token(Token = "0x400A62F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<SDKIAPTaskInfo, SDKIAP.ScanIAPInventoryResult[]> <>9__24_0;

			// Token: 0x0400A630 RID: 42544
			[Token(Token = "0x400A630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Converter<string, int> <>9__60_0;

			// Token: 0x0400A631 RID: 42545
			[Token(Token = "0x400A631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Converter<int, string> <>9__60_1;

			// Token: 0x0400A632 RID: 42546
			[Token(Token = "0x400A632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Converter<long, string> <>9__60_2;

			// Token: 0x0400A633 RID: 42547
			[Token(Token = "0x400A633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Converter<SDKIAP.IAPItem, string> <>9__63_0;

			// Token: 0x0400A634 RID: 42548
			[Token(Token = "0x400A634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Converter<SDKIAP.IAPItem, string> <>9__63_1;

			// Token: 0x0400A635 RID: 42549
			[Token(Token = "0x400A635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Converter<SDKIAP.RebateOption, string> <>9__69_0;

			// Token: 0x0400A636 RID: 42550
			[Token(Token = "0x400A636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Converter<SDKIAP.RebateOption, long> <>9__69_1;

			// Token: 0x0400A637 RID: 42551
			[Token(Token = "0x400A637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static Action <>9__80_1;
		}

		// Token: 0x02001C8A RID: 7306
		[Token(Token = "0x2001C8A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB8D4", Offset = "0x10FB8D4")]
		private sealed class <>c__DisplayClass80_0
		{
			// Token: 0x06009F8E RID: 40846 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F8E")]
			[Address(RVA = "0x20455D4", Offset = "0x20455D4", VA = "0x7BBC8455D4")]
			public <>c__DisplayClass80_0()
			{
			}

			// Token: 0x06009F8F RID: 40847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F8F")]
			[Address(RVA = "0x204A2F8", Offset = "0x204A2F8", VA = "0x7BBC84A2F8")]
			internal void <ShowPaymentFailureMessageBox>b__0()
			{
			}

			// Token: 0x0400A638 RID: 42552
			[Token(Token = "0x400A638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action onCancel;
		}

		// Token: 0x02001C8B RID: 7307
		[Token(Token = "0x2001C8B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB8E4", Offset = "0x10FB8E4")]
		private sealed class <>c__DisplayClass88_0
		{
			// Token: 0x06009F90 RID: 40848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F90")]
			[Address(RVA = "0x2046588", Offset = "0x2046588", VA = "0x7BBC846588")]
			public <>c__DisplayClass88_0()
			{
			}

			// Token: 0x06009F91 RID: 40849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F91")]
			[Address(RVA = "0x204A374", Offset = "0x204A374", VA = "0x7BBC84A374")]
			internal void <OnPurchasedProduct>b__0()
			{
			}

			// Token: 0x0400A639 RID: 42553
			[Token(Token = "0x400A639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SDKIAPTaskInfo info;

			// Token: 0x0400A63A RID: 42554
			[Token(Token = "0x400A63A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SDKIAPTaskResult result;

			// Token: 0x0400A63B RID: 42555
			[Token(Token = "0x400A63B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string item_identifier;
		}

		// Token: 0x02001C8C RID: 7308
		[Token(Token = "0x2001C8C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB8F4", Offset = "0x10FB8F4")]
		private sealed class <>c__DisplayClass99_0
		{
			// Token: 0x06009F92 RID: 40850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F92")]
			[Address(RVA = "0x2047400", Offset = "0x2047400", VA = "0x7BBC847400")]
			public <>c__DisplayClass99_0()
			{
			}

			// Token: 0x06009F93 RID: 40851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F93")]
			[Address(RVA = "0x204A3F4", Offset = "0x204A3F4", VA = "0x7BBC84A3F4")]
			internal void <PromptOnInsufficientDiamonds>b__0()
			{
			}

			// Token: 0x0400A63C RID: 42556
			[Token(Token = "0x400A63C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UINavigationUtil.UINavigationFrom from;
		}

		// Token: 0x02001C8D RID: 7309
		[Token(Token = "0x2001C8D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB904", Offset = "0x10FB904")]
		private sealed class <>c__DisplayClass103_0
		{
			// Token: 0x06009F94 RID: 40852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F94")]
			[Address(RVA = "0x2047E94", Offset = "0x2047E94", VA = "0x7BBC847E94")]
			public <>c__DisplayClass103_0()
			{
			}

			// Token: 0x06009F95 RID: 40853 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009F95")]
			[Address(RVA = "0x204A274", Offset = "0x204A274", VA = "0x7BBC84A274")]
			internal void <OnPurchaseRebateItemFailure>b__0()
			{
			}

			// Token: 0x0400A63D RID: 42557
			[Token(Token = "0x400A63D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SDKIAPTaskInfo info;

			// Token: 0x0400A63E RID: 42558
			[Token(Token = "0x400A63E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SDKIAPTaskResult result;

			// Token: 0x0400A63F RID: 42559
			[Token(Token = "0x400A63F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string display_item_identifier;

			// Token: 0x0400A640 RID: 42560
			[Token(Token = "0x400A640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public long display_rebate_id;
		}
	}
}
