using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002475 RID: 9333
	[Token(Token = "0x2002475")]
	public class UIPaymentGrowthFundItemView : UIBaseView
	{
		// Token: 0x0600C3FA RID: 50170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3FA")]
		[Address(RVA = "0x1F287B8", Offset = "0x1F287B8", VA = "0x7BBC7287B8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3FB RID: 50171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3FB")]
		[Address(RVA = "0x1F28B14", Offset = "0x1F28B14", VA = "0x7BBC728B14")]
		public UIPaymentGrowthFundItemView()
		{
		}

		// Token: 0x0400EA2F RID: 59951
		[Token(Token = "0x400EA2F")]
		[FieldOffset(Offset = "0x20")]
		public UIDragScrollView DragScrollView;

		// Token: 0x0400EA30 RID: 59952
		[Token(Token = "0x400EA30")]
		[FieldOffset(Offset = "0x28")]
		public UILabel LevelHint;

		// Token: 0x0400EA31 RID: 59953
		[Token(Token = "0x400EA31")]
		[FieldOffset(Offset = "0x30")]
		public UISprite DiamondIcon;

		// Token: 0x0400EA32 RID: 59954
		[Token(Token = "0x400EA32")]
		[FieldOffset(Offset = "0x38")]
		public UILabel RewardLabel;

		// Token: 0x0400EA33 RID: 59955
		[Token(Token = "0x400EA33")]
		[FieldOffset(Offset = "0x40")]
		public UINetworkTextureExt Icon;

		// Token: 0x0400EA34 RID: 59956
		[Token(Token = "0x400EA34")]
		[FieldOffset(Offset = "0x48")]
		public UIButton Purchase;

		// Token: 0x0400EA35 RID: 59957
		[Token(Token = "0x400EA35")]
		[FieldOffset(Offset = "0x50")]
		public GameObject WaitClaim;

		// Token: 0x0400EA36 RID: 59958
		[Token(Token = "0x400EA36")]
		[FieldOffset(Offset = "0x58")]
		public UILabel PurchaseLabel;

		// Token: 0x0400EA37 RID: 59959
		[Token(Token = "0x400EA37")]
		[FieldOffset(Offset = "0x60")]
		public GameObject WaitClaimBG;

		// Token: 0x0400EA38 RID: 59960
		[Token(Token = "0x400EA38")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Lock;

		// Token: 0x0400EA39 RID: 59961
		[Token(Token = "0x400EA39")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Claimed;

		// Token: 0x0400EA3A RID: 59962
		[Token(Token = "0x400EA3A")]
		[FieldOffset(Offset = "0x78")]
		public GameObject LowLevel;
	}
}
