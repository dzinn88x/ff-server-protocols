using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020010E1 RID: 4321
	[Token(Token = "0x20010E1")]
	internal class EPBadgePriceData : CSVBaseData
	{
		// Token: 0x0600436C RID: 17260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436C")]
		[Address(RVA = "0x160C068", Offset = "0x160C068", VA = "0x7BBBE0C068", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600436D")]
		[Address(RVA = "0x160C098", Offset = "0x160C098", VA = "0x7BBBE0C098", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436E")]
		[Address(RVA = "0x160C2A0", Offset = "0x160C2A0", VA = "0x7BBBE0C2A0")]
		public static EPBadgePriceData GetPriceByRegion(uint eventID)
		{
			return null;
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600436F")]
		[Address(RVA = "0x160C4B4", Offset = "0x160C4B4", VA = "0x7BBBE0C4B4")]
		public EPBadgePriceData()
		{
		}

		// Token: 0x04005333 RID: 21299
		[Token(Token = "0x4005333")]
		[FieldOffset(Offset = "0x10")]
		public string RegionName;

		// Token: 0x04005334 RID: 21300
		[Token(Token = "0x4005334")]
		[FieldOffset(Offset = "0x18")]
		public uint EPEventID;

		// Token: 0x04005335 RID: 21301
		[Token(Token = "0x4005335")]
		[FieldOffset(Offset = "0x1C")]
		public uint CostValue;

		// Token: 0x04005336 RID: 21302
		[Token(Token = "0x4005336")]
		[FieldOffset(Offset = "0x20")]
		public uint DiscountValue1;

		// Token: 0x04005337 RID: 21303
		[Token(Token = "0x4005337")]
		[FieldOffset(Offset = "0x24")]
		public uint DiscountValue2;

		// Token: 0x04005338 RID: 21304
		[Token(Token = "0x4005338")]
		[FieldOffset(Offset = "0x28")]
		public uint DiscountValue3;

		// Token: 0x04005339 RID: 21305
		[Token(Token = "0x4005339")]
		[FieldOffset(Offset = "0x2C")]
		public EInventory.CurrencyType CostType;
	}
}
