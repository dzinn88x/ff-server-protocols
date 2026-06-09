using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200213D RID: 8509
	[Token(Token = "0x200213D")]
	internal class UIChampionshipTeamInviteItemView : UIBaseView
	{
		// Token: 0x0600BD8A RID: 48522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD8A")]
		[Address(RVA = "0x1ED2958", Offset = "0x1ED2958", VA = "0x7BBC6D2958", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD8B RID: 48523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD8B")]
		[Address(RVA = "0x1ED2A78", Offset = "0x1ED2A78", VA = "0x7BBC6D2A78")]
		public UIChampionshipTeamInviteItemView()
		{
		}

		// Token: 0x0400C3DD RID: 50141
		[Token(Token = "0x400C3DD")]
		[FieldOffset(Offset = "0x20")]
		public Transform BaseProfile;

		// Token: 0x0400C3DE RID: 50142
		[Token(Token = "0x400C3DE")]
		[FieldOffset(Offset = "0x28")]
		public UIButton Invite;

		// Token: 0x0400C3DF RID: 50143
		[Token(Token = "0x400C3DF")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Tips;
	}
}
