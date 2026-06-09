using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024DC RID: 9436
	[Token(Token = "0x20024DC")]
	public class UIRoomCheckSliderTemplateView : UIBaseView
	{
		// Token: 0x0600C4C8 RID: 50376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4C8")]
		[Address(RVA = "0x1E23178", Offset = "0x1E23178", VA = "0x7BBC623178", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4C9 RID: 50377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4C9")]
		[Address(RVA = "0x1E23358", Offset = "0x1E23358", VA = "0x7BBC623358")]
		public UIRoomCheckSliderTemplateView()
		{
		}

		// Token: 0x0400EFED RID: 61421
		[Token(Token = "0x400EFED")]
		[FieldOffset(Offset = "0x20")]
		public UIToggle CheckToggle;

		// Token: 0x0400EFEE RID: 61422
		[Token(Token = "0x400EFEE")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Title;

		// Token: 0x0400EFEF RID: 61423
		[Token(Token = "0x400EFEF")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Value;

		// Token: 0x0400EFF0 RID: 61424
		[Token(Token = "0x400EFF0")]
		[FieldOffset(Offset = "0x38")]
		public UIButton plusBtn;

		// Token: 0x0400EFF1 RID: 61425
		[Token(Token = "0x400EFF1")]
		[FieldOffset(Offset = "0x40")]
		public UISlider slider;

		// Token: 0x0400EFF2 RID: 61426
		[Token(Token = "0x400EFF2")]
		[FieldOffset(Offset = "0x48")]
		public UIButton minusBtn;
	}
}
