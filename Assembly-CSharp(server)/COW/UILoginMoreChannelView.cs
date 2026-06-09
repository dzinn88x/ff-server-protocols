using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002407 RID: 9223
	[Token(Token = "0x2002407")]
	public class UILoginMoreChannelView : UIBaseView
	{
		// Token: 0x0600C31E RID: 49950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C31E")]
		[Address(RVA = "0x19E7804", Offset = "0x19E7804", VA = "0x7BBC1E7804", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C31F RID: 49951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C31F")]
		[Address(RVA = "0x19E7988", Offset = "0x19E7988", VA = "0x7BBC1E7988")]
		public UILoginMoreChannelView()
		{
		}

		// Token: 0x0400E35A RID: 58202
		[Token(Token = "0x400E35A")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid Grid;

		// Token: 0x0400E35B RID: 58203
		[Token(Token = "0x400E35B")]
		[FieldOffset(Offset = "0x28")]
		public UIButton VK;

		// Token: 0x0400E35C RID: 58204
		[Token(Token = "0x400E35C")]
		[FieldOffset(Offset = "0x30")]
		public UIButton Google;

		// Token: 0x0400E35D RID: 58205
		[Token(Token = "0x400E35D")]
		[FieldOffset(Offset = "0x38")]
		public UIButton Facebook;

		// Token: 0x0400E35E RID: 58206
		[Token(Token = "0x400E35E")]
		[FieldOffset(Offset = "0x40")]
		public UIButton Twitter;
	}
}
