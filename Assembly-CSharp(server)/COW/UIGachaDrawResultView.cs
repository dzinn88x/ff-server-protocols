using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200220A RID: 8714
	[Token(Token = "0x200220A")]
	internal class UIGachaDrawResultView : UIBaseView
	{
		// Token: 0x0600BF25 RID: 48933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF25")]
		[Address(RVA = "0x2160D48", Offset = "0x2160D48", VA = "0x7BBC960D48", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF26 RID: 48934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF26")]
		[Address(RVA = "0x2161580", Offset = "0x2161580", VA = "0x7BBC961580")]
		public UIGachaDrawResultView()
		{
		}

		// Token: 0x0400CE6A RID: 52842
		[Token(Token = "0x400CE6A")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BGOrangeSplashVFX;

		// Token: 0x0400CE6B RID: 52843
		[Token(Token = "0x400CE6B")]
		[FieldOffset(Offset = "0x28")]
		public GameObject BGPurpleSplashVFX;

		// Token: 0x0400CE6C RID: 52844
		[Token(Token = "0x400CE6C")]
		[FieldOffset(Offset = "0x30")]
		public GameObject BGBlueSplashVFX;

		// Token: 0x0400CE6D RID: 52845
		[Token(Token = "0x400CE6D")]
		[FieldOffset(Offset = "0x38")]
		public GameObject RewardPermanentVFX;

		// Token: 0x0400CE6E RID: 52846
		[Token(Token = "0x400CE6E")]
		[FieldOffset(Offset = "0x40")]
		public GameObject RewardOrangeVFX;

		// Token: 0x0400CE6F RID: 52847
		[Token(Token = "0x400CE6F")]
		[FieldOffset(Offset = "0x48")]
		public GameObject RewardPurpleVFX;

		// Token: 0x0400CE70 RID: 52848
		[Token(Token = "0x400CE70")]
		[FieldOffset(Offset = "0x50")]
		public GameObject RewardBlueVFX;

		// Token: 0x0400CE71 RID: 52849
		[Token(Token = "0x400CE71")]
		[FieldOffset(Offset = "0x58")]
		public Transform StartPos;

		// Token: 0x0400CE72 RID: 52850
		[Token(Token = "0x400CE72")]
		[FieldOffset(Offset = "0x60")]
		public TweenPosition TweenPosTemplate;

		// Token: 0x0400CE73 RID: 52851
		[Token(Token = "0x400CE73")]
		[FieldOffset(Offset = "0x68")]
		public TweenPosition OEndTweenPos0;

		// Token: 0x0400CE74 RID: 52852
		[Token(Token = "0x400CE74")]
		[FieldOffset(Offset = "0x70")]
		public TweenPosition FEndTweenPos0;

		// Token: 0x0400CE75 RID: 52853
		[Token(Token = "0x400CE75")]
		[FieldOffset(Offset = "0x78")]
		public TweenPosition FEndTweenPos1;

		// Token: 0x0400CE76 RID: 52854
		[Token(Token = "0x400CE76")]
		[FieldOffset(Offset = "0x80")]
		public TweenPosition FEndTweenPos2;

		// Token: 0x0400CE77 RID: 52855
		[Token(Token = "0x400CE77")]
		[FieldOffset(Offset = "0x88")]
		public TweenPosition FEndTweenPos3;

		// Token: 0x0400CE78 RID: 52856
		[Token(Token = "0x400CE78")]
		[FieldOffset(Offset = "0x90")]
		public TweenPosition FEndTweenPos4;

		// Token: 0x0400CE79 RID: 52857
		[Token(Token = "0x400CE79")]
		[FieldOffset(Offset = "0x98")]
		public TweenPosition TEndTweenPos0;

		// Token: 0x0400CE7A RID: 52858
		[Token(Token = "0x400CE7A")]
		[FieldOffset(Offset = "0xA0")]
		public TweenPosition TEndTweenPos1;

		// Token: 0x0400CE7B RID: 52859
		[Token(Token = "0x400CE7B")]
		[FieldOffset(Offset = "0xA8")]
		public TweenPosition TEndTweenPos2;

		// Token: 0x0400CE7C RID: 52860
		[Token(Token = "0x400CE7C")]
		[FieldOffset(Offset = "0xB0")]
		public TweenPosition TEndTweenPos3;

		// Token: 0x0400CE7D RID: 52861
		[Token(Token = "0x400CE7D")]
		[FieldOffset(Offset = "0xB8")]
		public TweenPosition TEndTweenPos4;

		// Token: 0x0400CE7E RID: 52862
		[Token(Token = "0x400CE7E")]
		[FieldOffset(Offset = "0xC0")]
		public TweenPosition TEndTweenPos5;

		// Token: 0x0400CE7F RID: 52863
		[Token(Token = "0x400CE7F")]
		[FieldOffset(Offset = "0xC8")]
		public TweenPosition TEndTweenPos6;

		// Token: 0x0400CE80 RID: 52864
		[Token(Token = "0x400CE80")]
		[FieldOffset(Offset = "0xD0")]
		public TweenPosition TEndTweenPos7;

		// Token: 0x0400CE81 RID: 52865
		[Token(Token = "0x400CE81")]
		[FieldOffset(Offset = "0xD8")]
		public TweenPosition TEndTweenPos8;

		// Token: 0x0400CE82 RID: 52866
		[Token(Token = "0x400CE82")]
		[FieldOffset(Offset = "0xE0")]
		public TweenPosition TEndTweenPos9;

		// Token: 0x0400CE83 RID: 52867
		[Token(Token = "0x400CE83")]
		[FieldOffset(Offset = "0xE8")]
		public TweenPosition TEndTweenPos10;

		// Token: 0x0400CE84 RID: 52868
		[Token(Token = "0x400CE84")]
		[FieldOffset(Offset = "0xF0")]
		public UIGrid BtnGroup;

		// Token: 0x0400CE85 RID: 52869
		[Token(Token = "0x400CE85")]
		[FieldOffset(Offset = "0xF8")]
		public UIButton RepurchaseBtn;

		// Token: 0x0400CE86 RID: 52870
		[Token(Token = "0x400CE86")]
		[FieldOffset(Offset = "0x100")]
		public UILabel RepurchaseLabel;

		// Token: 0x0400CE87 RID: 52871
		[Token(Token = "0x400CE87")]
		[FieldOffset(Offset = "0x108")]
		public UILabel FreeLabel;

		// Token: 0x0400CE88 RID: 52872
		[Token(Token = "0x400CE88")]
		[FieldOffset(Offset = "0x110")]
		public UISprite CurrencySprite;

		// Token: 0x0400CE89 RID: 52873
		[Token(Token = "0x400CE89")]
		[FieldOffset(Offset = "0x118")]
		public UILabel CurrencyCountLabel;

		// Token: 0x0400CE8A RID: 52874
		[Token(Token = "0x400CE8A")]
		[FieldOffset(Offset = "0x120")]
		public UIButton OKBtn;

		// Token: 0x0400CE8B RID: 52875
		[Token(Token = "0x400CE8B")]
		[FieldOffset(Offset = "0x128")]
		public UIButton OpenBtn;

		// Token: 0x0400CE8C RID: 52876
		[Token(Token = "0x400CE8C")]
		[FieldOffset(Offset = "0x130")]
		public UIButton FastEquipBtn;
	}
}
