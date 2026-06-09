using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200219B RID: 8603
	[Token(Token = "0x200219B")]
	public class UIDebugConsoleOptionListItemView : UIBaseView
	{
		// Token: 0x0600BE46 RID: 48710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE46")]
		[Address(RVA = "0x1BB9818", Offset = "0x1BB9818", VA = "0x7BBC3B9818", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE47 RID: 48711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE47")]
		[Address(RVA = "0x1BB9908", Offset = "0x1BB9908", VA = "0x7BBC3B9908")]
		public UIDebugConsoleOptionListItemView()
		{
		}

		// Token: 0x0400C8C3 RID: 51395
		[Token(Token = "0x400C8C3")]
		[FieldOffset(Offset = "0x20")]
		public UIButton btnOption;

		// Token: 0x0400C8C4 RID: 51396
		[Token(Token = "0x400C8C4")]
		[FieldOffset(Offset = "0x28")]
		public UILabel OptionName;
	}
}
