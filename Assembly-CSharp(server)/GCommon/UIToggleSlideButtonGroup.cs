using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001046 RID: 4166
	[Token(Token = "0x2001046")]
	public class UIToggleSlideButtonGroup : MonoBehaviour
	{
		// Token: 0x06003F84 RID: 16260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F84")]
		[Address(RVA = "0x223927C", Offset = "0x223927C", VA = "0x7BBCA3927C")]
		private void Awake()
		{
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F85")]
		[Address(RVA = "0x22395A0", Offset = "0x22395A0", VA = "0x7BBCA395A0")]
		public void SetDefaultBtn(UIToggleButton selectButton)
		{
		}

		// Token: 0x06003F86 RID: 16262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F86")]
		[Address(RVA = "0x2239920", Offset = "0x2239920", VA = "0x7BBCA39920")]
		public void PlayTween(bool forward)
		{
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F87")]
		[Address(RVA = "0x2239450", Offset = "0x2239450", VA = "0x7BBCA39450")]
		public void OnSelectButton(UIToggleButton selectedButton)
		{
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F88")]
		[Address(RVA = "0x223A490", Offset = "0x223A490", VA = "0x7BBCA3A490")]
		public void RefreshButtonStates()
		{
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F89")]
		[Address(RVA = "0x223A4D8", Offset = "0x223A4D8", VA = "0x7BBCA3A4D8")]
		public UIToggleSlideButtonGroup()
		{
		}

		// Token: 0x04004F7E RID: 20350
		[Token(Token = "0x4004F7E")]
		[FieldOffset(Offset = "0x18")]
		public UIToggleButton FirstButton;

		// Token: 0x04004F7F RID: 20351
		[Token(Token = "0x4004F7F")]
		[FieldOffset(Offset = "0x20")]
		public UIToggleButton SecondButton;

		// Token: 0x04004F80 RID: 20352
		[Token(Token = "0x4004F80")]
		[FieldOffset(Offset = "0x28")]
		public UIToggleButton DefaultClickBtn;

		// Token: 0x04004F81 RID: 20353
		[Token(Token = "0x4004F81")]
		[FieldOffset(Offset = "0x30")]
		public TweenPosition Slider;

		// Token: 0x04004F82 RID: 20354
		[Token(Token = "0x4004F82")]
		[FieldOffset(Offset = "0x38")]
		public UIToggleSlideButtonGroup.OnItemSelect OnItemSelectCallback;

		// Token: 0x04004F83 RID: 20355
		[Token(Token = "0x4004F83")]
		[FieldOffset(Offset = "0x40")]
		public UIToggleSlideButtonGroup.OnItemSelect OnItemUnSelectCallback;

		// Token: 0x04004F84 RID: 20356
		[Token(Token = "0x4004F84")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 m_FirstPos;

		// Token: 0x04004F85 RID: 20357
		[Token(Token = "0x4004F85")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 m_SecondPos;

		// Token: 0x04004F86 RID: 20358
		[Token(Token = "0x4004F86")]
		[FieldOffset(Offset = "0x60")]
		private TweenColor m_TweenColorFirstLabel;

		// Token: 0x04004F87 RID: 20359
		[Token(Token = "0x4004F87")]
		[FieldOffset(Offset = "0x68")]
		private TweenColor m_TweenColorSecondLabel;

		// Token: 0x04004F88 RID: 20360
		[Token(Token = "0x4004F88")]
		[FieldOffset(Offset = "0x0")]
		private static Color LabelEnable;

		// Token: 0x04004F89 RID: 20361
		[Token(Token = "0x4004F89")]
		[FieldOffset(Offset = "0x10")]
		private static Color LabelDisable;

		// Token: 0x02001047 RID: 4167
		// (Invoke) Token: 0x06003F8C RID: 16268
		[Token(Token = "0x2001047")]
		public delegate void OnItemSelect(UIToggleButton selectButton);

		// Token: 0x02001048 RID: 4168
		// (Invoke) Token: 0x06003F90 RID: 16272
		[Token(Token = "0x2001048")]
		public delegate void OnItemUnSelect(UIToggleButton selectButton);
	}
}
