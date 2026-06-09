using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020011AD RID: 4525
	[Token(Token = "0x20011AD")]
	internal class WinnerTakesAllRewardData : CSVBaseData
	{
		// Token: 0x06004661 RID: 18017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004661")]
		[Address(RVA = "0x23DFB60", Offset = "0x23DFB60", VA = "0x7BBCBDFB60", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x000153D8 File Offset: 0x000135D8
		[Token(Token = "0x6004662")]
		[Address(RVA = "0x23DFB6C", Offset = "0x23DFB6C", VA = "0x7BBCBDFB6C")]
		public uint SumChipNum()
		{
			return 0U;
		}

		// Token: 0x06004663 RID: 18019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004663")]
		[Address(RVA = "0x23DFB80", Offset = "0x23DFB80", VA = "0x7BBCBDFB80", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004664 RID: 18020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004664")]
		[Address(RVA = "0x23DFE08", Offset = "0x23DFE08", VA = "0x7BBCBDFE08")]
		public WinnerTakesAllRewardData()
		{
		}

		// Token: 0x040057B8 RID: 22456
		[Token(Token = "0x40057B8")]
		[FieldOffset(Offset = "0x10")]
		public uint GroupMode;

		// Token: 0x040057B9 RID: 22457
		[Token(Token = "0x40057B9")]
		[FieldOffset(Offset = "0x14")]
		public uint FirstChipNum;

		// Token: 0x040057BA RID: 22458
		[Token(Token = "0x40057BA")]
		[FieldOffset(Offset = "0x18")]
		public uint SecondChipNum;

		// Token: 0x040057BB RID: 22459
		[Token(Token = "0x40057BB")]
		[FieldOffset(Offset = "0x1C")]
		public uint ThirdChipNum;
	}
}
