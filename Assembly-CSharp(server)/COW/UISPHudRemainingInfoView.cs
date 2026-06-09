using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002529 RID: 9513
	[Token(Token = "0x2002529")]
	public class UISPHudRemainingInfoView : UIBaseView
	{
		// Token: 0x0600C562 RID: 50530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C562")]
		[Address(RVA = "0x1EEFC44", Offset = "0x1EEFC44", VA = "0x7BBC6EFC44", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C563 RID: 50531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C563")]
		[Address(RVA = "0x1EF0040", Offset = "0x1EF0040", VA = "0x7BBC6F0040")]
		public UISPHudRemainingInfoView()
		{
		}

		// Token: 0x0400F320 RID: 62240
		[Token(Token = "0x400F320")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SoloPanel;

		// Token: 0x0400F321 RID: 62241
		[Token(Token = "0x400F321")]
		[FieldOffset(Offset = "0x28")]
		public UILabel SGroupMode;

		// Token: 0x0400F322 RID: 62242
		[Token(Token = "0x400F322")]
		[FieldOffset(Offset = "0x30")]
		public GameObject SSafeZoneGo;

		// Token: 0x0400F323 RID: 62243
		[Token(Token = "0x400F323")]
		[FieldOffset(Offset = "0x38")]
		public UILabel SSafeZoneCount;

		// Token: 0x0400F324 RID: 62244
		[Token(Token = "0x400F324")]
		[FieldOffset(Offset = "0x40")]
		public UILabel SAlivePlayerCount;

		// Token: 0x0400F325 RID: 62245
		[Token(Token = "0x400F325")]
		[FieldOffset(Offset = "0x48")]
		public GameObject STime;

		// Token: 0x0400F326 RID: 62246
		[Token(Token = "0x400F326")]
		[FieldOffset(Offset = "0x50")]
		public UILabel STimeLabel;

		// Token: 0x0400F327 RID: 62247
		[Token(Token = "0x400F327")]
		[FieldOffset(Offset = "0x58")]
		public GameObject MultiPanel;

		// Token: 0x0400F328 RID: 62248
		[Token(Token = "0x400F328")]
		[FieldOffset(Offset = "0x60")]
		public UILabel MAlivePlayerCount;

		// Token: 0x0400F329 RID: 62249
		[Token(Token = "0x400F329")]
		[FieldOffset(Offset = "0x68")]
		public GameObject MTeamGo;

		// Token: 0x0400F32A RID: 62250
		[Token(Token = "0x400F32A")]
		[FieldOffset(Offset = "0x70")]
		public UILabel MAliveTeamCount;

		// Token: 0x0400F32B RID: 62251
		[Token(Token = "0x400F32B")]
		[FieldOffset(Offset = "0x78")]
		public GameObject MTime;

		// Token: 0x0400F32C RID: 62252
		[Token(Token = "0x400F32C")]
		[FieldOffset(Offset = "0x80")]
		public UILabel MTimeLabel;

		// Token: 0x0400F32D RID: 62253
		[Token(Token = "0x400F32D")]
		[FieldOffset(Offset = "0x88")]
		public UILabel MGroupMode;

		// Token: 0x0400F32E RID: 62254
		[Token(Token = "0x400F32E")]
		[FieldOffset(Offset = "0x90")]
		public GameObject MSafeZoneGo;

		// Token: 0x0400F32F RID: 62255
		[Token(Token = "0x400F32F")]
		[FieldOffset(Offset = "0x98")]
		public UILabel MSafeZoneCount;
	}
}
