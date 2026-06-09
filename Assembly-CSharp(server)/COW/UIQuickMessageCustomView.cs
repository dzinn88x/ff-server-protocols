using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024BC RID: 9404
	[Token(Token = "0x20024BC")]
	public class UIQuickMessageCustomView : UIBaseView
	{
		// Token: 0x0600C488 RID: 50312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C488")]
		[Address(RVA = "0x1FF7878", Offset = "0x1FF7878", VA = "0x7BBC7F7878", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C489 RID: 50313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C489")]
		[Address(RVA = "0x1FF7AEC", Offset = "0x1FF7AEC", VA = "0x7BBC7F7AEC")]
		public UIQuickMessageCustomView()
		{
		}

		// Token: 0x0400EF0B RID: 61195
		[Token(Token = "0x400EF0B")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView UnselectList;

		// Token: 0x0400EF0C RID: 61196
		[Token(Token = "0x400EF0C")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList UnselectEasyList;

		// Token: 0x0400EF0D RID: 61197
		[Token(Token = "0x400EF0D")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView SelectList;

		// Token: 0x0400EF0E RID: 61198
		[Token(Token = "0x400EF0E")]
		[FieldOffset(Offset = "0x38")]
		public UIEasyList SelectEasyList;

		// Token: 0x0400EF0F RID: 61199
		[Token(Token = "0x400EF0F")]
		[FieldOffset(Offset = "0x40")]
		public UIToggleButton BRToggleBtn;

		// Token: 0x0400EF10 RID: 61200
		[Token(Token = "0x400EF10")]
		[FieldOffset(Offset = "0x48")]
		public UIToggleButton CSToggleBtn;

		// Token: 0x0400EF11 RID: 61201
		[Token(Token = "0x400EF11")]
		[FieldOffset(Offset = "0x50")]
		public UIButton SaveBtn;

		// Token: 0x0400EF12 RID: 61202
		[Token(Token = "0x400EF12")]
		[FieldOffset(Offset = "0x58")]
		public UIButton CancelBtn;
	}
}
