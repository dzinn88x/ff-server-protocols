using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200098A RID: 2442
	[Token(Token = "0x200098A")]
	[ProtoContract]
	public class CSClaimGoliathAFKGroupAwardsReq
	{
		// Token: 0x06002698 RID: 9880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002698")]
		[Address(RVA = "0x21B0834", Offset = "0x21B0834", VA = "0x7BBC9B0834")]
		public CSClaimGoliathAFKGroupAwardsReq()
		{
		}

		// Token: 0x04002C3A RID: 11322
		[Token(Token = "0x4002C3A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119CE4", Offset = "0x1119CE4")]
		public ulong group_id;

		// Token: 0x04002C3B RID: 11323
		[Token(Token = "0x4002C3B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119CF8", Offset = "0x1119CF8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1119CF8", Offset = "0x1119CF8")]
		public string language;
	}
}
