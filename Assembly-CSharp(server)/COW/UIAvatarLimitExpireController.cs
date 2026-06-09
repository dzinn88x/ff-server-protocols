using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016AD RID: 5805
	[Token(Token = "0x20016AD")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F096C", Offset = "0x10F096C")]
	public class UIAvatarLimitExpireController : UIPopupWindowController
	{
		// Token: 0x060069EC RID: 27116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069EC")]
		[Address(RVA = "0x1B2A020", Offset = "0x1B2A020", VA = "0x7BBC32A020", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060069ED RID: 27117 RVA: 0x0001E018 File Offset: 0x0001C218
		[Token(Token = "0x60069ED")]
		[Address(RVA = "0x1B2A14C", Offset = "0x1B2A14C", VA = "0x7BBC32A14C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060069EE RID: 27118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069EE")]
		[Address(RVA = "0x1B2A19C", Offset = "0x1B2A19C", VA = "0x7BBC32A19C")]
		public void SetExpireInfo(List<uint> expireAvatars)
		{
		}

		// Token: 0x060069EF RID: 27119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069EF")]
		[Address(RVA = "0x1B2A458", Offset = "0x1B2A458", VA = "0x7BBC32A458", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060069F0 RID: 27120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069F0")]
		[Address(RVA = "0x1B2A460", Offset = "0x1B2A460", VA = "0x7BBC32A460")]
		public UIAvatarLimitExpireController()
		{
		}

		// Token: 0x040086A0 RID: 34464
		[Token(Token = "0x40086A0")]
		[FieldOffset(Offset = "0x98")]
		private UIAvatarLimitExpireView m_View;
	}
}
