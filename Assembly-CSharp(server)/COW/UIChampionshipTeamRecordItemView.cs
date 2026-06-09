using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002144 RID: 8516
	[Token(Token = "0x2002144")]
	public class UIChampionshipTeamRecordItemView : UIBaseView
	{
		// Token: 0x0600BD98 RID: 48536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD98")]
		[Address(RVA = "0x1EDBABC", Offset = "0x1EDBABC", VA = "0x7BBC6DBABC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD99 RID: 48537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD99")]
		[Address(RVA = "0x1EDBD64", Offset = "0x1EDBD64", VA = "0x7BBC6DBD64")]
		public UIChampionshipTeamRecordItemView()
		{
		}

		// Token: 0x0400C427 RID: 50215
		[Token(Token = "0x400C427")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Invalid;

		// Token: 0x0400C428 RID: 50216
		[Token(Token = "0x400C428")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Rank01;

		// Token: 0x0400C429 RID: 50217
		[Token(Token = "0x400C429")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Score01;

		// Token: 0x0400C42A RID: 50218
		[Token(Token = "0x400C42A")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Kill01;

		// Token: 0x0400C42B RID: 50219
		[Token(Token = "0x400C42B")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Session01;

		// Token: 0x0400C42C RID: 50220
		[Token(Token = "0x400C42C")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Valid;

		// Token: 0x0400C42D RID: 50221
		[Token(Token = "0x400C42D")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Session;

		// Token: 0x0400C42E RID: 50222
		[Token(Token = "0x400C42E")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Kill;

		// Token: 0x0400C42F RID: 50223
		[Token(Token = "0x400C42F")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Score;

		// Token: 0x0400C430 RID: 50224
		[Token(Token = "0x400C430")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Rank;
	}
}
