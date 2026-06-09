using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001181 RID: 4481
	[Token(Token = "0x2001181")]
	public class RenameCostData : CSVBaseData
	{
		// Token: 0x060045BA RID: 17850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BA")]
		[Address(RVA = "0x17592E4", Offset = "0x17592E4", VA = "0x7BBBF592E4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045BB")]
		[Address(RVA = "0x17592EC", Offset = "0x17592EC", VA = "0x7BBBF592EC", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045BC")]
		[Address(RVA = "0x17593AC", Offset = "0x17593AC", VA = "0x7BBBF593AC")]
		public RenameCostData()
		{
		}

		// Token: 0x040056BD RID: 22205
		[Token(Token = "0x40056BD")]
		[FieldOffset(Offset = "0x10")]
		public string Region;

		// Token: 0x040056BE RID: 22206
		[Token(Token = "0x40056BE")]
		[FieldOffset(Offset = "0x18")]
		public int DiamondCost;
	}
}
