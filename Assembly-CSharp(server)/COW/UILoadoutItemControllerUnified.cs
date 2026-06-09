using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020019E8 RID: 6632
	[Token(Token = "0x20019E8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F73AC", Offset = "0x10F73AC")]
	internal class UILoadoutItemControllerUnified : UIBaseController
	{
		// Token: 0x0600892C RID: 35116 RVA: 0x00024E10 File Offset: 0x00023010
		[Token(Token = "0x600892C")]
		[Address(RVA = "0x15237D4", Offset = "0x15237D4", VA = "0x7BBBD237D4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600892D RID: 35117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600892D")]
		[Address(RVA = "0x1523824", Offset = "0x1523824", VA = "0x7BBBD23824", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600892E RID: 35118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600892E")]
		[Address(RVA = "0x1523940", Offset = "0x1523940", VA = "0x7BBBD23940")]
		private void InitView()
		{
		}

		// Token: 0x0600892F RID: 35119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600892F")]
		[Address(RVA = "0x1523A9C", Offset = "0x1523A9C", VA = "0x7BBBD23A9C")]
		public void SetSelected(bool v)
		{
		}

		// Token: 0x06008930 RID: 35120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008930")]
		[Address(RVA = "0x15238F8", Offset = "0x15238F8", VA = "0x7BBBD238F8")]
		protected void ShowPlayCardInfo(bool val)
		{
		}

		// Token: 0x06008931 RID: 35121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008931")]
		[Address(RVA = "0x1523AD8", Offset = "0x1523AD8", VA = "0x7BBBD23AD8")]
		public void SetData(BaseItemInfo item, int index)
		{
		}

		// Token: 0x06008932 RID: 35122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008932")]
		[Address(RVA = "0x1523C20", Offset = "0x1523C20", VA = "0x7BBBD23C20")]
		public void SetBanned(bool isBanned)
		{
		}

		// Token: 0x06008933 RID: 35123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008933")]
		[Address(RVA = "0x1523C2C", Offset = "0x1523C2C", VA = "0x7BBBD23C2C")]
		public void RefreshUI()
		{
		}

		// Token: 0x06008934 RID: 35124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008934")]
		[Address(RVA = "0x1524478", Offset = "0x1524478", VA = "0x7BBBD24478")]
		public void SetItemEnable(bool isEnable, bool isPurchase = false)
		{
		}

		// Token: 0x06008935 RID: 35125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008935")]
		[Address(RVA = "0x1524330", Offset = "0x1524330", VA = "0x7BBBD24330")]
		protected void RefreshPlayCardTime()
		{
		}

		// Token: 0x06008936 RID: 35126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008936")]
		[Address(RVA = "0x152454C", Offset = "0x152454C", VA = "0x7BBBD2454C")]
		private void OnBtnClicked()
		{
		}

		// Token: 0x06008937 RID: 35127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008937")]
		[Address(RVA = "0x1524F00", Offset = "0x1524F00", VA = "0x7BBBD24F00")]
		public void Update()
		{
		}

		// Token: 0x06008938 RID: 35128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008938")]
		[Address(RVA = "0x1525014", Offset = "0x1525014", VA = "0x7BBBD25014")]
		public UILoadoutItemControllerUnified()
		{
		}

		// Token: 0x04009745 RID: 38725
		[Token(Token = "0x4009745")]
		[FieldOffset(Offset = "0x58")]
		private UILoadOutItemUnifiedView m_View;

		// Token: 0x04009746 RID: 38726
		[Token(Token = "0x4009746")]
		[FieldOffset(Offset = "0x60")]
		public Item PlayCardData;

		// Token: 0x04009747 RID: 38727
		[Token(Token = "0x4009747")]
		[FieldOffset(Offset = "0x68")]
		public int ItemIdex;

		// Token: 0x04009748 RID: 38728
		[Token(Token = "0x4009748")]
		[FieldOffset(Offset = "0x70")]
		public BaseItemInfo LoadOutData;

		// Token: 0x04009749 RID: 38729
		[Token(Token = "0x4009749")]
		[FieldOffset(Offset = "0x78")]
		public CSSharedItemDataManager.LoadoutSubType LoadOutType;

		// Token: 0x0400974A RID: 38730
		[Token(Token = "0x400974A")]
		[FieldOffset(Offset = "0x80")]
		private UIStandardItemMiniController m_ItemCtrl;

		// Token: 0x0400974B RID: 38731
		[Token(Token = "0x400974B")]
		[FieldOffset(Offset = "0x88")]
		protected bool m_selected;

		// Token: 0x0400974C RID: 38732
		[Token(Token = "0x400974C")]
		[FieldOffset(Offset = "0x89")]
		private bool m_Purchase;

		// Token: 0x0400974D RID: 38733
		[Token(Token = "0x400974D")]
		[FieldOffset(Offset = "0x90")]
		private UIModelMall m_ModelMall;

		// Token: 0x0400974E RID: 38734
		[Token(Token = "0x400974E")]
		[FieldOffset(Offset = "0x98")]
		private bool m_Isbanned;
	}
}
