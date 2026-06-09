using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002140 RID: 8512
	[Token(Token = "0x2002140")]
	public class UIChampionshipTeamJoinView : UIBaseView
	{
		// Token: 0x0600BD90 RID: 48528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD90")]
		[Address(RVA = "0x1ED48E0", Offset = "0x1ED48E0", VA = "0x7BBC6D48E0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD91 RID: 48529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD91")]
		[Address(RVA = "0x1ED4A54", Offset = "0x1ED4A54", VA = "0x7BBC6D4A54")]
		public UIChampionshipTeamJoinView()
		{
		}

		// Token: 0x0400C3EC RID: 50156
		[Token(Token = "0x400C3EC")]
		[FieldOffset(Offset = "0x20")]
		public UIInput SearchInput;

		// Token: 0x0400C3ED RID: 50157
		[Token(Token = "0x400C3ED")]
		[FieldOffset(Offset = "0x28")]
		public UIButton SearchButton;

		// Token: 0x0400C3EE RID: 50158
		[Token(Token = "0x400C3EE")]
		[FieldOffset(Offset = "0x30")]
		public UIEasyList TeamList;

		// Token: 0x0400C3EF RID: 50159
		[Token(Token = "0x400C3EF")]
		[FieldOffset(Offset = "0x38")]
		public GameObject EmptyTips;
	}
}
