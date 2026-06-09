using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200224E RID: 8782
	[Token(Token = "0x200224E")]
	internal class UIGuideTipsView : UIBaseView
	{
		// Token: 0x0600BFAD RID: 49069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFAD")]
		[Address(RVA = "0x16AD32C", Offset = "0x16AD32C", VA = "0x7BBBEAD32C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFAE RID: 49070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFAE")]
		[Address(RVA = "0x16AD44C", Offset = "0x16AD44C", VA = "0x7BBBEAD44C")]
		public UIGuideTipsView()
		{
		}

		// Token: 0x0400D2DB RID: 53979
		[Token(Token = "0x400D2DB")]
		[FieldOffset(Offset = "0x20")]
		public GameObject TextHintObject;

		// Token: 0x0400D2DC RID: 53980
		[Token(Token = "0x400D2DC")]
		[FieldOffset(Offset = "0x28")]
		public UILabel HintLabel;

		// Token: 0x0400D2DD RID: 53981
		[Token(Token = "0x400D2DD")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget TipsBGWidget;
	}
}
