using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A91 RID: 2705
	[Token(Token = "0x2000A91")]
	[ProtoContract]
	public class OppositeSexModelDesc
	{
		// Token: 0x0600279B RID: 10139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279B")]
		[Address(RVA = "0x249ED90", Offset = "0x249ED90", VA = "0x7BBCC9ED90")]
		public OppositeSexModelDesc()
		{
		}

		// Token: 0x040031EC RID: 12780
		[Token(Token = "0x40031EC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123C08", Offset = "0x1123C08")]
		public uint male_model_id;

		// Token: 0x040031ED RID: 12781
		[Token(Token = "0x40031ED")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123C1C", Offset = "0x1123C1C")]
		public uint female_model_id;

		// Token: 0x040031EE RID: 12782
		[Token(Token = "0x40031EE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123C30", Offset = "0x1123C30")]
		public uint start_timestamp;

		// Token: 0x040031EF RID: 12783
		[Token(Token = "0x40031EF")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123C44", Offset = "0x1123C44")]
		public uint end_timestamp;
	}
}
