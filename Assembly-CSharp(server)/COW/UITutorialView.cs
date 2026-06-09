using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200257F RID: 9599
	[Token(Token = "0x200257F")]
	internal class UITutorialView : UIBaseView
	{
		// Token: 0x0600C60E RID: 50702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C60E")]
		[Address(RVA = "0x19FAB10", Offset = "0x19FAB10", VA = "0x7BBC1FAB10", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C60F RID: 50703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C60F")]
		[Address(RVA = "0x19FAD00", Offset = "0x19FAD00", VA = "0x7BBC1FAD00")]
		public UITutorialView()
		{
		}

		// Token: 0x0400F6B5 RID: 63157
		[Token(Token = "0x400F6B5")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400F6B6 RID: 63158
		[Token(Token = "0x400F6B6")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Title;

		// Token: 0x0400F6B7 RID: 63159
		[Token(Token = "0x400F6B7")]
		[FieldOffset(Offset = "0x30")]
		public GameObject GoDots;

		// Token: 0x0400F6B8 RID: 63160
		[Token(Token = "0x400F6B8")]
		[FieldOffset(Offset = "0x38")]
		public Transform TrDots;

		// Token: 0x0400F6B9 RID: 63161
		[Token(Token = "0x400F6B9")]
		[FieldOffset(Offset = "0x40")]
		public GameObject GoWrap;

		// Token: 0x0400F6BA RID: 63162
		[Token(Token = "0x400F6BA")]
		[FieldOffset(Offset = "0x48")]
		public Transform TrWrap;
	}
}
