using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B09 RID: 6921
	[Token(Token = "0x2001B09")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F937C", Offset = "0x10F937C")]
	public class UIPopupMessageBox2Controller : UIPopupWindowController
	{
		// Token: 0x06009327 RID: 37671 RVA: 0x00027228 File Offset: 0x00025428
		[Token(Token = "0x6009327")]
		[Address(RVA = "0x20EFFD0", Offset = "0x20EFFD0", VA = "0x7BBC8EFFD0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009328 RID: 37672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009328")]
		[Address(RVA = "0x20F0020", Offset = "0x20F0020", VA = "0x7BBC8F0020", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009329 RID: 37673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009329")]
		[Address(RVA = "0x20F01B4", Offset = "0x20F01B4", VA = "0x7BBC8F01B4", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600932A RID: 37674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600932A")]
		[Address(RVA = "0x20F01DC", Offset = "0x20F01DC", VA = "0x7BBC8F01DC")]
		public void ShowStandardMessageBox(string info, UIPopupMessageBox2Controller.EStandardMessageBoxType mbType, [Optional] Action onOK, [Optional] Action onCancel, UIPopupMessageBox2Controller.EButtonStyle buttonStyle = UIPopupMessageBox2Controller.EButtonStyle.OKOnly, bool isColorfulInfo = false, string note = "")
		{
		}

		// Token: 0x0600932B RID: 37675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600932B")]
		[Address(RVA = "0x20F0B48", Offset = "0x20F0B48", VA = "0x7BBC8F0B48")]
		public void ShowMessageBox(string title, string info, UIPopupMessageBox2Controller.EButtonStyle buttonStyle = UIPopupMessageBox2Controller.EButtonStyle.OKCancel, [Optional] Action onOK, [Optional] Action onCancel, bool isColorfulInfo = false)
		{
		}

		// Token: 0x0600932C RID: 37676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600932C")]
		[Address(RVA = "0x20F0E54", Offset = "0x20F0E54", VA = "0x7BBC8F0E54")]
		public void ShowMessageBox(UIPopupMessageBox2Controller.MessageBoxInfo info)
		{
		}

		// Token: 0x0600932D RID: 37677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600932D")]
		[Address(RVA = "0x20F1150", Offset = "0x20F1150", VA = "0x7BBC8F1150")]
		private void OnBtnOKClick()
		{
		}

		// Token: 0x0600932E RID: 37678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600932E")]
		[Address(RVA = "0x20F1198", Offset = "0x20F1198", VA = "0x7BBC8F1198")]
		protected void OnBtnCancelClick()
		{
		}

		// Token: 0x0600932F RID: 37679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600932F")]
		[Address(RVA = "0x20F07F0", Offset = "0x20F07F0", VA = "0x7BBC8F07F0")]
		protected void UpdateView()
		{
		}

		// Token: 0x06009330 RID: 37680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009330")]
		[Address(RVA = "0x20F11E0", Offset = "0x20F11E0", VA = "0x7BBC8F11E0")]
		public void SetPopupMessageInfo(string message)
		{
		}

		// Token: 0x06009331 RID: 37681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009331")]
		[Address(RVA = "0x20F1260", Offset = "0x20F1260", VA = "0x7BBC8F1260", Slot = "21")]
		public override void Show()
		{
		}

		// Token: 0x06009332 RID: 37682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009332")]
		[Address(RVA = "0x20F1380", Offset = "0x20F1380", VA = "0x7BBC8F1380")]
		public UIPopupMessageBox2Controller()
		{
		}

		// Token: 0x04009D4B RID: 40267
		[Token(Token = "0x4009D4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UIPopupMessageBoxView m_View;

		// Token: 0x04009D4C RID: 40268
		[Token(Token = "0x4009D4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected UIPopupMessageBox2Controller.EButtonStyle m_ButtonStyle;

		// Token: 0x04009D4D RID: 40269
		[Token(Token = "0x4009D4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool m_NoCloseButton;

		// Token: 0x04009D4E RID: 40270
		[Token(Token = "0x4009D4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected Action m_OnOK;

		// Token: 0x04009D4F RID: 40271
		[Token(Token = "0x4009D4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Action m_OnCancel;

		// Token: 0x02001B0A RID: 6922
		[Token(Token = "0x2001B0A")]
		public enum EButtonStyle
		{
			// Token: 0x04009D51 RID: 40273
			[Token(Token = "0x4009D51")]
			None,
			// Token: 0x04009D52 RID: 40274
			[Token(Token = "0x4009D52")]
			OKOnly,
			// Token: 0x04009D53 RID: 40275
			[Token(Token = "0x4009D53")]
			OKCancel,
			// Token: 0x04009D54 RID: 40276
			[Token(Token = "0x4009D54")]
			OKClose
		}

		// Token: 0x02001B0B RID: 6923
		[Token(Token = "0x2001B0B")]
		public enum EStandardMessageBoxType
		{
			// Token: 0x04009D56 RID: 40278
			[Token(Token = "0x4009D56")]
			Info,
			// Token: 0x04009D57 RID: 40279
			[Token(Token = "0x4009D57")]
			Suggestion,
			// Token: 0x04009D58 RID: 40280
			[Token(Token = "0x4009D58")]
			Warning,
			// Token: 0x04009D59 RID: 40281
			[Token(Token = "0x4009D59")]
			Error,
			// Token: 0x04009D5A RID: 40282
			[Token(Token = "0x4009D5A")]
			Hint
		}

		// Token: 0x02001B0C RID: 6924
		[Token(Token = "0x2001B0C")]
		public class MessageBoxInfo
		{
			// Token: 0x06009333 RID: 37683 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009333")]
			[Address(RVA = "0x216C94C", Offset = "0x216C94C", VA = "0x7BBC96C94C")]
			public MessageBoxInfo()
			{
			}

			// Token: 0x04009D5B RID: 40283
			[Token(Token = "0x4009D5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Title;

			// Token: 0x04009D5C RID: 40284
			[Token(Token = "0x4009D5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string Info;

			// Token: 0x04009D5D RID: 40285
			[Token(Token = "0x4009D5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string OKText;

			// Token: 0x04009D5E RID: 40286
			[Token(Token = "0x4009D5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string CancelText;

			// Token: 0x04009D5F RID: 40287
			[Token(Token = "0x4009D5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UIPopupMessageBox2Controller.EButtonStyle ButtonStyle;

			// Token: 0x04009D60 RID: 40288
			[Token(Token = "0x4009D60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action OnOK;

			// Token: 0x04009D61 RID: 40289
			[Token(Token = "0x4009D61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action OnCancel;

			// Token: 0x04009D62 RID: 40290
			[Token(Token = "0x4009D62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool NoCloseButton;

			// Token: 0x04009D63 RID: 40291
			[Token(Token = "0x4009D63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string note;
		}
	}
}
