using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200240A RID: 9226
	[Token(Token = "0x200240A")]
	public class UILoginView : UIBaseView
	{
		// Token: 0x0600C324 RID: 49956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C324")]
		[Address(RVA = "0x19E8CB0", Offset = "0x19E8CB0", VA = "0x7BBC1E8CB0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C325 RID: 49957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C325")]
		[Address(RVA = "0x19E9CD8", Offset = "0x19E9CD8", VA = "0x7BBC1E9CD8")]
		public UILoginView()
		{
		}

		// Token: 0x0400E36B RID: 58219
		[Token(Token = "0x400E36B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BgPanel;

		// Token: 0x0400E36C RID: 58220
		[Token(Token = "0x400E36C")]
		[FieldOffset(Offset = "0x28")]
		public UITexture Bg;

		// Token: 0x0400E36D RID: 58221
		[Token(Token = "0x400E36D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject LoginPanel;

		// Token: 0x0400E36E RID: 58222
		[Token(Token = "0x400E36E")]
		[FieldOffset(Offset = "0x38")]
		public UILabel AccountID;

		// Token: 0x0400E36F RID: 58223
		[Token(Token = "0x400E36F")]
		[FieldOffset(Offset = "0x40")]
		public UIButton Debug;

		// Token: 0x0400E370 RID: 58224
		[Token(Token = "0x400E370")]
		[FieldOffset(Offset = "0x48")]
		public UITable Table;

		// Token: 0x0400E371 RID: 58225
		[Token(Token = "0x400E371")]
		[FieldOffset(Offset = "0x50")]
		public GameObject RegionTitle;

		// Token: 0x0400E372 RID: 58226
		[Token(Token = "0x400E372")]
		[FieldOffset(Offset = "0x58")]
		public UILabel RegionContent;

		// Token: 0x0400E373 RID: 58227
		[Token(Token = "0x400E373")]
		[FieldOffset(Offset = "0x60")]
		public UILabel CurrentServer;

		// Token: 0x0400E374 RID: 58228
		[Token(Token = "0x400E374")]
		[FieldOffset(Offset = "0x68")]
		public GameObject SeverPanel;

		// Token: 0x0400E375 RID: 58229
		[Token(Token = "0x400E375")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BtnChangeSever;

		// Token: 0x0400E376 RID: 58230
		[Token(Token = "0x400E376")]
		[FieldOffset(Offset = "0x78")]
		public UILabel ServerLabel;

		// Token: 0x0400E377 RID: 58231
		[Token(Token = "0x400E377")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BtnStartGame;

		// Token: 0x0400E378 RID: 58232
		[Token(Token = "0x400E378")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BgStartGame;

		// Token: 0x0400E379 RID: 58233
		[Token(Token = "0x400E379")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnLogout;

		// Token: 0x0400E37A RID: 58234
		[Token(Token = "0x400E37A")]
		[FieldOffset(Offset = "0x98")]
		public UISprite LogoutIcon;

		// Token: 0x0400E37B RID: 58235
		[Token(Token = "0x400E37B")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite LogoutFacebookSprite;

		// Token: 0x0400E37C RID: 58236
		[Token(Token = "0x400E37C")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite LogoutVKontakteSprite;

		// Token: 0x0400E37D RID: 58237
		[Token(Token = "0x400E37D")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite LogoutGuestSprite;

		// Token: 0x0400E37E RID: 58238
		[Token(Token = "0x400E37E")]
		[FieldOffset(Offset = "0xB8")]
		public UISprite LogoutHuaweiSprite;

		// Token: 0x0400E37F RID: 58239
		[Token(Token = "0x400E37F")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite LogoutGoogleSprite;

		// Token: 0x0400E380 RID: 58240
		[Token(Token = "0x400E380")]
		[FieldOffset(Offset = "0xC8")]
		public UISprite LogoutAppleSprite;

		// Token: 0x0400E381 RID: 58241
		[Token(Token = "0x400E381")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite LogoutTwitterSprite;

		// Token: 0x0400E382 RID: 58242
		[Token(Token = "0x400E382")]
		[FieldOffset(Offset = "0xD8")]
		public UIWidget CachedPlayerInfo;

		// Token: 0x0400E383 RID: 58243
		[Token(Token = "0x400E383")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel CachedNicknameLabel;

		// Token: 0x0400E384 RID: 58244
		[Token(Token = "0x400E384")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject GyroSetting;

		// Token: 0x0400E385 RID: 58245
		[Token(Token = "0x400E385")]
		[FieldOffset(Offset = "0xF0")]
		public UIToggleButtonGroup GyroSelectGroup;

		// Token: 0x0400E386 RID: 58246
		[Token(Token = "0x400E386")]
		[FieldOffset(Offset = "0xF8")]
		public UIToggleButton GyroTarget;

		// Token: 0x0400E387 RID: 58247
		[Token(Token = "0x400E387")]
		[FieldOffset(Offset = "0x100")]
		public UILabel MoveSpeedValue;

		// Token: 0x0400E388 RID: 58248
		[Token(Token = "0x400E388")]
		[FieldOffset(Offset = "0x108")]
		public UIButton MoveSpeedInc;

		// Token: 0x0400E389 RID: 58249
		[Token(Token = "0x400E389")]
		[FieldOffset(Offset = "0x110")]
		public UIButton MoveSpeedDec;

		// Token: 0x0400E38A RID: 58250
		[Token(Token = "0x400E38A")]
		[FieldOffset(Offset = "0x118")]
		public UILabel RebackSpeedValue;

		// Token: 0x0400E38B RID: 58251
		[Token(Token = "0x400E38B")]
		[FieldOffset(Offset = "0x120")]
		public UIButton RebackSpeedInc;

		// Token: 0x0400E38C RID: 58252
		[Token(Token = "0x400E38C")]
		[FieldOffset(Offset = "0x128")]
		public UIButton RebackSpeedDec;

		// Token: 0x0400E38D RID: 58253
		[Token(Token = "0x400E38D")]
		[FieldOffset(Offset = "0x130")]
		public GameObject PanelTOS;

		// Token: 0x0400E38E RID: 58254
		[Token(Token = "0x400E38E")]
		[FieldOffset(Offset = "0x138")]
		public UILabel LabelTOS;

		// Token: 0x0400E38F RID: 58255
		[Token(Token = "0x400E38F")]
		[FieldOffset(Offset = "0x140")]
		public UIButton BtnService;

		// Token: 0x0400E390 RID: 58256
		[Token(Token = "0x400E390")]
		[FieldOffset(Offset = "0x148")]
		public UIButton BtnPrivacy;

		// Token: 0x0400E391 RID: 58257
		[Token(Token = "0x400E391")]
		[FieldOffset(Offset = "0x150")]
		public UIToggle ToggleTOS;

		// Token: 0x0400E392 RID: 58258
		[Token(Token = "0x400E392")]
		[FieldOffset(Offset = "0x158")]
		public GameObject TOSVFX;

		// Token: 0x0400E393 RID: 58259
		[Token(Token = "0x400E393")]
		[FieldOffset(Offset = "0x160")]
		public GameObject LoginBtns;

		// Token: 0x0400E394 RID: 58260
		[Token(Token = "0x400E394")]
		[FieldOffset(Offset = "0x168")]
		public GameObject Normal;

		// Token: 0x0400E395 RID: 58261
		[Token(Token = "0x400E395")]
		[FieldOffset(Offset = "0x170")]
		public UIGrid LoginBtnGrid;

		// Token: 0x0400E396 RID: 58262
		[Token(Token = "0x400E396")]
		[FieldOffset(Offset = "0x178")]
		public UIButton BtnLoginAppleWhite;

		// Token: 0x0400E397 RID: 58263
		[Token(Token = "0x400E397")]
		[FieldOffset(Offset = "0x180")]
		public UIButton BtnLoginAppleBlack;

		// Token: 0x0400E398 RID: 58264
		[Token(Token = "0x400E398")]
		[FieldOffset(Offset = "0x188")]
		public UIButton BtnLoginHW;

		// Token: 0x0400E399 RID: 58265
		[Token(Token = "0x400E399")]
		[FieldOffset(Offset = "0x190")]
		public UISprite SpriteLoginHW_Huawei;

		// Token: 0x0400E39A RID: 58266
		[Token(Token = "0x400E39A")]
		[FieldOffset(Offset = "0x198")]
		public UIButton BtnLoginVK;

		// Token: 0x0400E39B RID: 58267
		[Token(Token = "0x400E39B")]
		[FieldOffset(Offset = "0x1A0")]
		public UIButton BtnLoginFB;

		// Token: 0x0400E39C RID: 58268
		[Token(Token = "0x400E39C")]
		[FieldOffset(Offset = "0x1A8")]
		public UIButton BtnLoginGoogle;

		// Token: 0x0400E39D RID: 58269
		[Token(Token = "0x400E39D")]
		[FieldOffset(Offset = "0x1B0")]
		public UISprite SpriteLoginVK_Russian;

		// Token: 0x0400E39E RID: 58270
		[Token(Token = "0x400E39E")]
		[FieldOffset(Offset = "0x1B8")]
		public UIButton BtnLoginTwitter;

		// Token: 0x0400E39F RID: 58271
		[Token(Token = "0x400E39F")]
		[FieldOffset(Offset = "0x1C0")]
		public UIButton BtnLoginGuest;

		// Token: 0x0400E3A0 RID: 58272
		[Token(Token = "0x400E3A0")]
		[FieldOffset(Offset = "0x1C8")]
		public GameObject MoreLogin;

		// Token: 0x0400E3A1 RID: 58273
		[Token(Token = "0x400E3A1")]
		[FieldOffset(Offset = "0x1D0")]
		public UIButton MoreLoginBtn;

		// Token: 0x0400E3A2 RID: 58274
		[Token(Token = "0x400E3A2")]
		[FieldOffset(Offset = "0x1D8")]
		public GameObject PC;

		// Token: 0x0400E3A3 RID: 58275
		[Token(Token = "0x400E3A3")]
		[FieldOffset(Offset = "0x1E0")]
		public UIButton PCGuest;

		// Token: 0x0400E3A4 RID: 58276
		[Token(Token = "0x400E3A4")]
		[FieldOffset(Offset = "0x1E8")]
		public GameObject Trial;

		// Token: 0x0400E3A5 RID: 58277
		[Token(Token = "0x400E3A5")]
		[FieldOffset(Offset = "0x1F0")]
		public UIButton TrialGuest;

		// Token: 0x0400E3A6 RID: 58278
		[Token(Token = "0x400E3A6")]
		[FieldOffset(Offset = "0x1F8")]
		public GameObject PanelAge;

		// Token: 0x0400E3A7 RID: 58279
		[Token(Token = "0x400E3A7")]
		[FieldOffset(Offset = "0x200")]
		public UILabel LabelAge;

		// Token: 0x0400E3A8 RID: 58280
		[Token(Token = "0x400E3A8")]
		[FieldOffset(Offset = "0x208")]
		public UIToggle ToggleAge;

		// Token: 0x0400E3A9 RID: 58281
		[Token(Token = "0x400E3A9")]
		[FieldOffset(Offset = "0x210")]
		public GameObject Age18Logo;

		// Token: 0x0400E3AA RID: 58282
		[Token(Token = "0x400E3AA")]
		[FieldOffset(Offset = "0x218")]
		public GameObject RegisterPanel;

		// Token: 0x0400E3AB RID: 58283
		[Token(Token = "0x400E3AB")]
		[FieldOffset(Offset = "0x220")]
		public UIInput InputCode;

		// Token: 0x0400E3AC RID: 58284
		[Token(Token = "0x400E3AC")]
		[FieldOffset(Offset = "0x228")]
		public UIInput InputNickName;

		// Token: 0x0400E3AD RID: 58285
		[Token(Token = "0x400E3AD")]
		[FieldOffset(Offset = "0x230")]
		public UIButton BtnRegister;

		// Token: 0x0400E3AE RID: 58286
		[Token(Token = "0x400E3AE")]
		[FieldOffset(Offset = "0x238")]
		public UILabel DataHintLabel;

		// Token: 0x0400E3AF RID: 58287
		[Token(Token = "0x400E3AF")]
		[FieldOffset(Offset = "0x240")]
		public GameObject VNLinkUrl;

		// Token: 0x0400E3B0 RID: 58288
		[Token(Token = "0x400E3B0")]
		[FieldOffset(Offset = "0x248")]
		public UIButton UrlBtn;
	}
}
