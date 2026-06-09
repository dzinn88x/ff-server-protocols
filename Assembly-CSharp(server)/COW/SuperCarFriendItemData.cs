using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020013BD RID: 5053
	[Token(Token = "0x20013BD")]
	public class SuperCarFriendItemData
	{
		// Token: 0x0600526B RID: 21099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600526B")]
		[Address(RVA = "0x1B41A64", Offset = "0x1B41A64", VA = "0x7BBC341A64")]
		public SuperCarFriendItemData()
		{
		}

		// Token: 0x0400786B RID: 30827
		[Token(Token = "0x400786B")]
		[FieldOffset(Offset = "0x10")]
		public object FriendInfo;

		// Token: 0x0400786C RID: 30828
		[Token(Token = "0x400786C")]
		[FieldOffset(Offset = "0x18")]
		public ulong GroupID;

		// Token: 0x0400786D RID: 30829
		[Token(Token = "0x400786D")]
		[FieldOffset(Offset = "0x20")]
		public string CaptainNickname;

		// Token: 0x0400786E RID: 30830
		[Token(Token = "0x400786E")]
		[FieldOffset(Offset = "0x28")]
		public uint MemberCnt;

		// Token: 0x0400786F RID: 30831
		[Token(Token = "0x400786F")]
		[FieldOffset(Offset = "0x2C")]
		public bool Inviteable;

		// Token: 0x04007870 RID: 30832
		[Token(Token = "0x4007870")]
		[FieldOffset(Offset = "0x30")]
		public UIModelSuperCar.EFriendCategory FriendCategory;
	}
}
