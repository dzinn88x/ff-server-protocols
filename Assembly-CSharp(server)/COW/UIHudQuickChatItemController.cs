using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200193A RID: 6458
	[Token(Token = "0x200193A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5CBC", Offset = "0x10F5CBC")]
	public class UIHudQuickChatItemController : UIBaseController
	{
		// Token: 0x060082DD RID: 33501 RVA: 0x000238E0 File Offset: 0x00021AE0
		[Token(Token = "0x60082DD")]
		[Address(RVA = "0x17E0C60", Offset = "0x17E0C60", VA = "0x7BBBFE0C60")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060082DE RID: 33502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082DE")]
		[Address(RVA = "0x17E0CB0", Offset = "0x17E0CB0", VA = "0x7BBBFE0CB0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060082DF RID: 33503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082DF")]
		[Address(RVA = "0x17E0D94", Offset = "0x17E0D94", VA = "0x7BBBFE0D94")]
		public void SetUIData(IngameQuickChatData data)
		{
		}

		// Token: 0x060082E0 RID: 33504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082E0")]
		[Address(RVA = "0x17E0E90", Offset = "0x17E0E90", VA = "0x7BBBFE0E90")]
		public void SetEnable(bool enable)
		{
		}

		// Token: 0x060082E1 RID: 33505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082E1")]
		[Address(RVA = "0x17E0F34", Offset = "0x17E0F34", VA = "0x7BBBFE0F34")]
		private void OnBtnClick()
		{
		}

		// Token: 0x060082E2 RID: 33506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082E2")]
		[Address(RVA = "0x17E10EC", Offset = "0x17E10EC", VA = "0x7BBBFE10EC")]
		public UIHudQuickChatItemController()
		{
		}

		// Token: 0x04009406 RID: 37894
		[Token(Token = "0x4009406")]
		[FieldOffset(Offset = "0x58")]
		private UIHudQuickChatItemView m_View;

		// Token: 0x04009407 RID: 37895
		[Token(Token = "0x4009407")]
		[FieldOffset(Offset = "0x60")]
		private IngameQuickChatData m_QuickChatData;
	}
}
