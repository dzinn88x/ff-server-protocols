using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C8F RID: 7311
	[Token(Token = "0x2001C8F")]
	public enum SubscriptionStatus
	{
		// Token: 0x0400A64D RID: 42573
		[Token(Token = "0x400A64D")]
		None = -1,
		// Token: 0x0400A64E RID: 42574
		[Token(Token = "0x400A64E")]
		Active,
		// Token: 0x0400A64F RID: 42575
		[Token(Token = "0x400A64F")]
		Expired,
		// Token: 0x0400A650 RID: 42576
		[Token(Token = "0x400A650")]
		Cancelled,
		// Token: 0x0400A651 RID: 42577
		[Token(Token = "0x400A651")]
		Revoked,
		// Token: 0x0400A652 RID: 42578
		[Token(Token = "0x400A652")]
		Transferred,
		// Token: 0x0400A653 RID: 42579
		[Token(Token = "0x400A653")]
		Scheduled
	}
}
