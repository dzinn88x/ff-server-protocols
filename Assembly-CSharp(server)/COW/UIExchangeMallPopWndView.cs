using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021DD RID: 8669
	[Token(Token = "0x20021DD")]
	public class UIExchangeMallPopWndView : UIBaseView
	{
		// Token: 0x0600BECB RID: 48843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BECB")]
		[Address(RVA = "0x2272AB0", Offset = "0x2272AB0", VA = "0x7BBCA72AB0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BECC RID: 48844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BECC")]
		[Address(RVA = "0x2272D54", Offset = "0x2272D54", VA = "0x7BBCA72D54")]
		public UIExchangeMallPopWndView()
		{
		}

		// Token: 0x0400CBE0 RID: 52192
		[Token(Token = "0x400CBE0")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView ScrollView;

		// Token: 0x0400CBE1 RID: 52193
		[Token(Token = "0x400CBE1")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList EasyList;

		// Token: 0x0400CBE2 RID: 52194
		[Token(Token = "0x400CBE2")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LabelLimitedCount;

		// Token: 0x0400CBE3 RID: 52195
		[Token(Token = "0x400CBE3")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnExchange;

		// Token: 0x0400CBE4 RID: 52196
		[Token(Token = "0x400CBE4")]
		[FieldOffset(Offset = "0x40")]
		public UISprite ExchangeBtnBG;

		// Token: 0x0400CBE5 RID: 52197
		[Token(Token = "0x400CBE5")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ExchangePriceLabel;

		// Token: 0x0400CBE6 RID: 52198
		[Token(Token = "0x400CBE6")]
		[FieldOffset(Offset = "0x50")]
		public UISprite ExchangeBuyIcon;

		// Token: 0x0400CBE7 RID: 52199
		[Token(Token = "0x400CBE7")]
		[FieldOffset(Offset = "0x58")]
		public UILabel LabelOwnNum;

		// Token: 0x0400CBE8 RID: 52200
		[Token(Token = "0x400CBE8")]
		[FieldOffset(Offset = "0x60")]
		public UISprite ExchangeIcon;
	}
}
