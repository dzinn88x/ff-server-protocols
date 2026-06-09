using System;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BF8 RID: 11256
	[Token(Token = "0x2002BF8")]
	internal class PurchaseNormalProduct : PurchaseTaskInstance
	{
		// Token: 0x0600F906 RID: 63750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F906")]
		[Address(RVA = "0x2251238", Offset = "0x2251238", VA = "0x7BBCA51238")]
		public PurchaseNormalProduct(SDKIAPTaskInfo info)
		{
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x0600F907 RID: 63751 RVA: 0x00047BE0 File Offset: 0x00045DE0
		[Token(Token = "0x1700121D")]
		public override SDKIAPTask Task
		{
			[Token(Token = "0x600F907")]
			[Address(RVA = "0x2251248", Offset = "0x2251248", VA = "0x7BBCA51248", Slot = "4")]
			get
			{
				return SDKIAPTask.None;
			}
		}

		// Token: 0x0600F908 RID: 63752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F908")]
		[Address(RVA = "0x2251250", Offset = "0x2251250", VA = "0x7BBCA51250", Slot = "9")]
		internal override string IdentifySelf()
		{
			return null;
		}

		// Token: 0x0600F909 RID: 63753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F909")]
		[Address(RVA = "0x2251304", Offset = "0x2251304", VA = "0x7BBCA51304", Slot = "13")]
		protected override void Start()
		{
		}

		// Token: 0x0600F90A RID: 63754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F90A")]
		[Address(RVA = "0x22516B0", Offset = "0x22516B0", VA = "0x7BBCA516B0")]
		private void OnPaymentProcessedOrException(SDKIAP_Android.TransactionInfo transactionInfo)
		{
		}

		// Token: 0x0600F90B RID: 63755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F90B")]
		[Address(RVA = "0x2251A74", Offset = "0x2251A74", VA = "0x7BBCA51A74", Slot = "14")]
		protected override void Succeed()
		{
		}

		// Token: 0x0600F90C RID: 63756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F90C")]
		[Address(RVA = "0x2251B1C", Offset = "0x2251B1C", VA = "0x7BBCA51B1C", Slot = "15")]
		protected override void Fail()
		{
		}

		// Token: 0x0600F90D RID: 63757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F90D")]
		[Address(RVA = "0x2251BC4", Offset = "0x2251BC4", VA = "0x7BBCA51BC4", Slot = "16")]
		protected override void Destroy()
		{
		}

		// Token: 0x04011CC1 RID: 72897
		[Token(Token = "0x4011CC1")]
		[FieldOffset(Offset = "0x40")]
		public int Quantity;

		// Token: 0x04011CC2 RID: 72898
		[Token(Token = "0x4011CC2")]
		[FieldOffset(Offset = "0x48")]
		public Action<SDKIAPTaskInfo, SDKIAPTaskResult, string> OnSuccess;

		// Token: 0x04011CC3 RID: 72899
		[Token(Token = "0x4011CC3")]
		[FieldOffset(Offset = "0x50")]
		public Action<SDKIAPTaskInfo, SDKIAPTaskResult, string> OnFailure;
	}
}
