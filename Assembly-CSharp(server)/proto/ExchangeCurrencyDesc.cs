using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AAE RID: 2734
	[Token(Token = "0x2000AAE")]
	[ProtoContract]
	public class ExchangeCurrencyDesc
	{
		// Token: 0x060027B8 RID: 10168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B8")]
		[Address(RVA = "0x21B9DA0", Offset = "0x21B9DA0", VA = "0x7BBC9B9DA0")]
		public ExchangeCurrencyDesc()
		{
		}

		// Token: 0x04003355 RID: 13141
		[Token(Token = "0x4003355")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126750", Offset = "0x1126750")]
		public uint id;

		// Token: 0x04003356 RID: 13142
		[Token(Token = "0x4003356")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126764", Offset = "0x1126764")]
		public uint type;

		// Token: 0x04003357 RID: 13143
		[Token(Token = "0x4003357")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126778", Offset = "0x1126778")]
		public uint subtype;

		// Token: 0x04003358 RID: 13144
		[Token(Token = "0x4003358")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112678C", Offset = "0x112678C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112678C", Offset = "0x112678C")]
		public string website;
	}
}
