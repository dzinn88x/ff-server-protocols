using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024BB RID: 9403
	[Token(Token = "0x20024BB")]
	public class UIQuickMessageCustomItemView : UIBaseView
	{
		// Token: 0x0600C486 RID: 50310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C486")]
		[Address(RVA = "0x1FF7780", Offset = "0x1FF7780", VA = "0x7BBC7F7780", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C487 RID: 50311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C487")]
		[Address(RVA = "0x1FF7870", Offset = "0x1FF7870", VA = "0x7BBC7F7870")]
		public UIQuickMessageCustomItemView()
		{
		}

		// Token: 0x0400EF09 RID: 61193
		[Token(Token = "0x400EF09")]
		[FieldOffset(Offset = "0x20")]
		public UILabel MessageContent;

		// Token: 0x0400EF0A RID: 61194
		[Token(Token = "0x400EF0A")]
		[FieldOffset(Offset = "0x28")]
		public UIButton DeleteBtn;
	}
}
