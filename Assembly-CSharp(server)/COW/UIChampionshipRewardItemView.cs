using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200213A RID: 8506
	[Token(Token = "0x200213A")]
	internal class UIChampionshipRewardItemView : UIBaseView
	{
		// Token: 0x0600BD84 RID: 48516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD84")]
		[Address(RVA = "0x1ECBDF8", Offset = "0x1ECBDF8", VA = "0x7BBC6CBDF8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD85 RID: 48517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD85")]
		[Address(RVA = "0x1ECBF18", Offset = "0x1ECBF18", VA = "0x7BBC6CBF18")]
		public UIChampionshipRewardItemView()
		{
		}

		// Token: 0x0400C3C2 RID: 50114
		[Token(Token = "0x400C3C2")]
		[FieldOffset(Offset = "0x20")]
		public BaseItemView Reward;

		// Token: 0x0400C3C3 RID: 50115
		[Token(Token = "0x400C3C3")]
		[FieldOffset(Offset = "0x28")]
		public UIButton RewardBtn;

		// Token: 0x0400C3C4 RID: 50116
		[Token(Token = "0x400C3C4")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ItemContainer;
	}
}
