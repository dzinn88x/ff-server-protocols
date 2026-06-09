using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001FF4 RID: 8180
	[Token(Token = "0x2001FF4")]
	internal class AccTeamData
	{
		// Token: 0x0600B5FE RID: 46590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5FE")]
		[Address(RVA = "0x1F97E3C", Offset = "0x1F97E3C", VA = "0x7BBC797E3C")]
		public AccTeamData()
		{
		}

		// Token: 0x0400B829 RID: 47145
		[Token(Token = "0x400B829")]
		[FieldOffset(Offset = "0x10")]
		public byte scTeamId;

		// Token: 0x0400B82A RID: 47146
		[Token(Token = "0x400B82A")]
		[FieldOffset(Offset = "0x18")]
		public string teamName;

		// Token: 0x0400B82B RID: 47147
		[Token(Token = "0x400B82B")]
		[FieldOffset(Offset = "0x20")]
		public string teamNameAbbr;

		// Token: 0x0400B82C RID: 47148
		[Token(Token = "0x400B82C")]
		[FieldOffset(Offset = "0x28")]
		public uint liveCount;

		// Token: 0x0400B82D RID: 47149
		[Token(Token = "0x400B82D")]
		[FieldOffset(Offset = "0x2C")]
		public uint teamIcon;

		// Token: 0x0400B82E RID: 47150
		[Token(Token = "0x400B82E")]
		[FieldOffset(Offset = "0x30")]
		public Color color;

		// Token: 0x0400B82F RID: 47151
		[Token(Token = "0x400B82F")]
		[FieldOffset(Offset = "0x40")]
		public uint score;

		// Token: 0x0400B830 RID: 47152
		[Token(Token = "0x400B830")]
		[FieldOffset(Offset = "0x44")]
		public uint rank;

		// Token: 0x0400B831 RID: 47153
		[Token(Token = "0x400B831")]
		[FieldOffset(Offset = "0x48")]
		public uint prevrank;
	}
}
