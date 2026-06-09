using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002493 RID: 9363
	[Token(Token = "0x2002493")]
	internal class UIPointsRaceView : UIBaseView
	{
		// Token: 0x0600C436 RID: 50230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C436")]
		[Address(RVA = "0x20E79C0", Offset = "0x20E79C0", VA = "0x7BBC8E79C0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C437 RID: 50231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C437")]
		[Address(RVA = "0x20E7E1C", Offset = "0x20E7E1C", VA = "0x7BBC8E7E1C")]
		public UIPointsRaceView()
		{
		}

		// Token: 0x0400EB96 RID: 60310
		[Token(Token = "0x400EB96")]
		[FieldOffset(Offset = "0x20")]
		public UISprite CurClanIcon;

		// Token: 0x0400EB97 RID: 60311
		[Token(Token = "0x400EB97")]
		[FieldOffset(Offset = "0x28")]
		public UILabel CurLevelLabel;

		// Token: 0x0400EB98 RID: 60312
		[Token(Token = "0x400EB98")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnClose;

		// Token: 0x0400EB99 RID: 60313
		[Token(Token = "0x400EB99")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Content;

		// Token: 0x0400EB9A RID: 60314
		[Token(Token = "0x400EB9A")]
		[FieldOffset(Offset = "0x40")]
		public GameObject CurrentClanStarsText;

		// Token: 0x0400EB9B RID: 60315
		[Token(Token = "0x400EB9B")]
		[FieldOffset(Offset = "0x48")]
		public GameObject LastClanStarsText;

		// Token: 0x0400EB9C RID: 60316
		[Token(Token = "0x400EB9C")]
		[FieldOffset(Offset = "0x50")]
		public UIButton RaceTips;

		// Token: 0x0400EB9D RID: 60317
		[Token(Token = "0x400EB9D")]
		[FieldOffset(Offset = "0x58")]
		public UILabel CurrentStarsNumber;

		// Token: 0x0400EB9E RID: 60318
		[Token(Token = "0x400EB9E")]
		[FieldOffset(Offset = "0x60")]
		public UILabel CurrentTimeText;

		// Token: 0x0400EB9F RID: 60319
		[Token(Token = "0x400EB9F")]
		[FieldOffset(Offset = "0x68")]
		public UIButton RankListButton;

		// Token: 0x0400EBA0 RID: 60320
		[Token(Token = "0x400EBA0")]
		[FieldOffset(Offset = "0x70")]
		public UIButton ClaimClanAwardBtn;

		// Token: 0x0400EBA1 RID: 60321
		[Token(Token = "0x400EBA1")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ReceivedButton;

		// Token: 0x0400EBA2 RID: 60322
		[Token(Token = "0x400EBA2")]
		[FieldOffset(Offset = "0x80")]
		public GameObject LargeGreyMask;

		// Token: 0x0400EBA3 RID: 60323
		[Token(Token = "0x400EBA3")]
		[FieldOffset(Offset = "0x88")]
		public UIGrid ClanPivot;

		// Token: 0x0400EBA4 RID: 60324
		[Token(Token = "0x400EBA4")]
		[FieldOffset(Offset = "0x90")]
		public UIProgressBar ProgressBar;

		// Token: 0x0400EBA5 RID: 60325
		[Token(Token = "0x400EBA5")]
		[FieldOffset(Offset = "0x98")]
		public UILabel IndividualStarsCount;

		// Token: 0x0400EBA6 RID: 60326
		[Token(Token = "0x400EBA6")]
		[FieldOffset(Offset = "0xA0")]
		public UIGrid IndividualPivot;
	}
}
