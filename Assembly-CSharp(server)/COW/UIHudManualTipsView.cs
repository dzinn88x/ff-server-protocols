using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002302 RID: 8962
	[Token(Token = "0x2002302")]
	internal class UIHudManualTipsView : UIBaseView
	{
		// Token: 0x0600C114 RID: 49428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C114")]
		[Address(RVA = "0x15BD310", Offset = "0x15BD310", VA = "0x7BBBDBD310", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C115 RID: 49429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C115")]
		[Address(RVA = "0x15BD400", Offset = "0x15BD400", VA = "0x7BBBDBD400")]
		public UIHudManualTipsView()
		{
		}

		// Token: 0x0400D846 RID: 55366
		[Token(Token = "0x400D846")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Content;

		// Token: 0x0400D847 RID: 55367
		[Token(Token = "0x400D847")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Message;
	}
}
