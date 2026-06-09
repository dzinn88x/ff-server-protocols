using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023AE RID: 9134
	[Token(Token = "0x20023AE")]
	public class UIHudWereWolvesTaskView : UIBaseView
	{
		// Token: 0x0600C26C RID: 49772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C26C")]
		[Address(RVA = "0x1D1782C", Offset = "0x1D1782C", VA = "0x7BBC51782C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C26D RID: 49773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C26D")]
		[Address(RVA = "0x1D1794C", Offset = "0x1D1794C", VA = "0x7BBC51794C")]
		public UIHudWereWolvesTaskView()
		{
		}

		// Token: 0x0400DDDF RID: 56799
		[Token(Token = "0x400DDDF")]
		[FieldOffset(Offset = "0x20")]
		public GameObject TaskPanel;

		// Token: 0x0400DDE0 RID: 56800
		[Token(Token = "0x400DDE0")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnClose;

		// Token: 0x0400DDE1 RID: 56801
		[Token(Token = "0x400DDE1")]
		[FieldOffset(Offset = "0x30")]
		public UILabel TitleLabel;
	}
}
