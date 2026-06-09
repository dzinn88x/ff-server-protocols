using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001527 RID: 5415
	[Token(Token = "0x2001527")]
	public class UIWeaponController : UICollectionMainBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06005D26 RID: 23846 RVA: 0x0001B108 File Offset: 0x00019308
		[Token(Token = "0x6005D26")]
		[Address(RVA = "0x16856A4", Offset = "0x16856A4", VA = "0x7BBBE856A4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005D27 RID: 23847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D27")]
		[Address(RVA = "0x16856F4", Offset = "0x16856F4", VA = "0x7BBBE856F4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005D28 RID: 23848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D28")]
		[Address(RVA = "0x1685974", Offset = "0x1685974", VA = "0x7BBBE85974", Slot = "28")]
		protected override void GeneratePopMenuData()
		{
		}

		// Token: 0x06005D29 RID: 23849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D29")]
		[Address(RVA = "0x1685DA4", Offset = "0x1685DA4", VA = "0x7BBBE85DA4")]
		public void UpdateDefualtSourceType()
		{
		}

		// Token: 0x06005D2A RID: 23850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D2A")]
		[Address(RVA = "0x1685EFC", Offset = "0x1685EFC", VA = "0x7BBBE85EFC")]
		private void OnPopMenuItemSelected(object obj)
		{
		}

		// Token: 0x06005D2B RID: 23851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D2B")]
		[Address(RVA = "0x1685FCC", Offset = "0x1685FCC", VA = "0x7BBBE85FCC", Slot = "29")]
		protected override void OnEquipBtnClick()
		{
		}

		// Token: 0x06005D2C RID: 23852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D2C")]
		[Address(RVA = "0x168609C", Offset = "0x168609C", VA = "0x7BBBE8609C", Slot = "30")]
		protected override void OnShownBtnClick()
		{
		}

		// Token: 0x06005D2D RID: 23853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D2D")]
		[Address(RVA = "0x168627C", Offset = "0x168627C", VA = "0x7BBBE8627C")]
		public void OnWeaponItemSelected(params object[] obj)
		{
		}

		// Token: 0x06005D2E RID: 23854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D2E")]
		[Address(RVA = "0x168664C", Offset = "0x168664C", VA = "0x7BBBE8664C", Slot = "31")]
		protected override void RefreshShowBtn()
		{
		}

		// Token: 0x06005D2F RID: 23855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D2F")]
		[Address(RVA = "0x1686738", Offset = "0x1686738", VA = "0x7BBBE86738")]
		private void RefreshEquipBtn()
		{
		}

		// Token: 0x06005D30 RID: 23856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D30")]
		[Address(RVA = "0x1686620", Offset = "0x1686620", VA = "0x7BBBE86620")]
		private void SetItemView(WeaponSkinBaseInfo data)
		{
		}

		// Token: 0x06005D31 RID: 23857 RVA: 0x0001B120 File Offset: 0x00019320
		[Token(Token = "0x6005D31")]
		[Address(RVA = "0x1686814", Offset = "0x1686814", VA = "0x7BBBE86814", Slot = "32")]
		protected override bool HaveItems()
		{
			return default(bool);
		}

		// Token: 0x06005D32 RID: 23858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D32")]
		[Address(RVA = "0x1686898", Offset = "0x1686898", VA = "0x7BBBE86898", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005D33 RID: 23859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D33")]
		[Address(RVA = "0x16869F0", Offset = "0x16869F0", VA = "0x7BBBE869F0", Slot = "33")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005D34 RID: 23860 RVA: 0x0001B138 File Offset: 0x00019338
		[Token(Token = "0x6005D34")]
		[Address(RVA = "0x16869F4", Offset = "0x16869F4", VA = "0x7BBBE869F4", Slot = "34")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005D35 RID: 23861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D35")]
		[Address(RVA = "0x1686A58", Offset = "0x1686A58", VA = "0x7BBBE86A58")]
		public UIWeaponController()
		{
		}

		// Token: 0x04007EE6 RID: 32486
		[Token(Token = "0x4007EE6")]
		[FieldOffset(Offset = "0xA0")]
		private WeaponSkinBaseInfo m_SelectedWeaponSkinData;

		// Token: 0x04007EE7 RID: 32487
		[Token(Token = "0x4007EE7")]
		[FieldOffset(Offset = "0xA8")]
		private CollectionDataManager.ECollectionWeaponType m_SelectedWeaponType;
	}
}
