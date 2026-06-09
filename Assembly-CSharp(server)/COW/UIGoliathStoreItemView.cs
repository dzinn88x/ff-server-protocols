using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002245 RID: 8773
	[Token(Token = "0x2002245")]
	public class UIGoliathStoreItemView : UIBaseView
	{
		// Token: 0x0600BF9B RID: 49051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF9B")]
		[Address(RVA = "0x1A8369C", Offset = "0x1A8369C", VA = "0x7BBC28369C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF9C RID: 49052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF9C")]
		[Address(RVA = "0x1A83974", Offset = "0x1A83974", VA = "0x7BBC283974")]
		public UIGoliathStoreItemView()
		{
		}

		// Token: 0x0400D22F RID: 53807
		[Token(Token = "0x400D22F")]
		[FieldOffset(Offset = "0x20")]
		public Transform ItemContainer;

		// Token: 0x0400D230 RID: 53808
		[Token(Token = "0x400D230")]
		[FieldOffset(Offset = "0x28")]
		public GameObject NodeCanBuy;

		// Token: 0x0400D231 RID: 53809
		[Token(Token = "0x400D231")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BtnCanBuyIcon;

		// Token: 0x0400D232 RID: 53810
		[Token(Token = "0x400D232")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnExchange;

		// Token: 0x0400D233 RID: 53811
		[Token(Token = "0x400D233")]
		[FieldOffset(Offset = "0x40")]
		public GameObject BuyBtnEffect;

		// Token: 0x0400D234 RID: 53812
		[Token(Token = "0x400D234")]
		[FieldOffset(Offset = "0x48")]
		public UISprite TokenIcon;

		// Token: 0x0400D235 RID: 53813
		[Token(Token = "0x400D235")]
		[FieldOffset(Offset = "0x50")]
		public UILabel TokenCost;

		// Token: 0x0400D236 RID: 53814
		[Token(Token = "0x400D236")]
		[FieldOffset(Offset = "0x58")]
		public GameObject NodeSoldOut;

		// Token: 0x0400D237 RID: 53815
		[Token(Token = "0x400D237")]
		[FieldOffset(Offset = "0x60")]
		public GameObject NodeOwned;

		// Token: 0x0400D238 RID: 53816
		[Token(Token = "0x400D238")]
		[FieldOffset(Offset = "0x68")]
		public UILabel ExchangeTimes;
	}
}
