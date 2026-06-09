using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001B4B RID: 6987
	[Token(Token = "0x2001B4B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9A44", Offset = "0x10F9A44")]
	internal class UIRelationshipBreakRequestConfirmController : UIPopupWindowController
	{
		// Token: 0x06009626 RID: 38438 RVA: 0x00027AF8 File Offset: 0x00025CF8
		[Token(Token = "0x6009626")]
		[Address(RVA = "0x1E19C50", Offset = "0x1E19C50", VA = "0x7BBC619C50")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009627 RID: 38439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009627")]
		[Address(RVA = "0x1E19CA0", Offset = "0x1E19CA0", VA = "0x7BBC619CA0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009628 RID: 38440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009628")]
		[Address(RVA = "0x1E19DDC", Offset = "0x1E19DDC", VA = "0x7BBC619DDC")]
		public void SetFriendData(FriendAccountInfo accountInfo, EFriend.RelationType relationType)
		{
		}

		// Token: 0x06009629 RID: 38441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009629")]
		[Address(RVA = "0x1E1A0CC", Offset = "0x1E1A0CC", VA = "0x7BBC61A0CC")]
		private void OnCancelBtnClick()
		{
		}

		// Token: 0x0600962A RID: 38442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600962A")]
		[Address(RVA = "0x1E1A1A4", Offset = "0x1E1A1A4", VA = "0x7BBC61A1A4")]
		private void OnConfirmBtnClick()
		{
		}

		// Token: 0x0600962B RID: 38443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600962B")]
		[Address(RVA = "0x1E1A27C", Offset = "0x1E1A27C", VA = "0x7BBC61A27C")]
		public UIRelationshipBreakRequestConfirmController()
		{
		}

		// Token: 0x04009EEC RID: 40684
		[Token(Token = "0x4009EEC")]
		[FieldOffset(Offset = "0x98")]
		private UIRelationshipBreakRequsetConfirmView m_View;

		// Token: 0x04009EED RID: 40685
		[Token(Token = "0x4009EED")]
		[FieldOffset(Offset = "0xA0")]
		private FriendAccountInfo m_TargetInfo;
	}
}
