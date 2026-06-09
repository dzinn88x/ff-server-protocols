using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009E3 RID: 2531
	[Token(Token = "0x20009E3")]
	[ProtoContract]
	public class DiamondSpendEventDesc
	{
		// Token: 0x060026ED RID: 9965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026ED")]
		[Address(RVA = "0x21B95A4", Offset = "0x21B95A4", VA = "0x7BBC9B95A4")]
		public DiamondSpendEventDesc()
		{
		}

		// Token: 0x04002DB4 RID: 11700
		[Token(Token = "0x4002DB4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111BC10", Offset = "0x111BC10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BC10", Offset = "0x111BC10")]
		public string region;

		// Token: 0x04002DB5 RID: 11701
		[Token(Token = "0x4002DB5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BC60", Offset = "0x111BC60")]
		public uint id;

		// Token: 0x04002DB6 RID: 11702
		[Token(Token = "0x4002DB6")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BC74", Offset = "0x111BC74")]
		public uint price_tier;

		// Token: 0x04002DB7 RID: 11703
		[Token(Token = "0x4002DB7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BC88", Offset = "0x111BC88")]
		public uint tier_diamond_min;

		// Token: 0x04002DB8 RID: 11704
		[Token(Token = "0x4002DB8")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BC9C", Offset = "0x111BC9C")]
		public float price;

		// Token: 0x04002DB9 RID: 11705
		[Token(Token = "0x4002DB9")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BCB0", Offset = "0x111BCB0")]
		public uint start_time_stamp;

		// Token: 0x04002DBA RID: 11706
		[Token(Token = "0x4002DBA")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BCC4", Offset = "0x111BCC4")]
		public uint end_time_stamp;

		// Token: 0x04002DBB RID: 11707
		[Token(Token = "0x4002DBB")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BCD8", Offset = "0x111BCD8")]
		public uint item_id;

		// Token: 0x04002DBC RID: 11708
		[Token(Token = "0x4002DBC")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BCEC", Offset = "0x111BCEC")]
		public uint rebate_id;

		// Token: 0x04002DBD RID: 11709
		[Token(Token = "0x4002DBD")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BD00", Offset = "0x111BD00")]
		public uint diamond_num;
	}
}
