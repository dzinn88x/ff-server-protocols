using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A3F RID: 2623
	[Token(Token = "0x2000A3F")]
	[ProtoContract]
	public class ClanRacePointsGainDesc
	{
		// Token: 0x06002749 RID: 10057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002749")]
		[Address(RVA = "0x21B8A24", Offset = "0x21B8A24", VA = "0x7BBC9B8A24")]
		public ClanRacePointsGainDesc()
		{
		}

		// Token: 0x04002FD5 RID: 12245
		[Token(Token = "0x4002FD5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11201C0", Offset = "0x11201C0")]
		public uint id;

		// Token: 0x04002FD6 RID: 12246
		[Token(Token = "0x4002FD6")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11201D4", Offset = "0x11201D4")]
		public uint type;

		// Token: 0x04002FD7 RID: 12247
		[Token(Token = "0x4002FD7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11201E8", Offset = "0x11201E8")]
		public uint race_points;

		// Token: 0x04002FD8 RID: 12248
		[Token(Token = "0x4002FD8")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11201FC", Offset = "0x11201FC")]
		public uint rank_solo;

		// Token: 0x04002FD9 RID: 12249
		[Token(Token = "0x4002FD9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120210", Offset = "0x1120210")]
		public uint rank_duo;

		// Token: 0x04002FDA RID: 12250
		[Token(Token = "0x4002FDA")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120224", Offset = "0x1120224")]
		public uint rank_squad;

		// Token: 0x04002FDB RID: 12251
		[Token(Token = "0x4002FDB")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120238", Offset = "0x1120238")]
		public uint match_mode;

		// Token: 0x04002FDC RID: 12252
		[Token(Token = "0x4002FDC")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112024C", Offset = "0x112024C")]
		public uint game_mode;
	}
}
