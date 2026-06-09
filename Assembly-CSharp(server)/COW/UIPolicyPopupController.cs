using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AFC RID: 6908
	[Token(Token = "0x2001AFC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F910C", Offset = "0x10F910C")]
	public class UIPolicyPopupController : UIPopupSpecialWindowController
	{
		// Token: 0x060092D0 RID: 37584 RVA: 0x00027120 File Offset: 0x00025320
		[Token(Token = "0x60092D0")]
		[Address(RVA = "0x20E8190", Offset = "0x20E8190", VA = "0x7BBC8E8190")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060092D1 RID: 37585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092D1")]
		[Address(RVA = "0x20E81E0", Offset = "0x20E81E0", VA = "0x7BBC8E81E0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060092D2 RID: 37586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092D2")]
		[Address(RVA = "0x20E8404", Offset = "0x20E8404", VA = "0x7BBC8E8404", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060092D3 RID: 37587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092D3")]
		[Address(RVA = "0x20E842C", Offset = "0x20E842C", VA = "0x7BBC8E842C")]
		public void SetUIData(UIPolicyPopupController.Config config)
		{
		}

		// Token: 0x060092D4 RID: 37588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092D4")]
		[Address(RVA = "0x20E85F8", Offset = "0x20E85F8", VA = "0x7BBC8E85F8")]
		public void SetUIData(string title = "", string content = "", string tips = "", string okTxt = "", string cancelTxt = "", [Optional] Action okCallback, [Optional] Action cancelCallback)
		{
		}

		// Token: 0x060092D5 RID: 37589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092D5")]
		[Address(RVA = "0x20E8744", Offset = "0x20E8744", VA = "0x7BBC8E8744")]
		private void OnBtnOKClick()
		{
		}

		// Token: 0x060092D6 RID: 37590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092D6")]
		[Address(RVA = "0x20E877C", Offset = "0x20E877C", VA = "0x7BBC8E877C")]
		private void OnBtnCancelClick()
		{
		}

		// Token: 0x060092D7 RID: 37591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092D7")]
		[Address(RVA = "0x20E87B4", Offset = "0x20E87B4", VA = "0x7BBC8E87B4")]
		private void OnCheckChanged()
		{
		}

		// Token: 0x060092D8 RID: 37592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092D8")]
		[Address(RVA = "0x20E88A0", Offset = "0x20E88A0", VA = "0x7BBC8E88A0")]
		private void OnURLClick()
		{
		}

		// Token: 0x060092D9 RID: 37593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092D9")]
		[Address(RVA = "0x20E88F4", Offset = "0x20E88F4", VA = "0x7BBC8E88F4", Slot = "40")]
		public override void OnBackButtonClick()
		{
		}

		// Token: 0x060092DA RID: 37594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092DA")]
		[Address(RVA = "0x20E8930", Offset = "0x20E8930", VA = "0x7BBC8E8930")]
		public UIPolicyPopupController()
		{
		}

		// Token: 0x04009D19 RID: 40217
		[Token(Token = "0x4009D19")]
		private const string URL = "https://www.garena.sg/privacy";

		// Token: 0x04009D1A RID: 40218
		[Token(Token = "0x4009D1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UIPolicyPopupView m_View;

		// Token: 0x04009D1B RID: 40219
		[Token(Token = "0x4009D1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Action m_OnOK;

		// Token: 0x04009D1C RID: 40220
		[Token(Token = "0x4009D1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Action m_OnCancel;

		// Token: 0x02001AFD RID: 6909
		[Token(Token = "0x2001AFD")]
		public class Config
		{
			// Token: 0x060092DB RID: 37595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60092DB")]
			[Address(RVA = "0x20E8938", Offset = "0x20E8938", VA = "0x7BBC8E8938")]
			public Config()
			{
			}

			// Token: 0x04009D1D RID: 40221
			[Token(Token = "0x4009D1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Title;

			// Token: 0x04009D1E RID: 40222
			[Token(Token = "0x4009D1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string Content;

			// Token: 0x04009D1F RID: 40223
			[Token(Token = "0x4009D1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string Tips;

			// Token: 0x04009D20 RID: 40224
			[Token(Token = "0x4009D20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string OKTxt;

			// Token: 0x04009D21 RID: 40225
			[Token(Token = "0x4009D21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string CancelTxt;

			// Token: 0x04009D22 RID: 40226
			[Token(Token = "0x4009D22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action OnOk;

			// Token: 0x04009D23 RID: 40227
			[Token(Token = "0x4009D23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action OnCancel;

			// Token: 0x04009D24 RID: 40228
			[Token(Token = "0x4009D24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool InitChecked;

			// Token: 0x04009D25 RID: 40229
			[Token(Token = "0x4009D25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool URLHide;
		}
	}
}
