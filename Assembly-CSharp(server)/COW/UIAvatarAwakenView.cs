using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020F9 RID: 8441
	[Token(Token = "0x20020F9")]
	public class UIAvatarAwakenView : UIBaseView
	{
		// Token: 0x0600BD03 RID: 48387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD03")]
		[Address(RVA = "0x1B21B40", Offset = "0x1B21B40", VA = "0x7BBC321B40", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD04 RID: 48388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD04")]
		[Address(RVA = "0x1B2268C", Offset = "0x1B2268C", VA = "0x7BBC32268C")]
		public UIAvatarAwakenView()
		{
		}

		// Token: 0x0400BFD4 RID: 49108
		[Token(Token = "0x400BFD4")]
		[FieldOffset(Offset = "0x20")]
		public UIButton RightArrowBtn;

		// Token: 0x0400BFD5 RID: 49109
		[Token(Token = "0x400BFD5")]
		[FieldOffset(Offset = "0x28")]
		public GameObject RightShowDisable;

		// Token: 0x0400BFD6 RID: 49110
		[Token(Token = "0x400BFD6")]
		[FieldOffset(Offset = "0x30")]
		public UIButton LeftArrorwBtn;

		// Token: 0x0400BFD7 RID: 49111
		[Token(Token = "0x400BFD7")]
		[FieldOffset(Offset = "0x38")]
		public GameObject LeftShowDisable;

		// Token: 0x0400BFD8 RID: 49112
		[Token(Token = "0x400BFD8")]
		[FieldOffset(Offset = "0x40")]
		public GameObject VFX_UI_Trail_Comic;

		// Token: 0x0400BFD9 RID: 49113
		[Token(Token = "0x400BFD9")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Energy_01_Comic;

		// Token: 0x0400BFDA RID: 49114
		[Token(Token = "0x400BFDA")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Energy_02_Comic;

		// Token: 0x0400BFDB RID: 49115
		[Token(Token = "0x400BFDB")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Energy_03_Comic;

		// Token: 0x0400BFDC RID: 49116
		[Token(Token = "0x400BFDC")]
		[FieldOffset(Offset = "0x60")]
		public UIScrollView StoryScrollView;

		// Token: 0x0400BFDD RID: 49117
		[Token(Token = "0x400BFDD")]
		[FieldOffset(Offset = "0x68")]
		public GameObject StoryUnlock;

		// Token: 0x0400BFDE RID: 49118
		[Token(Token = "0x400BFDE")]
		[FieldOffset(Offset = "0x70")]
		public UIGrid StoryItemList;

		// Token: 0x0400BFDF RID: 49119
		[Token(Token = "0x400BFDF")]
		[FieldOffset(Offset = "0x78")]
		public UIAvatarAwakenStoryItemController StoryItem;

		// Token: 0x0400BFE0 RID: 49120
		[Token(Token = "0x400BFE0")]
		[FieldOffset(Offset = "0x80")]
		public GameObject CanUnlockEffect;

		// Token: 0x0400BFE1 RID: 49121
		[Token(Token = "0x400BFE1")]
		[FieldOffset(Offset = "0x88")]
		public GameObject CanUnlock_1;

		// Token: 0x0400BFE2 RID: 49122
		[Token(Token = "0x400BFE2")]
		[FieldOffset(Offset = "0x90")]
		public GameObject CanUnlock_2;

		// Token: 0x0400BFE3 RID: 49123
		[Token(Token = "0x400BFE3")]
		[FieldOffset(Offset = "0x98")]
		public GameObject CanUnlock_3;

		// Token: 0x0400BFE4 RID: 49124
		[Token(Token = "0x400BFE4")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject unlockEffect_Once;

		// Token: 0x0400BFE5 RID: 49125
		[Token(Token = "0x400BFE5")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject Unlock_1;

		// Token: 0x0400BFE6 RID: 49126
		[Token(Token = "0x400BFE6")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject Unlock_2;

		// Token: 0x0400BFE7 RID: 49127
		[Token(Token = "0x400BFE7")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject Unlock_3;

		// Token: 0x0400BFE8 RID: 49128
		[Token(Token = "0x400BFE8")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject UnlockEffect;

		// Token: 0x0400BFE9 RID: 49129
		[Token(Token = "0x400BFE9")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject AwakenState;

		// Token: 0x0400BFEA RID: 49130
		[Token(Token = "0x400BFEA")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject OnGoing;

		// Token: 0x0400BFEB RID: 49131
		[Token(Token = "0x400BFEB")]
		[FieldOffset(Offset = "0xD8")]
		public UIButton AwardIcon;

		// Token: 0x0400BFEC RID: 49132
		[Token(Token = "0x400BFEC")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject effGo;

		// Token: 0x0400BFED RID: 49133
		[Token(Token = "0x400BFED")]
		[FieldOffset(Offset = "0xE8")]
		public UIProgressBar FinishProgress;

		// Token: 0x0400BFEE RID: 49134
		[Token(Token = "0x400BFEE")]
		[FieldOffset(Offset = "0xF0")]
		public UIButton AwakenBtn;

		// Token: 0x0400BFEF RID: 49135
		[Token(Token = "0x400BFEF")]
		[FieldOffset(Offset = "0xF8")]
		public UIButton AwakenBtnDisable;

		// Token: 0x0400BFF0 RID: 49136
		[Token(Token = "0x400BFF0")]
		[FieldOffset(Offset = "0x100")]
		public UILabel AwakenDescLabel;

		// Token: 0x0400BFF1 RID: 49137
		[Token(Token = "0x400BFF1")]
		[FieldOffset(Offset = "0x108")]
		public GameObject AwakenTask;

		// Token: 0x0400BFF2 RID: 49138
		[Token(Token = "0x400BFF2")]
		[FieldOffset(Offset = "0x110")]
		public GameObject TaskLock;

		// Token: 0x0400BFF3 RID: 49139
		[Token(Token = "0x400BFF3")]
		[FieldOffset(Offset = "0x118")]
		public UILabel LockInfo;

		// Token: 0x0400BFF4 RID: 49140
		[Token(Token = "0x400BFF4")]
		[FieldOffset(Offset = "0x120")]
		public UIButton GainAvatarBtn;

		// Token: 0x0400BFF5 RID: 49141
		[Token(Token = "0x400BFF5")]
		[FieldOffset(Offset = "0x128")]
		public UIButton LevelUpBtn;

		// Token: 0x0400BFF6 RID: 49142
		[Token(Token = "0x400BFF6")]
		[FieldOffset(Offset = "0x130")]
		public GameObject taskList;

		// Token: 0x0400BFF7 RID: 49143
		[Token(Token = "0x400BFF7")]
		[FieldOffset(Offset = "0x138")]
		public UIWidget listBgContent;

		// Token: 0x0400BFF8 RID: 49144
		[Token(Token = "0x400BFF8")]
		[FieldOffset(Offset = "0x140")]
		public GameObject TaskPos1;

		// Token: 0x0400BFF9 RID: 49145
		[Token(Token = "0x400BFF9")]
		[FieldOffset(Offset = "0x148")]
		public GameObject TaskPos2;

		// Token: 0x0400BFFA RID: 49146
		[Token(Token = "0x400BFFA")]
		[FieldOffset(Offset = "0x150")]
		public GameObject TaskPos3;

		// Token: 0x0400BFFB RID: 49147
		[Token(Token = "0x400BFFB")]
		[FieldOffset(Offset = "0x158")]
		public UIAvatarAwakenTaskItemController taskItem;

		// Token: 0x0400BFFC RID: 49148
		[Token(Token = "0x400BFFC")]
		[FieldOffset(Offset = "0x160")]
		public GameObject VFX_UI_Trail;

		// Token: 0x0400BFFD RID: 49149
		[Token(Token = "0x400BFFD")]
		[FieldOffset(Offset = "0x168")]
		public GameObject Energy_01;

		// Token: 0x0400BFFE RID: 49150
		[Token(Token = "0x400BFFE")]
		[FieldOffset(Offset = "0x170")]
		public GameObject Energy_02;

		// Token: 0x0400BFFF RID: 49151
		[Token(Token = "0x400BFFF")]
		[FieldOffset(Offset = "0x178")]
		public GameObject Energy_03;

		// Token: 0x0400C000 RID: 49152
		[Token(Token = "0x400C000")]
		[FieldOffset(Offset = "0x180")]
		public UIButton RefreshBtn;

		// Token: 0x0400C001 RID: 49153
		[Token(Token = "0x400C001")]
		[FieldOffset(Offset = "0x188")]
		public GameObject RefreshPrice;

		// Token: 0x0400C002 RID: 49154
		[Token(Token = "0x400C002")]
		[FieldOffset(Offset = "0x190")]
		public UILabel CurrencyNum;

		// Token: 0x0400C003 RID: 49155
		[Token(Token = "0x400C003")]
		[FieldOffset(Offset = "0x198")]
		public UISprite CurrencyIcon;

		// Token: 0x0400C004 RID: 49156
		[Token(Token = "0x400C004")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject RefreshLimit;
	}
}
