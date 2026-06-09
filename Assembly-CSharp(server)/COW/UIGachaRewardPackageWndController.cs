using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200181C RID: 6172
	[Token(Token = "0x200181C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3634", Offset = "0x10F3634")]
	internal class UIGachaRewardPackageWndController : UIPopupWindowController, IEasyList
	{
		// Token: 0x0600785F RID: 30815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600785F")]
		[Address(RVA = "0x1F9FCB8", Offset = "0x1F9FCB8", VA = "0x7BBC79FCB8", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06007860 RID: 30816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007860")]
		[Address(RVA = "0x1F9FD20", Offset = "0x1F9FD20", VA = "0x7BBC79FD20", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06007861 RID: 30817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007861")]
		[Address(RVA = "0x1F9FD88", Offset = "0x1F9FD88", VA = "0x7BBC79FD88")]
		public UIGachaRewardPackageWndController()
		{
		}
	}
}
