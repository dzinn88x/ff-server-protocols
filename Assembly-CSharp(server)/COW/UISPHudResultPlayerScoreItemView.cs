using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002532 RID: 9522
	[Token(Token = "0x2002532")]
	internal class UISPHudResultPlayerScoreItemView : UIBaseView
	{
		// Token: 0x0600C574 RID: 50548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C574")]
		[Address(RVA = "0x1EF0E64", Offset = "0x1EF0E64", VA = "0x7BBC6F0E64", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C575 RID: 50549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C575")]
		[Address(RVA = "0x1EF0F7C", Offset = "0x1EF0F7C", VA = "0x7BBC6F0F7C")]
		public UISPHudResultPlayerScoreItemView()
		{
		}

		// Token: 0x0400F359 RID: 62297
		[Token(Token = "0x400F359")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UISPHudResultPlayerScoreItem;

		// Token: 0x0400F35A RID: 62298
		[Token(Token = "0x400F35A")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Name;

		// Token: 0x0400F35B RID: 62299
		[Token(Token = "0x400F35B")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Cnt;
	}
}
