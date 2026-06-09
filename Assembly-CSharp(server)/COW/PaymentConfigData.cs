using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001153 RID: 4435
	[Token(Token = "0x2001153")]
	public class PaymentConfigData : CSVBaseData
	{
		// Token: 0x06004530 RID: 17712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004530")]
		[Address(RVA = "0x204B364", Offset = "0x204B364", VA = "0x7BBC84B364", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004531")]
		[Address(RVA = "0x204B370", Offset = "0x204B370", VA = "0x7BBC84B370", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004532 RID: 17714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004532")]
		[Address(RVA = "0x204B428", Offset = "0x204B428", VA = "0x7BBC84B428")]
		public PaymentConfigData()
		{
		}

		// Token: 0x040055D7 RID: 21975
		[Token(Token = "0x40055D7")]
		[FieldOffset(Offset = "0x10")]
		public uint ID;

		// Token: 0x040055D8 RID: 21976
		[Token(Token = "0x40055D8")]
		[FieldOffset(Offset = "0x14")]
		public uint Weight;
	}
}
