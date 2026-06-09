using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019F8 RID: 6648
	[Token(Token = "0x20019F8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F75AC", Offset = "0x10F75AC")]
	public class UILobbyIAPBundleController : UIBaseController
	{
		// Token: 0x060089CE RID: 35278 RVA: 0x00024F60 File Offset: 0x00023160
		[Token(Token = "0x60089CE")]
		[Address(RVA = "0x1539304", Offset = "0x1539304", VA = "0x7BBBD39304")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060089CF RID: 35279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089CF")]
		[Address(RVA = "0x1539354", Offset = "0x1539354", VA = "0x7BBBD39354", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060089D0 RID: 35280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089D0")]
		[Address(RVA = "0x1539490", Offset = "0x1539490", VA = "0x7BBBD39490", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060089D1 RID: 35281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089D1")]
		[Address(RVA = "0x1539498", Offset = "0x1539498", VA = "0x7BBBD39498")]
		private void OnIAPBundleButtonClick()
		{
		}

		// Token: 0x060089D2 RID: 35282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089D2")]
		[Address(RVA = "0x1539618", Offset = "0x1539618", VA = "0x7BBBD39618")]
		public void UpdateData()
		{
		}

		// Token: 0x060089D3 RID: 35283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089D3")]
		[Address(RVA = "0x1539898", Offset = "0x1539898", VA = "0x7BBBD39898")]
		public UILobbyIAPBundleController()
		{
		}

		// Token: 0x040097B2 RID: 38834
		[Token(Token = "0x40097B2")]
		[FieldOffset(Offset = "0x58")]
		private UILobbyIAPBundleView m_View;

		// Token: 0x040097B3 RID: 38835
		[Token(Token = "0x40097B3")]
		[FieldOffset(Offset = "0x60")]
		private UIModelIAPBundle m_Model;
	}
}
