using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002552 RID: 9554
	[Token(Token = "0x2002552")]
	public class UIStandardSubTabItemView : UIBaseView
	{
		// Token: 0x0600C5B4 RID: 50612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5B4")]
		[Address(RVA = "0x2131170", Offset = "0x2131170", VA = "0x7BBC931170", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5B5 RID: 50613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5B5")]
		[Address(RVA = "0x2131480", Offset = "0x2131480", VA = "0x7BBC931480")]
		public UIStandardSubTabItemView()
		{
		}

		// Token: 0x0400F4C8 RID: 62664
		[Token(Token = "0x400F4C8")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnTab;

		// Token: 0x0400F4C9 RID: 62665
		[Token(Token = "0x400F4C9")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Select;

		// Token: 0x0400F4CA RID: 62666
		[Token(Token = "0x400F4CA")]
		[FieldOffset(Offset = "0x30")]
		public UILabel SelectLabel;

		// Token: 0x0400F4CB RID: 62667
		[Token(Token = "0x400F4CB")]
		[FieldOffset(Offset = "0x38")]
		public GameObject UnSelect;

		// Token: 0x0400F4CC RID: 62668
		[Token(Token = "0x400F4CC")]
		[FieldOffset(Offset = "0x40")]
		public UILabel UnSelectLabel;

		// Token: 0x0400F4CD RID: 62669
		[Token(Token = "0x400F4CD")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Tag;

		// Token: 0x0400F4CE RID: 62670
		[Token(Token = "0x400F4CE")]
		[FieldOffset(Offset = "0x50")]
		public UILabel TagLabel;

		// Token: 0x0400F4CF RID: 62671
		[Token(Token = "0x400F4CF")]
		[FieldOffset(Offset = "0x58")]
		public UISprite TagIconBg;

		// Token: 0x0400F4D0 RID: 62672
		[Token(Token = "0x400F4D0")]
		[FieldOffset(Offset = "0x60")]
		public UISprite TagIcon;

		// Token: 0x0400F4D1 RID: 62673
		[Token(Token = "0x400F4D1")]
		[FieldOffset(Offset = "0x68")]
		public UITipsButton RedPoint;

		// Token: 0x0400F4D2 RID: 62674
		[Token(Token = "0x400F4D2")]
		[FieldOffset(Offset = "0x70")]
		public Transform Lock;
	}
}
