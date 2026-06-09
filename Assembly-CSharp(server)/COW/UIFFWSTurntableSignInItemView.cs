using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021EF RID: 8687
	[Token(Token = "0x20021EF")]
	public class UIFFWSTurntableSignInItemView : UIBaseView
	{
		// Token: 0x0600BEEF RID: 48879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEEF")]
		[Address(RVA = "0x1DB0930", Offset = "0x1DB0930", VA = "0x7BBC5B0930", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEF0 RID: 48880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEF0")]
		[Address(RVA = "0x1DB0CA4", Offset = "0x1DB0CA4", VA = "0x7BBC5B0CA4")]
		public UIFFWSTurntableSignInItemView()
		{
		}

		// Token: 0x0400CD17 RID: 52503
		[Token(Token = "0x400CD17")]
		[FieldOffset(Offset = "0x20")]
		public BaseItemView BaseItemView;

		// Token: 0x0400CD18 RID: 52504
		[Token(Token = "0x400CD18")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ItemBtn;

		// Token: 0x0400CD19 RID: 52505
		[Token(Token = "0x400CD19")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Rare;

		// Token: 0x0400CD1A RID: 52506
		[Token(Token = "0x400CD1A")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Light;

		// Token: 0x0400CD1B RID: 52507
		[Token(Token = "0x400CD1B")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Count;

		// Token: 0x0400CD1C RID: 52508
		[Token(Token = "0x400CD1C")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Sign;

		// Token: 0x0400CD1D RID: 52509
		[Token(Token = "0x400CD1D")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Time;

		// Token: 0x0400CD1E RID: 52510
		[Token(Token = "0x400CD1E")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BigRewardEffect;

		// Token: 0x0400CD1F RID: 52511
		[Token(Token = "0x400CD1F")]
		[FieldOffset(Offset = "0x60")]
		public GameObject BigRewardVFX;

		// Token: 0x0400CD20 RID: 52512
		[Token(Token = "0x400CD20")]
		[FieldOffset(Offset = "0x68")]
		public GameObject GetRewardEffect;

		// Token: 0x0400CD21 RID: 52513
		[Token(Token = "0x400CD21")]
		[FieldOffset(Offset = "0x70")]
		public UISprite Sprite_Debris;

		// Token: 0x0400CD22 RID: 52514
		[Token(Token = "0x400CD22")]
		[FieldOffset(Offset = "0x78")]
		public UISprite SelectedBG;

		// Token: 0x0400CD23 RID: 52515
		[Token(Token = "0x400CD23")]
		[FieldOffset(Offset = "0x80")]
		public GameObject FlickerEffect;
	}
}
