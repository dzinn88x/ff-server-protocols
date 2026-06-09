using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001ACB RID: 6859
	[Token(Token = "0x2001ACB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8ABC", Offset = "0x10F8ABC")]
	public class UIPaymentFirstTimeWindowController : UIPopupWindowController
	{
		// Token: 0x060090BF RID: 37055 RVA: 0x000269B8 File Offset: 0x00024BB8
		[Token(Token = "0x60090BF")]
		[Address(RVA = "0x1F249C4", Offset = "0x1F249C4", VA = "0x7BBC7249C4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060090C0 RID: 37056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090C0")]
		[Address(RVA = "0x1F24A14", Offset = "0x1F24A14", VA = "0x7BBC724A14", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060090C1 RID: 37057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090C1")]
		[Address(RVA = "0x1F24E84", Offset = "0x1F24E84", VA = "0x7BBC724E84")]
		private void OnGotoButtonClick()
		{
		}

		// Token: 0x060090C2 RID: 37058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090C2")]
		[Address(RVA = "0x1F2504C", Offset = "0x1F2504C", VA = "0x7BBC72504C")]
		private void OnCloseButtonClick()
		{
		}

		// Token: 0x060090C3 RID: 37059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090C3")]
		[Address(RVA = "0x1F24B5C", Offset = "0x1F24B5C", VA = "0x7BBC724B5C")]
		private void UpdateNetworkTexture()
		{
		}

		// Token: 0x060090C4 RID: 37060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090C4")]
		[Address(RVA = "0x1F25054", Offset = "0x1F25054", VA = "0x7BBC725054")]
		public UIPaymentFirstTimeWindowController()
		{
		}

		// Token: 0x04009C53 RID: 40019
		[Token(Token = "0x4009C53")]
		[FieldOffset(Offset = "0x98")]
		private UIPaymentFirstTimeWindowView m_View;
	}
}
