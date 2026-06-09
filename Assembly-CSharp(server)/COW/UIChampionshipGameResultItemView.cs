using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200212F RID: 8495
	[Token(Token = "0x200212F")]
	internal class UIChampionshipGameResultItemView : UIBaseView
	{
		// Token: 0x0600BD6E RID: 48494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD6E")]
		[Address(RVA = "0x1C35510", Offset = "0x1C35510", VA = "0x7BBC435510", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD6F RID: 48495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD6F")]
		[Address(RVA = "0x1C35694", Offset = "0x1C35694", VA = "0x7BBC435694")]
		public UIChampionshipGameResultItemView()
		{
		}

		// Token: 0x0400C35F RID: 50015
		[Token(Token = "0x400C35F")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Rank;

		// Token: 0x0400C360 RID: 50016
		[Token(Token = "0x400C360")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Mode;

		// Token: 0x0400C361 RID: 50017
		[Token(Token = "0x400C361")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Kills;

		// Token: 0x0400C362 RID: 50018
		[Token(Token = "0x400C362")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Score;

		// Token: 0x0400C363 RID: 50019
		[Token(Token = "0x400C363")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Time;
	}
}
