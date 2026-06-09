using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200250F RID: 9487
	[Token(Token = "0x200250F")]
	public class UISPHudDeadInfoView : UIBaseView
	{
		// Token: 0x0600C52E RID: 50478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C52E")]
		[Address(RVA = "0x1EE6EB4", Offset = "0x1EE6EB4", VA = "0x7BBC6E6EB4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C52F RID: 50479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C52F")]
		[Address(RVA = "0x1EE6FD4", Offset = "0x1EE6FD4", VA = "0x7BBC6E6FD4")]
		public UISPHudDeadInfoView()
		{
		}

		// Token: 0x0400F20D RID: 61965
		[Token(Token = "0x400F20D")]
		[FieldOffset(Offset = "0x20")]
		public GameObject DeadInfoGo;

		// Token: 0x0400F20E RID: 61966
		[Token(Token = "0x400F20E")]
		[FieldOffset(Offset = "0x28")]
		public GameObject DeadIcon;

		// Token: 0x0400F20F RID: 61967
		[Token(Token = "0x400F20F")]
		[FieldOffset(Offset = "0x30")]
		public TweenAlpha DeadIconTA;
	}
}
