using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021D7 RID: 8663
	[Token(Token = "0x20021D7")]
	public class UIEPWeeklyTaskView : UIBaseView
	{
		// Token: 0x0600BEBF RID: 48831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEBF")]
		[Address(RVA = "0x1AD67A8", Offset = "0x1AD67A8", VA = "0x7BBC2D67A8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEC0 RID: 48832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEC0")]
		[Address(RVA = "0x1AD68C8", Offset = "0x1AD68C8", VA = "0x7BBC2D68C8")]
		public UIEPWeeklyTaskView()
		{
		}

		// Token: 0x0400CB8F RID: 52111
		[Token(Token = "0x400CB8F")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid Grid;

		// Token: 0x0400CB90 RID: 52112
		[Token(Token = "0x400CB90")]
		[FieldOffset(Offset = "0x28")]
		public UIEPWeeklyItemPreviewController TaskItem;

		// Token: 0x0400CB91 RID: 52113
		[Token(Token = "0x400CB91")]
		[FieldOffset(Offset = "0x30")]
		public UIProgressBar ProgressBar;
	}
}
