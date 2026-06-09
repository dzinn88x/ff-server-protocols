using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A9D RID: 2717
	[Token(Token = "0x2000A9D")]
	[ProtoContract]
	public class GiftRankDesc
	{
		// Token: 0x060027A7 RID: 10151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A7")]
		[Address(RVA = "0x21BAC48", Offset = "0x21BAC48", VA = "0x7BBC9BAC48")]
		public GiftRankDesc()
		{
		}

		// Token: 0x040032B0 RID: 12976
		[Token(Token = "0x40032B0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125210", Offset = "0x1125210")]
		public uint rank_id;

		// Token: 0x040032B1 RID: 12977
		[Token(Token = "0x40032B1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125224", Offset = "0x1125224")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1125224", Offset = "0x1125224")]
		public string rank_name;

		// Token: 0x040032B2 RID: 12978
		[Token(Token = "0x40032B2")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1125274", Offset = "0x1125274")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125274", Offset = "0x1125274")]
		public string open_time;

		// Token: 0x040032B3 RID: 12979
		[Token(Token = "0x40032B3")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11252C4", Offset = "0x11252C4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11252C4", Offset = "0x11252C4")]
		public string close_time;

		// Token: 0x040032B4 RID: 12980
		[Token(Token = "0x40032B4")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125314", Offset = "0x1125314")]
		public bool is_time_show;

		// Token: 0x040032B5 RID: 12981
		[Token(Token = "0x40032B5")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125328", Offset = "0x1125328")]
		public uint giver_item_id;

		// Token: 0x040032B6 RID: 12982
		[Token(Token = "0x40032B6")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112533C", Offset = "0x112533C")]
		public uint receiver_item_id;

		// Token: 0x040032B7 RID: 12983
		[Token(Token = "0x40032B7")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125350", Offset = "0x1125350")]
		public uint gift_ratio;
	}
}
