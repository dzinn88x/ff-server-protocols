using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020019C0 RID: 6592
	[Token(Token = "0x20019C0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6F4C", Offset = "0x10F6F4C")]
	internal class UIInviteGroupBoxController : UIBaseController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06008741 RID: 34625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009B5")]
		private UIModelGroup m_ModelGroup
		{
			[Token(Token = "0x6008741")]
			[Address(RVA = "0x1922E18", Offset = "0x1922E18", VA = "0x7BBC122E18")]
			get
			{
				return null;
			}
		}

		// Token: 0x06008742 RID: 34626 RVA: 0x00024900 File Offset: 0x00022B00
		[Token(Token = "0x6008742")]
		[Address(RVA = "0x1922EB4", Offset = "0x1922EB4", VA = "0x7BBC122EB4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008743 RID: 34627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008743")]
		[Address(RVA = "0x19230C8", Offset = "0x19230C8", VA = "0x7BBC1230C8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008744 RID: 34628 RVA: 0x00024918 File Offset: 0x00022B18
		[Token(Token = "0x6008744")]
		[Address(RVA = "0x19239DC", Offset = "0x19239DC", VA = "0x7BBC1239DC")]
		private bool ShowInLeft()
		{
			return default(bool);
		}

		// Token: 0x06008745 RID: 34629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008745")]
		[Address(RVA = "0x1923AB0", Offset = "0x1923AB0", VA = "0x7BBC123AB0")]
		public void SetData([Optional] Action onOpen, [Optional] Action onClose)
		{
		}

		// Token: 0x06008746 RID: 34630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008746")]
		[Address(RVA = "0x1923BAC", Offset = "0x1923BAC", VA = "0x7BBC123BAC")]
		public void SetData(Vector3 worldPos, Vector3 scale, [Optional] Action onOpen, [Optional] Action onClose)
		{
		}

		// Token: 0x06008747 RID: 34631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008747")]
		[Address(RVA = "0x1924574", Offset = "0x1924574", VA = "0x7BBC124574", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008748 RID: 34632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008748")]
		[Address(RVA = "0x1924A3C", Offset = "0x1924A3C", VA = "0x7BBC124A3C")]
		public void OnClickAddFriend()
		{
		}

		// Token: 0x06008749 RID: 34633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008749")]
		[Address(RVA = "0x1924A50", Offset = "0x1924A50", VA = "0x7BBC124A50")]
		public void OnClickAddClan()
		{
		}

		// Token: 0x0600874A RID: 34634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600874A")]
		[Address(RVA = "0x1924AEC", Offset = "0x1924AEC", VA = "0x7BBC124AEC")]
		private void OnGroupChangeNtf(params object[] data)
		{
		}

		// Token: 0x0600874B RID: 34635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600874B")]
		[Address(RVA = "0x1924B34", Offset = "0x1924B34", VA = "0x7BBC124B34")]
		private void OnGroupUIEnter(params object[] data)
		{
		}

		// Token: 0x0600874C RID: 34636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600874C")]
		[Address(RVA = "0x1923E28", Offset = "0x1923E28", VA = "0x7BBC123E28")]
		private void SetInviteType()
		{
		}

		// Token: 0x0600874D RID: 34637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600874D")]
		[Address(RVA = "0x19244EC", Offset = "0x19244EC", VA = "0x7BBC1244EC")]
		private void UpdateRefreshState(bool inCD = false)
		{
		}

		// Token: 0x0600874E RID: 34638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600874E")]
		[Address(RVA = "0x1924BD0", Offset = "0x1924BD0", VA = "0x7BBC124BD0")]
		private void OnRefreshBtnClick()
		{
		}

		// Token: 0x0600874F RID: 34639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600874F")]
		[Address(RVA = "0x1924194", Offset = "0x1924194", VA = "0x7BBC124194")]
		private void RefreshFriendsList()
		{
		}

		// Token: 0x06008750 RID: 34640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008750")]
		[Address(RVA = "0x192588C", Offset = "0x192588C", VA = "0x7BBC12588C")]
		private void PartialUpdateCachedClanMembersInfo()
		{
		}

		// Token: 0x06008751 RID: 34641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008751")]
		[Address(RVA = "0x1925C88", Offset = "0x1925C88", VA = "0x7BBC125C88")]
		private void PartialUpdateCachedFriendsInfo()
		{
		}

		// Token: 0x06008752 RID: 34642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008752")]
		[Address(RVA = "0x1926054", Offset = "0x1926054", VA = "0x7BBC126054")]
		private void OnFriendToggleBtnClick()
		{
		}

		// Token: 0x06008753 RID: 34643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008753")]
		[Address(RVA = "0x1926284", Offset = "0x1926284", VA = "0x7BBC126284")]
		private void OnClanToggleBtnClick()
		{
		}

		// Token: 0x06008754 RID: 34644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008754")]
		[Address(RVA = "0x19264C4", Offset = "0x19264C4", VA = "0x7BBC1264C4")]
		private void OnRecentToggleClick()
		{
		}

		// Token: 0x06008755 RID: 34645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008755")]
		[Address(RVA = "0x19265F4", Offset = "0x19265F4", VA = "0x7BBC1265F4")]
		private void SetRecentUIData()
		{
		}

		// Token: 0x06008756 RID: 34646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008756")]
		[Address(RVA = "0x1926714", Offset = "0x1926714", VA = "0x7BBC126714")]
		private void SetClanUIData()
		{
		}

		// Token: 0x06008757 RID: 34647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008757")]
		[Address(RVA = "0x1926878", Offset = "0x1926878", VA = "0x7BBC126878")]
		private void SetFriendUIData()
		{
		}

		// Token: 0x06008758 RID: 34648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008758")]
		[Address(RVA = "0x19269DC", Offset = "0x19269DC", VA = "0x7BBC1269DC")]
		private void SetTeamUIData()
		{
		}

		// Token: 0x06008759 RID: 34649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008759")]
		[Address(RVA = "0x1923F50", Offset = "0x1923F50", VA = "0x7BBC123F50")]
		private void RefreshInviteUI()
		{
		}

		// Token: 0x0600875A RID: 34650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600875A")]
		[Address(RVA = "0x1926B28", Offset = "0x1926B28", VA = "0x7BBC126B28", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x0600875B RID: 34651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600875B")]
		[Address(RVA = "0x1926BD0", Offset = "0x1926BD0", VA = "0x7BBC126BD0")]
		private void onSearchBtnClick()
		{
		}

		// Token: 0x0600875C RID: 34652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600875C")]
		[Address(RVA = "0x192713C", Offset = "0x192713C", VA = "0x7BBC12713C")]
		private void RefreshScrollView()
		{
		}

		// Token: 0x0600875D RID: 34653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600875D")]
		[Address(RVA = "0x1927494", Offset = "0x1927494", VA = "0x7BBC127494")]
		private void OnClickMask(params object[] args)
		{
		}

		// Token: 0x0600875E RID: 34654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600875E")]
		[Address(RVA = "0x1927740", Offset = "0x1927740", VA = "0x7BBC127740")]
		private void OnTweenFinish()
		{
		}

		// Token: 0x0600875F RID: 34655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600875F")]
		[Address(RVA = "0x19277F0", Offset = "0x19277F0", VA = "0x7BBC1277F0")]
		private void OnMatchmakingShow(params object[] args)
		{
		}

		// Token: 0x06008760 RID: 34656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008760")]
		[Address(RVA = "0x19277F4", Offset = "0x19277F4", VA = "0x7BBC1277F4")]
		private void OnSelectGameMode(params object[] args)
		{
		}

		// Token: 0x06008761 RID: 34657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008761")]
		[Address(RVA = "0x1927674", Offset = "0x1927674", VA = "0x7BBC127674")]
		public void OnClickClose()
		{
		}

		// Token: 0x06008762 RID: 34658 RVA: 0x00024930 File Offset: 0x00022B30
		[Token(Token = "0x6008762")]
		[Address(RVA = "0x1927890", Offset = "0x1927890", VA = "0x7BBC127890", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008763 RID: 34659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008763")]
		[Address(RVA = "0x1927970", Offset = "0x1927970", VA = "0x7BBC127970", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008764 RID: 34660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008764")]
		[Address(RVA = "0x1925064", Offset = "0x1925064", VA = "0x7BBC125064")]
		private void UpdateView()
		{
		}

		// Token: 0x06008765 RID: 34661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008765")]
		[Address(RVA = "0x1927270", Offset = "0x1927270", VA = "0x7BBC127270")]
		private void ResetClipPos()
		{
		}

		// Token: 0x06008766 RID: 34662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008766")]
		[Address(RVA = "0x1927AD0", Offset = "0x1927AD0", VA = "0x7BBC127AD0")]
		private void ResetSearchInput()
		{
		}

		// Token: 0x06008767 RID: 34663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008767")]
		[Address(RVA = "0x1927BDC", Offset = "0x1927BDC", VA = "0x7BBC127BDC")]
		private void OnSearchInputGetFocus()
		{
		}

		// Token: 0x06008768 RID: 34664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008768")]
		[Address(RVA = "0x1927C84", Offset = "0x1927C84", VA = "0x7BBC127C84")]
		private void OnSearchInputChange()
		{
		}

		// Token: 0x06008769 RID: 34665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008769")]
		[Address(RVA = "0x1927CE8", Offset = "0x1927CE8", VA = "0x7BBC127CE8")]
		private void OnClickCommunity()
		{
		}

		// Token: 0x0600876A RID: 34666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600876A")]
		[Address(RVA = "0x192816C", Offset = "0x192816C", VA = "0x7BBC12816C")]
		private void OnQuickEnter()
		{
		}

		// Token: 0x0600876B RID: 34667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600876B")]
		[Address(RVA = "0x1928788", Offset = "0x1928788", VA = "0x7BBC128788")]
		private void OnGroupCodeEnter(object data)
		{
		}

		// Token: 0x0600876C RID: 34668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600876C")]
		[Address(RVA = "0x19288DC", Offset = "0x19288DC", VA = "0x7BBC1288DC", Slot = "30")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x0600876D RID: 34669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600876D")]
		[Address(RVA = "0x19289CC", Offset = "0x19289CC", VA = "0x7BBC1289CC", Slot = "31")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x0600876E RID: 34670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600876E")]
		[Address(RVA = "0x19289FC", Offset = "0x19289FC", VA = "0x7BBC1289FC")]
		public UIInviteGroupBoxController()
		{
		}

		// Token: 0x0600876F RID: 34671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600876F")]
		[Address(RVA = "0x1928AA4", Offset = "0x1928AA4", VA = "0x7BBC128AA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11435EC", Offset = "0x11435EC")]
		private void <OnRefreshBtnClick>b__29_0()
		{
		}

		// Token: 0x040095FC RID: 38396
		[Token(Token = "0x40095FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected UIInviteGroupBoxView m_View;

		// Token: 0x040095FD RID: 38397
		[Token(Token = "0x40095FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private uint m_DelayCall;

		// Token: 0x040095FE RID: 38398
		[Token(Token = "0x40095FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string INVITE_FILTER;

		// Token: 0x040095FF RID: 38399
		[Token(Token = "0x40095FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04009600 RID: 38400
		[Token(Token = "0x4009600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GroupInviteMemberType m_InviteType;

		// Token: 0x04009601 RID: 38401
		[Token(Token = "0x4009601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<FriendAccountInfo> m_CachedFriends;

		// Token: 0x04009602 RID: 38402
		[Token(Token = "0x4009602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<ClanMember> m_CachedOnlineClanMembers;

		// Token: 0x04009603 RID: 38403
		[Token(Token = "0x4009603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_HastUpdateRecent;

		// Token: 0x04009604 RID: 38404
		[Token(Token = "0x4009604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ulong m_LastRefreshTime;

		// Token: 0x04009605 RID: 38405
		[Token(Token = "0x4009605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool m_HasSearch;

		// Token: 0x04009606 RID: 38406
		[Token(Token = "0x4009606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private uint m_WinkCall;

		// Token: 0x04009607 RID: 38407
		[Token(Token = "0x4009607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private UICommonCodeInputWindowController m_CodeInputWindow;

		// Token: 0x04009608 RID: 38408
		[Token(Token = "0x4009608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private UIGroupInviteItemController.GroupInviteUI m_InviteUI;

		// Token: 0x04009609 RID: 38409
		[Token(Token = "0x4009609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Action m_OnClose;

		// Token: 0x0400960A RID: 38410
		[Token(Token = "0x400960A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private UIModelGroup __ModelGroup;

		// Token: 0x020019C1 RID: 6593
		[Token(Token = "0x20019C1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F6F84", Offset = "0x10F6F84")]
		private sealed class <>c__DisplayClass42_0
		{
			// Token: 0x06008770 RID: 34672 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008770")]
			[Address(RVA = "0x1927134", Offset = "0x1927134", VA = "0x7BBC127134")]
			public <>c__DisplayClass42_0()
			{
			}

			// Token: 0x06008771 RID: 34673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008771")]
			[Address(RVA = "0x1928AAC", Offset = "0x1928AAC", VA = "0x7BBC128AAC")]
			internal void <onSearchBtnClick>b__0()
			{
			}

			// Token: 0x06008772 RID: 34674 RVA: 0x00024948 File Offset: 0x00022B48
			[Token(Token = "0x6008772")]
			[Address(RVA = "0x1928B14", Offset = "0x1928B14", VA = "0x7BBC128B14")]
			internal bool <onSearchBtnClick>b__1(FriendAccountInfo a)
			{
				return default(bool);
			}

			// Token: 0x06008773 RID: 34675 RVA: 0x00024960 File Offset: 0x00022B60
			[Token(Token = "0x6008773")]
			[Address(RVA = "0x1928B60", Offset = "0x1928B60", VA = "0x7BBC128B60")]
			internal bool <onSearchBtnClick>b__2(ClanMember a)
			{
				return default(bool);
			}

			// Token: 0x06008774 RID: 34676 RVA: 0x00024978 File Offset: 0x00022B78
			[Token(Token = "0x6008774")]
			[Address(RVA = "0x1928BBC", Offset = "0x1928BBC", VA = "0x7BBC128BBC")]
			internal bool <onSearchBtnClick>b__3(TeamMemberWithAccountInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400960B RID: 38411
			[Token(Token = "0x400960B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIInviteGroupBoxController <>4__this;

			// Token: 0x0400960C RID: 38412
			[Token(Token = "0x400960C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;
		}
	}
}
