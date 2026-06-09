using System;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW
{
	// Token: 0x02001D39 RID: 7481
	[Token(Token = "0x2001D39")]
	public class ActivityClientInfo
	{
		// Token: 0x0600A2B0 RID: 41648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A2B0")]
		[Address(RVA = "0x1F9C418", Offset = "0x1F9C418", VA = "0x7BBC79C418")]
		public static implicit operator ActivityClientInfo(ActivityInfo activity)
		{
			return null;
		}

		// Token: 0x0600A2B1 RID: 41649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A2B1")]
		[Address(RVA = "0x1F9C4E0", Offset = "0x1F9C4E0", VA = "0x7BBC79C4E0")]
		public static implicit operator ActivityClientInfo(ActivityUpdateInfo activityUpdate)
		{
			return null;
		}

		// Token: 0x0600A2B2 RID: 41650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2B2")]
		[Address(RVA = "0x1F9C4D8", Offset = "0x1F9C4D8", VA = "0x7BBC79C4D8")]
		public ActivityClientInfo()
		{
		}

		// Token: 0x0400A933 RID: 43315
		[Token(Token = "0x400A933")]
		[FieldOffset(Offset = "0x10")]
		public uint id;

		// Token: 0x0400A934 RID: 43316
		[Token(Token = "0x400A934")]
		[FieldOffset(Offset = "0x14")]
		public uint data;

		// Token: 0x0400A935 RID: 43317
		[Token(Token = "0x400A935")]
		[FieldOffset(Offset = "0x18")]
		public proto.EActivity.State state;
	}
}
