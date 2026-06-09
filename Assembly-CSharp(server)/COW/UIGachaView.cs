using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200222E RID: 8750
	[Token(Token = "0x200222E")]
	public class UIGachaView : UIBaseView
	{
		// Token: 0x0600BF6D RID: 49005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF6D")]
		[Address(RVA = "0x1FAFCD8", Offset = "0x1FAFCD8", VA = "0x7BBC7AFCD8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF6E RID: 49006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF6E")]
		[Address(RVA = "0x1FB0328", Offset = "0x1FB0328", VA = "0x7BBC7B0328")]
		public UIGachaView()
		{
		}

		// Token: 0x0400D096 RID: 53398
		[Token(Token = "0x400D096")]
		[FieldOffset(Offset = "0x20")]
		public Animator GachaAnimator;

		// Token: 0x0400D097 RID: 53399
		[Token(Token = "0x400D097")]
		[FieldOffset(Offset = "0x28")]
		public GameObject GaChaTab;

		// Token: 0x0400D098 RID: 53400
		[Token(Token = "0x400D098")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView TabScrollView;

		// Token: 0x0400D099 RID: 53401
		[Token(Token = "0x400D099")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid GaChaTabGrid;

		// Token: 0x0400D09A RID: 53402
		[Token(Token = "0x400D09A")]
		[FieldOffset(Offset = "0x40")]
		public GameObject UIGachaRightBorder;

		// Token: 0x0400D09B RID: 53403
		[Token(Token = "0x400D09B")]
		[FieldOffset(Offset = "0x48")]
		public UIButton SwitchBtn;

		// Token: 0x0400D09C RID: 53404
		[Token(Token = "0x400D09C")]
		[FieldOffset(Offset = "0x50")]
		public GameObject SwitchToGunSpr;

		// Token: 0x0400D09D RID: 53405
		[Token(Token = "0x400D09D")]
		[FieldOffset(Offset = "0x58")]
		public GameObject SwitchToPersonSpr;

		// Token: 0x0400D09E RID: 53406
		[Token(Token = "0x400D09E")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ChangeSceneMask;

		// Token: 0x0400D09F RID: 53407
		[Token(Token = "0x400D09F")]
		[FieldOffset(Offset = "0x68")]
		public UINetworkTexture NetworkTexture;

		// Token: 0x0400D0A0 RID: 53408
		[Token(Token = "0x400D0A0")]
		[FieldOffset(Offset = "0x70")]
		public Transform ContentPanel;

		// Token: 0x0400D0A1 RID: 53409
		[Token(Token = "0x400D0A1")]
		[FieldOffset(Offset = "0x78")]
		public UIButton InterfaceContentMask;

		// Token: 0x0400D0A2 RID: 53410
		[Token(Token = "0x400D0A2")]
		[FieldOffset(Offset = "0x80")]
		public GameObject InterfaceContetnMaskLabel;

		// Token: 0x0400D0A3 RID: 53411
		[Token(Token = "0x400D0A3")]
		[FieldOffset(Offset = "0x88")]
		public UIButton InterfaceMask;

		// Token: 0x0400D0A4 RID: 53412
		[Token(Token = "0x400D0A4")]
		[FieldOffset(Offset = "0x90")]
		public GameObject UI3DPanel;

		// Token: 0x0400D0A5 RID: 53413
		[Token(Token = "0x400D0A5")]
		[FieldOffset(Offset = "0x98")]
		public GameObject InterfaceMaskLabel;

		// Token: 0x0400D0A6 RID: 53414
		[Token(Token = "0x400D0A6")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject Props;

		// Token: 0x0400D0A7 RID: 53415
		[Token(Token = "0x400D0A7")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton PropsButton;

		// Token: 0x0400D0A8 RID: 53416
		[Token(Token = "0x400D0A8")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject CouponTipsContainer;

		// Token: 0x0400D0A9 RID: 53417
		[Token(Token = "0x400D0A9")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton MaskPanel;

		// Token: 0x0400D0AA RID: 53418
		[Token(Token = "0x400D0AA")]
		[FieldOffset(Offset = "0xC0")]
		public UITable Table;

		// Token: 0x0400D0AB RID: 53419
		[Token(Token = "0x400D0AB")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject item1;

		// Token: 0x0400D0AC RID: 53420
		[Token(Token = "0x400D0AC")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject item2;

		// Token: 0x0400D0AD RID: 53421
		[Token(Token = "0x400D0AD")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject item3;

		// Token: 0x0400D0AE RID: 53422
		[Token(Token = "0x400D0AE")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject MoreLabel;

		// Token: 0x0400D0AF RID: 53423
		[Token(Token = "0x400D0AF")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel CurCouponCnt;
	}
}
