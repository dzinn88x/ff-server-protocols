using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002568 RID: 9576
	[Token(Token = "0x2002568")]
	public class UISuperCarView : UIBaseView
	{
		// Token: 0x0600C5E0 RID: 50656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5E0")]
		[Address(RVA = "0x1F42BA0", Offset = "0x1F42BA0", VA = "0x7BBC742BA0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5E1 RID: 50657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5E1")]
		[Address(RVA = "0x1F435B0", Offset = "0x1F435B0", VA = "0x7BBC7435B0")]
		public UISuperCarView()
		{
		}

		// Token: 0x0400F585 RID: 62853
		[Token(Token = "0x400F585")]
		[FieldOffset(Offset = "0x20")]
		public Animation OpenAnimation;

		// Token: 0x0400F586 RID: 62854
		[Token(Token = "0x400F586")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTextureExt TitleCDN;

		// Token: 0x0400F587 RID: 62855
		[Token(Token = "0x400F587")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LabelDate;

		// Token: 0x0400F588 RID: 62856
		[Token(Token = "0x400F588")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid EntrenceGrid;

		// Token: 0x0400F589 RID: 62857
		[Token(Token = "0x400F589")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnPeakDay;

		// Token: 0x0400F58A RID: 62858
		[Token(Token = "0x400F58A")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Bubble;

		// Token: 0x0400F58B RID: 62859
		[Token(Token = "0x400F58B")]
		[FieldOffset(Offset = "0x50")]
		public UILabel BubbleLabel;

		// Token: 0x0400F58C RID: 62860
		[Token(Token = "0x400F58C")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BubbleShakeVFX;

		// Token: 0x0400F58D RID: 62861
		[Token(Token = "0x400F58D")]
		[FieldOffset(Offset = "0x60")]
		public UILabel PeakDayDate;

		// Token: 0x0400F58E RID: 62862
		[Token(Token = "0x400F58E")]
		[FieldOffset(Offset = "0x68")]
		public UIButton BtnRule;

		// Token: 0x0400F58F RID: 62863
		[Token(Token = "0x400F58F")]
		[FieldOffset(Offset = "0x70")]
		public UIGrid LeftBottomGrid;

		// Token: 0x0400F590 RID: 62864
		[Token(Token = "0x400F590")]
		[FieldOffset(Offset = "0x78")]
		public UIButton BtnDaily;

		// Token: 0x0400F591 RID: 62865
		[Token(Token = "0x400F591")]
		[FieldOffset(Offset = "0x80")]
		public GameObject BtnSignTip;

		// Token: 0x0400F592 RID: 62866
		[Token(Token = "0x400F592")]
		[FieldOffset(Offset = "0x88")]
		public UISprite BgCallDeath;

		// Token: 0x0400F593 RID: 62867
		[Token(Token = "0x400F593")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnActivityPage;

		// Token: 0x0400F594 RID: 62868
		[Token(Token = "0x400F594")]
		[FieldOffset(Offset = "0x98")]
		public GameObject BtnGoWebTip;

		// Token: 0x0400F595 RID: 62869
		[Token(Token = "0x400F595")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject TopRightContainer;

		// Token: 0x0400F596 RID: 62870
		[Token(Token = "0x400F596")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton SugarTokenBtn;

		// Token: 0x0400F597 RID: 62871
		[Token(Token = "0x400F597")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite Money1Icon;

		// Token: 0x0400F598 RID: 62872
		[Token(Token = "0x400F598")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel SugarTokenCount;

		// Token: 0x0400F599 RID: 62873
		[Token(Token = "0x400F599")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton MapProgress;

		// Token: 0x0400F59A RID: 62874
		[Token(Token = "0x400F59A")]
		[FieldOffset(Offset = "0xC8")]
		public UITexture Map;

		// Token: 0x0400F59B RID: 62875
		[Token(Token = "0x400F59B")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel LapProgressLabel;

		// Token: 0x0400F59C RID: 62876
		[Token(Token = "0x400F59C")]
		[FieldOffset(Offset = "0xD8")]
		public UICountDownLabel LapCountDownLabel;

		// Token: 0x0400F59D RID: 62877
		[Token(Token = "0x400F59D")]
		[FieldOffset(Offset = "0xE0")]
		public UIGrid RightBottomGrid;

		// Token: 0x0400F59E RID: 62878
		[Token(Token = "0x400F59E")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton BtnFriendHelp;

		// Token: 0x0400F59F RID: 62879
		[Token(Token = "0x400F59F")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel FriendHelpSpeed;

		// Token: 0x0400F5A0 RID: 62880
		[Token(Token = "0x400F5A0")]
		[FieldOffset(Offset = "0xF8")]
		public UIButton BtnTokenAcc;

		// Token: 0x0400F5A1 RID: 62881
		[Token(Token = "0x400F5A1")]
		[FieldOffset(Offset = "0x100")]
		public UILabel TokenSpeed;

		// Token: 0x0400F5A2 RID: 62882
		[Token(Token = "0x400F5A2")]
		[FieldOffset(Offset = "0x108")]
		public UIButton BtnClose;

		// Token: 0x0400F5A3 RID: 62883
		[Token(Token = "0x400F5A3")]
		[FieldOffset(Offset = "0x110")]
		public UISprite CurSpeed;

		// Token: 0x0400F5A4 RID: 62884
		[Token(Token = "0x400F5A4")]
		[FieldOffset(Offset = "0x118")]
		public UILabel CurSpeedLabel;

		// Token: 0x0400F5A5 RID: 62885
		[Token(Token = "0x400F5A5")]
		[FieldOffset(Offset = "0x120")]
		public UIButton BtnShowReward;

		// Token: 0x0400F5A6 RID: 62886
		[Token(Token = "0x400F5A6")]
		[FieldOffset(Offset = "0x128")]
		public UIButton RewardMask;

		// Token: 0x0400F5A7 RID: 62887
		[Token(Token = "0x400F5A7")]
		[FieldOffset(Offset = "0x130")]
		public GameObject RewardItemContainer;

		// Token: 0x0400F5A8 RID: 62888
		[Token(Token = "0x400F5A8")]
		[FieldOffset(Offset = "0x138")]
		public GameObject RewardTips;

		// Token: 0x0400F5A9 RID: 62889
		[Token(Token = "0x400F5A9")]
		[FieldOffset(Offset = "0x140")]
		public UILabel LapRewardLabel;

		// Token: 0x0400F5AA RID: 62890
		[Token(Token = "0x400F5AA")]
		[FieldOffset(Offset = "0x148")]
		public GameObject RewardBubble;

		// Token: 0x0400F5AB RID: 62891
		[Token(Token = "0x400F5AB")]
		[FieldOffset(Offset = "0x150")]
		public GameObject CenterContainer;

		// Token: 0x0400F5AC RID: 62892
		[Token(Token = "0x400F5AC")]
		[FieldOffset(Offset = "0x158")]
		public UINetworkTextureExt BgTexture;

		// Token: 0x0400F5AD RID: 62893
		[Token(Token = "0x400F5AD")]
		[FieldOffset(Offset = "0x160")]
		public UIButton BtnChangeCar;

		// Token: 0x0400F5AE RID: 62894
		[Token(Token = "0x400F5AE")]
		[FieldOffset(Offset = "0x168")]
		public UILabel BaseSpeed;

		// Token: 0x0400F5AF RID: 62895
		[Token(Token = "0x400F5AF")]
		[FieldOffset(Offset = "0x170")]
		public GameObject Mask;
	}
}
