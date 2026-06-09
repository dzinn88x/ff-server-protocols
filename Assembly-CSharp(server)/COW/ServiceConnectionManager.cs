using System;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x020012E4 RID: 4836
	[Token(Token = "0x20012E4")]
	internal class ServiceConnectionManager : SingletonModule<ServiceConnectionManager>
	{
		// Token: 0x06004C78 RID: 19576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C78")]
		[Address(RVA = "0x1B35390", Offset = "0x1B35390", VA = "0x7BBC335390", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C79")]
		[Address(RVA = "0x1B35394", Offset = "0x1B35394", VA = "0x7BBC335394", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06004C7A RID: 19578 RVA: 0x00016E00 File Offset: 0x00015000
		[Token(Token = "0x6004C7A")]
		[Address(RVA = "0x1B353FC", Offset = "0x1B353FC", VA = "0x7BBC3353FC")]
		public bool ConnectToLobbyService(string url)
		{
			return default(bool);
		}

		// Token: 0x06004C7B RID: 19579 RVA: 0x00016E18 File Offset: 0x00015018
		[Token(Token = "0x6004C7B")]
		[Address(RVA = "0x1B3556C", Offset = "0x1B3556C", VA = "0x7BBC33556C")]
		public bool ConnectToChatService(string url)
		{
			return default(bool);
		}

		// Token: 0x06004C7C RID: 19580 RVA: 0x00016E30 File Offset: 0x00015030
		[Token(Token = "0x6004C7C")]
		[Address(RVA = "0x1B356DC", Offset = "0x1B356DC", VA = "0x7BBC3356DC")]
		public bool IsServiceConnected()
		{
			return default(bool);
		}

		// Token: 0x06004C7D RID: 19581 RVA: 0x00016E48 File Offset: 0x00015048
		[Token(Token = "0x6004C7D")]
		[Address(RVA = "0x1B356FC", Offset = "0x1B356FC", VA = "0x7BBC3356FC")]
		public bool IsChatServiceConnected()
		{
			return default(bool);
		}

		// Token: 0x06004C7E RID: 19582 RVA: 0x00016E60 File Offset: 0x00015060
		[Token(Token = "0x6004C7E")]
		[Address(RVA = "0x1B35740", Offset = "0x1B35740", VA = "0x7BBC335740")]
		public bool SendMessageToLobby(EProtocol.Proto cmdType, uint subCmdType, object message, byte regionID = 0)
		{
			return default(bool);
		}

		// Token: 0x06004C7F RID: 19583 RVA: 0x00016E78 File Offset: 0x00015078
		[Token(Token = "0x6004C7F")]
		[Address(RVA = "0x1B35A54", Offset = "0x1B35A54", VA = "0x7BBC335A54")]
		public bool SendMessageToChatChannel(EProtocol.Proto cmdType, uint subCmdType, object message, byte regionID = 0)
		{
			return default(bool);
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C80")]
		[Address(RVA = "0x1B35B58", Offset = "0x1B35B58", VA = "0x7BBC335B58")]
		public void Update(float gameTime)
		{
		}

		// Token: 0x06004C81 RID: 19585 RVA: 0x00016E90 File Offset: 0x00015090
		[Token(Token = "0x6004C81")]
		[Address(RVA = "0x1B35BAC", Offset = "0x1B35BAC", VA = "0x7BBC335BAC")]
		public bool NeedLogout()
		{
			return default(bool);
		}

		// Token: 0x06004C82 RID: 19586 RVA: 0x00016EA8 File Offset: 0x000150A8
		[Token(Token = "0x6004C82")]
		[Address(RVA = "0x1B35BCC", Offset = "0x1B35BCC", VA = "0x7BBC335BCC")]
		public DisconnectedReason GetDisconnectionReason()
		{
			return DisconnectedReason.Unknown;
		}

		// Token: 0x06004C83 RID: 19587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C83")]
		[Address(RVA = "0x1B35398", Offset = "0x1B35398", VA = "0x7BBC335398")]
		public void Close()
		{
		}

		// Token: 0x06004C84 RID: 19588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C84")]
		[Address(RVA = "0x1B35BE4", Offset = "0x1B35BE4", VA = "0x7BBC335BE4")]
		public void DebugDisconnect()
		{
		}

		// Token: 0x06004C85 RID: 19589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C85")]
		[Address(RVA = "0x1B35C04", Offset = "0x1B35C04", VA = "0x7BBC335C04")]
		public void OnApplicationPause(bool paused)
		{
		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C86")]
		[Address(RVA = "0x1B35C64", Offset = "0x1B35C64", VA = "0x7BBC335C64")]
		public ServiceConnectionManager()
		{
		}

		// Token: 0x0400741A RID: 29722
		[Token(Token = "0x400741A")]
		[FieldOffset(Offset = "0x18")]
		private LobbyServiceConnectionHandler m_LobbyServiceConnection;

		// Token: 0x0400741B RID: 29723
		[Token(Token = "0x400741B")]
		[FieldOffset(Offset = "0x20")]
		private ChatServiceConnectionHandler m_ChatServiceConnection;
	}
}
