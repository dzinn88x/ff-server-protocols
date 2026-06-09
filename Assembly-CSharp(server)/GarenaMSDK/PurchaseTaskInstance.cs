using System;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BF6 RID: 11254
	[Token(Token = "0x2002BF6")]
	internal class PurchaseTaskInstance : SDKIAPTaskInstance
	{
		// Token: 0x0600F900 RID: 63744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F900")]
		[Address(RVA = "0x2251240", Offset = "0x2251240", VA = "0x7BBCA51240")]
		public PurchaseTaskInstance(SDKIAPTaskInfo info)
		{
		}

		// Token: 0x0600F901 RID: 63745 RVA: 0x00047B98 File Offset: 0x00045D98
		[Token(Token = "0x600F901")]
		[Address(RVA = "0x22522E0", Offset = "0x22522E0", VA = "0x7BBCA522E0", Slot = "11")]
		public sealed override bool IsDuplicateOf(SDKIAPTaskInstance peer)
		{
			return default(bool);
		}

		// Token: 0x0600F902 RID: 63746 RVA: 0x00047BB0 File Offset: 0x00045DB0
		[Token(Token = "0x600F902")]
		[Address(RVA = "0x22522E8", Offset = "0x22522E8", VA = "0x7BBCA522E8", Slot = "12")]
		public sealed override bool CanFinishWith(SDKIAPTaskInstance peer)
		{
			return default(bool);
		}

		// Token: 0x0600F903 RID: 63747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F903")]
		[Address(RVA = "0x22514A8", Offset = "0x22514A8", VA = "0x7BBCA514A8", Slot = "13")]
		protected override void Start()
		{
		}

		// Token: 0x0600F904 RID: 63748 RVA: 0x00047BC8 File Offset: 0x00045DC8
		[Token(Token = "0x600F904")]
		[Address(RVA = "0x22518D8", Offset = "0x22518D8", VA = "0x7BBCA518D8")]
		protected static bool? GetAndroidPaymentResult(SDKIAP_Android.TransactionInfo transactionInfo, out ErrorCode errorCode, out string errorMessage)
		{
			return null;
		}

		// Token: 0x0600F905 RID: 63749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F905")]
		[Address(RVA = "0x2251C3C", Offset = "0x2251C3C", VA = "0x7BBCA51C3C", Slot = "16")]
		protected override void Destroy()
		{
		}

		// Token: 0x04011CBC RID: 72892
		[Token(Token = "0x4011CBC")]
		[FieldOffset(Offset = "0x28")]
		public string ProductIdentifier;

		// Token: 0x04011CBD RID: 72893
		[Token(Token = "0x4011CBD")]
		[FieldOffset(Offset = "0x30")]
		protected PurchaseTaskInstance.PendingPhase Phase;

		// Token: 0x04011CBE RID: 72894
		[Token(Token = "0x4011CBE")]
		[FieldOffset(Offset = "0x38")]
		protected SDKIAP_Android.TransactionInfo TransactionInfo;

		// Token: 0x02002BF7 RID: 11255
		[Token(Token = "0x2002BF7")]
		protected enum PendingPhase
		{
			// Token: 0x04011CC0 RID: 72896
			[Token(Token = "0x4011CC0")]
			Pending
		}
	}
}
