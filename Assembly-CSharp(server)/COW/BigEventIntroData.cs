using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CB2 RID: 7346
	[Token(Token = "0x2001CB2")]
	public class BigEventIntroData : CSVBaseData
	{
		// Token: 0x0600A04B RID: 41035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A04B")]
		[Address(RVA = "0x21D77BC", Offset = "0x21D77BC", VA = "0x7BBC9D77BC", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600A04C RID: 41036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A04C")]
		[Address(RVA = "0x21D7830", Offset = "0x21D7830", VA = "0x7BBC9D7830", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600A04D RID: 41037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A04D")]
		[Address(RVA = "0x21D7980", Offset = "0x21D7980", VA = "0x7BBC9D7980")]
		public BigEventIntroData()
		{
		}

		// Token: 0x0400A730 RID: 42800
		[Token(Token = "0x400A730")]
		[FieldOffset(Offset = "0x10")]
		public int eventID;

		// Token: 0x0400A731 RID: 42801
		[Token(Token = "0x400A731")]
		[FieldOffset(Offset = "0x14")]
		public int timing;

		// Token: 0x0400A732 RID: 42802
		[Token(Token = "0x400A732")]
		[FieldOffset(Offset = "0x18")]
		public string introDesc;
	}
}
