using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001C4A RID: 7242
	[Token(Token = "0x2001C4A")]
	public class BaseItemInfo
	{
		// Token: 0x06009D70 RID: 40304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D70")]
		[Address(RVA = "0x21CFDD8", Offset = "0x21CFDD8", VA = "0x7BBC9CFDD8")]
		public static implicit operator BaseItemInfo(AwardDesc awardItem)
		{
			return null;
		}

		// Token: 0x06009D71 RID: 40305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D71")]
		[Address(RVA = "0x21D0440", Offset = "0x21D0440", VA = "0x7BBC9D0440")]
		public BaseItemInfo(EInventory.AwardType type, uint quantity)
		{
		}

		// Token: 0x06009D72 RID: 40306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D72")]
		[Address(RVA = "0x21D0984", Offset = "0x21D0984", VA = "0x7BBC9D0984")]
		public BaseItemInfo(uint quality, ResourceID resourceID, string name)
		{
		}

		// Token: 0x06009D73 RID: 40307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D73")]
		[Address(RVA = "0x21D0A5C", Offset = "0x21D0A5C", VA = "0x7BBC9D0A5C")]
		public BaseItemInfo(uint itemID, EInventory.AwardType type, uint count, uint effectTime = 0U)
		{
		}

		// Token: 0x06009D74 RID: 40308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D74")]
		[Address(RVA = "0x21C9620", Offset = "0x21C9620", VA = "0x7BBC9C9620")]
		public BaseItemInfo()
		{
		}

		// Token: 0x06009D75 RID: 40309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D75")]
		[Address(RVA = "0x21D10E8", Offset = "0x21D10E8", VA = "0x7BBC9D10E8")]
		public static implicit operator BaseItemInfo(GachaShowItem item)
		{
			return null;
		}

		// Token: 0x06009D76 RID: 40310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D76")]
		[Address(RVA = "0x21D11B0", Offset = "0x21D11B0", VA = "0x7BBC9D11B0")]
		public static implicit operator BaseItemInfo(Item item)
		{
			return null;
		}

		// Token: 0x06009D77 RID: 40311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D77")]
		[Address(RVA = "0x21D13E8", Offset = "0x21D13E8", VA = "0x7BBC9D13E8")]
		public static implicit operator BaseItemInfo(BundleShowData awardItem)
		{
			return null;
		}

		// Token: 0x06009D78 RID: 40312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D78")]
		[Address(RVA = "0x21D1A48", Offset = "0x21D1A48", VA = "0x7BBC9D1A48")]
		public static implicit operator BaseItemInfo(OptionalBundleShowData awardItem)
		{
			return null;
		}

		// Token: 0x06009D79 RID: 40313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D79")]
		[Address(RVA = "0x21D20A8", Offset = "0x21D20A8", VA = "0x7BBC9D20A8")]
		public static implicit operator BaseItemInfo(TreasureBoxShowData awardItem)
		{
			return null;
		}

		// Token: 0x06009D7A RID: 40314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D7A")]
		[Address(RVA = "0x21D2810", Offset = "0x21D2810", VA = "0x7BBC9D2810")]
		public static implicit operator BaseItemInfo(StoreDesc storeDesc)
		{
			return null;
		}

		// Token: 0x06009D7B RID: 40315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D7B")]
		[Address(RVA = "0x21D29FC", Offset = "0x21D29FC", VA = "0x7BBC9D29FC")]
		public static implicit operator BaseItemInfo(MysteryPoolStoreItem storeDesc)
		{
			return null;
		}

		// Token: 0x06009D7C RID: 40316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D7C")]
		[Address(RVA = "0x21D2BE8", Offset = "0x21D2BE8", VA = "0x7BBC9D2BE8")]
		public static implicit operator BaseItemInfo(DiscountStoreDesc discountDesc)
		{
			return null;
		}

		// Token: 0x06009D7D RID: 40317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D7D")]
		[Address(RVA = "0x21D2DD4", Offset = "0x21D2DD4", VA = "0x7BBC9D2DD4")]
		public static implicit operator BaseItemInfo(InstallmentStoreDesc installmentDesc)
		{
			return null;
		}

		// Token: 0x06009D7E RID: 40318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D7E")]
		[Address(RVA = "0x21D2FB8", Offset = "0x21D2FB8", VA = "0x7BBC9D2FB8")]
		public static implicit operator BaseItemInfo(GiftItem giftItem)
		{
			return null;
		}

		// Token: 0x06009D7F RID: 40319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D7F")]
		[Address(RVA = "0x21D31A4", Offset = "0x21D31A4", VA = "0x7BBC9D31A4")]
		public static implicit operator BaseItemInfo(ExchangeStoreItemDesc exchangeItemDesc)
		{
			return null;
		}

		// Token: 0x06009D80 RID: 40320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D80")]
		[Address(RVA = "0x21D3390", Offset = "0x21D3390", VA = "0x7BBC9D3390")]
		public static implicit operator BaseItemInfo(PetInfo petData)
		{
			return null;
		}

		// Token: 0x06009D81 RID: 40321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D81")]
		[Address(RVA = "0x21D34F0", Offset = "0x21D34F0", VA = "0x7BBC9D34F0")]
		public static implicit operator BaseItemInfo(BigEventStoreCommodityDesc commodityDesc)
		{
			return null;
		}

		// Token: 0x06009D82 RID: 40322 RVA: 0x000293A0 File Offset: 0x000275A0
		[Token(Token = "0x6009D82")]
		[Address(RVA = "0x21D36DC", Offset = "0x21D36DC", VA = "0x7BBC9D36DC")]
		public bool IsGold()
		{
			return default(bool);
		}

		// Token: 0x06009D83 RID: 40323 RVA: 0x000293B8 File Offset: 0x000275B8
		[Token(Token = "0x6009D83")]
		[Address(RVA = "0x21D3730", Offset = "0x21D3730", VA = "0x7BBC9D3730")]
		public bool IsGem()
		{
			return default(bool);
		}

		// Token: 0x06009D84 RID: 40324 RVA: 0x000293D0 File Offset: 0x000275D0
		[Token(Token = "0x6009D84")]
		[Address(RVA = "0x21D3784", Offset = "0x21D3784", VA = "0x7BBC9D3784")]
		public bool IsExp()
		{
			return default(bool);
		}

		// Token: 0x06009D85 RID: 40325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D85")]
		[Address(RVA = "0x21D37D8", Offset = "0x21D37D8", VA = "0x7BBC9D37D8")]
		public string GetName()
		{
			return null;
		}

		// Token: 0x06009D86 RID: 40326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D86")]
		[Address(RVA = "0x21D38C4", Offset = "0x21D38C4", VA = "0x7BBC9D38C4")]
		public string GetDescription()
		{
			return null;
		}

		// Token: 0x0400A389 RID: 41865
		[Token(Token = "0x400A389")]
		[FieldOffset(Offset = "0x0")]
		public static BaseItemInfo[] EmptyArray;

		// Token: 0x0400A38A RID: 41866
		[Token(Token = "0x400A38A")]
		[FieldOffset(Offset = "0x10")]
		public uint m_ID;

		// Token: 0x0400A38B RID: 41867
		[Token(Token = "0x400A38B")]
		[FieldOffset(Offset = "0x18")]
		public string m_Name;

		// Token: 0x0400A38C RID: 41868
		[Token(Token = "0x400A38C")]
		[FieldOffset(Offset = "0x20")]
		public int m_Type;

		// Token: 0x0400A38D RID: 41869
		[Token(Token = "0x400A38D")]
		[FieldOffset(Offset = "0x24")]
		public ResourceID m_IconRes;

		// Token: 0x0400A38E RID: 41870
		[Token(Token = "0x400A38E")]
		[FieldOffset(Offset = "0x28")]
		public ResourceID m_BigIconRes;

		// Token: 0x0400A38F RID: 41871
		[Token(Token = "0x400A38F")]
		[FieldOffset(Offset = "0x2C")]
		public uint m_Count;

		// Token: 0x0400A390 RID: 41872
		[Token(Token = "0x400A390")]
		[FieldOffset(Offset = "0x30")]
		public EInventory.ItemStatus m_Status;

		// Token: 0x0400A391 RID: 41873
		[Token(Token = "0x400A391")]
		[FieldOffset(Offset = "0x34")]
		public uint m_DeltaTime;

		// Token: 0x0400A392 RID: 41874
		[Token(Token = "0x400A392")]
		[FieldOffset(Offset = "0x38")]
		public uint m_Quality;

		// Token: 0x0400A393 RID: 41875
		[Token(Token = "0x400A393")]
		[FieldOffset(Offset = "0x40")]
		public string m_Description;
	}
}
