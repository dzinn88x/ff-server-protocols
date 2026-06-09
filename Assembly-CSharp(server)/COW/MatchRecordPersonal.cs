using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001FBC RID: 8124
	[Token(Token = "0x2001FBC")]
	public class MatchRecordPersonal
	{
		// Token: 0x0600B43D RID: 46141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B43D")]
		[Address(RVA = "0x1A5C978", Offset = "0x1A5C978", VA = "0x7BBC25C978")]
		public MatchRecordPersonal(MatchAccountStats matchAccountStats)
		{
		}

		// Token: 0x0400B6BB RID: 46779
		[Token(Token = "0x400B6BB")]
		[FieldOffset(Offset = "0x10")]
		public uint Ranking;

		// Token: 0x0400B6BC RID: 46780
		[Token(Token = "0x400B6BC")]
		[FieldOffset(Offset = "0x14")]
		public uint MatchMode;

		// Token: 0x0400B6BD RID: 46781
		[Token(Token = "0x400B6BD")]
		[FieldOffset(Offset = "0x18")]
		public uint GameMode;

		// Token: 0x0400B6BE RID: 46782
		[Token(Token = "0x400B6BE")]
		[FieldOffset(Offset = "0x1C")]
		public uint MapID;

		// Token: 0x0400B6BF RID: 46783
		[Token(Token = "0x400B6BF")]
		[FieldOffset(Offset = "0x20")]
		public uint GroupMode;

		// Token: 0x0400B6C0 RID: 46784
		[Token(Token = "0x400B6C0")]
		[FieldOffset(Offset = "0x24")]
		public uint TotalRanking;

		// Token: 0x0400B6C1 RID: 46785
		[Token(Token = "0x400B6C1")]
		[FieldOffset(Offset = "0x28")]
		public int Rating;

		// Token: 0x0400B6C2 RID: 46786
		[Token(Token = "0x400B6C2")]
		[FieldOffset(Offset = "0x2C")]
		public int DeltaRating;

		// Token: 0x0400B6C3 RID: 46787
		[Token(Token = "0x400B6C3")]
		[FieldOffset(Offset = "0x30")]
		public uint Kills;

		// Token: 0x0400B6C4 RID: 46788
		[Token(Token = "0x400B6C4")]
		[FieldOffset(Offset = "0x38")]
		public ulong EndMatchTimeStamp;

		// Token: 0x0400B6C5 RID: 46789
		[Token(Token = "0x400B6C5")]
		[FieldOffset(Offset = "0x40")]
		public uint Revive;

		// Token: 0x0400B6C6 RID: 46790
		[Token(Token = "0x400B6C6")]
		[FieldOffset(Offset = "0x44")]
		public uint SurvivalTime;

		// Token: 0x0400B6C7 RID: 46791
		[Token(Token = "0x400B6C7")]
		[FieldOffset(Offset = "0x48")]
		public uint HeadShoot;

		// Token: 0x0400B6C8 RID: 46792
		[Token(Token = "0x400B6C8")]
		[FieldOffset(Offset = "0x4C")]
		public uint Damage;

		// Token: 0x0400B6C9 RID: 46793
		[Token(Token = "0x400B6C9")]
		[FieldOffset(Offset = "0x50")]
		public bool IsAlive;

		// Token: 0x0400B6CA RID: 46794
		[Token(Token = "0x400B6CA")]
		[FieldOffset(Offset = "0x54")]
		public uint Deaths;

		// Token: 0x0400B6CB RID: 46795
		[Token(Token = "0x400B6CB")]
		[FieldOffset(Offset = "0x58")]
		public AchievementData AchvData;

		// Token: 0x0400B6CC RID: 46796
		[Token(Token = "0x400B6CC")]
		[FieldOffset(Offset = "0x60")]
		public List<TeammateStats> TeammateList;

		// Token: 0x0400B6CD RID: 46797
		[Token(Token = "0x400B6CD")]
		[FieldOffset(Offset = "0x68")]
		public uint championshipType;

		// Token: 0x0400B6CE RID: 46798
		[Token(Token = "0x400B6CE")]
		[FieldOffset(Offset = "0x70")]
		public MatchStats mystats;
	}
}
