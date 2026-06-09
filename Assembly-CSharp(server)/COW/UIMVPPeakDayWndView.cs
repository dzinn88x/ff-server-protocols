using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200244C RID: 9292
	[Token(Token = "0x200244C")]
	public class UIMVPPeakDayWndView : UIBaseView
	{
		// Token: 0x0600C3A8 RID: 50088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3A8")]
		[Address(RVA = "0x1CCD068", Offset = "0x1CCD068", VA = "0x7BBC4CD068", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3A9 RID: 50089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3A9")]
		[Address(RVA = "0x1CCD2BC", Offset = "0x1CCD2BC", VA = "0x7BBC4CD2BC")]
		public UIMVPPeakDayWndView()
		{
		}

		// Token: 0x0400E7C6 RID: 59334
		[Token(Token = "0x400E7C6")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Desc;

		// Token: 0x0400E7C7 RID: 59335
		[Token(Token = "0x400E7C7")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnClose;

		// Token: 0x0400E7C8 RID: 59336
		[Token(Token = "0x400E7C8")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid RewardContainer;

		// Token: 0x0400E7C9 RID: 59337
		[Token(Token = "0x400E7C9")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ClaimStatus;

		// Token: 0x0400E7CA RID: 59338
		[Token(Token = "0x400E7CA")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnClaim;

		// Token: 0x0400E7CB RID: 59339
		[Token(Token = "0x400E7CB")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ClaimedDesc;

		// Token: 0x0400E7CC RID: 59340
		[Token(Token = "0x400E7CC")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ExpiredDesc;

		// Token: 0x0400E7CD RID: 59341
		[Token(Token = "0x400E7CD")]
		[FieldOffset(Offset = "0x58")]
		public UINetworkTexture TitleTexture;
	}
}
