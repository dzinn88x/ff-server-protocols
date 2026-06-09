using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009B3 RID: 2483
	[Token(Token = "0x20009B3")]
	[ProtoContract]
	public class CSClaimMVPProcessRewardsReq
	{
		// Token: 0x060026C1 RID: 9921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C1")]
		[Address(RVA = "0x21B0914", Offset = "0x21B0914", VA = "0x7BBC9B0914")]
		public CSClaimMVPProcessRewardsReq()
		{
		}

		// Token: 0x04002CAC RID: 11436
		[Token(Token = "0x4002CAC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A748", Offset = "0x111A748")]
		public uint process_id;
	}
}
