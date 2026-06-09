using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021E5 RID: 8677
	[Token(Token = "0x20021E5")]
	public class UIFFWSGuessView : UIBaseView
	{
		// Token: 0x0600BEDB RID: 48859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEDB")]
		[Address(RVA = "0x227B9C0", Offset = "0x227B9C0", VA = "0x7BBCA7B9C0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEDC RID: 48860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEDC")]
		[Address(RVA = "0x227C5A0", Offset = "0x227C5A0", VA = "0x7BBCA7C5A0")]
		public UIFFWSGuessView()
		{
		}

		// Token: 0x0400CC47 RID: 52295
		[Token(Token = "0x400CC47")]
		[FieldOffset(Offset = "0x20")]
		public Animation VFX_AnimSwitchPage;

		// Token: 0x0400CC48 RID: 52296
		[Token(Token = "0x400CC48")]
		[FieldOffset(Offset = "0x28")]
		public GameObject GoVfxGuessNormal;

		// Token: 0x0400CC49 RID: 52297
		[Token(Token = "0x400CC49")]
		[FieldOffset(Offset = "0x30")]
		public GameObject GoVfxGuessGlow;

		// Token: 0x0400CC4A RID: 52298
		[Token(Token = "0x400CC4A")]
		[FieldOffset(Offset = "0x38")]
		public Animation AnimationCharacterAwake;

		// Token: 0x0400CC4B RID: 52299
		[Token(Token = "0x400CC4B")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Character01;

		// Token: 0x0400CC4C RID: 52300
		[Token(Token = "0x400CC4C")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Character03;

		// Token: 0x0400CC4D RID: 52301
		[Token(Token = "0x400CC4D")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnClose;

		// Token: 0x0400CC4E RID: 52302
		[Token(Token = "0x400CC4E")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Content;

		// Token: 0x0400CC4F RID: 52303
		[Token(Token = "0x400CC4F")]
		[FieldOffset(Offset = "0x60")]
		public GameObject GoMaskFirstEnterTurorial;

		// Token: 0x0400CC50 RID: 52304
		[Token(Token = "0x400CC50")]
		[FieldOffset(Offset = "0x68")]
		public UIButton BtnFirstEnterTurorial;

		// Token: 0x0400CC51 RID: 52305
		[Token(Token = "0x400CC51")]
		[FieldOffset(Offset = "0x70")]
		public Transform TopLeft;

		// Token: 0x0400CC52 RID: 52306
		[Token(Token = "0x400CC52")]
		[FieldOffset(Offset = "0x78")]
		public UINetworkTextureExt TextureTitleCDN;

		// Token: 0x0400CC53 RID: 52307
		[Token(Token = "0x400CC53")]
		[FieldOffset(Offset = "0x80")]
		public Transform TopRight;

		// Token: 0x0400CC54 RID: 52308
		[Token(Token = "0x400CC54")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BtnRule;

		// Token: 0x0400CC55 RID: 52309
		[Token(Token = "0x400CC55")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnToken;

		// Token: 0x0400CC56 RID: 52310
		[Token(Token = "0x400CC56")]
		[FieldOffset(Offset = "0x98")]
		public UISprite TokenIcon;

		// Token: 0x0400CC57 RID: 52311
		[Token(Token = "0x400CC57")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel TokenNum;

		// Token: 0x0400CC58 RID: 52312
		[Token(Token = "0x400CC58")]
		[FieldOffset(Offset = "0xA8")]
		public Transform TipsContainer;

		// Token: 0x0400CC59 RID: 52313
		[Token(Token = "0x400CC59")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton BtnGoToExchange;

		// Token: 0x0400CC5A RID: 52314
		[Token(Token = "0x400CC5A")]
		[FieldOffset(Offset = "0xB8")]
		public UIGrid GridRounds;

		// Token: 0x0400CC5B RID: 52315
		[Token(Token = "0x400CC5B")]
		[FieldOffset(Offset = "0xC0")]
		public UIWidget WidgetFirstEnterTutorial;

		// Token: 0x0400CC5C RID: 52316
		[Token(Token = "0x400CC5C")]
		[FieldOffset(Offset = "0xC8")]
		public UIGrid GridTeams;

		// Token: 0x0400CC5D RID: 52317
		[Token(Token = "0x400CC5D")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite SpriteVS;

		// Token: 0x0400CC5E RID: 52318
		[Token(Token = "0x400CC5E")]
		[FieldOffset(Offset = "0xD8")]
		public TweenAlpha TweenAlphaVS;

		// Token: 0x0400CC5F RID: 52319
		[Token(Token = "0x400CC5F")]
		[FieldOffset(Offset = "0xE0")]
		public TweenPosition TweenAIWin;

		// Token: 0x0400CC60 RID: 52320
		[Token(Token = "0x400CC60")]
		[FieldOffset(Offset = "0xE8")]
		public TweenScale TweenAILose;

		// Token: 0x0400CC61 RID: 52321
		[Token(Token = "0x400CC61")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel LabelTeamAIPIck;

		// Token: 0x0400CC62 RID: 52322
		[Token(Token = "0x400CC62")]
		[FieldOffset(Offset = "0xF8")]
		public UINetworkTextureExt TextureTeamAIPickCDN;

		// Token: 0x0400CC63 RID: 52323
		[Token(Token = "0x400CC63")]
		[FieldOffset(Offset = "0x100")]
		public UISprite SpriteNullAIPick;

		// Token: 0x0400CC64 RID: 52324
		[Token(Token = "0x400CC64")]
		[FieldOffset(Offset = "0x108")]
		public TweenPosition TweenPlayerWin;

		// Token: 0x0400CC65 RID: 52325
		[Token(Token = "0x400CC65")]
		[FieldOffset(Offset = "0x110")]
		public TweenScale TweenPlayerLose;

		// Token: 0x0400CC66 RID: 52326
		[Token(Token = "0x400CC66")]
		[FieldOffset(Offset = "0x118")]
		public UILabel LabelTeamPlayerPick;

		// Token: 0x0400CC67 RID: 52327
		[Token(Token = "0x400CC67")]
		[FieldOffset(Offset = "0x120")]
		public UINetworkTextureExt TextureTeamPlayerPickCDN;

		// Token: 0x0400CC68 RID: 52328
		[Token(Token = "0x400CC68")]
		[FieldOffset(Offset = "0x128")]
		public UISprite SpriteNullPlayerPick;

		// Token: 0x0400CC69 RID: 52329
		[Token(Token = "0x400CC69")]
		[FieldOffset(Offset = "0x130")]
		public UIButton BtnAward;

		// Token: 0x0400CC6A RID: 52330
		[Token(Token = "0x400CC6A")]
		[FieldOffset(Offset = "0x138")]
		public GameObject GoCanClaim;

		// Token: 0x0400CC6B RID: 52331
		[Token(Token = "0x400CC6B")]
		[FieldOffset(Offset = "0x140")]
		public UILabel LabelAIPoints;

		// Token: 0x0400CC6C RID: 52332
		[Token(Token = "0x400CC6C")]
		[FieldOffset(Offset = "0x148")]
		public UILabel LabelPlayerPoints;

		// Token: 0x0400CC6D RID: 52333
		[Token(Token = "0x400CC6D")]
		[FieldOffset(Offset = "0x150")]
		public UIButton BtnGuess;

		// Token: 0x0400CC6E RID: 52334
		[Token(Token = "0x400CC6E")]
		[FieldOffset(Offset = "0x158")]
		public UISprite SpriteTeamDetail;

		// Token: 0x0400CC6F RID: 52335
		[Token(Token = "0x400CC6F")]
		[FieldOffset(Offset = "0x160")]
		public Transform TrCountDownRoot;

		// Token: 0x0400CC70 RID: 52336
		[Token(Token = "0x400CC70")]
		[FieldOffset(Offset = "0x168")]
		public GameObject TrGuessed;

		// Token: 0x0400CC71 RID: 52337
		[Token(Token = "0x400CC71")]
		[FieldOffset(Offset = "0x170")]
		public UILabel LabelGuessedTip;

		// Token: 0x0400CC72 RID: 52338
		[Token(Token = "0x400CC72")]
		[FieldOffset(Offset = "0x178")]
		public GameObject TrGuessTimeOut;

		// Token: 0x0400CC73 RID: 52339
		[Token(Token = "0x400CC73")]
		[FieldOffset(Offset = "0x180")]
		public GameObject GoNoLive;

		// Token: 0x0400CC74 RID: 52340
		[Token(Token = "0x400CC74")]
		[FieldOffset(Offset = "0x188")]
		public UILabel LabelTimeOutNoLive;

		// Token: 0x0400CC75 RID: 52341
		[Token(Token = "0x400CC75")]
		[FieldOffset(Offset = "0x190")]
		public GameObject GoLive;

		// Token: 0x0400CC76 RID: 52342
		[Token(Token = "0x400CC76")]
		[FieldOffset(Offset = "0x198")]
		public UIButton BtnGoToLive;

		// Token: 0x0400CC77 RID: 52343
		[Token(Token = "0x400CC77")]
		[FieldOffset(Offset = "0x1A0")]
		public UILabel LabelTimeOut;

		// Token: 0x0400CC78 RID: 52344
		[Token(Token = "0x400CC78")]
		[FieldOffset(Offset = "0x1A8")]
		public UILabel LabelWatchLive;
	}
}
