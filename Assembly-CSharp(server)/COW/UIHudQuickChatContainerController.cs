using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001939 RID: 6457
	[Token(Token = "0x2001939")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5C84", Offset = "0x10F5C84")]
	public class UIHudQuickChatContainerController : UIBaseController
	{
		// Token: 0x060082D6 RID: 33494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082D6")]
		[Address(RVA = "0x17DFED4", Offset = "0x17DFED4", VA = "0x7BBBFDFED4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060082D7 RID: 33495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082D7")]
		[Address(RVA = "0x17E0058", Offset = "0x17E0058", VA = "0x7BBBFE0058", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060082D8 RID: 33496 RVA: 0x000238C8 File Offset: 0x00021AC8
		[Token(Token = "0x60082D8")]
		[Address(RVA = "0x17E0180", Offset = "0x17E0180", VA = "0x7BBBFE0180")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060082D9 RID: 33497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082D9")]
		[Address(RVA = "0x17E01D0", Offset = "0x17E01D0", VA = "0x7BBBFE01D0")]
		private void OnRecvQuickChat(object[] data)
		{
		}

		// Token: 0x060082DA RID: 33498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082DA")]
		[Address(RVA = "0x17E08AC", Offset = "0x17E08AC", VA = "0x7BBBFE08AC")]
		private void UpdateQuickChatShow()
		{
		}

		// Token: 0x060082DB RID: 33499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082DB")]
		[Address(RVA = "0x17E07A8", Offset = "0x17E07A8", VA = "0x7BBBFE07A8")]
		private void ResetPositionAndScrollToBottom()
		{
		}

		// Token: 0x060082DC RID: 33500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082DC")]
		[Address(RVA = "0x17E0AA0", Offset = "0x17E0AA0", VA = "0x7BBBFE0AA0")]
		public UIHudQuickChatContainerController()
		{
		}

		// Token: 0x04009402 RID: 37890
		[Token(Token = "0x4009402")]
		[FieldOffset(Offset = "0x58")]
		private UIHudQuickChatContainerView m_View;

		// Token: 0x04009403 RID: 37891
		[Token(Token = "0x4009403")]
		[FieldOffset(Offset = "0x60")]
		private List<QuickChatShowItem> m_ShowQueue;

		// Token: 0x04009404 RID: 37892
		[Token(Token = "0x4009404")]
		[FieldOffset(Offset = "0x68")]
		private Queue<QuickChatView> m_LabelPool;

		// Token: 0x04009405 RID: 37893
		[Token(Token = "0x4009405")]
		[FieldOffset(Offset = "0x70")]
		private uint m_UpdateCallID;
	}
}
