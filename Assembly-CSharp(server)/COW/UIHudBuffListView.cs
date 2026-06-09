using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200228B RID: 8843
	[Token(Token = "0x200228B")]
	internal class UIHudBuffListView : UIBaseView
	{
		// Token: 0x0600C027 RID: 49191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C027")]
		[Address(RVA = "0x19B5340", Offset = "0x19B5340", VA = "0x7BBC1B5340", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C028 RID: 49192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C028")]
		[Address(RVA = "0x19B5430", Offset = "0x19B5430", VA = "0x7BBC1B5430")]
		public UIHudBuffListView()
		{
		}

		// Token: 0x0400D454 RID: 54356
		[Token(Token = "0x400D454")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid ItemListGrid;

		// Token: 0x0400D455 RID: 54357
		[Token(Token = "0x400D455")]
		[FieldOffset(Offset = "0x28")]
		public Transform ItemListGridTF;
	}
}
