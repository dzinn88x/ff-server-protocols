using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000763 RID: 1891
	[Token(Token = "0x2000763")]
	[ProtoContract]
	public class CSClaimCupRewardReq
	{
		// Token: 0x06002470 RID: 9328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002470")]
		[Address(RVA = "0x21B07A0", Offset = "0x21B07A0", VA = "0x7BBC9B07A0")]
		public CSClaimCupRewardReq()
		{
		}

		// Token: 0x04002518 RID: 9496
		[Token(Token = "0x4002518")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D624", Offset = "0x110D624")]
		public uint cup_type;

		// Token: 0x04002519 RID: 9497
		[Token(Token = "0x4002519")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D638", Offset = "0x110D638")]
		public uint cup_id;
	}
}
