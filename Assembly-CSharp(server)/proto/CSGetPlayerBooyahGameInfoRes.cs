using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009A0 RID: 2464
	[Token(Token = "0x20009A0")]
	[ProtoContract]
	public class CSGetPlayerBooyahGameInfoRes
	{
		// Token: 0x060026AE RID: 9902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AE")]
		[Address(RVA = "0x21B5580", Offset = "0x21B5580", VA = "0x7BBC9B5580")]
		public CSGetPlayerBooyahGameInfoRes()
		{
		}

		// Token: 0x04002C7C RID: 11388
		[Token(Token = "0x4002C7C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A284", Offset = "0x111A284")]
		public ulong account_id;

		// Token: 0x04002C7D RID: 11389
		[Token(Token = "0x4002C7D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A298", Offset = "0x111A298")]
		public uint booyah_wins;

		// Token: 0x04002C7E RID: 11390
		[Token(Token = "0x4002C7E")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A2AC", Offset = "0x111A2AC")]
		public uint booyah_chess_wins;
	}
}
