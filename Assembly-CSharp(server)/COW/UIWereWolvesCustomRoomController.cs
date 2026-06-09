using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C0B RID: 7179
	[Token(Token = "0x2001C0B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB60C", Offset = "0x10FB60C")]
	internal class UIWereWolvesCustomRoomController : UINavigationController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x06009C3F RID: 39999 RVA: 0x00029010 File Offset: 0x00027210
		[Token(Token = "0x6009C3F")]
		[Address(RVA = "0x1788E34", Offset = "0x1788E34", VA = "0x7BBBF88E34")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009C40 RID: 40000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C40")]
		[Address(RVA = "0x1788E84", Offset = "0x1788E84", VA = "0x7BBBF88E84", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009C41 RID: 40001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C41")]
		[Address(RVA = "0x1789C34", Offset = "0x1789C34", VA = "0x7BBBF89C34", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009C42 RID: 40002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C42")]
		[Address(RVA = "0x1789DA8", Offset = "0x1789DA8", VA = "0x7BBBF89DA8", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06009C43 RID: 40003 RVA: 0x00029028 File Offset: 0x00027228
		[Token(Token = "0x6009C43")]
		[Address(RVA = "0x178B42C", Offset = "0x178B42C", VA = "0x7BBBF8B42C", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06009C44 RID: 40004 RVA: 0x00029040 File Offset: 0x00027240
		[Token(Token = "0x6009C44")]
		[Address(RVA = "0x178B434", Offset = "0x178B434", VA = "0x7BBBF8B434", Slot = "37")]
		public override bool OverwriteBackButtonLogic()
		{
			return default(bool);
		}

		// Token: 0x06009C45 RID: 40005 RVA: 0x00029058 File Offset: 0x00027258
		[Token(Token = "0x6009C45")]
		[Address(RVA = "0x178B6F8", Offset = "0x178B6F8", VA = "0x7BBBF8B6F8", Slot = "42")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009C46 RID: 40006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C46")]
		[Address(RVA = "0x178B75C", Offset = "0x178B75C", VA = "0x7BBBF8B75C", Slot = "41")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009C47 RID: 40007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C47")]
		[Address(RVA = "0x1789E0C", Offset = "0x1789E0C", VA = "0x7BBBF89E0C")]
		public void RefreshUIData(bool mapModeChanged)
		{
		}

		// Token: 0x06009C48 RID: 40008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C48")]
		[Address(RVA = "0x178B2CC", Offset = "0x178B2CC", VA = "0x7BBBF8B2CC")]
		private void RefreshRoomCard()
		{
		}

		// Token: 0x06009C49 RID: 40009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C49")]
		[Address(RVA = "0x178BDB0", Offset = "0x178BDB0", VA = "0x7BBBF8BDB0", Slot = "39")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06009C4A RID: 40010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C4A")]
		[Address(RVA = "0x178BE44", Offset = "0x178BE44", VA = "0x7BBBF8BE44", Slot = "40")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06009C4B RID: 40011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C4B")]
		[Address(RVA = "0x178BE74", Offset = "0x178BE74", VA = "0x7BBBF8BE74")]
		private void OnBtnGameStart()
		{
		}

		// Token: 0x06009C4C RID: 40012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C4C")]
		[Address(RVA = "0x178BF58", Offset = "0x178BF58", VA = "0x7BBBF8BF58")]
		private string GetCurrentGameStartInfo()
		{
			return null;
		}

		// Token: 0x06009C4D RID: 40013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C4D")]
		[Address(RVA = "0x178C270", Offset = "0x178C270", VA = "0x7BBBF8C270")]
		private void OnBtnInvite()
		{
		}

		// Token: 0x06009C4E RID: 40014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C4E")]
		[Address(RVA = "0x178C430", Offset = "0x178C430", VA = "0x7BBBF8C430")]
		private void OnBtnCustomize()
		{
		}

		// Token: 0x06009C4F RID: 40015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C4F")]
		[Address(RVA = "0x178C4D0", Offset = "0x178C4D0", VA = "0x7BBBF8C4D0")]
		private void OnShareClick()
		{
		}

		// Token: 0x06009C50 RID: 40016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C50")]
		[Address(RVA = "0x17899F4", Offset = "0x17899F4", VA = "0x7BBBF899F4")]
		private void UpdateShareUI()
		{
		}

		// Token: 0x06009C51 RID: 40017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C51")]
		[Address(RVA = "0x178C6B4", Offset = "0x178C6B4", VA = "0x7BBBF8C6B4")]
		private void OnDisplayTypeBtnChange()
		{
		}

		// Token: 0x06009C52 RID: 40018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C52")]
		[Address(RVA = "0x178C7C4", Offset = "0x178C7C4", VA = "0x7BBBF8C7C4")]
		private void OnBackBtnClick()
		{
		}

		// Token: 0x06009C53 RID: 40019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C53")]
		[Address(RVA = "0x1789ACC", Offset = "0x1789ACC", VA = "0x7BBBF89ACC")]
		private void RefreshDisplayTypeLabel()
		{
		}

		// Token: 0x06009C54 RID: 40020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C54")]
		[Address(RVA = "0x178C880", Offset = "0x178C880", VA = "0x7BBBF8C880")]
		private void OnSelectedChanged(params object[] data)
		{
		}

		// Token: 0x06009C55 RID: 40021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C55")]
		[Address(RVA = "0x178BA44", Offset = "0x178BA44", VA = "0x7BBBF8BA44")]
		private void StartBtnCountDown()
		{
		}

		// Token: 0x06009C56 RID: 40022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C56")]
		[Address(RVA = "0x178C95C", Offset = "0x178C95C", VA = "0x7BBBF8C95C")]
		private void OnCountDownStarted()
		{
		}

		// Token: 0x06009C57 RID: 40023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C57")]
		[Address(RVA = "0x178B8A8", Offset = "0x178B8A8", VA = "0x7BBBF8B8A8")]
		private void OnCountDownFinished()
		{
		}

		// Token: 0x06009C58 RID: 40024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C58")]
		[Address(RVA = "0x178BBD4", Offset = "0x178BBD4", VA = "0x7BBBF8BBD4")]
		private void RefreshWaiting()
		{
		}

		// Token: 0x06009C59 RID: 40025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C59")]
		[Address(RVA = "0x178C9A4", Offset = "0x178C9A4", VA = "0x7BBBF8C9A4", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06009C5A RID: 40026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C5A")]
		[Address(RVA = "0x178CA54", Offset = "0x178CA54", VA = "0x7BBBF8CA54")]
		public UIWereWolvesCustomRoomController()
		{
		}

		// Token: 0x06009C5B RID: 40027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C5B")]
		[Address(RVA = "0x178CABC", Offset = "0x178CABC", VA = "0x7BBBF8CABC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145274", Offset = "0x1145274")]
		private void <OnBtnGameStart>b__23_0()
		{
		}

		// Token: 0x0400A226 RID: 41510
		[Token(Token = "0x400A226")]
		private const int ITEM_WIDTH = 398;

		// Token: 0x0400A227 RID: 41511
		[Token(Token = "0x400A227")]
		private const int ITEM_HEIGHT = 54;

		// Token: 0x0400A228 RID: 41512
		[Token(Token = "0x400A228")]
		private const string RoomModeName = "KEY_WereWolvesRoomModeName";

		// Token: 0x0400A229 RID: 41513
		[Token(Token = "0x400A229")]
		[FieldOffset(Offset = "0xB0")]
		private UIWereWolvesCustomRoomView m_View;

		// Token: 0x0400A22A RID: 41514
		[Token(Token = "0x400A22A")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelCustomRoom m_Model;

		// Token: 0x0400A22B RID: 41515
		[Token(Token = "0x400A22B")]
		[FieldOffset(Offset = "0xC0")]
		private UIInviteGroupBoxController m_GroupInvitationController;

		// Token: 0x0400A22C RID: 41516
		[Token(Token = "0x400A22C")]
		[FieldOffset(Offset = "0xC8")]
		private UIRoomCardListController m_RoomCardCtrl;

		// Token: 0x0400A22D RID: 41517
		[Token(Token = "0x400A22D")]
		private const int COOLDOWN_SECONDS = 35;

		// Token: 0x0400A22E RID: 41518
		[Token(Token = "0x400A22E")]
		[FieldOffset(Offset = "0xD0")]
		private Dictionary<INp{ZCe, uint> m_CurRoomParamMap;

		// Token: 0x0400A22F RID: 41519
		[Token(Token = "0x400A22F")]
		[FieldOffset(Offset = "0xD8")]
		private CountDownConfig m_Config;

		// Token: 0x0400A230 RID: 41520
		[Token(Token = "0x400A230")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_FirstEnteringIdleStateChecked;

		// Token: 0x02001C0C RID: 7180
		[Token(Token = "0x2001C0C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB644", Offset = "0x10FB644")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06009C5C RID: 40028 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009C5C")]
			[Address(RVA = "0x178B6F0", Offset = "0x178B6F0", VA = "0x7BBBF8B6F0")]
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x06009C5D RID: 40029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009C5D")]
			[Address(RVA = "0x178CB24", Offset = "0x178CB24", VA = "0x7BBBF8CB24")]
			internal void <OverwriteBackButtonLogic>b__0()
			{
			}

			// Token: 0x06009C5E RID: 40030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009C5E")]
			[Address(RVA = "0x178CCD4", Offset = "0x178CCD4", VA = "0x7BBBF8CCD4")]
			internal void <OverwriteBackButtonLogic>b__1()
			{
			}

			// Token: 0x0400A231 RID: 41521
			[Token(Token = "0x400A231")]
			[FieldOffset(Offset = "0x10")]
			public UIWereWolvesCustomRoomController <>4__this;

			// Token: 0x0400A232 RID: 41522
			[Token(Token = "0x400A232")]
			[FieldOffset(Offset = "0x18")]
			public UIPopupMessageBoxController quitDialog;
		}
	}
}
