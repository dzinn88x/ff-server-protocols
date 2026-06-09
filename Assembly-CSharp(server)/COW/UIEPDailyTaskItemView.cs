using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021CA RID: 8650
	[Token(Token = "0x20021CA")]
	public class UIEPDailyTaskItemView : UIBaseView
	{
		// Token: 0x0600BEA5 RID: 48805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEA5")]
		[Address(RVA = "0x221257C", Offset = "0x221257C", VA = "0x7BBCA1257C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEA6 RID: 48806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEA6")]
		[Address(RVA = "0x2212720", Offset = "0x2212720", VA = "0x7BBCA12720")]
		public UIEPDailyTaskItemView()
		{
		}

		// Token: 0x0400CB25 RID: 52005
		[Token(Token = "0x400CB25")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Bg;

		// Token: 0x0400CB26 RID: 52006
		[Token(Token = "0x400CB26")]
		[FieldOffset(Offset = "0x28")]
		public Transform Done;

		// Token: 0x0400CB27 RID: 52007
		[Token(Token = "0x400CB27")]
		[FieldOffset(Offset = "0x30")]
		public UILabel DoneCnt;

		// Token: 0x0400CB28 RID: 52008
		[Token(Token = "0x400CB28")]
		[FieldOffset(Offset = "0x38")]
		public UILabel TaskDesc;

		// Token: 0x0400CB29 RID: 52009
		[Token(Token = "0x400CB29")]
		[FieldOffset(Offset = "0x40")]
		public GameObject FinishEffect;
	}
}
