using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002409 RID: 9225
	[Token(Token = "0x2002409")]
	internal class UILoginRegionChooseView : UIBaseView
	{
		// Token: 0x0600C322 RID: 49954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C322")]
		[Address(RVA = "0x19E8A3C", Offset = "0x19E8A3C", VA = "0x7BBC1E8A3C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C323 RID: 49955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C323")]
		[Address(RVA = "0x19E8CA8", Offset = "0x19E8CA8", VA = "0x7BBC1E8CA8")]
		public UILoginRegionChooseView()
		{
		}

		// Token: 0x0400E363 RID: 58211
		[Token(Token = "0x400E363")]
		[FieldOffset(Offset = "0x20")]
		public UILabel TopTips;

		// Token: 0x0400E364 RID: 58212
		[Token(Token = "0x400E364")]
		[FieldOffset(Offset = "0x28")]
		public UIToggle Server1;

		// Token: 0x0400E365 RID: 58213
		[Token(Token = "0x400E365")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Name1;

		// Token: 0x0400E366 RID: 58214
		[Token(Token = "0x400E366")]
		[FieldOffset(Offset = "0x38")]
		public UIToggle Server2;

		// Token: 0x0400E367 RID: 58215
		[Token(Token = "0x400E367")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Name2;

		// Token: 0x0400E368 RID: 58216
		[Token(Token = "0x400E368")]
		[FieldOffset(Offset = "0x48")]
		public UIToggle Server3;

		// Token: 0x0400E369 RID: 58217
		[Token(Token = "0x400E369")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Name3;

		// Token: 0x0400E36A RID: 58218
		[Token(Token = "0x400E36A")]
		[FieldOffset(Offset = "0x58")]
		public UIButton ConfirmBtn;
	}
}
