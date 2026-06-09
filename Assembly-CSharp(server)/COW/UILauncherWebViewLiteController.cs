using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019CC RID: 6604
	[Token(Token = "0x20019CC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F70CC", Offset = "0x10F70CC")]
	internal class UILauncherWebViewLiteController : UIBaseController
	{
		// Token: 0x060087C3 RID: 34755 RVA: 0x00024A38 File Offset: 0x00022C38
		[Token(Token = "0x60087C3")]
		[Address(RVA = "0x1E29828", Offset = "0x1E29828", VA = "0x7BBC629828")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060087C4 RID: 34756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087C4")]
		[Address(RVA = "0x1E29878", Offset = "0x1E29878", VA = "0x7BBC629878", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060087C5 RID: 34757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087C5")]
		[Address(RVA = "0x1E2995C", Offset = "0x1E2995C", VA = "0x7BBC62995C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060087C6 RID: 34758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087C6")]
		[Address(RVA = "0x1E29998", Offset = "0x1E29998", VA = "0x7BBC629998")]
		private void OnCloseButtonClick()
		{
		}

		// Token: 0x060087C7 RID: 34759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087C7")]
		[Address(RVA = "0x1E29A40", Offset = "0x1E29A40", VA = "0x7BBC629A40")]
		private void Update()
		{
		}

		// Token: 0x060087C8 RID: 34760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087C8")]
		[Address(RVA = "0x1E26788", Offset = "0x1E26788", VA = "0x7BBC626788")]
		public void SetURL(string url)
		{
		}

		// Token: 0x060087C9 RID: 34761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087C9")]
		[Address(RVA = "0x1E29A7C", Offset = "0x1E29A7C", VA = "0x7BBC629A7C")]
		private void UpdateProgressBar()
		{
		}

		// Token: 0x060087CA RID: 34762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087CA")]
		[Address(RVA = "0x1E29C98", Offset = "0x1E29C98", VA = "0x7BBC629C98")]
		public UILauncherWebViewLiteController()
		{
		}

		// Token: 0x04009649 RID: 38473
		[Token(Token = "0x4009649")]
		[FieldOffset(Offset = "0x58")]
		private UIWebViewWindowLiteView m_View;

		// Token: 0x0400964A RID: 38474
		[Token(Token = "0x400964A")]
		[FieldOffset(Offset = "0x60")]
		private WebView m_WebView;
	}
}
