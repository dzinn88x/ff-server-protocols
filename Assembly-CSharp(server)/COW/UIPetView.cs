using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002490 RID: 9360
	[Token(Token = "0x2002490")]
	public class UIPetView : UIBaseView
	{
		// Token: 0x0600C430 RID: 50224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C430")]
		[Address(RVA = "0x20E5C98", Offset = "0x20E5C98", VA = "0x7BBC8E5C98", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C431 RID: 50225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C431")]
		[Address(RVA = "0x20E6AE0", Offset = "0x20E6AE0", VA = "0x7BBC8E6AE0")]
		public UIPetView()
		{
		}

		// Token: 0x0400EB46 RID: 60230
		[Token(Token = "0x400EB46")]
		[FieldOffset(Offset = "0x20")]
		public UITexture BG;

		// Token: 0x0400EB47 RID: 60231
		[Token(Token = "0x400EB47")]
		[FieldOffset(Offset = "0x28")]
		public GameObject CenterContainer;

		// Token: 0x0400EB48 RID: 60232
		[Token(Token = "0x400EB48")]
		[FieldOffset(Offset = "0x30")]
		public GameObject PetPanelContainer;

		// Token: 0x0400EB49 RID: 60233
		[Token(Token = "0x400EB49")]
		[FieldOffset(Offset = "0x38")]
		public GameObject PetListTitle;

		// Token: 0x0400EB4A RID: 60234
		[Token(Token = "0x400EB4A")]
		[FieldOffset(Offset = "0x40")]
		public UIEasyList PetGrid;

		// Token: 0x0400EB4B RID: 60235
		[Token(Token = "0x400EB4B")]
		[FieldOffset(Offset = "0x48")]
		public GameObject PetInfoContainer;

		// Token: 0x0400EB4C RID: 60236
		[Token(Token = "0x400EB4C")]
		[FieldOffset(Offset = "0x50")]
		public GameObject PetNameTitle;

		// Token: 0x0400EB4D RID: 60237
		[Token(Token = "0x400EB4D")]
		[FieldOffset(Offset = "0x58")]
		public UILabel PetNameLabel;

		// Token: 0x0400EB4E RID: 60238
		[Token(Token = "0x400EB4E")]
		[FieldOffset(Offset = "0x60")]
		public UIButton RenameBtn;

		// Token: 0x0400EB4F RID: 60239
		[Token(Token = "0x400EB4F")]
		[FieldOffset(Offset = "0x68")]
		public GameObject PetLevelLabelGroup;

		// Token: 0x0400EB50 RID: 60240
		[Token(Token = "0x400EB50")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Txt_Lv;

		// Token: 0x0400EB51 RID: 60241
		[Token(Token = "0x400EB51")]
		[FieldOffset(Offset = "0x78")]
		public UILabel exp_label;

		// Token: 0x0400EB52 RID: 60242
		[Token(Token = "0x400EB52")]
		[FieldOffset(Offset = "0x80")]
		public UIProgressBar ProgressBar;

		// Token: 0x0400EB53 RID: 60243
		[Token(Token = "0x400EB53")]
		[FieldOffset(Offset = "0x88")]
		public GameObject PetScrollView;

		// Token: 0x0400EB54 RID: 60244
		[Token(Token = "0x400EB54")]
		[FieldOffset(Offset = "0x90")]
		public GameObject IOSPreviewShowLabel;

		// Token: 0x0400EB55 RID: 60245
		[Token(Token = "0x400EB55")]
		[FieldOffset(Offset = "0x98")]
		public UIButton ActionTitleBtn;

		// Token: 0x0400EB56 RID: 60246
		[Token(Token = "0x400EB56")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject HLBg_Action;

		// Token: 0x0400EB57 RID: 60247
		[Token(Token = "0x400EB57")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel ActionTitle;

		// Token: 0x0400EB58 RID: 60248
		[Token(Token = "0x400EB58")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject ActionNewTips;

		// Token: 0x0400EB59 RID: 60249
		[Token(Token = "0x400EB59")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton SkinTitleBtn;

		// Token: 0x0400EB5A RID: 60250
		[Token(Token = "0x400EB5A")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject HLBg_Skin;

		// Token: 0x0400EB5B RID: 60251
		[Token(Token = "0x400EB5B")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel SkinTitle;

		// Token: 0x0400EB5C RID: 60252
		[Token(Token = "0x400EB5C")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject SkinNewTips;

		// Token: 0x0400EB5D RID: 60253
		[Token(Token = "0x400EB5D")]
		[FieldOffset(Offset = "0xD8")]
		public UIButton SkillTitleBtn;

		// Token: 0x0400EB5E RID: 60254
		[Token(Token = "0x400EB5E")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject SelectSkillGuide;

		// Token: 0x0400EB5F RID: 60255
		[Token(Token = "0x400EB5F")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject Effect_Circle;

		// Token: 0x0400EB60 RID: 60256
		[Token(Token = "0x400EB60")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject HLBg_Skill;

		// Token: 0x0400EB61 RID: 60257
		[Token(Token = "0x400EB61")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel SkillTitle;

		// Token: 0x0400EB62 RID: 60258
		[Token(Token = "0x400EB62")]
		[FieldOffset(Offset = "0x100")]
		public GameObject SkillNewTips;

		// Token: 0x0400EB63 RID: 60259
		[Token(Token = "0x400EB63")]
		[FieldOffset(Offset = "0x108")]
		public GameObject Rightdownbtn;

		// Token: 0x0400EB64 RID: 60260
		[Token(Token = "0x400EB64")]
		[FieldOffset(Offset = "0x110")]
		public UIButton PetActBtn;

		// Token: 0x0400EB65 RID: 60261
		[Token(Token = "0x400EB65")]
		[FieldOffset(Offset = "0x118")]
		public UILabel ActionBtn_label;

		// Token: 0x0400EB66 RID: 60262
		[Token(Token = "0x400EB66")]
		[FieldOffset(Offset = "0x120")]
		public UIButton PetShareBtn;

		// Token: 0x0400EB67 RID: 60263
		[Token(Token = "0x400EB67")]
		[FieldOffset(Offset = "0x128")]
		public UILabel ShareBtn_label;

		// Token: 0x0400EB68 RID: 60264
		[Token(Token = "0x400EB68")]
		[FieldOffset(Offset = "0x130")]
		public GameObject PetFeedContainer;

		// Token: 0x0400EB69 RID: 60265
		[Token(Token = "0x400EB69")]
		[FieldOffset(Offset = "0x138")]
		public UIButton FeedLevelUpBtn;

		// Token: 0x0400EB6A RID: 60266
		[Token(Token = "0x400EB6A")]
		[FieldOffset(Offset = "0x140")]
		public UIWidget LevelUpWidget;

		// Token: 0x0400EB6B RID: 60267
		[Token(Token = "0x400EB6B")]
		[FieldOffset(Offset = "0x148")]
		public UILabel FeedOneBtn_label;

		// Token: 0x0400EB6C RID: 60268
		[Token(Token = "0x400EB6C")]
		[FieldOffset(Offset = "0x150")]
		public GameObject LevelUpVFX;

		// Token: 0x0400EB6D RID: 60269
		[Token(Token = "0x400EB6D")]
		[FieldOffset(Offset = "0x158")]
		public UIButton FeedBuyBtn;

		// Token: 0x0400EB6E RID: 60270
		[Token(Token = "0x400EB6E")]
		[FieldOffset(Offset = "0x160")]
		public UISprite FeedShowIcon;

		// Token: 0x0400EB6F RID: 60271
		[Token(Token = "0x400EB6F")]
		[FieldOffset(Offset = "0x168")]
		public UILabel FeedShowTxt;

		// Token: 0x0400EB70 RID: 60272
		[Token(Token = "0x400EB70")]
		[FieldOffset(Offset = "0x170")]
		public GameObject GrownUpGo;

		// Token: 0x0400EB71 RID: 60273
		[Token(Token = "0x400EB71")]
		[FieldOffset(Offset = "0x178")]
		public GameObject ItemInfoShowContainer;

		// Token: 0x0400EB72 RID: 60274
		[Token(Token = "0x400EB72")]
		[FieldOffset(Offset = "0x180")]
		public UISprite PetNameInfoIcon;

		// Token: 0x0400EB73 RID: 60275
		[Token(Token = "0x400EB73")]
		[FieldOffset(Offset = "0x188")]
		public UILabel ItemInfoName;

		// Token: 0x0400EB74 RID: 60276
		[Token(Token = "0x400EB74")]
		[FieldOffset(Offset = "0x190")]
		public UISprite IPTag;

		// Token: 0x0400EB75 RID: 60277
		[Token(Token = "0x400EB75")]
		[FieldOffset(Offset = "0x198")]
		public UILabel ItemInfoUnlockDesc;

		// Token: 0x0400EB76 RID: 60278
		[Token(Token = "0x400EB76")]
		[FieldOffset(Offset = "0x1A0")]
		public UILabel ItemInfoDesc;

		// Token: 0x0400EB77 RID: 60279
		[Token(Token = "0x400EB77")]
		[FieldOffset(Offset = "0x1A8")]
		public UIWidget PreviewRightContainer;

		// Token: 0x0400EB78 RID: 60280
		[Token(Token = "0x400EB78")]
		[FieldOffset(Offset = "0x1B0")]
		public UIWidget PreviewLeftContainer;

		// Token: 0x0400EB79 RID: 60281
		[Token(Token = "0x400EB79")]
		[FieldOffset(Offset = "0x1B8")]
		public UIButton ShowPetBtn;

		// Token: 0x0400EB7A RID: 60282
		[Token(Token = "0x400EB7A")]
		[FieldOffset(Offset = "0x1C0")]
		public UIButton GotoShopBtn;

		// Token: 0x0400EB7B RID: 60283
		[Token(Token = "0x400EB7B")]
		[FieldOffset(Offset = "0x1C8")]
		public GameObject ShareUI;

		// Token: 0x0400EB7C RID: 60284
		[Token(Token = "0x400EB7C")]
		[FieldOffset(Offset = "0x1D0")]
		public UINetworkTexture HeadIcon;

		// Token: 0x0400EB7D RID: 60285
		[Token(Token = "0x400EB7D")]
		[FieldOffset(Offset = "0x1D8")]
		public UISprite HeadIconLocal;

		// Token: 0x0400EB7E RID: 60286
		[Token(Token = "0x400EB7E")]
		[FieldOffset(Offset = "0x1E0")]
		public UILabel NikcName;

		// Token: 0x0400EB7F RID: 60287
		[Token(Token = "0x400EB7F")]
		[FieldOffset(Offset = "0x1E8")]
		public UILabel ID;

		// Token: 0x0400EB80 RID: 60288
		[Token(Token = "0x400EB80")]
		[FieldOffset(Offset = "0x1F0")]
		public UISprite FreeFireLogo;

		// Token: 0x0400EB81 RID: 60289
		[Token(Token = "0x400EB81")]
		[FieldOffset(Offset = "0x1F8")]
		public Transform leftside;

		// Token: 0x0400EB82 RID: 60290
		[Token(Token = "0x400EB82")]
		[FieldOffset(Offset = "0x200")]
		public Transform rightside;

		// Token: 0x0400EB83 RID: 60291
		[Token(Token = "0x400EB83")]
		[FieldOffset(Offset = "0x208")]
		public UIWidget midPos;
	}
}
