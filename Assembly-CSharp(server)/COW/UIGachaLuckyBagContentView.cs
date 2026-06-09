using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002222 RID: 8738
	[Token(Token = "0x2002222")]
	internal class UIGachaLuckyBagContentView : UIBaseView
	{
		// Token: 0x0600BF55 RID: 48981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF55")]
		[Address(RVA = "0x2066D44", Offset = "0x2066D44", VA = "0x7BBC866D44", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF56 RID: 48982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF56")]
		[Address(RVA = "0x206784C", Offset = "0x206784C", VA = "0x7BBC86784C")]
		public UIGachaLuckyBagContentView()
		{
		}

		// Token: 0x0400CF99 RID: 53145
		[Token(Token = "0x400CF99")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UIGachaLuckyBagContent;

		// Token: 0x0400CF9A RID: 53146
		[Token(Token = "0x400CF9A")]
		[FieldOffset(Offset = "0x28")]
		public GameObject UISceneInCG;

		// Token: 0x0400CF9B RID: 53147
		[Token(Token = "0x400CF9B")]
		[FieldOffset(Offset = "0x30")]
		public GameObject RewardScene;

		// Token: 0x0400CF9C RID: 53148
		[Token(Token = "0x400CF9C")]
		[FieldOffset(Offset = "0x38")]
		public UILabel RewardName;

		// Token: 0x0400CF9D RID: 53149
		[Token(Token = "0x400CF9D")]
		[FieldOffset(Offset = "0x40")]
		public BaseItemView RewardItem;

		// Token: 0x0400CF9E RID: 53150
		[Token(Token = "0x400CF9E")]
		[FieldOffset(Offset = "0x48")]
		public UILabel NameLabel;

		// Token: 0x0400CF9F RID: 53151
		[Token(Token = "0x400CF9F")]
		[FieldOffset(Offset = "0x50")]
		public GameObject IconGroup;

		// Token: 0x0400CFA0 RID: 53152
		[Token(Token = "0x400CFA0")]
		[FieldOffset(Offset = "0x58")]
		public UISprite Sprite_Debris;

		// Token: 0x0400CFA1 RID: 53153
		[Token(Token = "0x400CFA1")]
		[FieldOffset(Offset = "0x60")]
		public UISprite VoucherIcon;

		// Token: 0x0400CFA2 RID: 53154
		[Token(Token = "0x400CFA2")]
		[FieldOffset(Offset = "0x68")]
		public UILabel LimitLabel;

		// Token: 0x0400CFA3 RID: 53155
		[Token(Token = "0x400CFA3")]
		[FieldOffset(Offset = "0x70")]
		public UIToggle RewardToggle;

		// Token: 0x0400CFA4 RID: 53156
		[Token(Token = "0x400CFA4")]
		[FieldOffset(Offset = "0x78")]
		public UISprite SelectedSprite;

		// Token: 0x0400CFA5 RID: 53157
		[Token(Token = "0x400CFA5")]
		[FieldOffset(Offset = "0x80")]
		public UISprite UnSelectedSprite;

		// Token: 0x0400CFA6 RID: 53158
		[Token(Token = "0x400CFA6")]
		[FieldOffset(Offset = "0x88")]
		public UILabel QuantityLabel;

		// Token: 0x0400CFA7 RID: 53159
		[Token(Token = "0x400CFA7")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BackBtn;

		// Token: 0x0400CFA8 RID: 53160
		[Token(Token = "0x400CFA8")]
		[FieldOffset(Offset = "0x98")]
		public UIButton ShareBtn;

		// Token: 0x0400CFA9 RID: 53161
		[Token(Token = "0x400CFA9")]
		[FieldOffset(Offset = "0xA0")]
		public Animator ShareIconAnimator;

		// Token: 0x0400CFAA RID: 53162
		[Token(Token = "0x400CFAA")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject ShareUI;

		// Token: 0x0400CFAB RID: 53163
		[Token(Token = "0x400CFAB")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject UserProfile;

		// Token: 0x0400CFAC RID: 53164
		[Token(Token = "0x400CFAC")]
		[FieldOffset(Offset = "0xB8")]
		public UINetworkTexture HeadshotRemote;

		// Token: 0x0400CFAD RID: 53165
		[Token(Token = "0x400CFAD")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject HeadshotDefault;

		// Token: 0x0400CFAE RID: 53166
		[Token(Token = "0x400CFAE")]
		[FieldOffset(Offset = "0xC8")]
		public UIEffectSprite HeadshotLocal;

		// Token: 0x0400CFAF RID: 53167
		[Token(Token = "0x400CFAF")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel PlayerID;

		// Token: 0x0400CFB0 RID: 53168
		[Token(Token = "0x400CFB0")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel PlayerNickname;

		// Token: 0x0400CFB1 RID: 53169
		[Token(Token = "0x400CFB1")]
		[FieldOffset(Offset = "0xE0")]
		public UISprite FFLogo;

		// Token: 0x0400CFB2 RID: 53170
		[Token(Token = "0x400CFB2")]
		[FieldOffset(Offset = "0xE8")]
		public UITexture ShareDrawSymbol;

		// Token: 0x0400CFB3 RID: 53171
		[Token(Token = "0x400CFB3")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject DrawScene;

		// Token: 0x0400CFB4 RID: 53172
		[Token(Token = "0x400CFB4")]
		[FieldOffset(Offset = "0xF8")]
		public Animator DrawSceneAnimator;

		// Token: 0x0400CFB5 RID: 53173
		[Token(Token = "0x400CFB5")]
		[FieldOffset(Offset = "0x100")]
		public UIButton OKBtn;

		// Token: 0x0400CFB6 RID: 53174
		[Token(Token = "0x400CFB6")]
		[FieldOffset(Offset = "0x108")]
		public UIButton ClearBtn;

		// Token: 0x0400CFB7 RID: 53175
		[Token(Token = "0x400CFB7")]
		[FieldOffset(Offset = "0x110")]
		public GameObject LineRenderer;

		// Token: 0x0400CFB8 RID: 53176
		[Token(Token = "0x400CFB8")]
		[FieldOffset(Offset = "0x118")]
		public UITexture ShowSymbol;

		// Token: 0x0400CFB9 RID: 53177
		[Token(Token = "0x400CFB9")]
		[FieldOffset(Offset = "0x120")]
		public UIWidget ShowSymbolWidget;

		// Token: 0x0400CFBA RID: 53178
		[Token(Token = "0x400CFBA")]
		[FieldOffset(Offset = "0x128")]
		public GameObject DrawTips;

		// Token: 0x0400CFBB RID: 53179
		[Token(Token = "0x400CFBB")]
		[FieldOffset(Offset = "0x130")]
		public UITexture DrawSceneBG;

		// Token: 0x0400CFBC RID: 53180
		[Token(Token = "0x400CFBC")]
		[FieldOffset(Offset = "0x138")]
		public GameObject UnlockSuccess;

		// Token: 0x0400CFBD RID: 53181
		[Token(Token = "0x400CFBD")]
		[FieldOffset(Offset = "0x140")]
		public GameObject UIContent;

		// Token: 0x0400CFBE RID: 53182
		[Token(Token = "0x400CFBE")]
		[FieldOffset(Offset = "0x148")]
		public GameObject BuyBtn;

		// Token: 0x0400CFBF RID: 53183
		[Token(Token = "0x400CFBF")]
		[FieldOffset(Offset = "0x150")]
		public UILabel BuyPriceLabel;

		// Token: 0x0400CFC0 RID: 53184
		[Token(Token = "0x400CFC0")]
		[FieldOffset(Offset = "0x158")]
		public GameObject NetworkTexturebg;

		// Token: 0x0400CFC1 RID: 53185
		[Token(Token = "0x400CFC1")]
		[FieldOffset(Offset = "0x160")]
		public UINetworkTexture NetworkTexture;

		// Token: 0x0400CFC2 RID: 53186
		[Token(Token = "0x400CFC2")]
		[FieldOffset(Offset = "0x168")]
		public UIButton PoolRewardBtn;

		// Token: 0x0400CFC3 RID: 53187
		[Token(Token = "0x400CFC3")]
		[FieldOffset(Offset = "0x170")]
		public UICountDownLabel FreeCountdownLabel;

		// Token: 0x0400CFC4 RID: 53188
		[Token(Token = "0x400CFC4")]
		[FieldOffset(Offset = "0x178")]
		public UILabel LimitedLabel;

		// Token: 0x0400CFC5 RID: 53189
		[Token(Token = "0x400CFC5")]
		[FieldOffset(Offset = "0x180")]
		public GameObject RewardPoolPos;

		// Token: 0x0400CFC6 RID: 53190
		[Token(Token = "0x400CFC6")]
		[FieldOffset(Offset = "0x188")]
		public GameObject PreviewLeftSideOpenPreviewPool;

		// Token: 0x0400CFC7 RID: 53191
		[Token(Token = "0x400CFC7")]
		[FieldOffset(Offset = "0x190")]
		public GameObject PreviewRightSide;
	}
}
