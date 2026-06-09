using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002364 RID: 9060
	[Token(Token = "0x2002364")]
	internal class UIHudSkillCastingView : UIBaseView
	{
		// Token: 0x0600C1D8 RID: 49624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1D8")]
		[Address(RVA = "0x1668B78", Offset = "0x1668B78", VA = "0x7BBBE68B78", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1D9 RID: 49625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1D9")]
		[Address(RVA = "0x1668C14", Offset = "0x1668C14", VA = "0x7BBBE68C14")]
		public UIHudSkillCastingView()
		{
		}

		// Token: 0x0400DBC0 RID: 56256
		[Token(Token = "0x400DBC0")]
		[FieldOffset(Offset = "0x20")]
		public UIProgressBar CastingProgress;
	}
}
