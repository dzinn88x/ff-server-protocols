using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021D6 RID: 8662
	[Token(Token = "0x20021D6")]
	public class UIEPWeeklyTaskDetailListView : UIBaseView
	{
		// Token: 0x0600BEBD RID: 48829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEBD")]
		[Address(RVA = "0x1AD662C", Offset = "0x1AD662C", VA = "0x7BBC2D662C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEBE RID: 48830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEBE")]
		[Address(RVA = "0x1AD67A0", Offset = "0x1AD67A0", VA = "0x7BBC2D67A0")]
		public UIEPWeeklyTaskDetailListView()
		{
		}

		// Token: 0x0400CB8B RID: 52107
		[Token(Token = "0x400CB8B")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Desc;

		// Token: 0x0400CB8C RID: 52108
		[Token(Token = "0x400CB8C")]
		[FieldOffset(Offset = "0x28")]
		public UIProgressBar ProgressBar;

		// Token: 0x0400CB8D RID: 52109
		[Token(Token = "0x400CB8D")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ProgressCnt;

		// Token: 0x0400CB8E RID: 52110
		[Token(Token = "0x400CB8E")]
		[FieldOffset(Offset = "0x38")]
		public UIEasyList EasyList;
	}
}
