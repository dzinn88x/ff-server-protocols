using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024E7 RID: 9447
	[Token(Token = "0x20024E7")]
	internal class UIRoomPopMenuView : UIBaseView
	{
		// Token: 0x0600C4DE RID: 50398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4DE")]
		[Address(RVA = "0x1A21350", Offset = "0x1A21350", VA = "0x7BBC221350", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4DF RID: 50399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4DF")]
		[Address(RVA = "0x1A21638", Offset = "0x1A21638", VA = "0x7BBC221638")]
		public UIRoomPopMenuView()
		{
		}

		// Token: 0x0400F052 RID: 61522
		[Token(Token = "0x400F052")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel WindowPanel;

		// Token: 0x0400F053 RID: 61523
		[Token(Token = "0x400F053")]
		[FieldOffset(Offset = "0x28")]
		public UIButton Mask;

		// Token: 0x0400F054 RID: 61524
		[Token(Token = "0x400F054")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget Container;

		// Token: 0x0400F055 RID: 61525
		[Token(Token = "0x400F055")]
		[FieldOffset(Offset = "0x38")]
		public UIWidget PlayerInfoPanel;

		// Token: 0x0400F056 RID: 61526
		[Token(Token = "0x400F056")]
		[FieldOffset(Offset = "0x40")]
		public UIEffectSprite Portrait;

		// Token: 0x0400F057 RID: 61527
		[Token(Token = "0x400F057")]
		[FieldOffset(Offset = "0x48")]
		public GameObject FakeHead;

		// Token: 0x0400F058 RID: 61528
		[Token(Token = "0x400F058")]
		[FieldOffset(Offset = "0x50")]
		public UIButton AddBtn;

		// Token: 0x0400F059 RID: 61529
		[Token(Token = "0x400F059")]
		[FieldOffset(Offset = "0x58")]
		public GameObject NamePos;

		// Token: 0x0400F05A RID: 61530
		[Token(Token = "0x400F05A")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Name;

		// Token: 0x0400F05B RID: 61531
		[Token(Token = "0x400F05B")]
		[FieldOffset(Offset = "0x68")]
		public UIGrid ItemGrid;
	}
}
