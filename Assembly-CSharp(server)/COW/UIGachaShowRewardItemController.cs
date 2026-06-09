using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200181D RID: 6173
	[Token(Token = "0x200181D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F366C", Offset = "0x10F366C")]
	public class UIGachaShowRewardItemController : UIEasyListItemController
	{
		// Token: 0x17000965 RID: 2405
		// (set) Token: 0x06007862 RID: 30818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000965")]
		public static uint CurrentGachaID
		{
			[Token(Token = "0x6007862")]
			[Address(RVA = "0x1F9FD90", Offset = "0x1F9FD90", VA = "0x7BBC79FD90")]
			set
			{
			}
		}

		// Token: 0x17000966 RID: 2406
		// (set) Token: 0x06007863 RID: 30819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000966")]
		public static bool IsShowDropUp
		{
			[Token(Token = "0x6007863")]
			[Address(RVA = "0x1F9FDFC", Offset = "0x1F9FDFC", VA = "0x7BBC79FDFC")]
			set
			{
			}
		}

		// Token: 0x06007864 RID: 30820 RVA: 0x00021360 File Offset: 0x0001F560
		[Token(Token = "0x6007864")]
		[Address(RVA = "0x1F9FE6C", Offset = "0x1F9FE6C", VA = "0x7BBC79FE6C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007865 RID: 30821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007865")]
		[Address(RVA = "0x1F9FEBC", Offset = "0x1F9FEBC", VA = "0x7BBC79FEBC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007866 RID: 30822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007866")]
		[Address(RVA = "0x1F9FFD0", Offset = "0x1F9FFD0", VA = "0x7BBC79FFD0", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06007867 RID: 30823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007867")]
		[Address(RVA = "0x1FA0020", Offset = "0x1FA0020", VA = "0x7BBC7A0020", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06007868 RID: 30824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007868")]
		[Address(RVA = "0x1FA01A0", Offset = "0x1FA01A0", VA = "0x7BBC7A01A0", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06007869 RID: 30825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007869")]
		[Address(RVA = "0x1FA0278", Offset = "0x1FA0278", VA = "0x7BBC7A0278")]
		private void RefreshDataItem(BaseItemInfo data)
		{
		}

		// Token: 0x0600786A RID: 30826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600786A")]
		[Address(RVA = "0x1FA0B30", Offset = "0x1FA0B30", VA = "0x7BBC7A0B30")]
		private void CheckItemABReady(uint itemID)
		{
		}

		// Token: 0x0600786B RID: 30827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600786B")]
		[Address(RVA = "0x1FA0C80", Offset = "0x1FA0C80", VA = "0x7BBC7A0C80")]
		public void SetQualityBG(int Quality, UISprite QualityBG, UISprite QualityNameBG01)
		{
		}

		// Token: 0x0600786C RID: 30828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600786C")]
		[Address(RVA = "0x1FA0E60", Offset = "0x1FA0E60", VA = "0x7BBC7A0E60")]
		public void SetVfxDisable()
		{
		}

		// Token: 0x0600786D RID: 30829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600786D")]
		[Address(RVA = "0x1FA0F08", Offset = "0x1FA0F08", VA = "0x7BBC7A0F08")]
		public void SetItemBtnDisable()
		{
		}

		// Token: 0x0600786E RID: 30830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600786E")]
		[Address(RVA = "0x1FA0F4C", Offset = "0x1FA0F4C", VA = "0x7BBC7A0F4C")]
		public void SetIsLegendRewardPool()
		{
		}

		// Token: 0x0600786F RID: 30831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600786F")]
		[Address(RVA = "0x1FA1010", Offset = "0x1FA1010", VA = "0x7BBC7A1010")]
		public void OnLegendItemBtnClick()
		{
		}

		// Token: 0x06007870 RID: 30832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007870")]
		[Address(RVA = "0x1FA1220", Offset = "0x1FA1220", VA = "0x7BBC7A1220")]
		public UIGachaShowRewardItemController()
		{
		}

		// Token: 0x04008E40 RID: 36416
		[Token(Token = "0x4008E40")]
		[FieldOffset(Offset = "0x70")]
		private UIGachaShowRewardItemView m_View;

		// Token: 0x04008E41 RID: 36417
		[Token(Token = "0x4008E41")]
		[FieldOffset(Offset = "0x78")]
		private BaseItemInfo m_Data;

		// Token: 0x04008E42 RID: 36418
		[Token(Token = "0x4008E42")]
		[FieldOffset(Offset = "0x80")]
		private bool m_IsItemABReady;

		// Token: 0x04008E43 RID: 36419
		[Token(Token = "0x4008E43")]
		[FieldOffset(Offset = "0x84")]
		private uint m_ItemIconGrey;

		// Token: 0x04008E44 RID: 36420
		[Token(Token = "0x4008E44")]
		[FieldOffset(Offset = "0x0")]
		private static bool m_IsShowDropUp;

		// Token: 0x04008E45 RID: 36421
		[Token(Token = "0x4008E45")]
		[FieldOffset(Offset = "0x4")]
		private static uint m_CurrentGachaID;
	}
}
