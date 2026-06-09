using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200212B RID: 8491
	[Token(Token = "0x200212B")]
	public class UIChampionshipChatRecruitView : UIBaseView
	{
		// Token: 0x0600BD66 RID: 48486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD66")]
		[Address(RVA = "0x1C27B9C", Offset = "0x1C27B9C", VA = "0x7BBC427B9C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD67 RID: 48487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD67")]
		[Address(RVA = "0x1C27DF8", Offset = "0x1C27DF8", VA = "0x7BBC427DF8")]
		public UIChampionshipChatRecruitView()
		{
		}

		// Token: 0x0400C31C RID: 49948
		[Token(Token = "0x400C31C")]
		[FieldOffset(Offset = "0x20")]
		public UILabel MatchName;

		// Token: 0x0400C31D RID: 49949
		[Token(Token = "0x400C31D")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TeamScale;

		// Token: 0x0400C31E RID: 49950
		[Token(Token = "0x400C31E")]
		[FieldOffset(Offset = "0x30")]
		public UIToggle WorldToggle;

		// Token: 0x0400C31F RID: 49951
		[Token(Token = "0x400C31F")]
		[FieldOffset(Offset = "0x38")]
		public UIWidget WorldWidget;

		// Token: 0x0400C320 RID: 49952
		[Token(Token = "0x400C320")]
		[FieldOffset(Offset = "0x40")]
		public UILabel WorldLabel;

		// Token: 0x0400C321 RID: 49953
		[Token(Token = "0x400C321")]
		[FieldOffset(Offset = "0x48")]
		public UIToggle ClanToggle;

		// Token: 0x0400C322 RID: 49954
		[Token(Token = "0x400C322")]
		[FieldOffset(Offset = "0x50")]
		public UIWidget ClanWidget;

		// Token: 0x0400C323 RID: 49955
		[Token(Token = "0x400C323")]
		[FieldOffset(Offset = "0x58")]
		public UIButton SendBtn;
	}
}
