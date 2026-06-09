using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021D1 RID: 8657
	[Token(Token = "0x20021D1")]
	public class UIEPTaskEntryView : UIBaseView
	{
		// Token: 0x0600BEB3 RID: 48819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEB3")]
		[Address(RVA = "0x1ACE2C4", Offset = "0x1ACE2C4", VA = "0x7BBC2CE2C4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEB4 RID: 48820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEB4")]
		[Address(RVA = "0x1ACE430", Offset = "0x1ACE430", VA = "0x7BBC2CE430")]
		public UIEPTaskEntryView()
		{
		}

		// Token: 0x0400CB69 RID: 52073
		[Token(Token = "0x400CB69")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Icon;

		// Token: 0x0400CB6A RID: 52074
		[Token(Token = "0x400CB6A")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ChallengeTips;

		// Token: 0x0400CB6B RID: 52075
		[Token(Token = "0x400CB6B")]
		[FieldOffset(Offset = "0x30")]
		public UIProgressBar ProgressBar;

		// Token: 0x0400CB6C RID: 52076
		[Token(Token = "0x400CB6C")]
		[FieldOffset(Offset = "0x38")]
		public GameObject NewTag;
	}
}
