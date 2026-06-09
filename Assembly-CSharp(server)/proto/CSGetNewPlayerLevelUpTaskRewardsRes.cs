using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007B3 RID: 1971
	[Token(Token = "0x20007B3")]
	[ProtoContract]
	public class CSGetNewPlayerLevelUpTaskRewardsRes
	{
		// Token: 0x060024C2 RID: 9410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C2")]
		[Address(RVA = "0x21B4F58", Offset = "0x21B4F58", VA = "0x7BBC9B4F58")]
		public CSGetNewPlayerLevelUpTaskRewardsRes()
		{
		}

		// Token: 0x040025E3 RID: 9699
		[Token(Token = "0x40025E3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EA10", Offset = "0x110EA10")]
		public AwardData awards;
	}
}
