using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FA0 RID: 4000
	[Token(Token = "0x2000FA0")]
	internal class ServiceClient : NetworkClient, ISessionHanlder
	{
		// Token: 0x06003A3A RID: 14906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3A")]
		[Address(RVA = "0x2490764", Offset = "0x2490764", VA = "0x7BBCC90764")]
		public ServiceClient(string token, ISessionHanlder sessionHanlder)
		{
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3B")]
		[Address(RVA = "0x2490988", Offset = "0x2490988", VA = "0x7BBCC90988")]
		public void Update()
		{
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x00012060 File Offset: 0x00010260
		[Token(Token = "0x6003A3C")]
		[Address(RVA = "0x2490F6C", Offset = "0x2490F6C", VA = "0x7BBCC90F6C")]
		public bool Send(byte cmd, byte[] data, int byteCount, byte region)
		{
			return default(bool);
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3D")]
		[Address(RVA = "0x2491224", Offset = "0x2491224", VA = "0x7BBCC91224", Slot = "4")]
		public void OnConnected(bool result)
		{
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3E")]
		[Address(RVA = "0x249134C", Offset = "0x249134C", VA = "0x7BBCC9134C", Slot = "5")]
		public void OnDisconnected(DisconnectedReason reason)
		{
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3F")]
		[Address(RVA = "0x2491450", Offset = "0x2491450", VA = "0x7BBCC91450", Slot = "6")]
		public void OnPingSent(int lastSentTime)
		{
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A40")]
		[Address(RVA = "0x24909F4", Offset = "0x24909F4", VA = "0x7BBCC909F4")]
		private void HandleRecvPacket()
		{
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A41")]
		[Address(RVA = "0x2491678", Offset = "0x2491678", VA = "0x7BBCC91678")]
		public void OnApplicationPause(bool paused)
		{
		}

		// Token: 0x04004BCF RID: 19407
		[Token(Token = "0x4004BCF")]
		[FieldOffset(Offset = "0x20")]
		private TCPSession m_TCPSession;

		// Token: 0x04004BD0 RID: 19408
		[Token(Token = "0x4004BD0")]
		[FieldOffset(Offset = "0x28")]
		private Queue<TCPMsgPacket> m_RecvTCPMsgList;

		// Token: 0x04004BD1 RID: 19409
		[Token(Token = "0x4004BD1")]
		[FieldOffset(Offset = "0x30")]
		private ISessionHanlder m_SessionHandler;
	}
}
