using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001377 RID: 4983
	[Token(Token = "0x2001377")]
	public class GoliathFriendItemData
	{
		// Token: 0x06004FF6 RID: 20470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FF6")]
		[Address(RVA = "0x1D8DE38", Offset = "0x1D8DE38", VA = "0x7BBC58DE38")]
		public GoliathFriendItemData()
		{
		}

		// Token: 0x04007685 RID: 30341
		[Token(Token = "0x4007685")]
		[FieldOffset(Offset = "0x10")]
		public object FriendInfo;

		// Token: 0x04007686 RID: 30342
		[Token(Token = "0x4007686")]
		[FieldOffset(Offset = "0x18")]
		public ulong GroupID;

		// Token: 0x04007687 RID: 30343
		[Token(Token = "0x4007687")]
		[FieldOffset(Offset = "0x20")]
		public string CaptainNickname;

		// Token: 0x04007688 RID: 30344
		[Token(Token = "0x4007688")]
		[FieldOffset(Offset = "0x28")]
		public uint MemberCnt;
	}
}
