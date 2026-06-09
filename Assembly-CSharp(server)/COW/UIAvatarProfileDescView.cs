using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002103 RID: 8451
	[Token(Token = "0x2002103")]
	public class UIAvatarProfileDescView : UIBaseView
	{
		// Token: 0x0600BD17 RID: 48407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD17")]
		[Address(RVA = "0x208877C", Offset = "0x208877C", VA = "0x7BBC88877C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD18 RID: 48408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD18")]
		[Address(RVA = "0x2089108", Offset = "0x2089108", VA = "0x7BBC889108")]
		public UIAvatarProfileDescView()
		{
		}

		// Token: 0x0400C068 RID: 49256
		[Token(Token = "0x400C068")]
		[FieldOffset(Offset = "0x20")]
		public UISprite RewardIcon;

		// Token: 0x0400C069 RID: 49257
		[Token(Token = "0x400C069")]
		[FieldOffset(Offset = "0x28")]
		public Transform SkillIcon;

		// Token: 0x0400C06A RID: 49258
		[Token(Token = "0x400C06A")]
		[FieldOffset(Offset = "0x30")]
		public UILabel RewardName;

		// Token: 0x0400C06B RID: 49259
		[Token(Token = "0x400C06B")]
		[FieldOffset(Offset = "0x38")]
		public UILabel RewardDesc;

		// Token: 0x0400C06C RID: 49260
		[Token(Token = "0x400C06C")]
		[FieldOffset(Offset = "0x40")]
		public GameObject LockBg;

		// Token: 0x0400C06D RID: 49261
		[Token(Token = "0x400C06D")]
		[FieldOffset(Offset = "0x48")]
		public GameObject SelectedObject;

		// Token: 0x0400C06E RID: 49262
		[Token(Token = "0x400C06E")]
		[FieldOffset(Offset = "0x50")]
		public GameObject UnlockedNode;

		// Token: 0x0400C06F RID: 49263
		[Token(Token = "0x400C06F")]
		[FieldOffset(Offset = "0x58")]
		public UILabel UnLockedNameLabel;

		// Token: 0x0400C070 RID: 49264
		[Token(Token = "0x400C070")]
		[FieldOffset(Offset = "0x60")]
		public UIScrollView StoryScrollView;

		// Token: 0x0400C071 RID: 49265
		[Token(Token = "0x400C071")]
		[FieldOffset(Offset = "0x68")]
		public UILabel StoryLabel;

		// Token: 0x0400C072 RID: 49266
		[Token(Token = "0x400C072")]
		[FieldOffset(Offset = "0x70")]
		public BoxCollider StoryScorableCollider;

		// Token: 0x0400C073 RID: 49267
		[Token(Token = "0x400C073")]
		[FieldOffset(Offset = "0x78")]
		public GameObject CanUnlockNode;

		// Token: 0x0400C074 RID: 49268
		[Token(Token = "0x400C074")]
		[FieldOffset(Offset = "0x80")]
		public GameObject CanUnlockContent;

		// Token: 0x0400C075 RID: 49269
		[Token(Token = "0x400C075")]
		[FieldOffset(Offset = "0x88")]
		public GameObject DebrisInfoObject;

		// Token: 0x0400C076 RID: 49270
		[Token(Token = "0x400C076")]
		[FieldOffset(Offset = "0x90")]
		public UIButton UnlockRuleBtn;

		// Token: 0x0400C077 RID: 49271
		[Token(Token = "0x400C077")]
		[FieldOffset(Offset = "0x98")]
		public UISprite AvatarIcon;

		// Token: 0x0400C078 RID: 49272
		[Token(Token = "0x400C078")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel DebrisCountTxt;

		// Token: 0x0400C079 RID: 49273
		[Token(Token = "0x400C079")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton PurchaseDebrisBtn;

		// Token: 0x0400C07A RID: 49274
		[Token(Token = "0x400C07A")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton ExchangeDebrisBtn;

		// Token: 0x0400C07B RID: 49275
		[Token(Token = "0x400C07B")]
		[FieldOffset(Offset = "0xB8")]
		public Transform DebrisExchange;

		// Token: 0x0400C07C RID: 49276
		[Token(Token = "0x400C07C")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel UniversalDebrisCnt;

		// Token: 0x0400C07D RID: 49277
		[Token(Token = "0x400C07D")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject UnlockConditionObject;

		// Token: 0x0400C07E RID: 49278
		[Token(Token = "0x400C07E")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel UnlockLevelValue;

		// Token: 0x0400C07F RID: 49279
		[Token(Token = "0x400C07F")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject lockedOrLabel;

		// Token: 0x0400C080 RID: 49280
		[Token(Token = "0x400C080")]
		[FieldOffset(Offset = "0xE0")]
		public UITable lockedTable;

		// Token: 0x0400C081 RID: 49281
		[Token(Token = "0x400C081")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton LockedCoinBtn;

		// Token: 0x0400C082 RID: 49282
		[Token(Token = "0x400C082")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel CoinCountValue;

		// Token: 0x0400C083 RID: 49283
		[Token(Token = "0x400C083")]
		[FieldOffset(Offset = "0xF8")]
		public UIButton LockedGemBtn;

		// Token: 0x0400C084 RID: 49284
		[Token(Token = "0x400C084")]
		[FieldOffset(Offset = "0x100")]
		public UILabel GemCountValue;

		// Token: 0x0400C085 RID: 49285
		[Token(Token = "0x400C085")]
		[FieldOffset(Offset = "0x108")]
		public GameObject PurchaseObject;

		// Token: 0x0400C086 RID: 49286
		[Token(Token = "0x400C086")]
		[FieldOffset(Offset = "0x110")]
		public GameObject PurchaseOrLabel;

		// Token: 0x0400C087 RID: 49287
		[Token(Token = "0x400C087")]
		[FieldOffset(Offset = "0x118")]
		public UITable PurchaseTable;

		// Token: 0x0400C088 RID: 49288
		[Token(Token = "0x400C088")]
		[FieldOffset(Offset = "0x120")]
		public UIButton CoinButton;

		// Token: 0x0400C089 RID: 49289
		[Token(Token = "0x400C089")]
		[FieldOffset(Offset = "0x128")]
		public UILabel CoinCount;

		// Token: 0x0400C08A RID: 49290
		[Token(Token = "0x400C08A")]
		[FieldOffset(Offset = "0x130")]
		public UIButton GemButton;

		// Token: 0x0400C08B RID: 49291
		[Token(Token = "0x400C08B")]
		[FieldOffset(Offset = "0x138")]
		public UILabel GemCount;

		// Token: 0x0400C08C RID: 49292
		[Token(Token = "0x400C08C")]
		[FieldOffset(Offset = "0x140")]
		public GameObject NotOwnObject;

		// Token: 0x0400C08D RID: 49293
		[Token(Token = "0x400C08D")]
		[FieldOffset(Offset = "0x148")]
		public Animator UnLockAnim;

		// Token: 0x0400C08E RID: 49294
		[Token(Token = "0x400C08E")]
		[FieldOffset(Offset = "0x150")]
		public GameObject LockedNode;

		// Token: 0x0400C08F RID: 49295
		[Token(Token = "0x400C08F")]
		[FieldOffset(Offset = "0x158")]
		public GameObject LockSprite;
	}
}
