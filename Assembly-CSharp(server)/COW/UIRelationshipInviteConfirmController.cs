using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001B4F RID: 6991
	[Token(Token = "0x2001B4F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9B24", Offset = "0x10F9B24")]
	internal class UIRelationshipInviteConfirmController : UIPopupWindowController
	{
		// Token: 0x06009641 RID: 38465 RVA: 0x00027B70 File Offset: 0x00025D70
		[Token(Token = "0x6009641")]
		[Address(RVA = "0x1E1B8AC", Offset = "0x1E1B8AC", VA = "0x7BBC61B8AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009642 RID: 38466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009642")]
		[Address(RVA = "0x1E1B8FC", Offset = "0x1E1B8FC", VA = "0x7BBC61B8FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009643 RID: 38467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009643")]
		[Address(RVA = "0x1E1BA38", Offset = "0x1E1BA38", VA = "0x7BBC61BA38")]
		public void SetFriendData(FriendAccountInfo accountInfo, EFriend.RelationType relationType)
		{
		}

		// Token: 0x06009644 RID: 38468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009644")]
		[Address(RVA = "0x1E1BCEC", Offset = "0x1E1BCEC", VA = "0x7BBC61BCEC")]
		private void OnCancelBtnClick()
		{
		}

		// Token: 0x06009645 RID: 38469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009645")]
		[Address(RVA = "0x1E1BCF4", Offset = "0x1E1BCF4", VA = "0x7BBC61BCF4")]
		private void OnConfirmBtnClick()
		{
		}

		// Token: 0x06009646 RID: 38470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009646")]
		[Address(RVA = "0x1E1BDCC", Offset = "0x1E1BDCC", VA = "0x7BBC61BDCC")]
		public UIRelationshipInviteConfirmController()
		{
		}

		// Token: 0x04009EF5 RID: 40693
		[Token(Token = "0x4009EF5")]
		[FieldOffset(Offset = "0x98")]
		private UIRelationshipInviteConfirmView m_View;

		// Token: 0x04009EF6 RID: 40694
		[Token(Token = "0x4009EF6")]
		[FieldOffset(Offset = "0xA0")]
		private FriendAccountInfo m_TargetInfo;
	}
}
