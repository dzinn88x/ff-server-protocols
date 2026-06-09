using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A73 RID: 2675
	[Token(Token = "0x2000A73")]
	[ProtoContract]
	public class GameExpBonusDesc
	{
		// Token: 0x0600277D RID: 10109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277D")]
		[Address(RVA = "0x21BA728", Offset = "0x21BA728", VA = "0x7BBC9BA728")]
		public GameExpBonusDesc()
		{
		}

		// Token: 0x040030FF RID: 12543
		[Token(Token = "0x40030FF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112218C", Offset = "0x112218C")]
		public uint match_mode;

		// Token: 0x04003100 RID: 12544
		[Token(Token = "0x4003100")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11221A0", Offset = "0x11221A0")]
		public uint game_mode;

		// Token: 0x04003101 RID: 12545
		[Token(Token = "0x4003101")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11221B4", Offset = "0x11221B4")]
		public uint level;

		// Token: 0x04003102 RID: 12546
		[Token(Token = "0x4003102")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11221C8", Offset = "0x11221C8")]
		public float bonus_exp_ratio;

		// Token: 0x04003103 RID: 12547
		[Token(Token = "0x4003103")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11221DC", Offset = "0x11221DC")]
		public uint bonus_exp_limit;
	}
}
