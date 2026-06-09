using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008B9 RID: 2233
	[Token(Token = "0x20008B9")]
	[ProtoContract]
	public class CSPayBundleWindowPurchaseReq
	{
		// Token: 0x060025C7 RID: 9671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C7")]
		[Address(RVA = "0x21B6D8C", Offset = "0x21B6D8C", VA = "0x7BBC9B6D8C")]
		public CSPayBundleWindowPurchaseReq()
		{
		}

		// Token: 0x04002A02 RID: 10754
		[Token(Token = "0x4002A02")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111642C", Offset = "0x111642C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111642C", Offset = "0x111642C")]
		public string login_token;

		// Token: 0x04002A03 RID: 10755
		[Token(Token = "0x4002A03")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111647C", Offset = "0x111647C")]
		public uint rebate_card_id;

		// Token: 0x04002A04 RID: 10756
		[Token(Token = "0x4002A04")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116490", Offset = "0x1116490")]
		public uint id;

		// Token: 0x04002A05 RID: 10757
		[Token(Token = "0x4002A05")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11164A4", Offset = "0x11164A4")]
		public EStore.PbwConsumeType consume_type;

		// Token: 0x04002A06 RID: 10758
		[Token(Token = "0x4002A06")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11164B8", Offset = "0x11164B8")]
		public uint rebate_card_end_timestamp;
	}
}
