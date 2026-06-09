using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021B6 RID: 8630
	[Token(Token = "0x20021B6")]
	public class UIElitePassIngameHudRankingView : UIBaseView
	{
		// Token: 0x0600BE7C RID: 48764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE7C")]
		[Address(RVA = "0x1AE8704", Offset = "0x1AE8704", VA = "0x7BBC2E8704", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE7D RID: 48765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE7D")]
		[Address(RVA = "0x1AE88A0", Offset = "0x1AE88A0", VA = "0x7BBC2E88A0")]
		public UIElitePassIngameHudRankingView()
		{
		}

		// Token: 0x0400CA2D RID: 51757
		[Token(Token = "0x400CA2D")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel ElitepassPanel;

		// Token: 0x0400CA2E RID: 51758
		[Token(Token = "0x400CA2E")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid Grid;

		// Token: 0x0400CA2F RID: 51759
		[Token(Token = "0x400CA2F")]
		[FieldOffset(Offset = "0x30")]
		public ElitePassIngameRanking Top1Player;

		// Token: 0x0400CA30 RID: 51760
		[Token(Token = "0x400CA30")]
		[FieldOffset(Offset = "0x38")]
		public ElitePassIngameRanking Top2Player;

		// Token: 0x0400CA31 RID: 51761
		[Token(Token = "0x400CA31")]
		[FieldOffset(Offset = "0x40")]
		public ElitePassIngameRanking Top3Player;
	}
}
