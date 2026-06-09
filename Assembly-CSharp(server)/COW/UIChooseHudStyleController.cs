using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02002098 RID: 8344
	[Token(Token = "0x2002098")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FDAB4", Offset = "0x10FDAB4")]
	public class UIChooseHudStyleController : UIPopupWindowController
	{
		// Token: 0x0600BB81 RID: 48001 RVA: 0x00035118 File Offset: 0x00033318
		[Token(Token = "0x600BB81")]
		[Address(RVA = "0x1BF520C", Offset = "0x1BF520C", VA = "0x7BBC3F520C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600BB82 RID: 48002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB82")]
		[Address(RVA = "0x1BF525C", Offset = "0x1BF525C", VA = "0x7BBC3F525C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600BB83 RID: 48003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB83")]
		[Address(RVA = "0x1BF5398", Offset = "0x1BF5398", VA = "0x7BBC3F5398")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x0600BB84 RID: 48004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB84")]
		[Address(RVA = "0x1BF53A0", Offset = "0x1BF53A0", VA = "0x7BBC3F53A0")]
		public void SetCallback(Action callback)
		{
		}

		// Token: 0x0600BB85 RID: 48005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB85")]
		[Address(RVA = "0x1BF53A8", Offset = "0x1BF53A8", VA = "0x7BBC3F53A8")]
		private void OnNewClick()
		{
		}

		// Token: 0x0600BB86 RID: 48006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB86")]
		[Address(RVA = "0x1BF5440", Offset = "0x1BF5440", VA = "0x7BBC3F5440")]
		private void OnOldClick()
		{
		}

		// Token: 0x0600BB87 RID: 48007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB87")]
		[Address(RVA = "0x1BF54D8", Offset = "0x1BF54D8", VA = "0x7BBC3F54D8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600BB88 RID: 48008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB88")]
		[Address(RVA = "0x1BF54E4", Offset = "0x1BF54E4", VA = "0x7BBC3F54E4")]
		public UIChooseHudStyleController()
		{
		}

		// Token: 0x0400BC70 RID: 48240
		[Token(Token = "0x400BC70")]
		[FieldOffset(Offset = "0x98")]
		public UIChooseHudStyleView m_View;

		// Token: 0x0400BC71 RID: 48241
		[Token(Token = "0x400BC71")]
		[FieldOffset(Offset = "0xA0")]
		private Action m_Callback;
	}
}
