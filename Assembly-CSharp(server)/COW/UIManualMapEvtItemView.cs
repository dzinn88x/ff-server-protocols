using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002428 RID: 9256
	[Token(Token = "0x2002428")]
	internal class UIManualMapEvtItemView : UIBaseView
	{
		// Token: 0x0600C360 RID: 50016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C360")]
		[Address(RVA = "0x18E34A4", Offset = "0x18E34A4", VA = "0x7BBC0E34A4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C361 RID: 50017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C361")]
		[Address(RVA = "0x18E36AC", Offset = "0x18E36AC", VA = "0x7BBC0E36AC")]
		public UIManualMapEvtItemView()
		{
		}

		// Token: 0x0400E5FE RID: 58878
		[Token(Token = "0x400E5FE")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UIManualMapEvtItem;

		// Token: 0x0400E5FF RID: 58879
		[Token(Token = "0x400E5FF")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Title;

		// Token: 0x0400E600 RID: 58880
		[Token(Token = "0x400E600")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Desc;

		// Token: 0x0400E601 RID: 58881
		[Token(Token = "0x400E601")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Icon;

		// Token: 0x0400E602 RID: 58882
		[Token(Token = "0x400E602")]
		[FieldOffset(Offset = "0x40")]
		public UILabel QuestionLabel;

		// Token: 0x0400E603 RID: 58883
		[Token(Token = "0x400E603")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnMore;

		// Token: 0x0400E604 RID: 58884
		[Token(Token = "0x400E604")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Tag;
	}
}
