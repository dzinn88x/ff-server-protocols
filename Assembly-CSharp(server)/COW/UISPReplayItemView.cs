using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200254A RID: 9546
	[Token(Token = "0x200254A")]
	internal class UISPReplayItemView : UIBaseView
	{
		// Token: 0x0600C5A4 RID: 50596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5A4")]
		[Address(RVA = "0x16284FC", Offset = "0x16284FC", VA = "0x7BBBE284FC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5A5 RID: 50597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5A5")]
		[Address(RVA = "0x16287D4", Offset = "0x16287D4", VA = "0x7BBBE287D4")]
		public UISPReplayItemView()
		{
		}

		// Token: 0x0400F455 RID: 62549
		[Token(Token = "0x400F455")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Date;

		// Token: 0x0400F456 RID: 62550
		[Token(Token = "0x400F456")]
		[FieldOffset(Offset = "0x28")]
		public UILabel MatchID;

		// Token: 0x0400F457 RID: 62551
		[Token(Token = "0x400F457")]
		[FieldOffset(Offset = "0x30")]
		public UILabel RoomInfo;

		// Token: 0x0400F458 RID: 62552
		[Token(Token = "0x400F458")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Players;

		// Token: 0x0400F459 RID: 62553
		[Token(Token = "0x400F459")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ModeName;

		// Token: 0x0400F45A RID: 62554
		[Token(Token = "0x400F45A")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Sole;

		// Token: 0x0400F45B RID: 62555
		[Token(Token = "0x400F45B")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Duo;

		// Token: 0x0400F45C RID: 62556
		[Token(Token = "0x400F45C")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Quad;

		// Token: 0x0400F45D RID: 62557
		[Token(Token = "0x400F45D")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Time;

		// Token: 0x0400F45E RID: 62558
		[Token(Token = "0x400F45E")]
		[FieldOffset(Offset = "0x68")]
		public UIButton PlayBtn;

		// Token: 0x0400F45F RID: 62559
		[Token(Token = "0x400F45F")]
		[FieldOffset(Offset = "0x70")]
		public UIButton DelBtn;
	}
}
