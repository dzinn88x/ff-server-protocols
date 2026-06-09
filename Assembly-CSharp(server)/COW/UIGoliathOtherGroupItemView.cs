using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002242 RID: 8770
	[Token(Token = "0x2002242")]
	public class UIGoliathOtherGroupItemView : UIBaseView
	{
		// Token: 0x0600BF95 RID: 49045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF95")]
		[Address(RVA = "0x1A7FE60", Offset = "0x1A7FE60", VA = "0x7BBC27FE60", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF96 RID: 49046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF96")]
		[Address(RVA = "0x1A80250", Offset = "0x1A80250", VA = "0x7BBC280250")]
		public UIGoliathOtherGroupItemView()
		{
		}

		// Token: 0x0400D20E RID: 53774
		[Token(Token = "0x400D20E")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIGoliathOtherGroupItem;

		// Token: 0x0400D20F RID: 53775
		[Token(Token = "0x400D20F")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Selected;

		// Token: 0x0400D210 RID: 53776
		[Token(Token = "0x400D210")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Unselected;

		// Token: 0x0400D211 RID: 53777
		[Token(Token = "0x400D211")]
		[FieldOffset(Offset = "0x38")]
		public GameObject GroupOpen;

		// Token: 0x0400D212 RID: 53778
		[Token(Token = "0x400D212")]
		[FieldOffset(Offset = "0x40")]
		public UILabel GroupName;

		// Token: 0x0400D213 RID: 53779
		[Token(Token = "0x400D213")]
		[FieldOffset(Offset = "0x48")]
		public UILabel GroupID;

		// Token: 0x0400D214 RID: 53780
		[Token(Token = "0x400D214")]
		[FieldOffset(Offset = "0x50")]
		public UILabel GroupState;

		// Token: 0x0400D215 RID: 53781
		[Token(Token = "0x400D215")]
		[FieldOffset(Offset = "0x58")]
		public UICountDownLabel GroupCountDown;

		// Token: 0x0400D216 RID: 53782
		[Token(Token = "0x400D216")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnCopyGroupID;

		// Token: 0x0400D217 RID: 53783
		[Token(Token = "0x400D217")]
		[FieldOffset(Offset = "0x68")]
		public Transform AFKItemContainer;

		// Token: 0x0400D218 RID: 53784
		[Token(Token = "0x400D218")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BtnGroupFinished;

		// Token: 0x0400D219 RID: 53785
		[Token(Token = "0x400D219")]
		[FieldOffset(Offset = "0x78")]
		public UILabel AFKRewardBonus;

		// Token: 0x0400D21A RID: 53786
		[Token(Token = "0x400D21A")]
		[FieldOffset(Offset = "0x80")]
		public GameObject GroupUnopen;

		// Token: 0x0400D21B RID: 53787
		[Token(Token = "0x400D21B")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BtnJoinGroup;

		// Token: 0x0400D21C RID: 53788
		[Token(Token = "0x400D21C")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnOtherGroup;
	}
}
