using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000731 RID: 1841
	[Token(Token = "0x2000731")]
	[ProtoContract]
	public class TeamLeaderboardItem
	{
		// Token: 0x0600243E RID: 9278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243E")]
		[Address(RVA = "0x24A0E10", Offset = "0x24A0E10", VA = "0x7BBCCA0E10")]
		public TeamLeaderboardItem()
		{
		}

		// Token: 0x04002481 RID: 9345
		[Token(Token = "0x4002481")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C6D4", Offset = "0x110C6D4")]
		public ulong team_id;

		// Token: 0x04002482 RID: 9346
		[Token(Token = "0x4002482")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C6E8", Offset = "0x110C6E8")]
		public double score;

		// Token: 0x04002483 RID: 9347
		[Token(Token = "0x4002483")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C6FC", Offset = "0x110C6FC")]
		public TeamLeaderboardProfile team_profile;

		// Token: 0x04002484 RID: 9348
		[Token(Token = "0x4002484")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C710", Offset = "0x110C710")]
		public int pos;
	}
}
