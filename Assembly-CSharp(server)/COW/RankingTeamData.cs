using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001FF3 RID: 8179
	[Token(Token = "0x2001FF3")]
	internal class RankingTeamData
	{
		// Token: 0x0600B5FD RID: 46589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5FD")]
		[Address(RVA = "0x1750A54", Offset = "0x1750A54", VA = "0x7BBBF50A54")]
		public RankingTeamData()
		{
		}

		// Token: 0x0400B822 RID: 47138
		[Token(Token = "0x400B822")]
		[FieldOffset(Offset = "0x10")]
		public byte scTeamId;

		// Token: 0x0400B823 RID: 47139
		[Token(Token = "0x400B823")]
		[FieldOffset(Offset = "0x18")]
		public string teamName;

		// Token: 0x0400B824 RID: 47140
		[Token(Token = "0x400B824")]
		[FieldOffset(Offset = "0x20")]
		public uint teamIcon;

		// Token: 0x0400B825 RID: 47141
		[Token(Token = "0x400B825")]
		[FieldOffset(Offset = "0x24")]
		public Color color;

		// Token: 0x0400B826 RID: 47142
		[Token(Token = "0x400B826")]
		[FieldOffset(Offset = "0x34")]
		public uint liveCount;

		// Token: 0x0400B827 RID: 47143
		[Token(Token = "0x400B827")]
		[FieldOffset(Offset = "0x38")]
		public uint killCount;

		// Token: 0x0400B828 RID: 47144
		[Token(Token = "0x400B828")]
		[FieldOffset(Offset = "0x3C")]
		public uint combatLevel;
	}
}
