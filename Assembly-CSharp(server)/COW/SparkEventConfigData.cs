using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200118D RID: 4493
	[Token(Token = "0x200118D")]
	public class SparkEventConfigData : CSVBaseData
	{
		// Token: 0x060045F2 RID: 17906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045F2")]
		[Address(RVA = "0x1B3B2F0", Offset = "0x1B3B2F0", VA = "0x7BBC33B2F0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F3")]
		[Address(RVA = "0x1B3B2F8", Offset = "0x1B3B2F8", VA = "0x7BBC33B2F8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060045F4 RID: 17908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F4")]
		[Address(RVA = "0x1B3B4D8", Offset = "0x1B3B4D8", VA = "0x7BBC33B4D8")]
		public SparkEventConfigData()
		{
		}

		// Token: 0x04005707 RID: 22279
		[Token(Token = "0x4005707")]
		[FieldOffset(Offset = "0x10")]
		public string EventType;

		// Token: 0x04005708 RID: 22280
		[Token(Token = "0x4005708")]
		[FieldOffset(Offset = "0x18")]
		public int MaxEventTimes;

		// Token: 0x04005709 RID: 22281
		[Token(Token = "0x4005709")]
		[FieldOffset(Offset = "0x1C")]
		public EHighlightType HighlightType;
	}
}
