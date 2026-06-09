using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005F4 RID: 1524
	[Token(Token = "0x20005F4")]
	[ProtoContract]
	public class AnniversaryNodeClaimedIds
	{
		// Token: 0x06002374 RID: 9076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002374")]
		[Address(RVA = "0x21AEFB8", Offset = "0x21AEFB8", VA = "0x7BBC9AEFB8")]
		public AnniversaryNodeClaimedIds()
		{
		}

		// Token: 0x04001E7B RID: 7803
		[Token(Token = "0x4001E7B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106C70", Offset = "0x1106C70")]
		public uint[] ids;
	}
}
