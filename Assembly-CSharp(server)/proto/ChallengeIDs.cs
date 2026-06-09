using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005F2 RID: 1522
	[Token(Token = "0x20005F2")]
	[ProtoContract]
	public class ChallengeIDs
	{
		// Token: 0x06002372 RID: 9074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002372")]
		[Address(RVA = "0x21B7F54", Offset = "0x21B7F54", VA = "0x7BBC9B7F54")]
		public ChallengeIDs()
		{
		}

		// Token: 0x04001E74 RID: 7796
		[Token(Token = "0x4001E74")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106B94", Offset = "0x1106B94")]
		public uint[] challengeIDs;

		// Token: 0x04001E75 RID: 7797
		[Token(Token = "0x4001E75")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106BD0", Offset = "0x1106BD0")]
		public uint daily_challenge_completed_cnt;

		// Token: 0x04001E76 RID: 7798
		[Token(Token = "0x4001E76")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106BE4", Offset = "0x1106BE4")]
		public uint elite_challenge_completed_cnt;

		// Token: 0x04001E77 RID: 7799
		[Token(Token = "0x4001E77")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106BF8", Offset = "0x1106BF8")]
		public uint veteran_challenge_completed_cnt;

		// Token: 0x04001E78 RID: 7800
		[Token(Token = "0x4001E78")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106C0C", Offset = "0x1106C0C")]
		public uint[] weeklyIDs;
	}
}
