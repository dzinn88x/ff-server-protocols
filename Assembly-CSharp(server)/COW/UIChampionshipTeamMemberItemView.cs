using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002141 RID: 8513
	[Token(Token = "0x2002141")]
	public class UIChampionshipTeamMemberItemView : UIBaseView
	{
		// Token: 0x0600BD92 RID: 48530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD92")]
		[Address(RVA = "0x1ED5360", Offset = "0x1ED5360", VA = "0x7BBC6D5360", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD93 RID: 48531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD93")]
		[Address(RVA = "0x1ED5504", Offset = "0x1ED5504", VA = "0x7BBC6D5504")]
		public UIChampionshipTeamMemberItemView()
		{
		}

		// Token: 0x0400C3F0 RID: 50160
		[Token(Token = "0x400C3F0")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Item;

		// Token: 0x0400C3F1 RID: 50161
		[Token(Token = "0x400C3F1")]
		[FieldOffset(Offset = "0x28")]
		public Transform BaseProfile;

		// Token: 0x0400C3F2 RID: 50162
		[Token(Token = "0x400C3F2")]
		[FieldOffset(Offset = "0x30")]
		public UILabel State;

		// Token: 0x0400C3F3 RID: 50163
		[Token(Token = "0x400C3F3")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Captain;

		// Token: 0x0400C3F4 RID: 50164
		[Token(Token = "0x400C3F4")]
		[FieldOffset(Offset = "0x40")]
		public UISprite bg;
	}
}
