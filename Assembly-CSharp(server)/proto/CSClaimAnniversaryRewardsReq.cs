using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200094E RID: 2382
	[Token(Token = "0x200094E")]
	[ProtoContract]
	public class CSClaimAnniversaryRewardsReq
	{
		// Token: 0x0600265C RID: 9820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265C")]
		[Address(RVA = "0x21B0760", Offset = "0x21B0760", VA = "0x7BBC9B0760")]
		public CSClaimAnniversaryRewardsReq()
		{
		}

		// Token: 0x04002BC1 RID: 11201
		[Token(Token = "0x4002BC1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11191F4", Offset = "0x11191F4")]
		public uint[] node_ids;
	}
}
