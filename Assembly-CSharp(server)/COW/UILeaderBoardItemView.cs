using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023D7 RID: 9175
	[Token(Token = "0x20023D7")]
	internal class UILeaderBoardItemView : UIBaseView
	{
		// Token: 0x0600C2BE RID: 49854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2BE")]
		[Address(RVA = "0x1E2D338", Offset = "0x1E2D338", VA = "0x7BBC62D338", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2BF RID: 49855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2BF")]
		[Address(RVA = "0x1E2D6F0", Offset = "0x1E2D6F0", VA = "0x7BBC62D6F0")]
		public UILeaderBoardItemView()
		{
		}

		// Token: 0x0400DFC0 RID: 57280
		[Token(Token = "0x400DFC0")]
		[FieldOffset(Offset = "0x20")]
		public UIButton itembtn;

		// Token: 0x0400DFC1 RID: 57281
		[Token(Token = "0x400DFC1")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Rank;

		// Token: 0x0400DFC2 RID: 57282
		[Token(Token = "0x400DFC2")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LastRank;

		// Token: 0x0400DFC3 RID: 57283
		[Token(Token = "0x400DFC3")]
		[FieldOffset(Offset = "0x38")]
		public GameObject RaiseSprite;

		// Token: 0x0400DFC4 RID: 57284
		[Token(Token = "0x400DFC4")]
		[FieldOffset(Offset = "0x40")]
		public GameObject declineSprite;

		// Token: 0x0400DFC5 RID: 57285
		[Token(Token = "0x400DFC5")]
		[FieldOffset(Offset = "0x48")]
		public GameObject keepSprite;

		// Token: 0x0400DFC6 RID: 57286
		[Token(Token = "0x400DFC6")]
		[FieldOffset(Offset = "0x50")]
		public UILabel NameContainer;

		// Token: 0x0400DFC7 RID: 57287
		[Token(Token = "0x400DFC7")]
		[FieldOffset(Offset = "0x58")]
		public UILabel WinTimes;

		// Token: 0x0400DFC8 RID: 57288
		[Token(Token = "0x400DFC8")]
		[FieldOffset(Offset = "0x60")]
		public UILabel WinRate;

		// Token: 0x0400DFC9 RID: 57289
		[Token(Token = "0x400DFC9")]
		[FieldOffset(Offset = "0x68")]
		public UILabel KillTimes;

		// Token: 0x0400DFCA RID: 57290
		[Token(Token = "0x400DFCA")]
		[FieldOffset(Offset = "0x70")]
		public UILabel KDRatio;

		// Token: 0x0400DFCB RID: 57291
		[Token(Token = "0x400DFCB")]
		[FieldOffset(Offset = "0x78")]
		public UILabel Score;

		// Token: 0x0400DFCC RID: 57292
		[Token(Token = "0x400DFCC")]
		[FieldOffset(Offset = "0x80")]
		public UISprite CupIcon;

		// Token: 0x0400DFCD RID: 57293
		[Token(Token = "0x400DFCD")]
		[FieldOffset(Offset = "0x88")]
		public UILabel Badges;

		// Token: 0x0400DFCE RID: 57294
		[Token(Token = "0x400DFCE")]
		[FieldOffset(Offset = "0x90")]
		public GameObject EPIcon;
	}
}
