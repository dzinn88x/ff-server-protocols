using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200230E RID: 8974
	[Token(Token = "0x200230E")]
	public class UIHudMatchResult2TeamsView : UIBaseView
	{
		// Token: 0x0600C12C RID: 49452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C12C")]
		[Address(RVA = "0x15C5B08", Offset = "0x15C5B08", VA = "0x7BBBDC5B08", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C12D RID: 49453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C12D")]
		[Address(RVA = "0x15C5F04", Offset = "0x15C5F04", VA = "0x7BBBDC5F04")]
		public UIHudMatchResult2TeamsView()
		{
		}

		// Token: 0x0400D8C7 RID: 55495
		[Token(Token = "0x400D8C7")]
		[FieldOffset(Offset = "0x20")]
		public GameObject TeamInfoContainer;

		// Token: 0x0400D8C8 RID: 55496
		[Token(Token = "0x400D8C8")]
		[FieldOffset(Offset = "0x28")]
		public GameObject LocalTeamIcon;

		// Token: 0x0400D8C9 RID: 55497
		[Token(Token = "0x400D8C9")]
		[FieldOffset(Offset = "0x30")]
		public GameObject OptTeamIcon;

		// Token: 0x0400D8CA RID: 55498
		[Token(Token = "0x400D8CA")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Team2Icon;

		// Token: 0x0400D8CB RID: 55499
		[Token(Token = "0x400D8CB")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Team1Icon;

		// Token: 0x0400D8CC RID: 55500
		[Token(Token = "0x400D8CC")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LocalTeamScore;

		// Token: 0x0400D8CD RID: 55501
		[Token(Token = "0x400D8CD")]
		[FieldOffset(Offset = "0x50")]
		public UILabel OptTeamScore;

		// Token: 0x0400D8CE RID: 55502
		[Token(Token = "0x400D8CE")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Defeat;

		// Token: 0x0400D8CF RID: 55503
		[Token(Token = "0x400D8CF")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Booyah;

		// Token: 0x0400D8D0 RID: 55504
		[Token(Token = "0x400D8D0")]
		[FieldOffset(Offset = "0x68")]
		public GameObject GridContainer;

		// Token: 0x0400D8D1 RID: 55505
		[Token(Token = "0x400D8D1")]
		[FieldOffset(Offset = "0x70")]
		public GameObject GridTitle;

		// Token: 0x0400D8D2 RID: 55506
		[Token(Token = "0x400D8D2")]
		[FieldOffset(Offset = "0x78")]
		public UIGrid GridLeft;

		// Token: 0x0400D8D3 RID: 55507
		[Token(Token = "0x400D8D3")]
		[FieldOffset(Offset = "0x80")]
		public UIGrid GridRight;

		// Token: 0x0400D8D4 RID: 55508
		[Token(Token = "0x400D8D4")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BtnMask;

		// Token: 0x0400D8D5 RID: 55509
		[Token(Token = "0x400D8D5")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnShare;

		// Token: 0x0400D8D6 RID: 55510
		[Token(Token = "0x400D8D6")]
		[FieldOffset(Offset = "0x98")]
		public UIButton BtnNext;
	}
}
