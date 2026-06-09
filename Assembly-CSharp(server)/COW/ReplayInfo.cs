using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020012B4 RID: 4788
	[Token(Token = "0x20012B4")]
	[Serializable]
	internal class ReplayInfo
	{
		// Token: 0x06004B0C RID: 19212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B0C")]
		[Address(RVA = "0x175A218", Offset = "0x175A218", VA = "0x7BBBF5A218")]
		public ReplayInfo()
		{
		}

		// Token: 0x04007330 RID: 29488
		[Token(Token = "0x4007330")]
		[FieldOffset(Offset = "0x10")]
		public ulong MatchID;

		// Token: 0x04007331 RID: 29489
		[Token(Token = "0x4007331")]
		[FieldOffset(Offset = "0x18")]
		public int PlayerCount;

		// Token: 0x04007332 RID: 29490
		[Token(Token = "0x4007332")]
		[FieldOffset(Offset = "0x20")]
		public string MatchDateTime;

		// Token: 0x04007333 RID: 29491
		[Token(Token = "0x4007333")]
		[FieldOffset(Offset = "0x28")]
		public float GameTotalTime;

		// Token: 0x04007334 RID: 29492
		[Token(Token = "0x4007334")]
		[FieldOffset(Offset = "0x2C")]
		public uint MapID;

		// Token: 0x04007335 RID: 29493
		[Token(Token = "0x4007335")]
		[FieldOffset(Offset = "0x30")]
		public uint MatchMode;

		// Token: 0x04007336 RID: 29494
		[Token(Token = "0x4007336")]
		[FieldOffset(Offset = "0x34")]
		public uint GameMode;

		// Token: 0x04007337 RID: 29495
		[Token(Token = "0x4007337")]
		[FieldOffset(Offset = "0x38")]
		public uint RoomType;

		// Token: 0x04007338 RID: 29496
		[Token(Token = "0x4007338")]
		[FieldOffset(Offset = "0x3C")]
		public uint GroupMode;

		// Token: 0x04007339 RID: 29497
		[Token(Token = "0x4007339")]
		[FieldOffset(Offset = "0x40")]
		public ulong RoomId;

		// Token: 0x0400733A RID: 29498
		[Token(Token = "0x400733A")]
		[FieldOffset(Offset = "0x48")]
		public string RoomName;

		// Token: 0x0400733B RID: 29499
		[Token(Token = "0x400733B")]
		[FieldOffset(Offset = "0x50")]
		public bool IsClientReplay;

		// Token: 0x0400733C RID: 29500
		[Token(Token = "0x400733C")]
		[FieldOffset(Offset = "0x58")]
		public string FileName;

		// Token: 0x0400733D RID: 29501
		[Token(Token = "0x400733D")]
		[FieldOffset(Offset = "0x60")]
		public List<ReplayEvent> Events;
	}
}
