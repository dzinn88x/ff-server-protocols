using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CFE RID: 7422
	[Token(Token = "0x2001CFE")]
	public class RoomBlockManager : SingletonModule<RoomBlockManager>
	{
		// Token: 0x0600A1C9 RID: 41417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1C9")]
		[Address(RVA = "0x1B2E2AC", Offset = "0x1B2E2AC", VA = "0x7BBC32E2AC", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A1CA RID: 41418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1CA")]
		[Address(RVA = "0x1B2E2B0", Offset = "0x1B2E2B0", VA = "0x7BBC32E2B0", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A1CB RID: 41419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1CB")]
		[Address(RVA = "0x1B2E2B4", Offset = "0x1B2E2B4", VA = "0x7BBC32E2B4")]
		public void OnTicked(ulong roomid)
		{
		}

		// Token: 0x0600A1CC RID: 41420 RVA: 0x0002A798 File Offset: 0x00028998
		[Token(Token = "0x600A1CC")]
		[Address(RVA = "0x1B2E4F4", Offset = "0x1B2E4F4", VA = "0x7BBC32E4F4")]
		public bool CheckIsBlocked(ulong roomid)
		{
			return default(bool);
		}

		// Token: 0x0600A1CD RID: 41421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1CD")]
		[Address(RVA = "0x1B2E89C", Offset = "0x1B2E89C", VA = "0x7BBC32E89C")]
		public RoomBlockManager()
		{
		}

		// Token: 0x0400A82B RID: 43051
		[Token(Token = "0x400A82B")]
		private const string BLOCKED_ROOM_ID = "BLOCKED_ROOM_ID";

		// Token: 0x0400A82C RID: 43052
		[Token(Token = "0x400A82C")]
		private const string BLOCKED_ROOM_TIME = "BLOCKED_ROOM_TIME";

		// Token: 0x0400A82D RID: 43053
		[Token(Token = "0x400A82D")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<ulong, Dictionary<ulong, ulong>> m_AccountIdToRoomId;
	}
}
