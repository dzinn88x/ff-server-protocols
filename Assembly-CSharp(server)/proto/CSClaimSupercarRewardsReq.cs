using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000992 RID: 2450
	[Token(Token = "0x2000992")]
	[ProtoContract]
	public class CSClaimSupercarRewardsReq
	{
		// Token: 0x060026A0 RID: 9888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A0")]
		[Address(RVA = "0x21B093C", Offset = "0x21B093C", VA = "0x7BBC9B093C")]
		public CSClaimSupercarRewardsReq()
		{
		}

		// Token: 0x04002C4F RID: 11343
		[Token(Token = "0x4002C4F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119F00", Offset = "0x1119F00")]
		public uint round_num;
	}
}
