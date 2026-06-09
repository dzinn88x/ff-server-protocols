using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020015ED RID: 5613
	[Token(Token = "0x20015ED")]
	public class FMatchResultPlayerData
	{
		// Token: 0x060063AB RID: 25515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063AB")]
		[Address(RVA = "0x1B952E8", Offset = "0x1B952E8", VA = "0x7BBC3952E8")]
		public FMatchResultPlayerData()
		{
		}

		// Token: 0x04008279 RID: 33401
		[Token(Token = "0x4008279")]
		[FieldOffset(Offset = "0x10")]
		public ulong accountID;

		// Token: 0x0400827A RID: 33402
		[Token(Token = "0x400827A")]
		[FieldOffset(Offset = "0x18")]
		public uint likedCount;

		// Token: 0x0400827B RID: 33403
		[Token(Token = "0x400827B")]
		[FieldOffset(Offset = "0x1C")]
		public bool hasLike;

		// Token: 0x0400827C RID: 33404
		[Token(Token = "0x400827C")]
		[FieldOffset(Offset = "0x1D")]
		public bool isFriend;

		// Token: 0x0400827D RID: 33405
		[Token(Token = "0x400827D")]
		[FieldOffset(Offset = "0x1E")]
		public bool isSelf;

		// Token: 0x0400827E RID: 33406
		[Token(Token = "0x400827E")]
		[FieldOffset(Offset = "0x1F")]
		public bool hasAddFriend;

		// Token: 0x0400827F RID: 33407
		[Token(Token = "0x400827F")]
		[FieldOffset(Offset = "0x20")]
		public bool hasReport;
	}
}
