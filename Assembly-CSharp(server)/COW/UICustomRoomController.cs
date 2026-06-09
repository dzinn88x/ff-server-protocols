using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x0200177C RID: 6012
	[Token(Token = "0x200177C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F223C", Offset = "0x10F223C")]
	public class UICustomRoomController : UINavigationController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x060071EB RID: 29163 RVA: 0x0001FB60 File Offset: 0x0001DD60
		[Token(Token = "0x60071EB")]
		[Address(RVA = "0x1BA455C", Offset = "0x1BA455C", VA = "0x7BBC3A455C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060071EC RID: 29164 RVA: 0x0001FB78 File Offset: 0x0001DD78
		[Token(Token = "0x60071EC")]
		[Address(RVA = "0x1BA45AC", Offset = "0x1BA45AC", VA = "0x7BBC3A45AC", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x060071ED RID: 29165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071ED")]
		[Address(RVA = "0x1BA45B4", Offset = "0x1BA45B4", VA = "0x7BBC3A45B4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060071EE RID: 29166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071EE")]
		[Address(RVA = "0x1BA5AFC", Offset = "0x1BA5AFC", VA = "0x7BBC3A5AFC", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x060071EF RID: 29167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071EF")]
		[Address(RVA = "0x1BA57A8", Offset = "0x1BA57A8", VA = "0x7BBC3A57A8")]
		private void UpdateShareUI()
		{
		}

		// Token: 0x060071F0 RID: 29168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071F0")]
		[Address(RVA = "0x1BA5BAC", Offset = "0x1BA5BAC", VA = "0x7BBC3A5BAC")]
		private void OnBtnGameStart()
		{
		}

		// Token: 0x060071F1 RID: 29169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071F1")]
		[Address(RVA = "0x1BA60CC", Offset = "0x1BA60CC", VA = "0x7BBC3A60CC")]
		private void OnBtnGameStartCallBack()
		{
		}

		// Token: 0x060071F2 RID: 29170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071F2")]
		[Address(RVA = "0x1BA6208", Offset = "0x1BA6208", VA = "0x7BBC3A6208")]
		private void OnBtnGameReady()
		{
		}

		// Token: 0x060071F3 RID: 29171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071F3")]
		[Address(RVA = "0x1BA6264", Offset = "0x1BA6264", VA = "0x7BBC3A6264")]
		private void OnBtnInvite()
		{
		}

		// Token: 0x060071F4 RID: 29172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F4")]
		[Address(RVA = "0x1BA5C90", Offset = "0x1BA5C90", VA = "0x7BBC3A5C90")]
		private string GetCurrentGameStartInfo()
		{
			return null;
		}

		// Token: 0x060071F5 RID: 29173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071F5")]
		[Address(RVA = "0x1BA6424", Offset = "0x1BA6424", VA = "0x7BBC3A6424")]
		private void OnBtnCustomize()
		{
		}

		// Token: 0x060071F6 RID: 29174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071F6")]
		[Address(RVA = "0x1BA64C4", Offset = "0x1BA64C4", VA = "0x7BBC3A64C4")]
		private void OnOBShowBtnClick()
		{
		}

		// Token: 0x060071F7 RID: 29175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071F7")]
		[Address(RVA = "0x1BA6554", Offset = "0x1BA6554", VA = "0x7BBC3A6554")]
		private void OnOBHideBtnClick()
		{
		}

		// Token: 0x060071F8 RID: 29176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071F8")]
		[Address(RVA = "0x1BA65E4", Offset = "0x1BA65E4", VA = "0x7BBC3A65E4", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x060071F9 RID: 29177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071F9")]
		[Address(RVA = "0x1BA8C3C", Offset = "0x1BA8C3C", VA = "0x7BBC3A8C3C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060071FA RID: 29178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071FA")]
		[Address(RVA = "0x1BA8CD4", Offset = "0x1BA8CD4", VA = "0x7BBC3A8CD4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060071FB RID: 29179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071FB")]
		[Address(RVA = "0x1BA6648", Offset = "0x1BA6648", VA = "0x7BBC3A6648")]
		public void RefreshUIData(bool mapModeChanged)
		{
		}

		// Token: 0x060071FC RID: 29180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071FC")]
		[Address(RVA = "0x1BA8A4C", Offset = "0x1BA8A4C", VA = "0x7BBC3A8A4C")]
		private void RefreshRoomCard()
		{
		}

		// Token: 0x060071FD RID: 29181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071FD")]
		[Address(RVA = "0x1BA93EC", Offset = "0x1BA93EC", VA = "0x7BBC3A93EC")]
		private void RefreshReadyBtn()
		{
		}

		// Token: 0x060071FE RID: 29182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071FE")]
		[Address(RVA = "0x1BA95F8", Offset = "0x1BA95F8", VA = "0x7BBC3A95F8")]
		private void RefreshWaiting()
		{
		}

		// Token: 0x060071FF RID: 29183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071FF")]
		[Address(RVA = "0x1BA97D4", Offset = "0x1BA97D4", VA = "0x7BBC3A97D4")]
		private void RefreshLoadout()
		{
		}

		// Token: 0x06007200 RID: 29184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007200")]
		[Address(RVA = "0x1BA5880", Offset = "0x1BA5880", VA = "0x7BBC3A5880")]
		private void InitItemWidthAndHeight()
		{
		}

		// Token: 0x06007201 RID: 29185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007201")]
		[Address(RVA = "0x1BA9890", Offset = "0x1BA9890", VA = "0x7BBC3A9890")]
		private void OnShareClick()
		{
		}

		// Token: 0x06007202 RID: 29186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007202")]
		[Address(RVA = "0x1BA9BCC", Offset = "0x1BA9BCC", VA = "0x7BBC3A9BCC", Slot = "39")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06007203 RID: 29187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007203")]
		[Address(RVA = "0x1BA9D38", Offset = "0x1BA9D38", VA = "0x7BBC3A9D38", Slot = "40")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06007204 RID: 29188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007204")]
		[Address(RVA = "0x1BA9D68", Offset = "0x1BA9D68", VA = "0x7BBC3A9D68", Slot = "41")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007205 RID: 29189 RVA: 0x0001FB90 File Offset: 0x0001DD90
		[Token(Token = "0x6007205")]
		[Address(RVA = "0x1BA9EB4", Offset = "0x1BA9EB4", VA = "0x7BBC3A9EB4", Slot = "42")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007206 RID: 29190 RVA: 0x0001FBA8 File Offset: 0x0001DDA8
		[Token(Token = "0x6007206")]
		[Address(RVA = "0x1BA9F18", Offset = "0x1BA9F18", VA = "0x7BBC3A9F18", Slot = "37")]
		public override bool OverwriteBackButtonLogic()
		{
			return default(bool);
		}

		// Token: 0x06007207 RID: 29191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007207")]
		[Address(RVA = "0x1BA925C", Offset = "0x1BA925C", VA = "0x7BBC3A925C")]
		private void StartBtnCountDown()
		{
		}

		// Token: 0x06007208 RID: 29192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007208")]
		[Address(RVA = "0x1BAA298", Offset = "0x1BAA298", VA = "0x7BBC3AA298")]
		private void OnCountDownStarted()
		{
		}

		// Token: 0x06007209 RID: 29193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007209")]
		[Address(RVA = "0x1BA90C0", Offset = "0x1BA90C0", VA = "0x7BBC3A90C0")]
		private void OnCountDownFinished()
		{
		}

		// Token: 0x0600720A RID: 29194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600720A")]
		[Address(RVA = "0x1BA8F00", Offset = "0x1BA8F00", VA = "0x7BBC3A8F00")]
		private string GetSettingString(ECustomRoomSetting setting)
		{
			return null;
		}

		// Token: 0x0600720B RID: 29195 RVA: 0x0001FBC0 File Offset: 0x0001DDC0
		[Token(Token = "0x600720B")]
		[Address(RVA = "0x1BAA2E0", Offset = "0x1BAA2E0", VA = "0x7BBC3AA2E0")]
		private bool IsRoomSettingsTrue(ECustomRoomSetting setting)
		{
			return default(bool);
		}

		// Token: 0x0600720C RID: 29196 RVA: 0x0001FBD8 File Offset: 0x0001DDD8
		[Token(Token = "0x600720C")]
		[Address(RVA = "0x1BAA2EC", Offset = "0x1BAA2EC", VA = "0x7BBC3AA2EC")]
		private bool IsRoomSettingsTrue(uint setting)
		{
			return default(bool);
		}

		// Token: 0x0600720D RID: 29197 RVA: 0x0001FBF0 File Offset: 0x0001DDF0
		[Token(Token = "0x600720D")]
		[Address(RVA = "0x1BA8E9C", Offset = "0x1BA8E9C", VA = "0x7BBC3A8E9C")]
		protected uint GetRoomSettingValue(ECustomRoomSetting start, ECustomRoomSetting end)
		{
			return 0U;
		}

		// Token: 0x0600720E RID: 29198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600720E")]
		[Address(RVA = "0x1BA8FE0", Offset = "0x1BA8FE0", VA = "0x7BBC3A8FE0")]
		private string GetSetting2String(ECustomRoomSetting2 setting)
		{
			return null;
		}

		// Token: 0x0600720F RID: 29199 RVA: 0x0001FC08 File Offset: 0x0001DE08
		[Token(Token = "0x600720F")]
		[Address(RVA = "0x1BAA2F8", Offset = "0x1BAA2F8", VA = "0x7BBC3AA2F8")]
		private bool IsRoomSettings2True(ECustomRoomSetting2 setting)
		{
			return default(bool);
		}

		// Token: 0x06007210 RID: 29200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007210")]
		[Address(RVA = "0x1BAA304", Offset = "0x1BAA304", VA = "0x7BBC3AA304")]
		private void OnDisplayTypeBtnChange()
		{
		}

		// Token: 0x06007211 RID: 29201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007211")]
		[Address(RVA = "0x1BAA414", Offset = "0x1BAA414", VA = "0x7BBC3AA414")]
		private void OnBackBtnClick()
		{
		}

		// Token: 0x06007212 RID: 29202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007212")]
		[Address(RVA = "0x1BA5994", Offset = "0x1BA5994", VA = "0x7BBC3A5994")]
		private void RefreshDisplayTypeLabel()
		{
		}

		// Token: 0x06007213 RID: 29203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007213")]
		[Address(RVA = "0x1BAA4D0", Offset = "0x1BAA4D0", VA = "0x7BBC3AA4D0")]
		private void OnSelectedChanged(params object[] data)
		{
		}

		// Token: 0x06007214 RID: 29204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007214")]
		[Address(RVA = "0x1BAA5AC", Offset = "0x1BAA5AC", VA = "0x7BBC3AA5AC")]
		private void OnCountDownStart(params object[] data)
		{
		}

		// Token: 0x06007215 RID: 29205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007215")]
		[Address(RVA = "0x1BAA8C0", Offset = "0x1BAA8C0", VA = "0x7BBC3AA8C0")]
		public UICustomRoomController()
		{
		}

		// Token: 0x06007216 RID: 29206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007216")]
		[Address(RVA = "0x1BAAA14", Offset = "0x1BAAA14", VA = "0x7BBC3AAA14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1141950", Offset = "0x1141950")]
		private void <OverwriteBackButtonLogic>b__48_0()
		{
		}

		// Token: 0x04008B33 RID: 35635
		[Token(Token = "0x4008B33")]
		private const int ITEM_WIDTH = 398;

		// Token: 0x04008B34 RID: 35636
		[Token(Token = "0x4008B34")]
		private const int SOLO_ITEM_HEIGHT = 54;

		// Token: 0x04008B35 RID: 35637
		[Token(Token = "0x4008B35")]
		private const int DUO_ITEM_HEIGHT = 100;

		// Token: 0x04008B36 RID: 35638
		[Token(Token = "0x4008B36")]
		private const int QUAD_ITEM_HEIGHT = 192;

		// Token: 0x04008B37 RID: 35639
		[Token(Token = "0x4008B37")]
		private const int DUO_ITEM_HEIGHT_WITH_TEAMINFO = 132;

		// Token: 0x04008B38 RID: 35640
		[Token(Token = "0x4008B38")]
		private const int QUAD_ITEM_HEIGHT_WITH_TEAMINFO = 216;

		// Token: 0x04008B39 RID: 35641
		[Token(Token = "0x4008B39")]
		private const int COOLDOWN_SECONDS = 35;

		// Token: 0x04008B3A RID: 35642
		[Token(Token = "0x4008B3A")]
		[FieldOffset(Offset = "0xB0")]
		private CountDownConfig m_Config;

		// Token: 0x04008B3B RID: 35643
		[Token(Token = "0x4008B3B")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_FirstEnteringIdleStateChecked;

		// Token: 0x04008B3C RID: 35644
		[Token(Token = "0x4008B3C")]
		[FieldOffset(Offset = "0xC0")]
		private UICustomRoomView m_View;

		// Token: 0x04008B3D RID: 35645
		[Token(Token = "0x4008B3D")]
		[FieldOffset(Offset = "0xC8")]
		private UIModelCustomRoom m_Model;

		// Token: 0x04008B3E RID: 35646
		[Token(Token = "0x4008B3E")]
		[FieldOffset(Offset = "0xD0")]
		private UIInviteGroupBoxController m_GroupInvitationController;

		// Token: 0x04008B3F RID: 35647
		[Token(Token = "0x4008B3F")]
		[FieldOffset(Offset = "0xD8")]
		private UIRoomCardListController m_RoomCardCtrl;

		// Token: 0x04008B40 RID: 35648
		[Token(Token = "0x4008B40")]
		[FieldOffset(Offset = "0xE0")]
		private UICustomRoomCountDownWindowController m_CountDownController;

		// Token: 0x04008B41 RID: 35649
		[Token(Token = "0x4008B41")]
		[FieldOffset(Offset = "0xE8")]
		private int m_ItemHeight;

		// Token: 0x04008B42 RID: 35650
		[Token(Token = "0x4008B42")]
		[FieldOffset(Offset = "0xEC")]
		private uint m_RoomSetting;

		// Token: 0x04008B43 RID: 35651
		[Token(Token = "0x4008B43")]
		[FieldOffset(Offset = "0xF0")]
		private uint m_RoomSetting2;

		// Token: 0x04008B44 RID: 35652
		[Token(Token = "0x4008B44")]
		[FieldOffset(Offset = "0xF8")]
		protected RoomCreateRuleDataManager m_DataManager;

		// Token: 0x04008B45 RID: 35653
		[Token(Token = "0x4008B45")]
		[FieldOffset(Offset = "0x100")]
		private List<UIRoomObserverItemController> m_SpectatorCtrls;

		// Token: 0x04008B46 RID: 35654
		[Token(Token = "0x4008B46")]
		[FieldOffset(Offset = "0x108")]
		private Dictionary<ERoom.Type, string> m_RoomModeNameDict;

		// Token: 0x04008B47 RID: 35655
		[Token(Token = "0x4008B47")]
		[FieldOffset(Offset = "0x110")]
		private readonly string m_VoiceRoomTag;

		// Token: 0x0200177D RID: 6013
		[Token(Token = "0x200177D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F2274", Offset = "0x10F2274")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06007218 RID: 29208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007218")]
			[Address(RVA = "0x1BAAC18", Offset = "0x1BAAC18", VA = "0x7BBC3AAC18")]
			public <>c()
			{
			}

			// Token: 0x06007219 RID: 29209 RVA: 0x0001FC20 File Offset: 0x0001DE20
			[Token(Token = "0x6007219")]
			[Address(RVA = "0x1BAAC20", Offset = "0x1BAAC20", VA = "0x7BBC3AAC20")]
			internal int <RefreshUIData>b__37_0(RoomPlayerInfo a, RoomPlayerInfo b)
			{
				return 0;
			}

			// Token: 0x04008B48 RID: 35656
			[Token(Token = "0x4008B48")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UICustomRoomController.<>c <>9;

			// Token: 0x04008B49 RID: 35657
			[Token(Token = "0x4008B49")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<RoomPlayerInfo> <>9__37_0;
		}

		// Token: 0x0200177E RID: 6014
		[Token(Token = "0x200177E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F2284", Offset = "0x10F2284")]
		private sealed class <>c__DisplayClass48_0
		{
			// Token: 0x0600721A RID: 29210 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600721A")]
			[Address(RVA = "0x1BAA290", Offset = "0x1BAA290", VA = "0x7BBC3AA290")]
			public <>c__DisplayClass48_0()
			{
			}

			// Token: 0x0600721B RID: 29211 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600721B")]
			[Address(RVA = "0x1BAAC90", Offset = "0x1BAAC90", VA = "0x7BBC3AAC90")]
			internal void <OverwriteBackButtonLogic>b__1()
			{
			}

			// Token: 0x04008B4A RID: 35658
			[Token(Token = "0x4008B4A")]
			[FieldOffset(Offset = "0x10")]
			public UIPopupMessageBoxController quitDialog;
		}
	}
}
