using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002305 RID: 8965
	[Token(Token = "0x2002305")]
	public class UIHudMatchEndShowTime2TeamsView : UIBaseView
	{
		// Token: 0x0600C11A RID: 49434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C11A")]
		[Address(RVA = "0x15BE1F0", Offset = "0x15BE1F0", VA = "0x7BBBDBE1F0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C11B RID: 49435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C11B")]
		[Address(RVA = "0x15BE52C", Offset = "0x15BE52C", VA = "0x7BBBDBE52C")]
		public UIHudMatchEndShowTime2TeamsView()
		{
		}

		// Token: 0x0400D851 RID: 55377
		[Token(Token = "0x400D851")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Lose;

		// Token: 0x0400D852 RID: 55378
		[Token(Token = "0x400D852")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Win;

		// Token: 0x0400D853 RID: 55379
		[Token(Token = "0x400D853")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ShowTimeLabel;

		// Token: 0x0400D854 RID: 55380
		[Token(Token = "0x400D854")]
		[FieldOffset(Offset = "0x38")]
		public UIButton ShowResultBtn;

		// Token: 0x0400D855 RID: 55381
		[Token(Token = "0x400D855")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ShowResultLabel;

		// Token: 0x0400D856 RID: 55382
		[Token(Token = "0x400D856")]
		[FieldOffset(Offset = "0x48")]
		public UILabel Time;

		// Token: 0x0400D857 RID: 55383
		[Token(Token = "0x400D857")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Team1Root;

		// Token: 0x0400D858 RID: 55384
		[Token(Token = "0x400D858")]
		[FieldOffset(Offset = "0x58")]
		public UISprite Team1Icon;

		// Token: 0x0400D859 RID: 55385
		[Token(Token = "0x400D859")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Team1Score;

		// Token: 0x0400D85A RID: 55386
		[Token(Token = "0x400D85A")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Team2Root;

		// Token: 0x0400D85B RID: 55387
		[Token(Token = "0x400D85B")]
		[FieldOffset(Offset = "0x70")]
		public UISprite Team2Icon;

		// Token: 0x0400D85C RID: 55388
		[Token(Token = "0x400D85C")]
		[FieldOffset(Offset = "0x78")]
		public UILabel Team2Score;
	}
}
