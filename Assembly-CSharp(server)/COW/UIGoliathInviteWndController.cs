using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200137B RID: 4987
	[Token(Token = "0x200137B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB640", Offset = "0x10EB640")]
	public class UIGoliathInviteWndController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x06005018 RID: 20504 RVA: 0x000185A0 File Offset: 0x000167A0
		[Token(Token = "0x6005018")]
		[Address(RVA = "0x1A71D90", Offset = "0x1A71D90", VA = "0x7BBC271D90")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005019 RID: 20505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005019")]
		[Address(RVA = "0x1A71DE0", Offset = "0x1A71DE0", VA = "0x7BBC271DE0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600501A RID: 20506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600501A")]
		[Address(RVA = "0x1A72468", Offset = "0x1A72468", VA = "0x7BBC272468", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600501B RID: 20507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600501B")]
		[Address(RVA = "0x1A72824", Offset = "0x1A72824", VA = "0x7BBC272824", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600501C RID: 20508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600501C")]
		[Address(RVA = "0x1A728D0", Offset = "0x1A728D0", VA = "0x7BBC2728D0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600501D RID: 20509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600501D")]
		[Address(RVA = "0x1A72940", Offset = "0x1A72940", VA = "0x7BBC272940")]
		public void SetInviteData(ulong groupID, string captainName, uint memberCnt)
		{
		}

		// Token: 0x0600501E RID: 20510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600501E")]
		[Address(RVA = "0x1A724E4", Offset = "0x1A724E4", VA = "0x7BBC2724E4")]
		private void ShowGuideIfNeed()
		{
		}

		// Token: 0x0600501F RID: 20511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600501F")]
		[Address(RVA = "0x1A72274", Offset = "0x1A72274", VA = "0x7BBC272274")]
		private void InitViewData()
		{
		}

		// Token: 0x06005020 RID: 20512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005020")]
		[Address(RVA = "0x1A72498", Offset = "0x1A72498", VA = "0x7BBC272498")]
		private void RefreshViewData()
		{
		}

		// Token: 0x06005021 RID: 20513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005021")]
		[Address(RVA = "0x1A72BC0", Offset = "0x1A72BC0", VA = "0x7BBC272BC0")]
		private void RefreshGameOrPlatformFriendView(UIGoliathInviteWndController.EFriendCategory category)
		{
		}

		// Token: 0x06005022 RID: 20514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005022")]
		[Address(RVA = "0x1A72E90", Offset = "0x1A72E90", VA = "0x7BBC272E90")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x06005023 RID: 20515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005023")]
		[Address(RVA = "0x1A72E98", Offset = "0x1A72E98", VA = "0x7BBC272E98")]
		private void OnBtnGameFriendClick()
		{
		}

		// Token: 0x06005024 RID: 20516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005024")]
		[Address(RVA = "0x1A72EA0", Offset = "0x1A72EA0", VA = "0x7BBC272EA0")]
		private void OnBtnPlatformFriendClick()
		{
		}

		// Token: 0x06005025 RID: 20517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005025")]
		[Address(RVA = "0x1A72EAC", Offset = "0x1A72EAC", VA = "0x7BBC272EAC")]
		private void OnBtnRecruitClick()
		{
		}

		// Token: 0x06005026 RID: 20518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005026")]
		[Address(RVA = "0x1A72F84", Offset = "0x1A72F84", VA = "0x7BBC272F84")]
		private void OnBtnLineInviteClick()
		{
		}

		// Token: 0x06005027 RID: 20519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005027")]
		[Address(RVA = "0x1A732F8", Offset = "0x1A732F8", VA = "0x7BBC2732F8")]
		private void OnBtnVKInviteClick()
		{
		}

		// Token: 0x06005028 RID: 20520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005028")]
		[Address(RVA = "0x1A7350C", Offset = "0x1A7350C", VA = "0x7BBC27350C")]
		private void OnBtnFBInviteClick()
		{
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005029")]
		[Address(RVA = "0x1A73918", Offset = "0x1A73918", VA = "0x7BBC273918")]
		private void OnBtnOtherInviteClick()
		{
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600502A")]
		[Address(RVA = "0x1A73BBC", Offset = "0x1A73BBC", VA = "0x7BBC273BBC")]
		private void OnGuideClick()
		{
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600502B")]
		[Address(RVA = "0x1A73CB0", Offset = "0x1A73CB0", VA = "0x7BBC273CB0", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600502C RID: 20524 RVA: 0x000185B8 File Offset: 0x000167B8
		[Token(Token = "0x600502C")]
		[Address(RVA = "0x1A73E54", Offset = "0x1A73E54", VA = "0x7BBC273E54", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600502D")]
		[Address(RVA = "0x1A73ED8", Offset = "0x1A73ED8", VA = "0x7BBC273ED8", Slot = "42")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x0600502E RID: 20526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600502E")]
		[Address(RVA = "0x1A73F94", Offset = "0x1A73F94", VA = "0x7BBC273F94", Slot = "43")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x0600502F RID: 20527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600502F")]
		[Address(RVA = "0x1A73FC4", Offset = "0x1A73FC4", VA = "0x7BBC273FC4")]
		public UIGoliathInviteWndController()
		{
		}

		// Token: 0x06005030 RID: 20528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005030")]
		[Address(RVA = "0x1A74044", Offset = "0x1A74044", VA = "0x7BBC274044")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DFBC", Offset = "0x113DFBC")]
		private GoliathFriendItemData <RefreshGameOrPlatformFriendView>b__20_0(FriendAccountInfo friendInfo)
		{
			return null;
		}

		// Token: 0x040076A5 RID: 30373
		[Token(Token = "0x40076A5")]
		[FieldOffset(Offset = "0x98")]
		private UIGoliathInviteWndView m_View;

		// Token: 0x040076A6 RID: 30374
		[Token(Token = "0x40076A6")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelFriends m_ModelFriends;

		// Token: 0x040076A7 RID: 30375
		[Token(Token = "0x40076A7")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x040076A8 RID: 30376
		[Token(Token = "0x40076A8")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelGoliath m_ModelGoliath;

		// Token: 0x040076A9 RID: 30377
		[Token(Token = "0x40076A9")]
		[FieldOffset(Offset = "0xB8")]
		private List<GoliathFriendItemData> m_FriendInfos;

		// Token: 0x040076AA RID: 30378
		[Token(Token = "0x40076AA")]
		[FieldOffset(Offset = "0xC0")]
		private UIGoliathInviteWndController.EFriendCategory m_CurCategory;

		// Token: 0x040076AB RID: 30379
		[Token(Token = "0x40076AB")]
		[FieldOffset(Offset = "0xC8")]
		private ulong m_GroupID;

		// Token: 0x040076AC RID: 30380
		[Token(Token = "0x40076AC")]
		[FieldOffset(Offset = "0xD0")]
		private string m_CaptainName;

		// Token: 0x040076AD RID: 30381
		[Token(Token = "0x40076AD")]
		[FieldOffset(Offset = "0xD8")]
		private uint m_MemberCnt;

		// Token: 0x040076AE RID: 30382
		[Token(Token = "0x40076AE")]
		[FieldOffset(Offset = "0xE0")]
		private UIRightReigonClickMask m_GuideClickMask;

		// Token: 0x0200137C RID: 4988
		[Token(Token = "0x200137C")]
		private enum EFriendCategory
		{
			// Token: 0x040076B0 RID: 30384
			[Token(Token = "0x40076B0")]
			Game,
			// Token: 0x040076B1 RID: 30385
			[Token(Token = "0x40076B1")]
			Platform
		}
	}
}
