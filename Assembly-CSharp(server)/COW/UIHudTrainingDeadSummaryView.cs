using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002386 RID: 9094
	[Token(Token = "0x2002386")]
	public class UIHudTrainingDeadSummaryView : UIBaseView
	{
		// Token: 0x0600C21C RID: 49692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C21C")]
		[Address(RVA = "0x15E795C", Offset = "0x15E795C", VA = "0x7BBBDE795C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C21D RID: 49693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C21D")]
		[Address(RVA = "0x15E7AE0", Offset = "0x15E7AE0", VA = "0x7BBBDE7AE0")]
		public UIHudTrainingDeadSummaryView()
		{
		}

		// Token: 0x0400DCB9 RID: 56505
		[Token(Token = "0x400DCB9")]
		[FieldOffset(Offset = "0x20")]
		public UILabel SummaryLabel;

		// Token: 0x0400DCBA RID: 56506
		[Token(Token = "0x400DCBA")]
		[FieldOffset(Offset = "0x28")]
		public UILabel KillLabel;

		// Token: 0x0400DCBB RID: 56507
		[Token(Token = "0x400DCBB")]
		[FieldOffset(Offset = "0x30")]
		public UILabel AssisLabel;

		// Token: 0x0400DCBC RID: 56508
		[Token(Token = "0x400DCBC")]
		[FieldOffset(Offset = "0x38")]
		public UILabel HitRateLabel;

		// Token: 0x0400DCBD RID: 56509
		[Token(Token = "0x400DCBD")]
		[FieldOffset(Offset = "0x40")]
		public UILabel HeadShotRate;
	}
}
