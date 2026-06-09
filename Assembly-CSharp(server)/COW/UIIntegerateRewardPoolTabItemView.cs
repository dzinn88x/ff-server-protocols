using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023C8 RID: 9160
	[Token(Token = "0x20023C8")]
	public class UIIntegerateRewardPoolTabItemView : UIBaseView
	{
		// Token: 0x0600C2A0 RID: 49824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2A0")]
		[Address(RVA = "0x1910D9C", Offset = "0x1910D9C", VA = "0x7BBC110D9C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2A1 RID: 49825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2A1")]
		[Address(RVA = "0x1910F74", Offset = "0x1910F74", VA = "0x7BBC110F74")]
		public UIIntegerateRewardPoolTabItemView()
		{
		}

		// Token: 0x0400DEFD RID: 57085
		[Token(Token = "0x400DEFD")]
		[FieldOffset(Offset = "0x20")]
		public UIButton TabBtn;

		// Token: 0x0400DEFE RID: 57086
		[Token(Token = "0x400DEFE")]
		[FieldOffset(Offset = "0x28")]
		public GameObject SpriteLock;

		// Token: 0x0400DEFF RID: 57087
		[Token(Token = "0x400DEFF")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Selected;

		// Token: 0x0400DF00 RID: 57088
		[Token(Token = "0x400DF00")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Sprite;

		// Token: 0x0400DF01 RID: 57089
		[Token(Token = "0x400DF01")]
		[FieldOffset(Offset = "0x40")]
		public UISprite Sprite_inter;

		// Token: 0x0400DF02 RID: 57090
		[Token(Token = "0x400DF02")]
		[FieldOffset(Offset = "0x48")]
		public UILabel PoolName;
	}
}
