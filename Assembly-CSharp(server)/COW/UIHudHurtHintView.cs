using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022E4 RID: 8932
	[Token(Token = "0x20022E4")]
	public class UIHudHurtHintView : UIBaseView
	{
		// Token: 0x0600C0D8 RID: 49368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0D8")]
		[Address(RVA = "0x1980084", Offset = "0x1980084", VA = "0x7BBC180084", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0D9 RID: 49369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0D9")]
		[Address(RVA = "0x19801E0", Offset = "0x19801E0", VA = "0x7BBC1801E0")]
		public UIHudHurtHintView()
		{
		}

		// Token: 0x0400D702 RID: 55042
		[Token(Token = "0x400D702")]
		[FieldOffset(Offset = "0x20")]
		public GameObject HintGo;

		// Token: 0x0400D703 RID: 55043
		[Token(Token = "0x400D703")]
		[FieldOffset(Offset = "0x28")]
		public GameObject HintPenetrateGo;

		// Token: 0x0400D704 RID: 55044
		[Token(Token = "0x400D704")]
		[FieldOffset(Offset = "0x30")]
		public GameObject HintStrongerGo;

		// Token: 0x0400D705 RID: 55045
		[Token(Token = "0x400D705")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HintWeakerGo;
	}
}
