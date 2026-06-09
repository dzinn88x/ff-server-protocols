using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200188F RID: 6287
	[Token(Token = "0x200188F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F45A4", Offset = "0x10F45A4")]
	public class UIHUDChangeSeatConfirmController : UIBaseController
	{
		// Token: 0x06007C87 RID: 31879 RVA: 0x00022368 File Offset: 0x00020568
		[Token(Token = "0x6007C87")]
		[Address(RVA = "0x16B70F4", Offset = "0x16B70F4", VA = "0x7BBBEB70F4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007C88 RID: 31880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C88")]
		[Address(RVA = "0x16B7144", Offset = "0x16B7144", VA = "0x7BBBEB7144", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007C89 RID: 31881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C89")]
		[Address(RVA = "0x16B730C", Offset = "0x16B730C", VA = "0x7BBBEB730C")]
		private void OnBtnClick()
		{
		}

		// Token: 0x06007C8A RID: 31882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C8A")]
		[Address(RVA = "0x16B73A8", Offset = "0x16B73A8", VA = "0x7BBBEB73A8", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06007C8B RID: 31883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C8B")]
		[Address(RVA = "0x16B74C8", Offset = "0x16B74C8", VA = "0x7BBBEB74C8")]
		private void OnChangeSeatConfirm(object[] data)
		{
		}

		// Token: 0x06007C8C RID: 31884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C8C")]
		[Address(RVA = "0x16B74DC", Offset = "0x16B74DC", VA = "0x7BBBEB74DC")]
		private void OnAskChangeSeat(params object[] data)
		{
		}

		// Token: 0x06007C8D RID: 31885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C8D")]
		[Address(RVA = "0x16B79E4", Offset = "0x16B79E4", VA = "0x7BBBEB79E4")]
		public UIHUDChangeSeatConfirmController()
		{
		}

		// Token: 0x06007C8E RID: 31886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C8E")]
		[Address(RVA = "0x16B7A44", Offset = "0x16B7A44", VA = "0x7BBBEB7A44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114294C", Offset = "0x114294C")]
		private void <OnAskChangeSeat>b__8_0()
		{
		}

		// Token: 0x04009064 RID: 36964
		[Token(Token = "0x4009064")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDChangeSeatConfirmView m_View;

		// Token: 0x04009065 RID: 36965
		[Token(Token = "0x4009065")]
		[FieldOffset(Offset = "0x60")]
		private uint m_CallID;

		// Token: 0x04009066 RID: 36966
		[Token(Token = "0x4009066")]
		[FieldOffset(Offset = "0x68")]
		private string m_TeammateName;
	}
}
