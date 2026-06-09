using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002206 RID: 8710
	[Token(Token = "0x2002206")]
	internal class UIGachaClothSwitchItemView : UIBaseView
	{
		// Token: 0x0600BF1D RID: 48925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF1D")]
		[Address(RVA = "0x21546B8", Offset = "0x21546B8", VA = "0x7BBC9546B8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF1E RID: 48926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF1E")]
		[Address(RVA = "0x21548C8", Offset = "0x21548C8", VA = "0x7BBC9548C8")]
		public UIGachaClothSwitchItemView()
		{
		}

		// Token: 0x0400CE4B RID: 52811
		[Token(Token = "0x400CE4B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BG;

		// Token: 0x0400CE4C RID: 52812
		[Token(Token = "0x400CE4C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject SelectedBG;

		// Token: 0x0400CE4D RID: 52813
		[Token(Token = "0x400CE4D")]
		[FieldOffset(Offset = "0x30")]
		public UIButton ItemBtn;

		// Token: 0x0400CE4E RID: 52814
		[Token(Token = "0x400CE4E")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ItemInfoContainer;

		// Token: 0x0400CE4F RID: 52815
		[Token(Token = "0x400CE4F")]
		[FieldOffset(Offset = "0x40")]
		public BaseItemView BaseInfoView;

		// Token: 0x0400CE50 RID: 52816
		[Token(Token = "0x400CE50")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ObtainedSprite;

		// Token: 0x0400CE51 RID: 52817
		[Token(Token = "0x400CE51")]
		[FieldOffset(Offset = "0x50")]
		public GameObject LimitTimeLabel;
	}
}
