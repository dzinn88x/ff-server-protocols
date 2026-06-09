using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002190 RID: 8592
	[Token(Token = "0x2002190")]
	public class UICSLadderDescriptionView : UIBaseView
	{
		// Token: 0x0600BE30 RID: 48688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE30")]
		[Address(RVA = "0x1C22788", Offset = "0x1C22788", VA = "0x7BBC422788", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE31 RID: 48689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE31")]
		[Address(RVA = "0x1C228E4", Offset = "0x1C228E4", VA = "0x7BBC4228E4")]
		public UICSLadderDescriptionView()
		{
		}

		// Token: 0x0400C848 RID: 51272
		[Token(Token = "0x400C848")]
		[FieldOffset(Offset = "0x20")]
		public UILabel SeaSonLabel;

		// Token: 0x0400C849 RID: 51273
		[Token(Token = "0x400C849")]
		[FieldOffset(Offset = "0x28")]
		public UILabel SeaSonTimeLabel;

		// Token: 0x0400C84A RID: 51274
		[Token(Token = "0x400C84A")]
		[FieldOffset(Offset = "0x30")]
		public UILabel SeaSonReward;

		// Token: 0x0400C84B RID: 51275
		[Token(Token = "0x400C84B")]
		[FieldOffset(Offset = "0x38")]
		public UILabel SeaSonRule;
	}
}
