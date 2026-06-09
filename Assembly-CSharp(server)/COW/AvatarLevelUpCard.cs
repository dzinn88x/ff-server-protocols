using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CAA RID: 7338
	[Token(Token = "0x2001CAA")]
	public class AvatarLevelUpCard
	{
		// Token: 0x0600A02F RID: 41007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A02F")]
		[Address(RVA = "0x15621EC", Offset = "0x15621EC", VA = "0x7BBBD621EC")]
		public AvatarLevelUpCard()
		{
		}

		// Token: 0x0400A6FF RID: 42751
		[Token(Token = "0x400A6FF")]
		[FieldOffset(Offset = "0x10")]
		public int cardId;

		// Token: 0x0400A700 RID: 42752
		[Token(Token = "0x400A700")]
		[FieldOffset(Offset = "0x14")]
		public int toLevel;

		// Token: 0x0400A701 RID: 42753
		[Token(Token = "0x400A701")]
		[FieldOffset(Offset = "0x18")]
		public uint goPos;
	}
}
