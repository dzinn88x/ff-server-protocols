using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002213 RID: 8723
	[Token(Token = "0x2002213")]
	internal class UIGachalegendaryContentView : UIBaseView
	{
		// Token: 0x0600BF37 RID: 48951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF37")]
		[Address(RVA = "0x1FB36BC", Offset = "0x1FB36BC", VA = "0x7BBC7B36BC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF38 RID: 48952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF38")]
		[Address(RVA = "0x1FB3EA0", Offset = "0x1FB3EA0", VA = "0x7BBC7B3EA0")]
		public UIGachalegendaryContentView()
		{
		}

		// Token: 0x0400CED2 RID: 52946
		[Token(Token = "0x400CED2")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UIGachalegendaryContent;

		// Token: 0x0400CED3 RID: 52947
		[Token(Token = "0x400CED3")]
		[FieldOffset(Offset = "0x28")]
		public Animator UIGachalegendaryAnim;

		// Token: 0x0400CED4 RID: 52948
		[Token(Token = "0x400CED4")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ItemDesc;

		// Token: 0x0400CED5 RID: 52949
		[Token(Token = "0x400CED5")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ItemName;

		// Token: 0x0400CED6 RID: 52950
		[Token(Token = "0x400CED6")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ItemDescLabel;

		// Token: 0x0400CED7 RID: 52951
		[Token(Token = "0x400CED7")]
		[FieldOffset(Offset = "0x48")]
		public UIButton stateBtn_3;

		// Token: 0x0400CED8 RID: 52952
		[Token(Token = "0x400CED8")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Seleccted_3;

		// Token: 0x0400CED9 RID: 52953
		[Token(Token = "0x400CED9")]
		[FieldOffset(Offset = "0x58")]
		public UILabel LvupLabel;

		// Token: 0x0400CEDA RID: 52954
		[Token(Token = "0x400CEDA")]
		[FieldOffset(Offset = "0x60")]
		public UICountDownLabel FreeCountdownLabel;

		// Token: 0x0400CEDB RID: 52955
		[Token(Token = "0x400CEDB")]
		[FieldOffset(Offset = "0x68")]
		public UIButton TimeBg;

		// Token: 0x0400CEDC RID: 52956
		[Token(Token = "0x400CEDC")]
		[FieldOffset(Offset = "0x70")]
		public UIButton PrivewBtn;

		// Token: 0x0400CEDD RID: 52957
		[Token(Token = "0x400CEDD")]
		[FieldOffset(Offset = "0x78")]
		public UIButton progressBar;

		// Token: 0x0400CEDE RID: 52958
		[Token(Token = "0x400CEDE")]
		[FieldOffset(Offset = "0x80")]
		public UIProgressBar LuckyProgressBar;

		// Token: 0x0400CEDF RID: 52959
		[Token(Token = "0x400CEDF")]
		[FieldOffset(Offset = "0x88")]
		public GameObject CurrentFlag;

		// Token: 0x0400CEE0 RID: 52960
		[Token(Token = "0x400CEE0")]
		[FieldOffset(Offset = "0x90")]
		public GameObject ProgressBarEffect;

		// Token: 0x0400CEE1 RID: 52961
		[Token(Token = "0x400CEE1")]
		[FieldOffset(Offset = "0x98")]
		public GameObject ProgressEndEffect;

		// Token: 0x0400CEE2 RID: 52962
		[Token(Token = "0x400CEE2")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject CurrentLucky_Lable_Info;

		// Token: 0x0400CEE3 RID: 52963
		[Token(Token = "0x400CEE3")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject GetLuckyEffect;

		// Token: 0x0400CEE4 RID: 52964
		[Token(Token = "0x400CEE4")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject AllBuyBtn;

		// Token: 0x0400CEE5 RID: 52965
		[Token(Token = "0x400CEE5")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel PriceLabel;

		// Token: 0x0400CEE6 RID: 52966
		[Token(Token = "0x400CEE6")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton BuffTipsBtn;

		// Token: 0x0400CEE7 RID: 52967
		[Token(Token = "0x400CEE7")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel BuffEffectLabel;

		// Token: 0x0400CEE8 RID: 52968
		[Token(Token = "0x400CEE8")]
		[FieldOffset(Offset = "0xD0")]
		public UIButton BuyBuffBtn;

		// Token: 0x0400CEE9 RID: 52969
		[Token(Token = "0x400CEE9")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject BuyBuffDisable;

		// Token: 0x0400CEEA RID: 52970
		[Token(Token = "0x400CEEA")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject BuyBuffEffect;

		// Token: 0x0400CEEB RID: 52971
		[Token(Token = "0x400CEEB")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject BuyBuffEnable;

		// Token: 0x0400CEEC RID: 52972
		[Token(Token = "0x400CEEC")]
		[FieldOffset(Offset = "0xF0")]
		public UISprite TenBuyResultNum;

		// Token: 0x0400CEED RID: 52973
		[Token(Token = "0x400CEED")]
		[FieldOffset(Offset = "0xF8")]
		public Animator buffLabelEffect_1;

		// Token: 0x0400CEEE RID: 52974
		[Token(Token = "0x400CEEE")]
		[FieldOffset(Offset = "0x100")]
		public Animator bufflabelEffect_2;

		// Token: 0x0400CEEF RID: 52975
		[Token(Token = "0x400CEEF")]
		[FieldOffset(Offset = "0x108")]
		public UIWidget PreviewRightSide;

		// Token: 0x0400CEF0 RID: 52976
		[Token(Token = "0x400CEF0")]
		[FieldOffset(Offset = "0x110")]
		public GameObject GachaPreviewPosition;

		// Token: 0x0400CEF1 RID: 52977
		[Token(Token = "0x400CEF1")]
		[FieldOffset(Offset = "0x118")]
		public UIWidget PreviewLeftSide;

		// Token: 0x0400CEF2 RID: 52978
		[Token(Token = "0x400CEF2")]
		[FieldOffset(Offset = "0x120")]
		public GameObject PreviewLeftSideOpenPreviewPool;
	}
}
