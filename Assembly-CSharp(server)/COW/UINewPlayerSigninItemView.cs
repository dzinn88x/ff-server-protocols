using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200245E RID: 9310
	[Token(Token = "0x200245E")]
	internal class UINewPlayerSigninItemView : UIBaseView
	{
		// Token: 0x0600C3CC RID: 50124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3CC")]
		[Address(RVA = "0x1AFC658", Offset = "0x1AFC658", VA = "0x7BBC2FC658", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3CD RID: 50125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3CD")]
		[Address(RVA = "0x1AFCAE8", Offset = "0x1AFCAE8", VA = "0x7BBC2FCAE8")]
		public UINewPlayerSigninItemView()
		{
		}

		// Token: 0x0400E8E8 RID: 59624
		[Token(Token = "0x400E8E8")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnItem;

		// Token: 0x0400E8E9 RID: 59625
		[Token(Token = "0x400E8E9")]
		[FieldOffset(Offset = "0x28")]
		public UISprite HighLightBGNormal;

		// Token: 0x0400E8EA RID: 59626
		[Token(Token = "0x400E8EA")]
		[FieldOffset(Offset = "0x30")]
		public UISprite ItemMaskBG;

		// Token: 0x0400E8EB RID: 59627
		[Token(Token = "0x400E8EB")]
		[FieldOffset(Offset = "0x38")]
		public UILabel DayCountLabel;

		// Token: 0x0400E8EC RID: 59628
		[Token(Token = "0x400E8EC")]
		[FieldOffset(Offset = "0x40")]
		public Transform ItemInfoContainer;

		// Token: 0x0400E8ED RID: 59629
		[Token(Token = "0x400E8ED")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ItemCount;

		// Token: 0x0400E8EE RID: 59630
		[Token(Token = "0x400E8EE")]
		[FieldOffset(Offset = "0x50")]
		public UILabel ItemTimeLeft;

		// Token: 0x0400E8EF RID: 59631
		[Token(Token = "0x400E8EF")]
		[FieldOffset(Offset = "0x58")]
		public GameObject NormalContainer;

		// Token: 0x0400E8F0 RID: 59632
		[Token(Token = "0x400E8F0")]
		[FieldOffset(Offset = "0x60")]
		public UILabel ItemNameLabel_Normal;

		// Token: 0x0400E8F1 RID: 59633
		[Token(Token = "0x400E8F1")]
		[FieldOffset(Offset = "0x68")]
		public UISprite ItemNormalBG;

		// Token: 0x0400E8F2 RID: 59634
		[Token(Token = "0x400E8F2")]
		[FieldOffset(Offset = "0x70")]
		public BaseItemView ItemIconContainer;

		// Token: 0x0400E8F3 RID: 59635
		[Token(Token = "0x400E8F3")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ReceivedHintNormal;

		// Token: 0x0400E8F4 RID: 59636
		[Token(Token = "0x400E8F4")]
		[FieldOffset(Offset = "0x80")]
		public GameObject SpecialContainer;

		// Token: 0x0400E8F5 RID: 59637
		[Token(Token = "0x400E8F5")]
		[FieldOffset(Offset = "0x88")]
		public GameObject ReceivedHintSpecial;

		// Token: 0x0400E8F6 RID: 59638
		[Token(Token = "0x400E8F6")]
		[FieldOffset(Offset = "0x90")]
		public UISprite ItemSpecialBG;

		// Token: 0x0400E8F7 RID: 59639
		[Token(Token = "0x400E8F7")]
		[FieldOffset(Offset = "0x98")]
		public BaseItemView ItemIconContainer_Special;

		// Token: 0x0400E8F8 RID: 59640
		[Token(Token = "0x400E8F8")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel ItemNameLabel_Special;

		// Token: 0x0400E8F9 RID: 59641
		[Token(Token = "0x400E8F9")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject GetLabel;
	}
}
