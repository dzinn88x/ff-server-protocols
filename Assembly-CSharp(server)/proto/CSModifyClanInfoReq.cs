using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007E6 RID: 2022
	[Token(Token = "0x20007E6")]
	[ProtoContract]
	public class CSModifyClanInfoReq
	{
		// Token: 0x060024F5 RID: 9461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F5")]
		[Address(RVA = "0x21B6900", Offset = "0x21B6900", VA = "0x7BBC9B6900")]
		public CSModifyClanInfoReq()
		{
		}

		// Token: 0x0400267C RID: 9852
		[Token(Token = "0x400267C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FE10", Offset = "0x110FE10")]
		public ulong clan_id;

		// Token: 0x0400267D RID: 9853
		[Token(Token = "0x400267D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110FE24", Offset = "0x110FE24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FE24", Offset = "0x110FE24")]
		public string announcement;

		// Token: 0x0400267E RID: 9854
		[Token(Token = "0x400267E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FE74", Offset = "0x110FE74")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110FE74", Offset = "0x110FE74")]
		public string slogan;

		// Token: 0x0400267F RID: 9855
		[Token(Token = "0x400267F")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FEC4", Offset = "0x110FEC4")]
		public uint entry_type;

		// Token: 0x04002680 RID: 9856
		[Token(Token = "0x4002680")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FED8", Offset = "0x110FED8")]
		public uint area_id;

		// Token: 0x04002681 RID: 9857
		[Token(Token = "0x4002681")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FEEC", Offset = "0x110FEEC")]
		public uint play_style;

		// Token: 0x04002682 RID: 9858
		[Token(Token = "0x4002682")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FF00", Offset = "0x110FF00")]
		public uint entry_level;

		// Token: 0x04002683 RID: 9859
		[Token(Token = "0x4002683")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FF14", Offset = "0x110FF14")]
		public uint entry_rank;
	}
}
