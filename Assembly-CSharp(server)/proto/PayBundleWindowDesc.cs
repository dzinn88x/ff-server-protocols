using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AA7 RID: 2727
	[Token(Token = "0x2000AA7")]
	[ProtoContract]
	public class PayBundleWindowDesc
	{
		// Token: 0x060027B1 RID: 10161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B1")]
		[Address(RVA = "0x249EFBC", Offset = "0x249EFBC", VA = "0x7BBCC9EFBC")]
		public PayBundleWindowDesc()
		{
		}

		// Token: 0x0400331D RID: 13085
		[Token(Token = "0x400331D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112605C", Offset = "0x112605C")]
		public uint id;

		// Token: 0x0400331E RID: 13086
		[Token(Token = "0x400331E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126070", Offset = "0x1126070")]
		public uint index_id;

		// Token: 0x0400331F RID: 13087
		[Token(Token = "0x400331F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126084", Offset = "0x1126084")]
		public uint price_item_id;

		// Token: 0x04003320 RID: 13088
		[Token(Token = "0x4003320")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126098", Offset = "0x1126098")]
		public float price;

		// Token: 0x04003321 RID: 13089
		[Token(Token = "0x4003321")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11260AC", Offset = "0x11260AC")]
		public uint discount_price_rebate_id;

		// Token: 0x04003322 RID: 13090
		[Token(Token = "0x4003322")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11260C0", Offset = "0x11260C0")]
		public uint discount_price_item_id;

		// Token: 0x04003323 RID: 13091
		[Token(Token = "0x4003323")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11260D4", Offset = "0x11260D4")]
		public float discount_price;

		// Token: 0x04003324 RID: 13092
		[Token(Token = "0x4003324")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11260E8", Offset = "0x11260E8")]
		public uint rebate_percentage;

		// Token: 0x04003325 RID: 13093
		[Token(Token = "0x4003325")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11260FC", Offset = "0x11260FC")]
		public uint limited_purchase;

		// Token: 0x04003326 RID: 13094
		[Token(Token = "0x4003326")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126110", Offset = "0x1126110")]
		public uint purchase_times;

		// Token: 0x04003327 RID: 13095
		[Token(Token = "0x4003327")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126124", Offset = "0x1126124")]
		public List<AwardDesc> awards;

		// Token: 0x04003328 RID: 13096
		[Token(Token = "0x4003328")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126138", Offset = "0x1126138")]
		public EStore.RebateCardBillStatus status;

		// Token: 0x04003329 RID: 13097
		[Token(Token = "0x4003329")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112614C", Offset = "0x112614C")]
		public uint diamond_price;

		// Token: 0x0400332A RID: 13098
		[Token(Token = "0x400332A")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126160", Offset = "0x1126160")]
		public uint diamond_discount_price;

		// Token: 0x0400332B RID: 13099
		[Token(Token = "0x400332B")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126174", Offset = "0x1126174")]
		public uint start_timestamp;

		// Token: 0x0400332C RID: 13100
		[Token(Token = "0x400332C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126188", Offset = "0x1126188")]
		public uint end_timestamp;

		// Token: 0x0400332D RID: 13101
		[Token(Token = "0x400332D")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112619C", Offset = "0x112619C")]
		public EStore.BundleRefreshType refresh_type;

		// Token: 0x0400332E RID: 13102
		[Token(Token = "0x400332E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11261B0", Offset = "0x11261B0")]
		public uint tag;

		// Token: 0x0400332F RID: 13103
		[Token(Token = "0x400332F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11261C4", Offset = "0x11261C4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11261C4", Offset = "0x11261C4")]
		public string bundle_name;

		// Token: 0x04003330 RID: 13104
		[Token(Token = "0x4003330")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126214", Offset = "0x1126214")]
		public EStore.PbwActivityType activity_type;

		// Token: 0x04003331 RID: 13105
		[Token(Token = "0x4003331")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126228", Offset = "0x1126228")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126228", Offset = "0x1126228")]
		public string cdn;

		// Token: 0x04003332 RID: 13106
		[Token(Token = "0x4003332")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126278", Offset = "0x1126278")]
		public uint rebate_card_end_timestamp;
	}
}
