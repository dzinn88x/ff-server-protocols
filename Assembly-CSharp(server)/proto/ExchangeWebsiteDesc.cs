using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AAC RID: 2732
	[Token(Token = "0x2000AAC")]
	[ProtoContract]
	public class ExchangeWebsiteDesc
	{
		// Token: 0x060027B6 RID: 10166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B6")]
		[Address(RVA = "0x21B9F48", Offset = "0x21B9F48", VA = "0x7BBC9B9F48")]
		public ExchangeWebsiteDesc()
		{
		}

		// Token: 0x0400334F RID: 13135
		[Token(Token = "0x400334F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126624", Offset = "0x1126624")]
		public uint id;

		// Token: 0x04003350 RID: 13136
		[Token(Token = "0x4003350")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126638", Offset = "0x1126638")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126638", Offset = "0x1126638")]
		public string url;
	}
}
