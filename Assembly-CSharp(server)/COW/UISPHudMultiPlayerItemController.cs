using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B94 RID: 7060
	[Token(Token = "0x2001B94")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA67C", Offset = "0x10FA67C")]
	internal class UISPHudMultiPlayerItemController : UIEasyListItemController
	{
		// Token: 0x06009845 RID: 38981 RVA: 0x000281B8 File Offset: 0x000263B8
		[Token(Token = "0x6009845")]
		[Address(RVA = "0x1EEA550", Offset = "0x1EEA550", VA = "0x7BBC6EA550")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009846 RID: 38982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009846")]
		[Address(RVA = "0x1EEA5A0", Offset = "0x1EEA5A0", VA = "0x7BBC6EA5A0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009847 RID: 38983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009847")]
		[Address(RVA = "0x1EEA604", Offset = "0x1EEA604", VA = "0x7BBC6EA604", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06009848 RID: 38984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009848")]
		[Address(RVA = "0x1EEAB00", Offset = "0x1EEAB00", VA = "0x7BBC6EAB00")]
		public UISPHudMultiPlayerItemController()
		{
		}

		// Token: 0x0400A028 RID: 41000
		[Token(Token = "0x400A028")]
		[FieldOffset(Offset = "0x70")]
		private UISPHudMultiPlayerItemView m_View;

		// Token: 0x0400A029 RID: 41001
		[Token(Token = "0x400A029")]
		[FieldOffset(Offset = "0x78")]
		private List<UISPHudSinglePlayerItemController> m_Ctrl;
	}
}
