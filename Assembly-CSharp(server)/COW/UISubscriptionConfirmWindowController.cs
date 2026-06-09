using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BA4 RID: 7076
	[Token(Token = "0x2001BA4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA954", Offset = "0x10FA954")]
	public class UISubscriptionConfirmWindowController : UIPopupWindowController
	{
		// Token: 0x060098C0 RID: 39104 RVA: 0x000283C8 File Offset: 0x000265C8
		[Token(Token = "0x60098C0")]
		[Address(RVA = "0x213927C", Offset = "0x213927C", VA = "0x7BBC93927C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060098C1 RID: 39105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098C1")]
		[Address(RVA = "0x21392CC", Offset = "0x21392CC", VA = "0x7BBC9392CC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060098C2 RID: 39106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098C2")]
		[Address(RVA = "0x21394B8", Offset = "0x21394B8", VA = "0x7BBC9394B8")]
		public void SetData(UISubscriptionConfirmWindowController.SubscriptionConfirmDisplayInfo info)
		{
		}

		// Token: 0x060098C3 RID: 39107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098C3")]
		[Address(RVA = "0x2139978", Offset = "0x2139978", VA = "0x7BBC939978", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060098C4 RID: 39108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098C4")]
		[Address(RVA = "0x2139980", Offset = "0x2139980", VA = "0x7BBC939980")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x060098C5 RID: 39109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098C5")]
		[Address(RVA = "0x21399BC", Offset = "0x21399BC", VA = "0x7BBC9399BC")]
		private void OnBtnOKClick()
		{
		}

		// Token: 0x060098C6 RID: 39110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098C6")]
		[Address(RVA = "0x2139A78", Offset = "0x2139A78", VA = "0x7BBC939A78")]
		private void OnBtnConfirmClick()
		{
		}

		// Token: 0x060098C7 RID: 39111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098C7")]
		[Address(RVA = "0x2139CE4", Offset = "0x2139CE4", VA = "0x7BBC939CE4")]
		private void OnBtnCancelClick()
		{
		}

		// Token: 0x060098C8 RID: 39112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098C8")]
		[Address(RVA = "0x2139CEC", Offset = "0x2139CEC", VA = "0x7BBC939CEC")]
		public UISubscriptionConfirmWindowController()
		{
		}

		// Token: 0x0400A057 RID: 41047
		[Token(Token = "0x400A057")]
		[FieldOffset(Offset = "0x98")]
		private UISubscriptionConfirmWindowView m_View;

		// Token: 0x0400A058 RID: 41048
		[Token(Token = "0x400A058")]
		[FieldOffset(Offset = "0xA0")]
		private UISubscriptionConfirmWindowController.SubscriptionConfirmDisplayInfo m_Info;

		// Token: 0x02001BA5 RID: 7077
		[Token(Token = "0x2001BA5")]
		public enum ButtonStyle
		{
			// Token: 0x0400A05A RID: 41050
			[Token(Token = "0x400A05A")]
			None,
			// Token: 0x0400A05B RID: 41051
			[Token(Token = "0x400A05B")]
			OK,
			// Token: 0x0400A05C RID: 41052
			[Token(Token = "0x400A05C")]
			Confirm_Cancel
		}

		// Token: 0x02001BA6 RID: 7078
		[Token(Token = "0x2001BA6")]
		public class SubscriptionConfirmDisplayInfo
		{
			// Token: 0x060098C9 RID: 39113 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60098C9")]
			[Address(RVA = "0x2139CF4", Offset = "0x2139CF4", VA = "0x7BBC939CF4")]
			public SubscriptionConfirmDisplayInfo()
			{
			}

			// Token: 0x0400A05D RID: 41053
			[Token(Token = "0x400A05D")]
			[FieldOffset(Offset = "0x10")]
			public string Title;

			// Token: 0x0400A05E RID: 41054
			[Token(Token = "0x400A05E")]
			[FieldOffset(Offset = "0x18")]
			public string Desc_1;

			// Token: 0x0400A05F RID: 41055
			[Token(Token = "0x400A05F")]
			[FieldOffset(Offset = "0x20")]
			public string Desc_2;

			// Token: 0x0400A060 RID: 41056
			[Token(Token = "0x400A060")]
			[FieldOffset(Offset = "0x28")]
			public string Desc_3;

			// Token: 0x0400A061 RID: 41057
			[Token(Token = "0x400A061")]
			[FieldOffset(Offset = "0x30")]
			public string Desc;

			// Token: 0x0400A062 RID: 41058
			[Token(Token = "0x400A062")]
			[FieldOffset(Offset = "0x38")]
			public string SubscriptionProductIdentifier;

			// Token: 0x0400A063 RID: 41059
			[Token(Token = "0x400A063")]
			[FieldOffset(Offset = "0x40")]
			public Action<string> OnOK;

			// Token: 0x0400A064 RID: 41060
			[Token(Token = "0x400A064")]
			[FieldOffset(Offset = "0x48")]
			public bool ShowClose;

			// Token: 0x0400A065 RID: 41061
			[Token(Token = "0x400A065")]
			[FieldOffset(Offset = "0x4C")]
			public UISubscriptionConfirmWindowController.ButtonStyle ButtonStyle;

			// Token: 0x0400A066 RID: 41062
			[Token(Token = "0x400A066")]
			[FieldOffset(Offset = "0x50")]
			public RebateCardInfo RebateCard;
		}
	}
}
