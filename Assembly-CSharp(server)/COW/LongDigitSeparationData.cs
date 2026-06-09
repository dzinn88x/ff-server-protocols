using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001137 RID: 4407
	[Token(Token = "0x2001137")]
	public class LongDigitSeparationData : CSVBaseData
	{
		// Token: 0x060044D9 RID: 17625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044D9")]
		[Address(RVA = "0x1A54840", Offset = "0x1A54840", VA = "0x7BBC254840", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044DA")]
		[Address(RVA = "0x1A54848", Offset = "0x1A54848", VA = "0x7BBC254848", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044DB")]
		[Address(RVA = "0x1A54934", Offset = "0x1A54934", VA = "0x7BBC254934")]
		public LongDigitSeparationData()
		{
		}

		// Token: 0x040054FB RID: 21755
		[Token(Token = "0x40054FB")]
		[FieldOffset(Offset = "0x10")]
		public string Language;

		// Token: 0x040054FC RID: 21756
		[Token(Token = "0x40054FC")]
		[FieldOffset(Offset = "0x18")]
		public int Digit;

		// Token: 0x040054FD RID: 21757
		[Token(Token = "0x40054FD")]
		[FieldOffset(Offset = "0x20")]
		public string SeperationSign;
	}
}
