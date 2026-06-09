using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A98 RID: 2712
	[Token(Token = "0x2000A98")]
	[ProtoContract]
	public class ChestSpecialExchangeDesc
	{
		// Token: 0x060027A2 RID: 10146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A2")]
		[Address(RVA = "0x21B8418", Offset = "0x21B8418", VA = "0x7BBC9B8418")]
		public ChestSpecialExchangeDesc()
		{
		}

		// Token: 0x0400327A RID: 12922
		[Token(Token = "0x400327A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124ACC", Offset = "0x1124ACC")]
		public uint forge_tab_id;

		// Token: 0x0400327B RID: 12923
		[Token(Token = "0x400327B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1124AE0", Offset = "0x1124AE0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124AE0", Offset = "0x1124AE0")]
		public string tab_name;

		// Token: 0x0400327C RID: 12924
		[Token(Token = "0x400327C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124B30", Offset = "0x1124B30")]
		public uint item_id;

		// Token: 0x0400327D RID: 12925
		[Token(Token = "0x400327D")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124B44", Offset = "0x1124B44")]
		public uint item_num;

		// Token: 0x0400327E RID: 12926
		[Token(Token = "0x400327E")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124B58", Offset = "0x1124B58")]
		public uint sort_id;

		// Token: 0x0400327F RID: 12927
		[Token(Token = "0x400327F")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124B6C", Offset = "0x1124B6C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1124B6C", Offset = "0x1124B6C")]
		public string added_time;

		// Token: 0x04003280 RID: 12928
		[Token(Token = "0x4003280")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1124BBC", Offset = "0x1124BBC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124BBC", Offset = "0x1124BBC")]
		public string expire_time;

		// Token: 0x04003281 RID: 12929
		[Token(Token = "0x4003281")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124C0C", Offset = "0x1124C0C")]
		public uint limited_purchase_times;

		// Token: 0x04003282 RID: 12930
		[Token(Token = "0x4003282")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1124C20", Offset = "0x1124C20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124C20", Offset = "0x1124C20")]
		public string language;

		// Token: 0x04003283 RID: 12931
		[Token(Token = "0x4003283")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1124C70", Offset = "0x1124C70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124C70", Offset = "0x1124C70")]
		public string image_url;

		// Token: 0x04003284 RID: 12932
		[Token(Token = "0x4003284")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124CC0", Offset = "0x1124CC0")]
		public bool is_show;

		// Token: 0x04003285 RID: 12933
		[Token(Token = "0x4003285")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124CD4", Offset = "0x1124CD4")]
		public List<AwardDesc> exchange_items;

		// Token: 0x04003286 RID: 12934
		[Token(Token = "0x4003286")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124CE8", Offset = "0x1124CE8")]
		public uint reward_level;

		// Token: 0x04003287 RID: 12935
		[Token(Token = "0x4003287")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1124CFC", Offset = "0x1124CFC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124CFC", Offset = "0x1124CFC")]
		public string real_image_url;

		// Token: 0x04003288 RID: 12936
		[Token(Token = "0x4003288")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124D4C", Offset = "0x1124D4C")]
		public uint purchase_times;

		// Token: 0x04003289 RID: 12937
		[Token(Token = "0x4003289")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124D60", Offset = "0x1124D60")]
		public uint item_duration;

		// Token: 0x0400328A RID: 12938
		[Token(Token = "0x400328A")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124D74", Offset = "0x1124D74")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1124D74", Offset = "0x1124D74")]
		public string effect_icon;
	}
}
