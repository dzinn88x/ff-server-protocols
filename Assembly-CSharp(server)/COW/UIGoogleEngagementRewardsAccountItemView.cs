using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002246 RID: 8774
	[Token(Token = "0x2002246")]
	internal class UIGoogleEngagementRewardsAccountItemView : UIBaseView
	{
		// Token: 0x0600BF9D RID: 49053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF9D")]
		[Address(RVA = "0x1A83BF8", Offset = "0x1A83BF8", VA = "0x7BBC283BF8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF9E RID: 49054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF9E")]
		[Address(RVA = "0x1A83D18", Offset = "0x1A83D18", VA = "0x7BBC283D18")]
		public UIGoogleEngagementRewardsAccountItemView()
		{
		}

		// Token: 0x0400D239 RID: 53817
		[Token(Token = "0x400D239")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Button;

		// Token: 0x0400D23A RID: 53818
		[Token(Token = "0x400D23A")]
		[FieldOffset(Offset = "0x28")]
		public UIDragScrollView DragScrollView;

		// Token: 0x0400D23B RID: 53819
		[Token(Token = "0x400D23B")]
		[FieldOffset(Offset = "0x30")]
		public UILabel AccountNameLabel;
	}
}
