using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002559 RID: 9561
	[Token(Token = "0x2002559")]
	public class UISuperCarChangeSkinWndView : UIBaseView
	{
		// Token: 0x0600C5C2 RID: 50626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5C2")]
		[Address(RVA = "0x213D0B4", Offset = "0x213D0B4", VA = "0x7BBC93D0B4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5C3 RID: 50627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5C3")]
		[Address(RVA = "0x213D3B4", Offset = "0x213D3B4", VA = "0x7BBC93D3B4")]
		public UISuperCarChangeSkinWndView()
		{
		}

		// Token: 0x0400F515 RID: 62741
		[Token(Token = "0x400F515")]
		[FieldOffset(Offset = "0x20")]
		public UITable ChangeCarTable;

		// Token: 0x0400F516 RID: 62742
		[Token(Token = "0x400F516")]
		[FieldOffset(Offset = "0x28")]
		public UIToggleButtonGroup ChangeCarToggles;

		// Token: 0x0400F517 RID: 62743
		[Token(Token = "0x400F517")]
		[FieldOffset(Offset = "0x30")]
		public UIToggleButton CarSkinToggleBtn;

		// Token: 0x0400F518 RID: 62744
		[Token(Token = "0x400F518")]
		[FieldOffset(Offset = "0x38")]
		public UILabel UseLabel;

		// Token: 0x0400F519 RID: 62745
		[Token(Token = "0x400F519")]
		[FieldOffset(Offset = "0x40")]
		public UISprite LockSprite;

		// Token: 0x0400F51A RID: 62746
		[Token(Token = "0x400F51A")]
		[FieldOffset(Offset = "0x48")]
		public UISprite BgSprite;

		// Token: 0x0400F51B RID: 62747
		[Token(Token = "0x400F51B")]
		[FieldOffset(Offset = "0x50")]
		public UIButton GetSkinBtn;

		// Token: 0x0400F51C RID: 62748
		[Token(Token = "0x400F51C")]
		[FieldOffset(Offset = "0x58")]
		public GameObject CarSkinUsing;

		// Token: 0x0400F51D RID: 62749
		[Token(Token = "0x400F51D")]
		[FieldOffset(Offset = "0x60")]
		public UIButton CarSkinUseBtn;

		// Token: 0x0400F51E RID: 62750
		[Token(Token = "0x400F51E")]
		[FieldOffset(Offset = "0x68")]
		public UIButton RightMask;
	}
}
