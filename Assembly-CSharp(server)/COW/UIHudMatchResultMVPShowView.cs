using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002313 RID: 8979
	[Token(Token = "0x2002313")]
	public class UIHudMatchResultMVPShowView : UIBaseView
	{
		// Token: 0x0600C136 RID: 49462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C136")]
		[Address(RVA = "0x17ACFF8", Offset = "0x17ACFF8", VA = "0x7BBBFACFF8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C137 RID: 49463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C137")]
		[Address(RVA = "0x17AD380", Offset = "0x17AD380", VA = "0x7BBBFAD380")]
		public UIHudMatchResultMVPShowView()
		{
		}

		// Token: 0x0400D90A RID: 55562
		[Token(Token = "0x400D90A")]
		[FieldOffset(Offset = "0x20")]
		public Animation HudMVPShowAnim;

		// Token: 0x0400D90B RID: 55563
		[Token(Token = "0x400D90B")]
		[FieldOffset(Offset = "0x28")]
		public UILabel GameModeTxt;

		// Token: 0x0400D90C RID: 55564
		[Token(Token = "0x400D90C")]
		[FieldOffset(Offset = "0x30")]
		public UILabel PlayerNameTxt;

		// Token: 0x0400D90D RID: 55565
		[Token(Token = "0x400D90D")]
		[FieldOffset(Offset = "0x38")]
		public GameObject FailMVPGrade;

		// Token: 0x0400D90E RID: 55566
		[Token(Token = "0x400D90E")]
		[FieldOffset(Offset = "0x40")]
		public GameObject WinMVPGrade;

		// Token: 0x0400D90F RID: 55567
		[Token(Token = "0x400D90F")]
		[FieldOffset(Offset = "0x48")]
		public UILabel TitleInfo1Txt;

		// Token: 0x0400D910 RID: 55568
		[Token(Token = "0x400D910")]
		[FieldOffset(Offset = "0x50")]
		public UILabel TitleInfo2Txt;

		// Token: 0x0400D911 RID: 55569
		[Token(Token = "0x400D911")]
		[FieldOffset(Offset = "0x58")]
		public UILabel TitleInfo3Txt;

		// Token: 0x0400D912 RID: 55570
		[Token(Token = "0x400D912")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Info1Txt;

		// Token: 0x0400D913 RID: 55571
		[Token(Token = "0x400D913")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Info2Txt;

		// Token: 0x0400D914 RID: 55572
		[Token(Token = "0x400D914")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Info3Txt;

		// Token: 0x0400D915 RID: 55573
		[Token(Token = "0x400D915")]
		[FieldOffset(Offset = "0x78")]
		public UIButton ShareBtn;

		// Token: 0x0400D916 RID: 55574
		[Token(Token = "0x400D916")]
		[FieldOffset(Offset = "0x80")]
		public UIButton ContinueBtn;

		// Token: 0x0400D917 RID: 55575
		[Token(Token = "0x400D917")]
		[FieldOffset(Offset = "0x88")]
		public GameObject ContinueTxt;
	}
}
