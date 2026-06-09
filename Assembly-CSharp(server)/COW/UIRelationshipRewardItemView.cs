using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024D4 RID: 9428
	[Token(Token = "0x20024D4")]
	public class UIRelationshipRewardItemView : UIBaseView
	{
		// Token: 0x0600C4B8 RID: 50360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B8")]
		[Address(RVA = "0x1E1FA84", Offset = "0x1E1FA84", VA = "0x7BBC61FA84", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4B9 RID: 50361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B9")]
		[Address(RVA = "0x1E1FC8C", Offset = "0x1E1FC8C", VA = "0x7BBC61FC8C")]
		public UIRelationshipRewardItemView()
		{
		}

		// Token: 0x0400EFCF RID: 61391
		[Token(Token = "0x400EFCF")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Cloth;

		// Token: 0x0400EFD0 RID: 61392
		[Token(Token = "0x400EFD0")]
		[FieldOffset(Offset = "0x28")]
		public GameObject RewardLockState;

		// Token: 0x0400EFD1 RID: 61393
		[Token(Token = "0x400EFD1")]
		[FieldOffset(Offset = "0x30")]
		public GameObject RewardReceiveState;

		// Token: 0x0400EFD2 RID: 61394
		[Token(Token = "0x400EFD2")]
		[FieldOffset(Offset = "0x38")]
		public GameObject RewardCanReceiveState;

		// Token: 0x0400EFD3 RID: 61395
		[Token(Token = "0x400EFD3")]
		[FieldOffset(Offset = "0x40")]
		public UIButton GainRewardBtn;

		// Token: 0x0400EFD4 RID: 61396
		[Token(Token = "0x400EFD4")]
		[FieldOffset(Offset = "0x48")]
		public UILabel NeedRankLabel;

		// Token: 0x0400EFD5 RID: 61397
		[Token(Token = "0x400EFD5")]
		[FieldOffset(Offset = "0x50")]
		public GameObject unlockStateBg;
	}
}
