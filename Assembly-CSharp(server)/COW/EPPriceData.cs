using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020010EE RID: 4334
	[Token(Token = "0x20010EE")]
	internal class EPPriceData : CSVBaseData
	{
		// Token: 0x060043A7 RID: 17319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A7")]
		[Address(RVA = "0x1611D10", Offset = "0x1611D10", VA = "0x7BBBE11D10", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A8")]
		[Address(RVA = "0x1611D18", Offset = "0x1611D18", VA = "0x7BBBE11D18", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A9")]
		[Address(RVA = "0x1611FE8", Offset = "0x1611FE8", VA = "0x7BBBE11FE8")]
		public static EPPriceData GetUpgradeToEPPrice(uint EPEventID)
		{
			return null;
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x00014C10 File Offset: 0x00012E10
		[Token(Token = "0x60043AA")]
		[Address(RVA = "0x1612148", Offset = "0x1612148", VA = "0x7BBBE12148")]
		public static uint GetBundlePrice(uint EPEventID)
		{
			return 0U;
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043AB")]
		[Address(RVA = "0x1612164", Offset = "0x1612164", VA = "0x7BBBE12164")]
		public EPPriceData()
		{
		}

		// Token: 0x04005396 RID: 21398
		[Token(Token = "0x4005396")]
		[FieldOffset(Offset = "0x10")]
		public string Key;

		// Token: 0x04005397 RID: 21399
		[Token(Token = "0x4005397")]
		[FieldOffset(Offset = "0x18")]
		public uint CostValue;

		// Token: 0x04005398 RID: 21400
		[Token(Token = "0x4005398")]
		[FieldOffset(Offset = "0x1C")]
		public uint BundleValue;

		// Token: 0x04005399 RID: 21401
		[Token(Token = "0x4005399")]
		[FieldOffset(Offset = "0x20")]
		public uint BundleBadge;

		// Token: 0x0400539A RID: 21402
		[Token(Token = "0x400539A")]
		[FieldOffset(Offset = "0x24")]
		public uint BundleRewardItem1;

		// Token: 0x0400539B RID: 21403
		[Token(Token = "0x400539B")]
		[FieldOffset(Offset = "0x28")]
		public uint BundleRewardNum1;

		// Token: 0x0400539C RID: 21404
		[Token(Token = "0x400539C")]
		[FieldOffset(Offset = "0x2C")]
		public uint BundleRewardTime1;

		// Token: 0x0400539D RID: 21405
		[Token(Token = "0x400539D")]
		[FieldOffset(Offset = "0x30")]
		public EInventory.CurrencyType CostType;
	}
}
