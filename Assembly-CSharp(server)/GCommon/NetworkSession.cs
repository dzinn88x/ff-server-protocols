using System;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F97 RID: 3991
	[Token(Token = "0x2000F97")]
	public class NetworkSession
	{
		// Token: 0x06003A1A RID: 14874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A1A")]
		[Address(RVA = "0x246798C", Offset = "0x246798C", VA = "0x7BBCC6798C")]
		public NetworkSession([Optional] ISessionHanlder cb)
		{
		}

		// Token: 0x06003A1B RID: 14875 RVA: 0x00011F88 File Offset: 0x00010188
		[Token(Token = "0x6003A1B")]
		[Address(RVA = "0x2467A18", Offset = "0x2467A18", VA = "0x7BBCC67A18", Slot = "4")]
		public virtual bool IsConnected()
		{
			return default(bool);
		}

		// Token: 0x06003A1C RID: 14876 RVA: 0x00011FA0 File Offset: 0x000101A0
		[Token(Token = "0x6003A1C")]
		[Address(RVA = "0x245DEF0", Offset = "0x245DEF0", VA = "0x7BBCC5DEF0")]
		public bool Connect(string serverAddr, int port)
		{
			return default(bool);
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A1D")]
		[Address(RVA = "0x2467A28", Offset = "0x2467A28", VA = "0x7BBCC67A28")]
		public void Update()
		{
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A1E")]
		[Address(RVA = "0x245DF10", Offset = "0x245DF10", VA = "0x7BBCC5DF10")]
		public void Close(bool isSendNotification = true)
		{
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A1F")]
		[Address(RVA = "0x2467B60", Offset = "0x2467B60", VA = "0x7BBCC67B60")]
		protected void RequestCloseSession(DisconnectedReason reason = DisconnectedReason.Unknown)
		{
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x00011FB8 File Offset: 0x000101B8
		[Token(Token = "0x6003A20")]
		[Address(RVA = "0x2467C64", Offset = "0x2467C64", VA = "0x7BBCC67C64", Slot = "5")]
		protected virtual bool OnConnect(string serverAddr, int port)
		{
			return default(bool);
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A21")]
		[Address(RVA = "0x2467C6C", Offset = "0x2467C6C", VA = "0x7BBCC67C6C", Slot = "6")]
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A22")]
		[Address(RVA = "0x2467C70", Offset = "0x2467C70", VA = "0x7BBCC67C70", Slot = "7")]
		protected virtual void OnClose()
		{
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A23")]
		[Address(RVA = "0x2467C74", Offset = "0x2467C74", VA = "0x7BBCC67C74")]
		protected void CreateRecvThread(ThreadStart threadFunc)
		{
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A24")]
		[Address(RVA = "0x2467D5C", Offset = "0x2467D5C", VA = "0x7BBCC67D5C")]
		protected void CreateSendThread(ThreadStart threadFunc)
		{
		}

		// Token: 0x04004BAD RID: 19373
		[Token(Token = "0x4004BAD")]
		protected const int CONNECT_NONE = 1;

		// Token: 0x04004BAE RID: 19374
		[Token(Token = "0x4004BAE")]
		protected const int CONNECT_PENDING = 2;

		// Token: 0x04004BAF RID: 19375
		[Token(Token = "0x4004BAF")]
		protected const int CONNECT_OK = 3;

		// Token: 0x04004BB0 RID: 19376
		[Token(Token = "0x4004BB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected int m_ConnectState;

		// Token: 0x04004BB1 RID: 19377
		[Token(Token = "0x4004BB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected bool m_Closed;

		// Token: 0x04004BB2 RID: 19378
		[Token(Token = "0x4004BB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int m_JoinTimeout;

		// Token: 0x04004BB3 RID: 19379
		[Token(Token = "0x4004BB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ISessionHanlder m_SessionHandler;

		// Token: 0x04004BB4 RID: 19380
		[Token(Token = "0x4004BB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Thread m_SendThread;

		// Token: 0x04004BB5 RID: 19381
		[Token(Token = "0x4004BB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Thread m_RecvThread;

		// Token: 0x04004BB6 RID: 19382
		[Token(Token = "0x4004BB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected AutoResetEvent m_SendSignalEvent;

		// Token: 0x04004BB7 RID: 19383
		[Token(Token = "0x4004BB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected AutoResetEvent m_RecvSignalEvent;

		// Token: 0x04004BB8 RID: 19384
		[Token(Token = "0x4004BB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected AutoResetEvent m_NotifySendEvent;

		// Token: 0x04004BB9 RID: 19385
		[Token(Token = "0x4004BB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected object m_CloseRequiredLock;

		// Token: 0x04004BBA RID: 19386
		[Token(Token = "0x4004BBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected bool m_HasCloseRequired;

		// Token: 0x04004BBB RID: 19387
		[Token(Token = "0x4004BBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		protected DisconnectedReason m_DisconnectedReason;
	}
}
