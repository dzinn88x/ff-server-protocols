using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001597 RID: 5527
	[Token(Token = "0x2001597")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EED34", Offset = "0x10EED34")]
	public class UIMallGiftController : UIBaseController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x060060ED RID: 24813 RVA: 0x0001BF60 File Offset: 0x0001A160
		[Token(Token = "0x60060ED")]
		[Address(RVA = "0x1C6CD9C", Offset = "0x1C6CD9C", VA = "0x7BBC46CD9C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060060EE RID: 24814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060EE")]
		[Address(RVA = "0x1C6CDEC", Offset = "0x1C6CDEC", VA = "0x7BBC46CDEC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060060EF RID: 24815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060EF")]
		[Address(RVA = "0x1C6D744", Offset = "0x1C6D744", VA = "0x7BBC46D744")]
		private void CloseReceiverListPanel(params object[] data)
		{
		}

		// Token: 0x060060F0 RID: 24816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F0")]
		[Address(RVA = "0x1C6D8C8", Offset = "0x1C6D8C8", VA = "0x7BBC46D8C8")]
		public void SetGiftViewData(EGiftStore_BuddyType type, GiftItem giftItem)
		{
		}

		// Token: 0x060060F1 RID: 24817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F1")]
		[Address(RVA = "0x1C6D670", Offset = "0x1C6D670", VA = "0x7BBC46D670")]
		private void InitAllSelectBtnState()
		{
		}

		// Token: 0x060060F2 RID: 24818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F2")]
		[Address(RVA = "0x1C6DDC8", Offset = "0x1C6DDC8", VA = "0x7BBC46DDC8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060060F3 RID: 24819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F3")]
		[Address(RVA = "0x1C6DF48", Offset = "0x1C6DF48", VA = "0x7BBC46DF48")]
		private void OnFriendSelected(params object[] data)
		{
		}

		// Token: 0x060060F4 RID: 24820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F4")]
		[Address(RVA = "0x1C6E078", Offset = "0x1C6E078", VA = "0x7BBC46E078")]
		private void RefreshFriendList(FriendInfo info, bool isSelected)
		{
		}

		// Token: 0x060060F5 RID: 24821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F5")]
		[Address(RVA = "0x1C6DD60", Offset = "0x1C6DD60", VA = "0x7BBC46DD60")]
		private void GetFriendDataList()
		{
		}

		// Token: 0x060060F6 RID: 24822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F6")]
		[Address(RVA = "0x1C6E768", Offset = "0x1C6E768", VA = "0x7BBC46E768")]
		public void OnMallBackClick()
		{
		}

		// Token: 0x060060F7 RID: 24823 RVA: 0x0001BF78 File Offset: 0x0001A178
		[Token(Token = "0x60060F7")]
		[Address(RVA = "0x1C6E6A4", Offset = "0x1C6E6A4", VA = "0x7BBC46E6A4")]
		private int GetSelectNum()
		{
			return 0;
		}

		// Token: 0x060060F8 RID: 24824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F8")]
		[Address(RVA = "0x1C6DAEC", Offset = "0x1C6DAEC", VA = "0x7BBC46DAEC")]
		private void RefreshSelectNum()
		{
		}

		// Token: 0x060060F9 RID: 24825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060F9")]
		[Address(RVA = "0x1C6EA70", Offset = "0x1C6EA70", VA = "0x7BBC46EA70", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060060FA RID: 24826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FA")]
		[Address(RVA = "0x1C6EB7C", Offset = "0x1C6EB7C", VA = "0x7BBC46EB7C", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060060FB RID: 24827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FB")]
		[Address(RVA = "0x1C6EBAC", Offset = "0x1C6EBAC", VA = "0x7BBC46EBAC")]
		private void OnFriendBtnClick()
		{
		}

		// Token: 0x060060FC RID: 24828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FC")]
		[Address(RVA = "0x1C6EE38", Offset = "0x1C6EE38", VA = "0x7BBC46EE38")]
		private void OnClanFriendBtnClick()
		{
		}

		// Token: 0x060060FD RID: 24829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FD")]
		[Address(RVA = "0x1C6EBB8", Offset = "0x1C6EBB8", VA = "0x7BBC46EBB8")]
		private void RefreshFriendListView()
		{
		}

		// Token: 0x060060FE RID: 24830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FE")]
		private void RefreshViewData<DataType>(List<DataType> dataList, bool needResort = true)
		{
		}

		// Token: 0x060060FF RID: 24831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060FF")]
		[Address(RVA = "0x1C6EE44", Offset = "0x1C6EE44", VA = "0x7BBC46EE44")]
		private void OnNextBtnClick()
		{
		}

		// Token: 0x06006100 RID: 24832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006100")]
		[Address(RVA = "0x1C6F0E4", Offset = "0x1C6F0E4", VA = "0x7BBC46F0E4")]
		private void SetGivePanelData()
		{
		}

		// Token: 0x06006101 RID: 24833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006101")]
		[Address(RVA = "0x1C6F27C", Offset = "0x1C6F27C", VA = "0x7BBC46F27C")]
		private void SetGiveFriendsName()
		{
		}

		// Token: 0x06006102 RID: 24834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006102")]
		[Address(RVA = "0x1C6F6E0", Offset = "0x1C6F6E0", VA = "0x7BBC46F6E0")]
		private void RefreshReceiverCallsign(int i)
		{
		}

		// Token: 0x06006103 RID: 24835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006103")]
		[Address(RVA = "0x1C6E5C8", Offset = "0x1C6E5C8", VA = "0x7BBC46E5C8")]
		private void SetAllSelectState(bool state)
		{
		}

		// Token: 0x06006104 RID: 24836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006104")]
		[Address(RVA = "0x1C6F9A4", Offset = "0x1C6F9A4", VA = "0x7BBC46F9A4")]
		private void OnAllSelectBtnClick()
		{
		}

		// Token: 0x06006105 RID: 24837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006105")]
		[Address(RVA = "0x1C6FB38", Offset = "0x1C6FB38", VA = "0x7BBC46FB38")]
		private void OnNameBtnClick()
		{
		}

		// Token: 0x06006106 RID: 24838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006106")]
		[Address(RVA = "0x1C6FC2C", Offset = "0x1C6FC2C", VA = "0x7BBC46FC2C")]
		private void OnSendBtnClick()
		{
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x0001BF90 File Offset: 0x0001A190
		[Token(Token = "0x6006107")]
		[Address(RVA = "0x1C7027C", Offset = "0x1C7027C", VA = "0x7BBC47027C", Slot = "31")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006108 RID: 24840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006108")]
		[Address(RVA = "0x1C70300", Offset = "0x1C70300", VA = "0x7BBC470300", Slot = "30")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006109 RID: 24841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006109")]
		[Address(RVA = "0x1C70A48", Offset = "0x1C70A48", VA = "0x7BBC470A48")]
		private void CreatFriendInfo(FriendInfo friendInfo, EGiftStore_BuddyType buddyType, List<FriendInfo> list)
		{
		}

		// Token: 0x0600610A RID: 24842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600610A")]
		[Address(RVA = "0x1C70D44", Offset = "0x1C70D44", VA = "0x7BBC470D44")]
		private void CheckCondition(FriendInfo info)
		{
		}

		// Token: 0x0600610B RID: 24843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600610B")]
		[Address(RVA = "0x1C712FC", Offset = "0x1C712FC", VA = "0x7BBC4712FC")]
		private void OnSearchBtnClick()
		{
		}

		// Token: 0x0600610C RID: 24844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600610C")]
		[Address(RVA = "0x1C714A4", Offset = "0x1C714A4", VA = "0x7BBC4714A4")]
		private void OnRuleBtnClick()
		{
		}

		// Token: 0x0600610D RID: 24845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600610D")]
		[Address(RVA = "0x1C71BA0", Offset = "0x1C71BA0", VA = "0x7BBC471BA0", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600610E RID: 24846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600610E")]
		[Address(RVA = "0x1C71F54", Offset = "0x1C71F54", VA = "0x7BBC471F54")]
		public UIMallGiftController()
		{
		}

		// Token: 0x040080E4 RID: 32996
		[Token(Token = "0x40080E4")]
		[FieldOffset(Offset = "0x58")]
		private UIMallGiftView m_View;

		// Token: 0x040080E5 RID: 32997
		[Token(Token = "0x40080E5")]
		[FieldOffset(Offset = "0x60")]
		private UIModelClan m_ModelClan;

		// Token: 0x040080E6 RID: 32998
		[Token(Token = "0x40080E6")]
		[FieldOffset(Offset = "0x68")]
		private UIModelFriends m_ModelFriends;

		// Token: 0x040080E7 RID: 32999
		[Token(Token = "0x40080E7")]
		[FieldOffset(Offset = "0x70")]
		private UIModelGift m_ModelGift;

		// Token: 0x040080E8 RID: 33000
		[Token(Token = "0x40080E8")]
		[FieldOffset(Offset = "0x78")]
		private UIModelUser m_ModelUser;

		// Token: 0x040080E9 RID: 33001
		[Token(Token = "0x40080E9")]
		[FieldOffset(Offset = "0x80")]
		private List<FriendInfo> m_FriendsList;

		// Token: 0x040080EA RID: 33002
		[Token(Token = "0x40080EA")]
		[FieldOffset(Offset = "0x88")]
		private List<FriendInfo> m_ClanFriendsList;

		// Token: 0x040080EB RID: 33003
		[Token(Token = "0x40080EB")]
		[FieldOffset(Offset = "0x90")]
		private List<FriendInfo> m_ReceiversList;

		// Token: 0x040080EC RID: 33004
		[Token(Token = "0x40080EC")]
		[FieldOffset(Offset = "0x98")]
		private List<UIMallGiftReceiverCallsignController> m_ReceiversCallsignList;

		// Token: 0x040080ED RID: 33005
		[Token(Token = "0x40080ED")]
		[FieldOffset(Offset = "0xA0")]
		private EGiftState m_GiftState;

		// Token: 0x040080EE RID: 33006
		[Token(Token = "0x40080EE")]
		[FieldOffset(Offset = "0xA4")]
		private EGiftStore_BuddyType m_FriendType;

		// Token: 0x040080EF RID: 33007
		[Token(Token = "0x40080EF")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<EGiftStore_BuddyType, bool> m_AllSelectStateDict;

		// Token: 0x040080F0 RID: 33008
		[Token(Token = "0x40080F0")]
		[FieldOffset(Offset = "0xB0")]
		private GiftItem m_SelectedGift;

		// Token: 0x040080F1 RID: 33009
		[Token(Token = "0x40080F1")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_IsSelectMax;

		// Token: 0x040080F2 RID: 33010
		[Token(Token = "0x40080F2")]
		[FieldOffset(Offset = "0xC0")]
		private string m_ReceiversName;

		// Token: 0x040080F3 RID: 33011
		[Token(Token = "0x40080F3")]
		[FieldOffset(Offset = "0xC8")]
		private int m_GetFriendNtfState;

		// Token: 0x040080F4 RID: 33012
		[Token(Token = "0x40080F4")]
		[FieldOffset(Offset = "0xCC")]
		private int m_GetClanFriendNtfState;

		// Token: 0x040080F5 RID: 33013
		[Token(Token = "0x40080F5")]
		private const int GETFRIENDSLIST = 1;

		// Token: 0x040080F6 RID: 33014
		[Token(Token = "0x40080F6")]
		private const int GETFRIENDSPRESENCE = 2;

		// Token: 0x040080F7 RID: 33015
		[Token(Token = "0x40080F7")]
		[FieldOffset(Offset = "0xD0")]
		private EGiftStore_BuddyType m_LobbySelectFriendType;

		// Token: 0x02001598 RID: 5528
		[Token(Token = "0x2001598")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EED6C", Offset = "0x10EED6C")]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x0600610F RID: 24847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600610F")]
			[Address(RVA = "0x1C6E69C", Offset = "0x1C6E69C", VA = "0x7BBC46E69C")]
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x06006110 RID: 24848 RVA: 0x0001BFA8 File Offset: 0x0001A1A8
			[Token(Token = "0x6006110")]
			[Address(RVA = "0x1C720CC", Offset = "0x1C720CC", VA = "0x7BBC4720CC")]
			internal bool <RefreshFriendList>b__0(FriendInfo temp)
			{
				return default(bool);
			}

			// Token: 0x040080F8 RID: 33016
			[Token(Token = "0x40080F8")]
			[FieldOffset(Offset = "0x10")]
			public FriendInfo info;
		}

		// Token: 0x02001599 RID: 5529
		[Token(Token = "0x2001599")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EED7C", Offset = "0x10EED7C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006112 RID: 24850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006112")]
			[Address(RVA = "0x1C72098", Offset = "0x1C72098", VA = "0x7BBC472098")]
			public <>c()
			{
			}

			// Token: 0x06006113 RID: 24851 RVA: 0x0001BFC0 File Offset: 0x0001A1C0
			[Token(Token = "0x6006113")]
			[Address(RVA = "0x1C720A0", Offset = "0x1C720A0", VA = "0x7BBC4720A0")]
			internal ulong <OnSendBtnClick>b__45_0(FriendInfo a)
			{
				return 0UL;
			}

			// Token: 0x040080F9 RID: 33017
			[Token(Token = "0x40080F9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIMallGiftController.<>c <>9;

			// Token: 0x040080FA RID: 33018
			[Token(Token = "0x40080FA")]
			[FieldOffset(Offset = "0x8")]
			public static Func<FriendInfo, ulong> <>9__45_0;
		}

		// Token: 0x0200159A RID: 5530
		[Token(Token = "0x200159A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EED8C", Offset = "0x10EED8C")]
		private sealed class <>c__DisplayClass48_0
		{
			// Token: 0x06006114 RID: 24852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006114")]
			[Address(RVA = "0x1C70D3C", Offset = "0x1C70D3C", VA = "0x7BBC470D3C")]
			public <>c__DisplayClass48_0()
			{
			}

			// Token: 0x06006115 RID: 24853 RVA: 0x0001BFD8 File Offset: 0x0001A1D8
			[Token(Token = "0x6006115")]
			[Address(RVA = "0x1C72134", Offset = "0x1C72134", VA = "0x7BBC472134")]
			internal bool <CreatFriendInfo>b__0(FriendInfo temp)
			{
				return default(bool);
			}

			// Token: 0x040080FB RID: 33019
			[Token(Token = "0x40080FB")]
			[FieldOffset(Offset = "0x10")]
			public EGiftStore_BuddyType buddyType;

			// Token: 0x040080FC RID: 33020
			[Token(Token = "0x40080FC")]
			[FieldOffset(Offset = "0x18")]
			public FriendInfo friendInfo;
		}

		// Token: 0x0200159B RID: 5531
		[Token(Token = "0x200159B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EED9C", Offset = "0x10EED9C")]
		private sealed class <>c__DisplayClass50_0
		{
			// Token: 0x06006116 RID: 24854 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006116")]
			[Address(RVA = "0x1C7149C", Offset = "0x1C7149C", VA = "0x7BBC47149C")]
			public <>c__DisplayClass50_0()
			{
			}

			// Token: 0x06006117 RID: 24855 RVA: 0x0001BFF0 File Offset: 0x0001A1F0
			[Token(Token = "0x6006117")]
			[Address(RVA = "0x1C72198", Offset = "0x1C72198", VA = "0x7BBC472198")]
			internal bool <OnSearchBtnClick>b__0(FriendInfo a)
			{
				return default(bool);
			}

			// Token: 0x040080FD RID: 33021
			[Token(Token = "0x40080FD")]
			[FieldOffset(Offset = "0x10")]
			public string key;
		}
	}
}
