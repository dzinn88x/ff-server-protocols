using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020019E5 RID: 6629
	[Token(Token = "0x20019E5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7304", Offset = "0x10F7304")]
	internal class UILoadoutController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x060088FD RID: 35069 RVA: 0x00024D80 File Offset: 0x00022F80
		[Token(Token = "0x60088FD")]
		[Address(RVA = "0x1CC9804", Offset = "0x1CC9804", VA = "0x7BBC4C9804")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060088FE RID: 35070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088FE")]
		[Address(RVA = "0x1CC9854", Offset = "0x1CC9854", VA = "0x7BBC4C9854", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060088FF RID: 35071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088FF")]
		[Address(RVA = "0x1CC9E18", Offset = "0x1CC9E18", VA = "0x7BBC4C9E18")]
		public void ShowLoadoutGuide()
		{
		}

		// Token: 0x06008900 RID: 35072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008900")]
		[Address(RVA = "0x1CCA580", Offset = "0x1CCA580", VA = "0x7BBC4CA580", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008901 RID: 35073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008901")]
		[Address(RVA = "0x1CCA750", Offset = "0x1CCA750", VA = "0x7BBC4CA750", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008902 RID: 35074 RVA: 0x00024D98 File Offset: 0x00022F98
		[Token(Token = "0x6008902")]
		[Address(RVA = "0x1CCAEA8", Offset = "0x1CCAEA8", VA = "0x7BBC4CAEA8")]
		private bool IsItemShow(Item item)
		{
			return default(bool);
		}

		// Token: 0x06008903 RID: 35075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008903")]
		[Address(RVA = "0x1CC9B34", Offset = "0x1CC9B34", VA = "0x7BBC4C9B34")]
		private void InitContents()
		{
		}

		// Token: 0x06008904 RID: 35076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008904")]
		[Address(RVA = "0x1CCB0A0", Offset = "0x1CCB0A0", VA = "0x7BBC4CB0A0")]
		private List<Item> FilterLoadouts(List<Item> loadoutList)
		{
			return null;
		}

		// Token: 0x06008905 RID: 35077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008905")]
		private void BuildLoadoutsUI<T>(List<Item> loadoutList, CSSharedItemDataManager.LoadoutSubType type, UIGrid grid) where T : UILoadoutItemController
		{
		}

		// Token: 0x06008906 RID: 35078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008906")]
		[Address(RVA = "0x1CCB1B0", Offset = "0x1CCB1B0", VA = "0x7BBC4CB1B0")]
		private void StopNewbieGuide(params object[] args)
		{
		}

		// Token: 0x06008907 RID: 35079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008907")]
		[Address(RVA = "0x1CCB41C", Offset = "0x1CCB41C", VA = "0x7BBC4CB41C")]
		private void OnUILoadOutSelected(params object[] data)
		{
		}

		// Token: 0x06008908 RID: 35080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008908")]
		[Address(RVA = "0x1CCB824", Offset = "0x1CCB824", VA = "0x7BBC4CB824", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008909 RID: 35081 RVA: 0x00024DB0 File Offset: 0x00022FB0
		[Token(Token = "0x6008909")]
		[Address(RVA = "0x1CCB8EC", Offset = "0x1CCB8EC", VA = "0x7BBC4CB8EC", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600890A RID: 35082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600890A")]
		[Address(RVA = "0x1CCB950", Offset = "0x1CCB950", VA = "0x7BBC4CB950")]
		private void OnConfirmBtnClick()
		{
		}

		// Token: 0x0600890B RID: 35083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600890B")]
		[Address(RVA = "0x1CCBC18", Offset = "0x1CCBC18", VA = "0x7BBC4CBC18")]
		public UILoadoutController()
		{
		}

		// Token: 0x0600890C RID: 35084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600890C")]
		[Address(RVA = "0x1CCBCB4", Offset = "0x1CCBCB4", VA = "0x7BBC4CBCB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11438C8", Offset = "0x11438C8")]
		private void <InitContents>b__17_0()
		{
		}

		// Token: 0x0400972E RID: 38702
		[Token(Token = "0x400972E")]
		[FieldOffset(Offset = "0x98")]
		private UILoadOutView m_View;

		// Token: 0x0400972F RID: 38703
		[Token(Token = "0x400972F")]
		[FieldOffset(Offset = "0xA0")]
		private List<UILoadoutItemController> m_LoadOutCtrls;

		// Token: 0x04009730 RID: 38704
		[Token(Token = "0x4009730")]
		[FieldOffset(Offset = "0xA8")]
		private List<UILoadoutItemControllerNew> m_LoadOutCtrlsNew;

		// Token: 0x04009731 RID: 38705
		[Token(Token = "0x4009731")]
		[FieldOffset(Offset = "0xB0")]
		private int m_CurrentSelectedLoadoutId;

		// Token: 0x04009732 RID: 38706
		[Token(Token = "0x4009732")]
		[FieldOffset(Offset = "0xB4")]
		private int m_CurrentSelectedLoadoutIdNew;

		// Token: 0x04009733 RID: 38707
		[Token(Token = "0x4009733")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_RequestedBackpack;

		// Token: 0x04009734 RID: 38708
		[Token(Token = "0x4009734")]
		[FieldOffset(Offset = "0xB9")]
		private bool m_HasShowGuide;

		// Token: 0x04009735 RID: 38709
		[Token(Token = "0x4009735")]
		[FieldOffset(Offset = "0xC0")]
		private UIGuideTipsController m_GuideTipsCtrl;

		// Token: 0x04009736 RID: 38710
		[Token(Token = "0x4009736")]
		[FieldOffset(Offset = "0xC8")]
		private UICommonGuideController m_LoadoutGuideCtrl;

		// Token: 0x04009737 RID: 38711
		[Token(Token = "0x4009737")]
		[FieldOffset(Offset = "0xD0")]
		private UICommonGuideController m_LoadoutGuideCtrlNew;

		// Token: 0x04009738 RID: 38712
		[Token(Token = "0x4009738")]
		[FieldOffset(Offset = "0xD8")]
		private UIModelUser m_ModelUser;
	}
}
