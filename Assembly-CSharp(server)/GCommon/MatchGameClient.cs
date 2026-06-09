using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F7C RID: 3964
	[Token(Token = "0x2000F7C")]
	internal class MatchGameClient : NetworkClient, ISessionHanlder
	{
		// Token: 0x060039BD RID: 14781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039BD")]
		[Address(RVA = "0x212C8B4", Offset = "0x212C8B4", VA = "0x7BBC92C8B4")]
		public MatchGameClient(ISessionHanlder sessionHanlder)
		{
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039BE")]
		[Address(RVA = "0x212C984", Offset = "0x212C984", VA = "0x7BBC92C984", Slot = "7")]
		public virtual void Update()
		{
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x00011E68 File Offset: 0x00010068
		[Token(Token = "0x60039BF")]
		[Address(RVA = "0x212CA8C", Offset = "0x212CA8C", VA = "0x7BBC92CA8C", Slot = "8")]
		public virtual bool Send(uint messageID, UDPClientMessageBase msg, byte sendOption = 0, bool cacheMsgAnyWay = false)
		{
			return default(bool);
		}

		// Token: 0x060039C0 RID: 14784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C0")]
		[Address(RVA = "0x212CEB4", Offset = "0x212CEB4", VA = "0x7BBC92CEB4", Slot = "9")]
		public virtual void OnConnected(bool result)
		{
		}

		// Token: 0x060039C1 RID: 14785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C1")]
		[Address(RVA = "0x212D07C", Offset = "0x212D07C", VA = "0x7BBC92D07C", Slot = "10")]
		public virtual void OnDisconnected(DisconnectedReason reason)
		{
		}

		// Token: 0x060039C2 RID: 14786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C2")]
		[Address(RVA = "0x212D180", Offset = "0x212D180", VA = "0x7BBC92D180", Slot = "11")]
		public virtual void OnPingSent(int lastSentTime)
		{
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C3")]
		[Address(RVA = "0x212D250", Offset = "0x212D250", VA = "0x7BBC92D250", Slot = "12")]
		protected virtual void HandleRecvPacket()
		{
		}

		// Token: 0x04004B46 RID: 19270
		[Token(Token = "0x4004B46")]
		[FieldOffset(Offset = "0x20")]
		protected UDPSession m_UDPSession;

		// Token: 0x04004B47 RID: 19271
		[Token(Token = "0x4004B47")]
		[FieldOffset(Offset = "0x28")]
		protected MemoryStream m_SendMemoryStream;

		// Token: 0x04004B48 RID: 19272
		[Token(Token = "0x4004B48")]
		[FieldOffset(Offset = "0x30")]
		protected MemoryStream m_RecvMemoryStream;

		// Token: 0x04004B49 RID: 19273
		[Token(Token = "0x4004B49")]
		[FieldOffset(Offset = "0x38")]
		protected BinaryReader m_BinaryReader;

		// Token: 0x04004B4A RID: 19274
		[Token(Token = "0x4004B4A")]
		[FieldOffset(Offset = "0x40")]
		protected BinaryWriter m_BinaryWriter;

		// Token: 0x04004B4B RID: 19275
		[Token(Token = "0x4004B4B")]
		[FieldOffset(Offset = "0x48")]
		protected Queue<UDPMsgPacket> m_RecvUDPMsgList;

		// Token: 0x04004B4C RID: 19276
		[Token(Token = "0x4004B4C")]
		[FieldOffset(Offset = "0x50")]
		protected ISessionHanlder m_SessionHandler;

		// Token: 0x04004B4D RID: 19277
		[Token(Token = "0x4004B4D")]
		[FieldOffset(Offset = "0x58")]
		protected float m_LastRecvPingPacketTime;
	}
}
