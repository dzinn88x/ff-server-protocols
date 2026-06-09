using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002531 RID: 9521
	[Token(Token = "0x2002531")]
	internal class UISPHudResultPlayerItemView : UIBaseView
	{
		// Token: 0x0600C572 RID: 50546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C572")]
		[Address(RVA = "0x1EF0D44", Offset = "0x1EF0D44", VA = "0x7BBC6F0D44", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C573 RID: 50547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C573")]
		[Address(RVA = "0x1EF0E5C", Offset = "0x1EF0E5C", VA = "0x7BBC6F0E5C")]
		public UISPHudResultPlayerItemView()
		{
		}

		// Token: 0x0400F356 RID: 62294
		[Token(Token = "0x400F356")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UISPHudResultPlayerItem;

		// Token: 0x0400F357 RID: 62295
		[Token(Token = "0x400F357")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Name;

		// Token: 0x0400F358 RID: 62296
		[Token(Token = "0x400F358")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Cnt;
	}
}
