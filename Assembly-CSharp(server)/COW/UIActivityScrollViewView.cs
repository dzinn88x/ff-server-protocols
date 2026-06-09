using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020E8 RID: 8424
	[Token(Token = "0x20020E8")]
	public class UIActivityScrollViewView : UIBaseView
	{
		// Token: 0x0600BCE1 RID: 48353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE1")]
		[Address(RVA = "0x195B5AC", Offset = "0x195B5AC", VA = "0x7BBC15B5AC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCE2 RID: 48354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE2")]
		[Address(RVA = "0x195B750", Offset = "0x195B750", VA = "0x7BBC15B750")]
		public UIActivityScrollViewView()
		{
		}

		// Token: 0x0400BF3D RID: 48957
		[Token(Token = "0x400BF3D")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel Mask;

		// Token: 0x0400BF3E RID: 48958
		[Token(Token = "0x400BF3E")]
		[FieldOffset(Offset = "0x28")]
		public UIDragScrollView DragArea;

		// Token: 0x0400BF3F RID: 48959
		[Token(Token = "0x400BF3F")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget DragWidget;

		// Token: 0x0400BF40 RID: 48960
		[Token(Token = "0x400BF40")]
		[FieldOffset(Offset = "0x38")]
		public UIScrollView ScrollView;

		// Token: 0x0400BF41 RID: 48961
		[Token(Token = "0x400BF41")]
		[FieldOffset(Offset = "0x40")]
		public UITable Table;
	}
}
