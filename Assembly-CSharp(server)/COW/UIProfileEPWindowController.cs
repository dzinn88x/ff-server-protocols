using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001B26 RID: 6950
	[Token(Token = "0x2001B26")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9554", Offset = "0x10F9554")]
	public class UIProfileEPWindowController : UIPopupWindowController
	{
		// Token: 0x060094D9 RID: 38105 RVA: 0x00027588 File Offset: 0x00025788
		[Token(Token = "0x60094D9")]
		[Address(RVA = "0x1B67D1C", Offset = "0x1B67D1C", VA = "0x7BBC367D1C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060094DA RID: 38106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094DA")]
		[Address(RVA = "0x1B67D6C", Offset = "0x1B67D6C", VA = "0x7BBC367D6C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060094DB RID: 38107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094DB")]
		[Address(RVA = "0x1B55638", Offset = "0x1B55638", VA = "0x7BBC355638")]
		public void SetUIdata(List<BasicEPInfo> info)
		{
		}

		// Token: 0x060094DC RID: 38108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094DC")]
		[Address(RVA = "0x1B67DD0", Offset = "0x1B67DD0", VA = "0x7BBC367DD0")]
		public UIProfileEPWindowController()
		{
		}

		// Token: 0x04009E48 RID: 40520
		[Token(Token = "0x4009E48")]
		[FieldOffset(Offset = "0x98")]
		private UIProfileEpWindowShowView m_View;
	}
}
