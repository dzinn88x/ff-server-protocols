using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002563 RID: 9571
	[Token(Token = "0x2002563")]
	public class UISuperCarPeakDayWndView : UIBaseView
	{
		// Token: 0x0600C5D6 RID: 50646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D6")]
		[Address(RVA = "0x214A37C", Offset = "0x214A37C", VA = "0x7BBC94A37C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5D7 RID: 50647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D7")]
		[Address(RVA = "0x214A5D0", Offset = "0x214A5D0", VA = "0x7BBC94A5D0")]
		public UISuperCarPeakDayWndView()
		{
		}

		// Token: 0x0400F55E RID: 62814
		[Token(Token = "0x400F55E")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Desc;

		// Token: 0x0400F55F RID: 62815
		[Token(Token = "0x400F55F")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnClose;

		// Token: 0x0400F560 RID: 62816
		[Token(Token = "0x400F560")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid RewardContainer;

		// Token: 0x0400F561 RID: 62817
		[Token(Token = "0x400F561")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ClaimStatus;

		// Token: 0x0400F562 RID: 62818
		[Token(Token = "0x400F562")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnClaim;

		// Token: 0x0400F563 RID: 62819
		[Token(Token = "0x400F563")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ClaimedDesc;

		// Token: 0x0400F564 RID: 62820
		[Token(Token = "0x400F564")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ExpiredDesc;

		// Token: 0x0400F565 RID: 62821
		[Token(Token = "0x400F565")]
		[FieldOffset(Offset = "0x58")]
		public UINetworkTexture TitleTexture;
	}
}
