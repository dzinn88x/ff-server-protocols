using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000707 RID: 1799
	[Token(Token = "0x2000707")]
	[ProtoContract]
	public class DebrisDetail
	{
		// Token: 0x06002415 RID: 9237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002415")]
		[Address(RVA = "0x21B9468", Offset = "0x21B9468", VA = "0x7BBC9B9468")]
		public DebrisDetail()
		{
		}

		// Token: 0x040023D5 RID: 9173
		[Token(Token = "0x40023D5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B6BC", Offset = "0x110B6BC")]
		public Item debris;

		// Token: 0x040023D6 RID: 9174
		[Token(Token = "0x40023D6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B6D0", Offset = "0x110B6D0")]
		public uint debris_gained_today;

		// Token: 0x040023D7 RID: 9175
		[Token(Token = "0x40023D7")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B6E4", Offset = "0x110B6E4")]
		public uint debris_gain_limit;

		// Token: 0x040023D8 RID: 9176
		[Token(Token = "0x40023D8")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B6F8", Offset = "0x110B6F8")]
		public bool debris_reach_avatar_limit;

		// Token: 0x040023D9 RID: 9177
		[Token(Token = "0x40023D9")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B70C", Offset = "0x110B70C")]
		public DebrisDetail.Source source;

		// Token: 0x02000708 RID: 1800
		[Token(Token = "0x2000708")]
		[ProtoContract]
		public enum Source
		{
			// Token: 0x040023DB RID: 9179
			[Token(Token = "0x40023DB")]
			NONE,
			// Token: 0x040023DC RID: 9180
			[Token(Token = "0x40023DC")]
			AVATAR,
			// Token: 0x040023DD RID: 9181
			[Token(Token = "0x40023DD")]
			SKILL
		}
	}
}
