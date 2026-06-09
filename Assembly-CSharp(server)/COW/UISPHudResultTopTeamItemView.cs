using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002536 RID: 9526
	[Token(Token = "0x2002536")]
	internal class UISPHudResultTopTeamItemView : UIBaseView
	{
		// Token: 0x0600C57C RID: 50556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C57C")]
		[Address(RVA = "0x1EF2984", Offset = "0x1EF2984", VA = "0x7BBC6F2984", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C57D RID: 50557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C57D")]
		[Address(RVA = "0x1EF2B28", Offset = "0x1EF2B28", VA = "0x7BBC6F2B28")]
		public UISPHudResultTopTeamItemView()
		{
		}

		// Token: 0x0400F372 RID: 62322
		[Token(Token = "0x400F372")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UISPHudResultTopTeamItem;

		// Token: 0x0400F373 RID: 62323
		[Token(Token = "0x400F373")]
		[FieldOffset(Offset = "0x28")]
		public GameObject FirBG;

		// Token: 0x0400F374 RID: 62324
		[Token(Token = "0x400F374")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Banner;

		// Token: 0x0400F375 RID: 62325
		[Token(Token = "0x400F375")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Id;

		// Token: 0x0400F376 RID: 62326
		[Token(Token = "0x400F376")]
		[FieldOffset(Offset = "0x40")]
		public UIGrid Grid;
	}
}
