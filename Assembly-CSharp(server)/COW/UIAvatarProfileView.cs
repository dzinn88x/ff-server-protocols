using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002108 RID: 8456
	[Token(Token = "0x2002108")]
	public class UIAvatarProfileView : UIBaseView
	{
		// Token: 0x0600BD21 RID: 48417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD21")]
		[Address(RVA = "0x1E45FE8", Offset = "0x1E45FE8", VA = "0x7BBC645FE8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD22 RID: 48418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD22")]
		[Address(RVA = "0x1E48254", Offset = "0x1E48254", VA = "0x7BBC648254")]
		public UIAvatarProfileView()
		{
		}

		// Token: 0x0400C0D0 RID: 49360
		[Token(Token = "0x400C0D0")]
		[FieldOffset(Offset = "0x20")]
		public GameObject MaxMask1;

		// Token: 0x0400C0D1 RID: 49361
		[Token(Token = "0x400C0D1")]
		[FieldOffset(Offset = "0x28")]
		public UISprite AlignmentIcon;

		// Token: 0x0400C0D2 RID: 49362
		[Token(Token = "0x400C0D2")]
		[FieldOffset(Offset = "0x30")]
		public UIButton AlignmentBtn;

		// Token: 0x0400C0D3 RID: 49363
		[Token(Token = "0x400C0D3")]
		[FieldOffset(Offset = "0x38")]
		public UITable CharacterInfoTable;

		// Token: 0x0400C0D4 RID: 49364
		[Token(Token = "0x400C0D4")]
		[FieldOffset(Offset = "0x40")]
		public UILabel CharacterName;

		// Token: 0x0400C0D5 RID: 49365
		[Token(Token = "0x400C0D5")]
		[FieldOffset(Offset = "0x48")]
		public UILabel Characterlv;

		// Token: 0x0400C0D6 RID: 49366
		[Token(Token = "0x400C0D6")]
		[FieldOffset(Offset = "0x50")]
		public UILabel CharacterIntroduction;

		// Token: 0x0400C0D7 RID: 49367
		[Token(Token = "0x400C0D7")]
		[FieldOffset(Offset = "0x58")]
		public UILabel DefaultCharacterIntroduction;

		// Token: 0x0400C0D8 RID: 49368
		[Token(Token = "0x400C0D8")]
		[FieldOffset(Offset = "0x60")]
		public GameObject tipsNode;

		// Token: 0x0400C0D9 RID: 49369
		[Token(Token = "0x400C0D9")]
		[FieldOffset(Offset = "0x68")]
		public UIButton TipBtn;

		// Token: 0x0400C0DA RID: 49370
		[Token(Token = "0x400C0DA")]
		[FieldOffset(Offset = "0x70")]
		public GameObject SkillDesc;

		// Token: 0x0400C0DB RID: 49371
		[Token(Token = "0x400C0DB")]
		[FieldOffset(Offset = "0x78")]
		public Transform SkillSprite;

		// Token: 0x0400C0DC RID: 49372
		[Token(Token = "0x400C0DC")]
		[FieldOffset(Offset = "0x80")]
		public UILabel SkillName;

		// Token: 0x0400C0DD RID: 49373
		[Token(Token = "0x400C0DD")]
		[FieldOffset(Offset = "0x88")]
		public UILabel SkillType;

		// Token: 0x0400C0DE RID: 49374
		[Token(Token = "0x400C0DE")]
		[FieldOffset(Offset = "0x90")]
		public GameObject DebrisInfo;

		// Token: 0x0400C0DF RID: 49375
		[Token(Token = "0x400C0DF")]
		[FieldOffset(Offset = "0x98")]
		public UILabel DebrisCount;

		// Token: 0x0400C0E0 RID: 49376
		[Token(Token = "0x400C0E0")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton levelUpEffectContainer;

		// Token: 0x0400C0E1 RID: 49377
		[Token(Token = "0x400C0E1")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton AwakenSkillUpgradeBtn;

		// Token: 0x0400C0E2 RID: 49378
		[Token(Token = "0x400C0E2")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject AwakenSkillRedDot;

		// Token: 0x0400C0E3 RID: 49379
		[Token(Token = "0x400C0E3")]
		[FieldOffset(Offset = "0xB8")]
		public UIScrollView SkillDescScrollView;

		// Token: 0x0400C0E4 RID: 49380
		[Token(Token = "0x400C0E4")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel CurrentSkillDesc;

		// Token: 0x0400C0E5 RID: 49381
		[Token(Token = "0x400C0E5")]
		[FieldOffset(Offset = "0xC8")]
		public UIEasyList ProfileList;

		// Token: 0x0400C0E6 RID: 49382
		[Token(Token = "0x400C0E6")]
		[FieldOffset(Offset = "0xD0")]
		public UIPanel ArrowPanel;

		// Token: 0x0400C0E7 RID: 49383
		[Token(Token = "0x400C0E7")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject SkillSlots;

		// Token: 0x0400C0E8 RID: 49384
		[Token(Token = "0x400C0E8")]
		[FieldOffset(Offset = "0xE0")]
		public Transform SlotPos_1;

		// Token: 0x0400C0E9 RID: 49385
		[Token(Token = "0x400C0E9")]
		[FieldOffset(Offset = "0xE8")]
		public Transform SlotPos_2;

		// Token: 0x0400C0EA RID: 49386
		[Token(Token = "0x400C0EA")]
		[FieldOffset(Offset = "0xF0")]
		public Transform SlotPos_3;

		// Token: 0x0400C0EB RID: 49387
		[Token(Token = "0x400C0EB")]
		[FieldOffset(Offset = "0xF8")]
		public Transform SlotPos_4;

		// Token: 0x0400C0EC RID: 49388
		[Token(Token = "0x400C0EC")]
		[FieldOffset(Offset = "0x100")]
		public Transform SlotPos_5;

		// Token: 0x0400C0ED RID: 49389
		[Token(Token = "0x400C0ED")]
		[FieldOffset(Offset = "0x108")]
		public GameObject pveweaponnode;

		// Token: 0x0400C0EE RID: 49390
		[Token(Token = "0x400C0EE")]
		[FieldOffset(Offset = "0x110")]
		public UISprite pveweaponicon;

		// Token: 0x0400C0EF RID: 49391
		[Token(Token = "0x400C0EF")]
		[FieldOffset(Offset = "0x118")]
		public GameObject DefaultAvatarNode;

		// Token: 0x0400C0F0 RID: 49392
		[Token(Token = "0x400C0F0")]
		[FieldOffset(Offset = "0x120")]
		public UISprite DefaultIPTag;

		// Token: 0x0400C0F1 RID: 49393
		[Token(Token = "0x400C0F1")]
		[FieldOffset(Offset = "0x128")]
		public UIButton DefaultVoicePlayBtn;

		// Token: 0x0400C0F2 RID: 49394
		[Token(Token = "0x400C0F2")]
		[FieldOffset(Offset = "0x130")]
		public GameObject DefaultVoicePlaying;

		// Token: 0x0400C0F3 RID: 49395
		[Token(Token = "0x400C0F3")]
		[FieldOffset(Offset = "0x138")]
		public GameObject DefaultVoiceNormal;

		// Token: 0x0400C0F4 RID: 49396
		[Token(Token = "0x400C0F4")]
		[FieldOffset(Offset = "0x140")]
		public UILabel DefaultAvatarName;

		// Token: 0x0400C0F5 RID: 49397
		[Token(Token = "0x400C0F5")]
		[FieldOffset(Offset = "0x148")]
		public UILabel DefaultAvatarDesc;

		// Token: 0x0400C0F6 RID: 49398
		[Token(Token = "0x400C0F6")]
		[FieldOffset(Offset = "0x150")]
		public GameObject ChangeSkinColor;

		// Token: 0x0400C0F7 RID: 49399
		[Token(Token = "0x400C0F7")]
		[FieldOffset(Offset = "0x158")]
		public UISlider colorSlider;

		// Token: 0x0400C0F8 RID: 49400
		[Token(Token = "0x400C0F8")]
		[FieldOffset(Offset = "0x160")]
		public UIEventListener ColorSliderListener;

		// Token: 0x0400C0F9 RID: 49401
		[Token(Token = "0x400C0F9")]
		[FieldOffset(Offset = "0x168")]
		public UIEventListener ThumbEventListener;

		// Token: 0x0400C0FA RID: 49402
		[Token(Token = "0x400C0FA")]
		[FieldOffset(Offset = "0x170")]
		public UISprite ThumbSprite;

		// Token: 0x0400C0FB RID: 49403
		[Token(Token = "0x400C0FB")]
		[FieldOffset(Offset = "0x178")]
		public UISprite colorResult;

		// Token: 0x0400C0FC RID: 49404
		[Token(Token = "0x400C0FC")]
		[FieldOffset(Offset = "0x180")]
		public GameObject DefaultStoryPanel;

		// Token: 0x0400C0FD RID: 49405
		[Token(Token = "0x400C0FD")]
		[FieldOffset(Offset = "0x188")]
		public UILabel DefaultAge;

		// Token: 0x0400C0FE RID: 49406
		[Token(Token = "0x400C0FE")]
		[FieldOffset(Offset = "0x190")]
		public UILabel DefaultBirth;

		// Token: 0x0400C0FF RID: 49407
		[Token(Token = "0x400C0FF")]
		[FieldOffset(Offset = "0x198")]
		public UILabel DefaultCareer;

		// Token: 0x0400C100 RID: 49408
		[Token(Token = "0x400C100")]
		[FieldOffset(Offset = "0x1A0")]
		public UILabel DefaultLove;

		// Token: 0x0400C101 RID: 49409
		[Token(Token = "0x400C101")]
		[FieldOffset(Offset = "0x1A8")]
		public UILabel DefaultRelation1;

		// Token: 0x0400C102 RID: 49410
		[Token(Token = "0x400C102")]
		[FieldOffset(Offset = "0x1B0")]
		public UISprite DefaultRelationIcon1;

		// Token: 0x0400C103 RID: 49411
		[Token(Token = "0x400C103")]
		[FieldOffset(Offset = "0x1B8")]
		public UILabel DefaultRelation2;

		// Token: 0x0400C104 RID: 49412
		[Token(Token = "0x400C104")]
		[FieldOffset(Offset = "0x1C0")]
		public UISprite DefaultRelationIcon2;

		// Token: 0x0400C105 RID: 49413
		[Token(Token = "0x400C105")]
		[FieldOffset(Offset = "0x1C8")]
		public UILabel DefaultRelation3;

		// Token: 0x0400C106 RID: 49414
		[Token(Token = "0x400C106")]
		[FieldOffset(Offset = "0x1D0")]
		public UISprite DefaultRelationIcon3;

		// Token: 0x0400C107 RID: 49415
		[Token(Token = "0x400C107")]
		[FieldOffset(Offset = "0x1D8")]
		public UIButton DefaultStoryBtn;

		// Token: 0x0400C108 RID: 49416
		[Token(Token = "0x400C108")]
		[FieldOffset(Offset = "0x1E0")]
		public GameObject Maxbg1;

		// Token: 0x0400C109 RID: 49417
		[Token(Token = "0x400C109")]
		[FieldOffset(Offset = "0x1E8")]
		public GameObject CommonAvatarNode;

		// Token: 0x0400C10A RID: 49418
		[Token(Token = "0x400C10A")]
		[FieldOffset(Offset = "0x1F0")]
		public UISprite CommonIPTag;

		// Token: 0x0400C10B RID: 49419
		[Token(Token = "0x400C10B")]
		[FieldOffset(Offset = "0x1F8")]
		public UIButton CommonVoicePlayBtn;

		// Token: 0x0400C10C RID: 49420
		[Token(Token = "0x400C10C")]
		[FieldOffset(Offset = "0x200")]
		public GameObject CommonVoicePlaying;

		// Token: 0x0400C10D RID: 49421
		[Token(Token = "0x400C10D")]
		[FieldOffset(Offset = "0x208")]
		public GameObject CommonVoiceNormal;

		// Token: 0x0400C10E RID: 49422
		[Token(Token = "0x400C10E")]
		[FieldOffset(Offset = "0x210")]
		public UILabel CommonAvatarName;

		// Token: 0x0400C10F RID: 49423
		[Token(Token = "0x400C10F")]
		[FieldOffset(Offset = "0x218")]
		public UILabel CommonAvatarDesc;

		// Token: 0x0400C110 RID: 49424
		[Token(Token = "0x400C110")]
		[FieldOffset(Offset = "0x220")]
		public GameObject CommonSkillPanel;

		// Token: 0x0400C111 RID: 49425
		[Token(Token = "0x400C111")]
		[FieldOffset(Offset = "0x228")]
		public UIPanel CommonSkillP;

		// Token: 0x0400C112 RID: 49426
		[Token(Token = "0x400C112")]
		[FieldOffset(Offset = "0x230")]
		public Transform CommonMainSkillPos;

		// Token: 0x0400C113 RID: 49427
		[Token(Token = "0x400C113")]
		[FieldOffset(Offset = "0x238")]
		public Transform CommonEquipPos1;

		// Token: 0x0400C114 RID: 49428
		[Token(Token = "0x400C114")]
		[FieldOffset(Offset = "0x240")]
		public Transform CommonEquipPos2;

		// Token: 0x0400C115 RID: 49429
		[Token(Token = "0x400C115")]
		[FieldOffset(Offset = "0x248")]
		public Transform CommonEquipPos3;

		// Token: 0x0400C116 RID: 49430
		[Token(Token = "0x400C116")]
		[FieldOffset(Offset = "0x250")]
		public UILabel CommonSkillType;

		// Token: 0x0400C117 RID: 49431
		[Token(Token = "0x400C117")]
		[FieldOffset(Offset = "0x258")]
		public UILabel CommonSkillName;

		// Token: 0x0400C118 RID: 49432
		[Token(Token = "0x400C118")]
		[FieldOffset(Offset = "0x260")]
		public UIButton CommonlevelUpEffectContainer;

		// Token: 0x0400C119 RID: 49433
		[Token(Token = "0x400C119")]
		[FieldOffset(Offset = "0x268")]
		public UIButton CommonLevelUpBtn;

		// Token: 0x0400C11A RID: 49434
		[Token(Token = "0x400C11A")]
		[FieldOffset(Offset = "0x270")]
		public UIScrollView CommonSkillDescScrollView;

		// Token: 0x0400C11B RID: 49435
		[Token(Token = "0x400C11B")]
		[FieldOffset(Offset = "0x278")]
		public UILabel CommonCurrentSkillDesc;

		// Token: 0x0400C11C RID: 49436
		[Token(Token = "0x400C11C")]
		[FieldOffset(Offset = "0x280")]
		public UIButton CommonLevelBtn;

		// Token: 0x0400C11D RID: 49437
		[Token(Token = "0x400C11D")]
		[FieldOffset(Offset = "0x288")]
		public UIWidget CommonLevelBtnWidgt;

		// Token: 0x0400C11E RID: 49438
		[Token(Token = "0x400C11E")]
		[FieldOffset(Offset = "0x290")]
		public GameObject CommonLevelTips;

		// Token: 0x0400C11F RID: 49439
		[Token(Token = "0x400C11F")]
		[FieldOffset(Offset = "0x298")]
		public GameObject CommonShowMode;

		// Token: 0x0400C120 RID: 49440
		[Token(Token = "0x400C120")]
		[FieldOffset(Offset = "0x2A0")]
		public GameObject CommonDisableMode;

		// Token: 0x0400C121 RID: 49441
		[Token(Token = "0x400C121")]
		[FieldOffset(Offset = "0x2A8")]
		public UILabel DisableLabel2;

		// Token: 0x0400C122 RID: 49442
		[Token(Token = "0x400C122")]
		[FieldOffset(Offset = "0x2B0")]
		public UIButton CommonTipBtn;

		// Token: 0x0400C123 RID: 49443
		[Token(Token = "0x400C123")]
		[FieldOffset(Offset = "0x2B8")]
		public GameObject CommonStoryPanel;

		// Token: 0x0400C124 RID: 49444
		[Token(Token = "0x400C124")]
		[FieldOffset(Offset = "0x2C0")]
		public UILabel CommonAge;

		// Token: 0x0400C125 RID: 49445
		[Token(Token = "0x400C125")]
		[FieldOffset(Offset = "0x2C8")]
		public UILabel CommonBirth;

		// Token: 0x0400C126 RID: 49446
		[Token(Token = "0x400C126")]
		[FieldOffset(Offset = "0x2D0")]
		public UILabel CommonCareer;

		// Token: 0x0400C127 RID: 49447
		[Token(Token = "0x400C127")]
		[FieldOffset(Offset = "0x2D8")]
		public UILabel CommonLove;

		// Token: 0x0400C128 RID: 49448
		[Token(Token = "0x400C128")]
		[FieldOffset(Offset = "0x2E0")]
		public UILabel CommonRelation1;

		// Token: 0x0400C129 RID: 49449
		[Token(Token = "0x400C129")]
		[FieldOffset(Offset = "0x2E8")]
		public UISprite CommonRelationIcon1;

		// Token: 0x0400C12A RID: 49450
		[Token(Token = "0x400C12A")]
		[FieldOffset(Offset = "0x2F0")]
		public UILabel CommonRelation2;

		// Token: 0x0400C12B RID: 49451
		[Token(Token = "0x400C12B")]
		[FieldOffset(Offset = "0x2F8")]
		public UISprite CommonRelationIcon2;

		// Token: 0x0400C12C RID: 49452
		[Token(Token = "0x400C12C")]
		[FieldOffset(Offset = "0x300")]
		public UILabel CommonRelation3;

		// Token: 0x0400C12D RID: 49453
		[Token(Token = "0x400C12D")]
		[FieldOffset(Offset = "0x308")]
		public UISprite CommonRelationIcon3;

		// Token: 0x0400C12E RID: 49454
		[Token(Token = "0x400C12E")]
		[FieldOffset(Offset = "0x310")]
		public UIButton CommonStoryBtn;

		// Token: 0x0400C12F RID: 49455
		[Token(Token = "0x400C12F")]
		[FieldOffset(Offset = "0x318")]
		public UISprite CommonSwitchSpr;

		// Token: 0x0400C130 RID: 49456
		[Token(Token = "0x400C130")]
		[FieldOffset(Offset = "0x320")]
		public UIButton CommonSwitchBtn;

		// Token: 0x0400C131 RID: 49457
		[Token(Token = "0x400C131")]
		[FieldOffset(Offset = "0x328")]
		public UISprite CommonSwitchIcon;

		// Token: 0x0400C132 RID: 49458
		[Token(Token = "0x400C132")]
		[FieldOffset(Offset = "0x330")]
		public GameObject Maxbg3;

		// Token: 0x0400C133 RID: 49459
		[Token(Token = "0x400C133")]
		[FieldOffset(Offset = "0x338")]
		public GameObject AwakenAvaytarNode;

		// Token: 0x0400C134 RID: 49460
		[Token(Token = "0x400C134")]
		[FieldOffset(Offset = "0x340")]
		public UISprite AwakenIPTag;

		// Token: 0x0400C135 RID: 49461
		[Token(Token = "0x400C135")]
		[FieldOffset(Offset = "0x348")]
		public UIButton AwakenVoicePlayBtn;

		// Token: 0x0400C136 RID: 49462
		[Token(Token = "0x400C136")]
		[FieldOffset(Offset = "0x350")]
		public GameObject AwakenVoicePlaying;

		// Token: 0x0400C137 RID: 49463
		[Token(Token = "0x400C137")]
		[FieldOffset(Offset = "0x358")]
		public GameObject AwakenVoiceNormal;

		// Token: 0x0400C138 RID: 49464
		[Token(Token = "0x400C138")]
		[FieldOffset(Offset = "0x360")]
		public UILabel AwakenAvatarName;

		// Token: 0x0400C139 RID: 49465
		[Token(Token = "0x400C139")]
		[FieldOffset(Offset = "0x368")]
		public UILabel AwakenAvatarDesc;

		// Token: 0x0400C13A RID: 49466
		[Token(Token = "0x400C13A")]
		[FieldOffset(Offset = "0x370")]
		public UIButton AwakenEntranceBtn;

		// Token: 0x0400C13B RID: 49467
		[Token(Token = "0x400C13B")]
		[FieldOffset(Offset = "0x378")]
		public UILabel awakenBtnLabel;

		// Token: 0x0400C13C RID: 49468
		[Token(Token = "0x400C13C")]
		[FieldOffset(Offset = "0x380")]
		public GameObject btnLabelVFX;

		// Token: 0x0400C13D RID: 49469
		[Token(Token = "0x400C13D")]
		[FieldOffset(Offset = "0x388")]
		public GameObject btnIconVFX;

		// Token: 0x0400C13E RID: 49470
		[Token(Token = "0x400C13E")]
		[FieldOffset(Offset = "0x390")]
		public GameObject AwakenEntranceTips;

		// Token: 0x0400C13F RID: 49471
		[Token(Token = "0x400C13F")]
		[FieldOffset(Offset = "0x398")]
		public GameObject AwakenAvatarExchangeContainer;

		// Token: 0x0400C140 RID: 49472
		[Token(Token = "0x400C140")]
		[FieldOffset(Offset = "0x3A0")]
		public UIButton ExchangeToOriAvatarBtn;

		// Token: 0x0400C141 RID: 49473
		[Token(Token = "0x400C141")]
		[FieldOffset(Offset = "0x3A8")]
		public UIAvatarAwakenSwitchItemView AvatarOriItem;

		// Token: 0x0400C142 RID: 49474
		[Token(Token = "0x400C142")]
		[FieldOffset(Offset = "0x3B0")]
		public UIButton ExchangeToAwakenAvatarBtn;

		// Token: 0x0400C143 RID: 49475
		[Token(Token = "0x400C143")]
		[FieldOffset(Offset = "0x3B8")]
		public UIAvatarAwakenSwitchItemView AvatarAwakenItem;

		// Token: 0x0400C144 RID: 49476
		[Token(Token = "0x400C144")]
		[FieldOffset(Offset = "0x3C0")]
		public GameObject AwakenUnLockKey;

		// Token: 0x0400C145 RID: 49477
		[Token(Token = "0x400C145")]
		[FieldOffset(Offset = "0x3C8")]
		public UISprite AwakenTagIcon;

		// Token: 0x0400C146 RID: 49478
		[Token(Token = "0x400C146")]
		[FieldOffset(Offset = "0x3D0")]
		public GameObject AwakenSkillPanel;

		// Token: 0x0400C147 RID: 49479
		[Token(Token = "0x400C147")]
		[FieldOffset(Offset = "0x3D8")]
		public UIPanel AwakenSkillP;

		// Token: 0x0400C148 RID: 49480
		[Token(Token = "0x400C148")]
		[FieldOffset(Offset = "0x3E0")]
		public Transform AwakenEquipPos1;

		// Token: 0x0400C149 RID: 49481
		[Token(Token = "0x400C149")]
		[FieldOffset(Offset = "0x3E8")]
		public Transform AwakenEquipPos2;

		// Token: 0x0400C14A RID: 49482
		[Token(Token = "0x400C14A")]
		[FieldOffset(Offset = "0x3F0")]
		public Transform AwakenEquipPos3;

		// Token: 0x0400C14B RID: 49483
		[Token(Token = "0x400C14B")]
		[FieldOffset(Offset = "0x3F8")]
		public Transform AwakenMainSkillPos;

		// Token: 0x0400C14C RID: 49484
		[Token(Token = "0x400C14C")]
		[FieldOffset(Offset = "0x400")]
		public UILabel AwakenSkillType;

		// Token: 0x0400C14D RID: 49485
		[Token(Token = "0x400C14D")]
		[FieldOffset(Offset = "0x408")]
		public UILabel AwakenSkillName;

		// Token: 0x0400C14E RID: 49486
		[Token(Token = "0x400C14E")]
		[FieldOffset(Offset = "0x410")]
		public UIButton AwakenlevelUpEffectContainer;

		// Token: 0x0400C14F RID: 49487
		[Token(Token = "0x400C14F")]
		[FieldOffset(Offset = "0x418")]
		public UIButton AwakenLevelUpBtn;

		// Token: 0x0400C150 RID: 49488
		[Token(Token = "0x400C150")]
		[FieldOffset(Offset = "0x420")]
		public UIScrollView AwakenSkillDescScrollView;

		// Token: 0x0400C151 RID: 49489
		[Token(Token = "0x400C151")]
		[FieldOffset(Offset = "0x428")]
		public UILabel AwakenCurrentSkillDesc;

		// Token: 0x0400C152 RID: 49490
		[Token(Token = "0x400C152")]
		[FieldOffset(Offset = "0x430")]
		public UIScrollView AwakenSkillDescScrollView1;

		// Token: 0x0400C153 RID: 49491
		[Token(Token = "0x400C153")]
		[FieldOffset(Offset = "0x438")]
		public UILabel AwakenCurrentSkillDesc1;

		// Token: 0x0400C154 RID: 49492
		[Token(Token = "0x400C154")]
		[FieldOffset(Offset = "0x440")]
		public UIButton AwakenLevelBtn;

		// Token: 0x0400C155 RID: 49493
		[Token(Token = "0x400C155")]
		[FieldOffset(Offset = "0x448")]
		public UIWidget AwakenLevelBtnWidgt;

		// Token: 0x0400C156 RID: 49494
		[Token(Token = "0x400C156")]
		[FieldOffset(Offset = "0x450")]
		public GameObject AwakenLevelTips;

		// Token: 0x0400C157 RID: 49495
		[Token(Token = "0x400C157")]
		[FieldOffset(Offset = "0x458")]
		public GameObject AwakenSHowMode;

		// Token: 0x0400C158 RID: 49496
		[Token(Token = "0x400C158")]
		[FieldOffset(Offset = "0x460")]
		public GameObject AwakenDisableMode;

		// Token: 0x0400C159 RID: 49497
		[Token(Token = "0x400C159")]
		[FieldOffset(Offset = "0x468")]
		public UILabel DisableLevel1;

		// Token: 0x0400C15A RID: 49498
		[Token(Token = "0x400C15A")]
		[FieldOffset(Offset = "0x470")]
		public UIButton AwakenTipBtn;

		// Token: 0x0400C15B RID: 49499
		[Token(Token = "0x400C15B")]
		[FieldOffset(Offset = "0x478")]
		public GameObject AwakenStoryPanel;

		// Token: 0x0400C15C RID: 49500
		[Token(Token = "0x400C15C")]
		[FieldOffset(Offset = "0x480")]
		public UILabel AwakenAge;

		// Token: 0x0400C15D RID: 49501
		[Token(Token = "0x400C15D")]
		[FieldOffset(Offset = "0x488")]
		public UILabel AwakenBirth;

		// Token: 0x0400C15E RID: 49502
		[Token(Token = "0x400C15E")]
		[FieldOffset(Offset = "0x490")]
		public UILabel AwakenCareer;

		// Token: 0x0400C15F RID: 49503
		[Token(Token = "0x400C15F")]
		[FieldOffset(Offset = "0x498")]
		public UILabel AwakenLove;

		// Token: 0x0400C160 RID: 49504
		[Token(Token = "0x400C160")]
		[FieldOffset(Offset = "0x4A0")]
		public UILabel AwakenRelation1;

		// Token: 0x0400C161 RID: 49505
		[Token(Token = "0x400C161")]
		[FieldOffset(Offset = "0x4A8")]
		public UISprite AwakenRelationIcon1;

		// Token: 0x0400C162 RID: 49506
		[Token(Token = "0x400C162")]
		[FieldOffset(Offset = "0x4B0")]
		public UILabel AwakenRelation2;

		// Token: 0x0400C163 RID: 49507
		[Token(Token = "0x400C163")]
		[FieldOffset(Offset = "0x4B8")]
		public UISprite AwakenRelationIcon2;

		// Token: 0x0400C164 RID: 49508
		[Token(Token = "0x400C164")]
		[FieldOffset(Offset = "0x4C0")]
		public UILabel AwakenRelation3;

		// Token: 0x0400C165 RID: 49509
		[Token(Token = "0x400C165")]
		[FieldOffset(Offset = "0x4C8")]
		public UISprite AwakenRelationIcon3;

		// Token: 0x0400C166 RID: 49510
		[Token(Token = "0x400C166")]
		[FieldOffset(Offset = "0x4D0")]
		public UIButton AwakenStoryBtn;

		// Token: 0x0400C167 RID: 49511
		[Token(Token = "0x400C167")]
		[FieldOffset(Offset = "0x4D8")]
		public UISprite AwakenSwitchSpr;

		// Token: 0x0400C168 RID: 49512
		[Token(Token = "0x400C168")]
		[FieldOffset(Offset = "0x4E0")]
		public UIButton AwakenSwitchBtn;

		// Token: 0x0400C169 RID: 49513
		[Token(Token = "0x400C169")]
		[FieldOffset(Offset = "0x4E8")]
		public UISprite AwakenSwitchIcon;

		// Token: 0x0400C16A RID: 49514
		[Token(Token = "0x400C16A")]
		[FieldOffset(Offset = "0x4F0")]
		public GameObject Maxbg2;

		// Token: 0x0400C16B RID: 49515
		[Token(Token = "0x400C16B")]
		[FieldOffset(Offset = "0x4F8")]
		public UIButton VoiceDownloadBtn;
	}
}
