using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AF8 RID: 2808
	[Token(Token = "0x2000AF8")]
	[ProtoContract]
	public class LinkActivityMapDesc
	{
		// Token: 0x06002800 RID: 10240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002800")]
		[Address(RVA = "0x21BBB14", Offset = "0x21BBB14", VA = "0x7BBC9BBB14")]
		public LinkActivityMapDesc()
		{
		}

		// Token: 0x040034F1 RID: 13553
		[Token(Token = "0x40034F1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11298B0", Offset = "0x11298B0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11298B0", Offset = "0x11298B0")]
		public string activity_date;

		// Token: 0x040034F2 RID: 13554
		[Token(Token = "0x40034F2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129900", Offset = "0x1129900")]
		public uint token_id;

		// Token: 0x040034F3 RID: 13555
		[Token(Token = "0x40034F3")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129914", Offset = "0x1129914")]
		public uint award_id;

		// Token: 0x040034F4 RID: 13556
		[Token(Token = "0x40034F4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129928", Offset = "0x1129928")]
		public uint locate_id;
	}
}
