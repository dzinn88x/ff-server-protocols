using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CB7 RID: 7351
	[Token(Token = "0x2001CB7")]
	public class ChampionshipChannelData : CSVBaseData
	{
		// Token: 0x0600A05D RID: 41053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A05D")]
		[Address(RVA = "0x14F43C4", Offset = "0x14F43C4", VA = "0x7BBBCF43C4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600A05E RID: 41054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A05E")]
		[Address(RVA = "0x14F43D0", Offset = "0x14F43D0", VA = "0x7BBBCF43D0", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600A05F RID: 41055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A05F")]
		[Address(RVA = "0x14F4544", Offset = "0x14F4544", VA = "0x7BBBCF4544")]
		public ChampionshipChannelData()
		{
		}

		// Token: 0x0400A737 RID: 42807
		[Token(Token = "0x400A737")]
		[FieldOffset(Offset = "0x10")]
		public List<string> RegionList;

		// Token: 0x0400A738 RID: 42808
		[Token(Token = "0x400A738")]
		[FieldOffset(Offset = "0x18")]
		public int ChannelID;

		// Token: 0x0400A739 RID: 42809
		[Token(Token = "0x400A739")]
		[FieldOffset(Offset = "0x20")]
		public string Icon;
	}
}
