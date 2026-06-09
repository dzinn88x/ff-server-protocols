using System;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BFA RID: 11258
	[Token(Token = "0x2002BFA")]
	internal class RedeemRebateOption : SDKIAPTaskInstance
	{
		// Token: 0x0600F916 RID: 63766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F916")]
		[Address(RVA = "0x22522F0", Offset = "0x22522F0", VA = "0x7BBCA522F0")]
		public RedeemRebateOption(SDKIAPTaskInfo info)
		{
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x0600F917 RID: 63767 RVA: 0x00047C10 File Offset: 0x00045E10
		[Token(Token = "0x1700121F")]
		public override SDKIAPTask Task
		{
			[Token(Token = "0x600F917")]
			[Address(RVA = "0x22522F8", Offset = "0x22522F8", VA = "0x7BBCA522F8", Slot = "4")]
			get
			{
				return SDKIAPTask.None;
			}
		}

		// Token: 0x0600F918 RID: 63768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F918")]
		[Address(RVA = "0x2252300", Offset = "0x2252300", VA = "0x7BBCA52300", Slot = "9")]
		internal override string IdentifySelf()
		{
			return null;
		}

		// Token: 0x0600F919 RID: 63769 RVA: 0x00047C28 File Offset: 0x00045E28
		[Token(Token = "0x600F919")]
		[Address(RVA = "0x2252380", Offset = "0x2252380", VA = "0x7BBCA52380", Slot = "11")]
		public sealed override bool IsDuplicateOf(SDKIAPTaskInstance peer)
		{
			return default(bool);
		}

		// Token: 0x0600F91A RID: 63770 RVA: 0x00047C40 File Offset: 0x00045E40
		[Token(Token = "0x600F91A")]
		[Address(RVA = "0x2252388", Offset = "0x2252388", VA = "0x7BBCA52388", Slot = "12")]
		public sealed override bool CanFinishWith(SDKIAPTaskInstance peer)
		{
			return default(bool);
		}

		// Token: 0x0600F91B RID: 63771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F91B")]
		[Address(RVA = "0x2252390", Offset = "0x2252390", VA = "0x7BBCA52390", Slot = "13")]
		protected override void Start()
		{
		}

		// Token: 0x0600F91C RID: 63772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F91C")]
		[Address(RVA = "0x22524AC", Offset = "0x22524AC", VA = "0x7BBCA524AC")]
		private void OnRedeemedRebateOptions(SDKIAP.RebateRedeemResult[] results, ErrorCode errorCode, string errorMessage)
		{
		}

		// Token: 0x0600F91D RID: 63773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F91D")]
		[Address(RVA = "0x22525AC", Offset = "0x22525AC", VA = "0x7BBCA525AC", Slot = "14")]
		protected override void Succeed()
		{
		}

		// Token: 0x0600F91E RID: 63774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F91E")]
		[Address(RVA = "0x2252654", Offset = "0x2252654", VA = "0x7BBCA52654", Slot = "15")]
		protected override void Fail()
		{
		}

		// Token: 0x0600F91F RID: 63775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F91F")]
		[Address(RVA = "0x22526FC", Offset = "0x22526FC", VA = "0x7BBCA526FC", Slot = "16")]
		protected override void Destroy()
		{
		}

		// Token: 0x04011CC9 RID: 72905
		[Token(Token = "0x4011CC9")]
		[FieldOffset(Offset = "0x28")]
		public int RebateID;

		// Token: 0x04011CCA RID: 72906
		[Token(Token = "0x4011CCA")]
		[FieldOffset(Offset = "0x30")]
		private SDKIAP.RebateRedeemResult[] _results;

		// Token: 0x04011CCB RID: 72907
		[Token(Token = "0x4011CCB")]
		[FieldOffset(Offset = "0x38")]
		public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateRedeemResult[]> OnRedeemed;
	}
}
