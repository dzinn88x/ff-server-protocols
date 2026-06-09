using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002342 RID: 9026
	[Token(Token = "0x2002342")]
	public class UIHudRangeShopItemView : UIBaseView
	{
		// Token: 0x0600C194 RID: 49556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C194")]
		[Address(RVA = "0x17E82FC", Offset = "0x17E82FC", VA = "0x7BBBFE82FC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C195 RID: 49557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C195")]
		[Address(RVA = "0x17E850C", Offset = "0x17E850C", VA = "0x7BBBFE850C")]
		public UIHudRangeShopItemView()
		{
		}

		// Token: 0x0400DAB5 RID: 55989
		[Token(Token = "0x400DAB5")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400DAB6 RID: 55990
		[Token(Token = "0x400DAB6")]
		[FieldOffset(Offset = "0x28")]
		public GameObject HighlightGO;

		// Token: 0x0400DAB7 RID: 55991
		[Token(Token = "0x400DAB7")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ItemName;

		// Token: 0x0400DAB8 RID: 55992
		[Token(Token = "0x400DAB8")]
		[FieldOffset(Offset = "0x38")]
		public UISprite ItemSprite;

		// Token: 0x0400DAB9 RID: 55993
		[Token(Token = "0x400DAB9")]
		[FieldOffset(Offset = "0x40")]
		public UISprite TokenIcon;

		// Token: 0x0400DABA RID: 55994
		[Token(Token = "0x400DABA")]
		[FieldOffset(Offset = "0x48")]
		public UILabel TokenCost;

		// Token: 0x0400DABB RID: 55995
		[Token(Token = "0x400DABB")]
		[FieldOffset(Offset = "0x50")]
		public UISprite TagNew;
	}
}
