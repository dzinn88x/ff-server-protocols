using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B54 RID: 6996
	[Token(Token = "0x2001B54")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9C3C", Offset = "0x10F9C3C")]
	internal class UIRelationshipMsgDetailWndController : UIPopupWindowController
	{
		// Token: 0x06009662 RID: 38498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009662")]
		[Address(RVA = "0x1E1E75C", Offset = "0x1E1E75C", VA = "0x7BBC61E75C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009663 RID: 38499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009663")]
		[Address(RVA = "0x1E1E948", Offset = "0x1E1E948", VA = "0x7BBC61E948", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06009664 RID: 38500 RVA: 0x00027C00 File Offset: 0x00025E00
		[Token(Token = "0x6009664")]
		[Address(RVA = "0x1E1E950", Offset = "0x1E1E950", VA = "0x7BBC61E950")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009665 RID: 38501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009665")]
		[Address(RVA = "0x1E1CFD0", Offset = "0x1E1CFD0", VA = "0x7BBC61CFD0")]
		public void SetUIData(RelationshipMessageInfo reInfo, string CDNUrl)
		{
		}

		// Token: 0x06009666 RID: 38502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009666")]
		[Address(RVA = "0x1E1E9A0", Offset = "0x1E1E9A0", VA = "0x7BBC61E9A0")]
		public void SetUIData(RelationshipInfo reInfo, string CDNUrl)
		{
		}

		// Token: 0x06009667 RID: 38503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009667")]
		[Address(RVA = "0x1E1EE14", Offset = "0x1E1EE14", VA = "0x7BBC61EE14")]
		private void OnClickClose()
		{
		}

		// Token: 0x06009668 RID: 38504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009668")]
		[Address(RVA = "0x1E1EE1C", Offset = "0x1E1EE1C", VA = "0x7BBC61EE1C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06009669 RID: 38505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009669")]
		[Address(RVA = "0x1E1EEB8", Offset = "0x1E1EEB8", VA = "0x7BBC61EEB8")]
		private void OnClickConfirm()
		{
		}

		// Token: 0x0600966A RID: 38506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600966A")]
		[Address(RVA = "0x1E1EF6C", Offset = "0x1E1EF6C", VA = "0x7BBC61EF6C")]
		private void OnClickRefuce()
		{
		}

		// Token: 0x0600966B RID: 38507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600966B")]
		[Address(RVA = "0x1E1F020", Offset = "0x1E1F020", VA = "0x7BBC61F020")]
		public UIRelationshipMsgDetailWndController()
		{
		}

		// Token: 0x04009EFD RID: 40701
		[Token(Token = "0x4009EFD")]
		[FieldOffset(Offset = "0x98")]
		private UIRelationshipMsgDetailWndView m_View;

		// Token: 0x04009EFE RID: 40702
		[Token(Token = "0x4009EFE")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelRelationShip modelRelationShip;

		// Token: 0x04009EFF RID: 40703
		[Token(Token = "0x4009EFF")]
		[FieldOffset(Offset = "0xA8")]
		private RelationshipMessageInfo m_RelationMsgInfo;

		// Token: 0x04009F00 RID: 40704
		[Token(Token = "0x4009F00")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_delayCall;
	}
}
