using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000892 RID: 2194
	[Token(Token = "0x2000892")]
	[ProtoContract]
	public class GetBasicEPInfoRes
	{
		// Token: 0x060025A0 RID: 9632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A0")]
		[Address(RVA = "0x21BA9EC", Offset = "0x21BA9EC", VA = "0x7BBC9BA9EC")]
		public GetBasicEPInfoRes()
		{
		}

		// Token: 0x040028E7 RID: 10471
		[Token(Token = "0x40028E7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113CA4", Offset = "0x1113CA4")]
		public bool owned_pass;

		// Token: 0x040028E8 RID: 10472
		[Token(Token = "0x40028E8")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113CB8", Offset = "0x1113CB8")]
		public uint ep_event_id;

		// Token: 0x040028E9 RID: 10473
		[Token(Token = "0x40028E9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113CCC", Offset = "0x1113CCC")]
		public long start_time;

		// Token: 0x040028EA RID: 10474
		[Token(Token = "0x40028EA")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113CE0", Offset = "0x1113CE0")]
		public long end_time;

		// Token: 0x040028EB RID: 10475
		[Token(Token = "0x40028EB")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113CF4", Offset = "0x1113CF4")]
		public uint ep_badge;

		// Token: 0x040028EC RID: 10476
		[Token(Token = "0x40028EC")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113D08", Offset = "0x1113D08")]
		public uint gold_limit_improved;

		// Token: 0x040028ED RID: 10477
		[Token(Token = "0x40028ED")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113D1C", Offset = "0x1113D1C")]
		public bool owned_fp_challenge;

		// Token: 0x040028EE RID: 10478
		[Token(Token = "0x40028EE")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113D30", Offset = "0x1113D30")]
		public uint badge_cnt;
	}
}
