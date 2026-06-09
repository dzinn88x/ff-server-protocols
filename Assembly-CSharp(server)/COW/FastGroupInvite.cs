using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001DE2 RID: 7650
	[Token(Token = "0x2001DE2")]
	public class FastGroupInvite : FastMessage
	{
		// Token: 0x0600A737 RID: 42807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A737")]
		[Address(RVA = "0x1B957E8", Offset = "0x1B957E8", VA = "0x7BBC3957E8")]
		public FastGroupInvite()
		{
		}

		// Token: 0x0400ACCF RID: 44239
		[Token(Token = "0x400ACCF")]
		[FieldOffset(Offset = "0x18")]
		public ulong GroupID;

		// Token: 0x0400ACD0 RID: 44240
		[Token(Token = "0x400ACD0")]
		[FieldOffset(Offset = "0x20")]
		public uint Group;

		// Token: 0x0400ACD1 RID: 44241
		[Token(Token = "0x400ACD1")]
		[FieldOffset(Offset = "0x24")]
		public uint Map;

		// Token: 0x0400ACD2 RID: 44242
		[Token(Token = "0x400ACD2")]
		[FieldOffset(Offset = "0x28")]
		public uint Game;

		// Token: 0x0400ACD3 RID: 44243
		[Token(Token = "0x400ACD3")]
		[FieldOffset(Offset = "0x2C")]
		public uint Match;

		// Token: 0x0400ACD4 RID: 44244
		[Token(Token = "0x400ACD4")]
		[FieldOffset(Offset = "0x30")]
		public uint MemberNum;

		// Token: 0x0400ACD5 RID: 44245
		[Token(Token = "0x400ACD5")]
		[FieldOffset(Offset = "0x34")]
		public uint RequireRank;

		// Token: 0x0400ACD6 RID: 44246
		[Token(Token = "0x400ACD6")]
		[FieldOffset(Offset = "0x38")]
		public string GroupTag;

		// Token: 0x0400ACD7 RID: 44247
		[Token(Token = "0x400ACD7")]
		[FieldOffset(Offset = "0x40")]
		public string SecretCode;
	}
}
