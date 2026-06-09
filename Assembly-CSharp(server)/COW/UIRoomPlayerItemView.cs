using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024E6 RID: 9446
	[Token(Token = "0x20024E6")]
	public class UIRoomPlayerItemView : UIBaseView
	{
		// Token: 0x0600C4DC RID: 50396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4DC")]
		[Address(RVA = "0x1A1FE98", Offset = "0x1A1FE98", VA = "0x7BBC21FE98", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4DD RID: 50397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4DD")]
		[Address(RVA = "0x1A20168", Offset = "0x1A20168", VA = "0x7BBC220168")]
		public UIRoomPlayerItemView()
		{
		}

		// Token: 0x0400F047 RID: 61511
		[Token(Token = "0x400F047")]
		[FieldOffset(Offset = "0x20")]
		public UIButton PlayerBtn;

		// Token: 0x0400F048 RID: 61512
		[Token(Token = "0x400F048")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ReadyMark;

		// Token: 0x0400F049 RID: 61513
		[Token(Token = "0x400F049")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Tag;

		// Token: 0x0400F04A RID: 61514
		[Token(Token = "0x400F04A")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Name;

		// Token: 0x0400F04B RID: 61515
		[Token(Token = "0x400F04B")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Selected;

		// Token: 0x0400F04C RID: 61516
		[Token(Token = "0x400F04C")]
		[FieldOffset(Offset = "0x48")]
		public GameObject SimulationIcon;

		// Token: 0x0400F04D RID: 61517
		[Token(Token = "0x400F04D")]
		[FieldOffset(Offset = "0x50")]
		public UILabel SimulationScore;

		// Token: 0x0400F04E RID: 61518
		[Token(Token = "0x400F04E")]
		[FieldOffset(Offset = "0x58")]
		public GameObject MaxIconMid;

		// Token: 0x0400F04F RID: 61519
		[Token(Token = "0x400F04F")]
		[FieldOffset(Offset = "0x60")]
		public GameObject MaxIconBot;

		// Token: 0x0400F050 RID: 61520
		[Token(Token = "0x400F050")]
		[FieldOffset(Offset = "0x68")]
		public GameObject SelfBg;

		// Token: 0x0400F051 RID: 61521
		[Token(Token = "0x400F051")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Icon_Celebrity;
	}
}
