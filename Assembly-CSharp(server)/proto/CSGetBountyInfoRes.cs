using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000979 RID: 2425
	[Token(Token = "0x2000979")]
	[ProtoContract]
	public class CSGetBountyInfoRes
	{
		// Token: 0x06002687 RID: 9863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002687")]
		[Address(RVA = "0x21B290C", Offset = "0x21B290C", VA = "0x7BBC9B290C")]
		public CSGetBountyInfoRes()
		{
		}

		// Token: 0x04002C18 RID: 11288
		[Token(Token = "0x4002C18")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11199C4", Offset = "0x11199C4")]
		public ulong main_percent;

		// Token: 0x04002C19 RID: 11289
		[Token(Token = "0x4002C19")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11199D8", Offset = "0x11199D8")]
		public ulong popularity;

		// Token: 0x04002C1A RID: 11290
		[Token(Token = "0x4002C1A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11199EC", Offset = "0x11199EC")]
		public uint bounty_tokens;
	}
}
