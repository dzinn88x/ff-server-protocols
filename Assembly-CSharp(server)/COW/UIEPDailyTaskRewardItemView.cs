using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021CB RID: 8651
	[Token(Token = "0x20021CB")]
	public class UIEPDailyTaskRewardItemView : UIBaseView
	{
		// Token: 0x0600BEA7 RID: 48807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEA7")]
		[Address(RVA = "0x2213200", Offset = "0x2213200", VA = "0x7BBCA13200", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEA8 RID: 48808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEA8")]
		[Address(RVA = "0x221349C", Offset = "0x221349C", VA = "0x7BBCA1349C")]
		public UIEPDailyTaskRewardItemView()
		{
		}

		// Token: 0x0400CB2A RID: 52010
		[Token(Token = "0x400CB2A")]
		[FieldOffset(Offset = "0x20")]
		public UIButton OperateBtn;

		// Token: 0x0400CB2B RID: 52011
		[Token(Token = "0x400CB2B")]
		[FieldOffset(Offset = "0x28")]
		public Animation UnlockAnimation;

		// Token: 0x0400CB2C RID: 52012
		[Token(Token = "0x400CB2C")]
		[FieldOffset(Offset = "0x30")]
		public GameObject OnGoingObj;

		// Token: 0x0400CB2D RID: 52013
		[Token(Token = "0x400CB2D")]
		[FieldOffset(Offset = "0x38")]
		public UILabel AwardCnt;

		// Token: 0x0400CB2E RID: 52014
		[Token(Token = "0x400CB2E")]
		[FieldOffset(Offset = "0x40")]
		public GameObject RedPoint;

		// Token: 0x0400CB2F RID: 52015
		[Token(Token = "0x400CB2F")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ClaimedLabel;

		// Token: 0x0400CB30 RID: 52016
		[Token(Token = "0x400CB30")]
		[FieldOffset(Offset = "0x50")]
		public GameObject UnReachObj;

		// Token: 0x0400CB31 RID: 52017
		[Token(Token = "0x400CB31")]
		[FieldOffset(Offset = "0x58")]
		public UILabel AwardCnt1;

		// Token: 0x0400CB32 RID: 52018
		[Token(Token = "0x400CB32")]
		[FieldOffset(Offset = "0x60")]
		public GameObject UnlockEffect;
	}
}
