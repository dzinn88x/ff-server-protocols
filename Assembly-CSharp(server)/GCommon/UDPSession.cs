using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using ICSharpCode.SharpZipLib.GZip;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FBD RID: 4029
	[Token(Token = "0x2000FBD")]
	public class UDPSession : NetworkSession
	{
		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06003AB5 RID: 15029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006EA")]
		public byte[] DecTempBuffer
		{
			[Token(Token = "0x6003AB5")]
			[Address(RVA = "0x2019298", Offset = "0x2019298", VA = "0x7BBC819298")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06003AB6 RID: 15030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006EB")]
		public TeaDecTempBuffer DecBuffer
		{
			[Token(Token = "0x6003AB6")]
			[Address(RVA = "0x2019290", Offset = "0x2019290", VA = "0x7BBC819290")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06003AB7 RID: 15031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006EC")]
		public byte[] EncTempBuffer
		{
			[Token(Token = "0x6003AB7")]
			[Address(RVA = "0x20196F4", Offset = "0x20196F4", VA = "0x7BBC8196F4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06003AB8 RID: 15032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006ED")]
		public TeaEncTempBuffer EncBuffer
		{
			[Token(Token = "0x6003AB8")]
			[Address(RVA = "0x20196EC", Offset = "0x20196EC", VA = "0x7BBC8196EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06003AB9 RID: 15033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006EE")]
		public byte[] ZipWorkingBuffer
		{
			[Token(Token = "0x6003AB9")]
			[Address(RVA = "0x2019208", Offset = "0x2019208", VA = "0x7BBC819208")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06003ABA RID: 15034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006EF")]
		public byte[] ZipOutputBuffer
		{
			[Token(Token = "0x6003ABA")]
			[Address(RVA = "0x2019180", Offset = "0x2019180", VA = "0x7BBC819180")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06003ABB RID: 15035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F0")]
		public GZipInputStream GZipInputStream
		{
			[Token(Token = "0x6003ABB")]
			[Address(RVA = "0x20190EC", Offset = "0x20190EC", VA = "0x7BBC8190EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ABC")]
		[Address(RVA = "0x201B830", Offset = "0x201B830", VA = "0x7BBC81B830")]
		public UDPSession([Optional] ISessionHanlder cb)
		{
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x000123F0 File Offset: 0x000105F0
		[Token(Token = "0x6003ABD")]
		[Address(RVA = "0x201BA7C", Offset = "0x201BA7C", VA = "0x7BBC81BA7C", Slot = "4")]
		public override bool IsConnected()
		{
			return default(bool);
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x00012408 File Offset: 0x00010608
		[Token(Token = "0x6003ABE")]
		[Address(RVA = "0x201BAB8", Offset = "0x201BAB8", VA = "0x7BBC81BAB8")]
		private bool CreateAndConnectSocket(IPEndPoint endPoint, bool isReconnect = false)
		{
			return default(bool);
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ABF")]
		[Address(RVA = "0x201BF0C", Offset = "0x201BF0C", VA = "0x7BBC81BF0C")]
		public void ForceToRecconnect()
		{
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x00012420 File Offset: 0x00010620
		[Token(Token = "0x6003AC0")]
		[Address(RVA = "0x201BFB0", Offset = "0x201BFB0", VA = "0x7BBC81BFB0")]
		private bool CheckReconnect()
		{
			return default(bool);
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AC1")]
		[Address(RVA = "0x201C10C", Offset = "0x201C10C", VA = "0x7BBC81C10C")]
		private void InvokeConnectionResult()
		{
		}

		// Token: 0x06003AC2 RID: 15042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AC2")]
		[Address(RVA = "0x201C1D8", Offset = "0x201C1D8", VA = "0x7BBC81C1D8")]
		private void UpdateSessionKey(string key)
		{
		}

		// Token: 0x06003AC3 RID: 15043 RVA: 0x00012438 File Offset: 0x00010638
		[Token(Token = "0x6003AC3")]
		[Address(RVA = "0x201C274", Offset = "0x201C274", VA = "0x7BBC81C274", Slot = "5")]
		protected override bool OnConnect(string serverAddr, int port)
		{
			return default(bool);
		}

		// Token: 0x06003AC4 RID: 15044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AC4")]
		[Address(RVA = "0x201C9C0", Offset = "0x201C9C0", VA = "0x7BBC81C9C0")]
		private void UpdateKeepAlive()
		{
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AC5")]
		[Address(RVA = "0x201CBD8", Offset = "0x201CBD8", VA = "0x7BBC81CBD8", Slot = "6")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06003AC6 RID: 15046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AC6")]
		[Address(RVA = "0x201D3C8", Offset = "0x201D3C8", VA = "0x7BBC81D3C8", Slot = "7")]
		protected override void OnClose()
		{
		}

		// Token: 0x06003AC7 RID: 15047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AC7")]
		[Address(RVA = "0x201C720", Offset = "0x201C720", VA = "0x7BBC81C720")]
		public void Send(uint cmd, byte[] data, int byteCount, byte sendOption = 0)
		{
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AC8")]
		[Address(RVA = "0x201D160", Offset = "0x201D160", VA = "0x7BBC81D160")]
		public void Resend(List<UDPMsgPacket> packets)
		{
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AC9")]
		[Address(RVA = "0x201D59C", Offset = "0x201D59C", VA = "0x7BBC81D59C")]
		public void GetUDPPackets(Queue<UDPMsgPacket> outPackets)
		{
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ACA")]
		[Address(RVA = "0x201D6EC", Offset = "0x201D6EC", VA = "0x7BBC81D6EC")]
		public void SetKeepAliveInterval(double interval)
		{
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ACB")]
		[Address(RVA = "0x201C610", Offset = "0x201C610", VA = "0x7BBC81C610")]
		private void CreateKeepAliveThread()
		{
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ACC")]
		[Address(RVA = "0x201D6F4", Offset = "0x201D6F4", VA = "0x7BBC81D6F4")]
		private void OnRecvDataThreadNoSleep()
		{
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ACD")]
		[Address(RVA = "0x201EF50", Offset = "0x201EF50", VA = "0x7BBC81EF50")]
		private void OnRecvDataThread()
		{
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ACE")]
		[Address(RVA = "0x20207B0", Offset = "0x20207B0", VA = "0x7BBC8207B0")]
		private void OnSendDataThread()
		{
		}

		// Token: 0x06003ACF RID: 15055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ACF")]
		[Address(RVA = "0x202143C", Offset = "0x202143C", VA = "0x7BBC82143C")]
		private void OnKeepAliveThread()
		{
		}

		// Token: 0x04004C52 RID: 19538
		[Token(Token = "0x4004C52")]
		private const int RECV_BUFF_SIZE = 512000;

		// Token: 0x04004C53 RID: 19539
		[Token(Token = "0x4004C53")]
		private const int SEND_BUFF_SIZE = 128000;

		// Token: 0x04004C54 RID: 19540
		[Token(Token = "0x4004C54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UdpClient m_UDPConnetion;

		// Token: 0x04004C55 RID: 19541
		[Token(Token = "0x4004C55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private IPEndPoint m_IPEndPoint;

		// Token: 0x04004C56 RID: 19542
		[Token(Token = "0x4004C56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Thread m_KeepAliveThread;

		// Token: 0x04004C57 RID: 19543
		[Token(Token = "0x4004C57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private AutoResetEvent m_KeepAliveSignalEvent;

		// Token: 0x04004C58 RID: 19544
		[Token(Token = "0x4004C58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private NetworkByteStream m_RecvBuffer;

		// Token: 0x04004C59 RID: 19545
		[Token(Token = "0x4004C59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private MemoryStream m_RecvMemoryStream;

		// Token: 0x04004C5A RID: 19546
		[Token(Token = "0x4004C5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Queue<UDPMsgPacket> m_RecvPacketQueue;

		// Token: 0x04004C5B RID: 19547
		[Token(Token = "0x4004C5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private LinkedList<UDPMsgPacket> m_PendingReliableRecvPacket;

		// Token: 0x04004C5C RID: 19548
		[Token(Token = "0x4004C5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private object m_HelloPacketLock;

		// Token: 0x04004C5D RID: 19549
		[Token(Token = "0x4004C5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private UDPSession.HelloData m_HelloPacket;

		// Token: 0x04004C5E RID: 19550
		[Token(Token = "0x4004C5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Queue<UDPMsgPacket> m_SendPacketQueue;

		// Token: 0x04004C5F RID: 19551
		[Token(Token = "0x4004C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private double m_KeepAliveInterval;

		// Token: 0x04004C60 RID: 19552
		[Token(Token = "0x4004C60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private double m_LastKeepAliveTime;

		// Token: 0x04004C61 RID: 19553
		[Token(Token = "0x4004C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private MemoryStream m_PingStream;

		// Token: 0x04004C62 RID: 19554
		[Token(Token = "0x4004C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private BinaryWriter m_PingBinaryWriter;

		// Token: 0x04004C63 RID: 19555
		[Token(Token = "0x4004C63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private C2S_UDP_Ping_Req m_PingKeepAliveMsg;

		// Token: 0x04004C64 RID: 19556
		[Token(Token = "0x4004C64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private double m_MaxDeactiveTime;

		// Token: 0x04004C65 RID: 19557
		[Token(Token = "0x4004C65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private object m_LastAliveTimeLock;

		// Token: 0x04004C66 RID: 19558
		[Token(Token = "0x4004C66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private double m_LastAliveTime;

		// Token: 0x04004C67 RID: 19559
		[Token(Token = "0x4004C67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private UDPReliableTracking m_ReliableTracking;

		// Token: 0x04004C68 RID: 19560
		[Token(Token = "0x4004C68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<UDPMsgPacket> m_PacketToResend;

		// Token: 0x04004C69 RID: 19561
		[Token(Token = "0x4004C69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private object m_SocketExceptionLock;

		// Token: 0x04004C6A RID: 19562
		[Token(Token = "0x4004C6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool m_IsSocketRaiseException;

		// Token: 0x04004C6B RID: 19563
		[Token(Token = "0x4004C6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		private bool m_NeedReconnectFlag;

		// Token: 0x04004C6C RID: 19564
		[Token(Token = "0x4004C6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private double m_ReconnectEndTime;

		// Token: 0x04004C6D RID: 19565
		[Token(Token = "0x4004C6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private string m_SessionKey;

		// Token: 0x04004C6E RID: 19566
		[Token(Token = "0x4004C6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool m_HasConnected;

		// Token: 0x04004C6F RID: 19567
		[Token(Token = "0x4004C6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private uint m_NextTrackingID;

		// Token: 0x04004C70 RID: 19568
		[Token(Token = "0x4004C70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DebugDropAll;

		// Token: 0x04004C71 RID: 19569
		[Token(Token = "0x4004C71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private byte[] m_DecTempBuffer;

		// Token: 0x04004C72 RID: 19570
		[Token(Token = "0x4004C72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private TeaDecTempBuffer m_DecBuffer;

		// Token: 0x04004C73 RID: 19571
		[Token(Token = "0x4004C73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private byte[] m_EncTempBuffer;

		// Token: 0x04004C74 RID: 19572
		[Token(Token = "0x4004C74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private TeaEncTempBuffer m_EncBuffer;

		// Token: 0x04004C75 RID: 19573
		[Token(Token = "0x4004C75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private byte[] m_ZipWorkingBuffer;

		// Token: 0x04004C76 RID: 19574
		[Token(Token = "0x4004C76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private byte[] m_ZipOutputBuffer;

		// Token: 0x04004C77 RID: 19575
		[Token(Token = "0x4004C77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private GZipInputStream m_GZipInputStream;

		// Token: 0x02000FBE RID: 4030
		[Token(Token = "0x2000FBE")]
		private class HelloData
		{
			// Token: 0x06003AD1 RID: 15057 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AD1")]
			[Address(RVA = "0x201BA74", Offset = "0x201BA74", VA = "0x7BBC81BA74")]
			public HelloData()
			{
			}

			// Token: 0x04004C78 RID: 19576
			[Token(Token = "0x4004C78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool HasNewConnectionResponse;

			// Token: 0x04004C79 RID: 19577
			[Token(Token = "0x4004C79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public UDPMessageIDReserved Cmd;

			// Token: 0x04004C7A RID: 19578
			[Token(Token = "0x4004C7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string SessionKey;
		}
	}
}
