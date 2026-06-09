using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024F3 RID: 9459
	[Token(Token = "0x20024F3")]
	internal class UISelectLanguageView : UIBaseView
	{
		// Token: 0x0600C4F6 RID: 50422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4F6")]
		[Address(RVA = "0x1630DF4", Offset = "0x1630DF4", VA = "0x7BBBE30DF4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4F7 RID: 50423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4F7")]
		[Address(RVA = "0x1630F14", Offset = "0x1630F14", VA = "0x7BBBE30F14")]
		public UISelectLanguageView()
		{
		}

		// Token: 0x0400F0E6 RID: 61670
		[Token(Token = "0x400F0E6")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel WindowPanel;

		// Token: 0x0400F0E7 RID: 61671
		[Token(Token = "0x400F0E7")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BgMask;

		// Token: 0x0400F0E8 RID: 61672
		[Token(Token = "0x400F0E8")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid ToggleGrid;
	}
}
