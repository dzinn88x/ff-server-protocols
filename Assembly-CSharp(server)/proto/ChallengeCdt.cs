using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000891 RID: 2193
	[Token(Token = "0x2000891")]
	[ProtoContract]
	public class ChallengeCdt
	{
		// Token: 0x0600259F RID: 9631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259F")]
		[Address(RVA = "0x21B7EB0", Offset = "0x21B7EB0", VA = "0x7BBC9B7EB0")]
		public ChallengeCdt()
		{
		}

		// Token: 0x040028E3 RID: 10467
		[Token(Token = "0x40028E3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113C2C", Offset = "0x1113C2C")]
		public EPChallenge_Condition_Type condition_type;

		// Token: 0x040028E4 RID: 10468
		[Token(Token = "0x40028E4")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113C40", Offset = "0x1113C40")]
		public uint current_value;

		// Token: 0x040028E5 RID: 10469
		[Token(Token = "0x40028E5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113C54", Offset = "0x1113C54")]
		public uint target_value;

		// Token: 0x040028E6 RID: 10470
		[Token(Token = "0x40028E6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113C68", Offset = "0x1113C68")]
		public uint[] sub_condition;
	}
}
