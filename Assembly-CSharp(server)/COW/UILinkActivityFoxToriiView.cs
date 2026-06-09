using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023E6 RID: 9190
	[Token(Token = "0x20023E6")]
	public class UILinkActivityFoxToriiView : UIBaseView
	{
		// Token: 0x0600C2DC RID: 49884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2DC")]
		[Address(RVA = "0x1CBD79C", Offset = "0x1CBD79C", VA = "0x7BBC4BD79C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2DD RID: 49885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2DD")]
		[Address(RVA = "0x1CBDE44", Offset = "0x1CBDE44", VA = "0x7BBC4BDE44")]
		public UILinkActivityFoxToriiView()
		{
		}

		// Token: 0x0400E0A5 RID: 57509
		[Token(Token = "0x400E0A5")]
		[FieldOffset(Offset = "0x20")]
		public UINetworkTexture CDN_BG;

		// Token: 0x0400E0A6 RID: 57510
		[Token(Token = "0x400E0A6")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid RewardList;

		// Token: 0x0400E0A7 RID: 57511
		[Token(Token = "0x400E0A7")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnBox;

		// Token: 0x0400E0A8 RID: 57512
		[Token(Token = "0x400E0A8")]
		[FieldOffset(Offset = "0x38")]
		public UILabel BigRewardDesc;

		// Token: 0x0400E0A9 RID: 57513
		[Token(Token = "0x400E0A9")]
		[FieldOffset(Offset = "0x40")]
		public UILabel FinishCounts;

		// Token: 0x0400E0AA RID: 57514
		[Token(Token = "0x400E0AA")]
		[FieldOffset(Offset = "0x48")]
		public UILabel TotalCounts;

		// Token: 0x0400E0AB RID: 57515
		[Token(Token = "0x400E0AB")]
		[FieldOffset(Offset = "0x50")]
		public GameObject BoxUnFinished;

		// Token: 0x0400E0AC RID: 57516
		[Token(Token = "0x400E0AC")]
		[FieldOffset(Offset = "0x58")]
		public UISprite BigRewardIconUnFinished;

		// Token: 0x0400E0AD RID: 57517
		[Token(Token = "0x400E0AD")]
		[FieldOffset(Offset = "0x60")]
		public GameObject BoxFinished;

		// Token: 0x0400E0AE RID: 57518
		[Token(Token = "0x400E0AE")]
		[FieldOffset(Offset = "0x68")]
		public UISprite BigRewardIconFinished;

		// Token: 0x0400E0AF RID: 57519
		[Token(Token = "0x400E0AF")]
		[FieldOffset(Offset = "0x70")]
		public GameObject BoxRewarded;

		// Token: 0x0400E0B0 RID: 57520
		[Token(Token = "0x400E0B0")]
		[FieldOffset(Offset = "0x78")]
		public UISprite BigRewardIconRewarded;

		// Token: 0x0400E0B1 RID: 57521
		[Token(Token = "0x400E0B1")]
		[FieldOffset(Offset = "0x80")]
		public UIProgressBar ProgressBarBg;

		// Token: 0x0400E0B2 RID: 57522
		[Token(Token = "0x400E0B2")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BtnClose;

		// Token: 0x0400E0B3 RID: 57523
		[Token(Token = "0x400E0B3")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnGoto;

		// Token: 0x0400E0B4 RID: 57524
		[Token(Token = "0x400E0B4")]
		[FieldOffset(Offset = "0x98")]
		public UILabel LabelWaitNext;

		// Token: 0x0400E0B5 RID: 57525
		[Token(Token = "0x400E0B5")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject BigMapPanel;

		// Token: 0x0400E0B6 RID: 57526
		[Token(Token = "0x400E0B6")]
		[FieldOffset(Offset = "0xA8")]
		public UITexture BigMap;

		// Token: 0x0400E0B7 RID: 57527
		[Token(Token = "0x400E0B7")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton BigmapMask;

		// Token: 0x0400E0B8 RID: 57528
		[Token(Token = "0x400E0B8")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton ZoomOutBtn;

		// Token: 0x0400E0B9 RID: 57529
		[Token(Token = "0x400E0B9")]
		[FieldOffset(Offset = "0xC0")]
		public UINetworkTexture Minimap;

		// Token: 0x0400E0BA RID: 57530
		[Token(Token = "0x400E0BA")]
		[FieldOffset(Offset = "0xC8")]
		public UINetworkTexture CdnTexture;

		// Token: 0x0400E0BB RID: 57531
		[Token(Token = "0x400E0BB")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject Finished;

		// Token: 0x0400E0BC RID: 57532
		[Token(Token = "0x400E0BC")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel CurDayLabel;

		// Token: 0x0400E0BD RID: 57533
		[Token(Token = "0x400E0BD")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel TotalDayLabel;

		// Token: 0x0400E0BE RID: 57534
		[Token(Token = "0x400E0BE")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton ZoomInBtn;
	}
}
