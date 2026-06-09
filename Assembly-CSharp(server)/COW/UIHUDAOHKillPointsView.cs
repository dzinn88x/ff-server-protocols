using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200225F RID: 8799
	[Token(Token = "0x200225F")]
	public class UIHUDAOHKillPointsView : UIBaseView
	{
		// Token: 0x0600BFCF RID: 49103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFCF")]
		[Address(RVA = "0x16B0120", Offset = "0x16B0120", VA = "0x7BBBEB0120", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFD0 RID: 49104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFD0")]
		[Address(RVA = "0x16B0240", Offset = "0x16B0240", VA = "0x7BBBEB0240")]
		public UIHUDAOHKillPointsView()
		{
		}

		// Token: 0x0400D35A RID: 54106
		[Token(Token = "0x400D35A")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid PointsGrid;

		// Token: 0x0400D35B RID: 54107
		[Token(Token = "0x400D35B")]
		[FieldOffset(Offset = "0x28")]
		public UIHUDArmsRacePointItem PointItem;

		// Token: 0x0400D35C RID: 54108
		[Token(Token = "0x400D35C")]
		[FieldOffset(Offset = "0x30")]
		public UISprite LevelIcon;
	}
}
