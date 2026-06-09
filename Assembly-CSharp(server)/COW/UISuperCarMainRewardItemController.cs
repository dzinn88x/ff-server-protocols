using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020013C1 RID: 5057
	[Token(Token = "0x20013C1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBD70", Offset = "0x10EBD70")]
	public class UISuperCarMainRewardItemController : UIEasyListItemController
	{
		// Token: 0x06005289 RID: 21129 RVA: 0x00018C78 File Offset: 0x00016E78
		[Token(Token = "0x6005289")]
		[Address(RVA = "0x2148650", Offset = "0x2148650", VA = "0x7BBC948650")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528A")]
		[Address(RVA = "0x21486A0", Offset = "0x21486A0", VA = "0x7BBC9486A0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528B")]
		[Address(RVA = "0x21414C0", Offset = "0x21414C0", VA = "0x7BBC9414C0")]
		public void SetStandItemMiniData(StatndardItemMiniData data, bool hasTween = true)
		{
		}

		// Token: 0x0600528C RID: 21132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528C")]
		[Address(RVA = "0x21486F8", Offset = "0x21486F8", VA = "0x7BBC9486F8")]
		public void RefreshView()
		{
		}

		// Token: 0x0600528D RID: 21133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528D")]
		[Address(RVA = "0x2148A40", Offset = "0x2148A40", VA = "0x7BBC948A40")]
		public UIDragScrollView GetItemDragView()
		{
			return null;
		}

		// Token: 0x0600528E RID: 21134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528E")]
		[Address(RVA = "0x2148A6C", Offset = "0x2148A6C", VA = "0x7BBC948A6C")]
		public void UpdateQuantityLabel(string newCount)
		{
		}

		// Token: 0x0600528F RID: 21135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528F")]
		[Address(RVA = "0x2148AC4", Offset = "0x2148AC4", VA = "0x7BBC948AC4")]
		public void SetFlowLightEnable(bool b)
		{
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005290")]
		[Address(RVA = "0x2148950", Offset = "0x2148950", VA = "0x7BBC948950")]
		public void SetQualityBG()
		{
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005291")]
		[Address(RVA = "0x21487D4", Offset = "0x21487D4", VA = "0x7BBC9487D4")]
		public void RefreshBaseItemView(BaseItemInfo info)
		{
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005292")]
		[Address(RVA = "0x2141514", Offset = "0x2141514", VA = "0x7BBC941514")]
		public void SetBtnClickEvent(bool useFullScreen = true)
		{
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005293")]
		[Address(RVA = "0x2148B0C", Offset = "0x2148B0C", VA = "0x7BBC948B0C")]
		public void SetCustomBtnClickEvent(EventDelegate.Callback action)
		{
		}

		// Token: 0x06005294 RID: 21140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005294")]
		[Address(RVA = "0x2148BD8", Offset = "0x2148BD8", VA = "0x7BBC948BD8")]
		public void EnableItemBtn()
		{
		}

		// Token: 0x06005295 RID: 21141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005295")]
		[Address(RVA = "0x2148C1C", Offset = "0x2148C1C", VA = "0x7BBC948C1C")]
		public void DisableItemBtn()
		{
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005296")]
		[Address(RVA = "0x2148C60", Offset = "0x2148C60", VA = "0x7BBC948C60")]
		private void ShowItemPreview()
		{
		}

		// Token: 0x06005297 RID: 21143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005297")]
		[Address(RVA = "0x2148D54", Offset = "0x2148D54", VA = "0x7BBC948D54")]
		private void ShowFullScreenPreview()
		{
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005298")]
		[Address(RVA = "0x2148878", Offset = "0x2148878", VA = "0x7BBC948878")]
		public void SetHighLightState(bool show)
		{
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005299")]
		[Address(RVA = "0x2148830", Offset = "0x2148830", VA = "0x7BBC948830")]
		public void SetGreyBGState(bool show)
		{
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600529A")]
		[Address(RVA = "0x21488C0", Offset = "0x21488C0", VA = "0x7BBC9488C0")]
		public void SetOwnedState(bool show)
		{
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600529B")]
		[Address(RVA = "0x2148908", Offset = "0x2148908", VA = "0x7BBC948908")]
		public void SetDownloadInfoState(bool show)
		{
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600529C")]
		[Address(RVA = "0x2148F44", Offset = "0x2148F44", VA = "0x7BBC948F44", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600529D")]
		[Address(RVA = "0x2149024", Offset = "0x2149024", VA = "0x7BBC949024")]
		public void SetQuantityIgnoreOne(bool ignore)
		{
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600529E")]
		[Address(RVA = "0x2149068", Offset = "0x2149068", VA = "0x7BBC949068")]
		public UISuperCarMainRewardItemController()
		{
		}

		// Token: 0x04007882 RID: 30850
		[Token(Token = "0x4007882")]
		[FieldOffset(Offset = "0x70")]
		public UISuperCarMainRewardItemView m_View;

		// Token: 0x04007883 RID: 30851
		[Token(Token = "0x4007883")]
		[FieldOffset(Offset = "0x78")]
		public StatndardItemMiniData m_Data;

		// Token: 0x04007884 RID: 30852
		[Token(Token = "0x4007884")]
		[FieldOffset(Offset = "0x80")]
		public bool ForceFullScreenPreview;
	}
}
