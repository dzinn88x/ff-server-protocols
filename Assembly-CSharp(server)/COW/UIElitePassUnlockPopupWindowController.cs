using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020017A5 RID: 6053
	[Token(Token = "0x20017A5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F282C", Offset = "0x10F282C")]
	internal class UIElitePassUnlockPopupWindowController : UIPopupWindowController
	{
		// Token: 0x06007395 RID: 29589 RVA: 0x00020178 File Offset: 0x0001E378
		[Token(Token = "0x6007395")]
		[Address(RVA = "0x1E70B00", Offset = "0x1E70B00", VA = "0x7BBC670B00")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007396 RID: 29590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007396")]
		[Address(RVA = "0x1E70B50", Offset = "0x1E70B50", VA = "0x7BBC670B50", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007397 RID: 29591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007397")]
		[Address(RVA = "0x1E70C94", Offset = "0x1E70C94", VA = "0x7BBC670C94")]
		public void UpdateBundleUnlockUI()
		{
		}

		// Token: 0x06007398 RID: 29592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007398")]
		[Address(RVA = "0x1E70DD4", Offset = "0x1E70DD4", VA = "0x7BBC670DD4")]
		public void RefreshTitle(uint cnt)
		{
		}

		// Token: 0x06007399 RID: 29593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007399")]
		[Address(RVA = "0x1E70F3C", Offset = "0x1E70F3C", VA = "0x7BBC670F3C")]
		private void OnOKButtonClick()
		{
		}

		// Token: 0x0600739A RID: 29594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739A")]
		[Address(RVA = "0x1E70F44", Offset = "0x1E70F44", VA = "0x7BBC670F44", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600739B RID: 29595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739B")]
		[Address(RVA = "0x1E70FF4", Offset = "0x1E70FF4", VA = "0x7BBC670FF4")]
		public UIElitePassUnlockPopupWindowController()
		{
		}

		// Token: 0x04008BED RID: 35821
		[Token(Token = "0x4008BED")]
		[FieldOffset(Offset = "0x98")]
		private UIElitePassUnlockEPPopupView m_View;

		// Token: 0x04008BEE RID: 35822
		[Token(Token = "0x4008BEE")]
		public const uint EP_PRIVILEGE_CNT = 4U;

		// Token: 0x04008BEF RID: 35823
		[Token(Token = "0x4008BEF")]
		public const uint EPBUNDLE_PRIVILEGE_CNT = 5U;
	}
}
