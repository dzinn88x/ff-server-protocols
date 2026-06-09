using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CAB RID: 7339
	[Token(Token = "0x2001CAB")]
	public class AvatarSuit
	{
		// Token: 0x0600A030 RID: 41008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A030")]
		[Address(RVA = "0x21C2554", Offset = "0x21C2554", VA = "0x7BBC9C2554")]
		public AvatarSuit()
		{
		}

		// Token: 0x0400A702 RID: 42754
		[Token(Token = "0x400A702")]
		[FieldOffset(Offset = "0x10")]
		public uint suitID;

		// Token: 0x0400A703 RID: 42755
		[Token(Token = "0x400A703")]
		[FieldOffset(Offset = "0x14")]
		public bool isDefault;

		// Token: 0x0400A704 RID: 42756
		[Token(Token = "0x400A704")]
		[FieldOffset(Offset = "0x15")]
		public bool hasOwnComplete;
	}
}
