using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024DE RID: 9438
	[Token(Token = "0x20024DE")]
	public class UIRoomDuoPlayerItemView : UIBaseView
	{
		// Token: 0x0600C4CC RID: 50380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4CC")]
		[Address(RVA = "0x1A107A4", Offset = "0x1A107A4", VA = "0x7BBC2107A4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4CD RID: 50381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4CD")]
		[Address(RVA = "0x1A10918", Offset = "0x1A10918", VA = "0x7BBC210918")]
		public UIRoomDuoPlayerItemView()
		{
		}

		// Token: 0x0400EFF5 RID: 61429
		[Token(Token = "0x400EFF5")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Selected;

		// Token: 0x0400EFF6 RID: 61430
		[Token(Token = "0x400EFF6")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Id;

		// Token: 0x0400EFF7 RID: 61431
		[Token(Token = "0x400EFF7")]
		[FieldOffset(Offset = "0x30")]
		public GameObject PlayerGo1;

		// Token: 0x0400EFF8 RID: 61432
		[Token(Token = "0x400EFF8")]
		[FieldOffset(Offset = "0x38")]
		public GameObject PlayerGo2;
	}
}
