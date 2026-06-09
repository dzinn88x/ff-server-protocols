using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002286 RID: 8838
	[Token(Token = "0x2002286")]
	public class UIHUDBountyRepairProgressView : UIBaseView
	{
		// Token: 0x0600C01D RID: 49181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C01D")]
		[Address(RVA = "0x16B6A08", Offset = "0x16B6A08", VA = "0x7BBBEB6A08", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C01E RID: 49182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C01E")]
		[Address(RVA = "0x16B6B28", Offset = "0x16B6B28", VA = "0x7BBBEB6B28")]
		public UIHUDBountyRepairProgressView()
		{
		}

		// Token: 0x0400D443 RID: 54339
		[Token(Token = "0x400D443")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Label_Percent;

		// Token: 0x0400D444 RID: 54340
		[Token(Token = "0x400D444")]
		[FieldOffset(Offset = "0x28")]
		public UIProgressBar ProgressBar;

		// Token: 0x0400D445 RID: 54341
		[Token(Token = "0x400D445")]
		[FieldOffset(Offset = "0x30")]
		public Transform LightLineEffect;
	}
}
