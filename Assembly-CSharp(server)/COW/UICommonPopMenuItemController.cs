using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001754 RID: 5972
	[Token(Token = "0x2001754")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1E1C", Offset = "0x10F1E1C")]
	public class UICommonPopMenuItemController : UIBaseController
	{
		// Token: 0x06007059 RID: 28761 RVA: 0x0001F728 File Offset: 0x0001D928
		[Token(Token = "0x6007059")]
		[Address(RVA = "0x1803504", Offset = "0x1803504", VA = "0x7BBC003504")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600705A RID: 28762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600705A")]
		[Address(RVA = "0x1803554", Offset = "0x1803554", VA = "0x7BBC003554", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600705B RID: 28763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600705B")]
		[Address(RVA = "0x18036A4", Offset = "0x18036A4", VA = "0x7BBC0036A4")]
		public void SetItemData(CommonPopMenuData data, int width, int height)
		{
		}

		// Token: 0x0600705C RID: 28764 RVA: 0x0001F740 File Offset: 0x0001D940
		[Token(Token = "0x600705C")]
		[Address(RVA = "0x18038F8", Offset = "0x18038F8", VA = "0x7BBC0038F8")]
		public int getTextPixelWidth()
		{
			return 0;
		}

		// Token: 0x0600705D RID: 28765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600705D")]
		[Address(RVA = "0x1803948", Offset = "0x1803948", VA = "0x7BBC003948")]
		public void setContainerWidth(int width)
		{
		}

		// Token: 0x0600705E RID: 28766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600705E")]
		[Address(RVA = "0x1803C08", Offset = "0x1803C08", VA = "0x7BBC003C08")]
		private void OnPopMenuItemClick()
		{
		}

		// Token: 0x0600705F RID: 28767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600705F")]
		[Address(RVA = "0x1803D40", Offset = "0x1803D40", VA = "0x7BBC003D40")]
		public UICommonPopMenuItemController()
		{
		}

		// Token: 0x04008A35 RID: 35381
		[Token(Token = "0x4008A35")]
		[FieldOffset(Offset = "0x58")]
		private UICommonPopMenuItemView m_View;

		// Token: 0x04008A36 RID: 35382
		[Token(Token = "0x4008A36")]
		[FieldOffset(Offset = "0x60")]
		private CommonPopMenuData m_Data;

		// Token: 0x04008A37 RID: 35383
		[Token(Token = "0x4008A37")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 m_localPostition;
	}
}
