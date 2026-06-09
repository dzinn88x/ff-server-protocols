using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A9C RID: 2716
	[Token(Token = "0x2000A9C")]
	[ProtoContract]
	public class GiftStoreItemDesc
	{
		// Token: 0x060027A6 RID: 10150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A6")]
		[Address(RVA = "0x21BADD4", Offset = "0x21BADD4", VA = "0x7BBC9BADD4")]
		public GiftStoreItemDesc()
		{
		}

		// Token: 0x0400329C RID: 12956
		[Token(Token = "0x400329C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124FCC", Offset = "0x1124FCC")]
		public uint store_id;

		// Token: 0x0400329D RID: 12957
		[Token(Token = "0x400329D")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124FE0", Offset = "0x1124FE0")]
		public uint commodity_id;

		// Token: 0x0400329E RID: 12958
		[Token(Token = "0x400329E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124FF4", Offset = "0x1124FF4")]
		public uint sort_id;

		// Token: 0x0400329F RID: 12959
		[Token(Token = "0x400329F")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125008", Offset = "0x1125008")]
		public uint item_id;

		// Token: 0x040032A0 RID: 12960
		[Token(Token = "0x40032A0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112501C", Offset = "0x112501C")]
		public uint coins_price;

		// Token: 0x040032A1 RID: 12961
		[Token(Token = "0x40032A1")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125030", Offset = "0x1125030")]
		public uint gems_price;

		// Token: 0x040032A2 RID: 12962
		[Token(Token = "0x40032A2")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125044", Offset = "0x1125044")]
		public uint tag_type;

		// Token: 0x040032A3 RID: 12963
		[Token(Token = "0x40032A3")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125058", Offset = "0x1125058")]
		public uint tag_value;

		// Token: 0x040032A4 RID: 12964
		[Token(Token = "0x40032A4")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112506C", Offset = "0x112506C")]
		public EInventory.AwardType return_type;

		// Token: 0x040032A5 RID: 12965
		[Token(Token = "0x40032A5")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125080", Offset = "0x1125080")]
		public uint return_id;

		// Token: 0x040032A6 RID: 12966
		[Token(Token = "0x40032A6")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125094", Offset = "0x1125094")]
		public uint return_num;

		// Token: 0x040032A7 RID: 12967
		[Token(Token = "0x40032A7")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11250A8", Offset = "0x11250A8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11250A8", Offset = "0x11250A8")]
		public string added_time;

		// Token: 0x040032A8 RID: 12968
		[Token(Token = "0x40032A8")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11250F8", Offset = "0x11250F8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11250F8", Offset = "0x11250F8")]
		public string expire_time;

		// Token: 0x040032A9 RID: 12969
		[Token(Token = "0x40032A9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125148", Offset = "0x1125148")]
		public uint type_override;

		// Token: 0x040032AA RID: 12970
		[Token(Token = "0x40032AA")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112515C", Offset = "0x112515C")]
		public bool is_original_type_remain;

		// Token: 0x040032AB RID: 12971
		[Token(Token = "0x40032AB")]
		[FieldOffset(Offset = "0x55")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125170", Offset = "0x1125170")]
		public bool is_exclusive;

		// Token: 0x040032AC RID: 12972
		[Token(Token = "0x40032AC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125184", Offset = "0x1125184")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1125184", Offset = "0x1125184")]
		public string image_url;

		// Token: 0x040032AD RID: 12973
		[Token(Token = "0x40032AD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11251D4", Offset = "0x11251D4")]
		public bool is_quick_gift_recommended;

		// Token: 0x040032AE RID: 12974
		[Token(Token = "0x40032AE")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11251E8", Offset = "0x11251E8")]
		public uint award_time;

		// Token: 0x040032AF RID: 12975
		[Token(Token = "0x40032AF")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11251FC", Offset = "0x11251FC")]
		public long expire_timestamp;
	}
}
