using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B39 RID: 2873
	[Token(Token = "0x2000B39")]
	[ProtoContract]
	public class BigEventCDNDesc
	{
		// Token: 0x06002841 RID: 10305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002841")]
		[Address(RVA = "0x21AF810", Offset = "0x21AF810", VA = "0x7BBC9AF810")]
		public BigEventCDNDesc()
		{
		}

		// Token: 0x0400368F RID: 13967
		[Token(Token = "0x400368F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CE34", Offset = "0x112CE34")]
		public ELimitedEvent.EventID event_id;

		// Token: 0x04003690 RID: 13968
		[Token(Token = "0x4003690")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CE48", Offset = "0x112CE48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112CE48", Offset = "0x112CE48")]
		public string lanuage;

		// Token: 0x04003691 RID: 13969
		[Token(Token = "0x4003691")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CE98", Offset = "0x112CE98")]
		public uint cdn_type;

		// Token: 0x04003692 RID: 13970
		[Token(Token = "0x4003692")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112CEAC", Offset = "0x112CEAC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CEAC", Offset = "0x112CEAC")]
		public string url;
	}
}
