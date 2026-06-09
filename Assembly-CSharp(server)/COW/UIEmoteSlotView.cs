using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021C7 RID: 8647
	[Token(Token = "0x20021C7")]
	public class UIEmoteSlotView : UIBaseView
	{
		// Token: 0x0600BE9F RID: 48799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE9F")]
		[Address(RVA = "0x1E78FE4", Offset = "0x1E78FE4", VA = "0x7BBC678FE4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEA0 RID: 48800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEA0")]
		[Address(RVA = "0x1E79250", Offset = "0x1E79250", VA = "0x7BBC679250")]
		public UIEmoteSlotView()
		{
		}

		// Token: 0x0400CB11 RID: 51985
		[Token(Token = "0x400CB11")]
		[FieldOffset(Offset = "0x20")]
		public UIButton slotBtn;

		// Token: 0x0400CB12 RID: 51986
		[Token(Token = "0x400CB12")]
		[FieldOffset(Offset = "0x28")]
		public UISprite defaultIcon;

		// Token: 0x0400CB13 RID: 51987
		[Token(Token = "0x400CB13")]
		[FieldOffset(Offset = "0x30")]
		public UISprite icon;

		// Token: 0x0400CB14 RID: 51988
		[Token(Token = "0x400CB14")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HL;

		// Token: 0x0400CB15 RID: 51989
		[Token(Token = "0x400CB15")]
		[FieldOffset(Offset = "0x40")]
		public GameObject DragItem;

		// Token: 0x0400CB16 RID: 51990
		[Token(Token = "0x400CB16")]
		[FieldOffset(Offset = "0x48")]
		public UISprite DragIcon;

		// Token: 0x0400CB17 RID: 51991
		[Token(Token = "0x400CB17")]
		[FieldOffset(Offset = "0x50")]
		public GameObject HintArrow;

		// Token: 0x0400CB18 RID: 51992
		[Token(Token = "0x400CB18")]
		[FieldOffset(Offset = "0x58")]
		public GameObject DownLoadState;

		// Token: 0x0400CB19 RID: 51993
		[Token(Token = "0x400CB19")]
		[FieldOffset(Offset = "0x60")]
		public UILabel BooyahLabel;
	}
}
