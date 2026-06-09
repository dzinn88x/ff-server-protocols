using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW
{
	// Token: 0x02001853 RID: 6227
	[Token(Token = "0x2001853")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3D44", Offset = "0x10F3D44")]
	internal class UIGroupInviteItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06007A57 RID: 31319 RVA: 0x00021A50 File Offset: 0x0001FC50
		[Token(Token = "0x17000978")]
		public bool HasGroup
		{
			[Token(Token = "0x6007A57")]
			[Address(RVA = "0x1A89094", Offset = "0x1A89094", VA = "0x7BBC289094")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06007A58 RID: 31320 RVA: 0x00021A68 File Offset: 0x0001FC68
		[Token(Token = "0x17000979")]
		public bool InGame
		{
			[Token(Token = "0x6007A58")]
			[Address(RVA = "0x1A89250", Offset = "0x1A89250", VA = "0x7BBC289250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007A59 RID: 31321 RVA: 0x00021A80 File Offset: 0x0001FC80
		[Token(Token = "0x6007A59")]
		[Address(RVA = "0x1A8926C", Offset = "0x1A8926C", VA = "0x7BBC28926C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007A5A RID: 31322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A5A")]
		[Address(RVA = "0x1A892BC", Offset = "0x1A892BC", VA = "0x7BBC2892BC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007A5B RID: 31323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A5B")]
		[Address(RVA = "0x1A89710", Offset = "0x1A89710", VA = "0x7BBC289710", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007A5C RID: 31324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A5C")]
		[Address(RVA = "0x1A898F0", Offset = "0x1A898F0", VA = "0x7BBC2898F0")]
		public void SetDefaultBtnStatus()
		{
		}

		// Token: 0x06007A5D RID: 31325 RVA: 0x00021A98 File Offset: 0x0001FC98
		[Token(Token = "0x6007A5D")]
		[Address(RVA = "0x1A890B0", Offset = "0x1A890B0", VA = "0x7BBC2890B0")]
		public proto.EPresence.AccountPresence GetPresence()
		{
			return proto.EPresence.AccountPresence.AccountPresence_NONE;
		}

		// Token: 0x06007A5E RID: 31326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A5E")]
		[Address(RVA = "0x1A89AC8", Offset = "0x1A89AC8", VA = "0x7BBC289AC8")]
		private void OnBgBtnClick()
		{
		}

		// Token: 0x06007A5F RID: 31327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A5F")]
		[Address(RVA = "0x1A89D9C", Offset = "0x1A89D9C", VA = "0x7BBC289D9C")]
		public void SetSelected(bool v)
		{
		}

		// Token: 0x06007A60 RID: 31328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A60")]
		[Address(RVA = "0x1A89DA0", Offset = "0x1A89DA0", VA = "0x7BBC289DA0")]
		private void OnGroupCreateSuccess(params object[] param)
		{
		}

		// Token: 0x06007A61 RID: 31329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A61")]
		[Address(RVA = "0x1A89DB4", Offset = "0x1A89DB4", VA = "0x7BBC289DB4")]
		private void InviteFriend()
		{
		}

		// Token: 0x06007A62 RID: 31330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A62")]
		[Address(RVA = "0x1A8A850", Offset = "0x1A8A850", VA = "0x7BBC28A850")]
		private void onBtnReserveClick()
		{
		}

		// Token: 0x06007A63 RID: 31331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A63")]
		[Address(RVA = "0x1A8AB94", Offset = "0x1A8AB94", VA = "0x7BBC28AB94")]
		private void onBtnInviteClick()
		{
		}

		// Token: 0x06007A64 RID: 31332 RVA: 0x00021AB0 File Offset: 0x0001FCB0
		[Token(Token = "0x6007A64")]
		[Address(RVA = "0x1A8B72C", Offset = "0x1A8B72C", VA = "0x7BBC28B72C")]
		private ulong GetAccountID()
		{
			return 0UL;
		}

		// Token: 0x06007A65 RID: 31333 RVA: 0x00021AC8 File Offset: 0x0001FCC8
		[Token(Token = "0x6007A65")]
		[Address(RVA = "0x1A8B7B4", Offset = "0x1A8B7B4", VA = "0x7BBC28B7B4")]
		private ulong GetGroupID()
		{
			return 0UL;
		}

		// Token: 0x06007A66 RID: 31334 RVA: 0x00021AE0 File Offset: 0x0001FCE0
		[Token(Token = "0x6007A66")]
		[Address(RVA = "0x1A8A680", Offset = "0x1A8A680", VA = "0x7BBC28A680")]
		private tcp.EGroup.InviteeType GetInviteeType(GroupInviteMemberType type)
		{
			return tcp.EGroup.InviteeType.InviteeType_NONE;
		}

		// Token: 0x06007A67 RID: 31335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A67")]
		[Address(RVA = "0x1A8B8F8", Offset = "0x1A8B8F8", VA = "0x7BBC28B8F8")]
		public void ClearUIData()
		{
		}

		// Token: 0x06007A68 RID: 31336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A68")]
		[Address(RVA = "0x1A8BB68", Offset = "0x1A8BB68", VA = "0x7BBC28BB68")]
		private void RefreshInviteBtnState()
		{
		}

		// Token: 0x06007A69 RID: 31337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A69")]
		[Address(RVA = "0x1A8BD50", Offset = "0x1A8BD50", VA = "0x7BBC28BD50")]
		private void SetReserveStatus()
		{
		}

		// Token: 0x06007A6A RID: 31338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A6A")]
		[Address(RVA = "0x1A8BEB4", Offset = "0x1A8BEB4", VA = "0x7BBC28BEB4", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06007A6B RID: 31339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A6B")]
		[Address(RVA = "0x1A8C900", Offset = "0x1A8C900", VA = "0x7BBC28C900")]
		private void UpdateCsRankState(uint rank, uint rankpoint)
		{
		}

		// Token: 0x06007A6C RID: 31340 RVA: 0x00021AF8 File Offset: 0x0001FCF8
		[Token(Token = "0x6007A6C")]
		[Address(RVA = "0x1A8C82C", Offset = "0x1A8C82C", VA = "0x7BBC28C82C")]
		private bool ShowInviteOrJoinBtn(proto.EPresence.AccountPresence presence)
		{
			return default(bool);
		}

		// Token: 0x06007A6D RID: 31341 RVA: 0x00021B10 File Offset: 0x0001FD10
		[Token(Token = "0x6007A6D")]
		[Address(RVA = "0x1A8C8E8", Offset = "0x1A8C8E8", VA = "0x7BBC28C8E8")]
		private bool ShowReserveBtn(proto.EPresence.AccountPresence presence)
		{
			return default(bool);
		}

		// Token: 0x06007A6E RID: 31342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A6E")]
		[Address(RVA = "0x1A8CA28", Offset = "0x1A8CA28", VA = "0x7BBC28CA28")]
		private void OnGroupChangeNtf(object[] data)
		{
		}

		// Token: 0x06007A6F RID: 31343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A6F")]
		[Address(RVA = "0x1A8CA40", Offset = "0x1A8CA40", VA = "0x7BBC28CA40")]
		private void OnJoinNtf(object[] data)
		{
		}

		// Token: 0x06007A70 RID: 31344 RVA: 0x00021B28 File Offset: 0x0001FD28
		[Token(Token = "0x6007A70")]
		[Address(RVA = "0x1A8C724", Offset = "0x1A8C724", VA = "0x7BBC28C724")]
		private bool IsRankingMatch()
		{
			return default(bool);
		}

		// Token: 0x06007A71 RID: 31345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A71")]
		[Address(RVA = "0x1A8893C", Offset = "0x1A8893C", VA = "0x7BBC28893C")]
		public void SetInviteUIType(UIGroupInviteItemController.GroupInviteUI ui)
		{
		}

		// Token: 0x06007A72 RID: 31346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A72")]
		[Address(RVA = "0x1A8CBF4", Offset = "0x1A8CBF4", VA = "0x7BBC28CBF4")]
		public void SetInviteMemberType(GroupInviteMemberType ui)
		{
		}

		// Token: 0x06007A73 RID: 31347 RVA: 0x00021B40 File Offset: 0x0001FD40
		[Token(Token = "0x6007A73")]
		[Address(RVA = "0x1A8CBFC", Offset = "0x1A8CBFC", VA = "0x7BBC28CBFC", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007A74 RID: 31348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A74")]
		[Address(RVA = "0x1A8CC3C", Offset = "0x1A8CC3C", VA = "0x7BBC28CC3C", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007A75 RID: 31349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A75")]
		[Address(RVA = "0x1A8CCB4", Offset = "0x1A8CCB4", VA = "0x7BBC28CCB4")]
		public UIGroupInviteItemController()
		{
		}

		// Token: 0x06007A76 RID: 31350 RVA: 0x00021B58 File Offset: 0x0001FD58
		[Token(Token = "0x6007A76")]
		[Address(RVA = "0x1A8CCBC", Offset = "0x1A8CCBC", VA = "0x7BBC28CCBC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11423E4", Offset = "0x11423E4")]
		private bool <GetInviteeType>b__32_0(RecentPlayerInfo temp)
		{
			return default(bool);
		}

		// Token: 0x06007A77 RID: 31351 RVA: 0x00021B70 File Offset: 0x0001FD70
		[Token(Token = "0x6007A77")]
		[Address(RVA = "0x1A8CD20", Offset = "0x1A8CD20", VA = "0x7BBC28CD20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11423F4", Offset = "0x11423F4")]
		private bool <OnJoinNtf>b__41_0(GroupMemberInfo a)
		{
			return default(bool);
		}

		// Token: 0x04008F20 RID: 36640
		[Token(Token = "0x4008F20")]
		[FieldOffset(Offset = "0x70")]
		private UIGroupInviteItemView m_View;

		// Token: 0x04008F21 RID: 36641
		[Token(Token = "0x4008F21")]
		[FieldOffset(Offset = "0x78")]
		public GroupInviteMemberType InviteType;

		// Token: 0x04008F22 RID: 36642
		[Token(Token = "0x4008F22")]
		[FieldOffset(Offset = "0x7C")]
		public int ItemIdex;

		// Token: 0x04008F23 RID: 36643
		[Token(Token = "0x4008F23")]
		[FieldOffset(Offset = "0x80")]
		private object m_Data;

		// Token: 0x04008F24 RID: 36644
		[Token(Token = "0x4008F24")]
		[FieldOffset(Offset = "0x88")]
		private UIGroupInviteItemController.GroupInviteUI m_InviteUI;

		// Token: 0x04008F25 RID: 36645
		[Token(Token = "0x4008F25")]
		[FieldOffset(Offset = "0x90")]
		private ClanMember clanMemberInfo;

		// Token: 0x04008F26 RID: 36646
		[Token(Token = "0x4008F26")]
		[FieldOffset(Offset = "0x98")]
		private FriendAccountInfo friendInfo;

		// Token: 0x04008F27 RID: 36647
		[Token(Token = "0x4008F27")]
		[FieldOffset(Offset = "0xA0")]
		private TeamMemberWithAccountInfo teamMemberInfo;

		// Token: 0x04008F28 RID: 36648
		[Token(Token = "0x4008F28")]
		[FieldOffset(Offset = "0xA8")]
		private ulong m_AccountId;

		// Token: 0x04008F29 RID: 36649
		[Token(Token = "0x4008F29")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelTeamReserve m_ModelTeamReserve;

		// Token: 0x04008F2A RID: 36650
		[Token(Token = "0x4008F2A")]
		[FieldOffset(Offset = "0xB8")]
		private float m_StartTime;

		// Token: 0x04008F2B RID: 36651
		[Token(Token = "0x4008F2B")]
		[FieldOffset(Offset = "0xBC")]
		private bool m_IsCoolingDown;

		// Token: 0x04008F2C RID: 36652
		[Token(Token = "0x4008F2C")]
		[FieldOffset(Offset = "0xC0")]
		private UIBaseProfileInfoController m_BaseProfile;

		// Token: 0x04008F2D RID: 36653
		[Token(Token = "0x4008F2D")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_SentInvite;

		// Token: 0x02001854 RID: 6228
		[Token(Token = "0x2001854")]
		public enum GroupInviteUI
		{
			// Token: 0x04008F2F RID: 36655
			[Token(Token = "0x4008F2F")]
			Group,
			// Token: 0x04008F30 RID: 36656
			[Token(Token = "0x4008F30")]
			Room
		}
	}
}
