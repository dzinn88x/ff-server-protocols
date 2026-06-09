using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ACD RID: 2765
	[Token(Token = "0x2000ACD")]
	[ProtoContract]
	public class PVECardInfo
	{
		// Token: 0x060027D5 RID: 10197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D5")]
		[Address(RVA = "0x249EE2C", Offset = "0x249EE2C", VA = "0x7BBCC9EE2C")]
		public PVECardInfo()
		{
		}

		// Token: 0x040033F2 RID: 13298
		[Token(Token = "0x40033F2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127830", Offset = "0x1127830")]
		public bool enable_flip;

		// Token: 0x040033F3 RID: 13299
		[Token(Token = "0x40033F3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127844", Offset = "0x1127844")]
		public List<CardPrice> card_price;

		// Token: 0x040033F4 RID: 13300
		[Token(Token = "0x40033F4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127858", Offset = "0x1127858")]
		public List<AwardFromCard> awards;

		// Token: 0x040033F5 RID: 13301
		[Token(Token = "0x40033F5")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112786C", Offset = "0x112786C")]
		public uint flip_count_today;

		// Token: 0x040033F6 RID: 13302
		[Token(Token = "0x40033F6")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127880", Offset = "0x1127880")]
		public uint flip_count_max;

		// Token: 0x040033F7 RID: 13303
		[Token(Token = "0x40033F7")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127894", Offset = "0x1127894")]
		public List<CardImageDesc> back_image;

		// Token: 0x040033F8 RID: 13304
		[Token(Token = "0x40033F8")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11278A8", Offset = "0x11278A8")]
		public uint match_rank;
	}
}
