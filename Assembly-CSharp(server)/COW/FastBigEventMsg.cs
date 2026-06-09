using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001414 RID: 5140
	[Token(Token = "0x2001414")]
	public class FastBigEventMsg : FastMessage
	{
		// Token: 0x060054C1 RID: 21697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C1")]
		[Address(RVA = "0x1B955F8", Offset = "0x1B955F8", VA = "0x7BBC3955F8")]
		public FastBigEventMsg()
		{
		}

		// Token: 0x060054C2 RID: 21698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C2")]
		[Address(RVA = "0x1B9565C", Offset = "0x1B9565C", VA = "0x7BBC39565C")]
		public FastBigEventMsg(FastBigEventMsg template)
		{
		}

		// Token: 0x040079FD RID: 31229
		[Token(Token = "0x40079FD")]
		[FieldOffset(Offset = "0x18")]
		public ulong GroupID;

		// Token: 0x040079FE RID: 31230
		[Token(Token = "0x40079FE")]
		[FieldOffset(Offset = "0x20")]
		public string SelfNickname;

		// Token: 0x040079FF RID: 31231
		[Token(Token = "0x40079FF")]
		[FieldOffset(Offset = "0x28")]
		public string CaptainNickname;

		// Token: 0x04007A00 RID: 31232
		[Token(Token = "0x4007A00")]
		[FieldOffset(Offset = "0x30")]
		public uint MemberCnt;
	}
}
