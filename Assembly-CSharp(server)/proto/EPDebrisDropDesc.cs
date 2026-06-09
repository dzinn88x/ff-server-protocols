using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A8D RID: 2701
	[Token(Token = "0x2000A8D")]
	[ProtoContract]
	public class EPDebrisDropDesc
	{
		// Token: 0x06002797 RID: 10135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002797")]
		[Address(RVA = "0x21B991C", Offset = "0x21B991C", VA = "0x7BBC9B991C")]
		public EPDebrisDropDesc()
		{
		}

		// Token: 0x040031BB RID: 12731
		[Token(Token = "0x40031BB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123564", Offset = "0x1123564")]
		public uint ep_id;

		// Token: 0x040031BC RID: 12732
		[Token(Token = "0x40031BC")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123578", Offset = "0x1123578")]
		public uint debris_id;

		// Token: 0x040031BD RID: 12733
		[Token(Token = "0x40031BD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112358C", Offset = "0x112358C")]
		public uint kill_param;

		// Token: 0x040031BE RID: 12734
		[Token(Token = "0x40031BE")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11235A0", Offset = "0x11235A0")]
		public uint damage_param;

		// Token: 0x040031BF RID: 12735
		[Token(Token = "0x40031BF")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11235B4", Offset = "0x11235B4")]
		public uint rank_param;

		// Token: 0x040031C0 RID: 12736
		[Token(Token = "0x40031C0")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11235C8", Offset = "0x11235C8")]
		public uint drop_game_max;

		// Token: 0x040031C1 RID: 12737
		[Token(Token = "0x40031C1")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11235DC", Offset = "0x11235DC")]
		public uint drop_daily_max;
	}
}
