using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A66 RID: 2662
	[Token(Token = "0x2000A66")]
	[ProtoContract]
	public class AwakenComicDesc
	{
		// Token: 0x06002770 RID: 10096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002770")]
		[Address(RVA = "0x21AF5C0", Offset = "0x21AF5C0", VA = "0x7BBC9AF5C0")]
		public AwakenComicDesc()
		{
		}

		// Token: 0x040030AB RID: 12459
		[Token(Token = "0x40030AB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121818", Offset = "0x1121818")]
		public uint original_avatar_id;

		// Token: 0x040030AC RID: 12460
		[Token(Token = "0x40030AC")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112182C", Offset = "0x112182C")]
		public uint comic_id;

		// Token: 0x040030AD RID: 12461
		[Token(Token = "0x40030AD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121840", Offset = "0x1121840")]
		public uint unlock_item_id;

		// Token: 0x040030AE RID: 12462
		[Token(Token = "0x40030AE")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121854", Offset = "0x1121854")]
		public uint unlock_item_cnt;
	}
}
