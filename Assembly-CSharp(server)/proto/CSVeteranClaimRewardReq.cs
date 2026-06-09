using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007B5 RID: 1973
	[Token(Token = "0x20007B5")]
	[ProtoContract]
	public class CSVeteranClaimRewardReq
	{
		// Token: 0x060024C4 RID: 9412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C4")]
		[Address(RVA = "0x21B7D5C", Offset = "0x21B7D5C", VA = "0x7BBC9B7D5C")]
		public CSVeteranClaimRewardReq()
		{
		}

		// Token: 0x040025E6 RID: 9702
		[Token(Token = "0x40025E6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EA4C", Offset = "0x110EA4C")]
		public uint reward_id;
	}
}
