using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200232E RID: 9006
	[Token(Token = "0x200232E")]
	public class UIHudPlayerRemainingInfoView : UIBaseView
	{
		// Token: 0x0600C16C RID: 49516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C16C")]
		[Address(RVA = "0x1D7C994", Offset = "0x1D7C994", VA = "0x7BBC57C994", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C16D RID: 49517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C16D")]
		[Address(RVA = "0x1D7CD14", Offset = "0x1D7CD14", VA = "0x7BBC57CD14")]
		public UIHudPlayerRemainingInfoView()
		{
		}

		// Token: 0x0400DA57 RID: 55895
		[Token(Token = "0x400DA57")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Remaining;

		// Token: 0x0400DA58 RID: 55896
		[Token(Token = "0x400DA58")]
		[FieldOffset(Offset = "0x28")]
		public UILabel RemainLabel;

		// Token: 0x0400DA59 RID: 55897
		[Token(Token = "0x400DA59")]
		[FieldOffset(Offset = "0x30")]
		public UILabel RemainingCountText;

		// Token: 0x0400DA5A RID: 55898
		[Token(Token = "0x400DA5A")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Kill;

		// Token: 0x0400DA5B RID: 55899
		[Token(Token = "0x400DA5B")]
		[FieldOffset(Offset = "0x40")]
		public UILabel KillCountText;

		// Token: 0x0400DA5C RID: 55900
		[Token(Token = "0x400DA5C")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Enemy;

		// Token: 0x0400DA5D RID: 55901
		[Token(Token = "0x400DA5D")]
		[FieldOffset(Offset = "0x50")]
		public UILabel RemainingEnemyCountText;

		// Token: 0x0400DA5E RID: 55902
		[Token(Token = "0x400DA5E")]
		[FieldOffset(Offset = "0x58")]
		public GameObject KDA;

		// Token: 0x0400DA5F RID: 55903
		[Token(Token = "0x400DA5F")]
		[FieldOffset(Offset = "0x60")]
		public UILabel KdaCountText;

		// Token: 0x0400DA60 RID: 55904
		[Token(Token = "0x400DA60")]
		[FieldOffset(Offset = "0x68")]
		public GameObject OnlyAlive;

		// Token: 0x0400DA61 RID: 55905
		[Token(Token = "0x400DA61")]
		[FieldOffset(Offset = "0x70")]
		public UILabel AliveLabel;

		// Token: 0x0400DA62 RID: 55906
		[Token(Token = "0x400DA62")]
		[FieldOffset(Offset = "0x78")]
		public UILabel AliveCount;

		// Token: 0x0400DA63 RID: 55907
		[Token(Token = "0x400DA63")]
		[FieldOffset(Offset = "0x80")]
		public GameObject OnlyKill;

		// Token: 0x0400DA64 RID: 55908
		[Token(Token = "0x400DA64")]
		[FieldOffset(Offset = "0x88")]
		public UILabel killCount;
	}
}
