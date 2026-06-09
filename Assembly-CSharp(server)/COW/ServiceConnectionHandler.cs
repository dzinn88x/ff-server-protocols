using System;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x020012E1 RID: 4833
	[Token(Token = "0x20012E1")]
	internal class ServiceConnectionHandler : ISessionHanlder
	{
		// Token: 0x06004C66 RID: 19558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C66")]
		[Address(RVA = "0x1B34378", Offset = "0x1B34378", VA = "0x7BBC334378")]
		public ServiceConnectionHandler(string token)
		{
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x00016D70 File Offset: 0x00014F70
		[Token(Token = "0x6004C67")]
		[Address(RVA = "0x1B344C4", Offset = "0x1B344C4", VA = "0x7BBC3344C4")]
		public bool Connect(string addr, int port)
		{
			return default(bool);
		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C68")]
		[Address(RVA = "0x1B34964", Offset = "0x1B34964", VA = "0x7BBC334964")]
		public void Update(float gameTime)
		{
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C69")]
		[Address(RVA = "0x1B34D74", Offset = "0x1B34D74", VA = "0x7BBC334D74")]
		public void Close()
		{
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C6A")]
		[Address(RVA = "0x1B34D8C", Offset = "0x1B34D8C", VA = "0x7BBC334D8C")]
		public void Destroy()
		{
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C6B")]
		[Address(RVA = "0x1B34DC0", Offset = "0x1B34DC0", VA = "0x7BBC334DC0", Slot = "7")]
		public virtual void OnConnected(bool result)
		{
		}

		// Token: 0x06004C6C RID: 19564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C6C")]
		[Address(RVA = "0x1B34E8C", Offset = "0x1B34E8C", VA = "0x7BBC334E8C", Slot = "8")]
		public virtual void OnPingSent(int lastSentTime)
		{
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C6D")]
		[Address(RVA = "0x1B34E90", Offset = "0x1B34E90", VA = "0x7BBC334E90", Slot = "9")]
		public virtual void OnDisconnected(DisconnectedReason reason)
		{
		}

		// Token: 0x06004C6E RID: 19566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C6E")]
		[Address(RVA = "0x1B35144", Offset = "0x1B35144", VA = "0x7BBC335144", Slot = "10")]
		protected virtual void OnServerConfirmed(TCPEmptyMessage res)
		{
		}

		// Token: 0x06004C6F RID: 19567 RVA: 0x00016D88 File Offset: 0x00014F88
		[Token(Token = "0x6004C6F")]
		[Address(RVA = "0x1B352D4", Offset = "0x1B352D4", VA = "0x7BBC3352D4")]
		public bool IsConfirmed()
		{
			return default(bool);
		}

		// Token: 0x06004C70 RID: 19568 RVA: 0x00016DA0 File Offset: 0x00014FA0
		[Token(Token = "0x6004C70")]
		[Address(RVA = "0x1B352DC", Offset = "0x1B352DC", VA = "0x7BBC3352DC")]
		public bool Send(EProtocol.Proto cmdType, ProtoReq message, byte regionID = 0)
		{
			return default(bool);
		}

		// Token: 0x06004C71 RID: 19569 RVA: 0x00016DB8 File Offset: 0x00014FB8
		[Token(Token = "0x6004C71")]
		[Address(RVA = "0x1B35360", Offset = "0x1B35360", VA = "0x7BBC335360")]
		public bool NeedLogout()
		{
			return default(bool);
		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x00016DD0 File Offset: 0x00014FD0
		[Token(Token = "0x6004C72")]
		[Address(RVA = "0x1B35368", Offset = "0x1B35368", VA = "0x7BBC335368")]
		public DisconnectedReason GetDisconnectionReason()
		{
			return DisconnectedReason.Unknown;
		}

		// Token: 0x06004C73 RID: 19571 RVA: 0x00016DE8 File Offset: 0x00014FE8
		[Token(Token = "0x6004C73")]
		[Address(RVA = "0x1B35370", Offset = "0x1B35370", VA = "0x7BBC335370", Slot = "11")]
		public virtual EServiceHandler GetServiceHandlerName()
		{
			return EServiceHandler.None;
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C74")]
		[Address(RVA = "0x1B35378", Offset = "0x1B35378", VA = "0x7BBC335378")]
		public void OnApplicationPause(bool paused)
		{
		}

		// Token: 0x0400740C RID: 29708
		[Token(Token = "0x400740C")]
		[FieldOffset(Offset = "0x10")]
		protected ServiceClient m_Client;

		// Token: 0x0400740D RID: 29709
		[Token(Token = "0x400740D")]
		[FieldOffset(Offset = "0x18")]
		protected string m_Addr;

		// Token: 0x0400740E RID: 29710
		[Token(Token = "0x400740E")]
		[FieldOffset(Offset = "0x20")]
		protected int m_Port;

		// Token: 0x0400740F RID: 29711
		[Token(Token = "0x400740F")]
		[FieldOffset(Offset = "0x24")]
		protected bool m_IsConfirmed;

		// Token: 0x04007410 RID: 29712
		[Token(Token = "0x4007410")]
		[FieldOffset(Offset = "0x28")]
		protected ServiceConnectionHandler.ReconnectInfo m_ReconnectInfo;

		// Token: 0x04007411 RID: 29713
		[Token(Token = "0x4007411")]
		[FieldOffset(Offset = "0x30")]
		protected bool m_NeedLogout;

		// Token: 0x04007412 RID: 29714
		[Token(Token = "0x4007412")]
		[FieldOffset(Offset = "0x34")]
		protected DisconnectedReason m_DisconnectByServerReason;

		// Token: 0x020012E2 RID: 4834
		[Token(Token = "0x20012E2")]
		protected class ReconnectInfo
		{
			// Token: 0x06004C75 RID: 19573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C75")]
			[Address(RVA = "0x1B3471C", Offset = "0x1B3471C", VA = "0x7BBC33471C")]
			public void TryReconnect()
			{
			}

			// Token: 0x06004C76 RID: 19574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C76")]
			[Address(RVA = "0x1B34B08", Offset = "0x1B34B08", VA = "0x7BBC334B08")]
			public void Reset(bool isDeep)
			{
			}

			// Token: 0x06004C77 RID: 19575 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C77")]
			[Address(RVA = "0x1B344BC", Offset = "0x1B344BC", VA = "0x7BBC3344BC")]
			public ReconnectInfo()
			{
			}

			// Token: 0x04007413 RID: 29715
			[Token(Token = "0x4007413")]
			[FieldOffset(Offset = "0x10")]
			public bool NeedReconnected;

			// Token: 0x04007414 RID: 29716
			[Token(Token = "0x4007414")]
			[FieldOffset(Offset = "0x14")]
			public float NextReconnectTime;

			// Token: 0x04007415 RID: 29717
			[Token(Token = "0x4007415")]
			[FieldOffset(Offset = "0x18")]
			public int ReconnectCount;
		}
	}
}
