using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020011A4 RID: 4516
	[Token(Token = "0x20011A4")]
	public class VoucherData : CSVBaseData
	{
		// Token: 0x06004646 RID: 17990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004646")]
		[Address(RVA = "0x179B6F8", Offset = "0x179B6F8", VA = "0x7BBBF9B6F8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004647")]
		[Address(RVA = "0x179B704", Offset = "0x179B704", VA = "0x7BBBF9B704", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004648")]
		[Address(RVA = "0x179B84C", Offset = "0x179B84C", VA = "0x7BBBF9B84C")]
		public VoucherData()
		{
		}

		// Token: 0x04005785 RID: 22405
		[Token(Token = "0x4005785")]
		[FieldOffset(Offset = "0x10")]
		public uint ID;

		// Token: 0x04005786 RID: 22406
		[Token(Token = "0x4005786")]
		[FieldOffset(Offset = "0x14")]
		public uint VoucherType;

		// Token: 0x04005787 RID: 22407
		[Token(Token = "0x4005787")]
		[FieldOffset(Offset = "0x18")]
		public uint DeductItemType;

		// Token: 0x04005788 RID: 22408
		[Token(Token = "0x4005788")]
		[FieldOffset(Offset = "0x1C")]
		public uint DeductItemID;

		// Token: 0x04005789 RID: 22409
		[Token(Token = "0x4005789")]
		[FieldOffset(Offset = "0x20")]
		public uint Maxmount;

		// Token: 0x0400578A RID: 22410
		[Token(Token = "0x400578A")]
		[FieldOffset(Offset = "0x24")]
		public uint Deductmount;
	}
}
