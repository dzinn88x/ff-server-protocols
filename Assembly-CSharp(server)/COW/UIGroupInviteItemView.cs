using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200224A RID: 8778
	[Token(Token = "0x200224A")]
	public class UIGroupInviteItemView : UIBaseView
	{
		// Token: 0x0600BFA5 RID: 49061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFA5")]
		[Address(RVA = "0x16A1B24", Offset = "0x16A1B24", VA = "0x7BBBEA1B24", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFA6 RID: 49062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFA6")]
		[Address(RVA = "0x16A1EC4", Offset = "0x16A1EC4", VA = "0x7BBBEA1EC4")]
		public UIGroupInviteItemView()
		{
		}

		// Token: 0x0400D289 RID: 53897
		[Token(Token = "0x400D289")]
		[FieldOffset(Offset = "0x20")]
		public UIButton bgBtn;

		// Token: 0x0400D28A RID: 53898
		[Token(Token = "0x400D28A")]
		[FieldOffset(Offset = "0x28")]
		public UISprite platformIcon;

		// Token: 0x0400D28B RID: 53899
		[Token(Token = "0x400D28B")]
		[FieldOffset(Offset = "0x30")]
		public UIButton inviteBtn;

		// Token: 0x0400D28C RID: 53900
		[Token(Token = "0x400D28C")]
		[FieldOffset(Offset = "0x38")]
		public GameObject inviteBtnGray;

		// Token: 0x0400D28D RID: 53901
		[Token(Token = "0x400D28D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject inviteSprite;

		// Token: 0x0400D28E RID: 53902
		[Token(Token = "0x400D28E")]
		[FieldOffset(Offset = "0x48")]
		public GameObject JoinObj;

		// Token: 0x0400D28F RID: 53903
		[Token(Token = "0x400D28F")]
		[FieldOffset(Offset = "0x50")]
		public GameObject JoinObjGrey;

		// Token: 0x0400D290 RID: 53904
		[Token(Token = "0x400D290")]
		[FieldOffset(Offset = "0x58")]
		public Transform invited;

		// Token: 0x0400D291 RID: 53905
		[Token(Token = "0x400D291")]
		[FieldOffset(Offset = "0x60")]
		public Transform profileinfo;

		// Token: 0x0400D292 RID: 53906
		[Token(Token = "0x400D292")]
		[FieldOffset(Offset = "0x68")]
		public UIButton ReserveBtn;

		// Token: 0x0400D293 RID: 53907
		[Token(Token = "0x400D293")]
		[FieldOffset(Offset = "0x70")]
		public GameObject CanReserve;

		// Token: 0x0400D294 RID: 53908
		[Token(Token = "0x400D294")]
		[FieldOffset(Offset = "0x78")]
		public GameObject Reserved;

		// Token: 0x0400D295 RID: 53909
		[Token(Token = "0x400D295")]
		[FieldOffset(Offset = "0x80")]
		public GameObject Reserving;

		// Token: 0x0400D296 RID: 53910
		[Token(Token = "0x400D296")]
		[FieldOffset(Offset = "0x88")]
		public GameObject CannotReserve;
	}
}
