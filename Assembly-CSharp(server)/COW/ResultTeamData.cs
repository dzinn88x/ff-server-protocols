using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001FF6 RID: 8182
	[Token(Token = "0x2001FF6")]
	internal class ResultTeamData
	{
		// Token: 0x0600B600 RID: 46592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B600")]
		[Address(RVA = "0x175D904", Offset = "0x175D904", VA = "0x7BBBF5D904")]
		public ResultTeamData()
		{
		}

		// Token: 0x0400B835 RID: 47157
		[Token(Token = "0x400B835")]
		[FieldOffset(Offset = "0x10")]
		public byte id;

		// Token: 0x0400B836 RID: 47158
		[Token(Token = "0x400B836")]
		[FieldOffset(Offset = "0x14")]
		public uint rank;

		// Token: 0x0400B837 RID: 47159
		[Token(Token = "0x400B837")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400B838 RID: 47160
		[Token(Token = "0x400B838")]
		[FieldOffset(Offset = "0x20")]
		public uint icon;

		// Token: 0x0400B839 RID: 47161
		[Token(Token = "0x400B839")]
		[FieldOffset(Offset = "0x24")]
		public uint killCount;

		// Token: 0x0400B83A RID: 47162
		[Token(Token = "0x400B83A")]
		[FieldOffset(Offset = "0x28")]
		public uint killScore;

		// Token: 0x0400B83B RID: 47163
		[Token(Token = "0x400B83B")]
		[FieldOffset(Offset = "0x2C")]
		public uint rankScore;

		// Token: 0x0400B83C RID: 47164
		[Token(Token = "0x400B83C")]
		[FieldOffset(Offset = "0x30")]
		public uint totalScore;

		// Token: 0x0400B83D RID: 47165
		[Token(Token = "0x400B83D")]
		[FieldOffset(Offset = "0x34")]
		public uint winNum;

		// Token: 0x0400B83E RID: 47166
		[Token(Token = "0x400B83E")]
		[FieldOffset(Offset = "0x38")]
		public List<ResultPlayerData> players;
	}
}
