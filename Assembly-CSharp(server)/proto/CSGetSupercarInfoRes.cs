using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000994 RID: 2452
	[Token(Token = "0x2000994")]
	[ProtoContract]
	public class CSGetSupercarInfoRes
	{
		// Token: 0x060026A2 RID: 9890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A2")]
		[Address(RVA = "0x21B5E70", Offset = "0x21B5E70", VA = "0x7BBC9B5E70")]
		public CSGetSupercarInfoRes()
		{
		}

		// Token: 0x04002C53 RID: 11347
		[Token(Token = "0x4002C53")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119F50", Offset = "0x1119F50")]
		public uint car_id;

		// Token: 0x04002C54 RID: 11348
		[Token(Token = "0x4002C54")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119F64", Offset = "0x1119F64")]
		public uint exchange_tokens;

		// Token: 0x04002C55 RID: 11349
		[Token(Token = "0x4002C55")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119F78", Offset = "0x1119F78")]
		public uint rewarded_to;

		// Token: 0x04002C56 RID: 11350
		[Token(Token = "0x4002C56")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119F8C", Offset = "0x1119F8C")]
		public List<SupercarHelpPlayer> helpers;

		// Token: 0x04002C57 RID: 11351
		[Token(Token = "0x4002C57")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119FA0", Offset = "0x1119FA0")]
		public uint drive_sum;

		// Token: 0x04002C58 RID: 11352
		[Token(Token = "0x4002C58")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119FB4", Offset = "0x1119FB4")]
		public long update_time;

		// Token: 0x04002C59 RID: 11353
		[Token(Token = "0x4002C59")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119FC8", Offset = "0x1119FC8")]
		public long next_reset_time;
	}
}
