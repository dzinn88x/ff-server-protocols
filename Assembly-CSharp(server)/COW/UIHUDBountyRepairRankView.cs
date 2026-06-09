using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002287 RID: 8839
	[Token(Token = "0x2002287")]
	public class UIHUDBountyRepairRankView : UIBaseView
	{
		// Token: 0x0600C01F RID: 49183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C01F")]
		[Address(RVA = "0x16B6B30", Offset = "0x16B6B30", VA = "0x7BBBEB6B30", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C020 RID: 49184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C020")]
		[Address(RVA = "0x16B6CBC", Offset = "0x16B6CBC", VA = "0x7BBBEB6CBC")]
		public UIHUDBountyRepairRankView()
		{
		}

		// Token: 0x0400D446 RID: 54342
		[Token(Token = "0x400D446")]
		[FieldOffset(Offset = "0x20")]
		public BountyRepairingItem Rank1;

		// Token: 0x0400D447 RID: 54343
		[Token(Token = "0x400D447")]
		[FieldOffset(Offset = "0x28")]
		public BountyRepairingItem Rank2;

		// Token: 0x0400D448 RID: 54344
		[Token(Token = "0x400D448")]
		[FieldOffset(Offset = "0x30")]
		public BountyRepairingItem Rank3;

		// Token: 0x0400D449 RID: 54345
		[Token(Token = "0x400D449")]
		[FieldOffset(Offset = "0x38")]
		public BountyRepairingItem SelfRank;

		// Token: 0x0400D44A RID: 54346
		[Token(Token = "0x400D44A")]
		[FieldOffset(Offset = "0x40")]
		public GameObject VFX_Bounty_Waiting_RankLock;
	}
}
