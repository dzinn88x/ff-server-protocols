using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001B4A RID: 6986
	[Token(Token = "0x2001B4A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9A0C", Offset = "0x10F9A0C")]
	internal class UIRelationshipBreakConfirmController : UIPopupWindowController
	{
		// Token: 0x06009620 RID: 38432 RVA: 0x00027AE0 File Offset: 0x00025CE0
		[Token(Token = "0x6009620")]
		[Address(RVA = "0x1E1960C", Offset = "0x1E1960C", VA = "0x7BBC61960C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009621 RID: 38433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009621")]
		[Address(RVA = "0x1E1965C", Offset = "0x1E1965C", VA = "0x7BBC61965C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009622 RID: 38434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009622")]
		[Address(RVA = "0x1E19798", Offset = "0x1E19798", VA = "0x7BBC619798")]
		public void SetFriendData(FriendAccountInfo accountInfo, ulong friendID, EFriend.RelationType relationType)
		{
		}

		// Token: 0x06009623 RID: 38435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009623")]
		[Address(RVA = "0x1E19A54", Offset = "0x1E19A54", VA = "0x7BBC619A54")]
		private void OnCancelBtnClick()
		{
		}

		// Token: 0x06009624 RID: 38436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009624")]
		[Address(RVA = "0x1E19A5C", Offset = "0x1E19A5C", VA = "0x7BBC619A5C")]
		private void OnConfirmBtnClick()
		{
		}

		// Token: 0x06009625 RID: 38437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009625")]
		[Address(RVA = "0x1E19B20", Offset = "0x1E19B20", VA = "0x7BBC619B20")]
		public UIRelationshipBreakConfirmController()
		{
		}

		// Token: 0x04009EE9 RID: 40681
		[Token(Token = "0x4009EE9")]
		[FieldOffset(Offset = "0x98")]
		private UIRelationshipBreakConfirmView m_View;

		// Token: 0x04009EEA RID: 40682
		[Token(Token = "0x4009EEA")]
		[FieldOffset(Offset = "0xA0")]
		private FriendAccountInfo m_TargetInfo;

		// Token: 0x04009EEB RID: 40683
		[Token(Token = "0x4009EEB")]
		[FieldOffset(Offset = "0xA8")]
		private ulong m_FriendID;
	}
}
