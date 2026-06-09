using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024A7 RID: 9383
	[Token(Token = "0x20024A7")]
	public class UIProfileEpWindowShowView : UIBaseView
	{
		// Token: 0x0600C45E RID: 50270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C45E")]
		[Address(RVA = "0x1FDB758", Offset = "0x1FDB758", VA = "0x7BBC7DB758", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C45F RID: 50271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C45F")]
		[Address(RVA = "0x1FDB8CC", Offset = "0x1FDB8CC", VA = "0x7BBC7DB8CC")]
		public UIProfileEpWindowShowView()
		{
		}

		// Token: 0x0400ECF3 RID: 60659
		[Token(Token = "0x400ECF3")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView ScrollViewRoot;

		// Token: 0x0400ECF4 RID: 60660
		[Token(Token = "0x400ECF4")]
		[FieldOffset(Offset = "0x28")]
		public UIPanel ScrollViewPanel;

		// Token: 0x0400ECF5 RID: 60661
		[Token(Token = "0x400ECF5")]
		[FieldOffset(Offset = "0x30")]
		public Transform ItemListGridTF;

		// Token: 0x0400ECF6 RID: 60662
		[Token(Token = "0x400ECF6")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid ItemListGrid;
	}
}
