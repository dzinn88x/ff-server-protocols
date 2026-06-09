using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001B4D RID: 6989
	[Token(Token = "0x2001B4D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9AB4", Offset = "0x10F9AB4")]
	public class UIRelationshipExtraPreviewWndController : UIPopupWindowController
	{
		// Token: 0x06009635 RID: 38453 RVA: 0x00027B40 File Offset: 0x00025D40
		[Token(Token = "0x6009635")]
		[Address(RVA = "0x1E1AD90", Offset = "0x1E1AD90", VA = "0x7BBC61AD90")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009636 RID: 38454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009636")]
		[Address(RVA = "0x1E1ADE0", Offset = "0x1E1ADE0", VA = "0x7BBC61ADE0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009637 RID: 38455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009637")]
		[Address(RVA = "0x1E1AEC4", Offset = "0x1E1AEC4", VA = "0x7BBC61AEC4")]
		public void SetViewData(IntimacyAwardDesc desc)
		{
		}

		// Token: 0x06009638 RID: 38456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009638")]
		[Address(RVA = "0x1E1B248", Offset = "0x1E1B248", VA = "0x7BBC61B248")]
		private void OnOKClick()
		{
		}

		// Token: 0x06009639 RID: 38457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009639")]
		[Address(RVA = "0x1E1B250", Offset = "0x1E1B250", VA = "0x7BBC61B250", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600963A RID: 38458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600963A")]
		[Address(RVA = "0x1E1B258", Offset = "0x1E1B258", VA = "0x7BBC61B258", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600963B RID: 38459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600963B")]
		[Address(RVA = "0x1E1B260", Offset = "0x1E1B260", VA = "0x7BBC61B260")]
		public UIRelationshipExtraPreviewWndController()
		{
		}

		// Token: 0x04009EF1 RID: 40689
		[Token(Token = "0x4009EF1")]
		[FieldOffset(Offset = "0x98")]
		private UIRelationshipExtraPreviewWndView m_View;
	}
}
