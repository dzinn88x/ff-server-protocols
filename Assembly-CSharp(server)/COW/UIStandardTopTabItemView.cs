using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002555 RID: 9557
	[Token(Token = "0x2002555")]
	public class UIStandardTopTabItemView : UIBaseView
	{
		// Token: 0x0600C5BA RID: 50618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5BA")]
		[Address(RVA = "0x21350FC", Offset = "0x21350FC", VA = "0x7BBC9350FC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5BB RID: 50619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5BB")]
		[Address(RVA = "0x2135438", Offset = "0x2135438", VA = "0x7BBC935438")]
		public UIStandardTopTabItemView()
		{
		}

		// Token: 0x0400F4E6 RID: 62694
		[Token(Token = "0x400F4E6")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Button;

		// Token: 0x0400F4E7 RID: 62695
		[Token(Token = "0x400F4E7")]
		[FieldOffset(Offset = "0x28")]
		public BoxCollider Collider;

		// Token: 0x0400F4E8 RID: 62696
		[Token(Token = "0x400F4E8")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Select;

		// Token: 0x0400F4E9 RID: 62697
		[Token(Token = "0x400F4E9")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SelectBg;

		// Token: 0x0400F4EA RID: 62698
		[Token(Token = "0x400F4EA")]
		[FieldOffset(Offset = "0x40")]
		public UISprite SelectLine;

		// Token: 0x0400F4EB RID: 62699
		[Token(Token = "0x400F4EB")]
		[FieldOffset(Offset = "0x48")]
		public UILabel SelectLabel;

		// Token: 0x0400F4EC RID: 62700
		[Token(Token = "0x400F4EC")]
		[FieldOffset(Offset = "0x50")]
		public UISprite NewTabIcon;

		// Token: 0x0400F4ED RID: 62701
		[Token(Token = "0x400F4ED")]
		[FieldOffset(Offset = "0x58")]
		public GameObject UnSelect;

		// Token: 0x0400F4EE RID: 62702
		[Token(Token = "0x400F4EE")]
		[FieldOffset(Offset = "0x60")]
		public UISprite UnSelectBg;

		// Token: 0x0400F4EF RID: 62703
		[Token(Token = "0x400F4EF")]
		[FieldOffset(Offset = "0x68")]
		public UILabel UnSelectLabel;

		// Token: 0x0400F4F0 RID: 62704
		[Token(Token = "0x400F4F0")]
		[FieldOffset(Offset = "0x70")]
		public UISprite TabIcon;

		// Token: 0x0400F4F1 RID: 62705
		[Token(Token = "0x400F4F1")]
		[FieldOffset(Offset = "0x78")]
		public UITipsButton RedPoint;
	}
}
