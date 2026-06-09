using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FA9 RID: 4009
	[Token(Token = "0x2000FA9")]
	public class TCPSession : NetworkSession
	{
		// Token: 0x06003A50 RID: 14928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A50")]
		[Address(RVA = "0x249081C", Offset = "0x249081C", VA = "0x7BBCC9081C")]
		public TCPSession(string token, [Optional] ISessionHanlder cb)
		{
		}

		// Token: 0x06003A51 RID: 14929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A51")]
		[Address(RVA = "0x2495C58", Offset = "0x2495C58", VA = "0x7BBCC95C58")]
		private AesManaged CreateAes()
		{
			return null;
		}

		// Token: 0x06003A52 RID: 14930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A52")]
		[Address(RVA = "0x2491520", Offset = "0x2491520", VA = "0x7BBCC91520")]
		public void GetTCPPackets(Queue<TCPMsgPacket> outPackets)
		{
		}

		// Token: 0x06003A53 RID: 14931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A53")]
		[Address(RVA = "0x2490FF4", Offset = "0x2490FF4", VA = "0x7BBCC90FF4")]
		public void Send(byte cmd, byte[] data, int byteCount, byte region)
		{
		}

		// Token: 0x06003A54 RID: 14932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A54")]
		[Address(RVA = "0x2496578", Offset = "0x2496578", VA = "0x7BBCC96578")]
		private void CreateHeartBeatThread()
		{
		}

		// Token: 0x06003A55 RID: 14933 RVA: 0x00012090 File Offset: 0x00010290
		[Token(Token = "0x6003A55")]
		[Address(RVA = "0x2496688", Offset = "0x2496688", VA = "0x7BBCC96688", Slot = "5")]
		protected override bool OnConnect(string serverAddr, int port)
		{
			return default(bool);
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A56")]
		[Address(RVA = "0x2496B88", Offset = "0x2496B88", VA = "0x7BBCC96B88", Slot = "6")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06003A57 RID: 14935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A57")]
		[Address(RVA = "0x2496E24", Offset = "0x2496E24", VA = "0x7BBCC96E24", Slot = "7")]
		protected override void OnClose()
		{
		}

		// Token: 0x06003A58 RID: 14936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A58")]
		[Address(RVA = "0x2496FEC", Offset = "0x2496FEC", VA = "0x7BBCC96FEC")]
		private void OnConnected(IAsyncResult ar)
		{
		}

		// Token: 0x06003A59 RID: 14937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A59")]
		[Address(RVA = "0x2497338", Offset = "0x2497338", VA = "0x7BBCC97338")]
		private void OnRecvDataThread()
		{
		}

		// Token: 0x06003A5A RID: 14938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A5A")]
		[Address(RVA = "0x2497F5C", Offset = "0x2497F5C", VA = "0x7BBCC97F5C")]
		private void OnSendDataThread()
		{
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A5B")]
		[Address(RVA = "0x24985D8", Offset = "0x24985D8", VA = "0x7BBCC985D8")]
		private void OnKeepAliveThread()
		{
		}

		// Token: 0x06003A5C RID: 14940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A5C")]
		[Address(RVA = "0x249168C", Offset = "0x249168C", VA = "0x7BBCC9168C")]
		public void OnApplicationPause(bool paused)
		{
		}

		// Token: 0x06003A5D RID: 14941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A5D")]
		[Address(RVA = "0x249626C", Offset = "0x249626C", VA = "0x7BBCC9626C")]
		public byte[] Encrypt(AesManaged aes, byte[] data)
		{
			return null;
		}

		// Token: 0x06003A5E RID: 14942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A5E")]
		[Address(RVA = "0x2498B4C", Offset = "0x2498B4C", VA = "0x7BBCC98B4C")]
		public byte[] Decrypt(AesManaged aes, byte[] data)
		{
			return null;
		}

		// Token: 0x04004BE9 RID: 19433
		[Token(Token = "0x4004BE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TcpClient m_TCPConnection;

		// Token: 0x04004BEA RID: 19434
		[Token(Token = "0x4004BEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private NetworkByteStream m_RecvBuffer;

		// Token: 0x04004BEB RID: 19435
		[Token(Token = "0x4004BEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private MemoryStream m_RecvRemainingBuffer;

		// Token: 0x04004BEC RID: 19436
		[Token(Token = "0x4004BEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private object m_ConnectedRetRequiredLock;

		// Token: 0x04004BED RID: 19437
		[Token(Token = "0x4004BED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_HasConnectedRetRequired;

		// Token: 0x04004BEE RID: 19438
		[Token(Token = "0x4004BEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private double m_KeepAliveInterval;

		// Token: 0x04004BEF RID: 19439
		[Token(Token = "0x4004BEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private double m_MaxDeactiveTime;

		// Token: 0x04004BF0 RID: 19440
		[Token(Token = "0x4004BF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private object m_LastAliveTimeLock;

		// Token: 0x04004BF1 RID: 19441
		[Token(Token = "0x4004BF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private double m_LastAliveTime;

		// Token: 0x04004BF2 RID: 19442
		[Token(Token = "0x4004BF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Thread m_KeepAliveThread;

		// Token: 0x04004BF3 RID: 19443
		[Token(Token = "0x4004BF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AutoResetEvent m_KeepAliveSignalEvent;

		// Token: 0x04004BF4 RID: 19444
		[Token(Token = "0x4004BF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int m_ReceiveBufferSize;

		// Token: 0x04004BF5 RID: 19445
		[Token(Token = "0x4004BF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int m_SendBufferSize;

		// Token: 0x04004BF6 RID: 19446
		[Token(Token = "0x4004BF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string m_Token;

		// Token: 0x04004BF7 RID: 19447
		[Token(Token = "0x4004BF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Queue<TCPMsgPacket> m_SendPacketQueue;

		// Token: 0x04004BF8 RID: 19448
		[Token(Token = "0x4004BF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Queue<TCPMsgPacket> m_RecvPacketQueue;

		// Token: 0x04004BF9 RID: 19449
		[Token(Token = "0x4004BF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_ServerConfirmed;

		// Token: 0x04004BFA RID: 19450
		[Token(Token = "0x4004BFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		private bool m_IsPaused;

		// Token: 0x04004BFB RID: 19451
		[Token(Token = "0x4004BFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private double m_LastPausedTime;

		// Token: 0x04004BFC RID: 19452
		[Token(Token = "0x4004BFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private double m_MaxBackgroundDeactiveTime;

		// Token: 0x04004BFD RID: 19453
		[Token(Token = "0x4004BFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool m_IsInBackGround;

		// Token: 0x04004BFE RID: 19454
		[Token(Token = "0x4004BFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private AesManaged m_Aes;
	}
}
