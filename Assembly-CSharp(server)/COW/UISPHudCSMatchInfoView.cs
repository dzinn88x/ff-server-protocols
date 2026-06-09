using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002501 RID: 9473
	[Token(Token = "0x2002501")]
	public class UISPHudCSMatchInfoView : UIBaseView
	{
		// Token: 0x0600C514 RID: 50452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C514")]
		[Address(RVA = "0x1EE07C8", Offset = "0x1EE07C8", VA = "0x7BBC6E07C8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C515 RID: 50453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C515")]
		[Address(RVA = "0x1EE0E6C", Offset = "0x1EE0E6C", VA = "0x7BBC6E0E6C")]
		public UISPHudCSMatchInfoView()
		{
		}

		// Token: 0x0400F165 RID: 61797
		[Token(Token = "0x400F165")]
		[FieldOffset(Offset = "0x20")]
		public TweenPosition TWPosition;

		// Token: 0x0400F166 RID: 61798
		[Token(Token = "0x400F166")]
		[FieldOffset(Offset = "0x28")]
		public TweenAlpha TWAlpha;

		// Token: 0x0400F167 RID: 61799
		[Token(Token = "0x400F167")]
		[FieldOffset(Offset = "0x30")]
		public GameObject EconomyInfo;

		// Token: 0x0400F168 RID: 61800
		[Token(Token = "0x400F168")]
		[FieldOffset(Offset = "0x38")]
		public UILabel EconomyBlue;

		// Token: 0x0400F169 RID: 61801
		[Token(Token = "0x400F169")]
		[FieldOffset(Offset = "0x40")]
		public UILabel EconomyRed;

		// Token: 0x0400F16A RID: 61802
		[Token(Token = "0x400F16A")]
		[FieldOffset(Offset = "0x48")]
		public UIProgressBar EconomyBar;

		// Token: 0x0400F16B RID: 61803
		[Token(Token = "0x400F16B")]
		[FieldOffset(Offset = "0x50")]
		public UILabel TeamBlueName;

		// Token: 0x0400F16C RID: 61804
		[Token(Token = "0x400F16C")]
		[FieldOffset(Offset = "0x58")]
		public UILabel myWinNum;

		// Token: 0x0400F16D RID: 61805
		[Token(Token = "0x400F16D")]
		[FieldOffset(Offset = "0x60")]
		public UILabel oppoWinNum;

		// Token: 0x0400F16E RID: 61806
		[Token(Token = "0x400F16E")]
		[FieldOffset(Offset = "0x68")]
		public GameObject RoundInfo;

		// Token: 0x0400F16F RID: 61807
		[Token(Token = "0x400F16F")]
		[FieldOffset(Offset = "0x70")]
		public UILabel remainTime;

		// Token: 0x0400F170 RID: 61808
		[Token(Token = "0x400F170")]
		[FieldOffset(Offset = "0x78")]
		public UILabel curRound;

		// Token: 0x0400F171 RID: 61809
		[Token(Token = "0x400F171")]
		[FieldOffset(Offset = "0x80")]
		public GameObject BombCountdownInfo;

		// Token: 0x0400F172 RID: 61810
		[Token(Token = "0x400F172")]
		[FieldOffset(Offset = "0x88")]
		public UISprite FillBg;

		// Token: 0x0400F173 RID: 61811
		[Token(Token = "0x400F173")]
		[FieldOffset(Offset = "0x90")]
		public UILabel TeamRedName;

		// Token: 0x0400F174 RID: 61812
		[Token(Token = "0x400F174")]
		[FieldOffset(Offset = "0x98")]
		public UISprite TeamBlueIcon;

		// Token: 0x0400F175 RID: 61813
		[Token(Token = "0x400F175")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite TeamRedIcon;

		// Token: 0x0400F176 RID: 61814
		[Token(Token = "0x400F176")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject TeamBlueDefaultIcon;

		// Token: 0x0400F177 RID: 61815
		[Token(Token = "0x400F177")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite Team1Icon;

		// Token: 0x0400F178 RID: 61816
		[Token(Token = "0x400F178")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject TeamRedDefaultIcon;

		// Token: 0x0400F179 RID: 61817
		[Token(Token = "0x400F179")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite Team2Icon;

		// Token: 0x0400F17A RID: 61818
		[Token(Token = "0x400F17A")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject BombInfo;

		// Token: 0x0400F17B RID: 61819
		[Token(Token = "0x400F17B")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite BlueFactionIcon;

		// Token: 0x0400F17C RID: 61820
		[Token(Token = "0x400F17C")]
		[FieldOffset(Offset = "0xD8")]
		public UISprite RedFactionIcon;

		// Token: 0x0400F17D RID: 61821
		[Token(Token = "0x400F17D")]
		[FieldOffset(Offset = "0xE0")]
		public UIProgressBar BlueRemoveProgressBar;

		// Token: 0x0400F17E RID: 61822
		[Token(Token = "0x400F17E")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel BlueRemoveHint;

		// Token: 0x0400F17F RID: 61823
		[Token(Token = "0x400F17F")]
		[FieldOffset(Offset = "0xF0")]
		public UIProgressBar RedRemoveProgressBar;

		// Token: 0x0400F180 RID: 61824
		[Token(Token = "0x400F180")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel RedRemoveHint;
	}
}
