using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009E4 RID: 2532
	[Token(Token = "0x20009E4")]
	[ProtoContract]
	public class OfferConditionDesc
	{
		// Token: 0x060026EE RID: 9966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026EE")]
		[Address(RVA = "0x249EC74", Offset = "0x249EC74", VA = "0x7BBCC9EC74")]
		public OfferConditionDesc()
		{
		}

		// Token: 0x04002DBE RID: 11710
		[Token(Token = "0x4002DBE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BD14", Offset = "0x111BD14")]
		public uint offer_id;

		// Token: 0x04002DBF RID: 11711
		[Token(Token = "0x4002DBF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BD28", Offset = "0x111BD28")]
		public long offer_start_time;

		// Token: 0x04002DC0 RID: 11712
		[Token(Token = "0x4002DC0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BD3C", Offset = "0x111BD3C")]
		public long offer_end_time;

		// Token: 0x04002DC1 RID: 11713
		[Token(Token = "0x4002DC1")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BD50", Offset = "0x111BD50")]
		public uint expend_diamond;

		// Token: 0x04002DC2 RID: 11714
		[Token(Token = "0x4002DC2")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BD64", Offset = "0x111BD64")]
		public uint offer_chance;

		// Token: 0x04002DC3 RID: 11715
		[Token(Token = "0x4002DC3")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BD78", Offset = "0x111BD78")]
		public uint offer_appear_time;
	}
}
