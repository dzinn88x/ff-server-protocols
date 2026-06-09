using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200097B RID: 2427
	[Token(Token = "0x200097B")]
	[ProtoContract]
	public class CSGetBermudaInfoRes
	{
		// Token: 0x06002689 RID: 9865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002689")]
		[Address(RVA = "0x21B24B0", Offset = "0x21B24B0", VA = "0x7BBC9B24B0")]
		public CSGetBermudaInfoRes()
		{
		}

		// Token: 0x04002C1D RID: 11293
		[Token(Token = "0x4002C1D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119A28", Offset = "0x1119A28")]
		public List<BermudaRewardInfo> bermudaRewardInfo;
	}
}
