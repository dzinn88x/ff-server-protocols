using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021E8 RID: 8680
	[Token(Token = "0x20021E8")]
	public class UIFFWSMainPageView : UIBaseView
	{
		// Token: 0x0600BEE1 RID: 48865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEE1")]
		[Address(RVA = "0x2282C80", Offset = "0x2282C80", VA = "0x7BBCA82C80", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEE2 RID: 48866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEE2")]
		[Address(RVA = "0x2283858", Offset = "0x2283858", VA = "0x7BBCA83858")]
		public UIFFWSMainPageView()
		{
		}

		// Token: 0x0400CC84 RID: 52356
		[Token(Token = "0x400CC84")]
		[FieldOffset(Offset = "0x20")]
		public Animation VFX_AnimSwitchPage;

		// Token: 0x0400CC85 RID: 52357
		[Token(Token = "0x400CC85")]
		[FieldOffset(Offset = "0x28")]
		public GameObject GoVfxGuessNormal;

		// Token: 0x0400CC86 RID: 52358
		[Token(Token = "0x400CC86")]
		[FieldOffset(Offset = "0x30")]
		public GameObject GoVfxGuessGlow;

		// Token: 0x0400CC87 RID: 52359
		[Token(Token = "0x400CC87")]
		[FieldOffset(Offset = "0x38")]
		public Animation AnimationCharacterAwake;

		// Token: 0x0400CC88 RID: 52360
		[Token(Token = "0x400CC88")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Character01;

		// Token: 0x0400CC89 RID: 52361
		[Token(Token = "0x400CC89")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Character03;

		// Token: 0x0400CC8A RID: 52362
		[Token(Token = "0x400CC8A")]
		[FieldOffset(Offset = "0x50")]
		public MeshRenderer AndrewBefore01;

		// Token: 0x0400CC8B RID: 52363
		[Token(Token = "0x400CC8B")]
		[FieldOffset(Offset = "0x58")]
		public MeshRenderer AndrewBefore02;

		// Token: 0x0400CC8C RID: 52364
		[Token(Token = "0x400CC8C")]
		[FieldOffset(Offset = "0x60")]
		public MeshRenderer AndrewAfter01;

		// Token: 0x0400CC8D RID: 52365
		[Token(Token = "0x400CC8D")]
		[FieldOffset(Offset = "0x68")]
		public MeshRenderer AndrewAfter02;

		// Token: 0x0400CC8E RID: 52366
		[Token(Token = "0x400CC8E")]
		[FieldOffset(Offset = "0x70")]
		public MeshRenderer AndrewAfter03;

		// Token: 0x0400CC8F RID: 52367
		[Token(Token = "0x400CC8F")]
		[FieldOffset(Offset = "0x78")]
		public Transform TrCurrentPageRoot;

		// Token: 0x0400CC90 RID: 52368
		[Token(Token = "0x400CC90")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BtnClose;

		// Token: 0x0400CC91 RID: 52369
		[Token(Token = "0x400CC91")]
		[FieldOffset(Offset = "0x88")]
		public GameObject Content;

		// Token: 0x0400CC92 RID: 52370
		[Token(Token = "0x400CC92")]
		[FieldOffset(Offset = "0x90")]
		public Transform TopLeft;

		// Token: 0x0400CC93 RID: 52371
		[Token(Token = "0x400CC93")]
		[FieldOffset(Offset = "0x98")]
		public UILabel TimeLabel;

		// Token: 0x0400CC94 RID: 52372
		[Token(Token = "0x400CC94")]
		[FieldOffset(Offset = "0xA0")]
		public UIGrid GridTopLeftBtns;

		// Token: 0x0400CC95 RID: 52373
		[Token(Token = "0x400CC95")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton BtnPeakDay;

		// Token: 0x0400CC96 RID: 52374
		[Token(Token = "0x400CC96")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject PeakDayTips;

		// Token: 0x0400CC97 RID: 52375
		[Token(Token = "0x400CC97")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel PeakDayBubble;

		// Token: 0x0400CC98 RID: 52376
		[Token(Token = "0x400CC98")]
		[FieldOffset(Offset = "0xC0")]
		public TweenPosition TweenPosPeakDayBubble;

		// Token: 0x0400CC99 RID: 52377
		[Token(Token = "0x400CC99")]
		[FieldOffset(Offset = "0xC8")]
		public UIButton BtnWeb;

		// Token: 0x0400CC9A RID: 52378
		[Token(Token = "0x400CC9A")]
		[FieldOffset(Offset = "0xD0")]
		public UINetworkTextureExt TextureTitleCDN;

		// Token: 0x0400CC9B RID: 52379
		[Token(Token = "0x400CC9B")]
		[FieldOffset(Offset = "0xD8")]
		public Transform TopRight;

		// Token: 0x0400CC9C RID: 52380
		[Token(Token = "0x400CC9C")]
		[FieldOffset(Offset = "0xE0")]
		public UIButton BtnRule;

		// Token: 0x0400CC9D RID: 52381
		[Token(Token = "0x400CC9D")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton BtnToken;

		// Token: 0x0400CC9E RID: 52382
		[Token(Token = "0x400CC9E")]
		[FieldOffset(Offset = "0xF0")]
		public UISprite TokenIcon;

		// Token: 0x0400CC9F RID: 52383
		[Token(Token = "0x400CC9F")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel TokenNum;

		// Token: 0x0400CCA0 RID: 52384
		[Token(Token = "0x400CCA0")]
		[FieldOffset(Offset = "0x100")]
		public Transform TipsContainer;

		// Token: 0x0400CCA1 RID: 52385
		[Token(Token = "0x400CCA1")]
		[FieldOffset(Offset = "0x108")]
		public UIButton BtnCup;

		// Token: 0x0400CCA2 RID: 52386
		[Token(Token = "0x400CCA2")]
		[FieldOffset(Offset = "0x110")]
		public GameObject CupTips;

		// Token: 0x0400CCA3 RID: 52387
		[Token(Token = "0x400CCA3")]
		[FieldOffset(Offset = "0x118")]
		public Transform TrGuessVFXRoot;

		// Token: 0x0400CCA4 RID: 52388
		[Token(Token = "0x400CCA4")]
		[FieldOffset(Offset = "0x120")]
		public UIButton BtnGuess;

		// Token: 0x0400CCA5 RID: 52389
		[Token(Token = "0x400CCA5")]
		[FieldOffset(Offset = "0x128")]
		public GameObject GoGuessRedPoint;

		// Token: 0x0400CCA6 RID: 52390
		[Token(Token = "0x400CCA6")]
		[FieldOffset(Offset = "0x130")]
		public Transform TrGuessCountDown;

		// Token: 0x0400CCA7 RID: 52391
		[Token(Token = "0x400CCA7")]
		[FieldOffset(Offset = "0x138")]
		public Transform TrCharacterVFXRoot;

		// Token: 0x0400CCA8 RID: 52392
		[Token(Token = "0x400CCA8")]
		[FieldOffset(Offset = "0x140")]
		public Transform TrCharacterNormal;

		// Token: 0x0400CCA9 RID: 52393
		[Token(Token = "0x400CCA9")]
		[FieldOffset(Offset = "0x148")]
		public Transform TrCharacterAwaken;

		// Token: 0x0400CCAA RID: 52394
		[Token(Token = "0x400CCAA")]
		[FieldOffset(Offset = "0x150")]
		public UIButton BtnMission;

		// Token: 0x0400CCAB RID: 52395
		[Token(Token = "0x400CCAB")]
		[FieldOffset(Offset = "0x158")]
		public GameObject TaskTips;

		// Token: 0x0400CCAC RID: 52396
		[Token(Token = "0x400CCAC")]
		[FieldOffset(Offset = "0x160")]
		public UILabel LabelCharacterAwakenProcess;

		// Token: 0x0400CCAD RID: 52397
		[Token(Token = "0x400CCAD")]
		[FieldOffset(Offset = "0x168")]
		public Transform BottomRight;

		// Token: 0x0400CCAE RID: 52398
		[Token(Token = "0x400CCAE")]
		[FieldOffset(Offset = "0x170")]
		public UIButton BtnLive;

		// Token: 0x0400CCAF RID: 52399
		[Token(Token = "0x400CCAF")]
		[FieldOffset(Offset = "0x178")]
		public Transform TrLiveVFXRoot;

		// Token: 0x0400CCB0 RID: 52400
		[Token(Token = "0x400CCB0")]
		[FieldOffset(Offset = "0x180")]
		public Transform TrVFXLive;

		// Token: 0x0400CCB1 RID: 52401
		[Token(Token = "0x400CCB1")]
		[FieldOffset(Offset = "0x188")]
		public Transform BottomLeft;

		// Token: 0x0400CCB2 RID: 52402
		[Token(Token = "0x400CCB2")]
		[FieldOffset(Offset = "0x190")]
		public UIGrid GridBottomLeftBtns;

		// Token: 0x0400CCB3 RID: 52403
		[Token(Token = "0x400CCB3")]
		[FieldOffset(Offset = "0x198")]
		public UIButton BtnExchange;

		// Token: 0x0400CCB4 RID: 52404
		[Token(Token = "0x400CCB4")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject ExchangeTips;

		// Token: 0x0400CCB5 RID: 52405
		[Token(Token = "0x400CCB5")]
		[FieldOffset(Offset = "0x1A8")]
		public UIButton BtnCheckIn;

		// Token: 0x0400CCB6 RID: 52406
		[Token(Token = "0x400CCB6")]
		[FieldOffset(Offset = "0x1B0")]
		public GameObject CheckInTips;
	}
}
