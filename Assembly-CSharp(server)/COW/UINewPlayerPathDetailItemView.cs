using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200245A RID: 9306
	[Token(Token = "0x200245A")]
	public class UINewPlayerPathDetailItemView : UIBaseView
	{
		// Token: 0x0600C3C4 RID: 50116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3C4")]
		[Address(RVA = "0x1AF7650", Offset = "0x1AF7650", VA = "0x7BBC2F7650", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3C5 RID: 50117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3C5")]
		[Address(RVA = "0x1AF7A20", Offset = "0x1AF7A20", VA = "0x7BBC2F7A20")]
		public UINewPlayerPathDetailItemView()
		{
		}

		// Token: 0x0400E8B7 RID: 59575
		[Token(Token = "0x400E8B7")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnItem;

		// Token: 0x0400E8B8 RID: 59576
		[Token(Token = "0x400E8B8")]
		[FieldOffset(Offset = "0x28")]
		public UISprite ChooseBox;

		// Token: 0x0400E8B9 RID: 59577
		[Token(Token = "0x400E8B9")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Sprite_Weapon;

		// Token: 0x0400E8BA RID: 59578
		[Token(Token = "0x400E8BA")]
		[FieldOffset(Offset = "0x38")]
		public BaseItemView TaskIcon;

		// Token: 0x0400E8BB RID: 59579
		[Token(Token = "0x400E8BB")]
		[FieldOffset(Offset = "0x40")]
		public UISprite TaskIcon01;

		// Token: 0x0400E8BC RID: 59580
		[Token(Token = "0x400E8BC")]
		[FieldOffset(Offset = "0x48")]
		public UISprite TaskIcon02;

		// Token: 0x0400E8BD RID: 59581
		[Token(Token = "0x400E8BD")]
		[FieldOffset(Offset = "0x50")]
		public UIButton RewardIconBtn;

		// Token: 0x0400E8BE RID: 59582
		[Token(Token = "0x400E8BE")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Desc;

		// Token: 0x0400E8BF RID: 59583
		[Token(Token = "0x400E8BF")]
		[FieldOffset(Offset = "0x60")]
		public UILabel CountLabel;

		// Token: 0x0400E8C0 RID: 59584
		[Token(Token = "0x400E8C0")]
		[FieldOffset(Offset = "0x68")]
		public GameObject NormalState;

		// Token: 0x0400E8C1 RID: 59585
		[Token(Token = "0x400E8C1")]
		[FieldOffset(Offset = "0x70")]
		public GameObject WaitClaimState;

		// Token: 0x0400E8C2 RID: 59586
		[Token(Token = "0x400E8C2")]
		[FieldOffset(Offset = "0x78")]
		public UIButton ClaimBtn;

		// Token: 0x0400E8C3 RID: 59587
		[Token(Token = "0x400E8C3")]
		[FieldOffset(Offset = "0x80")]
		public GameObject ClaimedState;

		// Token: 0x0400E8C4 RID: 59588
		[Token(Token = "0x400E8C4")]
		[FieldOffset(Offset = "0x88")]
		public UIButton GotoBtn;

		// Token: 0x0400E8C5 RID: 59589
		[Token(Token = "0x400E8C5")]
		[FieldOffset(Offset = "0x90")]
		public GameObject RedDot;
	}
}
