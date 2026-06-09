using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001765 RID: 5989
	[Token(Token = "0x2001765")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1FBC", Offset = "0x10F1FBC")]
	public class UICommonTinyMsgBoxController : UIPopupWindowController
	{
		// Token: 0x060070FB RID: 28923 RVA: 0x0001F968 File Offset: 0x0001DB68
		[Token(Token = "0x60070FB")]
		[Address(RVA = "0x1815148", Offset = "0x1815148", VA = "0x7BBC015148")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060070FC RID: 28924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070FC")]
		[Address(RVA = "0x1815198", Offset = "0x1815198", VA = "0x7BBC015198", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060070FD RID: 28925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070FD")]
		[Address(RVA = "0x18152D4", Offset = "0x18152D4", VA = "0x7BBC0152D4", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060070FE RID: 28926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070FE")]
		[Address(RVA = "0x1815310", Offset = "0x1815310", VA = "0x7BBC015310")]
		public void SetUIData(UICommonTinyMsgBoxController.Config config)
		{
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070FF")]
		[Address(RVA = "0x181550C", Offset = "0x181550C", VA = "0x7BBC01550C")]
		private void SetUIStyle(UICommonTinyMsgBoxController.EUIStyle style)
		{
		}

		// Token: 0x06007100 RID: 28928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007100")]
		[Address(RVA = "0x1815A38", Offset = "0x1815A38", VA = "0x7BBC015A38")]
		private void OnBtnOKClick()
		{
		}

		// Token: 0x06007101 RID: 28929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007101")]
		[Address(RVA = "0x1815A6C", Offset = "0x1815A6C", VA = "0x7BBC015A6C")]
		private void OnBtnCancelClick()
		{
		}

		// Token: 0x06007102 RID: 28930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007102")]
		[Address(RVA = "0x1815AA0", Offset = "0x1815AA0", VA = "0x7BBC015AA0")]
		public UICommonTinyMsgBoxController()
		{
		}

		// Token: 0x04008A9F RID: 35487
		[Token(Token = "0x4008A9F")]
		[FieldOffset(Offset = "0x98")]
		private UICommonTinyMsgBoxView m_View;

		// Token: 0x04008AA0 RID: 35488
		[Token(Token = "0x4008AA0")]
		[FieldOffset(Offset = "0xA0")]
		private Action m_OnOK;

		// Token: 0x04008AA1 RID: 35489
		[Token(Token = "0x4008AA1")]
		[FieldOffset(Offset = "0xA8")]
		private Action m_OnCancel;

		// Token: 0x04008AA2 RID: 35490
		[Token(Token = "0x4008AA2")]
		[FieldOffset(Offset = "0xB0")]
		private Action m_OnClose;

		// Token: 0x02001766 RID: 5990
		[Token(Token = "0x2001766")]
		public enum EUIStyle
		{
			// Token: 0x04008AA4 RID: 35492
			[Token(Token = "0x4008AA4")]
			EUIStyleNormal,
			// Token: 0x04008AA5 RID: 35493
			[Token(Token = "0x4008AA5")]
			EUIStyleTips,
			// Token: 0x04008AA6 RID: 35494
			[Token(Token = "0x4008AA6")]
			EUIStyleIcon
		}

		// Token: 0x02001767 RID: 5991
		[Token(Token = "0x2001767")]
		public class Config
		{
			// Token: 0x06007103 RID: 28931 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007103")]
			[Address(RVA = "0x1815AA8", Offset = "0x1815AA8", VA = "0x7BBC015AA8")]
			public Config()
			{
			}

			// Token: 0x04008AA7 RID: 35495
			[Token(Token = "0x4008AA7")]
			[FieldOffset(Offset = "0x10")]
			public string Title;

			// Token: 0x04008AA8 RID: 35496
			[Token(Token = "0x4008AA8")]
			[FieldOffset(Offset = "0x18")]
			public string Content;

			// Token: 0x04008AA9 RID: 35497
			[Token(Token = "0x4008AA9")]
			[FieldOffset(Offset = "0x20")]
			public string OKTxt;

			// Token: 0x04008AAA RID: 35498
			[Token(Token = "0x4008AAA")]
			[FieldOffset(Offset = "0x28")]
			public string CancelTxt;

			// Token: 0x04008AAB RID: 35499
			[Token(Token = "0x4008AAB")]
			[FieldOffset(Offset = "0x30")]
			public string TipsTxt;

			// Token: 0x04008AAC RID: 35500
			[Token(Token = "0x4008AAC")]
			[FieldOffset(Offset = "0x38")]
			public ResourceID iconRes;

			// Token: 0x04008AAD RID: 35501
			[Token(Token = "0x4008AAD")]
			[FieldOffset(Offset = "0x40")]
			public Action OnOk;

			// Token: 0x04008AAE RID: 35502
			[Token(Token = "0x4008AAE")]
			[FieldOffset(Offset = "0x48")]
			public Action OnCancel;

			// Token: 0x04008AAF RID: 35503
			[Token(Token = "0x4008AAF")]
			[FieldOffset(Offset = "0x50")]
			public Action OnClose;

			// Token: 0x04008AB0 RID: 35504
			[Token(Token = "0x4008AB0")]
			[FieldOffset(Offset = "0x58")]
			public UICommonTinyMsgBoxController.EUIStyle Style;
		}
	}
}
