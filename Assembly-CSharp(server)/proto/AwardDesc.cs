using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009DF RID: 2527
	[Token(Token = "0x20009DF")]
	[ProtoContract]
	public class AwardDesc
	{
		// Token: 0x060026E9 RID: 9961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E9")]
		[Address(RVA = "0x21AF6B8", Offset = "0x21AF6B8", VA = "0x7BBC9AF6B8")]
		public AwardDesc()
		{
		}

		// Token: 0x04002DA1 RID: 11681
		[Token(Token = "0x4002DA1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B9A4", Offset = "0x111B9A4")]
		public EInventory.AwardType award_type;

		// Token: 0x04002DA2 RID: 11682
		[Token(Token = "0x4002DA2")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B9B8", Offset = "0x111B9B8")]
		public uint award_id;

		// Token: 0x04002DA3 RID: 11683
		[Token(Token = "0x4002DA3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B9CC", Offset = "0x111B9CC")]
		public uint award_num;

		// Token: 0x04002DA4 RID: 11684
		[Token(Token = "0x4002DA4")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B9E0", Offset = "0x111B9E0")]
		public uint award_max_num;

		// Token: 0x04002DA5 RID: 11685
		[Token(Token = "0x4002DA5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B9F4", Offset = "0x111B9F4")]
		public uint award_expire_time;
	}
}
