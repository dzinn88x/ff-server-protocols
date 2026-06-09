using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200219C RID: 8604
	[Token(Token = "0x200219C")]
	public class UIDebugConsoleOptionListView : UIBaseView
	{
		// Token: 0x0600BE48 RID: 48712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE48")]
		[Address(RVA = "0x1BB9910", Offset = "0x1BB9910", VA = "0x7BBC3B9910", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE49 RID: 48713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE49")]
		[Address(RVA = "0x1BB9A00", Offset = "0x1BB9A00", VA = "0x7BBC3B9A00")]
		public UIDebugConsoleOptionListView()
		{
		}

		// Token: 0x0400C8C5 RID: 51397
		[Token(Token = "0x400C8C5")]
		[FieldOffset(Offset = "0x20")]
		public UISprite Board;

		// Token: 0x0400C8C6 RID: 51398
		[Token(Token = "0x400C8C6")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList EasyList;
	}
}
