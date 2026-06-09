using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200256E RID: 9582
	[Token(Token = "0x200256E")]
	public class UISuperFighterPeakDayWndView : UIBaseView
	{
		// Token: 0x0600C5EC RID: 50668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5EC")]
		[Address(RVA = "0x1F4EBF4", Offset = "0x1F4EBF4", VA = "0x7BBC74EBF4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5ED RID: 50669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5ED")]
		[Address(RVA = "0x1F4EE0C", Offset = "0x1F4EE0C", VA = "0x7BBC74EE0C")]
		public UISuperFighterPeakDayWndView()
		{
		}

		// Token: 0x0400F60B RID: 62987
		[Token(Token = "0x400F60B")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Desc;

		// Token: 0x0400F60C RID: 62988
		[Token(Token = "0x400F60C")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid AwardGrid;

		// Token: 0x0400F60D RID: 62989
		[Token(Token = "0x400F60D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ClaimNode;

		// Token: 0x0400F60E RID: 62990
		[Token(Token = "0x400F60E")]
		[FieldOffset(Offset = "0x38")]
		public GameObject CannotClaimDesc;

		// Token: 0x0400F60F RID: 62991
		[Token(Token = "0x400F60F")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnClaim;

		// Token: 0x0400F610 RID: 62992
		[Token(Token = "0x400F610")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ClaimedIcon;

		// Token: 0x0400F611 RID: 62993
		[Token(Token = "0x400F611")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ExpiredIcon;
	}
}
