using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200150F RID: 5391
	[Token(Token = "0x200150F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE0AC", Offset = "0x10EE0AC")]
	public class UIHUDEquipUnlockLevelController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06005C98 RID: 23704 RVA: 0x0001AF40 File Offset: 0x00019140
		[Token(Token = "0x6005C98")]
		[Address(RVA = "0x16B8874", Offset = "0x16B8874", VA = "0x7BBBEB8874")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005C99 RID: 23705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C99")]
		[Address(RVA = "0x16B88C4", Offset = "0x16B88C4", VA = "0x7BBBEB88C4", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005C9A RID: 23706 RVA: 0x0001AF58 File Offset: 0x00019158
		[Token(Token = "0x6005C9A")]
		[Address(RVA = "0x16B8AE8", Offset = "0x16B8AE8", VA = "0x7BBBEB8AE8", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C9B")]
		[Address(RVA = "0x16B8B2C", Offset = "0x16B8B2C", VA = "0x7BBBEB8B2C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005C9C RID: 23708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C9C")]
		[Address(RVA = "0x16B8F50", Offset = "0x16B8F50", VA = "0x7BBBEB8F50", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005C9D RID: 23709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C9D")]
		[Address(RVA = "0x16B8C88", Offset = "0x16B8C88", VA = "0x7BBBEB8C88")]
		public void SetUpData()
		{
		}

		// Token: 0x06005C9E RID: 23710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C9E")]
		[Address(RVA = "0x16B9004", Offset = "0x16B9004", VA = "0x7BBBEB9004")]
		public void InitOneLevel(int levelIndex)
		{
		}

		// Token: 0x06005C9F RID: 23711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C9F")]
		[Address(RVA = "0x16B9130", Offset = "0x16B9130", VA = "0x7BBBEB9130")]
		public void ShowWindow(float showTime)
		{
		}

		// Token: 0x06005CA0 RID: 23712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA0")]
		[Address(RVA = "0x16B8938", Offset = "0x16B8938", VA = "0x7BBBEB8938")]
		public void UpdateUnLockInfo()
		{
		}

		// Token: 0x06005CA1 RID: 23713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA1")]
		[Address(RVA = "0x16B92F4", Offset = "0x16B92F4", VA = "0x7BBBEB92F4")]
		public void RefreshSelectedItem()
		{
		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA2")]
		[Address(RVA = "0x16B92F8", Offset = "0x16B92F8", VA = "0x7BBBEB92F8")]
		public void OnConfirm()
		{
		}

		// Token: 0x06005CA3 RID: 23715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA3")]
		[Address(RVA = "0x16B950C", Offset = "0x16B950C", VA = "0x7BBBEB950C")]
		public void SendSelectInfoToServer()
		{
		}

		// Token: 0x06005CA4 RID: 23716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA4")]
		[Address(RVA = "0x16B9614", Offset = "0x16B9614", VA = "0x7BBBEB9614")]
		private void Update()
		{
		}

		// Token: 0x06005CA5 RID: 23717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA5")]
		[Address(RVA = "0x16B9670", Offset = "0x16B9670", VA = "0x7BBBEB9670")]
		public UIHUDEquipUnlockLevelController()
		{
		}

		// Token: 0x04007EB1 RID: 32433
		[Token(Token = "0x4007EB1")]
		[FieldOffset(Offset = "0x98")]
		private UIHUDEquipUnlockLevelView m_View;

		// Token: 0x04007EB2 RID: 32434
		[Token(Token = "0x4007EB2")]
		[FieldOffset(Offset = "0xA0")]
		private List<UIHudBanknoteShopLevelListController> m_LevelList;

		// Token: 0x04007EB3 RID: 32435
		[Token(Token = "0x4007EB3")]
		[FieldOffset(Offset = "0xA8")]
		private int m_OneLevelSetCount;

		// Token: 0x04007EB4 RID: 32436
		[Token(Token = "0x4007EB4")]
		[FieldOffset(Offset = "0xB0")]
		private UITimeLabelHelper m_EndTime;
	}
}
