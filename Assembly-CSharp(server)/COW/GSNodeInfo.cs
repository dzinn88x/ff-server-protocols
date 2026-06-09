using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x02001E29 RID: 7721
	[Token(Token = "0x2001E29")]
	internal class GSNodeInfo
	{
		// Token: 0x0600A8CF RID: 43215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A8CF")]
		[Address(RVA = "0x18683A8", Offset = "0x18683A8", VA = "0x7BBC0683A8")]
		public static implicit operator AccountIDCPingInfo(GSNodeInfo info)
		{
			return null;
		}

		// Token: 0x0600A8D0 RID: 43216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8D0")]
		[Address(RVA = "0x1868470", Offset = "0x1868470", VA = "0x7BBC068470")]
		public GSNodeInfo()
		{
		}

		// Token: 0x0400AE2A RID: 44586
		[Token(Token = "0x400AE2A")]
		[FieldOffset(Offset = "0x10")]
		public string IDC;

		// Token: 0x0400AE2B RID: 44587
		[Token(Token = "0x400AE2B")]
		[FieldOffset(Offset = "0x18")]
		public int Ping_Time;

		// Token: 0x0400AE2C RID: 44588
		[Token(Token = "0x400AE2C")]
		[FieldOffset(Offset = "0x20")]
		public List<string> IP_List;
	}
}
