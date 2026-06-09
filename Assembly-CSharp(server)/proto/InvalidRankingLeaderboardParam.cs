using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A76 RID: 2678
	[Token(Token = "0x2000A76")]
	[ProtoContract]
	public class InvalidRankingLeaderboardParam
	{
		// Token: 0x06002780 RID: 10112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002780")]
		[Address(RVA = "0x21BB624", Offset = "0x21BB624", VA = "0x7BBC9BB624")]
		public InvalidRankingLeaderboardParam()
		{
		}

		// Token: 0x0400310D RID: 12557
		[Token(Token = "0x400310D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112231C", Offset = "0x112231C")]
		public uint games_played;

		// Token: 0x0400310E RID: 12558
		[Token(Token = "0x400310E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122330", Offset = "0x1122330")]
		public float KD;

		// Token: 0x0400310F RID: 12559
		[Token(Token = "0x400310F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122344", Offset = "0x1122344")]
		public float win_rate;

		// Token: 0x04003110 RID: 12560
		[Token(Token = "0x4003110")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122358", Offset = "0x1122358")]
		public uint min_games;

		// Token: 0x04003111 RID: 12561
		[Token(Token = "0x4003111")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112236C", Offset = "0x112236C")]
		public float combine_KD;

		// Token: 0x04003112 RID: 12562
		[Token(Token = "0x4003112")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122380", Offset = "0x1122380")]
		public float combine_Headshot;
	}
}
