using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200221F RID: 8735
	[Token(Token = "0x200221F")]
	public class UIGachaLimitRemoveConfrimWndView : UIBaseView
	{
		// Token: 0x0600BF4F RID: 48975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF4F")]
		[Address(RVA = "0x2066540", Offset = "0x2066540", VA = "0x7BBC866540", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF50 RID: 48976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF50")]
		[Address(RVA = "0x2066660", Offset = "0x2066660", VA = "0x7BBC866660")]
		public UIGachaLimitRemoveConfrimWndView()
		{
		}

		// Token: 0x0400CF92 RID: 53138
		[Token(Token = "0x400CF92")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid PreviewGrid;

		// Token: 0x0400CF93 RID: 53139
		[Token(Token = "0x400CF93")]
		[FieldOffset(Offset = "0x28")]
		public UIButton OKBtn;

		// Token: 0x0400CF94 RID: 53140
		[Token(Token = "0x400CF94")]
		[FieldOffset(Offset = "0x30")]
		public UILabel BtnLabel;
	}
}
