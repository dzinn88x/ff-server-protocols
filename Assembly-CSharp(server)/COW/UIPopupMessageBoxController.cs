using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B0D RID: 6925
	[Token(Token = "0x2001B0D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F93B4", Offset = "0x10F93B4")]
	public class UIPopupMessageBoxController : UIPopupSpecialWindowController
	{
		// Token: 0x06009334 RID: 37684 RVA: 0x00027240 File Offset: 0x00025440
		[Token(Token = "0x6009334")]
		[Address(RVA = "0x216C9AC", Offset = "0x216C9AC", VA = "0x7BBC96C9AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009335 RID: 37685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009335")]
		[Address(RVA = "0x216C9FC", Offset = "0x216C9FC", VA = "0x7BBC96C9FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009336 RID: 37686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009336")]
		[Address(RVA = "0x216CB90", Offset = "0x216CB90", VA = "0x7BBC96CB90", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06009337 RID: 37687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009337")]
		[Address(RVA = "0x216CBB8", Offset = "0x216CBB8", VA = "0x7BBC96CBB8")]
		public void ShowStandardMessageBox(string info, UIPopupMessageBoxController.EStandardMessageBoxType mbType, [Optional] Action onOK, [Optional] Action onCancel, UIPopupMessageBoxController.EButtonStyle buttonStyle = UIPopupMessageBoxController.EButtonStyle.OKOnly, bool isColorfulInfo = false, string note = "", [Optional] Transform par)
		{
		}

		// Token: 0x06009338 RID: 37688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009338")]
		[Address(RVA = "0x216DA1C", Offset = "0x216DA1C", VA = "0x7BBC96DA1C")]
		public void ShowMessageBox(string title, string info, UIPopupMessageBoxController.EButtonStyle buttonStyle = UIPopupMessageBoxController.EButtonStyle.OKCancel, [Optional] Action onOK, [Optional] Action onCancel, bool isColorfulInfo = false)
		{
		}

		// Token: 0x06009339 RID: 37689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009339")]
		[Address(RVA = "0x216DD28", Offset = "0x216DD28", VA = "0x7BBC96DD28")]
		public void ShowMessageBox(UIPopupMessageBoxController.MessageBoxInfo info)
		{
		}

		// Token: 0x0600933A RID: 37690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600933A")]
		[Address(RVA = "0x216E024", Offset = "0x216E024", VA = "0x7BBC96E024")]
		public void SetSpeicalOkButton(uint time)
		{
		}

		// Token: 0x0600933B RID: 37691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600933B")]
		[Address(RVA = "0x216E2E4", Offset = "0x216E2E4", VA = "0x7BBC96E2E4")]
		private void Update()
		{
		}

		// Token: 0x0600933C RID: 37692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600933C")]
		[Address(RVA = "0x216E0B4", Offset = "0x216E0B4", VA = "0x7BBC96E0B4")]
		private void UpdateOkButton(uint time)
		{
		}

		// Token: 0x0600933D RID: 37693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600933D")]
		[Address(RVA = "0x216E35C", Offset = "0x216E35C", VA = "0x7BBC96E35C")]
		private void OnBtnOKClick()
		{
		}

		// Token: 0x0600933E RID: 37694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600933E")]
		[Address(RVA = "0x216E3A4", Offset = "0x216E3A4", VA = "0x7BBC96E3A4")]
		protected void OnBtnCancelClick()
		{
		}

		// Token: 0x0600933F RID: 37695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600933F")]
		[Address(RVA = "0x216D6C4", Offset = "0x216D6C4", VA = "0x7BBC96D6C4")]
		protected void UpdateView()
		{
		}

		// Token: 0x06009340 RID: 37696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009340")]
		[Address(RVA = "0x216E3EC", Offset = "0x216E3EC", VA = "0x7BBC96E3EC", Slot = "40")]
		public override void OnBackButtonClick()
		{
		}

		// Token: 0x06009341 RID: 37697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009341")]
		[Address(RVA = "0x216E460", Offset = "0x216E460", VA = "0x7BBC96E460", Slot = "41")]
		public override void OnEnterButtonClick()
		{
		}

		// Token: 0x06009342 RID: 37698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009342")]
		[Address(RVA = "0x216E49C", Offset = "0x216E49C", VA = "0x7BBC96E49C")]
		public void SetPopupMessageInfo(string message)
		{
		}

		// Token: 0x06009343 RID: 37699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009343")]
		[Address(RVA = "0x216E51C", Offset = "0x216E51C", VA = "0x7BBC96E51C", Slot = "21")]
		public override void Show()
		{
		}

		// Token: 0x06009344 RID: 37700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009344")]
		[Address(RVA = "0x216E63C", Offset = "0x216E63C", VA = "0x7BBC96E63C")]
		public UIPopupMessageBoxController()
		{
		}

		// Token: 0x04009D64 RID: 40292
		[Token(Token = "0x4009D64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UIPopupMessageBoxView m_View;

		// Token: 0x04009D65 RID: 40293
		[Token(Token = "0x4009D65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected UIPopupMessageBoxController.EButtonStyle m_ButtonStyle;

		// Token: 0x04009D66 RID: 40294
		[Token(Token = "0x4009D66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool m_NoCloseButton;

		// Token: 0x04009D67 RID: 40295
		[Token(Token = "0x4009D67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected Action m_OnOK;

		// Token: 0x04009D68 RID: 40296
		[Token(Token = "0x4009D68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Action m_OnCancel;

		// Token: 0x04009D69 RID: 40297
		[Token(Token = "0x4009D69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float m_DuraTime;

		// Token: 0x04009D6A RID: 40298
		[Token(Token = "0x4009D6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool m_SepicalUpdateButton;

		// Token: 0x04009D6B RID: 40299
		[Token(Token = "0x4009D6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private uint m_LastTime;

		// Token: 0x02001B0E RID: 6926
		[Token(Token = "0x2001B0E")]
		public enum EButtonStyle
		{
			// Token: 0x04009D6D RID: 40301
			[Token(Token = "0x4009D6D")]
			None,
			// Token: 0x04009D6E RID: 40302
			[Token(Token = "0x4009D6E")]
			OKOnly,
			// Token: 0x04009D6F RID: 40303
			[Token(Token = "0x4009D6F")]
			OKCancel,
			// Token: 0x04009D70 RID: 40304
			[Token(Token = "0x4009D70")]
			OKClose
		}

		// Token: 0x02001B0F RID: 6927
		[Token(Token = "0x2001B0F")]
		public enum EStandardMessageBoxType
		{
			// Token: 0x04009D72 RID: 40306
			[Token(Token = "0x4009D72")]
			Info,
			// Token: 0x04009D73 RID: 40307
			[Token(Token = "0x4009D73")]
			Suggestion,
			// Token: 0x04009D74 RID: 40308
			[Token(Token = "0x4009D74")]
			Warning,
			// Token: 0x04009D75 RID: 40309
			[Token(Token = "0x4009D75")]
			Error,
			// Token: 0x04009D76 RID: 40310
			[Token(Token = "0x4009D76")]
			Hint,
			// Token: 0x04009D77 RID: 40311
			[Token(Token = "0x4009D77")]
			Exception
		}

		// Token: 0x02001B10 RID: 6928
		[Token(Token = "0x2001B10")]
		public class MessageBoxInfo
		{
			// Token: 0x06009345 RID: 37701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009345")]
			[Address(RVA = "0x216E644", Offset = "0x216E644", VA = "0x7BBC96E644")]
			public MessageBoxInfo()
			{
			}

			// Token: 0x04009D78 RID: 40312
			[Token(Token = "0x4009D78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Title;

			// Token: 0x04009D79 RID: 40313
			[Token(Token = "0x4009D79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string Info;

			// Token: 0x04009D7A RID: 40314
			[Token(Token = "0x4009D7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string OKText;

			// Token: 0x04009D7B RID: 40315
			[Token(Token = "0x4009D7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string CancelText;

			// Token: 0x04009D7C RID: 40316
			[Token(Token = "0x4009D7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UIPopupMessageBoxController.EButtonStyle ButtonStyle;

			// Token: 0x04009D7D RID: 40317
			[Token(Token = "0x4009D7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action OnOK;

			// Token: 0x04009D7E RID: 40318
			[Token(Token = "0x4009D7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action OnCancel;

			// Token: 0x04009D7F RID: 40319
			[Token(Token = "0x4009D7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool NoCloseButton;

			// Token: 0x04009D80 RID: 40320
			[Token(Token = "0x4009D80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string note;
		}
	}
}
