using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024C3 RID: 9411
	[Token(Token = "0x20024C3")]
	public class UIRankComparisonView : UIBaseView
	{
		// Token: 0x0600C496 RID: 50326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C496")]
		[Address(RVA = "0x1E0BD50", Offset = "0x1E0BD50", VA = "0x7BBC60BD50", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C497 RID: 50327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C497")]
		[Address(RVA = "0x1E0C264", Offset = "0x1E0C264", VA = "0x7BBC60C264")]
		public UIRankComparisonView()
		{
		}

		// Token: 0x0400EF48 RID: 61256
		[Token(Token = "0x400EF48")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BgBtn;

		// Token: 0x0400EF49 RID: 61257
		[Token(Token = "0x400EF49")]
		[FieldOffset(Offset = "0x28")]
		public UILabel titleTxt;

		// Token: 0x0400EF4A RID: 61258
		[Token(Token = "0x400EF4A")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ExtendFriendsTxt;

		// Token: 0x0400EF4B RID: 61259
		[Token(Token = "0x400EF4B")]
		[FieldOffset(Offset = "0x38")]
		public UISprite RankIcon;

		// Token: 0x0400EF4C RID: 61260
		[Token(Token = "0x400EF4C")]
		[FieldOffset(Offset = "0x40")]
		public UILabel RankName;

		// Token: 0x0400EF4D RID: 61261
		[Token(Token = "0x400EF4D")]
		[FieldOffset(Offset = "0x48")]
		public UILabel RankScore;

		// Token: 0x0400EF4E RID: 61262
		[Token(Token = "0x400EF4E")]
		[FieldOffset(Offset = "0x50")]
		public ParticleSystem RankNormalEffect;

		// Token: 0x0400EF4F RID: 61263
		[Token(Token = "0x400EF4F")]
		[FieldOffset(Offset = "0x58")]
		public UIGrid FriendsGrid;

		// Token: 0x0400EF50 RID: 61264
		[Token(Token = "0x400EF50")]
		[FieldOffset(Offset = "0x60")]
		public UIWidget ItemContainer1;

		// Token: 0x0400EF51 RID: 61265
		[Token(Token = "0x400EF51")]
		[FieldOffset(Offset = "0x68")]
		public UIWidget ItemContainer2;

		// Token: 0x0400EF52 RID: 61266
		[Token(Token = "0x400EF52")]
		[FieldOffset(Offset = "0x70")]
		public UIWidget ItemContainer3;

		// Token: 0x0400EF53 RID: 61267
		[Token(Token = "0x400EF53")]
		[FieldOffset(Offset = "0x78")]
		public UIWidget ItemContainer4;

		// Token: 0x0400EF54 RID: 61268
		[Token(Token = "0x400EF54")]
		[FieldOffset(Offset = "0x80")]
		public UIWidget ItemContainer5;

		// Token: 0x0400EF55 RID: 61269
		[Token(Token = "0x400EF55")]
		[FieldOffset(Offset = "0x88")]
		public UIButton GotoBtn;

		// Token: 0x0400EF56 RID: 61270
		[Token(Token = "0x400EF56")]
		[FieldOffset(Offset = "0x90")]
		public UIGrid BtnGrid;

		// Token: 0x0400EF57 RID: 61271
		[Token(Token = "0x400EF57")]
		[FieldOffset(Offset = "0x98")]
		public UIButton ShowBtn;

		// Token: 0x0400EF58 RID: 61272
		[Token(Token = "0x400EF58")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton ShareBtn;

		// Token: 0x0400EF59 RID: 61273
		[Token(Token = "0x400EF59")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel closeTxt;

		// Token: 0x0400EF5A RID: 61274
		[Token(Token = "0x400EF5A")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject ShareUI;

		// Token: 0x0400EF5B RID: 61275
		[Token(Token = "0x400EF5B")]
		[FieldOffset(Offset = "0xB8")]
		public UISprite FreeFireLogo;
	}
}
