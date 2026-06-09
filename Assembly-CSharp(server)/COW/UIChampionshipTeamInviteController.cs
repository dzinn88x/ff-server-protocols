using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001494 RID: 5268
	[Token(Token = "0x2001494")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED234", Offset = "0x10ED234")]
	public class UIChampionshipTeamInviteController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x06005922 RID: 22818 RVA: 0x0001A388 File Offset: 0x00018588
		[Token(Token = "0x6005922")]
		[Address(RVA = "0x1ED10AC", Offset = "0x1ED10AC", VA = "0x7BBC6D10AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005923 RID: 22819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005923")]
		[Address(RVA = "0x1ED10FC", Offset = "0x1ED10FC", VA = "0x7BBC6D10FC", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005924 RID: 22820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005924")]
		[Address(RVA = "0x1ED112C", Offset = "0x1ED112C", VA = "0x7BBC6D112C", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005925 RID: 22821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005925")]
		[Address(RVA = "0x1ED11C0", Offset = "0x1ED11C0", VA = "0x7BBC6D11C0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005926")]
		[Address(RVA = "0x1ED1404", Offset = "0x1ED1404", VA = "0x7BBC6D1404", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x0001A3A0 File Offset: 0x000185A0
		[Token(Token = "0x6005927")]
		[Address(RVA = "0x1ED1464", Offset = "0x1ED1464", VA = "0x7BBC6D1464")]
		public UIChampionshipTeamInviteController.InviteState GetInviteState(ulong id)
		{
			return UIChampionshipTeamInviteController.InviteState.Normal;
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005928")]
		[Address(RVA = "0x1ED14EC", Offset = "0x1ED14EC", VA = "0x7BBC6D14EC")]
		public void SetInviteState(ulong id, UIChampionshipTeamInviteController.InviteState state)
		{
		}

		// Token: 0x06005929 RID: 22825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005929")]
		[Address(RVA = "0x1ED1564", Offset = "0x1ED1564", VA = "0x7BBC6D1564")]
		private void Search()
		{
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600592A")]
		[Address(RVA = "0x1ED1794", Offset = "0x1ED1794", VA = "0x7BBC6D1794")]
		public void ShowSearchResultView()
		{
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600592B")]
		[Address(RVA = "0x1ED1928", Offset = "0x1ED1928", VA = "0x7BBC6D1928")]
		private void UpdateFriendListView()
		{
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600592C")]
		[Address(RVA = "0x1ED1844", Offset = "0x1ED1844", VA = "0x7BBC6D1844")]
		private void RefreshEasyListView(List<FriendAccountInfo> data)
		{
		}

		// Token: 0x0600592D RID: 22829 RVA: 0x0001A3B8 File Offset: 0x000185B8
		[Token(Token = "0x600592D")]
		[Address(RVA = "0x1ED1B10", Offset = "0x1ED1B10", VA = "0x7BBC6D1B10", Slot = "43")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600592E RID: 22830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600592E")]
		[Address(RVA = "0x1ED1BB8", Offset = "0x1ED1BB8", VA = "0x7BBC6D1BB8", Slot = "42")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600592F RID: 22831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600592F")]
		[Address(RVA = "0x1ED1CD8", Offset = "0x1ED1CD8", VA = "0x7BBC6D1CD8")]
		public UIChampionshipTeamInviteController()
		{
		}

		// Token: 0x06005930 RID: 22832 RVA: 0x0001A3D0 File Offset: 0x000185D0
		[Token(Token = "0x6005930")]
		[Address(RVA = "0x1ED1D48", Offset = "0x1ED1D48", VA = "0x7BBC6D1D48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F4B8", Offset = "0x113F4B8")]
		private bool <UpdateFriendListView>b__16_0(FriendAccountInfo e)
		{
			return default(bool);
		}

		// Token: 0x04007CC3 RID: 31939
		[Token(Token = "0x4007CC3")]
		[FieldOffset(Offset = "0x98")]
		private UIChampionshipTeamInviteView m_View;

		// Token: 0x04007CC4 RID: 31940
		[Token(Token = "0x4007CC4")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelFriends m_ModelFriends;

		// Token: 0x04007CC5 RID: 31941
		[Token(Token = "0x4007CC5")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<ulong, UIChampionshipTeamInviteController.InviteState> m_InviteStates;

		// Token: 0x04007CC6 RID: 31942
		[Token(Token = "0x4007CC6")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007CC7 RID: 31943
		[Token(Token = "0x4007CC7")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_GettedFriendsData;

		// Token: 0x04007CC8 RID: 31944
		[Token(Token = "0x4007CC8")]
		[FieldOffset(Offset = "0xB9")]
		private bool m_GettedInvitedListData;

		// Token: 0x02001495 RID: 5269
		[Token(Token = "0x2001495")]
		public enum InviteState
		{
			// Token: 0x04007CCA RID: 31946
			[Token(Token = "0x4007CCA")]
			Normal,
			// Token: 0x04007CCB RID: 31947
			[Token(Token = "0x4007CCB")]
			Inviting,
			// Token: 0x04007CCC RID: 31948
			[Token(Token = "0x4007CCC")]
			Invited
		}

		// Token: 0x02001496 RID: 5270
		[Token(Token = "0x2001496")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ED26C", Offset = "0x10ED26C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005932 RID: 22834 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005932")]
			[Address(RVA = "0x1ED1DF0", Offset = "0x1ED1DF0", VA = "0x7BBC6D1DF0")]
			public <>c()
			{
			}

			// Token: 0x06005933 RID: 22835 RVA: 0x0001A3E8 File Offset: 0x000185E8
			[Token(Token = "0x6005933")]
			[Address(RVA = "0x1ED1DF8", Offset = "0x1ED1DF8", VA = "0x7BBC6D1DF8")]
			internal int <UpdateFriendListView>b__16_1(FriendAccountInfo e, FriendAccountInfo o)
			{
				return 0;
			}

			// Token: 0x04007CCD RID: 31949
			[Token(Token = "0x4007CCD")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIChampionshipTeamInviteController.<>c <>9;

			// Token: 0x04007CCE RID: 31950
			[Token(Token = "0x4007CCE")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<FriendAccountInfo> <>9__16_1;
		}
	}
}
