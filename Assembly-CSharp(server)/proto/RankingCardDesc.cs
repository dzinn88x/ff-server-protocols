using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AA5 RID: 2725
	[Token(Token = "0x2000AA5")]
	[ProtoContract]
	public class RankingCardDesc
	{
		// Token: 0x060027AF RID: 10159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AF")]
		[Address(RVA = "0x249FA78", Offset = "0x249FA78", VA = "0x7BBCC9FA78")]
		public RankingCardDesc()
		{
		}

		// Token: 0x04003313 RID: 13075
		[Token(Token = "0x4003313")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125F58", Offset = "0x1125F58")]
		public uint card_id;

		// Token: 0x04003314 RID: 13076
		[Token(Token = "0x4003314")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125F6C", Offset = "0x1125F6C")]
		public uint ranking_point_times;

		// Token: 0x04003315 RID: 13077
		[Token(Token = "0x4003315")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125F80", Offset = "0x1125F80")]
		public uint token_times;

		// Token: 0x04003316 RID: 13078
		[Token(Token = "0x4003316")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125F94", Offset = "0x1125F94")]
		public bool is_no_deduct;
	}
}
