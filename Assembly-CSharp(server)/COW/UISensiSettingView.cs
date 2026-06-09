using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024F4 RID: 9460
	[Token(Token = "0x20024F4")]
	public class UISensiSettingView : UIBaseView
	{
		// Token: 0x0600C4F8 RID: 50424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4F8")]
		[Address(RVA = "0x1630F1C", Offset = "0x1630F1C", VA = "0x7BBBE30F1C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4F9 RID: 50425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4F9")]
		[Address(RVA = "0x1631160", Offset = "0x1631160", VA = "0x7BBBE31160")]
		public UISensiSettingView()
		{
		}

		// Token: 0x0400F0E9 RID: 61673
		[Token(Token = "0x400F0E9")]
		[FieldOffset(Offset = "0x20")]
		public UIButton QuitBtn1;

		// Token: 0x0400F0EA RID: 61674
		[Token(Token = "0x400F0EA")]
		[FieldOffset(Offset = "0x28")]
		public UISettingSliderItem Setting1xScope;

		// Token: 0x0400F0EB RID: 61675
		[Token(Token = "0x400F0EB")]
		[FieldOffset(Offset = "0x30")]
		public UISettingSliderItem Setting2xScope;

		// Token: 0x0400F0EC RID: 61676
		[Token(Token = "0x400F0EC")]
		[FieldOffset(Offset = "0x38")]
		public UISettingSliderItem Setting4xScope;

		// Token: 0x0400F0ED RID: 61677
		[Token(Token = "0x400F0ED")]
		[FieldOffset(Offset = "0x40")]
		public UISettingSliderItem Setting8xScope;

		// Token: 0x0400F0EE RID: 61678
		[Token(Token = "0x400F0EE")]
		[FieldOffset(Offset = "0x48")]
		public UISettingSliderItem SensitivitySetting;

		// Token: 0x0400F0EF RID: 61679
		[Token(Token = "0x400F0EF")]
		[FieldOffset(Offset = "0x50")]
		public UIButton ResetDefaultBtn;

		// Token: 0x0400F0F0 RID: 61680
		[Token(Token = "0x400F0F0")]
		[FieldOffset(Offset = "0x58")]
		public UISettingSliderItem AuxAimSensitivity;
	}
}
