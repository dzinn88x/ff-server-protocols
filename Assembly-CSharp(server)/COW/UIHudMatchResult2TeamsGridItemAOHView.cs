using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002307 RID: 8967
	[Token(Token = "0x2002307")]
	public class UIHudMatchResult2TeamsGridItemAOHView : UIBaseView
	{
		// Token: 0x0600C11E RID: 49438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C11E")]
		[Address(RVA = "0x15C27E8", Offset = "0x15C27E8", VA = "0x7BBBDC27E8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C11F RID: 49439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C11F")]
		[Address(RVA = "0x15C2BC0", Offset = "0x15C2BC0", VA = "0x7BBBDC2BC0")]
		public UIHudMatchResult2TeamsGridItemAOHView()
		{
		}

		// Token: 0x0400D86C RID: 55404
		[Token(Token = "0x400D86C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Self;

		// Token: 0x0400D86D RID: 55405
		[Token(Token = "0x400D86D")]
		[FieldOffset(Offset = "0x28")]
		public UIButton SimpleProfileInfo;

		// Token: 0x0400D86E RID: 55406
		[Token(Token = "0x400D86E")]
		[FieldOffset(Offset = "0x30")]
		public UISprite HeadIcon;

		// Token: 0x0400D86F RID: 55407
		[Token(Token = "0x400D86F")]
		[FieldOffset(Offset = "0x38")]
		public GameObject infoContainer;

		// Token: 0x0400D870 RID: 55408
		[Token(Token = "0x400D870")]
		[FieldOffset(Offset = "0x40")]
		public UILabel nickname;

		// Token: 0x0400D871 RID: 55409
		[Token(Token = "0x400D871")]
		[FieldOffset(Offset = "0x48")]
		public UILabel clanName;

		// Token: 0x0400D872 RID: 55410
		[Token(Token = "0x400D872")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Kill;

		// Token: 0x0400D873 RID: 55411
		[Token(Token = "0x400D873")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Death;

		// Token: 0x0400D874 RID: 55412
		[Token(Token = "0x400D874")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Assist;

		// Token: 0x0400D875 RID: 55413
		[Token(Token = "0x400D875")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Damage;

		// Token: 0x0400D876 RID: 55414
		[Token(Token = "0x400D876")]
		[FieldOffset(Offset = "0x70")]
		public UILabel AOHScore1;

		// Token: 0x0400D877 RID: 55415
		[Token(Token = "0x400D877")]
		[FieldOffset(Offset = "0x78")]
		public UILabel AOHScore2;

		// Token: 0x0400D878 RID: 55416
		[Token(Token = "0x400D878")]
		[FieldOffset(Offset = "0x80")]
		public UILabel Evaluation;

		// Token: 0x0400D879 RID: 55417
		[Token(Token = "0x400D879")]
		[FieldOffset(Offset = "0x88")]
		public GameObject Mvp;

		// Token: 0x0400D87A RID: 55418
		[Token(Token = "0x400D87A")]
		[FieldOffset(Offset = "0x90")]
		public UIButton AddFriendBtn;
	}
}
