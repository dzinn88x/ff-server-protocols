using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017D9 RID: 6105
	[Token(Token = "0x20017D9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2E7C", Offset = "0x10F2E7C")]
	public class UIGachaADItemController : UIBaseController
	{
		// Token: 0x060075AF RID: 30127 RVA: 0x00020AC0 File Offset: 0x0001ECC0
		[Token(Token = "0x60075AF")]
		[Address(RVA = "0x214F4D4", Offset = "0x214F4D4", VA = "0x7BBC94F4D4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060075B0 RID: 30128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075B0")]
		[Address(RVA = "0x214F524", Offset = "0x214F524", VA = "0x7BBC94F524", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060075B1 RID: 30129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075B1")]
		[Address(RVA = "0x214F680", Offset = "0x214F680", VA = "0x7BBC94F680")]
		private void OnItemSelect()
		{
		}

		// Token: 0x060075B2 RID: 30130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075B2")]
		[Address(RVA = "0x214F71C", Offset = "0x214F71C", VA = "0x7BBC94F71C")]
		public void RefreshAdData(AdvertDesc info)
		{
		}

		// Token: 0x060075B3 RID: 30131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075B3")]
		[Address(RVA = "0x214F8A4", Offset = "0x214F8A4", VA = "0x7BBC94F8A4")]
		public UIGachaADItemController()
		{
		}

		// Token: 0x04008D04 RID: 36100
		[Token(Token = "0x4008D04")]
		[FieldOffset(Offset = "0x58")]
		private UIGachaADItemView m_View;
	}
}
