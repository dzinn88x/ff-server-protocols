using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AEA RID: 2794
	[Token(Token = "0x2000AEA")]
	[ProtoContract]
	public class AntiAddictionConfigDesc
	{
		// Token: 0x060027F2 RID: 10226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F2")]
		[Address(RVA = "0x21AF168", Offset = "0x21AF168", VA = "0x7BBC9AF168")]
		public AntiAddictionConfigDesc()
		{
		}

		// Token: 0x040034A1 RID: 13473
		[Token(Token = "0x40034A1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128D5C", Offset = "0x1128D5C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1128D5C", Offset = "0x1128D5C")]
		public string country;

		// Token: 0x040034A2 RID: 13474
		[Token(Token = "0x40034A2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128DAC", Offset = "0x1128DAC")]
		public EAntiAddiction.AgeState age;

		// Token: 0x040034A3 RID: 13475
		[Token(Token = "0x40034A3")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128DC0", Offset = "0x1128DC0")]
		public uint duration1;

		// Token: 0x040034A4 RID: 13476
		[Token(Token = "0x40034A4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128DD4", Offset = "0x1128DD4")]
		public uint duration2;

		// Token: 0x040034A5 RID: 13477
		[Token(Token = "0x40034A5")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128DE8", Offset = "0x1128DE8")]
		public uint duration3;

		// Token: 0x040034A6 RID: 13478
		[Token(Token = "0x40034A6")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128DFC", Offset = "0x1128DFC")]
		public uint rest_time;

		// Token: 0x040034A7 RID: 13479
		[Token(Token = "0x40034A7")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128E10", Offset = "0x1128E10")]
		public uint total_time;

		// Token: 0x040034A8 RID: 13480
		[Token(Token = "0x40034A8")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128E24", Offset = "0x1128E24")]
		public EAntiAddiction.TotalTimeBanMode total_time_ban_mode;

		// Token: 0x040034A9 RID: 13481
		[Token(Token = "0x40034A9")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128E38", Offset = "0x1128E38")]
		public EAntiAddiction.HintType hint_type;

		// Token: 0x040034AA RID: 13482
		[Token(Token = "0x40034AA")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1128E4C", Offset = "0x1128E4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128E4C", Offset = "0x1128E4C")]
		public string hint_title1;

		// Token: 0x040034AB RID: 13483
		[Token(Token = "0x40034AB")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1128E9C", Offset = "0x1128E9C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128E9C", Offset = "0x1128E9C")]
		public string hint_title2;

		// Token: 0x040034AC RID: 13484
		[Token(Token = "0x40034AC")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1128EEC", Offset = "0x1128EEC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128EEC", Offset = "0x1128EEC")]
		public string hint_string1;

		// Token: 0x040034AD RID: 13485
		[Token(Token = "0x40034AD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128F3C", Offset = "0x1128F3C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1128F3C", Offset = "0x1128F3C")]
		public string hint_string2;
	}
}
