using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001339 RID: 4921
	[Token(Token = "0x2001339")]
	public class AutoTaskRecommendFriend : AutoPopupTask
	{
		// Token: 0x06004E06 RID: 19974 RVA: 0x00017B80 File Offset: 0x00015D80
		[Token(Token = "0x6004E06")]
		[Address(RVA = "0x155B12C", Offset = "0x155B12C", VA = "0x7BBBD5B12C", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004E07 RID: 19975 RVA: 0x00017B98 File Offset: 0x00015D98
		[Token(Token = "0x6004E07")]
		[Address(RVA = "0x155B1D4", Offset = "0x155B1D4", VA = "0x7BBBD5B1D4", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004E08 RID: 19976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E08")]
		[Address(RVA = "0x155B1DC", Offset = "0x155B1DC", VA = "0x7BBBD5B1DC", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004E09 RID: 19977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E09")]
		[Address(RVA = "0x155B1E4", Offset = "0x155B1E4", VA = "0x7BBBD5B1E4")]
		public AutoTaskRecommendFriend()
		{
		}
	}
}
