using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000730 RID: 1840
	[Token(Token = "0x2000730")]
	[ProtoContract]
	public class ClanLeaderboardItem
	{
		// Token: 0x0600243D RID: 9277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243D")]
		[Address(RVA = "0x21B8760", Offset = "0x21B8760", VA = "0x7BBC9B8760")]
		public ClanLeaderboardItem()
		{
		}

		// Token: 0x0400247D RID: 9341
		[Token(Token = "0x400247D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C684", Offset = "0x110C684")]
		public ulong clan_id;

		// Token: 0x0400247E RID: 9342
		[Token(Token = "0x400247E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C698", Offset = "0x110C698")]
		public double score;

		// Token: 0x0400247F RID: 9343
		[Token(Token = "0x400247F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C6AC", Offset = "0x110C6AC")]
		public ClanLeaderboardProfile clan_profile;

		// Token: 0x04002480 RID: 9344
		[Token(Token = "0x4002480")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C6C0", Offset = "0x110C6C0")]
		public int pos;
	}
}
