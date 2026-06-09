using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001851 RID: 6225
	[Token(Token = "0x2001851")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3CFC", Offset = "0x10F3CFC")]
	internal class UIGroupInvitationController : UIBaseController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x06007A42 RID: 31298 RVA: 0x000219F0 File Offset: 0x0001FBF0
		[Token(Token = "0x6007A42")]
		[Address(RVA = "0x1A86B44", Offset = "0x1A86B44", VA = "0x7BBC286B44")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007A43 RID: 31299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A43")]
		[Address(RVA = "0x1A86B94", Offset = "0x1A86B94", VA = "0x7BBC286B94", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007A44 RID: 31300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A44")]
		[Address(RVA = "0x1A86FA4", Offset = "0x1A86FA4", VA = "0x7BBC286FA4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007A45 RID: 31301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A45")]
		[Address(RVA = "0x1A870A4", Offset = "0x1A870A4", VA = "0x7BBC2870A4", Slot = "21")]
		public override void Show()
		{
		}

		// Token: 0x06007A46 RID: 31302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A46")]
		[Address(RVA = "0x1A871D4", Offset = "0x1A871D4", VA = "0x7BBC2871D4")]
		private void OnFriendToggleBtnClick()
		{
		}

		// Token: 0x06007A47 RID: 31303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A47")]
		[Address(RVA = "0x1A874B4", Offset = "0x1A874B4", VA = "0x7BBC2874B4")]
		private void OnClanToggleBtnClick()
		{
		}

		// Token: 0x06007A48 RID: 31304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A48")]
		[Address(RVA = "0x1A877D0", Offset = "0x1A877D0", VA = "0x7BBC2877D0")]
		private void SetClanUIData()
		{
		}

		// Token: 0x06007A49 RID: 31305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A49")]
		[Address(RVA = "0x1A87A28", Offset = "0x1A87A28", VA = "0x7BBC287A28")]
		private void PartialUpdateCachedFriendsInfo()
		{
		}

		// Token: 0x06007A4A RID: 31306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A4A")]
		[Address(RVA = "0x1A87DE8", Offset = "0x1A87DE8", VA = "0x7BBC287DE8")]
		private void SetFriendUIData()
		{
		}

		// Token: 0x06007A4B RID: 31307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A4B")]
		[Address(RVA = "0x1A88004", Offset = "0x1A88004", VA = "0x7BBC288004")]
		private void OnSearchBtnClick()
		{
		}

		// Token: 0x06007A4C RID: 31308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A4C")]
		[Address(RVA = "0x1A8824C", Offset = "0x1A8824C", VA = "0x7BBC28824C")]
		private void PartialUpdateCachedClanMembersInfo()
		{
		}

		// Token: 0x06007A4D RID: 31309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A4D")]
		[Address(RVA = "0x1A8863C", Offset = "0x1A8863C", VA = "0x7BBC28863C")]
		private void OnRefreshBtnClick()
		{
		}

		// Token: 0x06007A4E RID: 31310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A4E")]
		[Address(RVA = "0x1A88760", Offset = "0x1A88760", VA = "0x7BBC288760")]
		private void OnMaskClick()
		{
		}

		// Token: 0x06007A4F RID: 31311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A4F")]
		[Address(RVA = "0x1A88770", Offset = "0x1A88770", VA = "0x7BBC288770", Slot = "30")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007A50 RID: 31312 RVA: 0x00021A08 File Offset: 0x0001FC08
		[Token(Token = "0x6007A50")]
		[Address(RVA = "0x1A88828", Offset = "0x1A88828", VA = "0x7BBC288828", Slot = "31")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007A51 RID: 31313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007A51")]
		[Address(RVA = "0x1A8888C", Offset = "0x1A8888C", VA = "0x7BBC28888C", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06007A52 RID: 31314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A52")]
		[Address(RVA = "0x1A88944", Offset = "0x1A88944", VA = "0x7BBC288944", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06007A53 RID: 31315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A53")]
		[Address(RVA = "0x1A88974", Offset = "0x1A88974", VA = "0x7BBC288974")]
		public UIGroupInvitationController()
		{
		}

		// Token: 0x04008F1B RID: 36635
		[Token(Token = "0x4008F1B")]
		[FieldOffset(Offset = "0x58")]
		private UIGroupInvitationView m_View;

		// Token: 0x04008F1C RID: 36636
		[Token(Token = "0x4008F1C")]
		[FieldOffset(Offset = "0x60")]
		private List<FriendAccountInfo> m_CachedFriends;

		// Token: 0x04008F1D RID: 36637
		[Token(Token = "0x4008F1D")]
		[FieldOffset(Offset = "0x68")]
		private List<ClanMember> m_CachedOnlineClanMembers;

		// Token: 0x04008F1E RID: 36638
		[Token(Token = "0x4008F1E")]
		[FieldOffset(Offset = "0x70")]
		private GroupInviteMemberType m_InviteType;

		// Token: 0x02001852 RID: 6226
		[Token(Token = "0x2001852")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F3D34", Offset = "0x10F3D34")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06007A54 RID: 31316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A54")]
			[Address(RVA = "0x1A88244", Offset = "0x1A88244", VA = "0x7BBC288244")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06007A55 RID: 31317 RVA: 0x00021A20 File Offset: 0x0001FC20
			[Token(Token = "0x6007A55")]
			[Address(RVA = "0x1A88A0C", Offset = "0x1A88A0C", VA = "0x7BBC288A0C")]
			internal bool <OnSearchBtnClick>b__0(FriendAccountInfo a)
			{
				return default(bool);
			}

			// Token: 0x06007A56 RID: 31318 RVA: 0x00021A38 File Offset: 0x0001FC38
			[Token(Token = "0x6007A56")]
			[Address(RVA = "0x1A88A58", Offset = "0x1A88A58", VA = "0x7BBC288A58")]
			internal bool <OnSearchBtnClick>b__1(ClanMember a)
			{
				return default(bool);
			}

			// Token: 0x04008F1F RID: 36639
			[Token(Token = "0x4008F1F")]
			[FieldOffset(Offset = "0x10")]
			public string name;
		}
	}
}
