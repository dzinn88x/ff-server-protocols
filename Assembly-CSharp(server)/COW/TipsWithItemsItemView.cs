using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020D0 RID: 8400
	[Token(Token = "0x20020D0")]
	internal class TipsWithItemsItemView : UIBaseView
	{
		// Token: 0x0600BCB1 RID: 48305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCB1")]
		[Address(RVA = "0x1B49868", Offset = "0x1B49868", VA = "0x7BBC349868", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCB2 RID: 48306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCB2")]
		[Address(RVA = "0x1B499D4", Offset = "0x1B499D4", VA = "0x7BBC3499D4")]
		public TipsWithItemsItemView()
		{
		}

		// Token: 0x0400BE5B RID: 48731
		[Token(Token = "0x400BE5B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject TitlePivot;

		// Token: 0x0400BE5C RID: 48732
		[Token(Token = "0x400BE5C")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Title;

		// Token: 0x0400BE5D RID: 48733
		[Token(Token = "0x400BE5D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ContentPivot;

		// Token: 0x0400BE5E RID: 48734
		[Token(Token = "0x400BE5E")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Content;
	}
}
