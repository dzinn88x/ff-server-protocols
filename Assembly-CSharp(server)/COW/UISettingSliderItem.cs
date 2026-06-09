using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C67 RID: 7271
	[Token(Token = "0x2001C67")]
	public class UISettingSliderItem : MonoBehaviour
	{
		// Token: 0x06009E85 RID: 40581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E85")]
		[Address(RVA = "0x1635B28", Offset = "0x1635B28", VA = "0x7BBBE35B28")]
		private void Start()
		{
		}

		// Token: 0x06009E86 RID: 40582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E86")]
		[Address(RVA = "0x1635C20", Offset = "0x1635C20", VA = "0x7BBBE35C20")]
		private void OnSliderChange()
		{
		}

		// Token: 0x06009E87 RID: 40583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E87")]
		[Address(RVA = "0x1635D4C", Offset = "0x1635D4C", VA = "0x7BBBE35D4C")]
		public void SetSliderValue(float v)
		{
		}

		// Token: 0x06009E88 RID: 40584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E88")]
		[Address(RVA = "0x1635D8C", Offset = "0x1635D8C", VA = "0x7BBBE35D8C")]
		public UISettingSliderItem()
		{
		}

		// Token: 0x0400A4E2 RID: 42210
		[Token(Token = "0x400A4E2")]
		[FieldOffset(Offset = "0x18")]
		public UISlider SettingSlider;

		// Token: 0x0400A4E3 RID: 42211
		[Token(Token = "0x400A4E3")]
		[FieldOffset(Offset = "0x20")]
		public UILabel SettingValue;

		// Token: 0x0400A4E4 RID: 42212
		[Token(Token = "0x400A4E4")]
		[FieldOffset(Offset = "0x28")]
		public Action ImmediatelyApplyCallBack;

		// Token: 0x0400A4E5 RID: 42213
		[Token(Token = "0x400A4E5")]
		[FieldOffset(Offset = "0x30")]
		public Func<float> GetSettingFunc;

		// Token: 0x0400A4E6 RID: 42214
		[Token(Token = "0x400A4E6")]
		[FieldOffset(Offset = "0x38")]
		public Action<float> SetSettingFunc;
	}
}
