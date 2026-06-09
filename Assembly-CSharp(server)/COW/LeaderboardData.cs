using System;
using COW.GamePlay;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014C5 RID: 5317
	[Token(Token = "0x20014C5")]
	internal class LeaderboardData
	{
		// Token: 0x06005A77 RID: 23159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A77")]
		[Address(RVA = "0x14002F4", Offset = "0x14002F4", VA = "0x7BBBC002F4")]
		public LeaderboardData()
		{
		}

		// Token: 0x04007D6A RID: 32106
		[Token(Token = "0x4007D6A")]
		[FieldOffset(Offset = "0x10")]
		public {QAb\u0082~u mPlayerId;

		// Token: 0x04007D6B RID: 32107
		[Token(Token = "0x4007D6B")]
		[FieldOffset(Offset = "0x28")]
		public bool mIsLocalPlayer;

		// Token: 0x04007D6C RID: 32108
		[Token(Token = "0x4007D6C")]
		[FieldOffset(Offset = "0x30")]
		public string mName;

		// Token: 0x04007D6D RID: 32109
		[Token(Token = "0x4007D6D")]
		[FieldOffset(Offset = "0x38")]
		public string mClan;

		// Token: 0x04007D6E RID: 32110
		[Token(Token = "0x4007D6E")]
		[FieldOffset(Offset = "0x40")]
		public int mKill;

		// Token: 0x04007D6F RID: 32111
		[Token(Token = "0x4007D6F")]
		[FieldOffset(Offset = "0x44")]
		public int mDead;

		// Token: 0x04007D70 RID: 32112
		[Token(Token = "0x4007D70")]
		[FieldOffset(Offset = "0x48")]
		public int mAssist;

		// Token: 0x04007D71 RID: 32113
		[Token(Token = "0x4007D71")]
		[FieldOffset(Offset = "0x4C")]
		public int mTotalDamage;
	}
}
