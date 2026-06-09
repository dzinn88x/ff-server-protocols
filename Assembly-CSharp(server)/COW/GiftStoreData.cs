using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001103 RID: 4355
	[Token(Token = "0x2001103")]
	public class GiftStoreData : CSVBaseData
	{
		// Token: 0x0600440F RID: 17423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600440F")]
		[Address(RVA = "0x1D8DBE0", Offset = "0x1D8DBE0", VA = "0x7BBC58DBE0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004410")]
		[Address(RVA = "0x1D8DBEC", Offset = "0x1D8DBEC", VA = "0x7BBC58DBEC", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004411")]
		[Address(RVA = "0x1D8DCC8", Offset = "0x1D8DCC8", VA = "0x7BBC58DCC8")]
		public GiftStoreData()
		{
		}

		// Token: 0x0400540F RID: 21519
		[Token(Token = "0x400540F")]
		[FieldOffset(Offset = "0x10")]
		public uint StoreID;

		// Token: 0x04005410 RID: 21520
		[Token(Token = "0x4005410")]
		[FieldOffset(Offset = "0x18")]
		public string StoreIcon;

		// Token: 0x04005411 RID: 21521
		[Token(Token = "0x4005411")]
		[FieldOffset(Offset = "0x20")]
		public string StoreTab;
	}
}
