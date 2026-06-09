using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016F2 RID: 5874
	[Token(Token = "0x20016F2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1194", Offset = "0x10F1194")]
	public class UIChangeServerController : UIBaseController
	{
		// Token: 0x06006D07 RID: 27911 RVA: 0x0001EC18 File Offset: 0x0001CE18
		[Token(Token = "0x6006D07")]
		[Address(RVA = "0x1BDDE70", Offset = "0x1BDDE70", VA = "0x7BBC3DDE70")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006D08 RID: 27912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D08")]
		[Address(RVA = "0x1BDDEC0", Offset = "0x1BDDEC0", VA = "0x7BBC3DDEC0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006D09 RID: 27913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D09")]
		[Address(RVA = "0x1BDDFFC", Offset = "0x1BDDFFC", VA = "0x7BBC3DDFFC")]
		public void SetServerList(int regionid)
		{
		}

		// Token: 0x06006D0A RID: 27914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D0A")]
		[Address(RVA = "0x1BDE5CC", Offset = "0x1BDE5CC", VA = "0x7BBC3DE5CC")]
		private void OnCloseClick()
		{
		}

		// Token: 0x06006D0B RID: 27915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D0B")]
		[Address(RVA = "0x1BDE5D4", Offset = "0x1BDE5D4", VA = "0x7BBC3DE5D4")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x06006D0C RID: 27916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D0C")]
		[Address(RVA = "0x1BDE828", Offset = "0x1BDE828", VA = "0x7BBC3DE828")]
		public UIChangeServerController()
		{
		}

		// Token: 0x04008871 RID: 34929
		[Token(Token = "0x4008871")]
		[FieldOffset(Offset = "0x58")]
		private UIChangeServerView m_View;

		// Token: 0x04008872 RID: 34930
		[Token(Token = "0x4008872")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<UIToggle, RegionSettingData> m_ToggleServerData;
	}
}
