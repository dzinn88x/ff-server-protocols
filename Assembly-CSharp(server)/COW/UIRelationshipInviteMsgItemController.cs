using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B50 RID: 6992
	[Token(Token = "0x2001B50")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9B5C", Offset = "0x10F9B5C")]
	internal class UIRelationshipInviteMsgItemController : UIEasyListItemController
	{
		// Token: 0x06009647 RID: 38471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009647")]
		[Address(RVA = "0x1E1BEF4", Offset = "0x1E1BEF4", VA = "0x7BBC61BEF4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009648 RID: 38472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009648")]
		[Address(RVA = "0x1E1BFD8", Offset = "0x1E1BFD8", VA = "0x7BBC61BFD8", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06009649 RID: 38473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009649")]
		[Address(RVA = "0x1E1BFE0", Offset = "0x1E1BFE0", VA = "0x7BBC61BFE0")]
		private void ShowMsgDetailWindow()
		{
		}

		// Token: 0x0600964A RID: 38474 RVA: 0x00027B88 File Offset: 0x00025D88
		[Token(Token = "0x600964A")]
		[Address(RVA = "0x1E1D300", Offset = "0x1E1D300", VA = "0x7BBC61D300")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600964B RID: 38475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600964B")]
		[Address(RVA = "0x1E1D350", Offset = "0x1E1D350", VA = "0x7BBC61D350", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600964C RID: 38476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600964C")]
		[Address(RVA = "0x1E1C30C", Offset = "0x1E1C30C", VA = "0x7BBC61C30C")]
		private void RefreshMsgInfo()
		{
		}

		// Token: 0x0600964D RID: 38477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600964D")]
		[Address(RVA = "0x1E1D534", Offset = "0x1E1D534", VA = "0x7BBC61D534")]
		public UIRelationshipInviteMsgItemController()
		{
		}

		// Token: 0x04009EF7 RID: 40695
		[Token(Token = "0x4009EF7")]
		[FieldOffset(Offset = "0x70")]
		private UIRelationshipInviteMsgItemView m_View;

		// Token: 0x04009EF8 RID: 40696
		[Token(Token = "0x4009EF8")]
		[FieldOffset(Offset = "0x78")]
		private RelationshipMessageInfo m_info;

		// Token: 0x04009EF9 RID: 40697
		[Token(Token = "0x4009EF9")]
		[FieldOffset(Offset = "0x80")]
		private UIBaseProfileInfoController m_baseInfo;
	}
}
