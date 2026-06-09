using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B7A RID: 7034
	[Token(Token = "0x2001B7A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA28C", Offset = "0x10FA28C")]
	public class UISecondConfirmSmallContoller : UIPopupWindowController
	{
		// Token: 0x06009790 RID: 38800 RVA: 0x00027F90 File Offset: 0x00026190
		[Token(Token = "0x6009790")]
		[Address(RVA = "0x162F514", Offset = "0x162F514", VA = "0x7BBBE2F514")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009791 RID: 38801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009791")]
		[Address(RVA = "0x162F564", Offset = "0x162F564", VA = "0x7BBBE2F564", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009792 RID: 38802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009792")]
		[Address(RVA = "0x162F6E8", Offset = "0x162F6E8", VA = "0x7BBBE2F6E8")]
		protected void OnCancelClick()
		{
		}

		// Token: 0x06009793 RID: 38803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009793")]
		[Address(RVA = "0x162F71C", Offset = "0x162F71C", VA = "0x7BBBE2F71C")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x06009794 RID: 38804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009794")]
		[Address(RVA = "0x162F750", Offset = "0x162F750", VA = "0x7BBBE2F750")]
		public void SetData(string text = "")
		{
		}

		// Token: 0x06009795 RID: 38805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009795")]
		[Address(RVA = "0x162F798", Offset = "0x162F798", VA = "0x7BBBE2F798")]
		public void SetTitle(string title)
		{
		}

		// Token: 0x06009796 RID: 38806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009796")]
		[Address(RVA = "0x162F7D0", Offset = "0x162F7D0", VA = "0x7BBBE2F7D0")]
		public void ShowCancelButton()
		{
		}

		// Token: 0x06009797 RID: 38807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009797")]
		[Address(RVA = "0x162F82C", Offset = "0x162F82C", VA = "0x7BBBE2F82C")]
		public void SetConfirmCallback(Action action)
		{
		}

		// Token: 0x06009798 RID: 38808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009798")]
		[Address(RVA = "0x162F834", Offset = "0x162F834", VA = "0x7BBBE2F834")]
		public void SetCancelCallback(Action action)
		{
		}

		// Token: 0x06009799 RID: 38809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009799")]
		[Address(RVA = "0x162F83C", Offset = "0x162F83C", VA = "0x7BBBE2F83C", Slot = "38")]
		public override void EnterByReturn()
		{
		}

		// Token: 0x0600979A RID: 38810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600979A")]
		[Address(RVA = "0x162F928", Offset = "0x162F928", VA = "0x7BBBE2F928")]
		public UISecondConfirmSmallContoller()
		{
		}

		// Token: 0x04009FA4 RID: 40868
		[Token(Token = "0x4009FA4")]
		[FieldOffset(Offset = "0x98")]
		private UISecondConfirmSmallView m_View;

		// Token: 0x04009FA5 RID: 40869
		[Token(Token = "0x4009FA5")]
		[FieldOffset(Offset = "0xA0")]
		private Action m_ConfirmAction;

		// Token: 0x04009FA6 RID: 40870
		[Token(Token = "0x4009FA6")]
		[FieldOffset(Offset = "0xA8")]
		private Action m_CancelAction;
	}
}
