using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200229D RID: 8861
	[Token(Token = "0x200229D")]
	public class UIHudControlLeaderboardView : UIBaseView
	{
		// Token: 0x0600C04B RID: 49227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C04B")]
		[Address(RVA = "0x1A93740", Offset = "0x1A93740", VA = "0x7BBC293740", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C04C RID: 49228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C04C")]
		[Address(RVA = "0x1A93B18", Offset = "0x1A93B18", VA = "0x7BBC293B18")]
		public UIHudControlLeaderboardView()
		{
		}

		// Token: 0x0400D4A3 RID: 54435
		[Token(Token = "0x400D4A3")]
		[FieldOffset(Offset = "0x20")]
		public UILabel LeftTitle_1;

		// Token: 0x0400D4A4 RID: 54436
		[Token(Token = "0x400D4A4")]
		[FieldOffset(Offset = "0x28")]
		public UILabel LeftTitle_2;

		// Token: 0x0400D4A5 RID: 54437
		[Token(Token = "0x400D4A5")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LeftTitle_3;

		// Token: 0x0400D4A6 RID: 54438
		[Token(Token = "0x400D4A6")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid ItemListGridMyTeam;

		// Token: 0x0400D4A7 RID: 54439
		[Token(Token = "0x400D4A7")]
		[FieldOffset(Offset = "0x40")]
		public Transform ItemListGridMyTeamTF;

		// Token: 0x0400D4A8 RID: 54440
		[Token(Token = "0x400D4A8")]
		[FieldOffset(Offset = "0x48")]
		public UISprite MyFactionIcon;

		// Token: 0x0400D4A9 RID: 54441
		[Token(Token = "0x400D4A9")]
		[FieldOffset(Offset = "0x50")]
		public UILabel MyFactionName;

		// Token: 0x0400D4AA RID: 54442
		[Token(Token = "0x400D4AA")]
		[FieldOffset(Offset = "0x58")]
		public UILabel RightTitle_1;

		// Token: 0x0400D4AB RID: 54443
		[Token(Token = "0x400D4AB")]
		[FieldOffset(Offset = "0x60")]
		public UILabel RightTitle_2;

		// Token: 0x0400D4AC RID: 54444
		[Token(Token = "0x400D4AC")]
		[FieldOffset(Offset = "0x68")]
		public UILabel RightTitle_3;

		// Token: 0x0400D4AD RID: 54445
		[Token(Token = "0x400D4AD")]
		[FieldOffset(Offset = "0x70")]
		public UIGrid ItemListGridEnemyTeam;

		// Token: 0x0400D4AE RID: 54446
		[Token(Token = "0x400D4AE")]
		[FieldOffset(Offset = "0x78")]
		public Transform ItemListGridEnemyTeamTF;

		// Token: 0x0400D4AF RID: 54447
		[Token(Token = "0x400D4AF")]
		[FieldOffset(Offset = "0x80")]
		public UISprite EnemyFactionIcon;

		// Token: 0x0400D4B0 RID: 54448
		[Token(Token = "0x400D4B0")]
		[FieldOffset(Offset = "0x88")]
		public UILabel EnemyFactionName;

		// Token: 0x0400D4B1 RID: 54449
		[Token(Token = "0x400D4B1")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnClose;
	}
}
