using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000698 RID: 1688
	[Token(Token = "0x2000698")]
	[ProtoContract]
	public class ESubscription
	{
		// Token: 0x060023D5 RID: 9173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D5")]
		[Address(RVA = "0x21B9B5C", Offset = "0x21B9B5C", VA = "0x7BBC9B9B5C")]
		public ESubscription()
		{
		}

		// Token: 0x02000699 RID: 1689
		[Token(Token = "0x2000699")]
		[ProtoContract]
		public enum SubscribeType
		{
			// Token: 0x04002126 RID: 8486
			[Token(Token = "0x4002126")]
			SubscribeType_NONE,
			// Token: 0x04002127 RID: 8487
			[Token(Token = "0x4002127")]
			SubscribeType_REBATE,
			// Token: 0x04002128 RID: 8488
			[Token(Token = "0x4002128")]
			SubscribeType_EP,
			// Token: 0x04002129 RID: 8489
			[Token(Token = "0x4002129")]
			SubscribeType_BUNDLE
		}

		// Token: 0x0200069A RID: 1690
		[Token(Token = "0x200069A")]
		[ProtoContract]
		public enum PriceType
		{
			// Token: 0x0400212B RID: 8491
			[Token(Token = "0x400212B")]
			PriceType_NONE,
			// Token: 0x0400212C RID: 8492
			[Token(Token = "0x400212C")]
			PriceType_WEEK,
			// Token: 0x0400212D RID: 8493
			[Token(Token = "0x400212D")]
			PriceType_MONTH
		}

		// Token: 0x0200069B RID: 1691
		[Token(Token = "0x200069B")]
		[ProtoContract]
		public enum TagType
		{
			// Token: 0x0400212F RID: 8495
			[Token(Token = "0x400212F")]
			TagType_NONE,
			// Token: 0x04002130 RID: 8496
			[Token(Token = "0x4002130")]
			TagType_LIMITEDTIME,
			// Token: 0x04002131 RID: 8497
			[Token(Token = "0x4002131")]
			TagType_NEW
		}
	}
}
