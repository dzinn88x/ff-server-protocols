using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A36 RID: 6710
	[Token(Token = "0x2001A36")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7BE4", Offset = "0x10F7BE4")]
	public class UIMailRewardItemController : UIBaseController
	{
		// Token: 0x06008CEE RID: 36078 RVA: 0x00025950 File Offset: 0x00023B50
		[Token(Token = "0x6008CEE")]
		[Address(RVA = "0x1CE55A4", Offset = "0x1CE55A4", VA = "0x7BBC4E55A4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008CEF RID: 36079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CEF")]
		[Address(RVA = "0x1CE55F4", Offset = "0x1CE55F4", VA = "0x7BBC4E55F4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008CF0 RID: 36080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CF0")]
		[Address(RVA = "0x1CE24AC", Offset = "0x1CE24AC", VA = "0x7BBC4E24AC")]
		public void SetData(BaseItemInfo item, bool claimed)
		{
		}

		// Token: 0x06008CF1 RID: 36081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CF1")]
		[Address(RVA = "0x1CE56D4", Offset = "0x1CE56D4", VA = "0x7BBC4E56D4")]
		private void ShowItemTip()
		{
		}

		// Token: 0x06008CF2 RID: 36082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CF2")]
		[Address(RVA = "0x1CE57B8", Offset = "0x1CE57B8", VA = "0x7BBC4E57B8")]
		public UIMailRewardItemController()
		{
		}

		// Token: 0x0400992B RID: 39211
		[Token(Token = "0x400992B")]
		[FieldOffset(Offset = "0x58")]
		private UIMailRewardItemView m_View;

		// Token: 0x0400992C RID: 39212
		[Token(Token = "0x400992C")]
		[FieldOffset(Offset = "0x60")]
		private UIStandardItemMiniController m_UIStandardItemMiniController;

		// Token: 0x0400992D RID: 39213
		[Token(Token = "0x400992D")]
		[FieldOffset(Offset = "0x68")]
		private BaseItemInfo m_Item;
	}
}
