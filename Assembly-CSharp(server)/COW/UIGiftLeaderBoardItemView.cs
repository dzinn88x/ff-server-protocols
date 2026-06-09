using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002239 RID: 8761
	[Token(Token = "0x2002239")]
	internal class UIGiftLeaderBoardItemView : UIBaseView
	{
		// Token: 0x0600BF83 RID: 49027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF83")]
		[Address(RVA = "0x2010CAC", Offset = "0x2010CAC", VA = "0x7BBC810CAC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF84 RID: 49028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF84")]
		[Address(RVA = "0x2010F28", Offset = "0x2010F28", VA = "0x7BBC810F28")]
		public UIGiftLeaderBoardItemView()
		{
		}

		// Token: 0x0400D173 RID: 53619
		[Token(Token = "0x400D173")]
		[FieldOffset(Offset = "0x20")]
		public UIButton itembtn;

		// Token: 0x0400D174 RID: 53620
		[Token(Token = "0x400D174")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Rank;

		// Token: 0x0400D175 RID: 53621
		[Token(Token = "0x400D175")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Rank_self;

		// Token: 0x0400D176 RID: 53622
		[Token(Token = "0x400D176")]
		[FieldOffset(Offset = "0x38")]
		public UISprite CupIcon;

		// Token: 0x0400D177 RID: 53623
		[Token(Token = "0x400D177")]
		[FieldOffset(Offset = "0x40")]
		public GameObject BaseProfile;

		// Token: 0x0400D178 RID: 53624
		[Token(Token = "0x400D178")]
		[FieldOffset(Offset = "0x48")]
		public UILabel Count;

		// Token: 0x0400D179 RID: 53625
		[Token(Token = "0x400D179")]
		[FieldOffset(Offset = "0x50")]
		public UISprite BgTop;

		// Token: 0x0400D17A RID: 53626
		[Token(Token = "0x400D17A")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BelowBGTop;

		// Token: 0x0400D17B RID: 53627
		[Token(Token = "0x400D17B")]
		[FieldOffset(Offset = "0x60")]
		public UISprite BgOther;
	}
}
