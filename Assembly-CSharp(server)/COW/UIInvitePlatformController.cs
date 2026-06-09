using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019C3 RID: 6595
	[Token(Token = "0x20019C3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6FCC", Offset = "0x10F6FCC")]
	internal class UIInvitePlatformController : UIPopupWindowController
	{
		// Token: 0x06008781 RID: 34689 RVA: 0x000249C0 File Offset: 0x00022BC0
		[Token(Token = "0x6008781")]
		[Address(RVA = "0x1E832C0", Offset = "0x1E832C0", VA = "0x7BBC6832C0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008782 RID: 34690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008782")]
		[Address(RVA = "0x1E83310", Offset = "0x1E83310", VA = "0x7BBC683310", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008783 RID: 34691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008783")]
		[Address(RVA = "0x1E838C4", Offset = "0x1E838C4", VA = "0x7BBC6838C4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008784 RID: 34692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008784")]
		[Address(RVA = "0x1E838CC", Offset = "0x1E838CC", VA = "0x7BBC6838CC")]
		private string MakeInviteUrl(string urlTemplate)
		{
			return null;
		}

		// Token: 0x06008785 RID: 34693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008785")]
		[Address(RVA = "0x1E83CF4", Offset = "0x1E83CF4", VA = "0x7BBC683CF4")]
		private void OnBtnLineInviteClick()
		{
		}

		// Token: 0x06008786 RID: 34694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008786")]
		[Address(RVA = "0x1E840C0", Offset = "0x1E840C0", VA = "0x7BBC6840C0")]
		private void OnBtnFBInviteClick()
		{
		}

		// Token: 0x06008787 RID: 34695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008787")]
		[Address(RVA = "0x1E845B4", Offset = "0x1E845B4", VA = "0x7BBC6845B4")]
		private void OnBtnVKInviteClick()
		{
		}

		// Token: 0x06008788 RID: 34696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008788")]
		[Address(RVA = "0x1E84870", Offset = "0x1E84870", VA = "0x7BBC684870")]
		private void OnBtnOtherInviteClick()
		{
		}

		// Token: 0x06008789 RID: 34697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008789")]
		[Address(RVA = "0x1E84BA4", Offset = "0x1E84BA4", VA = "0x7BBC684BA4")]
		private void OnCopyLink()
		{
		}

		// Token: 0x0600878A RID: 34698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600878A")]
		[Address(RVA = "0x1E84F00", Offset = "0x1E84F00", VA = "0x7BBC684F00")]
		public UIInvitePlatformController()
		{
		}

		// Token: 0x04009613 RID: 38419
		[Token(Token = "0x4009613")]
		[FieldOffset(Offset = "0x98")]
		protected UIInvitePlatformView m_View;
	}
}
