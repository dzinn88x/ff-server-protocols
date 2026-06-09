using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022FD RID: 8957
	[Token(Token = "0x20022FD")]
	internal class UIHudLeaderboardView : UIBaseView
	{
		// Token: 0x0600C10A RID: 49418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C10A")]
		[Address(RVA = "0x15BAB7C", Offset = "0x15BAB7C", VA = "0x7BBBDBAB7C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C10B RID: 49419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C10B")]
		[Address(RVA = "0x15BAE18", Offset = "0x15BAE18", VA = "0x7BBBDBAE18")]
		public UIHudLeaderboardView()
		{
		}

		// Token: 0x0400D82C RID: 55340
		[Token(Token = "0x400D82C")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid ItemListGridMyTeam;

		// Token: 0x0400D82D RID: 55341
		[Token(Token = "0x400D82D")]
		[FieldOffset(Offset = "0x28")]
		public Transform ItemListGridMyTeamTF;

		// Token: 0x0400D82E RID: 55342
		[Token(Token = "0x400D82E")]
		[FieldOffset(Offset = "0x30")]
		public UISprite MyFactionIcon;

		// Token: 0x0400D82F RID: 55343
		[Token(Token = "0x400D82F")]
		[FieldOffset(Offset = "0x38")]
		public UILabel MyFactionName;

		// Token: 0x0400D830 RID: 55344
		[Token(Token = "0x400D830")]
		[FieldOffset(Offset = "0x40")]
		public UIGrid ItemListGridEnemyTeam;

		// Token: 0x0400D831 RID: 55345
		[Token(Token = "0x400D831")]
		[FieldOffset(Offset = "0x48")]
		public Transform ItemListGridEnemyTeamTF;

		// Token: 0x0400D832 RID: 55346
		[Token(Token = "0x400D832")]
		[FieldOffset(Offset = "0x50")]
		public UISprite EnemyFactionIcon;

		// Token: 0x0400D833 RID: 55347
		[Token(Token = "0x400D833")]
		[FieldOffset(Offset = "0x58")]
		public UILabel EnemyFactionName;

		// Token: 0x0400D834 RID: 55348
		[Token(Token = "0x400D834")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnClose;
	}
}
