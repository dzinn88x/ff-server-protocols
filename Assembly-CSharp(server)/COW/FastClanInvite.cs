using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001DE1 RID: 7649
	[Token(Token = "0x2001DE1")]
	public class FastClanInvite : FastMessage
	{
		// Token: 0x0600A736 RID: 42806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A736")]
		[Address(RVA = "0x1B9578C", Offset = "0x1B9578C", VA = "0x7BBC39578C")]
		public FastClanInvite()
		{
		}

		// Token: 0x0400ACC9 RID: 44233
		[Token(Token = "0x400ACC9")]
		[FieldOffset(Offset = "0x18")]
		public ulong id;

		// Token: 0x0400ACCA RID: 44234
		[Token(Token = "0x400ACCA")]
		[FieldOffset(Offset = "0x20")]
		public string Name;

		// Token: 0x0400ACCB RID: 44235
		[Token(Token = "0x400ACCB")]
		[FieldOffset(Offset = "0x28")]
		public uint Level;

		// Token: 0x0400ACCC RID: 44236
		[Token(Token = "0x400ACCC")]
		[FieldOffset(Offset = "0x30")]
		public string MemberNum;

		// Token: 0x0400ACCD RID: 44237
		[Token(Token = "0x400ACCD")]
		[FieldOffset(Offset = "0x38")]
		public uint Apply;

		// Token: 0x0400ACCE RID: 44238
		[Token(Token = "0x400ACCE")]
		[FieldOffset(Offset = "0x40")]
		public string Declaration;
	}
}
