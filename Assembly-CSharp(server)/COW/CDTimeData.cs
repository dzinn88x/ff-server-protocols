using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C96 RID: 7318
	[Token(Token = "0x2001C96")]
	public class CDTimeData
	{
		// Token: 0x06009FB7 RID: 40887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FB7")]
		[Address(RVA = "0x14E8EF0", Offset = "0x14E8EF0", VA = "0x7BBBCE8EF0")]
		public CDTimeData(ulong _RequestTime, int _CdSecond)
		{
		}

		// Token: 0x06009FB8 RID: 40888 RVA: 0x00029BF8 File Offset: 0x00027DF8
		[Token(Token = "0x6009FB8")]
		[Address(RVA = "0x14E8F2C", Offset = "0x14E8F2C", VA = "0x7BBBCE8F2C")]
		public bool CheckOutofCd()
		{
			return default(bool);
		}

		// Token: 0x0400A675 RID: 42613
		[Token(Token = "0x400A675")]
		[FieldOffset(Offset = "0x10")]
		public ulong RequestTime;

		// Token: 0x0400A676 RID: 42614
		[Token(Token = "0x400A676")]
		[FieldOffset(Offset = "0x18")]
		public int CdSecond;
	}
}
