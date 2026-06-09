using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021E9 RID: 8681
	[Token(Token = "0x20021E9")]
	public class UIFFWSPeakDayWndView : UIBaseView
	{
		// Token: 0x0600BEE3 RID: 48867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEE3")]
		[Address(RVA = "0x2284590", Offset = "0x2284590", VA = "0x7BBCA84590", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEE4 RID: 48868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEE4")]
		[Address(RVA = "0x228482C", Offset = "0x228482C", VA = "0x7BBCA8482C")]
		public UIFFWSPeakDayWndView()
		{
		}

		// Token: 0x0400CCB7 RID: 52407
		[Token(Token = "0x400CCB7")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400CCB8 RID: 52408
		[Token(Token = "0x400CCB8")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Desc;

		// Token: 0x0400CCB9 RID: 52409
		[Token(Token = "0x400CCB9")]
		[FieldOffset(Offset = "0x30")]
		public Transform AwardContainer;

		// Token: 0x0400CCBA RID: 52410
		[Token(Token = "0x400CCBA")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid RewardContainer;

		// Token: 0x0400CCBB RID: 52411
		[Token(Token = "0x400CCBB")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ClaimNode;

		// Token: 0x0400CCBC RID: 52412
		[Token(Token = "0x400CCBC")]
		[FieldOffset(Offset = "0x48")]
		public GameObject CannotClaimDesc;

		// Token: 0x0400CCBD RID: 52413
		[Token(Token = "0x400CCBD")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnClaim;

		// Token: 0x0400CCBE RID: 52414
		[Token(Token = "0x400CCBE")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ClaimedIcon;

		// Token: 0x0400CCBF RID: 52415
		[Token(Token = "0x400CCBF")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ExpiredIcon;
	}
}
