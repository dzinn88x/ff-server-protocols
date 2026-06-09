using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AE7 RID: 2791
	[Token(Token = "0x2000AE7")]
	[ProtoContract]
	public class ChampionshipNameOverwriteDesc
	{
		// Token: 0x060027EF RID: 10223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EF")]
		[Address(RVA = "0x21B804C", Offset = "0x21B804C", VA = "0x7BBC9B804C")]
		public ChampionshipNameOverwriteDesc()
		{
		}

		// Token: 0x04003497 RID: 13463
		[Token(Token = "0x4003497")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128BE0", Offset = "0x1128BE0")]
		public uint championship_type;

		// Token: 0x04003498 RID: 13464
		[Token(Token = "0x4003498")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128BF4", Offset = "0x1128BF4")]
		public uint championship_id;

		// Token: 0x04003499 RID: 13465
		[Token(Token = "0x4003499")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128C08", Offset = "0x1128C08")]
		public uint name_type;

		// Token: 0x0400349A RID: 13466
		[Token(Token = "0x400349A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1128C1C", Offset = "0x1128C1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128C1C", Offset = "0x1128C1C")]
		public string language;

		// Token: 0x0400349B RID: 13467
		[Token(Token = "0x400349B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1128C6C", Offset = "0x1128C6C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128C6C", Offset = "0x1128C6C")]
		public string content;
	}
}
