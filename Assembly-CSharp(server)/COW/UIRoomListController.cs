using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B63 RID: 7011
	[Token(Token = "0x2001B63")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9EDC", Offset = "0x10F9EDC")]
	public class UIRoomListController : UINavigationController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x060096BD RID: 38589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A45")]
		private List<FRoomModeSelectData> RoomModeSelectDatas
		{
			[Token(Token = "0x60096BD")]
			[Address(RVA = "0x1A121FC", Offset = "0x1A121FC", VA = "0x7BBC2121FC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060096BE RID: 38590 RVA: 0x00027D50 File Offset: 0x00025F50
		[Token(Token = "0x60096BE")]
		[Address(RVA = "0x1A12270", Offset = "0x1A12270", VA = "0x7BBC212270")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060096BF RID: 38591 RVA: 0x00027D68 File Offset: 0x00025F68
		[Token(Token = "0x60096BF")]
		[Address(RVA = "0x1A122C0", Offset = "0x1A122C0", VA = "0x7BBC2122C0", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x060096C0 RID: 38592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096C0")]
		[Address(RVA = "0x1A122C8", Offset = "0x1A122C8", VA = "0x7BBC2122C8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060096C1 RID: 38593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096C1")]
		[Address(RVA = "0x1A12FBC", Offset = "0x1A12FBC", VA = "0x7BBC212FBC", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x060096C2 RID: 38594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096C2")]
		[Address(RVA = "0x1A1306C", Offset = "0x1A1306C", VA = "0x7BBC21306C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060096C3 RID: 38595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096C3")]
		[Address(RVA = "0x1A132B8", Offset = "0x1A132B8", VA = "0x7BBC2132B8", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x060096C4 RID: 38596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096C4")]
		[Address(RVA = "0x1A13A7C", Offset = "0x1A13A7C", VA = "0x7BBC213A7C", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x060096C5 RID: 38597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096C5")]
		[Address(RVA = "0x1A13B2C", Offset = "0x1A13B2C", VA = "0x7BBC213B2C")]
		private void OnInputChanged()
		{
		}

		// Token: 0x060096C6 RID: 38598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096C6")]
		[Address(RVA = "0x1A13BDC", Offset = "0x1A13BDC", VA = "0x7BBC213BDC")]
		private void OnBtnInputClear()
		{
		}

		// Token: 0x060096C7 RID: 38599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096C7")]
		[Address(RVA = "0x1A13C50", Offset = "0x1A13C50", VA = "0x7BBC213C50")]
		public void SearchRoomById(ERoom.Type roomType, string roomId)
		{
		}

		// Token: 0x060096C8 RID: 38600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096C8")]
		[Address(RVA = "0x1A144F8", Offset = "0x1A144F8", VA = "0x7BBC2144F8")]
		private void SelectCasual(UIToggleButton btn)
		{
		}

		// Token: 0x060096C9 RID: 38601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096C9")]
		[Address(RVA = "0x1A145D0", Offset = "0x1A145D0", VA = "0x7BBC2145D0")]
		private void SelectLeagueNormal(UIToggleButton btn)
		{
		}

		// Token: 0x060096CA RID: 38602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096CA")]
		[Address(RVA = "0x1A146AC", Offset = "0x1A146AC", VA = "0x7BBC2146AC")]
		private void SelectWereWolvesRoom(UIToggleButton btn)
		{
		}

		// Token: 0x060096CB RID: 38603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096CB")]
		[Address(RVA = "0x1A14788", Offset = "0x1A14788", VA = "0x7BBC214788")]
		private void SelectMyRoom(UIToggleButton btn)
		{
		}

		// Token: 0x060096CC RID: 38604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096CC")]
		[Address(RVA = "0x1A14274", Offset = "0x1A14274", VA = "0x7BBC214274")]
		private void OnBtnRoomSearch()
		{
		}

		// Token: 0x060096CD RID: 38605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096CD")]
		[Address(RVA = "0x1A14500", Offset = "0x1A14500", VA = "0x7BBC214500")]
		private void OnRoomToggleSelect(ERoom.TabType roomType)
		{
		}

		// Token: 0x060096CE RID: 38606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096CE")]
		[Address(RVA = "0x1A148F0", Offset = "0x1A148F0", VA = "0x7BBC2148F0")]
		private void OnBtnRoomRefresh()
		{
		}

		// Token: 0x060096CF RID: 38607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096CF")]
		[Address(RVA = "0x1A14D14", Offset = "0x1A14D14", VA = "0x7BBC214D14")]
		private void OnBtnRoomCreate()
		{
		}

		// Token: 0x060096D0 RID: 38608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096D0")]
		[Address(RVA = "0x1A151BC", Offset = "0x1A151BC", VA = "0x7BBC2151BC")]
		private void TryToCreateWereWolvesRoom()
		{
		}

		// Token: 0x060096D1 RID: 38609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096D1")]
		[Address(RVA = "0x1A1567C", Offset = "0x1A1567C", VA = "0x7BBC21567C")]
		private void OnSelectModeBtnClick()
		{
		}

		// Token: 0x060096D2 RID: 38610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096D2")]
		[Address(RVA = "0x1A15B88", Offset = "0x1A15B88", VA = "0x7BBC215B88")]
		private void OnSelectModeApply()
		{
		}

		// Token: 0x060096D3 RID: 38611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096D3")]
		[Address(RVA = "0x1A15828", Offset = "0x1A15828", VA = "0x7BBC215828")]
		private void InitGameModePopMenuData()
		{
		}

		// Token: 0x060096D4 RID: 38612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096D4")]
		[Address(RVA = "0x1A133D4", Offset = "0x1A133D4", VA = "0x7BBC2133D4")]
		private void UpdateTeamNumber(object[] param)
		{
		}

		// Token: 0x060096D5 RID: 38613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096D5")]
		[Address(RVA = "0x1A15CD0", Offset = "0x1A15CD0", VA = "0x7BBC215CD0")]
		private void UpdateBatchRoom(object[] param)
		{
		}

		// Token: 0x060096D6 RID: 38614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096D6")]
		[Address(RVA = "0x1A1368C", Offset = "0x1A1368C", VA = "0x7BBC21368C")]
		private void UpdateRoomCard()
		{
		}

		// Token: 0x060096D7 RID: 38615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096D7")]
		[Address(RVA = "0x1A14790", Offset = "0x1A14790", VA = "0x7BBC214790")]
		private void RefreshRoomList(List<RoomBasicInfo> roomList)
		{
		}

		// Token: 0x060096D8 RID: 38616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096D8")]
		[Address(RVA = "0x1A16030", Offset = "0x1A16030", VA = "0x7BBC216030")]
		private void OnCountDownStarted()
		{
		}

		// Token: 0x060096D9 RID: 38617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096D9")]
		[Address(RVA = "0x1A16138", Offset = "0x1A16138", VA = "0x7BBC216138")]
		private void OnCountDownUpdate()
		{
		}

		// Token: 0x060096DA RID: 38618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096DA")]
		[Address(RVA = "0x1A13940", Offset = "0x1A13940", VA = "0x7BBC213940")]
		private void OnCountDownFinished()
		{
		}

		// Token: 0x060096DB RID: 38619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096DB")]
		[Address(RVA = "0x1A162F4", Offset = "0x1A162F4", VA = "0x7BBC2162F4", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060096DC RID: 38620 RVA: 0x00027D80 File Offset: 0x00025F80
		[Token(Token = "0x60096DC")]
		[Address(RVA = "0x1A164D8", Offset = "0x1A164D8", VA = "0x7BBC2164D8", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060096DD RID: 38621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60096DD")]
		[Address(RVA = "0x1A1653C", Offset = "0x1A1653C", VA = "0x7BBC21653C", Slot = "41")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060096DE RID: 38622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096DE")]
		[Address(RVA = "0x1A165D0", Offset = "0x1A165D0", VA = "0x7BBC2165D0", Slot = "42")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060096DF RID: 38623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096DF")]
		[Address(RVA = "0x1A16600", Offset = "0x1A16600", VA = "0x7BBC216600")]
		public UIRoomListController()
		{
		}

		// Token: 0x04009F2F RID: 40751
		[Token(Token = "0x4009F2F")]
		private const int COOLDOWN_SECONDS = 30;

		// Token: 0x04009F30 RID: 40752
		[Token(Token = "0x4009F30")]
		[FieldOffset(Offset = "0xB0")]
		private CountDownConfig config;

		// Token: 0x04009F31 RID: 40753
		[Token(Token = "0x4009F31")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelMall m_ModelMall;

		// Token: 0x04009F32 RID: 40754
		[Token(Token = "0x4009F32")]
		[FieldOffset(Offset = "0xC0")]
		private UIRoomListView m_View;

		// Token: 0x04009F33 RID: 40755
		[Token(Token = "0x4009F33")]
		[FieldOffset(Offset = "0xC8")]
		private ERoom.TabType m_RoomTabType;

		// Token: 0x04009F34 RID: 40756
		[Token(Token = "0x4009F34")]
		[FieldOffset(Offset = "0xCC")]
		private bool m_HasLeagueRequested;

		// Token: 0x04009F35 RID: 40757
		[Token(Token = "0x4009F35")]
		[FieldOffset(Offset = "0xCD")]
		private bool m_HasWereWolvesRequested;

		// Token: 0x04009F36 RID: 40758
		[Token(Token = "0x4009F36")]
		[FieldOffset(Offset = "0xD0")]
		private UIRoomModeSelectPopupWindowController m_RoomModeSelectPopupWindowController;

		// Token: 0x04009F37 RID: 40759
		[Token(Token = "0x4009F37")]
		[FieldOffset(Offset = "0xD8")]
		private UIRoomCardListController m_RoomCardCtrl;

		// Token: 0x04009F38 RID: 40760
		[Token(Token = "0x4009F38")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_IsRefreshCountDown;

		// Token: 0x04009F39 RID: 40761
		[Token(Token = "0x4009F39")]
		[FieldOffset(Offset = "0xE8")]
		private List<FRoomModeSelectData> m_RoomModeSelectDatas;

		// Token: 0x04009F3A RID: 40762
		[Token(Token = "0x4009F3A")]
		[FieldOffset(Offset = "0xF0")]
		protected List<ResourceID> m_WereWolvesNeedDownloadRes;
	}
}
