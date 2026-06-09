using System;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x020016FC RID: 5884
	[Token(Token = "0x20016FC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1364", Offset = "0x10F1364")]
	public class UIChatParentController : UIPopupWindowController
	{
		// Token: 0x06006D61 RID: 28001 RVA: 0x0001ED50 File Offset: 0x0001CF50
		[Token(Token = "0x6006D61")]
		[Address(RVA = "0x1BE5658", Offset = "0x1BE5658", VA = "0x7BBC3E5658")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006D62 RID: 28002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D62")]
		[Address(RVA = "0x1BE56A8", Offset = "0x1BE56A8", VA = "0x7BBC3E56A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006D63 RID: 28003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D63")]
		[Address(RVA = "0x1BE5808", Offset = "0x1BE5808", VA = "0x7BBC3E5808", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06006D64 RID: 28004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D64")]
		[Address(RVA = "0x1BE58D4", Offset = "0x1BE58D4", VA = "0x7BBC3E58D4", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06006D65 RID: 28005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D65")]
		[Address(RVA = "0x1BE5984", Offset = "0x1BE5984", VA = "0x7BBC3E5984")]
		public void GotoChannel(EChannel.ChannelType type, ulong roomid = 0UL)
		{
		}

		// Token: 0x06006D66 RID: 28006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D66")]
		[Address(RVA = "0x1BE59CC", Offset = "0x1BE59CC", VA = "0x7BBC3E59CC", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06006D67 RID: 28007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D67")]
		[Address(RVA = "0x1BE5A30", Offset = "0x1BE5A30", VA = "0x7BBC3E5A30")]
		private void CloseChatWindow(params object[] objs)
		{
		}

		// Token: 0x06006D68 RID: 28008 RVA: 0x0001ED68 File Offset: 0x0001CF68
		[Token(Token = "0x6006D68")]
		[Address(RVA = "0x1BE5A38", Offset = "0x1BE5A38", VA = "0x7BBC3E5A38", Slot = "34")]
		protected override bool UseCustomizedAnimation()
		{
			return default(bool);
		}

		// Token: 0x06006D69 RID: 28009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D69")]
		[Address(RVA = "0x1BE5A40", Offset = "0x1BE5A40", VA = "0x7BBC3E5A40")]
		public UIChatParentController()
		{
		}

		// Token: 0x0400888C RID: 34956
		[Token(Token = "0x400888C")]
		[FieldOffset(Offset = "0x98")]
		private UIChatParentView m_View;

		// Token: 0x0400888D RID: 34957
		[Token(Token = "0x400888D")]
		[FieldOffset(Offset = "0xA0")]
		private UIChatController m_ChatController;
	}
}
