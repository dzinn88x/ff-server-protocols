using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002541 RID: 9537
	[Token(Token = "0x2002541")]
	internal class UISPHudTeammatesInfoView : UIBaseView
	{
		// Token: 0x0600C592 RID: 50578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C592")]
		[Address(RVA = "0x1625D6C", Offset = "0x1625D6C", VA = "0x7BBBE25D6C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C593 RID: 50579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C593")]
		[Address(RVA = "0x1625FC0", Offset = "0x1625FC0", VA = "0x7BBBE25FC0")]
		public UISPHudTeammatesInfoView()
		{
		}

		// Token: 0x0400F405 RID: 62469
		[Token(Token = "0x400F405")]
		[FieldOffset(Offset = "0x20")]
		public UILabel TeamName;

		// Token: 0x0400F406 RID: 62470
		[Token(Token = "0x400F406")]
		[FieldOffset(Offset = "0x28")]
		public UISprite TeamIcon;

		// Token: 0x0400F407 RID: 62471
		[Token(Token = "0x400F407")]
		[FieldOffset(Offset = "0x30")]
		public UISprite FakeTeamIcon;

		// Token: 0x0400F408 RID: 62472
		[Token(Token = "0x400F408")]
		[FieldOffset(Offset = "0x38")]
		public UISprite TeamColorBG1;

		// Token: 0x0400F409 RID: 62473
		[Token(Token = "0x400F409")]
		[FieldOffset(Offset = "0x40")]
		public UISprite TeamColorBG2;

		// Token: 0x0400F40A RID: 62474
		[Token(Token = "0x400F40A")]
		[FieldOffset(Offset = "0x48")]
		public UILabel TeamKillCount;

		// Token: 0x0400F40B RID: 62475
		[Token(Token = "0x400F40B")]
		[FieldOffset(Offset = "0x50")]
		public UIGrid Grid;

		// Token: 0x0400F40C RID: 62476
		[Token(Token = "0x400F40C")]
		[FieldOffset(Offset = "0x58")]
		public UISPHudTeammateItem TeammateTemplate;
	}
}
