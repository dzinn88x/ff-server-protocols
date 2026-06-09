using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020012E0 RID: 4832
	[Token(Token = "0x20012E0")]
	internal class PCMatchGameClient : MatchGameClient
	{
		// Token: 0x06004C5F RID: 19551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5F")]
		[Address(RVA = "0x2038D38", Offset = "0x2038D38", VA = "0x7BBC838D38")]
		public PCMatchGameClient(ISessionHanlder sessionHanlder)
		{
		}

		// Token: 0x06004C60 RID: 19552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C60")]
		[Address(RVA = "0x2038EAC", Offset = "0x2038EAC", VA = "0x7BBC838EAC", Slot = "9")]
		public override void OnConnected(bool result)
		{
		}

		// Token: 0x06004C61 RID: 19553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C61")]
		[Address(RVA = "0x2038F14", Offset = "0x2038F14", VA = "0x7BBC838F14", Slot = "10")]
		public override void OnDisconnected(DisconnectedReason reason)
		{
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C62")]
		[Address(RVA = "0x2038FA0", Offset = "0x2038FA0", VA = "0x7BBC838FA0", Slot = "11")]
		public override void OnPingSent(int lastSentTime)
		{
		}

		// Token: 0x06004C63 RID: 19555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C63")]
		[Address(RVA = "0x2039004", Offset = "0x2039004", VA = "0x7BBC839004", Slot = "7")]
		public override void Update()
		{
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x00016D58 File Offset: 0x00014F58
		[Token(Token = "0x6004C64")]
		[Address(RVA = "0x2039068", Offset = "0x2039068", VA = "0x7BBC839068", Slot = "8")]
		public override bool Send(uint messageID, UDPClientMessageBase msg, byte sendOption = 0, bool cacheMsgAnyWay = false)
		{
			return default(bool);
		}

		// Token: 0x06004C65 RID: 19557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C65")]
		[Address(RVA = "0x20390F4", Offset = "0x20390F4", VA = "0x7BBC8390F4", Slot = "12")]
		protected override void HandleRecvPacket()
		{
		}

		// Token: 0x04007408 RID: 29704
		[Token(Token = "0x4007408")]
		[FieldOffset(Offset = "0x60")]
		private ReplayManager m_ReplayMgr;

		// Token: 0x04007409 RID: 29705
		[Token(Token = "0x4007409")]
		[FieldOffset(Offset = "0x68")]
		private DelayOBManager m_DelayOBMgr;

		// Token: 0x0400740A RID: 29706
		[Token(Token = "0x400740A")]
		[FieldOffset(Offset = "0x70")]
		private DelayOBData m_DelayOBData;

		// Token: 0x0400740B RID: 29707
		[Token(Token = "0x400740B")]
		[FieldOffset(Offset = "0x78")]
		private bool m_DelayOBGSDisconnected;
	}
}
