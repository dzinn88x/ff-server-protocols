using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A32 RID: 2610
	[Token(Token = "0x2000A32")]
	[ProtoContract]
	public class WarmGameConfigDesc
	{
		// Token: 0x0600273C RID: 10044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273C")]
		[Address(RVA = "0x24A17E4", Offset = "0x24A17E4", VA = "0x7BBCCA17E4")]
		public WarmGameConfigDesc()
		{
		}

		// Token: 0x04002F9E RID: 12190
		[Token(Token = "0x4002F9E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FC48", Offset = "0x111FC48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111FC48", Offset = "0x111FC48")]
		public string region;

		// Token: 0x04002F9F RID: 12191
		[Token(Token = "0x4002F9F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FC98", Offset = "0x111FC98")]
		public EAccount.WarmGameType type;

		// Token: 0x04002FA0 RID: 12192
		[Token(Token = "0x4002FA0")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FCAC", Offset = "0x111FCAC")]
		public uint warm_games;

		// Token: 0x04002FA1 RID: 12193
		[Token(Token = "0x4002FA1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FCC0", Offset = "0x111FCC0")]
		public uint[] warm_game_level;

		// Token: 0x04002FA2 RID: 12194
		[Token(Token = "0x4002FA2")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FCFC", Offset = "0x111FCFC")]
		public bool is_open;
	}
}
