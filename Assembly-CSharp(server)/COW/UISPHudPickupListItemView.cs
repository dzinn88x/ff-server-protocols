using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002520 RID: 9504
	[Token(Token = "0x2002520")]
	internal class UISPHudPickupListItemView : UIBaseView
	{
		// Token: 0x0600C550 RID: 50512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C550")]
		[Address(RVA = "0x1EEC570", Offset = "0x1EEC570", VA = "0x7BBC6EC570", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C551 RID: 50513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C551")]
		[Address(RVA = "0x1EEC6E4", Offset = "0x1EEC6E4", VA = "0x7BBC6EC6E4")]
		public UISPHudPickupListItemView()
		{
		}

		// Token: 0x0400F2ED RID: 62189
		[Token(Token = "0x400F2ED")]
		[FieldOffset(Offset = "0x20")]
		public UILabel LabelCount;

		// Token: 0x0400F2EE RID: 62190
		[Token(Token = "0x400F2EE")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnItemAction;

		// Token: 0x0400F2EF RID: 62191
		[Token(Token = "0x400F2EF")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ItemName;

		// Token: 0x0400F2F0 RID: 62192
		[Token(Token = "0x400F2F0")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SpriteItemIcon;
	}
}
