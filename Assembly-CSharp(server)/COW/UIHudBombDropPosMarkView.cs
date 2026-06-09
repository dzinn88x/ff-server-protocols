using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200227D RID: 8829
	[Token(Token = "0x200227D")]
	public class UIHudBombDropPosMarkView : UIBaseView
	{
		// Token: 0x0600C00B RID: 49163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C00B")]
		[Address(RVA = "0x1898870", Offset = "0x1898870", VA = "0x7BBC098870", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C00C RID: 49164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C00C")]
		[Address(RVA = "0x1898A50", Offset = "0x1898A50", VA = "0x7BBC098A50")]
		public UIHudBombDropPosMarkView()
		{
		}

		// Token: 0x0400D401 RID: 54273
		[Token(Token = "0x400D401")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ArrowLeft;

		// Token: 0x0400D402 RID: 54274
		[Token(Token = "0x400D402")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ArrowUp;

		// Token: 0x0400D403 RID: 54275
		[Token(Token = "0x400D403")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ArrowDown;

		// Token: 0x0400D404 RID: 54276
		[Token(Token = "0x400D404")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ArrowRight;

		// Token: 0x0400D405 RID: 54277
		[Token(Token = "0x400D405")]
		[FieldOffset(Offset = "0x40")]
		public UILabel DistanceLabel;

		// Token: 0x0400D406 RID: 54278
		[Token(Token = "0x400D406")]
		[FieldOffset(Offset = "0x48")]
		public UIWidget boundWidget;
	}
}
