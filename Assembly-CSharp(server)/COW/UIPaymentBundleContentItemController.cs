using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001AB2 RID: 6834
	[Token(Token = "0x2001AB2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8934", Offset = "0x10F8934")]
	public class UIPaymentBundleContentItemController : UIBaseController
	{
		// Token: 0x06009039 RID: 36921 RVA: 0x000266D0 File Offset: 0x000248D0
		[Token(Token = "0x6009039")]
		[Address(RVA = "0x16F11CC", Offset = "0x16F11CC", VA = "0x7BBBEF11CC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600903A RID: 36922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600903A")]
		[Address(RVA = "0x16F121C", Offset = "0x16F121C", VA = "0x7BBBEF121C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600903B RID: 36923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600903B")]
		[Address(RVA = "0x16F1300", Offset = "0x16F1300", VA = "0x7BBBEF1300")]
		public void SetData(AwardDesc desc)
		{
		}

		// Token: 0x0600903C RID: 36924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600903C")]
		[Address(RVA = "0x16F142C", Offset = "0x16F142C", VA = "0x7BBBEF142C")]
		public void SetDragScrollView(UIScrollView scrollView)
		{
		}

		// Token: 0x0600903D RID: 36925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600903D")]
		[Address(RVA = "0x16F146C", Offset = "0x16F146C", VA = "0x7BBBEF146C")]
		private void OnItemViewClick()
		{
		}

		// Token: 0x0600903E RID: 36926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600903E")]
		[Address(RVA = "0x16F15A4", Offset = "0x16F15A4", VA = "0x7BBBEF15A4")]
		public UIPaymentBundleContentItemController()
		{
		}

		// Token: 0x04009BFD RID: 39933
		[Token(Token = "0x4009BFD")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentBundleContentItemView m_View;

		// Token: 0x04009BFE RID: 39934
		[Token(Token = "0x4009BFE")]
		[FieldOffset(Offset = "0x60")]
		private AwardDesc m_Data;
	}
}
