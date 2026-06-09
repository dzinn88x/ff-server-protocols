using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002484 RID: 9348
	[Token(Token = "0x2002484")]
	public class UIPaymentTotalView : UIBaseView
	{
		// Token: 0x0600C418 RID: 50200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C418")]
		[Address(RVA = "0x1F3A198", Offset = "0x1F3A198", VA = "0x7BBC73A198", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C419 RID: 50201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C419")]
		[Address(RVA = "0x1F3A614", Offset = "0x1F3A614", VA = "0x7BBC73A614")]
		public UIPaymentTotalView()
		{
		}

		// Token: 0x0400EAD7 RID: 60119
		[Token(Token = "0x400EAD7")]
		[FieldOffset(Offset = "0x20")]
		public UIButton GotoButton;

		// Token: 0x0400EAD8 RID: 60120
		[Token(Token = "0x400EAD8")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TopUpInTotalLabel;

		// Token: 0x0400EAD9 RID: 60121
		[Token(Token = "0x400EAD9")]
		[FieldOffset(Offset = "0x30")]
		public UILabel TopUpInTotalLabel_1;

		// Token: 0x0400EADA RID: 60122
		[Token(Token = "0x400EADA")]
		[FieldOffset(Offset = "0x38")]
		public UILabel TopUpInTotalLabel_2;

		// Token: 0x0400EADB RID: 60123
		[Token(Token = "0x400EADB")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ProgressBarContainer;

		// Token: 0x0400EADC RID: 60124
		[Token(Token = "0x400EADC")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ProgressDetailLabel_1;

		// Token: 0x0400EADD RID: 60125
		[Token(Token = "0x400EADD")]
		[FieldOffset(Offset = "0x50")]
		public UISprite ProgressDetailSprite_1;

		// Token: 0x0400EADE RID: 60126
		[Token(Token = "0x400EADE")]
		[FieldOffset(Offset = "0x58")]
		public UILabel ProgressDetailLabel_2;

		// Token: 0x0400EADF RID: 60127
		[Token(Token = "0x400EADF")]
		[FieldOffset(Offset = "0x60")]
		public UISprite ProgressDetailSprite_2;

		// Token: 0x0400EAE0 RID: 60128
		[Token(Token = "0x400EAE0")]
		[FieldOffset(Offset = "0x68")]
		public UILabel ProgressDetailLabel_3;

		// Token: 0x0400EAE1 RID: 60129
		[Token(Token = "0x400EAE1")]
		[FieldOffset(Offset = "0x70")]
		public UISprite ProgressDetailSprite_3;

		// Token: 0x0400EAE2 RID: 60130
		[Token(Token = "0x400EAE2")]
		[FieldOffset(Offset = "0x78")]
		public UIWidget ProgressBarLeft;

		// Token: 0x0400EAE3 RID: 60131
		[Token(Token = "0x400EAE3")]
		[FieldOffset(Offset = "0x80")]
		public UIWidget ProgressBarRight;

		// Token: 0x0400EAE4 RID: 60132
		[Token(Token = "0x400EAE4")]
		[FieldOffset(Offset = "0x88")]
		public UITexture ProgressCursor;

		// Token: 0x0400EAE5 RID: 60133
		[Token(Token = "0x400EAE5")]
		[FieldOffset(Offset = "0x90")]
		public UISprite ProgressBarSprite;

		// Token: 0x0400EAE6 RID: 60134
		[Token(Token = "0x400EAE6")]
		[FieldOffset(Offset = "0x98")]
		public UIGrid ItemsGrid;

		// Token: 0x0400EAE7 RID: 60135
		[Token(Token = "0x400EAE7")]
		[FieldOffset(Offset = "0xA0")]
		public UINetworkTextureExt CDNTexture;
	}
}
