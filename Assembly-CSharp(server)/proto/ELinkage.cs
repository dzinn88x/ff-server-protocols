using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000693 RID: 1683
	[Token(Token = "0x2000693")]
	[ProtoContract]
	public class ELinkage
	{
		// Token: 0x060023D1 RID: 9169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D1")]
		[Address(RVA = "0x21B9848", Offset = "0x21B9848", VA = "0x7BBC9B9848")]
		public ELinkage()
		{
		}

		// Token: 0x02000694 RID: 1684
		[Token(Token = "0x2000694")]
		[ProtoContract]
		public enum ActivityType
		{
			// Token: 0x04002116 RID: 8470
			[Token(Token = "0x4002116")]
			Type_NONE,
			// Token: 0x04002117 RID: 8471
			[Token(Token = "0x4002117")]
			Type_PIRATE_MAP,
			// Token: 0x04002118 RID: 8472
			[Token(Token = "0x4002118")]
			Type_TDM,
			// Token: 0x04002119 RID: 8473
			[Token(Token = "0x4002119")]
			Type_SAMURAI,
			// Token: 0x0400211A RID: 8474
			[Token(Token = "0x400211A")]
			Type_ARMSRACE,
			// Token: 0x0400211B RID: 8475
			[Token(Token = "0x400211B")]
			Type_BOMBMATCH,
			// Token: 0x0400211C RID: 8476
			[Token(Token = "0x400211C")]
			Type_FOXTORII
		}
	}
}
