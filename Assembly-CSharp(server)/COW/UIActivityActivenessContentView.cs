using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020D7 RID: 8407
	[Token(Token = "0x20020D7")]
	public class UIActivityActivenessContentView : UIBaseView
	{
		// Token: 0x0600BCBF RID: 48319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCBF")]
		[Address(RVA = "0x1A3F21C", Offset = "0x1A3F21C", VA = "0x7BBC23F21C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCC0 RID: 48320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCC0")]
		[Address(RVA = "0x1A3F690", Offset = "0x1A3F690", VA = "0x7BBC23F690")]
		public UIActivityActivenessContentView()
		{
		}

		// Token: 0x0400BE8D RID: 48781
		[Token(Token = "0x400BE8D")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ActivenessProcessInfo;

		// Token: 0x0400BE8E RID: 48782
		[Token(Token = "0x400BE8E")]
		[FieldOffset(Offset = "0x28")]
		public UIActivityActivenessRewardDescription WeekActivenessInfo;

		// Token: 0x0400BE8F RID: 48783
		[Token(Token = "0x400BE8F")]
		[FieldOffset(Offset = "0x30")]
		public UIButton WeekRewardProcessBtn;

		// Token: 0x0400BE90 RID: 48784
		[Token(Token = "0x400BE90")]
		[FieldOffset(Offset = "0x38")]
		public GameObject WeekRewardProcess;

		// Token: 0x0400BE91 RID: 48785
		[Token(Token = "0x400BE91")]
		[FieldOffset(Offset = "0x40")]
		public UILabel WeekActivenessValue;

		// Token: 0x0400BE92 RID: 48786
		[Token(Token = "0x400BE92")]
		[FieldOffset(Offset = "0x48")]
		public UICountDownLabel WeekRewardResetTime;

		// Token: 0x0400BE93 RID: 48787
		[Token(Token = "0x400BE93")]
		[FieldOffset(Offset = "0x50")]
		public UIProgressBar DailyActivenessProcessSlider;

		// Token: 0x0400BE94 RID: 48788
		[Token(Token = "0x400BE94")]
		[FieldOffset(Offset = "0x58")]
		public GameObject SliderEffect;

		// Token: 0x0400BE95 RID: 48789
		[Token(Token = "0x400BE95")]
		[FieldOffset(Offset = "0x60")]
		public GameObject FakeSliderEffect;

		// Token: 0x0400BE96 RID: 48790
		[Token(Token = "0x400BE96")]
		[FieldOffset(Offset = "0x68")]
		public UIGrid AwardGrid;

		// Token: 0x0400BE97 RID: 48791
		[Token(Token = "0x400BE97")]
		[FieldOffset(Offset = "0x70")]
		public UIActivityActivenessRewardDescription ActivenessAwarditem;

		// Token: 0x0400BE98 RID: 48792
		[Token(Token = "0x400BE98")]
		[FieldOffset(Offset = "0x78")]
		public UILabel DailyActivenessValue;

		// Token: 0x0400BE99 RID: 48793
		[Token(Token = "0x400BE99")]
		[FieldOffset(Offset = "0x80")]
		public UICountDownLabel DayRewardResetTime;

		// Token: 0x0400BE9A RID: 48794
		[Token(Token = "0x400BE9A")]
		[FieldOffset(Offset = "0x88")]
		public GameObject TaskScrollView;

		// Token: 0x0400BE9B RID: 48795
		[Token(Token = "0x400BE9B")]
		[FieldOffset(Offset = "0x90")]
		public UIGrid TasksList;

		// Token: 0x0400BE9C RID: 48796
		[Token(Token = "0x400BE9C")]
		[FieldOffset(Offset = "0x98")]
		public UIActivityActivenessItemController ActivenessInfoItem;

		// Token: 0x0400BE9D RID: 48797
		[Token(Token = "0x400BE9D")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton ClaimAllBtn;
	}
}
