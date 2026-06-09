using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200245C RID: 9308
	[Token(Token = "0x200245C")]
	public class UINewPlayerPathItemView : UIBaseView
	{
		// Token: 0x0600C3C8 RID: 50120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3C8")]
		[Address(RVA = "0x1AF9B10", Offset = "0x1AF9B10", VA = "0x7BBC2F9B10", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3C9 RID: 50121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3C9")]
		[Address(RVA = "0x1AFA1CC", Offset = "0x1AFA1CC", VA = "0x7BBC2FA1CC")]
		public UINewPlayerPathItemView()
		{
		}

		// Token: 0x0400E8C9 RID: 59593
		[Token(Token = "0x400E8C9")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400E8CA RID: 59594
		[Token(Token = "0x400E8CA")]
		[FieldOffset(Offset = "0x28")]
		public UISprite HighLightEff;

		// Token: 0x0400E8CB RID: 59595
		[Token(Token = "0x400E8CB")]
		[FieldOffset(Offset = "0x30")]
		public GameObject BoxIconWaitClaim;

		// Token: 0x0400E8CC RID: 59596
		[Token(Token = "0x400E8CC")]
		[FieldOffset(Offset = "0x38")]
		public GameObject GPP_CanClaimVFX;

		// Token: 0x0400E8CD RID: 59597
		[Token(Token = "0x400E8CD")]
		[FieldOffset(Offset = "0x40")]
		public GameObject BoxIconOpened;

		// Token: 0x0400E8CE RID: 59598
		[Token(Token = "0x400E8CE")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BoxIconLocked;

		// Token: 0x0400E8CF RID: 59599
		[Token(Token = "0x400E8CF")]
		[FieldOffset(Offset = "0x50")]
		public UILabel DayCountLabel;

		// Token: 0x0400E8D0 RID: 59600
		[Token(Token = "0x400E8D0")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Container;

		// Token: 0x0400E8D1 RID: 59601
		[Token(Token = "0x400E8D1")]
		[FieldOffset(Offset = "0x60")]
		public GameObject LockState;

		// Token: 0x0400E8D2 RID: 59602
		[Token(Token = "0x400E8D2")]
		[FieldOffset(Offset = "0x68")]
		public UIButton LockPreviewButton;

		// Token: 0x0400E8D3 RID: 59603
		[Token(Token = "0x400E8D3")]
		[FieldOffset(Offset = "0x70")]
		public GameObject NormalState;

		// Token: 0x0400E8D4 RID: 59604
		[Token(Token = "0x400E8D4")]
		[FieldOffset(Offset = "0x78")]
		public UILabel ProgressLabel;

		// Token: 0x0400E8D5 RID: 59605
		[Token(Token = "0x400E8D5")]
		[FieldOffset(Offset = "0x80")]
		public GameObject minline;

		// Token: 0x0400E8D6 RID: 59606
		[Token(Token = "0x400E8D6")]
		[FieldOffset(Offset = "0x88")]
		public Transform ProgressEffect;

		// Token: 0x0400E8D7 RID: 59607
		[Token(Token = "0x400E8D7")]
		[FieldOffset(Offset = "0x90")]
		public UISprite Foreground;

		// Token: 0x0400E8D8 RID: 59608
		[Token(Token = "0x400E8D8")]
		[FieldOffset(Offset = "0x98")]
		public UISprite BarLight;

		// Token: 0x0400E8D9 RID: 59609
		[Token(Token = "0x400E8D9")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton PreviewButton;

		// Token: 0x0400E8DA RID: 59610
		[Token(Token = "0x400E8DA")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject WaitClaimState;

		// Token: 0x0400E8DB RID: 59611
		[Token(Token = "0x400E8DB")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton ClaimButton;

		// Token: 0x0400E8DC RID: 59612
		[Token(Token = "0x400E8DC")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject ClaimRedDot;

		// Token: 0x0400E8DD RID: 59613
		[Token(Token = "0x400E8DD")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel FinishProgressLabel;

		// Token: 0x0400E8DE RID: 59614
		[Token(Token = "0x400E8DE")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject ClaimedState;

		// Token: 0x0400E8DF RID: 59615
		[Token(Token = "0x400E8DF")]
		[FieldOffset(Offset = "0xD0")]
		public UIButton ClaimedPreviewButton;

		// Token: 0x0400E8E0 RID: 59616
		[Token(Token = "0x400E8E0")]
		[FieldOffset(Offset = "0xD8")]
		public UINetworkTexture NetworkTexture;

		// Token: 0x0400E8E1 RID: 59617
		[Token(Token = "0x400E8E1")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject VFX_Today;

		// Token: 0x0400E8E2 RID: 59618
		[Token(Token = "0x400E8E2")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject TotalRedDot;

		// Token: 0x0400E8E3 RID: 59619
		[Token(Token = "0x400E8E3")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject GreyMask;

		// Token: 0x0400E8E4 RID: 59620
		[Token(Token = "0x400E8E4")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject VFX_unlock;
	}
}
