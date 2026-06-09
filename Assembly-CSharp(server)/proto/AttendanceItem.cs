using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007BD RID: 1981
	[Token(Token = "0x20007BD")]
	[ProtoContract]
	public class AttendanceItem
	{
		// Token: 0x060024CC RID: 9420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CC")]
		[Address(RVA = "0x21AF2FC", Offset = "0x21AF2FC", VA = "0x7BBC9AF2FC")]
		public AttendanceItem()
		{
		}

		// Token: 0x040025FD RID: 9725
		[Token(Token = "0x40025FD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EDBC", Offset = "0x110EDBC")]
		public uint id;

		// Token: 0x040025FE RID: 9726
		[Token(Token = "0x40025FE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EDD0", Offset = "0x110EDD0")]
		public uint signed;

		// Token: 0x040025FF RID: 9727
		[Token(Token = "0x40025FF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EDE4", Offset = "0x110EDE4")]
		public List<AwardDesc> awards;

		// Token: 0x04002600 RID: 9728
		[Token(Token = "0x4002600")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EDF8", Offset = "0x110EDF8")]
		public bool is_big_prize;
	}
}
