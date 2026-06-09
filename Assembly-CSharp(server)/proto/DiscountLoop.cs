using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AAA RID: 2730
	[Token(Token = "0x2000AAA")]
	[ProtoContract]
	public class DiscountLoop
	{
		// Token: 0x060027B4 RID: 10164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B4")]
		[Address(RVA = "0x21B9674", Offset = "0x21B9674", VA = "0x7BBC9B9674")]
		public DiscountLoop()
		{
		}

		// Token: 0x04003341 RID: 13121
		[Token(Token = "0x4003341")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112641C", Offset = "0x112641C")]
		public uint loop_id;

		// Token: 0x04003342 RID: 13122
		[Token(Token = "0x4003342")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126430", Offset = "0x1126430")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126430", Offset = "0x1126430")]
		public string start_date;

		// Token: 0x04003343 RID: 13123
		[Token(Token = "0x4003343")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126480", Offset = "0x1126480")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126480", Offset = "0x1126480")]
		public string end_date;
	}
}
