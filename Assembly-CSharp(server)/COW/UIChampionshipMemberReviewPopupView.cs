using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002133 RID: 8499
	[Token(Token = "0x2002133")]
	public class UIChampionshipMemberReviewPopupView : UIBaseView
	{
		// Token: 0x0600BD76 RID: 48502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD76")]
		[Address(RVA = "0x1EC6BBC", Offset = "0x1EC6BBC", VA = "0x7BBC6C6BBC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD77 RID: 48503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD77")]
		[Address(RVA = "0x1EC6FBC", Offset = "0x1EC6FBC", VA = "0x7BBC6C6FBC")]
		public UIChampionshipMemberReviewPopupView()
		{
		}

		// Token: 0x0400C392 RID: 50066
		[Token(Token = "0x400C392")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Tabs;

		// Token: 0x0400C393 RID: 50067
		[Token(Token = "0x400C393")]
		[FieldOffset(Offset = "0x28")]
		public UITable Btns;

		// Token: 0x0400C394 RID: 50068
		[Token(Token = "0x400C394")]
		[FieldOffset(Offset = "0x30")]
		public UIToggleButton BtnApply;

		// Token: 0x0400C395 RID: 50069
		[Token(Token = "0x400C395")]
		[FieldOffset(Offset = "0x38")]
		public UITipsButton ApplyTipsBtn;

		// Token: 0x0400C396 RID: 50070
		[Token(Token = "0x400C396")]
		[FieldOffset(Offset = "0x40")]
		public UIToggleButton BtnInvite;

		// Token: 0x0400C397 RID: 50071
		[Token(Token = "0x400C397")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LabelUnSelect;

		// Token: 0x0400C398 RID: 50072
		[Token(Token = "0x400C398")]
		[FieldOffset(Offset = "0x50")]
		public UITipsButton InviteTipsBtn;

		// Token: 0x0400C399 RID: 50073
		[Token(Token = "0x400C399")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Apply;

		// Token: 0x0400C39A RID: 50074
		[Token(Token = "0x400C39A")]
		[FieldOffset(Offset = "0x60")]
		public UIEasyList ApplyEasyList;

		// Token: 0x0400C39B RID: 50075
		[Token(Token = "0x400C39B")]
		[FieldOffset(Offset = "0x68")]
		public UIButton RejectAll;

		// Token: 0x0400C39C RID: 50076
		[Token(Token = "0x400C39C")]
		[FieldOffset(Offset = "0x70")]
		public GameObject ApplyNoData;

		// Token: 0x0400C39D RID: 50077
		[Token(Token = "0x400C39D")]
		[FieldOffset(Offset = "0x78")]
		public GameObject Invite;

		// Token: 0x0400C39E RID: 50078
		[Token(Token = "0x400C39E")]
		[FieldOffset(Offset = "0x80")]
		public UIEasyList InviteEasyList;

		// Token: 0x0400C39F RID: 50079
		[Token(Token = "0x400C39F")]
		[FieldOffset(Offset = "0x88")]
		public UIButton RejectAllInvite;

		// Token: 0x0400C3A0 RID: 50080
		[Token(Token = "0x400C3A0")]
		[FieldOffset(Offset = "0x90")]
		public GameObject InviteNoData;
	}
}
