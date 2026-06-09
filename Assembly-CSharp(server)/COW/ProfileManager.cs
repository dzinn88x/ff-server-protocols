using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C63 RID: 7267
	[Token(Token = "0x2001C63")]
	public class ProfileManager : SingletonModule<ProfileManager>, IUIModelDataChangeObserver
	{
		// Token: 0x06009E59 RID: 40537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E59")]
		[Address(RVA = "0x174E4DC", Offset = "0x174E4DC", VA = "0x7BBBF4E4DC", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06009E5A RID: 40538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E5A")]
		[Address(RVA = "0x174E5BC", Offset = "0x174E5BC", VA = "0x7BBBF4E5BC", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06009E5B RID: 40539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009E5B")]
		[Address(RVA = "0x174E758", Offset = "0x174E758", VA = "0x7BBBF4E758")]
		public BaseProfileInfo GetUserProfileInfo(ulong id)
		{
			return null;
		}

		// Token: 0x06009E5C RID: 40540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E5C")]
		[Address(RVA = "0x174E800", Offset = "0x174E800", VA = "0x7BBBF4E800")]
		public void AddUserProfileInfo(List<ClanMember> m_ClanMembers)
		{
		}

		// Token: 0x06009E5D RID: 40541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E5D")]
		[Address(RVA = "0x174E914", Offset = "0x174E914", VA = "0x7BBBF4E914")]
		public void AddUserProfileInfo(ulong id, BaseProfileInfo profileinfo)
		{
		}

		// Token: 0x06009E5E RID: 40542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E5E")]
		[Address(RVA = "0x174E98C", Offset = "0x174E98C", VA = "0x7BBBF4E98C", Slot = "10")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009E5F RID: 40543 RVA: 0x000296A0 File Offset: 0x000278A0
		[Token(Token = "0x6009E5F")]
		[Address(RVA = "0x174F154", Offset = "0x174F154", VA = "0x7BBBF4F154", Slot = "11")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009E60 RID: 40544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E60")]
		[Address(RVA = "0x174F1F0", Offset = "0x174F1F0", VA = "0x7BBBF4F1F0")]
		public ProfileManager()
		{
		}

		// Token: 0x0400A49B RID: 42139
		[Token(Token = "0x400A49B")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<ulong, BaseProfileInfo> m_ProfileInfoDic;

		// Token: 0x0400A49C RID: 42140
		[Token(Token = "0x400A49C")]
		[FieldOffset(Offset = "0x20")]
		private UIModelFriends m_FriendModel;

		// Token: 0x0400A49D RID: 42141
		[Token(Token = "0x400A49D")]
		[FieldOffset(Offset = "0x28")]
		private UIModelClan m_ClanModel;

		// Token: 0x0400A49E RID: 42142
		[Token(Token = "0x400A49E")]
		[FieldOffset(Offset = "0x30")]
		private UIModelGroup m_GroupModel;

		// Token: 0x0400A49F RID: 42143
		[Token(Token = "0x400A49F")]
		[FieldOffset(Offset = "0x38")]
		private UIModelCustomRoom m_CustomRoomModel;
	}
}
