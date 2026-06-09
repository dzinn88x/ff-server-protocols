using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020D8 RID: 8408
	[Token(Token = "0x20020D8")]
	public class UIActivityADContentView : UIBaseView
	{
		// Token: 0x0600BCC1 RID: 48321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCC1")]
		[Address(RVA = "0x1A3EF1C", Offset = "0x1A3EF1C", VA = "0x7BBC23EF1C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCC2 RID: 48322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCC2")]
		[Address(RVA = "0x1A3F214", Offset = "0x1A3F214", VA = "0x7BBC23F214")]
		public UIActivityADContentView()
		{
		}

		// Token: 0x0400BE9E RID: 48798
		[Token(Token = "0x400BE9E")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel Mask;

		// Token: 0x0400BE9F RID: 48799
		[Token(Token = "0x400BE9F")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ArrowDown;

		// Token: 0x0400BEA0 RID: 48800
		[Token(Token = "0x400BEA0")]
		[FieldOffset(Offset = "0x30")]
		public UIDragScrollView DragArea;

		// Token: 0x0400BEA1 RID: 48801
		[Token(Token = "0x400BEA1")]
		[FieldOffset(Offset = "0x38")]
		public UIWidget DragWidget;

		// Token: 0x0400BEA2 RID: 48802
		[Token(Token = "0x400BEA2")]
		[FieldOffset(Offset = "0x40")]
		public UIScrollView ScrollView;

		// Token: 0x0400BEA3 RID: 48803
		[Token(Token = "0x400BEA3")]
		[FieldOffset(Offset = "0x48")]
		public UINetworkTexture AD;

		// Token: 0x0400BEA4 RID: 48804
		[Token(Token = "0x400BEA4")]
		[FieldOffset(Offset = "0x50")]
		public UIEventListener ADMaxEvent;

		// Token: 0x0400BEA5 RID: 48805
		[Token(Token = "0x400BEA5")]
		[FieldOffset(Offset = "0x58")]
		public UIButton GoTo;

		// Token: 0x0400BEA6 RID: 48806
		[Token(Token = "0x400BEA6")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Title;

		// Token: 0x0400BEA7 RID: 48807
		[Token(Token = "0x400BEA7")]
		[FieldOffset(Offset = "0x68")]
		public GameObject GoToRedpoint;
	}
}
