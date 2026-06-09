using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002184 RID: 8580
	[Token(Token = "0x2002184")]
	public class UICommonRewardWndView : UIBaseView
	{
		// Token: 0x0600BE18 RID: 48664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE18")]
		[Address(RVA = "0x18139E0", Offset = "0x18139E0", VA = "0x7BBC0139E0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE19 RID: 48665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE19")]
		[Address(RVA = "0x1813EA8", Offset = "0x1813EA8", VA = "0x7BBC013EA8")]
		public UICommonRewardWndView()
		{
		}

		// Token: 0x0400C7A6 RID: 51110
		[Token(Token = "0x400C7A6")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Mask;

		// Token: 0x0400C7A7 RID: 51111
		[Token(Token = "0x400C7A7")]
		[FieldOffset(Offset = "0x28")]
		public UIButton SkipMask;

		// Token: 0x0400C7A8 RID: 51112
		[Token(Token = "0x400C7A8")]
		[FieldOffset(Offset = "0x30")]
		public GameObject RewardContainer;

		// Token: 0x0400C7A9 RID: 51113
		[Token(Token = "0x400C7A9")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ExtraItem;

		// Token: 0x0400C7AA RID: 51114
		[Token(Token = "0x400C7AA")]
		[FieldOffset(Offset = "0x40")]
		public UIGrid RewardGrid;

		// Token: 0x0400C7AB RID: 51115
		[Token(Token = "0x400C7AB")]
		[FieldOffset(Offset = "0x48")]
		public GameObject RewardGridLeftPos;

		// Token: 0x0400C7AC RID: 51116
		[Token(Token = "0x400C7AC")]
		[FieldOffset(Offset = "0x50")]
		public GameObject RewardGridMiddlePos;

		// Token: 0x0400C7AD RID: 51117
		[Token(Token = "0x400C7AD")]
		[FieldOffset(Offset = "0x58")]
		public UIScrollView OptionalRewardScrollView;

		// Token: 0x0400C7AE RID: 51118
		[Token(Token = "0x400C7AE")]
		[FieldOffset(Offset = "0x60")]
		public UIGrid OptionalRewardGrid;

		// Token: 0x0400C7AF RID: 51119
		[Token(Token = "0x400C7AF")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Share;

		// Token: 0x0400C7B0 RID: 51120
		[Token(Token = "0x400C7B0")]
		[FieldOffset(Offset = "0x70")]
		public UIButton GoToSharePreViewBtn;

		// Token: 0x0400C7B1 RID: 51121
		[Token(Token = "0x400C7B1")]
		[FieldOffset(Offset = "0x78")]
		public Animator ShareIconAnimator;

		// Token: 0x0400C7B2 RID: 51122
		[Token(Token = "0x400C7B2")]
		[FieldOffset(Offset = "0x80")]
		public GameObject Label;

		// Token: 0x0400C7B3 RID: 51123
		[Token(Token = "0x400C7B3")]
		[FieldOffset(Offset = "0x88")]
		public UILabel FreeRewardLabel;

		// Token: 0x0400C7B4 RID: 51124
		[Token(Token = "0x400C7B4")]
		[FieldOffset(Offset = "0x90")]
		public UILabel TransferHint;

		// Token: 0x0400C7B5 RID: 51125
		[Token(Token = "0x400C7B5")]
		[FieldOffset(Offset = "0x98")]
		public UILabel TransferHintOneRow;

		// Token: 0x0400C7B6 RID: 51126
		[Token(Token = "0x400C7B6")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel OptionalLabel;

		// Token: 0x0400C7B7 RID: 51127
		[Token(Token = "0x400C7B7")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel OptionalLabelStatic;

		// Token: 0x0400C7B8 RID: 51128
		[Token(Token = "0x400C7B8")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject BG;
	}
}
