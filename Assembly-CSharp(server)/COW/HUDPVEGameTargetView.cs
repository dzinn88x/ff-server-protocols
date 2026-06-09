using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020BD RID: 8381
	[Token(Token = "0x20020BD")]
	public class HUDPVEGameTargetView : UIBaseView
	{
		// Token: 0x0600BC8B RID: 48267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC8B")]
		[Address(RVA = "0x1857EDC", Offset = "0x1857EDC", VA = "0x7BBC057EDC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BC8C RID: 48268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC8C")]
		[Address(RVA = "0x18580BC", Offset = "0x18580BC", VA = "0x7BBC0580BC")]
		public HUDPVEGameTargetView()
		{
		}

		// Token: 0x0400BD35 RID: 48437
		[Token(Token = "0x400BD35")]
		[FieldOffset(Offset = "0x20")]
		public GameObject RoundContentContainer;

		// Token: 0x0400BD36 RID: 48438
		[Token(Token = "0x400BD36")]
		[FieldOffset(Offset = "0x28")]
		public UILabel RoundLabel;

		// Token: 0x0400BD37 RID: 48439
		[Token(Token = "0x400BD37")]
		[FieldOffset(Offset = "0x30")]
		public UILabel RoundLabel_01;

		// Token: 0x0400BD38 RID: 48440
		[Token(Token = "0x400BD38")]
		[FieldOffset(Offset = "0x38")]
		public UILabel RoundLabel_02;

		// Token: 0x0400BD39 RID: 48441
		[Token(Token = "0x400BD39")]
		[FieldOffset(Offset = "0x40")]
		public GameObject GameWinContainer;

		// Token: 0x0400BD3A RID: 48442
		[Token(Token = "0x400BD3A")]
		[FieldOffset(Offset = "0x48")]
		public GameObject TimeOutContainer;
	}
}
