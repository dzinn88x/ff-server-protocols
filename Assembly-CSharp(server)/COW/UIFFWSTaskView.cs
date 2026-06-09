using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021EE RID: 8686
	[Token(Token = "0x20021EE")]
	public class UIFFWSTaskView : UIBaseView
	{
		// Token: 0x0600BEED RID: 48877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEED")]
		[Address(RVA = "0x1DAB21C", Offset = "0x1DAB21C", VA = "0x7BBC5AB21C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEEE RID: 48878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEEE")]
		[Address(RVA = "0x1DABAB4", Offset = "0x1DABAB4", VA = "0x7BBC5ABAB4")]
		public UIFFWSTaskView()
		{
		}

		// Token: 0x0400CCF4 RID: 52468
		[Token(Token = "0x400CCF4")]
		[FieldOffset(Offset = "0x20")]
		public Animation VFX_AnimSwitchPage;

		// Token: 0x0400CCF5 RID: 52469
		[Token(Token = "0x400CCF5")]
		[FieldOffset(Offset = "0x28")]
		public GameObject GoVfxGuessNormal;

		// Token: 0x0400CCF6 RID: 52470
		[Token(Token = "0x400CCF6")]
		[FieldOffset(Offset = "0x30")]
		public GameObject GoVfxGuessGlow;

		// Token: 0x0400CCF7 RID: 52471
		[Token(Token = "0x400CCF7")]
		[FieldOffset(Offset = "0x38")]
		public Animation AnimationCharacterAwake;

		// Token: 0x0400CCF8 RID: 52472
		[Token(Token = "0x400CCF8")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Character01;

		// Token: 0x0400CCF9 RID: 52473
		[Token(Token = "0x400CCF9")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Character03;

		// Token: 0x0400CCFA RID: 52474
		[Token(Token = "0x400CCFA")]
		[FieldOffset(Offset = "0x50")]
		public MeshRenderer AndrewBefore01;

		// Token: 0x0400CCFB RID: 52475
		[Token(Token = "0x400CCFB")]
		[FieldOffset(Offset = "0x58")]
		public MeshRenderer AndrewBefore02;

		// Token: 0x0400CCFC RID: 52476
		[Token(Token = "0x400CCFC")]
		[FieldOffset(Offset = "0x60")]
		public MeshRenderer AndrewAfter01;

		// Token: 0x0400CCFD RID: 52477
		[Token(Token = "0x400CCFD")]
		[FieldOffset(Offset = "0x68")]
		public MeshRenderer AndrewAfter02;

		// Token: 0x0400CCFE RID: 52478
		[Token(Token = "0x400CCFE")]
		[FieldOffset(Offset = "0x70")]
		public MeshRenderer AndrewAfter03;

		// Token: 0x0400CCFF RID: 52479
		[Token(Token = "0x400CCFF")]
		[FieldOffset(Offset = "0x78")]
		public UINetworkTexture TitleTexture;

		// Token: 0x0400CD00 RID: 52480
		[Token(Token = "0x400CD00")]
		[FieldOffset(Offset = "0x80")]
		public GameObject Task;

		// Token: 0x0400CD01 RID: 52481
		[Token(Token = "0x400CD01")]
		[FieldOffset(Offset = "0x88")]
		public UISprite TaskBG;

		// Token: 0x0400CD02 RID: 52482
		[Token(Token = "0x400CD02")]
		[FieldOffset(Offset = "0x90")]
		public UILabel TaskStoryLabel;

		// Token: 0x0400CD03 RID: 52483
		[Token(Token = "0x400CD03")]
		[FieldOffset(Offset = "0x98")]
		public UIGrid TaskGrid;

		// Token: 0x0400CD04 RID: 52484
		[Token(Token = "0x400CD04")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton Mask;

		// Token: 0x0400CD05 RID: 52485
		[Token(Token = "0x400CD05")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject TaskDialogueContinueHint;

		// Token: 0x0400CD06 RID: 52486
		[Token(Token = "0x400CD06")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel TaskDialogueLabel;

		// Token: 0x0400CD07 RID: 52487
		[Token(Token = "0x400CD07")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton AcceptBtn;

		// Token: 0x0400CD08 RID: 52488
		[Token(Token = "0x400CD08")]
		[FieldOffset(Offset = "0xC0")]
		public UIGrid TaskList;

		// Token: 0x0400CD09 RID: 52489
		[Token(Token = "0x400CD09")]
		[FieldOffset(Offset = "0xC8")]
		public UISprite AwakenProgressBar;

		// Token: 0x0400CD0A RID: 52490
		[Token(Token = "0x400CD0A")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel AwakenProgressPercentage;

		// Token: 0x0400CD0B RID: 52491
		[Token(Token = "0x400CD0B")]
		[FieldOffset(Offset = "0xD8")]
		public TweenPositionArc SliderEffect;

		// Token: 0x0400CD0C RID: 52492
		[Token(Token = "0x400CD0C")]
		[FieldOffset(Offset = "0xE0")]
		public Transform EffectToPos;

		// Token: 0x0400CD0D RID: 52493
		[Token(Token = "0x400CD0D")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject ProgressIncreaseEffect;

		// Token: 0x0400CD0E RID: 52494
		[Token(Token = "0x400CD0E")]
		[FieldOffset(Offset = "0xF0")]
		public Transform EffectFromPos;

		// Token: 0x0400CD0F RID: 52495
		[Token(Token = "0x400CD0F")]
		[FieldOffset(Offset = "0xF8")]
		public UINetworkTexture AvatarTexture;

		// Token: 0x0400CD10 RID: 52496
		[Token(Token = "0x400CD10")]
		[FieldOffset(Offset = "0x100")]
		public UINetworkTexture BGTexture;

		// Token: 0x0400CD11 RID: 52497
		[Token(Token = "0x400CD11")]
		[FieldOffset(Offset = "0x108")]
		public UIButton BtnRule;

		// Token: 0x0400CD12 RID: 52498
		[Token(Token = "0x400CD12")]
		[FieldOffset(Offset = "0x110")]
		public UIButton ShopEntrance;

		// Token: 0x0400CD13 RID: 52499
		[Token(Token = "0x400CD13")]
		[FieldOffset(Offset = "0x118")]
		public UIButton Token;

		// Token: 0x0400CD14 RID: 52500
		[Token(Token = "0x400CD14")]
		[FieldOffset(Offset = "0x120")]
		public UISprite TokenIcon;

		// Token: 0x0400CD15 RID: 52501
		[Token(Token = "0x400CD15")]
		[FieldOffset(Offset = "0x128")]
		public UILabel TokenNum;

		// Token: 0x0400CD16 RID: 52502
		[Token(Token = "0x400CD16")]
		[FieldOffset(Offset = "0x130")]
		public UIButton BtnClose;
	}
}
