using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022B8 RID: 8888
	[Token(Token = "0x20022B8")]
	internal class UIHudDetectorView : UIBaseView
	{
		// Token: 0x0600C080 RID: 49280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C080")]
		[Address(RVA = "0x1BFBE20", Offset = "0x1BFBE20", VA = "0x7BBC3FBE20", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C081 RID: 49281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C081")]
		[Address(RVA = "0x1BFBEBC", Offset = "0x1BFBEBC", VA = "0x7BBC3FBEBC")]
		public UIHudDetectorView()
		{
		}

		// Token: 0x0400D60D RID: 54797
		[Token(Token = "0x400D60D")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Label;
	}
}
