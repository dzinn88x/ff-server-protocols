using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B00 RID: 2816
	[Token(Token = "0x2000B00")]
	[ProtoContract]
	public class LinkEquipSetTimeDesc
	{
		// Token: 0x06002808 RID: 10248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002808")]
		[Address(RVA = "0x21BBBCC", Offset = "0x21BBBCC", VA = "0x7BBC9BBBCC")]
		public LinkEquipSetTimeDesc()
		{
		}

		// Token: 0x04003519 RID: 13593
		[Token(Token = "0x4003519")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129DEC", Offset = "0x1129DEC")]
		public uint id;

		// Token: 0x0400351A RID: 13594
		[Token(Token = "0x400351A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129E00", Offset = "0x1129E00")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1129E00", Offset = "0x1129E00")]
		public string start_time;

		// Token: 0x0400351B RID: 13595
		[Token(Token = "0x400351B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129E50", Offset = "0x1129E50")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1129E50", Offset = "0x1129E50")]
		public string end_time;

		// Token: 0x0400351C RID: 13596
		[Token(Token = "0x400351C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129EA0", Offset = "0x1129EA0")]
		public uint[] build_ids;

		// Token: 0x0400351D RID: 13597
		[Token(Token = "0x400351D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129EDC", Offset = "0x1129EDC")]
		public long start_timestamp;

		// Token: 0x0400351E RID: 13598
		[Token(Token = "0x400351E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129EF0", Offset = "0x1129EF0")]
		public long end_timestamp;
	}
}
