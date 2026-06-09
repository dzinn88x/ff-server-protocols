using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A85 RID: 2693
	[Token(Token = "0x2000A85")]
	[ProtoContract]
	public class ChallengeCondition
	{
		// Token: 0x0600278F RID: 10127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278F")]
		[Address(RVA = "0x21B7EB8", Offset = "0x21B7EB8", VA = "0x7BBC9B7EB8")]
		public ChallengeCondition()
		{
		}

		// Token: 0x04003182 RID: 12674
		[Token(Token = "0x4003182")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122E70", Offset = "0x1122E70")]
		public uint condition;

		// Token: 0x04003183 RID: 12675
		[Token(Token = "0x4003183")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122E84", Offset = "0x1122E84")]
		public uint target_value;

		// Token: 0x04003184 RID: 12676
		[Token(Token = "0x4003184")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122E98", Offset = "0x1122E98")]
		public uint[] sub_condition;
	}
}
