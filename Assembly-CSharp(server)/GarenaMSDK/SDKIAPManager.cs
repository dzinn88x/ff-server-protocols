using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BE6 RID: 11238
	[Token(Token = "0x2002BE6")]
	public static class SDKIAPManager
	{
		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x0600F894 RID: 63636 RVA: 0x00047898 File Offset: 0x00045A98
		[Token(Token = "0x17001212")]
		public static bool Pending
		{
			[Token(Token = "0x600F894")]
			[Address(RVA = "0x2738910", Offset = "0x2738910", VA = "0x7BBCF38910")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x0600F895 RID: 63637 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F896 RID: 63638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001213")]
		public static SDKIAPManager.SDKIAPManagerConfiguration Configuration
		{
			[Token(Token = "0x600F895")]
			[Address(RVA = "0x2738A14", Offset = "0x2738A14", VA = "0x7BBCF38A14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BBC8", Offset = "0x114BBC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F896")]
			[Address(RVA = "0x2738A7C", Offset = "0x2738A7C", VA = "0x7BBCF38A7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BBD8", Offset = "0x114BBD8")]
			set
			{
			}
		}

		// Token: 0x0600F897 RID: 63639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F897")]
		[Address(RVA = "0x2738AE8", Offset = "0x2738AE8", VA = "0x7BBCF38AE8")]
		private static void DestroyTask(SDKIAPTaskInstance taskInstance)
		{
		}

		// Token: 0x0600F898 RID: 63640 RVA: 0x000478B0 File Offset: 0x00045AB0
		[Token(Token = "0x600F898")]
		[Address(RVA = "0x2738C30", Offset = "0x2738C30", VA = "0x7BBCF38C30")]
		private static bool ExecuteTask(SDKIAPTaskInstance taskInstance)
		{
			return default(bool);
		}

		// Token: 0x0600F899 RID: 63641 RVA: 0x000478C8 File Offset: 0x00045AC8
		[Token(Token = "0x600F899")]
		[Address(RVA = "0x2738F2C", Offset = "0x2738F2C", VA = "0x7BBCF38F2C")]
		private static bool ProcessTask(SDKIAPTaskInstance taskInstance)
		{
			return default(bool);
		}

		// Token: 0x0600F89A RID: 63642 RVA: 0x000478E0 File Offset: 0x00045AE0
		[Token(Token = "0x600F89A")]
		private static bool CanFinishWith<T>(T t, SDKIAPTaskInstance i) where T : SDKIAPTaskInstance
		{
			return default(bool);
		}

		// Token: 0x0600F89B RID: 63643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F89B")]
		internal static void Finish<T>(T t, Action<T> callback) where T : SDKIAPTaskInstance
		{
		}

		// Token: 0x0600F89C RID: 63644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F89C")]
		[Address(RVA = "0x27395BC", Offset = "0x27395BC", VA = "0x7BBCF395BC")]
		internal static void TaskInstanceStateChanged(SDKIAPTaskInstance task, SDKIAPTaskState prev, SDKIAPTaskState next)
		{
		}

		// Token: 0x0600F89D RID: 63645 RVA: 0x000478F8 File Offset: 0x00045AF8
		[Token(Token = "0x600F89D")]
		[Address(RVA = "0x27397AC", Offset = "0x27397AC", VA = "0x7BBCF397AC")]
		public static bool ScanIAPInventory(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAP.ScanIAPInventoryResult[]> scanned)
		{
			return default(bool);
		}

		// Token: 0x0600F89E RID: 63646 RVA: 0x00047910 File Offset: 0x00045B10
		[Token(Token = "0x600F89E")]
		[Address(RVA = "0x27398E0", Offset = "0x27398E0", VA = "0x7BBCF398E0")]
		public static bool LoadIAPItems(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.IAPItem[]> done, int rebateID = 0, bool allItems = false)
		{
			return default(bool);
		}

		// Token: 0x0600F89F RID: 63647 RVA: 0x00047928 File Offset: 0x00045B28
		[Token(Token = "0x600F89F")]
		[Address(RVA = "0x2739A88", Offset = "0x2739A88", VA = "0x7BBCF39A88")]
		public static bool LoadRebateOptions(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateOption[]> done, bool force = false)
		{
			return default(bool);
		}

		// Token: 0x0600F8A0 RID: 63648 RVA: 0x00047940 File Offset: 0x00045B40
		[Token(Token = "0x600F8A0")]
		[Address(RVA = "0x2739BBC", Offset = "0x2739BBC", VA = "0x7BBCF39BBC")]
		public static bool LoadSomeIAPItems(SDKIAPTaskInfo info, int[] productIds, long[] rebateIds, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.IAPItem[]> done)
		{
			return default(bool);
		}

		// Token: 0x0600F8A1 RID: 63649 RVA: 0x00047958 File Offset: 0x00045B58
		[Token(Token = "0x600F8A1")]
		[Address(RVA = "0x2739D38", Offset = "0x2739D38", VA = "0x7BBCF39D38")]
		public static bool LoadSomeRebateOptions(SDKIAPTaskInfo info, long[] rebateIds, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateOption[]> done)
		{
			return default(bool);
		}

		// Token: 0x0600F8A2 RID: 63650 RVA: 0x00047970 File Offset: 0x00045B70
		[Token(Token = "0x600F8A2")]
		[Address(RVA = "0x2739E94", Offset = "0x2739E94", VA = "0x7BBCF39E94")]
		public static bool PurchaseNormalProduct(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, string> success, Action<SDKIAPTaskInfo, SDKIAPTaskResult, string> failure, [Optional] string productIdentifier, int quantity = 1)
		{
			return default(bool);
		}

		// Token: 0x0600F8A3 RID: 63651 RVA: 0x00047988 File Offset: 0x00045B88
		[Token(Token = "0x600F8A3")]
		[Address(RVA = "0x273A02C", Offset = "0x273A02C", VA = "0x7BBCF3A02C")]
		public static bool PurchaseRebateOption(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAPManager.RebateOptionPurchaseResult> success, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAPManager.RebateOptionPurchaseResult> failure, int rebateID, string productIdentifier)
		{
			return default(bool);
		}

		// Token: 0x0600F8A4 RID: 63652 RVA: 0x000479A0 File Offset: 0x00045BA0
		[Token(Token = "0x600F8A4")]
		[Address(RVA = "0x273A1CC", Offset = "0x273A1CC", VA = "0x7BBCF3A1CC")]
		public static bool RedeemRebateOption(SDKIAPTaskInfo info, Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateRedeemResult[]> redeemed, int rebateID)
		{
			return default(bool);
		}

		// Token: 0x04011C7C RID: 72828
		[Token(Token = "0x4011C7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<SDKIAPTask, SDKIAPTaskType> _TaskTypes;

		// Token: 0x04011C7D RID: 72829
		[Token(Token = "0x4011C7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<SDKIAPTaskInstance> _Tasks;

		// Token: 0x04011C7E RID: 72830
		[Token(Token = "0x4011C7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static SDKIAPTaskInstance _PendingTask;

		// Token: 0x04011C7F RID: 72831
		[Token(Token = "0x4011C7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131D94", Offset = "0x1131D94")]
		private static SDKIAPManager.SDKIAPManagerConfiguration <Configuration>k__BackingField;

		// Token: 0x02002BE7 RID: 11239
		[Token(Token = "0x2002BE7")]
		public class SDKIAPManagerConfiguration
		{
			// Token: 0x0600F8A6 RID: 63654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F8A6")]
			[Address(RVA = "0x273A568", Offset = "0x273A568", VA = "0x7BBCF3A568")]
			public SDKIAPManagerConfiguration()
			{
			}

			// Token: 0x04011C80 RID: 72832
			[Token(Token = "0x4011C80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool LocalizePrice;

			// Token: 0x04011C81 RID: 72833
			[Token(Token = "0x4011C81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int ServerID;

			// Token: 0x04011C82 RID: 72834
			[Token(Token = "0x4011C82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int RoleID;

			// Token: 0x04011C83 RID: 72835
			[Token(Token = "0x4011C83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string Region;

			// Token: 0x04011C84 RID: 72836
			[Token(Token = "0x4011C84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string ProductPrefix_iOS;
		}

		// Token: 0x02002BE8 RID: 11240
		[Token(Token = "0x2002BE8")]
		public class RebateOptionPurchaseResult
		{
			// Token: 0x0600F8A7 RID: 63655 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F8A7")]
			[Address(RVA = "0x273A560", Offset = "0x273A560", VA = "0x7BBCF3A560")]
			public RebateOptionPurchaseResult()
			{
			}

			// Token: 0x04011C85 RID: 72837
			[Token(Token = "0x4011C85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string ProductIdentifier;

			// Token: 0x04011C86 RID: 72838
			[Token(Token = "0x4011C86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public long RebateID;

			// Token: 0x04011C87 RID: 72839
			[Token(Token = "0x4011C87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int RemainingDays;
		}
	}
}
