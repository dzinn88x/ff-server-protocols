using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010BD RID: 4285
	[Token(Token = "0x20010BD")]
	public class ClanExtendScaleData : CSVBaseData
	{
		// Token: 0x060042D8 RID: 17112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D8")]
		[Address(RVA = "0x14F89D0", Offset = "0x14F89D0", VA = "0x7BBBCF89D0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042D9 RID: 17113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D9")]
		[Address(RVA = "0x14F89DC", Offset = "0x14F89DC", VA = "0x7BBBCF89DC", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060042DA RID: 17114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042DA")]
		[Address(RVA = "0x14F8AB8", Offset = "0x14F8AB8", VA = "0x7BBBCF8AB8")]
		public ClanExtendScaleData()
		{
		}

		// Token: 0x040051FA RID: 20986
		[Token(Token = "0x40051FA")]
		[FieldOffset(Offset = "0x10")]
		public int ExtendTimes;

		// Token: 0x040051FB RID: 20987
		[Token(Token = "0x40051FB")]
		[FieldOffset(Offset = "0x14")]
		public int ExtendSize;

		// Token: 0x040051FC RID: 20988
		[Token(Token = "0x40051FC")]
		[FieldOffset(Offset = "0x18")]
		public int DiamondCost;
	}
}
