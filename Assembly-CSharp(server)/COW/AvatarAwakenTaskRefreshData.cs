using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200109C RID: 4252
	[Token(Token = "0x200109C")]
	public class AvatarAwakenTaskRefreshData : CSVBaseData
	{
		// Token: 0x060041A3 RID: 16803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A3")]
		[Address(RVA = "0x155C95C", Offset = "0x155C95C", VA = "0x7BBBD5C95C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041A4")]
		[Address(RVA = "0x155C968", Offset = "0x155C968", VA = "0x7BBBD5C968", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041A5")]
		[Address(RVA = "0x155CA70", Offset = "0x155CA70", VA = "0x7BBBD5CA70")]
		public AvatarAwakenTaskRefreshData()
		{
		}

		// Token: 0x040050F9 RID: 20729
		[Token(Token = "0x40050F9")]
		[FieldOffset(Offset = "0x10")]
		public uint CharacterID;

		// Token: 0x040050FA RID: 20730
		[Token(Token = "0x40050FA")]
		[FieldOffset(Offset = "0x18")]
		public uint[] RefreshCostType;

		// Token: 0x040050FB RID: 20731
		[Token(Token = "0x40050FB")]
		[FieldOffset(Offset = "0x20")]
		public uint[] RefreshCost;

		// Token: 0x040050FC RID: 20732
		[Token(Token = "0x40050FC")]
		[FieldOffset(Offset = "0x28")]
		public uint RefreshTimesLimit;
	}
}
