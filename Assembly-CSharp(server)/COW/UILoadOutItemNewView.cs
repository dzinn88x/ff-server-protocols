using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023ED RID: 9197
	[Token(Token = "0x20023ED")]
	internal class UILoadOutItemNewView : UIBaseView
	{
		// Token: 0x0600C2EA RID: 49898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2EA")]
		[Address(RVA = "0x1CC4118", Offset = "0x1CC4118", VA = "0x7BBC4C4118", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2EB RID: 49899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2EB")]
		[Address(RVA = "0x1CC4554", Offset = "0x1CC4554", VA = "0x7BBC4C4554")]
		public UILoadOutItemNewView()
		{
		}

		// Token: 0x0400E106 RID: 57606
		[Token(Token = "0x400E106")]
		[FieldOffset(Offset = "0x20")]
		public BaseItemView BaseInfoView;

		// Token: 0x0400E107 RID: 57607
		[Token(Token = "0x400E107")]
		[FieldOffset(Offset = "0x28")]
		public UIButton itemBtn;

		// Token: 0x0400E108 RID: 57608
		[Token(Token = "0x400E108")]
		[FieldOffset(Offset = "0x30")]
		public UISprite icon;

		// Token: 0x0400E109 RID: 57609
		[Token(Token = "0x400E109")]
		[FieldOffset(Offset = "0x38")]
		public UILabel cnt;

		// Token: 0x0400E10A RID: 57610
		[Token(Token = "0x400E10A")]
		[FieldOffset(Offset = "0x40")]
		public UILabel name;

		// Token: 0x0400E10B RID: 57611
		[Token(Token = "0x400E10B")]
		[FieldOffset(Offset = "0x48")]
		public GameObject HL;

		// Token: 0x0400E10C RID: 57612
		[Token(Token = "0x400E10C")]
		[FieldOffset(Offset = "0x50")]
		public GameObject HLPlayCard;

		// Token: 0x0400E10D RID: 57613
		[Token(Token = "0x400E10D")]
		[FieldOffset(Offset = "0x58")]
		public GameObject line;

		// Token: 0x0400E10E RID: 57614
		[Token(Token = "0x400E10E")]
		[FieldOffset(Offset = "0x60")]
		public UIButton infoBtn;

		// Token: 0x0400E10F RID: 57615
		[Token(Token = "0x400E10F")]
		[FieldOffset(Offset = "0x68")]
		public UIButton BuyBtn;

		// Token: 0x0400E110 RID: 57616
		[Token(Token = "0x400E110")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Price;

		// Token: 0x0400E111 RID: 57617
		[Token(Token = "0x400E111")]
		[FieldOffset(Offset = "0x78")]
		public UIButton DecreaseBtn;

		// Token: 0x0400E112 RID: 57618
		[Token(Token = "0x400E112")]
		[FieldOffset(Offset = "0x80")]
		public UIButton IncreaseBtn;

		// Token: 0x0400E113 RID: 57619
		[Token(Token = "0x400E113")]
		[FieldOffset(Offset = "0x88")]
		public UILabel num;

		// Token: 0x0400E114 RID: 57620
		[Token(Token = "0x400E114")]
		[FieldOffset(Offset = "0x90")]
		public GameObject PlayCardGameObj;

		// Token: 0x0400E115 RID: 57621
		[Token(Token = "0x400E115")]
		[FieldOffset(Offset = "0x98")]
		public UISprite PlayCardIcon;

		// Token: 0x0400E116 RID: 57622
		[Token(Token = "0x400E116")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel Remain;
	}
}
