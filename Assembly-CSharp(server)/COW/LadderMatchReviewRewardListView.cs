using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020C6 RID: 8390
	[Token(Token = "0x20020C6")]
	public class LadderMatchReviewRewardListView : UIBaseView
	{
		// Token: 0x0600BC9D RID: 48285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC9D")]
		[Address(RVA = "0x13FC198", Offset = "0x13FC198", VA = "0x7BBBBFC198", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BC9E RID: 48286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC9E")]
		[Address(RVA = "0x13FC380", Offset = "0x13FC380", VA = "0x7BBBBFC380")]
		public LadderMatchReviewRewardListView()
		{
		}

		// Token: 0x0400BDA7 RID: 48551
		[Token(Token = "0x400BDA7")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView ScrollView;

		// Token: 0x0400BDA8 RID: 48552
		[Token(Token = "0x400BDA8")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList EasyList;

		// Token: 0x0400BDA9 RID: 48553
		[Token(Token = "0x400BDA9")]
		[FieldOffset(Offset = "0x30")]
		public UINetworkTextureExt CdnReward;

		// Token: 0x0400BDAA RID: 48554
		[Token(Token = "0x400BDAA")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabeCSTip;

		// Token: 0x0400BDAB RID: 48555
		[Token(Token = "0x400BDAB")]
		[FieldOffset(Offset = "0x40")]
		public UILabel LabeBRTip;

		// Token: 0x0400BDAC RID: 48556
		[Token(Token = "0x400BDAC")]
		[FieldOffset(Offset = "0x48")]
		public UISprite SpriteRank;
	}
}
