using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002530 RID: 9520
	[Token(Token = "0x2002530")]
	internal class UISPHudResultNormalTeamItemView : UIBaseView
	{
		// Token: 0x0600C570 RID: 50544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C570")]
		[Address(RVA = "0x1EF0C1C", Offset = "0x1EF0C1C", VA = "0x7BBC6F0C1C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C571 RID: 50545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C571")]
		[Address(RVA = "0x1EF0D3C", Offset = "0x1EF0D3C", VA = "0x7BBC6F0D3C")]
		public UISPHudResultNormalTeamItemView()
		{
		}

		// Token: 0x0400F353 RID: 62291
		[Token(Token = "0x400F353")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UISPHudResultNormalTeamItem;

		// Token: 0x0400F354 RID: 62292
		[Token(Token = "0x400F354")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Id;

		// Token: 0x0400F355 RID: 62293
		[Token(Token = "0x400F355")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid Grid;
	}
}
