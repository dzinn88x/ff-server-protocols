using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F57 RID: 3927
	[Token(Token = "0x2000F57")]
	public class RemoteConsoleBase : MonoBehaviour
	{
		// Token: 0x060038CA RID: 14538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038CA")]
		[Address(RVA = "0x247BEC4", Offset = "0x247BEC4", VA = "0x7BBCC7BEC4")]
		private void Awake()
		{
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060038CB RID: 14539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D7")]
		public string LocalAddr
		{
			[Token(Token = "0x60038CB")]
			[Address(RVA = "0x247BFE4", Offset = "0x247BFE4", VA = "0x7BBCC7BFE4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060038CC RID: 14540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038CC")]
		[Address(RVA = "0x247C164", Offset = "0x247C164", VA = "0x7BBCC7C164")]
		public void InitRemoteConsoleServer()
		{
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038CD")]
		[Address(RVA = "0x247C190", Offset = "0x247C190", VA = "0x7BBCC7C190")]
		public void InitUDPClient()
		{
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038CE")]
		[Address(RVA = "0x247C4D4", Offset = "0x247C4D4", VA = "0x7BBCC7C4D4")]
		private void OnRecvDataThread()
		{
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038CF")]
		[Address(RVA = "0x247CD08", Offset = "0x247CD08", VA = "0x7BBCC7CD08")]
		public void UpdatePendingCommands()
		{
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D0")]
		[Address(RVA = "0x247CE6C", Offset = "0x247CE6C", VA = "0x7BBCC7CE6C")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D1")]
		[Address(RVA = "0x247CE9C", Offset = "0x247CE9C", VA = "0x7BBCC7CE9C")]
		private void OnDestory()
		{
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D2")]
		[Address(RVA = "0x247CEE4", Offset = "0x247CEE4", VA = "0x7BBCC7CEE4")]
		public void Send(string msg)
		{
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D3")]
		[Address(RVA = "0x247CC24", Offset = "0x247CC24", VA = "0x7BBCC7CC24")]
		private void ThreadSafeAddPendingCommand(string s)
		{
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D4")]
		[Address(RVA = "0x247CD0C", Offset = "0x247CD0C", VA = "0x7BBCC7CD0C")]
		private void ThreadSafeExecutePendingCommands()
		{
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D5")]
		[Address(RVA = "0x247CFB0", Offset = "0x247CFB0", VA = "0x7BBCC7CFB0", Slot = "4")]
		protected virtual void ExecuteCommand(string cmdline)
		{
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D6")]
		[Address(RVA = "0x247D2D8", Offset = "0x247D2D8", VA = "0x7BBCC7D2D8")]
		public string ExecuteCommandLocalCall(string cmd)
		{
			return null;
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D7")]
		[Address(RVA = "0x247D4E4", Offset = "0x247D4E4", VA = "0x7BBCC7D4E4")]
		public static string Echo(object o)
		{
			return null;
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D8")]
		[Address(RVA = "0x247D54C", Offset = "0x247D54C", VA = "0x7BBCC7D54C")]
		private static void ReceiveCallback(IAsyncResult ar)
		{
		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D9")]
		[Address(RVA = "0x247D8D8", Offset = "0x247D8D8", VA = "0x7BBCC7D8D8")]
		public void DefCommand(string cmdStr, RemoteConsoleBase.ConsoleCommand cmd, string description = "")
		{
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038DA")]
		[Address(RVA = "0x247D9A4", Offset = "0x247D9A4", VA = "0x7BBCC7D9A4", Slot = "5")]
		protected virtual void InitializeConsoleCommands()
		{
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038DB")]
		[Address(RVA = "0x247DB50", Offset = "0x247DB50", VA = "0x7BBCC7DB50")]
		private void CmdPing(string param)
		{
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038DC")]
		[Address(RVA = "0x247DBBC", Offset = "0x247DBBC", VA = "0x7BBCC7DBBC")]
		private void CmdList(string param)
		{
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038DD")]
		[Address(RVA = "0x247DD80", Offset = "0x247DD80", VA = "0x7BBCC7DD80")]
		private void CmdConnect(string param)
		{
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038DE")]
		[Address(RVA = "0x247DDEC", Offset = "0x247DDEC", VA = "0x7BBCC7DDEC")]
		private void CmdSetStatic(string param)
		{
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038DF")]
		[Address(RVA = "0x247E284", Offset = "0x247E284", VA = "0x7BBCC7E284")]
		private object ParseValue(Type fType, string valueStr)
		{
			return null;
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E0")]
		[Address(RVA = "0x247E898", Offset = "0x247E898", VA = "0x7BBCC7E898")]
		private void CmdCallStatic(string param)
		{
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060038E1 RID: 14561 RVA: 0x00011A48 File Offset: 0x0000FC48
		// (set) Token: 0x060038E2 RID: 14562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D8")]
		protected int PrintIndentLevel
		{
			[Token(Token = "0x60038E1")]
			[Address(RVA = "0x247EEA8", Offset = "0x247EEA8", VA = "0x7BBCC7EEA8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60038E2")]
			[Address(RVA = "0x247EEB0", Offset = "0x247EEB0", VA = "0x7BBCC7EEB0")]
			set
			{
			}
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E3")]
		[Address(RVA = "0x247EF80", Offset = "0x247EF80", VA = "0x7BBCC7EF80")]
		public void Print(string s)
		{
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E4")]
		[Address(RVA = "0x247F030", Offset = "0x247F030", VA = "0x7BBCC7F030")]
		public void PrintTransforms(Transform t, bool rec = true)
		{
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E5")]
		[Address(RVA = "0x247F360", Offset = "0x247F360", VA = "0x7BBCC7F360")]
		protected void PrintTransform(Transform t)
		{
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E6")]
		[Address(RVA = "0x247F488", Offset = "0x247F488", VA = "0x7BBCC7F488")]
		public RemoteConsoleBase()
		{
		}

		// Token: 0x04004AB9 RID: 19129
		[Token(Token = "0x4004AB9")]
		[FieldOffset(Offset = "0x0")]
		public static RemoteConsoleBase instance;

		// Token: 0x04004ABA RID: 19130
		[Token(Token = "0x4004ABA")]
		[FieldOffset(Offset = "0x18")]
		private UdpClient m_UDPClient;

		// Token: 0x04004ABB RID: 19131
		[Token(Token = "0x4004ABB")]
		[FieldOffset(Offset = "0x20")]
		public int m_LocalPort;

		// Token: 0x04004ABC RID: 19132
		[Token(Token = "0x4004ABC")]
		[FieldOffset(Offset = "0x28")]
		protected EndPoint m_ReceivedEP;

		// Token: 0x04004ABD RID: 19133
		[Token(Token = "0x4004ABD")]
		[FieldOffset(Offset = "0x30")]
		protected EndPoint m_RemoteEP;

		// Token: 0x04004ABE RID: 19134
		[Token(Token = "0x4004ABE")]
		[FieldOffset(Offset = "0x38")]
		private Thread m_RecvThread;

		// Token: 0x04004ABF RID: 19135
		[Token(Token = "0x4004ABF")]
		[FieldOffset(Offset = "0x40")]
		private byte[] mReceiveByteData;

		// Token: 0x04004AC0 RID: 19136
		[Token(Token = "0x4004AC0")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, RemoteConsoleBase.ConsoleCommand> m_ConsoleCommands;

		// Token: 0x04004AC1 RID: 19137
		[Token(Token = "0x4004AC1")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, string> m_ConsoleCommandsDesc;

		// Token: 0x04004AC2 RID: 19138
		[Token(Token = "0x4004AC2")]
		[FieldOffset(Offset = "0x58")]
		private NetworkByteStream m_RecvBuffer;

		// Token: 0x04004AC3 RID: 19139
		[Token(Token = "0x4004AC3")]
		[FieldOffset(Offset = "0x60")]
		private string ConnectCMD;

		// Token: 0x04004AC4 RID: 19140
		[Token(Token = "0x4004AC4")]
		[FieldOffset(Offset = "0x68")]
		private Socket mUDPServer;

		// Token: 0x04004AC5 RID: 19141
		[Token(Token = "0x4004AC5")]
		[FieldOffset(Offset = "0x70")]
		private StringBuilder m_LocalStream;

		// Token: 0x04004AC6 RID: 19142
		[Token(Token = "0x4004AC6")]
		[FieldOffset(Offset = "0x78")]
		private string m_LocalAddr;

		// Token: 0x04004AC7 RID: 19143
		[Token(Token = "0x4004AC7")]
		[FieldOffset(Offset = "0x80")]
		private List<string> _m_PendingCommands;

		// Token: 0x04004AC8 RID: 19144
		[Token(Token = "0x4004AC8")]
		[FieldOffset(Offset = "0x88")]
		protected string m_PrintIndent;

		// Token: 0x04004AC9 RID: 19145
		[Token(Token = "0x4004AC9")]
		[FieldOffset(Offset = "0x90")]
		protected int m_PrintIndentLevel;

		// Token: 0x02000F58 RID: 3928
		// (Invoke) Token: 0x060038E9 RID: 14569
		[Token(Token = "0x2000F58")]
		public delegate void ConsoleCommand(string param);
	}
}
