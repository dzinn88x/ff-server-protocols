using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A2E RID: 2606
	[Token(Token = "0x2000A2E")]
	[ProtoContract]
	public class FestivalAttendanceDesc
	{
		// Token: 0x06002738 RID: 10040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002738")]
		[Address(RVA = "0x21BA340", Offset = "0x21BA340", VA = "0x7BBC9BA340")]
		public FestivalAttendanceDesc()
		{
		}

		// Token: 0x04002F90 RID: 12176
		[Token(Token = "0x4002F90")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FA40", Offset = "0x111FA40")]
		public uint id;

		// Token: 0x04002F91 RID: 12177
		[Token(Token = "0x4002F91")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FA54", Offset = "0x111FA54")]
		public uint index_id;

		// Token: 0x04002F92 RID: 12178
		[Token(Token = "0x4002F92")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FA68", Offset = "0x111FA68")]
		public List<AwardDesc> awards;

		// Token: 0x04002F93 RID: 12179
		[Token(Token = "0x4002F93")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FA7C", Offset = "0x111FA7C")]
		public uint free_max_num;

		// Token: 0x04002F94 RID: 12180
		[Token(Token = "0x4002F94")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FA90", Offset = "0x111FA90")]
		public uint drop_max_num;
	}
}
