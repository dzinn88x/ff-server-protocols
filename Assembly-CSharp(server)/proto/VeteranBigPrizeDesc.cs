using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A2C RID: 2604
	[Token(Token = "0x2000A2C")]
	[ProtoContract]
	public class VeteranBigPrizeDesc
	{
		// Token: 0x06002736 RID: 10038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002736")]
		[Address(RVA = "0x24A14AC", Offset = "0x24A14AC", VA = "0x7BBCCA14AC")]
		public VeteranBigPrizeDesc()
		{
		}

		// Token: 0x04002F81 RID: 12161
		[Token(Token = "0x4002F81")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F734", Offset = "0x111F734")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F734", Offset = "0x111F734")]
		public string region;

		// Token: 0x04002F82 RID: 12162
		[Token(Token = "0x4002F82")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F784", Offset = "0x111F784")]
		public uint big_prize_id;

		// Token: 0x04002F83 RID: 12163
		[Token(Token = "0x4002F83")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F798", Offset = "0x111F798")]
		public uint veteran_class;

		// Token: 0x04002F84 RID: 12164
		[Token(Token = "0x4002F84")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F7AC", Offset = "0x111F7AC")]
		public uint big_prize_demand;

		// Token: 0x04002F85 RID: 12165
		[Token(Token = "0x4002F85")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F7C0", Offset = "0x111F7C0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F7C0", Offset = "0x111F7C0")]
		public string cdn_url;

		// Token: 0x04002F86 RID: 12166
		[Token(Token = "0x4002F86")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F810", Offset = "0x111F810")]
		public List<AwardDesc> awards;

		// Token: 0x04002F87 RID: 12167
		[Token(Token = "0x4002F87")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F824", Offset = "0x111F824")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F824", Offset = "0x111F824")]
		public string language;
	}
}
