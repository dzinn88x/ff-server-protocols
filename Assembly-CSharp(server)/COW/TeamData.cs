using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001FF2 RID: 8178
	[Token(Token = "0x2001FF2")]
	internal class TeamData
	{
		// Token: 0x0600B5FC RID: 46588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5FC")]
		[Address(RVA = "0x1B45CF0", Offset = "0x1B45CF0", VA = "0x7BBC345CF0")]
		public TeamData()
		{
		}

		// Token: 0x0400B81B RID: 47131
		[Token(Token = "0x400B81B")]
		[FieldOffset(Offset = "0x10")]
		public string teamName;

		// Token: 0x0400B81C RID: 47132
		[Token(Token = "0x400B81C")]
		[FieldOffset(Offset = "0x18")]
		public string teamNameAbbr;

		// Token: 0x0400B81D RID: 47133
		[Token(Token = "0x400B81D")]
		[FieldOffset(Offset = "0x20")]
		public byte gsTeamId;

		// Token: 0x0400B81E RID: 47134
		[Token(Token = "0x400B81E")]
		[FieldOffset(Offset = "0x21")]
		public byte scTeamId;

		// Token: 0x0400B81F RID: 47135
		[Token(Token = "0x400B81F")]
		[FieldOffset(Offset = "0x24")]
		public uint teamIcon;

		// Token: 0x0400B820 RID: 47136
		[Token(Token = "0x400B820")]
		[FieldOffset(Offset = "0x28")]
		public uint winNum;

		// Token: 0x0400B821 RID: 47137
		[Token(Token = "0x400B821")]
		[FieldOffset(Offset = "0x30")]
		public List<PlayerData> playerList;
	}
}
