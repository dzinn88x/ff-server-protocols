using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002384 RID: 9092
	[Token(Token = "0x2002384")]
	public class UIHudTokenLeaderboardView : UIBaseView
	{
		// Token: 0x0600C218 RID: 49688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C218")]
		[Address(RVA = "0x15E7380", Offset = "0x15E7380", VA = "0x7BBBDE7380", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C219 RID: 49689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C219")]
		[Address(RVA = "0x15E761C", Offset = "0x15E761C", VA = "0x7BBBDE761C")]
		public UIHudTokenLeaderboardView()
		{
		}

		// Token: 0x0400DCA8 RID: 56488
		[Token(Token = "0x400DCA8")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid ItemListGridMyTeam;

		// Token: 0x0400DCA9 RID: 56489
		[Token(Token = "0x400DCA9")]
		[FieldOffset(Offset = "0x28")]
		public Transform ItemListGridMyTeamTF;

		// Token: 0x0400DCAA RID: 56490
		[Token(Token = "0x400DCAA")]
		[FieldOffset(Offset = "0x30")]
		public UISprite MyFactionIcon;

		// Token: 0x0400DCAB RID: 56491
		[Token(Token = "0x400DCAB")]
		[FieldOffset(Offset = "0x38")]
		public UILabel MyFactionName;

		// Token: 0x0400DCAC RID: 56492
		[Token(Token = "0x400DCAC")]
		[FieldOffset(Offset = "0x40")]
		public UIGrid ItemListGridEnemyTeam;

		// Token: 0x0400DCAD RID: 56493
		[Token(Token = "0x400DCAD")]
		[FieldOffset(Offset = "0x48")]
		public Transform ItemListGridEnemyTeamTF;

		// Token: 0x0400DCAE RID: 56494
		[Token(Token = "0x400DCAE")]
		[FieldOffset(Offset = "0x50")]
		public UISprite EnemyFactionIcon;

		// Token: 0x0400DCAF RID: 56495
		[Token(Token = "0x400DCAF")]
		[FieldOffset(Offset = "0x58")]
		public UILabel EnemyFactionName;

		// Token: 0x0400DCB0 RID: 56496
		[Token(Token = "0x400DCB0")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnClose;
	}
}
