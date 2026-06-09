using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200214B RID: 8523
	[Token(Token = "0x200214B")]
	public class UIChatBlockListView : UIBaseView
	{
		// Token: 0x0600BDA6 RID: 48550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDA6")]
		[Address(RVA = "0x1BE092C", Offset = "0x1BE092C", VA = "0x7BBC3E092C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDA7 RID: 48551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDA7")]
		[Address(RVA = "0x1BE0A1C", Offset = "0x1BE0A1C", VA = "0x7BBC3E0A1C")]
		public UIChatBlockListView()
		{
		}

		// Token: 0x0400C4A6 RID: 50342
		[Token(Token = "0x400C4A6")]
		[FieldOffset(Offset = "0x20")]
		public UIEasyList EasyList;

		// Token: 0x0400C4A7 RID: 50343
		[Token(Token = "0x400C4A7")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ListCount;
	}
}
