using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200213E RID: 8510
	[Token(Token = "0x200213E")]
	public class UIChampionshipTeamInviteView : UIBaseView
	{
		// Token: 0x0600BD8C RID: 48524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD8C")]
		[Address(RVA = "0x1ED2A80", Offset = "0x1ED2A80", VA = "0x7BBC6D2A80", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD8D RID: 48525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD8D")]
		[Address(RVA = "0x1ED2BF4", Offset = "0x1ED2BF4", VA = "0x7BBC6D2BF4")]
		public UIChampionshipTeamInviteView()
		{
		}

		// Token: 0x0400C3E0 RID: 50144
		[Token(Token = "0x400C3E0")]
		[FieldOffset(Offset = "0x20")]
		public UIEasyList EasyList;

		// Token: 0x0400C3E1 RID: 50145
		[Token(Token = "0x400C3E1")]
		[FieldOffset(Offset = "0x28")]
		public GameObject EmptyTips;

		// Token: 0x0400C3E2 RID: 50146
		[Token(Token = "0x400C3E2")]
		[FieldOffset(Offset = "0x30")]
		public UIInput SearchInput;

		// Token: 0x0400C3E3 RID: 50147
		[Token(Token = "0x400C3E3")]
		[FieldOffset(Offset = "0x38")]
		public UIButton Search;
	}
}
