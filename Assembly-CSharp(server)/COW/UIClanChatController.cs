using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200171D RID: 5917
	[Token(Token = "0x200171D")]
	public class UIClanChatController : UIBaseChatController<UIClanChatItemController>
	{
		// Token: 0x06006E61 RID: 28257 RVA: 0x0001F128 File Offset: 0x0001D328
		[Token(Token = "0x6006E61")]
		[Address(RVA = "0x1CEE6A0", Offset = "0x1CEE6A0", VA = "0x7BBC4EE6A0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006E62 RID: 28258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E62")]
		[Address(RVA = "0x1CEE6F0", Offset = "0x1CEE6F0", VA = "0x7BBC4EE6F0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006E63 RID: 28259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E63")]
		[Address(RVA = "0x1CEEB10", Offset = "0x1CEEB10", VA = "0x7BBC4EEB10", Slot = "32")]
		protected override ChatChannelInfo GetCurShowChannel()
		{
			return null;
		}

		// Token: 0x06006E64 RID: 28260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E64")]
		[Address(RVA = "0x1CEECAC", Offset = "0x1CEECAC", VA = "0x7BBC4EECAC")]
		public UIClanChatController()
		{
		}

		// Token: 0x04008906 RID: 35078
		[Token(Token = "0x4008906")]
		[FieldOffset(Offset = "0x1A8")]
		private UIClanChatView m_View;
	}
}
