using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021A5 RID: 8613
	[Token(Token = "0x20021A5")]
	public class UIDiceGameMainView : UIBaseView
	{
		// Token: 0x0600BE5A RID: 48730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE5A")]
		[Address(RVA = "0x2203744", Offset = "0x2203744", VA = "0x7BBCA03744", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE5B RID: 48731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE5B")]
		[Address(RVA = "0x2204548", Offset = "0x2204548", VA = "0x7BBCA04548")]
		public UIDiceGameMainView()
		{
		}

		// Token: 0x0400C917 RID: 51479
		[Token(Token = "0x400C917")]
		[FieldOffset(Offset = "0x20")]
		public Animator MainAnimator;

		// Token: 0x0400C918 RID: 51480
		[Token(Token = "0x400C918")]
		[FieldOffset(Offset = "0x28")]
		public GameObject TaskInfo;

		// Token: 0x0400C919 RID: 51481
		[Token(Token = "0x400C919")]
		[FieldOffset(Offset = "0x30")]
		public UIButton TaskBtn;

		// Token: 0x0400C91A RID: 51482
		[Token(Token = "0x400C91A")]
		[FieldOffset(Offset = "0x38")]
		public UILabel TaskStateDesc;

		// Token: 0x0400C91B RID: 51483
		[Token(Token = "0x400C91B")]
		[FieldOffset(Offset = "0x40")]
		public GameObject TaskReceivedObj;

		// Token: 0x0400C91C RID: 51484
		[Token(Token = "0x400C91C")]
		[FieldOffset(Offset = "0x48")]
		public GameObject TaskCanReceiveObj;

		// Token: 0x0400C91D RID: 51485
		[Token(Token = "0x400C91D")]
		[FieldOffset(Offset = "0x50")]
		public UINetworkTexture TitleCDN;

		// Token: 0x0400C91E RID: 51486
		[Token(Token = "0x400C91E")]
		[FieldOffset(Offset = "0x58")]
		public GameObject RuleVFX;

		// Token: 0x0400C91F RID: 51487
		[Token(Token = "0x400C91F")]
		[FieldOffset(Offset = "0x60")]
		public UIButton RuleBtn;

		// Token: 0x0400C920 RID: 51488
		[Token(Token = "0x400C920")]
		[FieldOffset(Offset = "0x68")]
		public Transform GuidePos1;

		// Token: 0x0400C921 RID: 51489
		[Token(Token = "0x400C921")]
		[FieldOffset(Offset = "0x70")]
		public UIButton QuestBtn;

		// Token: 0x0400C922 RID: 51490
		[Token(Token = "0x400C922")]
		[FieldOffset(Offset = "0x78")]
		public Transform DiceSprTrans;

		// Token: 0x0400C923 RID: 51491
		[Token(Token = "0x400C923")]
		[FieldOffset(Offset = "0x80")]
		public Transform TokenSprTrans;

		// Token: 0x0400C924 RID: 51492
		[Token(Token = "0x400C924")]
		[FieldOffset(Offset = "0x88")]
		public UIProgressBar PhaseProgress;

		// Token: 0x0400C925 RID: 51493
		[Token(Token = "0x400C925")]
		[FieldOffset(Offset = "0x90")]
		public TweenProgressBar TweenProgressBar;

		// Token: 0x0400C926 RID: 51494
		[Token(Token = "0x400C926")]
		[FieldOffset(Offset = "0x98")]
		public DiceGamePhaseRwdItemController PhaseRewardItem1;

		// Token: 0x0400C927 RID: 51495
		[Token(Token = "0x400C927")]
		[FieldOffset(Offset = "0xA0")]
		public DiceGamePhaseRwdItemController PhaseRewardItem2;

		// Token: 0x0400C928 RID: 51496
		[Token(Token = "0x400C928")]
		[FieldOffset(Offset = "0xA8")]
		public DiceGamePhaseRwdItemController PhaseRewardItem3;

		// Token: 0x0400C929 RID: 51497
		[Token(Token = "0x400C929")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite DiceSpr;

		// Token: 0x0400C92A RID: 51498
		[Token(Token = "0x400C92A")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel DiceCnt;

		// Token: 0x0400C92B RID: 51499
		[Token(Token = "0x400C92B")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton DiceInfoBtn;

		// Token: 0x0400C92C RID: 51500
		[Token(Token = "0x400C92C")]
		[FieldOffset(Offset = "0xC8")]
		public UISprite TokenSpr;

		// Token: 0x0400C92D RID: 51501
		[Token(Token = "0x400C92D")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel TokenCnt;

		// Token: 0x0400C92E RID: 51502
		[Token(Token = "0x400C92E")]
		[FieldOffset(Offset = "0xD8")]
		public UIButton TokenInfoBtn;

		// Token: 0x0400C92F RID: 51503
		[Token(Token = "0x400C92F")]
		[FieldOffset(Offset = "0xE0")]
		public UIButton BtnClose;

		// Token: 0x0400C930 RID: 51504
		[Token(Token = "0x400C930")]
		[FieldOffset(Offset = "0xE8")]
		public UISprite CosumeDiceSpr;

		// Token: 0x0400C931 RID: 51505
		[Token(Token = "0x400C931")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel DiceConsumeCnt;

		// Token: 0x0400C932 RID: 51506
		[Token(Token = "0x400C932")]
		[FieldOffset(Offset = "0xF8")]
		public UIButton RollBtn;

		// Token: 0x0400C933 RID: 51507
		[Token(Token = "0x400C933")]
		[FieldOffset(Offset = "0x100")]
		public Transform GuidePos2;

		// Token: 0x0400C934 RID: 51508
		[Token(Token = "0x400C934")]
		[FieldOffset(Offset = "0x108")]
		public GameObject GuideInfo;

		// Token: 0x0400C935 RID: 51509
		[Token(Token = "0x400C935")]
		[FieldOffset(Offset = "0x110")]
		public UILabel GuideLabel;

		// Token: 0x0400C936 RID: 51510
		[Token(Token = "0x400C936")]
		[FieldOffset(Offset = "0x118")]
		public GameObject GlassBgRoot;

		// Token: 0x0400C937 RID: 51511
		[Token(Token = "0x400C937")]
		[FieldOffset(Offset = "0x120")]
		public GameObject AnimationRoot;

		// Token: 0x0400C938 RID: 51512
		[Token(Token = "0x400C938")]
		[FieldOffset(Offset = "0x128")]
		public GameObject RollDiceRoot;

		// Token: 0x0400C939 RID: 51513
		[Token(Token = "0x400C939")]
		[FieldOffset(Offset = "0x130")]
		public UIButton DiceAnimMask;

		// Token: 0x0400C93A RID: 51514
		[Token(Token = "0x400C93A")]
		[FieldOffset(Offset = "0x138")]
		public GameObject RollDiceAnim;

		// Token: 0x0400C93B RID: 51515
		[Token(Token = "0x400C93B")]
		[FieldOffset(Offset = "0x140")]
		public Animator DiceRollAnimator;

		// Token: 0x0400C93C RID: 51516
		[Token(Token = "0x400C93C")]
		[FieldOffset(Offset = "0x148")]
		public GameObject RuleDetail;

		// Token: 0x0400C93D RID: 51517
		[Token(Token = "0x400C93D")]
		[FieldOffset(Offset = "0x150")]
		public UIButton CloseRuleBtn;

		// Token: 0x0400C93E RID: 51518
		[Token(Token = "0x400C93E")]
		[FieldOffset(Offset = "0x158")]
		public UILabel StartPointRule;

		// Token: 0x0400C93F RID: 51519
		[Token(Token = "0x400C93F")]
		[FieldOffset(Offset = "0x160")]
		public UILabel MoveForwardRule;

		// Token: 0x0400C940 RID: 51520
		[Token(Token = "0x400C940")]
		[FieldOffset(Offset = "0x168")]
		public UILabel BoxRule;

		// Token: 0x0400C941 RID: 51521
		[Token(Token = "0x400C941")]
		[FieldOffset(Offset = "0x170")]
		public UILabel MoveBackRule;

		// Token: 0x0400C942 RID: 51522
		[Token(Token = "0x400C942")]
		[FieldOffset(Offset = "0x178")]
		public UILabel TokenRule;

		// Token: 0x0400C943 RID: 51523
		[Token(Token = "0x400C943")]
		[FieldOffset(Offset = "0x180")]
		public UILabel BuffRule;

		// Token: 0x0400C944 RID: 51524
		[Token(Token = "0x400C944")]
		[FieldOffset(Offset = "0x188")]
		public UILabel DiceRule;

		// Token: 0x0400C945 RID: 51525
		[Token(Token = "0x400C945")]
		[FieldOffset(Offset = "0x190")]
		public UILabel EventRule;

		// Token: 0x0400C946 RID: 51526
		[Token(Token = "0x400C946")]
		[FieldOffset(Offset = "0x198")]
		public GameObject PhaseDialogRoot;

		// Token: 0x0400C947 RID: 51527
		[Token(Token = "0x400C947")]
		[FieldOffset(Offset = "0x1A0")]
		public UIButton Mask;

		// Token: 0x0400C948 RID: 51528
		[Token(Token = "0x400C948")]
		[FieldOffset(Offset = "0x1A8")]
		public UILabel DialogLabel;

		// Token: 0x0400C949 RID: 51529
		[Token(Token = "0x400C949")]
		[FieldOffset(Offset = "0x1B0")]
		public UILabel TabCloseLabel;

		// Token: 0x0400C94A RID: 51530
		[Token(Token = "0x400C94A")]
		[FieldOffset(Offset = "0x1B8")]
		public GameObject BoardRoot;

		// Token: 0x0400C94B RID: 51531
		[Token(Token = "0x400C94B")]
		[FieldOffset(Offset = "0x1C0")]
		public GameObject SpawnVfxObj;

		// Token: 0x0400C94C RID: 51532
		[Token(Token = "0x400C94C")]
		[FieldOffset(Offset = "0x1C8")]
		public Animator SpawnVfxAnim;

		// Token: 0x0400C94D RID: 51533
		[Token(Token = "0x400C94D")]
		[FieldOffset(Offset = "0x1D0")]
		public Animation BuffInfoAnim;

		// Token: 0x0400C94E RID: 51534
		[Token(Token = "0x400C94E")]
		[FieldOffset(Offset = "0x1D8")]
		public UISprite BuffNormalISpr;

		// Token: 0x0400C94F RID: 51535
		[Token(Token = "0x400C94F")]
		[FieldOffset(Offset = "0x1E0")]
		public UISprite CurBuffSpr;

		// Token: 0x0400C950 RID: 51536
		[Token(Token = "0x400C950")]
		[FieldOffset(Offset = "0x1E8")]
		public UILabel BuffRemainLabel;

		// Token: 0x0400C951 RID: 51537
		[Token(Token = "0x400C951")]
		[FieldOffset(Offset = "0x1F0")]
		public Transform SpwanPos;

		// Token: 0x0400C952 RID: 51538
		[Token(Token = "0x400C952")]
		[FieldOffset(Offset = "0x1F8")]
		public GameObject StartAnimRoot;
	}
}
