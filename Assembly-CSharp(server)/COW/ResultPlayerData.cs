using System;
using COW.GamePlay;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001FF8 RID: 8184
	[Token(Token = "0x2001FF8")]
	internal class ResultPlayerData
	{
		// Token: 0x0600B602 RID: 46594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B602")]
		[Address(RVA = "0x175D8FC", Offset = "0x175D8FC", VA = "0x7BBBF5D8FC")]
		public ResultPlayerData()
		{
		}

		// Token: 0x0400B844 RID: 47172
		[Token(Token = "0x400B844")]
		[FieldOffset(Offset = "0x10")]
		public ulong userId;

		// Token: 0x0400B845 RID: 47173
		[Token(Token = "0x400B845")]
		[FieldOffset(Offset = "0x18")]
		public string nickname;

		// Token: 0x0400B846 RID: 47174
		[Token(Token = "0x400B846")]
		[FieldOffset(Offset = "0x20")]
		public uint kill;

		// Token: 0x0400B847 RID: 47175
		[Token(Token = "0x400B847")]
		[FieldOffset(Offset = "0x24")]
		public uint deadCnt;

		// Token: 0x0400B848 RID: 47176
		[Token(Token = "0x400B848")]
		[FieldOffset(Offset = "0x28")]
		public uint assistCnt;

		// Token: 0x0400B849 RID: 47177
		[Token(Token = "0x400B849")]
		[FieldOffset(Offset = "0x2C")]
		public uint damage;

		// Token: 0x0400B84A RID: 47178
		[Token(Token = "0x400B84A")]
		[FieldOffset(Offset = "0x30")]
		public int factionId;

		// Token: 0x0400B84B RID: 47179
		[Token(Token = "0x400B84B")]
		[FieldOffset(Offset = "0x34")]
		public int score;

		// Token: 0x0400B84C RID: 47180
		[Token(Token = "0x400B84C")]
		[FieldOffset(Offset = "0x38")]
		public {QAb\u0082~u player_id;
	}
}
