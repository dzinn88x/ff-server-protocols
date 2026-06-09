using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020012D7 RID: 4823
	[Token(Token = "0x20012D7")]
	internal class ChatServiceConnectionHandler : ServiceConnectionHandler
	{
		// Token: 0x06004BFD RID: 19453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BFD")]
		[Address(RVA = "0x14F4ADC", Offset = "0x14F4ADC", VA = "0x7BBBCF4ADC")]
		public ChatServiceConnectionHandler(string token)
		{
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x00016C98 File Offset: 0x00014E98
		[Token(Token = "0x6004BFE")]
		[Address(RVA = "0x14F4C38", Offset = "0x14F4C38", VA = "0x7BBBCF4C38", Slot = "11")]
		public override EServiceHandler GetServiceHandlerName()
		{
			return EServiceHandler.None;
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BFF")]
		[Address(RVA = "0x14F4C40", Offset = "0x14F4C40", VA = "0x7BBBCF4C40")]
		private void OnRecvChannelMessage(MessageNotify res)
		{
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C00")]
		[Address(RVA = "0x14F57B0", Offset = "0x14F57B0", VA = "0x7BBBCF57B0")]
		private void OnRecvChatNty(MessageNotify res)
		{
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C01")]
		[Address(RVA = "0x14F5878", Offset = "0x14F5878", VA = "0x7BBBCF5878", Slot = "10")]
		protected override void OnServerConfirmed(TCPEmptyMessage res)
		{
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C02")]
		[Address(RVA = "0x14F58A0", Offset = "0x14F58A0", VA = "0x7BBBCF58A0", Slot = "9")]
		public override void OnDisconnected(DisconnectedReason reason)
		{
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C03")]
		[Address(RVA = "0x14F58C8", Offset = "0x14F58C8", VA = "0x7BBBCF58C8")]
		private void LeaveAllChannels()
		{
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C04")]
		[Address(RVA = "0x14F531C", Offset = "0x14F531C", VA = "0x7BBBCF531C")]
		private void JoinChannels()
		{
		}

		// Token: 0x040073E8 RID: 29672
		[Token(Token = "0x40073E8")]
		[FieldOffset(Offset = "0x38")]
		private UIModelChat m_ChatModel;

		// Token: 0x040073E9 RID: 29673
		[Token(Token = "0x40073E9")]
		[FieldOffset(Offset = "0x40")]
		private ulong m_ReservationReachLimitTime;
	}
}
