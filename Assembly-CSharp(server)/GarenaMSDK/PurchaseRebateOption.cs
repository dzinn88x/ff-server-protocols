using System;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BF9 RID: 11257
	[Token(Token = "0x2002BF9")]
	internal class PurchaseRebateOption : PurchaseTaskInstance
	{
		// Token: 0x0600F90E RID: 63758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F90E")]
		[Address(RVA = "0x2251C44", Offset = "0x2251C44", VA = "0x7BBCA51C44")]
		public PurchaseRebateOption(SDKIAPTaskInfo info)
		{
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x0600F90F RID: 63759 RVA: 0x00047BF8 File Offset: 0x00045DF8
		[Token(Token = "0x1700121E")]
		public override SDKIAPTask Task
		{
			[Token(Token = "0x600F90F")]
			[Address(RVA = "0x2251C4C", Offset = "0x2251C4C", VA = "0x7BBCA51C4C", Slot = "4")]
			get
			{
				return SDKIAPTask.None;
			}
		}

		// Token: 0x0600F910 RID: 63760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F910")]
		[Address(RVA = "0x2251C54", Offset = "0x2251C54", VA = "0x7BBCA51C54", Slot = "9")]
		internal override string IdentifySelf()
		{
			return null;
		}

		// Token: 0x0600F911 RID: 63761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F911")]
		[Address(RVA = "0x2251CDC", Offset = "0x2251CDC", VA = "0x7BBCA51CDC", Slot = "13")]
		protected override void Start()
		{
		}

		// Token: 0x0600F912 RID: 63762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F912")]
		[Address(RVA = "0x2251E90", Offset = "0x2251E90", VA = "0x7BBCA51E90")]
		private void OnPaymentProcessedOrException(SDKIAP_Android.TransactionInfo transactionInfo)
		{
		}

		// Token: 0x0600F913 RID: 63763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F913")]
		[Address(RVA = "0x2252018", Offset = "0x2252018", VA = "0x7BBCA52018", Slot = "14")]
		protected override void Succeed()
		{
		}

		// Token: 0x0600F914 RID: 63764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F914")]
		[Address(RVA = "0x2252140", Offset = "0x2252140", VA = "0x7BBCA52140", Slot = "15")]
		protected override void Fail()
		{
		}

		// Token: 0x0600F915 RID: 63765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F915")]
		[Address(RVA = "0x2252268", Offset = "0x2252268", VA = "0x7BBCA52268", Slot = "16")]
		protected override void Destroy()
		{
		}

		// Token: 0x04011CC4 RID: 72900
		[Token(Token = "0x4011CC4")]
		[FieldOffset(Offset = "0x40")]
		public long RebateID;

		// Token: 0x04011CC5 RID: 72901
		[Token(Token = "0x4011CC5")]
		[FieldOffset(Offset = "0x48")]
		private long _rebateID;

		// Token: 0x04011CC6 RID: 72902
		[Token(Token = "0x4011CC6")]
		[FieldOffset(Offset = "0x50")]
		private int _remainingDays;

		// Token: 0x04011CC7 RID: 72903
		[Token(Token = "0x4011CC7")]
		[FieldOffset(Offset = "0x58")]
		public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAPManager.RebateOptionPurchaseResult> OnSuccess;

		// Token: 0x04011CC8 RID: 72904
		[Token(Token = "0x4011CC8")]
		[FieldOffset(Offset = "0x60")]
		public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAPManager.RebateOptionPurchaseResult> OnFailure;
	}
}
