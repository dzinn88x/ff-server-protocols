using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AB1 RID: 2737
	[Token(Token = "0x2000AB1")]
	[ProtoContract]
	public class MysteryShopDesc
	{
		// Token: 0x060027BB RID: 10171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BB")]
		[Address(RVA = "0x249E774", Offset = "0x249E774", VA = "0x7BBCC9E774")]
		public MysteryShopDesc()
		{
		}

		// Token: 0x04003367 RID: 13159
		[Token(Token = "0x4003367")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126A20", Offset = "0x1126A20")]
		public uint store_id;

		// Token: 0x04003368 RID: 13160
		[Token(Token = "0x4003368")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126A34", Offset = "0x1126A34")]
		public uint mystery_shop_pool_id;

		// Token: 0x04003369 RID: 13161
		[Token(Token = "0x4003369")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126A48", Offset = "0x1126A48")]
		public uint sort_id;

		// Token: 0x0400336A RID: 13162
		[Token(Token = "0x400336A")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126A5C", Offset = "0x1126A5C")]
		public uint item_id;

		// Token: 0x0400336B RID: 13163
		[Token(Token = "0x400336B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126A70", Offset = "0x1126A70")]
		public uint award_time;

		// Token: 0x0400336C RID: 13164
		[Token(Token = "0x400336C")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126A84", Offset = "0x1126A84")]
		public uint gems_price;

		// Token: 0x0400336D RID: 13165
		[Token(Token = "0x400336D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126A98", Offset = "0x1126A98")]
		public uint limited_purchase_times;

		// Token: 0x0400336E RID: 13166
		[Token(Token = "0x400336E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126AAC", Offset = "0x1126AAC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126AAC", Offset = "0x1126AAC")]
		public string reward_cdn;

		// Token: 0x0400336F RID: 13167
		[Token(Token = "0x400336F")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126AFC", Offset = "0x1126AFC")]
		public bool big_reward;

		// Token: 0x04003370 RID: 13168
		[Token(Token = "0x4003370")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126B10", Offset = "0x1126B10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126B10", Offset = "0x1126B10")]
		public string share_cdn;

		// Token: 0x04003371 RID: 13169
		[Token(Token = "0x4003371")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126B60", Offset = "0x1126B60")]
		public EInventory.AwardType repeat_change_item_type;

		// Token: 0x04003372 RID: 13170
		[Token(Token = "0x4003372")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126B74", Offset = "0x1126B74")]
		public uint repeat_change_item_id;

		// Token: 0x04003373 RID: 13171
		[Token(Token = "0x4003373")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126B88", Offset = "0x1126B88")]
		public uint repeat_change_item_num;

		// Token: 0x04003374 RID: 13172
		[Token(Token = "0x4003374")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126B9C", Offset = "0x1126B9C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126B9C", Offset = "0x1126B9C")]
		public string language;
	}
}
