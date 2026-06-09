using System;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x0200171E RID: 5918
	[Token(Token = "0x200171E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F185C", Offset = "0x10F185C")]
	public class UIClanChatItemController : UIBaseChatItemController
	{
		// Token: 0x06006E65 RID: 28261 RVA: 0x0001F140 File Offset: 0x0001D340
		[Token(Token = "0x6006E65")]
		[Address(RVA = "0x1CEECFC", Offset = "0x1CEECFC", VA = "0x7BBC4EECFC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006E66 RID: 28262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E66")]
		[Address(RVA = "0x1CEED4C", Offset = "0x1CEED4C", VA = "0x7BBC4EED4C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006E67 RID: 28263 RVA: 0x0001F158 File Offset: 0x0001D358
		[Token(Token = "0x6006E67")]
		[Address(RVA = "0x1CEEF50", Offset = "0x1CEEF50", VA = "0x7BBC4EEF50", Slot = "28")]
		protected override EChannel.ChannelType GetParentChannelType()
		{
			return EChannel.ChannelType.ChannelType_GROUP;
		}

		// Token: 0x06006E68 RID: 28264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E68")]
		[Address(RVA = "0x1CEF0AC", Offset = "0x1CEF0AC", VA = "0x7BBC4EF0AC")]
		public UIClanChatItemController()
		{
		}

		// Token: 0x04008907 RID: 35079
		[Token(Token = "0x4008907")]
		[FieldOffset(Offset = "0xF8")]
		private UIClanChatItemView m_View;
	}
}
