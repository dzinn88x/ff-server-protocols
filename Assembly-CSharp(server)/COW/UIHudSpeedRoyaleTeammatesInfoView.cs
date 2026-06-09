using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200236C RID: 9068
	[Token(Token = "0x200236C")]
	internal class UIHudSpeedRoyaleTeammatesInfoView : UIBaseView
	{
		// Token: 0x0600C1E8 RID: 49640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1E8")]
		[Address(RVA = "0x16712D4", Offset = "0x16712D4", VA = "0x7BBBE712D4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1E9 RID: 49641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1E9")]
		[Address(RVA = "0x16713F4", Offset = "0x16713F4", VA = "0x7BBBE713F4")]
		public UIHudSpeedRoyaleTeammatesInfoView()
		{
		}

		// Token: 0x0400DBE4 RID: 56292
		[Token(Token = "0x400DBE4")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid Grid;

		// Token: 0x0400DBE5 RID: 56293
		[Token(Token = "0x400DBE5")]
		[FieldOffset(Offset = "0x28")]
		public UIHudSpeedRoyaleTeammateItem TeammateTemplate;

		// Token: 0x0400DBE6 RID: 56294
		[Token(Token = "0x400DBE6")]
		[FieldOffset(Offset = "0x30")]
		public UIHudSpeedRoyaleTeammateGroup TeammateGroupTemplate;
	}
}
