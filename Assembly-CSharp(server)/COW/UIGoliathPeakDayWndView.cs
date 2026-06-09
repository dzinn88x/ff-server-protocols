using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002243 RID: 8771
	[Token(Token = "0x2002243")]
	public class UIGoliathPeakDayWndView : UIBaseView
	{
		// Token: 0x0600BF97 RID: 49047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF97")]
		[Address(RVA = "0x1A80D0C", Offset = "0x1A80D0C", VA = "0x7BBC280D0C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF98 RID: 49048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF98")]
		[Address(RVA = "0x1A80F60", Offset = "0x1A80F60", VA = "0x7BBC280F60")]
		public UIGoliathPeakDayWndView()
		{
		}

		// Token: 0x0400D21D RID: 53789
		[Token(Token = "0x400D21D")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400D21E RID: 53790
		[Token(Token = "0x400D21E")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Desc;

		// Token: 0x0400D21F RID: 53791
		[Token(Token = "0x400D21F")]
		[FieldOffset(Offset = "0x30")]
		public Transform AwardContainer;

		// Token: 0x0400D220 RID: 53792
		[Token(Token = "0x400D220")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ClaimNode;

		// Token: 0x0400D221 RID: 53793
		[Token(Token = "0x400D221")]
		[FieldOffset(Offset = "0x40")]
		public GameObject CannotClaimDesc;

		// Token: 0x0400D222 RID: 53794
		[Token(Token = "0x400D222")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnClaim;

		// Token: 0x0400D223 RID: 53795
		[Token(Token = "0x400D223")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ClaimedIcon;

		// Token: 0x0400D224 RID: 53796
		[Token(Token = "0x400D224")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ExpiredIcon;
	}
}
