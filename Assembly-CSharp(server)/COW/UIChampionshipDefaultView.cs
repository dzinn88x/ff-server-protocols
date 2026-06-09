using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200212C RID: 8492
	[Token(Token = "0x200212C")]
	public class UIChampionshipDefaultView : UIBaseView
	{
		// Token: 0x0600BD68 RID: 48488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD68")]
		[Address(RVA = "0x1C3003C", Offset = "0x1C3003C", VA = "0x7BBC43003C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD69 RID: 48489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD69")]
		[Address(RVA = "0x1C3012C", Offset = "0x1C3012C", VA = "0x7BBC43012C")]
		public UIChampionshipDefaultView()
		{
		}

		// Token: 0x0400C324 RID: 49956
		[Token(Token = "0x400C324")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnRule;

		// Token: 0x0400C325 RID: 49957
		[Token(Token = "0x400C325")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Title;
	}
}
