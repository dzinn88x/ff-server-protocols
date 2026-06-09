using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022B2 RID: 8882
	[Token(Token = "0x20022B2")]
	public class UIHudCSSOLeaderboardView : UIBaseView
	{
		// Token: 0x0600C074 RID: 49268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C074")]
		[Address(RVA = "0x19C67D8", Offset = "0x19C67D8", VA = "0x7BBC1C67D8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C075 RID: 49269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C075")]
		[Address(RVA = "0x19C6A64", Offset = "0x19C6A64", VA = "0x7BBC1C6A64")]
		public UIHudCSSOLeaderboardView()
		{
		}

		// Token: 0x0400D566 RID: 54630
		[Token(Token = "0x400D566")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid ItemListGridMyTeam;

		// Token: 0x0400D567 RID: 54631
		[Token(Token = "0x400D567")]
		[FieldOffset(Offset = "0x28")]
		public Transform ItemListGridMyTeamTF;

		// Token: 0x0400D568 RID: 54632
		[Token(Token = "0x400D568")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnClose;

		// Token: 0x0400D569 RID: 54633
		[Token(Token = "0x400D569")]
		[FieldOffset(Offset = "0x38")]
		public GameObject TapToClose;

		// Token: 0x0400D56A RID: 54634
		[Token(Token = "0x400D56A")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Round;

		// Token: 0x0400D56B RID: 54635
		[Token(Token = "0x400D56B")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ComingSoon;

		// Token: 0x0400D56C RID: 54636
		[Token(Token = "0x400D56C")]
		[FieldOffset(Offset = "0x50")]
		public UILabel CountDown;

		// Token: 0x0400D56D RID: 54637
		[Token(Token = "0x400D56D")]
		[FieldOffset(Offset = "0x58")]
		public UILabel CurrRoundNum;

		// Token: 0x0400D56E RID: 54638
		[Token(Token = "0x400D56E")]
		[FieldOffset(Offset = "0x60")]
		public UILabel LastRoundNum;
	}
}
