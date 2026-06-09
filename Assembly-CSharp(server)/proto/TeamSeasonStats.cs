using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200091C RID: 2332
	[Token(Token = "0x200091C")]
	[ProtoContract]
	public class TeamSeasonStats
	{
		// Token: 0x0600262A RID: 9770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262A")]
		[Address(RVA = "0x24A0F6C", Offset = "0x24A0F6C", VA = "0x7BBCCA0F6C")]
		public TeamSeasonStats()
		{
		}

		// Token: 0x04002B46 RID: 11078
		[Token(Token = "0x4002B46")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118664", Offset = "0x1118664")]
		public ulong team_id;

		// Token: 0x04002B47 RID: 11079
		[Token(Token = "0x4002B47")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118678", Offset = "0x1118678")]
		public uint championship_type;

		// Token: 0x04002B48 RID: 11080
		[Token(Token = "0x4002B48")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111868C", Offset = "0x111868C")]
		public uint championship_id;

		// Token: 0x04002B49 RID: 11081
		[Token(Token = "0x4002B49")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11186A0", Offset = "0x11186A0")]
		public uint kills;

		// Token: 0x04002B4A RID: 11082
		[Token(Token = "0x4002B4A")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11186B4", Offset = "0x11186B4")]
		public uint score;

		// Token: 0x04002B4B RID: 11083
		[Token(Token = "0x4002B4B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11186C8", Offset = "0x11186C8")]
		public uint pos;
	}
}
