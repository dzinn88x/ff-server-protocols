using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200212D RID: 8493
	[Token(Token = "0x200212D")]
	public class UIChampionshipEmulatorErrorWndView : UIBaseView
	{
		// Token: 0x0600BD6A RID: 48490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD6A")]
		[Address(RVA = "0x1C30394", Offset = "0x1C30394", VA = "0x7BBC430394", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD6B RID: 48491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD6B")]
		[Address(RVA = "0x1C304B4", Offset = "0x1C304B4", VA = "0x7BBC4304B4")]
		public UIChampionshipEmulatorErrorWndView()
		{
		}

		// Token: 0x0400C326 RID: 49958
		[Token(Token = "0x400C326")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Message;

		// Token: 0x0400C327 RID: 49959
		[Token(Token = "0x400C327")]
		[FieldOffset(Offset = "0x28")]
		public UIButton OkBtn;

		// Token: 0x0400C328 RID: 49960
		[Token(Token = "0x400C328")]
		[FieldOffset(Offset = "0x30")]
		public UILabel BtnOKLabel;
	}
}
