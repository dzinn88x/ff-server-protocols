using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AFD RID: 2813
	[Token(Token = "0x2000AFD")]
	[ProtoContract]
	public class SubscribeStoreDesc
	{
		// Token: 0x06002805 RID: 10245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002805")]
		[Address(RVA = "0x24A0A3C", Offset = "0x24A0A3C", VA = "0x7BBCCA0A3C")]
		public SubscribeStoreDesc()
		{
		}

		// Token: 0x040034FF RID: 13567
		[Token(Token = "0x40034FF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129A04", Offset = "0x1129A04")]
		public uint store_id;

		// Token: 0x04003500 RID: 13568
		[Token(Token = "0x4003500")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129A18", Offset = "0x1129A18")]
		public uint sort_id;

		// Token: 0x04003501 RID: 13569
		[Token(Token = "0x4003501")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129A2C", Offset = "0x1129A2C")]
		public long added_time;

		// Token: 0x04003502 RID: 13570
		[Token(Token = "0x4003502")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129A40", Offset = "0x1129A40")]
		public long expire_time;

		// Token: 0x04003503 RID: 13571
		[Token(Token = "0x4003503")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129A54", Offset = "0x1129A54")]
		public ESubscription.SubscribeType subscribe_type;

		// Token: 0x04003504 RID: 13572
		[Token(Token = "0x4003504")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129A68", Offset = "0x1129A68")]
		public uint item_id;

		// Token: 0x04003505 RID: 13573
		[Token(Token = "0x4003505")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1129A7C", Offset = "0x1129A7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129A7C", Offset = "0x1129A7C")]
		public string item_name;

		// Token: 0x04003506 RID: 13574
		[Token(Token = "0x4003506")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129ACC", Offset = "0x1129ACC")]
		public uint price_item_id;

		// Token: 0x04003507 RID: 13575
		[Token(Token = "0x4003507")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129AE0", Offset = "0x1129AE0")]
		public uint price_rebate_id;

		// Token: 0x04003508 RID: 13576
		[Token(Token = "0x4003508")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129AF4", Offset = "0x1129AF4")]
		public float price;

		// Token: 0x04003509 RID: 13577
		[Token(Token = "0x4003509")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129B08", Offset = "0x1129B08")]
		public ESubscription.PriceType price_type;

		// Token: 0x0400350A RID: 13578
		[Token(Token = "0x400350A")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129B1C", Offset = "0x1129B1C")]
		public ESubscription.TagType tag_type;

		// Token: 0x0400350B RID: 13579
		[Token(Token = "0x400350B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1129B30", Offset = "0x1129B30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129B30", Offset = "0x1129B30")]
		public string icon_url;

		// Token: 0x0400350C RID: 13580
		[Token(Token = "0x400350C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129B80", Offset = "0x1129B80")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1129B80", Offset = "0x1129B80")]
		public string preview_url;

		// Token: 0x0400350D RID: 13581
		[Token(Token = "0x400350D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129BD0", Offset = "0x1129BD0")]
		public uint subscribe_bonus;

		// Token: 0x0400350E RID: 13582
		[Token(Token = "0x400350E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129BE4", Offset = "0x1129BE4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1129BE4", Offset = "0x1129BE4")]
		public string language;

		// Token: 0x0400350F RID: 13583
		[Token(Token = "0x400350F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129C34", Offset = "0x1129C34")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1129C34", Offset = "0x1129C34")]
		public string real_icon_url;

		// Token: 0x04003510 RID: 13584
		[Token(Token = "0x4003510")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129C84", Offset = "0x1129C84")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1129C84", Offset = "0x1129C84")]
		public string real_preview_url;

		// Token: 0x04003511 RID: 13585
		[Token(Token = "0x4003511")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129CD4", Offset = "0x1129CD4")]
		public float intro_price;

		// Token: 0x04003512 RID: 13586
		[Token(Token = "0x4003512")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129CE8", Offset = "0x1129CE8")]
		public uint intro_time;
	}
}
