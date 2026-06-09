using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001878 RID: 6264
	[Token(Token = "0x2001878")]
	internal class UIHudBanknoteShopLevelListController : UIBaseController
	{
		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06007BCB RID: 31691 RVA: 0x00022050 File Offset: 0x00020250
		[Token(Token = "0x17000985")]
		public int SelectedIndex
		{
			[Token(Token = "0x6007BCB")]
			[Address(RVA = "0x1891CFC", Offset = "0x1891CFC", VA = "0x7BBC091CFC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007BCC RID: 31692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BCC")]
		[Address(RVA = "0x1891D04", Offset = "0x1891D04", VA = "0x7BBC091D04", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007BCD RID: 31693 RVA: 0x00022068 File Offset: 0x00020268
		[Token(Token = "0x6007BCD")]
		[Address(RVA = "0x1891D98", Offset = "0x1891D98", VA = "0x7BBC091D98")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007BCE RID: 31694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BCE")]
		[Address(RVA = "0x1891DE8", Offset = "0x1891DE8", VA = "0x7BBC091DE8")]
		public void InitItems(List<uint> items, int level, bool isMaxLevel, int OneLevelSetCount)
		{
		}

		// Token: 0x06007BCF RID: 31695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BCF")]
		[Address(RVA = "0x18921BC", Offset = "0x18921BC", VA = "0x7BBC0921BC")]
		public void InitOneItem(int itemid, int index)
		{
		}

		// Token: 0x06007BD0 RID: 31696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BD0")]
		[Address(RVA = "0x189236C", Offset = "0x189236C", VA = "0x7BBC09236C")]
		public void OnItemSelected(int selectedIndex)
		{
		}

		// Token: 0x06007BD1 RID: 31697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BD1")]
		[Address(RVA = "0x1892374", Offset = "0x1892374", VA = "0x7BBC092374")]
		public void RefreshItemsSelectedState()
		{
		}

		// Token: 0x06007BD2 RID: 31698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BD2")]
		[Address(RVA = "0x18924C8", Offset = "0x18924C8", VA = "0x7BBC0924C8")]
		public void UpdateUnlockInfo(bool isUnlocked, int unlockItemIndex)
		{
		}

		// Token: 0x06007BD3 RID: 31699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BD3")]
		[Address(RVA = "0x18925D0", Offset = "0x18925D0", VA = "0x7BBC0925D0")]
		public UIHudBanknoteShopLevelListController()
		{
		}

		// Token: 0x0400901F RID: 36895
		[Token(Token = "0x400901F")]
		[FieldOffset(Offset = "0x58")]
		private UIHudBanknoteShopLevelListView m_View;

		// Token: 0x04009020 RID: 36896
		[Token(Token = "0x4009020")]
		[FieldOffset(Offset = "0x60")]
		private UIOneLevelEquipList m_equipView;

		// Token: 0x04009021 RID: 36897
		[Token(Token = "0x4009021")]
		[FieldOffset(Offset = "0x68")]
		private List<UIHudBanknoteShopItemController> m_ItemList;

		// Token: 0x04009022 RID: 36898
		[Token(Token = "0x4009022")]
		[FieldOffset(Offset = "0x70")]
		private int m_SelectedIndex;
	}
}
