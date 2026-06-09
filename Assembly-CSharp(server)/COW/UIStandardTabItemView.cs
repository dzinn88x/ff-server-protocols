using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002553 RID: 9555
	[Token(Token = "0x2002553")]
	public class UIStandardTabItemView : UIBaseView
	{
		// Token: 0x0600C5B6 RID: 50614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5B6")]
		[Address(RVA = "0x21333B4", Offset = "0x21333B4", VA = "0x7BBC9333B4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5B7 RID: 50615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5B7")]
		[Address(RVA = "0x2133794", Offset = "0x2133794", VA = "0x7BBC933794")]
		public UIStandardTabItemView()
		{
		}

		// Token: 0x0400F4D3 RID: 62675
		[Token(Token = "0x400F4D3")]
		[FieldOffset(Offset = "0x20")]
		public UISprite DownArrow;

		// Token: 0x0400F4D4 RID: 62676
		[Token(Token = "0x400F4D4")]
		[FieldOffset(Offset = "0x28")]
		public UISprite UpArrow;

		// Token: 0x0400F4D5 RID: 62677
		[Token(Token = "0x400F4D5")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Select;

		// Token: 0x0400F4D6 RID: 62678
		[Token(Token = "0x400F4D6")]
		[FieldOffset(Offset = "0x38")]
		public UILabel SelectLabel;

		// Token: 0x0400F4D7 RID: 62679
		[Token(Token = "0x400F4D7")]
		[FieldOffset(Offset = "0x40")]
		public UISprite SelectBg;

		// Token: 0x0400F4D8 RID: 62680
		[Token(Token = "0x400F4D8")]
		[FieldOffset(Offset = "0x48")]
		public GameObject UnSelect;

		// Token: 0x0400F4D9 RID: 62681
		[Token(Token = "0x400F4D9")]
		[FieldOffset(Offset = "0x50")]
		public UILabel UnSelectLabel;

		// Token: 0x0400F4DA RID: 62682
		[Token(Token = "0x400F4DA")]
		[FieldOffset(Offset = "0x58")]
		public GameObject UnSelectBg;

		// Token: 0x0400F4DB RID: 62683
		[Token(Token = "0x400F4DB")]
		[FieldOffset(Offset = "0x60")]
		public UITipsButton RedPoint;

		// Token: 0x0400F4DC RID: 62684
		[Token(Token = "0x400F4DC")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Tag;

		// Token: 0x0400F4DD RID: 62685
		[Token(Token = "0x400F4DD")]
		[FieldOffset(Offset = "0x70")]
		public UILabel TagLabel;

		// Token: 0x0400F4DE RID: 62686
		[Token(Token = "0x400F4DE")]
		[FieldOffset(Offset = "0x78")]
		public UISprite TagIconBg;

		// Token: 0x0400F4DF RID: 62687
		[Token(Token = "0x400F4DF")]
		[FieldOffset(Offset = "0x80")]
		public UISprite TagIcon;

		// Token: 0x0400F4E0 RID: 62688
		[Token(Token = "0x400F4E0")]
		[FieldOffset(Offset = "0x88")]
		public UIButton Button;

		// Token: 0x0400F4E1 RID: 62689
		[Token(Token = "0x400F4E1")]
		[FieldOffset(Offset = "0x90")]
		public GameObject DrawerFixRect;
	}
}
