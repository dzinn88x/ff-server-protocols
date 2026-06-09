using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001701 RID: 5889
	[Token(Token = "0x2001701")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F140C", Offset = "0x10F140C")]
	public class UIChatReportController : UIPopupWindowController
	{
		// Token: 0x06006D89 RID: 28041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D89")]
		[Address(RVA = "0x1BE8E08", Offset = "0x1BE8E08", VA = "0x7BBC3E8E08", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006D8A RID: 28042 RVA: 0x0001EDF8 File Offset: 0x0001CFF8
		[Token(Token = "0x6006D8A")]
		[Address(RVA = "0x1BE9088", Offset = "0x1BE9088", VA = "0x7BBC3E9088")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006D8B RID: 28043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D8B")]
		[Address(RVA = "0x1BE90D8", Offset = "0x1BE90D8", VA = "0x7BBC3E90D8")]
		public void SetUIData(MessageInfo messageInfo)
		{
		}

		// Token: 0x06006D8C RID: 28044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D8C")]
		[Address(RVA = "0x1BE95DC", Offset = "0x1BE95DC", VA = "0x7BBC3E95DC")]
		private void OnReportReasonSelect(UIToggleButton button)
		{
		}

		// Token: 0x06006D8D RID: 28045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D8D")]
		[Address(RVA = "0x1BE97F4", Offset = "0x1BE97F4", VA = "0x7BBC3E97F4")]
		private void OnReportButtonClick()
		{
		}

		// Token: 0x06006D8E RID: 28046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D8E")]
		[Address(RVA = "0x1BE9A00", Offset = "0x1BE9A00", VA = "0x7BBC3E9A00")]
		public UIChatReportController()
		{
		}

		// Token: 0x04008899 RID: 34969
		[Token(Token = "0x4008899")]
		[FieldOffset(Offset = "0x98")]
		private UIChatReportView m_View;

		// Token: 0x0400889A RID: 34970
		[Token(Token = "0x400889A")]
		[FieldOffset(Offset = "0xA0")]
		private uint m_SelectedReason;

		// Token: 0x0400889B RID: 34971
		[Token(Token = "0x400889B")]
		[FieldOffset(Offset = "0xA8")]
		private MessageInfo m_MessageData;
	}
}
