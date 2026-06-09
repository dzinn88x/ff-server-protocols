using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002483 RID: 9347
	[Token(Token = "0x2002483")]
	public class UIPaymentTotalItemView : UIBaseView
	{
		// Token: 0x0600C416 RID: 50198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C416")]
		[Address(RVA = "0x1F39FA8", Offset = "0x1F39FA8", VA = "0x7BBC739FA8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C417 RID: 50199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C417")]
		[Address(RVA = "0x1F3A190", Offset = "0x1F3A190", VA = "0x7BBC73A190")]
		public UIPaymentTotalItemView()
		{
		}

		// Token: 0x0400EAD1 RID: 60113
		[Token(Token = "0x400EAD1")]
		[FieldOffset(Offset = "0x20")]
		public UILabel DescLabel;

		// Token: 0x0400EAD2 RID: 60114
		[Token(Token = "0x400EAD2")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ClaimedLabel;

		// Token: 0x0400EAD3 RID: 60115
		[Token(Token = "0x400EAD3")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ClaimedSprite;

		// Token: 0x0400EAD4 RID: 60116
		[Token(Token = "0x400EAD4")]
		[FieldOffset(Offset = "0x38")]
		public UIButton ClaimButton;

		// Token: 0x0400EAD5 RID: 60117
		[Token(Token = "0x400EAD5")]
		[FieldOffset(Offset = "0x40")]
		public UIButton TopupButton;

		// Token: 0x0400EAD6 RID: 60118
		[Token(Token = "0x400EAD6")]
		[FieldOffset(Offset = "0x48")]
		public UIGrid ContentsGrid;
	}
}
