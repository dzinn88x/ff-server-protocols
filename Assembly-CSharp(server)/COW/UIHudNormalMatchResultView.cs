using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002320 RID: 8992
	[Token(Token = "0x2002320")]
	public class UIHudNormalMatchResultView : UIBaseView
	{
		// Token: 0x0600C150 RID: 49488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C150")]
		[Address(RVA = "0x17BAD58", Offset = "0x17BAD58", VA = "0x7BBBFBAD58", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C151 RID: 49489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C151")]
		[Address(RVA = "0x17BB640", Offset = "0x17BB640", VA = "0x7BBBFBB640")]
		public UIHudNormalMatchResultView()
		{
		}

		// Token: 0x0400D9C9 RID: 55753
		[Token(Token = "0x400D9C9")]
		[FieldOffset(Offset = "0x20")]
		public Animator HudNormalMatchResAni;

		// Token: 0x0400D9CA RID: 55754
		[Token(Token = "0x400D9CA")]
		[FieldOffset(Offset = "0x28")]
		public UILabel RankNum;

		// Token: 0x0400D9CB RID: 55755
		[Token(Token = "0x400D9CB")]
		[FieldOffset(Offset = "0x30")]
		public UILabel TotalNum;

		// Token: 0x0400D9CC RID: 55756
		[Token(Token = "0x400D9CC")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ResultDesc;

		// Token: 0x0400D9CD RID: 55757
		[Token(Token = "0x400D9CD")]
		[FieldOffset(Offset = "0x40")]
		public Transform BaseReward;

		// Token: 0x0400D9CE RID: 55758
		[Token(Token = "0x400D9CE")]
		[FieldOffset(Offset = "0x48")]
		public UILabel GameModeTxt;

		// Token: 0x0400D9CF RID: 55759
		[Token(Token = "0x400D9CF")]
		[FieldOffset(Offset = "0x50")]
		public UILabel GameMapTxt;

		// Token: 0x0400D9D0 RID: 55760
		[Token(Token = "0x400D9D0")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BiaoQianOB;

		// Token: 0x0400D9D1 RID: 55761
		[Token(Token = "0x400D9D1")]
		[FieldOffset(Offset = "0x60")]
		public UIWidget Biaoqian1;

		// Token: 0x0400D9D2 RID: 55762
		[Token(Token = "0x400D9D2")]
		[FieldOffset(Offset = "0x68")]
		public UIWidget Biaoqian2;

		// Token: 0x0400D9D3 RID: 55763
		[Token(Token = "0x400D9D3")]
		[FieldOffset(Offset = "0x70")]
		public UIWidget Biaoqian3;

		// Token: 0x0400D9D4 RID: 55764
		[Token(Token = "0x400D9D4")]
		[FieldOffset(Offset = "0x78")]
		public UIWidget Biaoqian4;

		// Token: 0x0400D9D5 RID: 55765
		[Token(Token = "0x400D9D5")]
		[FieldOffset(Offset = "0x80")]
		public UIWidget PlaceHolderBiaoqian;

		// Token: 0x0400D9D6 RID: 55766
		[Token(Token = "0x400D9D6")]
		[FieldOffset(Offset = "0x88")]
		public UILabel TitleInfo1Txt;

		// Token: 0x0400D9D7 RID: 55767
		[Token(Token = "0x400D9D7")]
		[FieldOffset(Offset = "0x90")]
		public UILabel TitleInfo2Txt;

		// Token: 0x0400D9D8 RID: 55768
		[Token(Token = "0x400D9D8")]
		[FieldOffset(Offset = "0x98")]
		public UILabel TitleInfo3Txt;

		// Token: 0x0400D9D9 RID: 55769
		[Token(Token = "0x400D9D9")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel TitleInfo4Txt;

		// Token: 0x0400D9DA RID: 55770
		[Token(Token = "0x400D9DA")]
		[FieldOffset(Offset = "0xA8")]
		public Transform PlayerItemInfo1;

		// Token: 0x0400D9DB RID: 55771
		[Token(Token = "0x400D9DB")]
		[FieldOffset(Offset = "0xB0")]
		public Transform PlayerItemInfo2;

		// Token: 0x0400D9DC RID: 55772
		[Token(Token = "0x400D9DC")]
		[FieldOffset(Offset = "0xB8")]
		public Transform PlayerItemInfo3;

		// Token: 0x0400D9DD RID: 55773
		[Token(Token = "0x400D9DD")]
		[FieldOffset(Offset = "0xC0")]
		public Transform PlayerItemInfo4;

		// Token: 0x0400D9DE RID: 55774
		[Token(Token = "0x400D9DE")]
		[FieldOffset(Offset = "0xC8")]
		public UIButton ShareBtn;

		// Token: 0x0400D9DF RID: 55775
		[Token(Token = "0x400D9DF")]
		[FieldOffset(Offset = "0xD0")]
		public UIButton NextBtn;

		// Token: 0x0400D9E0 RID: 55776
		[Token(Token = "0x400D9E0")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel NextBtnTime;

		// Token: 0x0400D9E1 RID: 55777
		[Token(Token = "0x400D9E1")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel NextBtnLable;

		// Token: 0x0400D9E2 RID: 55778
		[Token(Token = "0x400D9E2")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton DetailsBtn;

		// Token: 0x0400D9E3 RID: 55779
		[Token(Token = "0x400D9E3")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject DetailBtnShowIcon;

		// Token: 0x0400D9E4 RID: 55780
		[Token(Token = "0x400D9E4")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject DetailBtnHideIcon;

		// Token: 0x0400D9E5 RID: 55781
		[Token(Token = "0x400D9E5")]
		[FieldOffset(Offset = "0x100")]
		public UIGrid RewardBtnGrid;

		// Token: 0x0400D9E6 RID: 55782
		[Token(Token = "0x400D9E6")]
		[FieldOffset(Offset = "0x108")]
		public UIButton VideoGiftBtn;

		// Token: 0x0400D9E7 RID: 55783
		[Token(Token = "0x400D9E7")]
		[FieldOffset(Offset = "0x110")]
		public UIButton FastSendGiftBtn;

		// Token: 0x0400D9E8 RID: 55784
		[Token(Token = "0x400D9E8")]
		[FieldOffset(Offset = "0x118")]
		public Transform CallSignContainer;

		// Token: 0x0400D9E9 RID: 55785
		[Token(Token = "0x400D9E9")]
		[FieldOffset(Offset = "0x120")]
		public GameObject ShareInfoContainer;

		// Token: 0x0400D9EA RID: 55786
		[Token(Token = "0x400D9EA")]
		[FieldOffset(Offset = "0x128")]
		public UILabel ShareGameModeTxt;

		// Token: 0x0400D9EB RID: 55787
		[Token(Token = "0x400D9EB")]
		[FieldOffset(Offset = "0x130")]
		public UIWidget Biaoqian1Share;

		// Token: 0x0400D9EC RID: 55788
		[Token(Token = "0x400D9EC")]
		[FieldOffset(Offset = "0x138")]
		public UIWidget Biaoqian2Share;

		// Token: 0x0400D9ED RID: 55789
		[Token(Token = "0x400D9ED")]
		[FieldOffset(Offset = "0x140")]
		public UIWidget Biaoqian3Share;

		// Token: 0x0400D9EE RID: 55790
		[Token(Token = "0x400D9EE")]
		[FieldOffset(Offset = "0x148")]
		public UIWidget Biaoqian4Share;
	}
}
