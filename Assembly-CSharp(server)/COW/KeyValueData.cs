using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001115 RID: 4373
	[Token(Token = "0x2001115")]
	public class KeyValueData : CSVBaseData
	{
		// Token: 0x06004475 RID: 17525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004475")]
		[Address(RVA = "0x13F6EF8", Offset = "0x13F6EF8", VA = "0x7BBBBF6EF8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004476")]
		[Address(RVA = "0x13F6F2C", Offset = "0x13F6F2C", VA = "0x7BBBBF6F2C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004477 RID: 17527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004477")]
		[Address(RVA = "0x13F75B8", Offset = "0x13F75B8", VA = "0x7BBBBF75B8")]
		public KeyValueData()
		{
		}

		// Token: 0x0400546C RID: 21612
		[Token(Token = "0x400546C")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x0400546D RID: 21613
		[Token(Token = "0x400546D")]
		[FieldOffset(Offset = "0x18")]
		public object Value;
	}
}
