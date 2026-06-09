using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B12 RID: 6930
	[Token(Token = "0x2001B12")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F93EC", Offset = "0x10F93EC")]
	public class UIPPTOPController : UIPopupWindowController
	{
		// Token: 0x06009356 RID: 37718 RVA: 0x00027288 File Offset: 0x00025488
		[Token(Token = "0x6009356")]
		[Address(RVA = "0x16E1A0C", Offset = "0x16E1A0C", VA = "0x7BBBEE1A0C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009357 RID: 37719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009357")]
		[Address(RVA = "0x16E1A5C", Offset = "0x16E1A5C", VA = "0x7BBBEE1A5C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009358 RID: 37720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009358")]
		[Address(RVA = "0x16E1BF0", Offset = "0x16E1BF0", VA = "0x7BBBEE1BF0")]
		public void SetData(bool privacyShow, bool serviceShow, string privacyURL, string serviceURL)
		{
		}

		// Token: 0x06009359 RID: 37721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009359")]
		[Address(RVA = "0x16E1D0C", Offset = "0x16E1D0C", VA = "0x7BBBEE1D0C")]
		private void OnBtnPrivacyClick()
		{
		}

		// Token: 0x0600935A RID: 37722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600935A")]
		[Address(RVA = "0x16E1D20", Offset = "0x16E1D20", VA = "0x7BBBEE1D20")]
		private void OnBtnServiceClick()
		{
		}

		// Token: 0x0600935B RID: 37723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600935B")]
		[Address(RVA = "0x16E1D34", Offset = "0x16E1D34", VA = "0x7BBBEE1D34")]
		private void OnBtnAgreeClick()
		{
		}

		// Token: 0x0600935C RID: 37724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600935C")]
		[Address(RVA = "0x16E1DF0", Offset = "0x16E1DF0", VA = "0x7BBBEE1DF0", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600935D RID: 37725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600935D")]
		[Address(RVA = "0x16E1F24", Offset = "0x16E1F24", VA = "0x7BBBEE1F24")]
		public UIPPTOPController()
		{
		}

		// Token: 0x04009D8E RID: 40334
		[Token(Token = "0x4009D8E")]
		[FieldOffset(Offset = "0x98")]
		private UIPPTOPView m_View;

		// Token: 0x04009D8F RID: 40335
		[Token(Token = "0x4009D8F")]
		[FieldOffset(Offset = "0xA0")]
		private string m_PrivacyURL;

		// Token: 0x04009D90 RID: 40336
		[Token(Token = "0x4009D90")]
		[FieldOffset(Offset = "0xA8")]
		private string m_ServiceURL;

		// Token: 0x04009D91 RID: 40337
		[Token(Token = "0x4009D91")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_IsAgreed;
	}
}
