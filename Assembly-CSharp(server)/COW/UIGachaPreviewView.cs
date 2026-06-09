using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002225 RID: 8741
	[Token(Token = "0x2002225")]
	public class UIGachaPreviewView : UIBaseView
	{
		// Token: 0x0600BF5B RID: 48987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF5B")]
		[Address(RVA = "0x20721E0", Offset = "0x20721E0", VA = "0x7BBC8721E0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF5C RID: 48988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF5C")]
		[Address(RVA = "0x207237C", Offset = "0x207237C", VA = "0x7BBC87237C")]
		public UIGachaPreviewView()
		{
		}

		// Token: 0x0400CFE7 RID: 53223
		[Token(Token = "0x400CFE7")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView GachaPreviewScrollView;

		// Token: 0x0400CFE8 RID: 53224
		[Token(Token = "0x400CFE8")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList Grid;

		// Token: 0x0400CFE9 RID: 53225
		[Token(Token = "0x400CFE9")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BGClickLottery;

		// Token: 0x0400CFEA RID: 53226
		[Token(Token = "0x400CFEA")]
		[FieldOffset(Offset = "0x38")]
		public UIButton btnclose;

		// Token: 0x0400CFEB RID: 53227
		[Token(Token = "0x400CFEB")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnProbability;
	}
}
