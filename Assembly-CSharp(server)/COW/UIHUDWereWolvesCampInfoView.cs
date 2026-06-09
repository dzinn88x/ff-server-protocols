using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023A1 RID: 9121
	[Token(Token = "0x20023A1")]
	public class UIHUDWereWolvesCampInfoView : UIBaseView
	{
		// Token: 0x0600C252 RID: 49746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C252")]
		[Address(RVA = "0x1D53770", Offset = "0x1D53770", VA = "0x7BBC553770", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C253 RID: 49747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C253")]
		[Address(RVA = "0x1D53A0C", Offset = "0x1D53A0C", VA = "0x7BBC553A0C")]
		public UIHUDWereWolvesCampInfoView()
		{
		}

		// Token: 0x0400DD84 RID: 56708
		[Token(Token = "0x400DD84")]
		[FieldOffset(Offset = "0x20")]
		public UIProgressBar LeftTimeProgress;

		// Token: 0x0400DD85 RID: 56709
		[Token(Token = "0x400DD85")]
		[FieldOffset(Offset = "0x28")]
		public UISprite barFore;

		// Token: 0x0400DD86 RID: 56710
		[Token(Token = "0x400DD86")]
		[FieldOffset(Offset = "0x30")]
		public GameObject WolfRoot;

		// Token: 0x0400DD87 RID: 56711
		[Token(Token = "0x400DD87")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SkillIconSprite;

		// Token: 0x0400DD88 RID: 56712
		[Token(Token = "0x400DD88")]
		[FieldOffset(Offset = "0x40")]
		public UIGrid IconGrid;

		// Token: 0x0400DD89 RID: 56713
		[Token(Token = "0x400DD89")]
		[FieldOffset(Offset = "0x48")]
		public UIHUDWereWolvesCampWolfItem WolfIconTemplate;

		// Token: 0x0400DD8A RID: 56714
		[Token(Token = "0x400DD8A")]
		[FieldOffset(Offset = "0x50")]
		public GameObject HumanRoot;

		// Token: 0x0400DD8B RID: 56715
		[Token(Token = "0x400DD8B")]
		[FieldOffset(Offset = "0x58")]
		public UILabel HumanTitleLabel;

		// Token: 0x0400DD8C RID: 56716
		[Token(Token = "0x400DD8C")]
		[FieldOffset(Offset = "0x60")]
		public UILabel LeftTimeLabel;
	}
}
