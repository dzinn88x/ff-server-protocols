using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021C3 RID: 8643
	[Token(Token = "0x20021C3")]
	internal class UIElitePassWaitingRoomRankingView : UIBaseView
	{
		// Token: 0x0600BE96 RID: 48790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE96")]
		[Address(RVA = "0x1E73688", Offset = "0x1E73688", VA = "0x7BBC673688", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE97 RID: 48791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE97")]
		[Address(RVA = "0x1E73858", Offset = "0x1E73858", VA = "0x7BBC673858")]
		public UIElitePassWaitingRoomRankingView()
		{
		}

		// Token: 0x0400CAF0 RID: 51952
		[Token(Token = "0x400CAF0")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid Grid;

		// Token: 0x0400CAF1 RID: 51953
		[Token(Token = "0x400CAF1")]
		[FieldOffset(Offset = "0x28")]
		public ElitePassIngameRanking Top1Player;

		// Token: 0x0400CAF2 RID: 51954
		[Token(Token = "0x400CAF2")]
		[FieldOffset(Offset = "0x30")]
		public ElitePassIngameRanking Top2Player;

		// Token: 0x0400CAF3 RID: 51955
		[Token(Token = "0x400CAF3")]
		[FieldOffset(Offset = "0x38")]
		public ElitePassIngameRanking Top3Player;

		// Token: 0x0400CAF4 RID: 51956
		[Token(Token = "0x400CAF4")]
		[FieldOffset(Offset = "0x40")]
		public ElitePassIngameRanking MePlayer;

		// Token: 0x0400CAF5 RID: 51957
		[Token(Token = "0x400CAF5")]
		[FieldOffset(Offset = "0x48")]
		public UITexture AvatarTexture;
	}
}
