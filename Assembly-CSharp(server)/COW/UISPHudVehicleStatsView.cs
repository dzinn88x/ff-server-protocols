using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002544 RID: 9540
	[Token(Token = "0x2002544")]
	internal class UISPHudVehicleStatsView : UIBaseView
	{
		// Token: 0x0600C598 RID: 50584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C598")]
		[Address(RVA = "0x16273EC", Offset = "0x16273EC", VA = "0x7BBBE273EC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C599 RID: 50585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C599")]
		[Address(RVA = "0x1627588", Offset = "0x1627588", VA = "0x7BBBE27588")]
		public UISPHudVehicleStatsView()
		{
		}

		// Token: 0x0400F421 RID: 62497
		[Token(Token = "0x400F421")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Go;

		// Token: 0x0400F422 RID: 62498
		[Token(Token = "0x400F422")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Container;

		// Token: 0x0400F423 RID: 62499
		[Token(Token = "0x400F423")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LabelSpeed;

		// Token: 0x0400F424 RID: 62500
		[Token(Token = "0x400F424")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HPNode;

		// Token: 0x0400F425 RID: 62501
		[Token(Token = "0x400F425")]
		[FieldOffset(Offset = "0x40")]
		public UISprite HPIcon;
	}
}
