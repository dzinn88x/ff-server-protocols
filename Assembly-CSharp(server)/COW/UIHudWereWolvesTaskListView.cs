using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023AD RID: 9133
	[Token(Token = "0x20023AD")]
	public class UIHudWereWolvesTaskListView : UIBaseView
	{
		// Token: 0x0600C26A RID: 49770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C26A")]
		[Address(RVA = "0x1D17734", Offset = "0x1D17734", VA = "0x7BBC517734", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C26B RID: 49771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C26B")]
		[Address(RVA = "0x1D17824", Offset = "0x1D17824", VA = "0x7BBC517824")]
		public UIHudWereWolvesTaskListView()
		{
		}

		// Token: 0x0400DDDD RID: 56797
		[Token(Token = "0x400DDDD")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView ContentScrollView;

		// Token: 0x0400DDDE RID: 56798
		[Token(Token = "0x400DDDE")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList ContentList;
	}
}
