using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018AE RID: 6318
	[Token(Token = "0x20018AE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4914", Offset = "0x10F4914")]
	internal class UIHudDynamicInfoPopupController : UIBaseController
	{
		// Token: 0x06007D8F RID: 32143 RVA: 0x00022698 File Offset: 0x00020898
		[Token(Token = "0x6007D8F")]
		[Address(RVA = "0x1C002B8", Offset = "0x1C002B8", VA = "0x7BBC4002B8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007D90 RID: 32144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D90")]
		[Address(RVA = "0x1C00308", Offset = "0x1C00308", VA = "0x7BBC400308", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007D91 RID: 32145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D91")]
		[Address(RVA = "0x1C0036C", Offset = "0x1C0036C", VA = "0x7BBC40036C", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007D92 RID: 32146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D92")]
		[Address(RVA = "0x1C00374", Offset = "0x1C00374", VA = "0x7BBC400374", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007D93 RID: 32147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D93")]
		[Address(RVA = "0x1C0043C", Offset = "0x1C0043C", VA = "0x7BBC40043C")]
		public void SetMessage(string message, float duration)
		{
		}

		// Token: 0x06007D94 RID: 32148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D94")]
		[Address(RVA = "0x1C00568", Offset = "0x1C00568", VA = "0x7BBC400568")]
		private void AutoHide()
		{
		}

		// Token: 0x06007D95 RID: 32149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D95")]
		[Address(RVA = "0x1C0039C", Offset = "0x1C0039C", VA = "0x7BBC40039C")]
		private void CancelDelayCall()
		{
		}

		// Token: 0x06007D96 RID: 32150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D96")]
		[Address(RVA = "0x1C00610", Offset = "0x1C00610", VA = "0x7BBC400610", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06007D97 RID: 32151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D97")]
		[Address(RVA = "0x1C00638", Offset = "0x1C00638", VA = "0x7BBC400638")]
		public UIHudDynamicInfoPopupController()
		{
		}

		// Token: 0x04009125 RID: 37157
		[Token(Token = "0x4009125")]
		[FieldOffset(Offset = "0x58")]
		private UIHudDynamicInfoPopupView m_View;

		// Token: 0x04009126 RID: 37158
		[Token(Token = "0x4009126")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCallID;
	}
}
