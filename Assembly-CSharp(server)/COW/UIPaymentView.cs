using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002485 RID: 9349
	[Token(Token = "0x2002485")]
	public class UIPaymentView : UIBaseView
	{
		// Token: 0x0600C41A RID: 50202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C41A")]
		[Address(RVA = "0x1F3A61C", Offset = "0x1F3A61C", VA = "0x7BBC73A61C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C41B RID: 50203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C41B")]
		[Address(RVA = "0x1F3A73C", Offset = "0x1F3A73C", VA = "0x7BBC73A73C")]
		public UIPaymentView()
		{
		}

		// Token: 0x0400EAE8 RID: 60136
		[Token(Token = "0x400EAE8")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget LeftContainer;

		// Token: 0x0400EAE9 RID: 60137
		[Token(Token = "0x400EAE9")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid LeftGrid;

		// Token: 0x0400EAEA RID: 60138
		[Token(Token = "0x400EAEA")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget RightContainer;
	}
}
