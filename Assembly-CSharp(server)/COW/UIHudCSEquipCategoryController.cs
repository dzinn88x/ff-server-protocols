using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014B2 RID: 5298
	[Token(Token = "0x20014B2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED5AC", Offset = "0x10ED5AC")]
	internal class UIHudCSEquipCategoryController : UIBaseController
	{
		// Token: 0x060059E1 RID: 23009 RVA: 0x0001A748 File Offset: 0x00018948
		[Token(Token = "0x60059E1")]
		[Address(RVA = "0x19B66D4", Offset = "0x19B66D4", VA = "0x7BBC1B66D4")]
		public uint Filter()
		{
			return 0U;
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x060059E2 RID: 23010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A3")]
		public UIHudCSEquipItemController FirstItem
		{
			[Token(Token = "0x60059E2")]
			[Address(RVA = "0x19B66DC", Offset = "0x19B66DC", VA = "0x7BBC1B66DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060059E3 RID: 23011 RVA: 0x0001A760 File Offset: 0x00018960
		[Token(Token = "0x60059E3")]
		[Address(RVA = "0x19B66E4", Offset = "0x19B66E4", VA = "0x7BBC1B66E4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060059E4 RID: 23012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059E4")]
		[Address(RVA = "0x19B6734", Offset = "0x19B6734", VA = "0x7BBC1B6734", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060059E5 RID: 23013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059E5")]
		[Address(RVA = "0x19B6798", Offset = "0x19B6798", VA = "0x7BBC1B6798")]
		public void SetUIData(uint filter, List<CSShopItemData> itemList)
		{
		}

		// Token: 0x060059E6 RID: 23014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059E6")]
		[Address(RVA = "0x19B6B30", Offset = "0x19B6B30", VA = "0x7BBC1B6B30")]
		private void SetFilterLabel(uint filter)
		{
		}

		// Token: 0x060059E7 RID: 23015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059E7")]
		[Address(RVA = "0x19B771C", Offset = "0x19B771C", VA = "0x7BBC1B771C")]
		public void SetBombUIData(uint filter, List<TDMLikeShopConfigData> dataList)
		{
		}

		// Token: 0x060059E8 RID: 23016 RVA: 0x0001A778 File Offset: 0x00018978
		[Token(Token = "0x60059E8")]
		[Address(RVA = "0x19B6FD0", Offset = "0x19B6FD0", VA = "0x7BBC1B6FD0")]
		private bool SetMysteryBoxUI()
		{
			return default(bool);
		}

		// Token: 0x060059E9 RID: 23017 RVA: 0x0001A790 File Offset: 0x00018990
		[Token(Token = "0x60059E9")]
		[Address(RVA = "0x19B7A70", Offset = "0x19B7A70", VA = "0x7BBC1B7A70")]
		public bool UpdateMysteryBoxUI()
		{
			return default(bool);
		}

		// Token: 0x060059EA RID: 23018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059EA")]
		[Address(RVA = "0x19B7C90", Offset = "0x19B7C90", VA = "0x7BBC1B7C90")]
		public UIHudCSEquipCategoryController()
		{
		}

		// Token: 0x04007D25 RID: 32037
		[Token(Token = "0x4007D25")]
		[FieldOffset(Offset = "0x58")]
		private UIHudInGameShopCategoryView m_View;

		// Token: 0x04007D26 RID: 32038
		[Token(Token = "0x4007D26")]
		[FieldOffset(Offset = "0x60")]
		private UIHudCSEquipItemController m_FirstItem;

		// Token: 0x04007D27 RID: 32039
		[Token(Token = "0x4007D27")]
		[FieldOffset(Offset = "0x68")]
		private uint m_Filter;

		// Token: 0x04007D28 RID: 32040
		[Token(Token = "0x4007D28")]
		[FieldOffset(Offset = "0x70")]
		private List<CSShopItemData> m_MysteryBoxItemDataList;

		// Token: 0x04007D29 RID: 32041
		[Token(Token = "0x4007D29")]
		[FieldOffset(Offset = "0x78")]
		private List<UIHudCSEquipItemController> m_ChildMysteryBoxController;

		// Token: 0x04007D2A RID: 32042
		[Token(Token = "0x4007D2A")]
		[FieldOffset(Offset = "0x80")]
		private List<UIToggleButton> m_ToggleList;

		// Token: 0x04007D2B RID: 32043
		[Token(Token = "0x4007D2B")]
		[FieldOffset(Offset = "0x88")]
		private bool m_UIDirty;

		// Token: 0x04007D2C RID: 32044
		[Token(Token = "0x4007D2C")]
		[FieldOffset(Offset = "0x8C")]
		private uint m_TopQuality;

		// Token: 0x020014B3 RID: 5299
		[Token(Token = "0x20014B3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ED5E4", Offset = "0x10ED5E4")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x060059EB RID: 23019 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60059EB")]
			[Address(RVA = "0x19B7A34", Offset = "0x19B7A34", VA = "0x7BBC1B7A34")]
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x04007D2D RID: 32045
			[Token(Token = "0x4007D2D")]
			[FieldOffset(Offset = "0x10")]
			public List<uint> qualityList;
		}

		// Token: 0x020014B4 RID: 5300
		[Token(Token = "0x20014B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ED5F4", Offset = "0x10ED5F4")]
		private sealed class <>c__DisplayClass16_1
		{
			// Token: 0x060059EC RID: 23020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60059EC")]
			[Address(RVA = "0x19B7A3C", Offset = "0x19B7A3C", VA = "0x7BBC1B7A3C")]
			public <>c__DisplayClass16_1()
			{
			}

			// Token: 0x060059ED RID: 23021 RVA: 0x0001A7A8 File Offset: 0x000189A8
			[Token(Token = "0x60059ED")]
			[Address(RVA = "0x19B7DEC", Offset = "0x19B7DEC", VA = "0x7BBC1B7DEC")]
			internal bool <SetMysteryBoxUI>b__1(CSShopItemData item)
			{
				return default(bool);
			}

			// Token: 0x04007D2E RID: 32046
			[Token(Token = "0x4007D2E")]
			[FieldOffset(Offset = "0x10")]
			public int i;

			// Token: 0x04007D2F RID: 32047
			[Token(Token = "0x4007D2F")]
			[FieldOffset(Offset = "0x18")]
			public UIHudCSEquipCategoryController.<>c__DisplayClass16_0 CS$<>8__locals1;
		}

		// Token: 0x020014B5 RID: 5301
		[Token(Token = "0x20014B5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ED604", Offset = "0x10ED604")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060059EF RID: 23023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60059EF")]
			[Address(RVA = "0x19B7DB4", Offset = "0x19B7DB4", VA = "0x7BBC1B7DB4")]
			public <>c()
			{
			}

			// Token: 0x060059F0 RID: 23024 RVA: 0x0001A7C0 File Offset: 0x000189C0
			[Token(Token = "0x60059F0")]
			[Address(RVA = "0x19B7DBC", Offset = "0x19B7DBC", VA = "0x7BBC1B7DBC")]
			internal int <SetMysteryBoxUI>b__16_0(uint a, uint b)
			{
				return 0;
			}

			// Token: 0x04007D30 RID: 32048
			[Token(Token = "0x4007D30")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudCSEquipCategoryController.<>c <>9;

			// Token: 0x04007D31 RID: 32049
			[Token(Token = "0x4007D31")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<uint> <>9__16_0;
		}
	}
}
