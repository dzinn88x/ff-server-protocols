using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001119 RID: 4377
	[Token(Token = "0x2001119")]
	internal class LastNameData : CSVBaseData
	{
		// Token: 0x06004481 RID: 17537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004481")]
		[Address(RVA = "0x13FEABC", Offset = "0x13FEABC", VA = "0x7BBBBFEABC", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004482 RID: 17538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004482")]
		[Address(RVA = "0x13FEAC8", Offset = "0x13FEAC8", VA = "0x7BBBBFEAC8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004483 RID: 17539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004483")]
		[Address(RVA = "0x13FEB88", Offset = "0x13FEB88", VA = "0x7BBBBFEB88")]
		public LastNameData()
		{
		}

		// Token: 0x04005485 RID: 21637
		[Token(Token = "0x4005485")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x04005486 RID: 21638
		[Token(Token = "0x4005486")]
		[FieldOffset(Offset = "0x18")]
		public string Name;
	}
}
