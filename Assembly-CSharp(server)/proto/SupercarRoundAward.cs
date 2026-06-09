using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B2D RID: 2861
	[Token(Token = "0x2000B2D")]
	[ProtoContract]
	public class SupercarRoundAward
	{
		// Token: 0x06002835 RID: 10293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002835")]
		[Address(RVA = "0x24A0BE0", Offset = "0x24A0BE0", VA = "0x7BBCCA0BE0")]
		public SupercarRoundAward()
		{
		}

		// Token: 0x04003651 RID: 13905
		[Token(Token = "0x4003651")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C77C", Offset = "0x112C77C")]
		public uint round_id;

		// Token: 0x04003652 RID: 13906
		[Token(Token = "0x4003652")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C790", Offset = "0x112C790")]
		public AwardDesc award;
	}
}
