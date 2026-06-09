using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A25 RID: 2597
	[Token(Token = "0x2000A25")]
	[ProtoContract]
	public class AttendanceDesc
	{
		// Token: 0x0600272F RID: 10031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272F")]
		[Address(RVA = "0x21AF288", Offset = "0x21AF288", VA = "0x7BBC9AF288")]
		public AttendanceDesc()
		{
		}

		// Token: 0x04002F52 RID: 12114
		[Token(Token = "0x4002F52")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F220", Offset = "0x111F220")]
		public uint id;

		// Token: 0x04002F53 RID: 12115
		[Token(Token = "0x4002F53")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F234", Offset = "0x111F234")]
		public uint index_id;

		// Token: 0x04002F54 RID: 12116
		[Token(Token = "0x4002F54")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F248", Offset = "0x111F248")]
		public List<AwardDesc> awards;

		// Token: 0x04002F55 RID: 12117
		[Token(Token = "0x4002F55")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F25C", Offset = "0x111F25C")]
		public uint weight;

		// Token: 0x04002F56 RID: 12118
		[Token(Token = "0x4002F56")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F270", Offset = "0x111F270")]
		public bool is_big_prize;
	}
}
