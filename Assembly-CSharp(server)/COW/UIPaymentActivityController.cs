using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AB0 RID: 6832
	[Token(Token = "0x2001AB0")]
	public class UIPaymentActivityController : UIPaymentController.PaymentTabContentController
	{
		// Token: 0x06009028 RID: 36904 RVA: 0x00026688 File Offset: 0x00024888
		[Token(Token = "0x6009028")]
		[Address(RVA = "0x16EFA9C", Offset = "0x16EFA9C", VA = "0x7BBBEEFA9C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009029 RID: 36905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009029")]
		[Address(RVA = "0x16EFAEC", Offset = "0x16EFAEC", VA = "0x7BBBEEFAEC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600902A RID: 36906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600902A")]
		[Address(RVA = "0x16EFC38", Offset = "0x16EFC38", VA = "0x7BBBEEFC38", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600902B RID: 36907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600902B")]
		[Address(RVA = "0x16EFC40", Offset = "0x16EFC40", VA = "0x7BBBEEFC40", Slot = "29")]
		public override void RefreshContent()
		{
		}

		// Token: 0x0600902C RID: 36908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600902C")]
		[Address(RVA = "0x16EFE54", Offset = "0x16EFE54", VA = "0x7BBBEEFE54")]
		private void OnButtonClick()
		{
		}

		// Token: 0x0600902D RID: 36909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600902D")]
		[Address(RVA = "0x16EFE10", Offset = "0x16EFE10", VA = "0x7BBBEEFE10")]
		private void ApplyCdnUrlToNetworkTexture(UINetworkTextureExt networkTexture, string url)
		{
		}

		// Token: 0x0600902E RID: 36910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600902E")]
		[Address(RVA = "0x16EFF3C", Offset = "0x16EFF3C", VA = "0x7BBBEEFF3C")]
		public UIPaymentActivityController()
		{
		}

		// Token: 0x04009BF9 RID: 39929
		[Token(Token = "0x4009BF9")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentActivityView m_View;

		// Token: 0x04009BFA RID: 39930
		[Token(Token = "0x4009BFA")]
		[FieldOffset(Offset = "0x60")]
		private UIModelActivity m_Activity;
	}
}
