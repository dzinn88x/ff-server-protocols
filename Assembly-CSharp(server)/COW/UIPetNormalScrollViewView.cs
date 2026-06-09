using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200248B RID: 9355
	[Token(Token = "0x200248B")]
	internal class UIPetNormalScrollViewView : UIBaseView
	{
		// Token: 0x0600C426 RID: 50214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C426")]
		[Address(RVA = "0x20E0D5C", Offset = "0x20E0D5C", VA = "0x7BBC8E0D5C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C427 RID: 50215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C427")]
		[Address(RVA = "0x20E0E4C", Offset = "0x20E0E4C", VA = "0x7BBC8E0E4C")]
		public UIPetNormalScrollViewView()
		{
		}

		// Token: 0x0400EB20 RID: 60192
		[Token(Token = "0x400EB20")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIPetNormalScrollView;

		// Token: 0x0400EB21 RID: 60193
		[Token(Token = "0x400EB21")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList UIPetNormalGrid;
	}
}
