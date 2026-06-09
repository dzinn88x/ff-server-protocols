using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002292 RID: 8850
	[Token(Token = "0x2002292")]
	internal class UIHUDCenterUpTitleView : UIBaseView
	{
		// Token: 0x0600C035 RID: 49205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C035")]
		[Address(RVA = "0x16B7050", Offset = "0x16B7050", VA = "0x7BBBEB7050", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C036 RID: 49206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C036")]
		[Address(RVA = "0x16B70EC", Offset = "0x16B70EC", VA = "0x7BBBEB70EC")]
		public UIHUDCenterUpTitleView()
		{
		}

		// Token: 0x0400D478 RID: 54392
		[Token(Token = "0x400D478")]
		[FieldOffset(Offset = "0x20")]
		public UILabel TitleLabel;
	}
}
