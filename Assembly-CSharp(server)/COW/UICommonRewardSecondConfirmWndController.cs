using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200175A RID: 5978
	[Token(Token = "0x200175A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1E9C", Offset = "0x10F1E9C")]
	public class UICommonRewardSecondConfirmWndController : UIPopupWindowController
	{
		// Token: 0x06007089 RID: 28809 RVA: 0x0001F830 File Offset: 0x0001DA30
		[Token(Token = "0x6007089")]
		[Address(RVA = "0x1806764", Offset = "0x1806764", VA = "0x7BBC006764")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600708A RID: 28810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600708A")]
		[Address(RVA = "0x18067B4", Offset = "0x18067B4", VA = "0x7BBC0067B4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600708B RID: 28811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600708B")]
		[Address(RVA = "0x18068F0", Offset = "0x18068F0", VA = "0x7BBC0068F0")]
		protected void OnCancelClick()
		{
		}

		// Token: 0x0600708C RID: 28812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600708C")]
		[Address(RVA = "0x1806924", Offset = "0x1806924", VA = "0x7BBC006924")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x0600708D RID: 28813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600708D")]
		[Address(RVA = "0x1806958", Offset = "0x1806958", VA = "0x7BBC006958")]
		public void SetData(Dictionary<uint, long> returnIdNumDic, long returnCoinNum, long returnDiamondNum)
		{
		}

		// Token: 0x0600708E RID: 28814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600708E")]
		[Address(RVA = "0x18075EC", Offset = "0x18075EC", VA = "0x7BBC0075EC")]
		public void SetConfirmCallback(Action action)
		{
		}

		// Token: 0x0600708F RID: 28815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600708F")]
		[Address(RVA = "0x18075F4", Offset = "0x18075F4", VA = "0x7BBC0075F4")]
		public void SetCancelCallback(Action action)
		{
		}

		// Token: 0x06007090 RID: 28816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007090")]
		[Address(RVA = "0x18075FC", Offset = "0x18075FC", VA = "0x7BBC0075FC")]
		public UICommonRewardSecondConfirmWndController()
		{
		}

		// Token: 0x04008A52 RID: 35410
		[Token(Token = "0x4008A52")]
		[FieldOffset(Offset = "0x98")]
		private UICommonRewardSecondConfirmWndView m_View;

		// Token: 0x04008A53 RID: 35411
		[Token(Token = "0x4008A53")]
		[FieldOffset(Offset = "0xA0")]
		private Action m_ConfirmAction;

		// Token: 0x04008A54 RID: 35412
		[Token(Token = "0x4008A54")]
		[FieldOffset(Offset = "0xA8")]
		private Action m_CancelAction;
	}
}
