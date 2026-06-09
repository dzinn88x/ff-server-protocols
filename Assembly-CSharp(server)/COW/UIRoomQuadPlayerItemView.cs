using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024E8 RID: 9448
	[Token(Token = "0x20024E8")]
	public class UIRoomQuadPlayerItemView : UIBaseView
	{
		// Token: 0x0600C4E0 RID: 50400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4E0")]
		[Address(RVA = "0x1A21D24", Offset = "0x1A21D24", VA = "0x7BBC221D24", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4E1 RID: 50401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4E1")]
		[Address(RVA = "0x1A21F04", Offset = "0x1A21F04", VA = "0x7BBC221F04")]
		public UIRoomQuadPlayerItemView()
		{
		}

		// Token: 0x0400F05C RID: 61532
		[Token(Token = "0x400F05C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Selected;

		// Token: 0x0400F05D RID: 61533
		[Token(Token = "0x400F05D")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Id;

		// Token: 0x0400F05E RID: 61534
		[Token(Token = "0x400F05E")]
		[FieldOffset(Offset = "0x30")]
		public GameObject PlayerGo1;

		// Token: 0x0400F05F RID: 61535
		[Token(Token = "0x400F05F")]
		[FieldOffset(Offset = "0x38")]
		public GameObject PlayerGo2;

		// Token: 0x0400F060 RID: 61536
		[Token(Token = "0x400F060")]
		[FieldOffset(Offset = "0x40")]
		public GameObject PlayerGo3;

		// Token: 0x0400F061 RID: 61537
		[Token(Token = "0x400F061")]
		[FieldOffset(Offset = "0x48")]
		public GameObject PlayerGo4;
	}
}
