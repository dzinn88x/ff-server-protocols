using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024F1 RID: 9457
	[Token(Token = "0x20024F1")]
	internal class UISecondRechargeRewardItemView : UIBaseView
	{
		// Token: 0x0600C4F2 RID: 50418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4F2")]
		[Address(RVA = "0x162FD9C", Offset = "0x162FD9C", VA = "0x7BBBE2FD9C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4F3 RID: 50419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4F3")]
		[Address(RVA = "0x162FEBC", Offset = "0x162FEBC", VA = "0x7BBBE2FEBC")]
		public UISecondRechargeRewardItemView()
		{
		}

		// Token: 0x0400F0DE RID: 61662
		[Token(Token = "0x400F0DE")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnItem;

		// Token: 0x0400F0DF RID: 61663
		[Token(Token = "0x400F0DF")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Sprite;

		// Token: 0x0400F0E0 RID: 61664
		[Token(Token = "0x400F0E0")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Label;
	}
}
