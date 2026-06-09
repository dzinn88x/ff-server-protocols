using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A0C RID: 2572
	[Token(Token = "0x2000A0C")]
	[ProtoContract]
	public class GameOpeningInfoRes
	{
		// Token: 0x06002716 RID: 10006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002716")]
		[Address(RVA = "0x21BA8F0", Offset = "0x21BA8F0", VA = "0x7BBC9BA8F0")]
		public GameOpeningInfoRes()
		{
		}

		// Token: 0x04002EF6 RID: 12022
		[Token(Token = "0x4002EF6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E5F0", Offset = "0x111E5F0")]
		public GameOpeningInfoDescList opening_info_list;

		// Token: 0x04002EF7 RID: 12023
		[Token(Token = "0x4002EF7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E604", Offset = "0x111E604")]
		public long timezone_offset_secs;

		// Token: 0x04002EF8 RID: 12024
		[Token(Token = "0x4002EF8")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E618", Offset = "0x111E618")]
		public GameModeNameList game_mode_name_list;

		// Token: 0x04002EF9 RID: 12025
		[Token(Token = "0x4002EF9")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E62C", Offset = "0x111E62C")]
		public ModeLevelLimitDescList mode_level_limit_list;

		// Token: 0x04002EFA RID: 12026
		[Token(Token = "0x4002EFA")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E640", Offset = "0x111E640")]
		public RankingLevelLimitDescList ranking_level_limit_list;
	}
}
