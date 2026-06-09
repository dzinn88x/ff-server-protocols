using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020017A2 RID: 6050
	[Token(Token = "0x20017A2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F27AC", Offset = "0x10F27AC")]
	public class UIElitePassSubscriptionConfirmWindowController : UIPopupWindowController
	{
		// Token: 0x0600737E RID: 29566 RVA: 0x00020118 File Offset: 0x0001E318
		[Token(Token = "0x600737E")]
		[Address(RVA = "0x1E6F014", Offset = "0x1E6F014", VA = "0x7BBC66F014")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600737F RID: 29567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600737F")]
		[Address(RVA = "0x1E6F064", Offset = "0x1E6F064", VA = "0x7BBC66F064", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007380")]
		[Address(RVA = "0x1E6F248", Offset = "0x1E6F248", VA = "0x7BBC66F248", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007381 RID: 29569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007381")]
		[Address(RVA = "0x1E6F250", Offset = "0x1E6F250", VA = "0x7BBC66F250")]
		private void OnBtnConfirmClick()
		{
		}

		// Token: 0x06007382 RID: 29570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007382")]
		[Address(RVA = "0x1E6F300", Offset = "0x1E6F300", VA = "0x7BBC66F300")]
		private void OnBtnCancelClick()
		{
		}

		// Token: 0x06007383 RID: 29571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007383")]
		[Address(RVA = "0x1E6F308", Offset = "0x1E6F308", VA = "0x7BBC66F308")]
		public UIElitePassSubscriptionConfirmWindowController()
		{
		}

		// Token: 0x04008BE7 RID: 35815
		[Token(Token = "0x4008BE7")]
		[FieldOffset(Offset = "0x98")]
		private UIElitePassSubscriptionConfirmWindowView m_View;
	}
}
