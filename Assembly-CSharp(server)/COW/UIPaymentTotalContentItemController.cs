using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001ADE RID: 6878
	[Token(Token = "0x2001ADE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8CFC", Offset = "0x10F8CFC")]
	public class UIPaymentTotalContentItemController : UIBaseController
	{
		// Token: 0x060091C0 RID: 37312 RVA: 0x00026CD0 File Offset: 0x00024ED0
		[Token(Token = "0x60091C0")]
		[Address(RVA = "0x1F37EB0", Offset = "0x1F37EB0", VA = "0x7BBC737EB0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060091C1 RID: 37313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091C1")]
		[Address(RVA = "0x1F37F00", Offset = "0x1F37F00", VA = "0x7BBC737F00", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060091C2 RID: 37314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091C2")]
		[Address(RVA = "0x1F3800C", Offset = "0x1F3800C", VA = "0x7BBC73800C")]
		public void SetData(AwardDesc award, bool claimed)
		{
		}

		// Token: 0x060091C3 RID: 37315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091C3")]
		[Address(RVA = "0x1F38130", Offset = "0x1F38130", VA = "0x7BBC738130")]
		public UIPaymentTotalContentItemController()
		{
		}

		// Token: 0x04009C9B RID: 40091
		[Token(Token = "0x4009C9B")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentTotalContentItemView m_View;

		// Token: 0x04009C9C RID: 40092
		[Token(Token = "0x4009C9C")]
		[FieldOffset(Offset = "0x60")]
		private UIStandardItemMiniController m_UIStandardItemMiniController;
	}
}
