using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023EA RID: 9194
	[Token(Token = "0x20023EA")]
	public class UILinkActivitySimpleView : UIBaseView
	{
		// Token: 0x0600C2E4 RID: 49892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E4")]
		[Address(RVA = "0x1CC262C", Offset = "0x1CC262C", VA = "0x7BBC4C262C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2E5 RID: 49893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E5")]
		[Address(RVA = "0x1CC2A50", Offset = "0x1CC2A50", VA = "0x7BBC4C2A50")]
		public UILinkActivitySimpleView()
		{
		}

		// Token: 0x0400E0E7 RID: 57575
		[Token(Token = "0x400E0E7")]
		[FieldOffset(Offset = "0x20")]
		public UINetworkTexture cdn;

		// Token: 0x0400E0E8 RID: 57576
		[Token(Token = "0x400E0E8")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Title;

		// Token: 0x0400E0E9 RID: 57577
		[Token(Token = "0x400E0E9")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Desc;

		// Token: 0x0400E0EA RID: 57578
		[Token(Token = "0x400E0EA")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnClose;

		// Token: 0x0400E0EB RID: 57579
		[Token(Token = "0x400E0EB")]
		[FieldOffset(Offset = "0x40")]
		public GameObject DailyRewardsGot;

		// Token: 0x0400E0EC RID: 57580
		[Token(Token = "0x400E0EC")]
		[FieldOffset(Offset = "0x48")]
		public UILabel RewardTitle;

		// Token: 0x0400E0ED RID: 57581
		[Token(Token = "0x400E0ED")]
		[FieldOffset(Offset = "0x50")]
		public UIGrid RewardList;

		// Token: 0x0400E0EE RID: 57582
		[Token(Token = "0x400E0EE")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BigRewardDesc;

		// Token: 0x0400E0EF RID: 57583
		[Token(Token = "0x400E0EF")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnBox;

		// Token: 0x0400E0F0 RID: 57584
		[Token(Token = "0x400E0F0")]
		[FieldOffset(Offset = "0x68")]
		public UISprite BigRewardIcon;

		// Token: 0x0400E0F1 RID: 57585
		[Token(Token = "0x400E0F1")]
		[FieldOffset(Offset = "0x70")]
		public UILabel FinishCounts;

		// Token: 0x0400E0F2 RID: 57586
		[Token(Token = "0x400E0F2")]
		[FieldOffset(Offset = "0x78")]
		public UILabel FinishCountsCurrent;

		// Token: 0x0400E0F3 RID: 57587
		[Token(Token = "0x400E0F3")]
		[FieldOffset(Offset = "0x80")]
		public UILabel FinishCountsTotal;

		// Token: 0x0400E0F4 RID: 57588
		[Token(Token = "0x400E0F4")]
		[FieldOffset(Offset = "0x88")]
		public UIProgressBar FinishProgress;

		// Token: 0x0400E0F5 RID: 57589
		[Token(Token = "0x400E0F5")]
		[FieldOffset(Offset = "0x90")]
		public UILabel Days;

		// Token: 0x0400E0F6 RID: 57590
		[Token(Token = "0x400E0F6")]
		[FieldOffset(Offset = "0x98")]
		public UIButton BtnGoto;
	}
}
