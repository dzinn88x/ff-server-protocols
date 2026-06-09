using System;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x02001415 RID: 5141
	[Token(Token = "0x2001415")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC5D0", Offset = "0x10EC5D0")]
	public class UIBigEventChatMsgItemController : UIBaseController
	{
		// Token: 0x060054C3 RID: 21699 RVA: 0x000194E8 File Offset: 0x000176E8
		[Token(Token = "0x60054C3")]
		[Address(RVA = "0x1427FC4", Offset = "0x1427FC4", VA = "0x7BBBC27FC4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060054C4 RID: 21700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C4")]
		[Address(RVA = "0x1428014", Offset = "0x1428014", VA = "0x7BBBC28014", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060054C5 RID: 21701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C5")]
		[Address(RVA = "0x142817C", Offset = "0x142817C", VA = "0x7BBBC2817C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060054C6 RID: 21702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C6")]
		[Address(RVA = "0x1420CC8", Offset = "0x1420CC8", VA = "0x7BBBC20CC8")]
		public void SetViewData(string serializedInfo, UIBigEventChatMsgItemController.EBigEventChatMsgType type, bool isSelf, EChannel.ChannelType channel, ulong senderID = 0UL)
		{
		}

		// Token: 0x060054C7 RID: 21703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C7")]
		[Address(RVA = "0x1428184", Offset = "0x1428184", VA = "0x7BBBC28184")]
		private void OnBtnJoinClick()
		{
		}

		// Token: 0x060054C8 RID: 21704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C8")]
		[Address(RVA = "0x1428684", Offset = "0x1428684", VA = "0x7BBBC28684")]
		public UIBigEventChatMsgItemController()
		{
		}

		// Token: 0x04007A01 RID: 31233
		[Token(Token = "0x4007A01")]
		[FieldOffset(Offset = "0x58")]
		private UIBigEventChatMsgItemView m_View;

		// Token: 0x04007A02 RID: 31234
		[Token(Token = "0x4007A02")]
		[FieldOffset(Offset = "0x60")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x04007A03 RID: 31235
		[Token(Token = "0x4007A03")]
		[FieldOffset(Offset = "0x68")]
		private UIModelGoliath m_ModelGoliath;

		// Token: 0x04007A04 RID: 31236
		[Token(Token = "0x4007A04")]
		[FieldOffset(Offset = "0x70")]
		private object m_Info;

		// Token: 0x04007A05 RID: 31237
		[Token(Token = "0x4007A05")]
		[FieldOffset(Offset = "0x78")]
		private UIBigEventChatMsgItemController.EBigEventChatMsgType m_CurType;

		// Token: 0x04007A06 RID: 31238
		[Token(Token = "0x4007A06")]
		[FieldOffset(Offset = "0x7C")]
		private EChannel.ChannelType m_Channel;

		// Token: 0x04007A07 RID: 31239
		[Token(Token = "0x4007A07")]
		private const uint MAX_SUB_GROUP_CNT = 2U;

		// Token: 0x04007A08 RID: 31240
		[Token(Token = "0x4007A08")]
		[FieldOffset(Offset = "0x80")]
		private ulong m_SenderID;

		// Token: 0x02001416 RID: 5142
		[Token(Token = "0x2001416")]
		public enum EBigEventChatMsgType
		{
			// Token: 0x04007A0A RID: 31242
			[Token(Token = "0x4007A0A")]
			Invalid,
			// Token: 0x04007A0B RID: 31243
			[Token(Token = "0x4007A0B")]
			Goliath,
			// Token: 0x04007A0C RID: 31244
			[Token(Token = "0x4007A0C")]
			SuperCar
		}
	}
}
