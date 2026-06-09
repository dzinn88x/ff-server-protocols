using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B5E RID: 7006
	[Token(Token = "0x2001B5E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9DFC", Offset = "0x10F9DFC")]
	public class UIRoomCheckSliderTemplateController : UIBaseController
	{
		// Token: 0x0600969A RID: 38554 RVA: 0x00027CF0 File Offset: 0x00025EF0
		[Token(Token = "0x600969A")]
		[Address(RVA = "0x1E227E4", Offset = "0x1E227E4", VA = "0x7BBC6227E4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600969B RID: 38555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600969B")]
		[Address(RVA = "0x1E22834", Offset = "0x1E22834", VA = "0x7BBC622834", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600969C RID: 38556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600969C")]
		[Address(RVA = "0x1E22A20", Offset = "0x1E22A20", VA = "0x7BBC622A20", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x0600969D RID: 38557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600969D")]
		[Address(RVA = "0x1E22A48", Offset = "0x1E22A48", VA = "0x7BBC622A48")]
		public void SetSlider(string key, int max, int min, int interval, int def, bool toggleVal, bool showToggle = true)
		{
		}

		// Token: 0x0600969E RID: 38558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600969E")]
		[Address(RVA = "0x1E22CBC", Offset = "0x1E22CBC", VA = "0x7BBC622CBC")]
		public void SetCallBack(Action<int> sliderCB, Action<bool> toggleCB)
		{
		}

		// Token: 0x0600969F RID: 38559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600969F")]
		[Address(RVA = "0x1E22CC4", Offset = "0x1E22CC4", VA = "0x7BBC622CC4")]
		public void ResetCallBack()
		{
		}

		// Token: 0x060096A0 RID: 38560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096A0")]
		[Address(RVA = "0x1E22CCC", Offset = "0x1E22CCC", VA = "0x7BBC622CCC")]
		private void OnToggleChanged()
		{
		}

		// Token: 0x060096A1 RID: 38561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096A1")]
		[Address(RVA = "0x1E22D60", Offset = "0x1E22D60", VA = "0x7BBC622D60")]
		private void OnSliderChanged()
		{
		}

		// Token: 0x060096A2 RID: 38562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096A2")]
		[Address(RVA = "0x1E22EA8", Offset = "0x1E22EA8", VA = "0x7BBC622EA8")]
		private void OnPlusClick()
		{
		}

		// Token: 0x060096A3 RID: 38563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096A3")]
		[Address(RVA = "0x1E23000", Offset = "0x1E23000", VA = "0x7BBC623000")]
		private void OnMinusClick()
		{
		}

		// Token: 0x060096A4 RID: 38564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096A4")]
		[Address(RVA = "0x1E2315C", Offset = "0x1E2315C", VA = "0x7BBC62315C")]
		public UIRoomCheckSliderTemplateController()
		{
		}

		// Token: 0x04009F1C RID: 40732
		[Token(Token = "0x4009F1C")]
		[FieldOffset(Offset = "0x58")]
		private UIRoomCheckSliderTemplateView m_View;

		// Token: 0x04009F1D RID: 40733
		[Token(Token = "0x4009F1D")]
		[FieldOffset(Offset = "0x60")]
		private int m_MinValue;

		// Token: 0x04009F1E RID: 40734
		[Token(Token = "0x4009F1E")]
		[FieldOffset(Offset = "0x64")]
		private int m_MaxValue;

		// Token: 0x04009F1F RID: 40735
		[Token(Token = "0x4009F1F")]
		[FieldOffset(Offset = "0x68")]
		private int m_Interval;

		// Token: 0x04009F20 RID: 40736
		[Token(Token = "0x4009F20")]
		[FieldOffset(Offset = "0x6C")]
		private int m_CurValue;

		// Token: 0x04009F21 RID: 40737
		[Token(Token = "0x4009F21")]
		[FieldOffset(Offset = "0x70")]
		private Action<int> m_SliderCB;

		// Token: 0x04009F22 RID: 40738
		[Token(Token = "0x4009F22")]
		[FieldOffset(Offset = "0x78")]
		private Action<bool> m_ToggeleCB;
	}
}
