using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016FD RID: 5885
	[Token(Token = "0x20016FD")]
	public class UIChatPopMenuController : UIBasePopMenuController<UIChatPopMenuItemContoller>
	{
		// Token: 0x06006D6A RID: 28010 RVA: 0x0001ED80 File Offset: 0x0001CF80
		[Token(Token = "0x6006D6A")]
		[Address(RVA = "0x1BE5AEC", Offset = "0x1BE5AEC", VA = "0x7BBC3E5AEC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006D6B RID: 28011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D6B")]
		[Address(RVA = "0x1BE5B3C", Offset = "0x1BE5B3C", VA = "0x7BBC3E5B3C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006D6C RID: 28012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D6C")]
		[Address(RVA = "0x1BE5BDC", Offset = "0x1BE5BDC", VA = "0x7BBC3E5BDC")]
		public void UpdateMenuData(List<CommonPopMenuData> list, ulong userid)
		{
		}

		// Token: 0x06006D6D RID: 28013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D6D")]
		[Address(RVA = "0x1BE5C60", Offset = "0x1BE5C60", VA = "0x7BBC3E5C60")]
		public void UpdateMenuData(List<CommonPopMenuData> list, ulong userid, Vector3 WindowPos)
		{
		}

		// Token: 0x06006D6E RID: 28014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D6E")]
		[Address(RVA = "0x1BE61F4", Offset = "0x1BE61F4", VA = "0x7BBC3E61F4")]
		private void UpdateMenuDataWithFixedWidth(List<CommonPopMenuData> list, int width)
		{
		}

		// Token: 0x06006D6F RID: 28015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D6F")]
		[Address(RVA = "0x1BE6494", Offset = "0x1BE6494", VA = "0x7BBC3E6494")]
		public UIChatPopMenuController()
		{
		}

		// Token: 0x0400888E RID: 34958
		[Token(Token = "0x400888E")]
		[FieldOffset(Offset = "0xE0")]
		private UICommonPopMenuView m_View;

		// Token: 0x0400888F RID: 34959
		[Token(Token = "0x400888F")]
		[FieldOffset(Offset = "0xE8")]
		private UIClickMask m_ClickMask;
	}
}
