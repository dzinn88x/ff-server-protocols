using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000996 RID: 2454
	[Token(Token = "0x2000996")]
	[ProtoContract]
	public class CSClaimSupercarRewardsRes
	{
		// Token: 0x060026A4 RID: 9892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A4")]
		[Address(RVA = "0x21B0944", Offset = "0x21B0944", VA = "0x7BBC9B0944")]
		public CSClaimSupercarRewardsRes()
		{
		}

		// Token: 0x04002C5D RID: 11357
		[Token(Token = "0x4002C5D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A018", Offset = "0x111A018")]
		public AwardDesc award;
	}
}
