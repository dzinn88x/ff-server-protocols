using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x020016E5 RID: 5861
	[Token(Token = "0x20016E5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0F8C", Offset = "0x10F0F8C")]
	internal class UIBaseHudInfoListController : UIBaseController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x06006C45 RID: 27717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C45")]
		[Address(RVA = "0x1421E24", Offset = "0x1421E24", VA = "0x7BBBC21E24", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006C46 RID: 27718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C46")]
		[Address(RVA = "0x1422708", Offset = "0x1422708", VA = "0x7BBBC22708")]
		protected void OnHotkeyInfoTabChanged(object[] data)
		{
		}

		// Token: 0x06006C47 RID: 27719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C47")]
		[Address(RVA = "0x14229F4", Offset = "0x14229F4", VA = "0x7BBBC229F4")]
		protected void AutoscrollToSelectedPlayer(object[] data)
		{
		}

		// Token: 0x06006C48 RID: 27720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C48")]
		[Address(RVA = "0x1422CA8", Offset = "0x1422CA8", VA = "0x7BBBC22CA8")]
		protected void RefreshAirdropSelected(object[] data)
		{
		}

		// Token: 0x06006C49 RID: 27721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C49")]
		[Address(RVA = "0x1422DBC", Offset = "0x1422DBC", VA = "0x7BBBC22DBC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006C4A RID: 27722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4A")]
		[Address(RVA = "0x1422F50", Offset = "0x1422F50", VA = "0x7BBBC22F50")]
		protected void OnCloseClick()
		{
		}

		// Token: 0x06006C4B RID: 27723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4B")]
		[Address(RVA = "0x1422880", Offset = "0x1422880", VA = "0x7BBBC22880")]
		protected void OnPlayerTabClick()
		{
		}

		// Token: 0x06006C4C RID: 27724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4C")]
		[Address(RVA = "0x1422954", Offset = "0x1422954", VA = "0x7BBBC22954")]
		protected void OnAirdropTabClick()
		{
		}

		// Token: 0x06006C4D RID: 27725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4D")]
		[Address(RVA = "0x14223A0", Offset = "0x14223A0", VA = "0x7BBBC223A0")]
		protected void SetPlayerGridParam()
		{
		}

		// Token: 0x06006C4E RID: 27726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4E")]
		[Address(RVA = "0x1422F94", Offset = "0x1422F94", VA = "0x7BBBC22F94")]
		protected void RefreshPlayerList()
		{
		}

		// Token: 0x06006C4F RID: 27727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4F")]
		[Address(RVA = "0x1423050", Offset = "0x1423050", VA = "0x7BBBC23050")]
		protected void RefreshAirdropList()
		{
		}

		// Token: 0x06006C50 RID: 27728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C50")]
		[Address(RVA = "0x1423418", Offset = "0x1423418", VA = "0x7BBBC23418", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006C51 RID: 27729 RVA: 0x0001E9F0 File Offset: 0x0001CBF0
		[Token(Token = "0x6006C51")]
		[Address(RVA = "0x14234CC", Offset = "0x14234CC", VA = "0x7BBBC234CC", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006C52 RID: 27730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C52")]
		[Address(RVA = "0x1423510", Offset = "0x1423510", VA = "0x7BBBC23510", Slot = "30")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006C53 RID: 27731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C53")]
		[Address(RVA = "0x14235CC", Offset = "0x14235CC", VA = "0x7BBBC235CC", Slot = "31")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06006C54 RID: 27732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C54")]
		[Address(RVA = "0x1422590", Offset = "0x1422590", VA = "0x7BBBC22590")]
		protected void ShowHudInfoList(bool value)
		{
		}

		// Token: 0x06006C55 RID: 27733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C55")]
		[Address(RVA = "0x14235FC", Offset = "0x14235FC", VA = "0x7BBBC235FC")]
		private void OnShowFinished()
		{
		}

		// Token: 0x06006C56 RID: 27734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C56")]
		[Address(RVA = "0x1423720", Offset = "0x1423720", VA = "0x7BBBC23720")]
		public UIBaseHudInfoListController()
		{
		}

		// Token: 0x040087F5 RID: 34805
		[Token(Token = "0x40087F5")]
		protected const uint SINGLE_PLAYER_CELL_HEIGHT = 80U;

		// Token: 0x040087F6 RID: 34806
		[Token(Token = "0x40087F6")]
		protected const uint DUO_PLAYER_CELL_HEIGHT = 150U;

		// Token: 0x040087F7 RID: 34807
		[Token(Token = "0x40087F7")]
		protected const uint QUAD_PLAYER_CELL_HEIGHT = 270U;

		// Token: 0x040087F8 RID: 34808
		[Token(Token = "0x40087F8")]
		protected const int SINGLE_PLAYER_ITEM_HEIGHT = 78;

		// Token: 0x040087F9 RID: 34809
		[Token(Token = "0x40087F9")]
		protected const int MULTI_PLAYER_ITEM_HEIGHT = 58;

		// Token: 0x040087FA RID: 34810
		[Token(Token = "0x40087FA")]
		[FieldOffset(Offset = "0x58")]
		protected UIBaseHudInfoListView m_BaseView;

		// Token: 0x040087FB RID: 34811
		[Token(Token = "0x40087FB")]
		[FieldOffset(Offset = "0x60")]
		protected UIModelSpectator m_Model;

		// Token: 0x040087FC RID: 34812
		[Token(Token = "0x40087FC")]
		[FieldOffset(Offset = "0x68")]
		protected List<UISPHudAirdropItemController> m_AirdropList;

		// Token: 0x040087FD RID: 34813
		[Token(Token = "0x40087FD")]
		[FieldOffset(Offset = "0x70")]
		protected zTfbhtW m_CurrentGroupMode;

		// Token: 0x040087FE RID: 34814
		[Token(Token = "0x40087FE")]
		[FieldOffset(Offset = "0x74")]
		protected Vector3 m_PlayerGridTransform;

		// Token: 0x040087FF RID: 34815
		[Token(Token = "0x40087FF")]
		[FieldOffset(Offset = "0x80")]
		protected float CELL_WIDTH;

		// Token: 0x04008800 RID: 34816
		[Token(Token = "0x4008800")]
		[FieldOffset(Offset = "0x84")]
		protected float m_CellHeight;

		// Token: 0x04008801 RID: 34817
		[Token(Token = "0x4008801")]
		[FieldOffset(Offset = "0x88")]
		protected float m_PlayerPanelHeight;

		// Token: 0x04008802 RID: 34818
		[Token(Token = "0x4008802")]
		[FieldOffset(Offset = "0x8C")]
		protected Vector3 m_MoveRelative;

		// Token: 0x04008803 RID: 34819
		[Token(Token = "0x4008803")]
		[FieldOffset(Offset = "0x98")]
		protected UIScrollView m_PlayerScrollView;

		// Token: 0x04008804 RID: 34820
		[Token(Token = "0x4008804")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_ShowInfoList;
	}
}
