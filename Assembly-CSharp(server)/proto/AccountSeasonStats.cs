using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200091D RID: 2333
	[Token(Token = "0x200091D")]
	[ProtoContract]
	public class AccountSeasonStats
	{
		// Token: 0x0600262B RID: 9771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262B")]
		[Address(RVA = "0x21AE844", Offset = "0x21AE844", VA = "0x7BBC9AE844")]
		public AccountSeasonStats()
		{
		}

		// Token: 0x04002B4C RID: 11084
		[Token(Token = "0x4002B4C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11186DC", Offset = "0x11186DC")]
		public ulong account_id;

		// Token: 0x04002B4D RID: 11085
		[Token(Token = "0x4002B4D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11186F0", Offset = "0x11186F0")]
		public uint championship_type;

		// Token: 0x04002B4E RID: 11086
		[Token(Token = "0x4002B4E")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118704", Offset = "0x1118704")]
		public uint championship_id;

		// Token: 0x04002B4F RID: 11087
		[Token(Token = "0x4002B4F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118718", Offset = "0x1118718")]
		public uint score;

		// Token: 0x04002B50 RID: 11088
		[Token(Token = "0x4002B50")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111872C", Offset = "0x111872C")]
		public uint pos;
	}
}
