using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ACC RID: 2764
	[Token(Token = "0x2000ACC")]
	[ProtoContract]
	public class PVPCardInfo
	{
		// Token: 0x060027D4 RID: 10196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D4")]
		[Address(RVA = "0x249EF00", Offset = "0x249EF00", VA = "0x7BBCC9EF00")]
		public PVPCardInfo()
		{
		}

		// Token: 0x040033EB RID: 13291
		[Token(Token = "0x40033EB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127768", Offset = "0x1127768")]
		public bool enable_flip;

		// Token: 0x040033EC RID: 13292
		[Token(Token = "0x40033EC")]
		[FieldOffset(Offset = "0x11")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112777C", Offset = "0x112777C")]
		public bool win_award;

		// Token: 0x040033ED RID: 13293
		[Token(Token = "0x40033ED")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127790", Offset = "0x1127790")]
		public List<CardPrice> card_price;

		// Token: 0x040033EE RID: 13294
		[Token(Token = "0x40033EE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11277A4", Offset = "0x11277A4")]
		public List<AwardFromCard> awards;

		// Token: 0x040033EF RID: 13295
		[Token(Token = "0x40033EF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11277B8", Offset = "0x11277B8")]
		public uint flip_count_today;

		// Token: 0x040033F0 RID: 13296
		[Token(Token = "0x40033F0")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11277CC", Offset = "0x11277CC")]
		public uint flip_count_max;

		// Token: 0x040033F1 RID: 13297
		[Token(Token = "0x40033F1")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11277E0", Offset = "0x11277E0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11277E0", Offset = "0x11277E0")]
		public string back_image_url;
	}
}
