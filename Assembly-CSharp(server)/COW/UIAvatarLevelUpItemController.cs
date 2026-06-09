using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016AA RID: 5802
	[Token(Token = "0x20016AA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F08EC", Offset = "0x10F08EC")]
	public class UIAvatarLevelUpItemController : UIBaseController
	{
		// Token: 0x060069CE RID: 27086 RVA: 0x0001DF88 File Offset: 0x0001C188
		[Token(Token = "0x60069CE")]
		[Address(RVA = "0x1B26164", Offset = "0x1B26164", VA = "0x7BBC326164")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060069CF RID: 27087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069CF")]
		[Address(RVA = "0x1B261B4", Offset = "0x1B261B4", VA = "0x7BBC3261B4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060069D0 RID: 27088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069D0")]
		[Address(RVA = "0x1B26218", Offset = "0x1B26218", VA = "0x7BBC326218")]
		public void RefreshData(AvatarLevelUpItem itemdata)
		{
		}

		// Token: 0x060069D1 RID: 27089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069D1")]
		[Address(RVA = "0x1B2654C", Offset = "0x1B2654C", VA = "0x7BBC32654C")]
		public UIAvatarLevelUpItemController()
		{
		}

		// Token: 0x0400868A RID: 34442
		[Token(Token = "0x400868A")]
		[FieldOffset(Offset = "0x58")]
		private UIAvatarLevelUpItemView m_View;

		// Token: 0x0400868B RID: 34443
		[Token(Token = "0x400868B")]
		[FieldOffset(Offset = "0x60")]
		private UIStandardItemMiniController m_ctrl;
	}
}
