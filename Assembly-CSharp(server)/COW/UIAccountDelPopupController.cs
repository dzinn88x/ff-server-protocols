using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001696 RID: 5782
	[Token(Token = "0x2001696")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F064C", Offset = "0x10F064C")]
	public class UIAccountDelPopupController : UIPopupSpecialWindowController
	{
		// Token: 0x0600692D RID: 26925 RVA: 0x0001DC70 File Offset: 0x0001BE70
		[Token(Token = "0x600692D")]
		[Address(RVA = "0x1A39860", Offset = "0x1A39860", VA = "0x7BBC239860")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600692E RID: 26926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600692E")]
		[Address(RVA = "0x1A398B0", Offset = "0x1A398B0", VA = "0x7BBC2398B0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600692F RID: 26927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600692F")]
		[Address(RVA = "0x1A39AD4", Offset = "0x1A39AD4", VA = "0x7BBC239AD4", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06006930 RID: 26928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006930")]
		[Address(RVA = "0x1A39AFC", Offset = "0x1A39AFC", VA = "0x7BBC239AFC")]
		public void SetUIData(UIAccountDelPopupController.Config config)
		{
		}

		// Token: 0x06006931 RID: 26929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006931")]
		[Address(RVA = "0x1A39E5C", Offset = "0x1A39E5C", VA = "0x7BBC239E5C")]
		private void OnBtnOKClick()
		{
		}

		// Token: 0x06006932 RID: 26930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006932")]
		[Address(RVA = "0x1A3A668", Offset = "0x1A3A668", VA = "0x7BBC23A668")]
		private void OnBtnCancelClick()
		{
		}

		// Token: 0x06006933 RID: 26931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006933")]
		[Address(RVA = "0x1A3A69C", Offset = "0x1A3A69C", VA = "0x7BBC23A69C")]
		private void OnCheckChanged()
		{
		}

		// Token: 0x06006934 RID: 26932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006934")]
		[Address(RVA = "0x1A3A788", Offset = "0x1A3A788", VA = "0x7BBC23A788")]
		private void OnURLClick()
		{
		}

		// Token: 0x06006935 RID: 26933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006935")]
		[Address(RVA = "0x1A3A7DC", Offset = "0x1A3A7DC", VA = "0x7BBC23A7DC", Slot = "40")]
		public override void OnBackButtonClick()
		{
		}

		// Token: 0x06006936 RID: 26934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006936")]
		[Address(RVA = "0x1A3A818", Offset = "0x1A3A818", VA = "0x7BBC23A818")]
		public UIAccountDelPopupController()
		{
		}

		// Token: 0x0400862A RID: 34346
		[Token(Token = "0x400862A")]
		private const string URL = "https://www.garena.sg/privacy";

		// Token: 0x0400862B RID: 34347
		[Token(Token = "0x400862B")]
		[FieldOffset(Offset = "0x98")]
		private UIAccountDelPopupView m_View;

		// Token: 0x0400862C RID: 34348
		[Token(Token = "0x400862C")]
		[FieldOffset(Offset = "0xA0")]
		private Action m_OnOK;

		// Token: 0x0400862D RID: 34349
		[Token(Token = "0x400862D")]
		[FieldOffset(Offset = "0xA8")]
		private Action m_OnCancel;

		// Token: 0x0400862E RID: 34350
		[Token(Token = "0x400862E")]
		[FieldOffset(Offset = "0xB0")]
		private UIAccountDelPopupController.InputStyleOnOk m_InputStyleOnOk;

		// Token: 0x0400862F RID: 34351
		[Token(Token = "0x400862F")]
		[FieldOffset(Offset = "0xB8")]
		private UIAccountDelPopupController.UIStyle m_Style;

		// Token: 0x02001697 RID: 5783
		// (Invoke) Token: 0x06006938 RID: 26936
		[Token(Token = "0x2001697")]
		public delegate bool InputStyleOnOk(string str);

		// Token: 0x02001698 RID: 5784
		[Token(Token = "0x2001698")]
		public enum UIStyle
		{
			// Token: 0x04008631 RID: 34353
			[Token(Token = "0x4008631")]
			EStyleNormal,
			// Token: 0x04008632 RID: 34354
			[Token(Token = "0x4008632")]
			EStyleCheckBox,
			// Token: 0x04008633 RID: 34355
			[Token(Token = "0x4008633")]
			EStyleInput
		}

		// Token: 0x02001699 RID: 5785
		[Token(Token = "0x2001699")]
		public class Config
		{
			// Token: 0x0600693B RID: 26939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600693B")]
			[Address(RVA = "0x1A3A820", Offset = "0x1A3A820", VA = "0x7BBC23A820")]
			public Config()
			{
			}

			// Token: 0x04008634 RID: 34356
			[Token(Token = "0x4008634")]
			[FieldOffset(Offset = "0x10")]
			public string Title;

			// Token: 0x04008635 RID: 34357
			[Token(Token = "0x4008635")]
			[FieldOffset(Offset = "0x18")]
			public string Content;

			// Token: 0x04008636 RID: 34358
			[Token(Token = "0x4008636")]
			[FieldOffset(Offset = "0x20")]
			public string Tips;

			// Token: 0x04008637 RID: 34359
			[Token(Token = "0x4008637")]
			[FieldOffset(Offset = "0x28")]
			public string OKTxt;

			// Token: 0x04008638 RID: 34360
			[Token(Token = "0x4008638")]
			[FieldOffset(Offset = "0x30")]
			public string CancelTxt;

			// Token: 0x04008639 RID: 34361
			[Token(Token = "0x4008639")]
			[FieldOffset(Offset = "0x38")]
			public Action OnOk;

			// Token: 0x0400863A RID: 34362
			[Token(Token = "0x400863A")]
			[FieldOffset(Offset = "0x40")]
			public Action OnCancel;

			// Token: 0x0400863B RID: 34363
			[Token(Token = "0x400863B")]
			[FieldOffset(Offset = "0x48")]
			public UIAccountDelPopupController.InputStyleOnOk InputStyleOnOk;

			// Token: 0x0400863C RID: 34364
			[Token(Token = "0x400863C")]
			[FieldOffset(Offset = "0x50")]
			public bool InitChecked;

			// Token: 0x0400863D RID: 34365
			[Token(Token = "0x400863D")]
			[FieldOffset(Offset = "0x51")]
			public bool HideURL;

			// Token: 0x0400863E RID: 34366
			[Token(Token = "0x400863E")]
			[FieldOffset(Offset = "0x54")]
			public UIAccountDelPopupController.UIStyle Style;
		}
	}
}
