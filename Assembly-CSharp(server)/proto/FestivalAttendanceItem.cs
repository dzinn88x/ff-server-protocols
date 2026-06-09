using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007BE RID: 1982
	[Token(Token = "0x20007BE")]
	[ProtoContract]
	public class FestivalAttendanceItem
	{
		// Token: 0x060024CD RID: 9421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CD")]
		[Address(RVA = "0x21BA3B4", Offset = "0x21BA3B4", VA = "0x7BBC9BA3B4")]
		public FestivalAttendanceItem()
		{
		}

		// Token: 0x04002601 RID: 9729
		[Token(Token = "0x4002601")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EE0C", Offset = "0x110EE0C")]
		public uint id;

		// Token: 0x04002602 RID: 9730
		[Token(Token = "0x4002602")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EE20", Offset = "0x110EE20")]
		public uint signed;

		// Token: 0x04002603 RID: 9731
		[Token(Token = "0x4002603")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EE34", Offset = "0x110EE34")]
		public List<AwardDesc> awards;

		// Token: 0x04002604 RID: 9732
		[Token(Token = "0x4002604")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EE48", Offset = "0x110EE48")]
		public uint drop_max_num;
	}
}
