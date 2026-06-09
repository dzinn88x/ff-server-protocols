using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F7E RID: 3966
	[Token(Token = "0x2000F7E")]
	public class NetworkClient
	{
		// Token: 0x060039CA RID: 14794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039CA")]
		[Address(RVA = "0x245DE24", Offset = "0x245DE24", VA = "0x7BBCC5DE24")]
		public void SetEnableSimpleInvokeExceptionInfo(bool b)
		{
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x00011E98 File Offset: 0x00010098
		[Token(Token = "0x60039CB")]
		[Address(RVA = "0x245DE64", Offset = "0x245DE64", VA = "0x7BBCC5DE64")]
		public bool Connect(string serverAddr, int port)
		{
			return default(bool);
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039CC")]
		[Address(RVA = "0x245DEFC", Offset = "0x245DEFC", VA = "0x7BBCC5DEFC")]
		public void Close(bool isSendNotification = true)
		{
		}

		// Token: 0x060039CD RID: 14797 RVA: 0x00011EB0 File Offset: 0x000100B0
		[Token(Token = "0x60039CD")]
		[Address(RVA = "0x245E258", Offset = "0x245E258", VA = "0x7BBCC5E258")]
		public bool IsConnected()
		{
			return default(bool);
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039CE")]
		public void RegisterHandler<T>(uint cmd, NetworkMessageDispatcher.NetworkMessageHandler<T> handler)
		{
		}

		// Token: 0x060039CF RID: 14799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039CF")]
		public void UnregisterHandler<T>(uint cmd, NetworkMessageDispatcher.NetworkMessageHandler<T> handler)
		{
		}

		// Token: 0x060039D0 RID: 14800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D0")]
		[Address(RVA = "0x245E270", Offset = "0x245E270", VA = "0x7BBCC5E270")]
		protected void RegisterSession(NetworkSession sess)
		{
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039D1")]
		[Address(RVA = "0x245E284", Offset = "0x245E284", VA = "0x7BBCC5E284")]
		public NetworkClient()
		{
		}

		// Token: 0x04004B50 RID: 19280
		[Token(Token = "0x4004B50")]
		[FieldOffset(Offset = "0x10")]
		protected NetworkSession m_Session;

		// Token: 0x04004B51 RID: 19281
		[Token(Token = "0x4004B51")]
		[FieldOffset(Offset = "0x18")]
		protected NetworkMessageDispatcher m_MessageDispatcher;
	}
}
