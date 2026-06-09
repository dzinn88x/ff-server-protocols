using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A64 RID: 2660
	[Token(Token = "0x2000A64")]
	[ProtoContract]
	public class AwakenTaskDesc
	{
		// Token: 0x0600276E RID: 10094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276E")]
		[Address(RVA = "0x21AF5D0", Offset = "0x21AF5D0", VA = "0x7BBC9AF5D0")]
		public AwakenTaskDesc()
		{
		}

		// Token: 0x040030A2 RID: 12450
		[Token(Token = "0x40030A2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121764", Offset = "0x1121764")]
		public uint id;

		// Token: 0x040030A3 RID: 12451
		[Token(Token = "0x40030A3")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121778", Offset = "0x1121778")]
		public uint task_type;

		// Token: 0x040030A4 RID: 12452
		[Token(Token = "0x40030A4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112178C", Offset = "0x112178C")]
		public uint task_value;

		// Token: 0x040030A5 RID: 12453
		[Token(Token = "0x40030A5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11217A0", Offset = "0x11217A0")]
		public List<AwardDesc> awards;

		// Token: 0x040030A6 RID: 12454
		[Token(Token = "0x40030A6")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11217B4", Offset = "0x11217B4")]
		public uint task_sub_value;
	}
}
