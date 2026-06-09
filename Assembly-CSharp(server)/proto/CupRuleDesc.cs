using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B52 RID: 2898
	[Token(Token = "0x2000B52")]
	[ProtoContract]
	public class CupRuleDesc
	{
		// Token: 0x0600285A RID: 10330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285A")]
		[Address(RVA = "0x21B9248", Offset = "0x21B9248", VA = "0x7BBC9B9248")]
		public CupRuleDesc()
		{
		}

		// Token: 0x0400372E RID: 14126
		[Token(Token = "0x400372E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E464", Offset = "0x112E464")]
		public uint limited_level;

		// Token: 0x0400372F RID: 14127
		[Token(Token = "0x400372F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E478", Offset = "0x112E478")]
		public uint limited_rank;

		// Token: 0x04003730 RID: 14128
		[Token(Token = "0x4003730")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E48C", Offset = "0x112E48C")]
		public uint upper_limited_level;

		// Token: 0x04003731 RID: 14129
		[Token(Token = "0x4003731")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E4A0", Offset = "0x112E4A0")]
		public uint upper_limited_rank;
	}
}
