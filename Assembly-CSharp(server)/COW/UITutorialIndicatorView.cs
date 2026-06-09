using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200257E RID: 9598
	[Token(Token = "0x200257E")]
	public class UITutorialIndicatorView : UIBaseView
	{
		// Token: 0x0600C60C RID: 50700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C60C")]
		[Address(RVA = "0x19FA70C", Offset = "0x19FA70C", VA = "0x7BBC1FA70C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C60D RID: 50701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C60D")]
		[Address(RVA = "0x19FAB08", Offset = "0x19FAB08", VA = "0x7BBC1FAB08")]
		public UITutorialIndicatorView()
		{
		}

		// Token: 0x0400F6A5 RID: 63141
		[Token(Token = "0x400F6A5")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel MainPanel;

		// Token: 0x0400F6A6 RID: 63142
		[Token(Token = "0x400F6A6")]
		[FieldOffset(Offset = "0x28")]
		public GameObject VisualControlObject_Right;

		// Token: 0x0400F6A7 RID: 63143
		[Token(Token = "0x400F6A7")]
		[FieldOffset(Offset = "0x30")]
		public GameObject VisualControlObject_Left;

		// Token: 0x0400F6A8 RID: 63144
		[Token(Token = "0x400F6A8")]
		[FieldOffset(Offset = "0x38")]
		public GameObject VisualControlObject_Middle;

		// Token: 0x0400F6A9 RID: 63145
		[Token(Token = "0x400F6A9")]
		[FieldOffset(Offset = "0x40")]
		public GameObject IndicatorObject;

		// Token: 0x0400F6AA RID: 63146
		[Token(Token = "0x400F6AA")]
		[FieldOffset(Offset = "0x48")]
		public GameObject TextHintObject;

		// Token: 0x0400F6AB RID: 63147
		[Token(Token = "0x400F6AB")]
		[FieldOffset(Offset = "0x50")]
		public UILabel HintLabel;

		// Token: 0x0400F6AC RID: 63148
		[Token(Token = "0x400F6AC")]
		[FieldOffset(Offset = "0x58")]
		public UIWidget TipsBGWidget;

		// Token: 0x0400F6AD RID: 63149
		[Token(Token = "0x400F6AD")]
		[FieldOffset(Offset = "0x60")]
		public GameObject CircleWithArrowObject;

		// Token: 0x0400F6AE RID: 63150
		[Token(Token = "0x400F6AE")]
		[FieldOffset(Offset = "0x68")]
		public GameObject CircleBigObject;

		// Token: 0x0400F6AF RID: 63151
		[Token(Token = "0x400F6AF")]
		[FieldOffset(Offset = "0x70")]
		public GameObject CircleObject;

		// Token: 0x0400F6B0 RID: 63152
		[Token(Token = "0x400F6B0")]
		[FieldOffset(Offset = "0x78")]
		public GameObject CircleWithLineObject;

		// Token: 0x0400F6B1 RID: 63153
		[Token(Token = "0x400F6B1")]
		[FieldOffset(Offset = "0x80")]
		public GameObject LeftLine;

		// Token: 0x0400F6B2 RID: 63154
		[Token(Token = "0x400F6B2")]
		[FieldOffset(Offset = "0x88")]
		public GameObject RightLine;

		// Token: 0x0400F6B3 RID: 63155
		[Token(Token = "0x400F6B3")]
		[FieldOffset(Offset = "0x90")]
		public GameObject MapCircleWithArrowObject;

		// Token: 0x0400F6B4 RID: 63156
		[Token(Token = "0x400F6B4")]
		[FieldOffset(Offset = "0x98")]
		public GameObject CircleSmallHintObject;
	}
}
