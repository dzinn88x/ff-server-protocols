using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200257C RID: 9596
	[Token(Token = "0x200257C")]
	public class UITurntableSignInView : UIBaseView
	{
		// Token: 0x0600C608 RID: 50696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C608")]
		[Address(RVA = "0x19F3E58", Offset = "0x19F3E58", VA = "0x7BBC1F3E58", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C609 RID: 50697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C609")]
		[Address(RVA = "0x19F446C", Offset = "0x19F446C", VA = "0x7BBC1F446C")]
		public UITurntableSignInView()
		{
		}

		// Token: 0x0400F689 RID: 63113
		[Token(Token = "0x400F689")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Close;

		// Token: 0x0400F68A RID: 63114
		[Token(Token = "0x400F68A")]
		[FieldOffset(Offset = "0x28")]
		public UIButton RuleButton;

		// Token: 0x0400F68B RID: 63115
		[Token(Token = "0x400F68B")]
		[FieldOffset(Offset = "0x30")]
		public UIButton TimeBtn;

		// Token: 0x0400F68C RID: 63116
		[Token(Token = "0x400F68C")]
		[FieldOffset(Offset = "0x38")]
		public UILabel TimeLabel;

		// Token: 0x0400F68D RID: 63117
		[Token(Token = "0x400F68D")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Days;

		// Token: 0x0400F68E RID: 63118
		[Token(Token = "0x400F68E")]
		[FieldOffset(Offset = "0x48")]
		public GameObject TipsContainer;

		// Token: 0x0400F68F RID: 63119
		[Token(Token = "0x400F68F")]
		[FieldOffset(Offset = "0x50")]
		public UILabel EventDesc;

		// Token: 0x0400F690 RID: 63120
		[Token(Token = "0x400F690")]
		[FieldOffset(Offset = "0x58")]
		public GameObject PeakDayContainer;

		// Token: 0x0400F691 RID: 63121
		[Token(Token = "0x400F691")]
		[FieldOffset(Offset = "0x60")]
		public UILabel PeakDayAwardDesc;

		// Token: 0x0400F692 RID: 63122
		[Token(Token = "0x400F692")]
		[FieldOffset(Offset = "0x68")]
		public GameObject PeakDayAwardCantClaime;

		// Token: 0x0400F693 RID: 63123
		[Token(Token = "0x400F693")]
		[FieldOffset(Offset = "0x70")]
		public Transform PeakDayAwardContainer;

		// Token: 0x0400F694 RID: 63124
		[Token(Token = "0x400F694")]
		[FieldOffset(Offset = "0x78")]
		public UIButton SigninBtn;

		// Token: 0x0400F695 RID: 63125
		[Token(Token = "0x400F695")]
		[FieldOffset(Offset = "0x80")]
		public UISprite SignBtnBG;

		// Token: 0x0400F696 RID: 63126
		[Token(Token = "0x400F696")]
		[FieldOffset(Offset = "0x88")]
		public UILabel SignLabel;

		// Token: 0x0400F697 RID: 63127
		[Token(Token = "0x400F697")]
		[FieldOffset(Offset = "0x90")]
		public GameObject Signed;

		// Token: 0x0400F698 RID: 63128
		[Token(Token = "0x400F698")]
		[FieldOffset(Offset = "0x98")]
		public GameObject UnSign;

		// Token: 0x0400F699 RID: 63129
		[Token(Token = "0x400F699")]
		[FieldOffset(Offset = "0xA0")]
		public TurntableAnim Turntable;

		// Token: 0x0400F69A RID: 63130
		[Token(Token = "0x400F69A")]
		[FieldOffset(Offset = "0xA8")]
		public Transform Reward1;

		// Token: 0x0400F69B RID: 63131
		[Token(Token = "0x400F69B")]
		[FieldOffset(Offset = "0xB0")]
		public Transform Reward2;

		// Token: 0x0400F69C RID: 63132
		[Token(Token = "0x400F69C")]
		[FieldOffset(Offset = "0xB8")]
		public Transform Reward3;

		// Token: 0x0400F69D RID: 63133
		[Token(Token = "0x400F69D")]
		[FieldOffset(Offset = "0xC0")]
		public Transform Reward4;

		// Token: 0x0400F69E RID: 63134
		[Token(Token = "0x400F69E")]
		[FieldOffset(Offset = "0xC8")]
		public Transform Reward5;

		// Token: 0x0400F69F RID: 63135
		[Token(Token = "0x400F69F")]
		[FieldOffset(Offset = "0xD0")]
		public Transform Reward6;

		// Token: 0x0400F6A0 RID: 63136
		[Token(Token = "0x400F6A0")]
		[FieldOffset(Offset = "0xD8")]
		public Transform Reward7;

		// Token: 0x0400F6A1 RID: 63137
		[Token(Token = "0x400F6A1")]
		[FieldOffset(Offset = "0xE0")]
		public UINetworkTexture NetworkTexture;
	}
}
