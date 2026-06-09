using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001486 RID: 5254
	[Token(Token = "0x2001486")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED02C", Offset = "0x10ED02C")]
	internal class UIChampionshipNoticeDotController : UIBaseController
	{
		// Token: 0x060058BD RID: 22717 RVA: 0x0001A238 File Offset: 0x00018438
		[Token(Token = "0x60058BD")]
		[Address(RVA = "0x1EC7FB0", Offset = "0x1EC7FB0", VA = "0x7BBC6C7FB0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060058BE RID: 22718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058BE")]
		[Address(RVA = "0x1EC8000", Offset = "0x1EC8000", VA = "0x7BBC6C8000", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060058BF RID: 22719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058BF")]
		[Address(RVA = "0x1EC78F8", Offset = "0x1EC78F8", VA = "0x7BBC6C78F8")]
		public void SetSelected(bool v)
		{
		}

		// Token: 0x060058C0 RID: 22720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C0")]
		[Address(RVA = "0x1EC80BC", Offset = "0x1EC80BC", VA = "0x7BBC6C80BC")]
		public UIChampionshipNoticeDotController()
		{
		}

		// Token: 0x04007C7F RID: 31871
		[Token(Token = "0x4007C7F")]
		[FieldOffset(Offset = "0x58")]
		private UIChampionshipNoticeDotView m_View;

		// Token: 0x04007C80 RID: 31872
		[Token(Token = "0x4007C80")]
		[FieldOffset(Offset = "0x60")]
		public int DotIndex;
	}
}
