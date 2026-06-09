using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200220D RID: 8717
	[Token(Token = "0x200220D")]
	public class UIGachaEnergyPreviewView : UIBaseView
	{
		// Token: 0x0600BF2B RID: 48939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF2B")]
		[Address(RVA = "0x2162654", Offset = "0x2162654", VA = "0x7BBC962654", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF2C RID: 48940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF2C")]
		[Address(RVA = "0x21627F0", Offset = "0x21627F0", VA = "0x7BBC9627F0")]
		public UIGachaEnergyPreviewView()
		{
		}

		// Token: 0x0400CE9E RID: 52894
		[Token(Token = "0x400CE9E")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView GachaPreviewScrollView;

		// Token: 0x0400CE9F RID: 52895
		[Token(Token = "0x400CE9F")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList Grid;

		// Token: 0x0400CEA0 RID: 52896
		[Token(Token = "0x400CEA0")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BGClickLottery;

		// Token: 0x0400CEA1 RID: 52897
		[Token(Token = "0x400CEA1")]
		[FieldOffset(Offset = "0x38")]
		public UIButton btnclose;

		// Token: 0x0400CEA2 RID: 52898
		[Token(Token = "0x400CEA2")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnProbability;
	}
}
