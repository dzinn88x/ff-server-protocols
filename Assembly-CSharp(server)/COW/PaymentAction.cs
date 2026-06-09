using System;
using GarenaMSDK;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C93 RID: 7315
	[Token(Token = "0x2001C93")]
	public class PaymentAction
	{
		// Token: 0x06009FAF RID: 40879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FAF")]
		[Address(RVA = "0x2045A74", Offset = "0x2045A74", VA = "0x7BBC845A74")]
		public PaymentAction()
		{
		}

		// Token: 0x0400A66D RID: 42605
		[Token(Token = "0x400A66D")]
		[FieldOffset(Offset = "0x10")]
		public SDKIAPTaskInfo Info;

		// Token: 0x0400A66E RID: 42606
		[Token(Token = "0x400A66E")]
		[FieldOffset(Offset = "0x18")]
		public string ProductIdentifier;

		// Token: 0x0400A66F RID: 42607
		[Token(Token = "0x400A66F")]
		[FieldOffset(Offset = "0x20")]
		public bool IsFirstTime;

		// Token: 0x0400A670 RID: 42608
		[Token(Token = "0x400A670")]
		[FieldOffset(Offset = "0x24")]
		public int Quantity;

		// Token: 0x0400A671 RID: 42609
		[Token(Token = "0x400A671")]
		[FieldOffset(Offset = "0x28")]
		public long RebateID;
	}
}
