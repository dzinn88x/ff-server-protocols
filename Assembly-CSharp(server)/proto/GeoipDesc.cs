using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A1C RID: 2588
	[Token(Token = "0x2000A1C")]
	[ProtoContract]
	public class GeoipDesc
	{
		// Token: 0x06002726 RID: 10022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002726")]
		[Address(RVA = "0x21BA968", Offset = "0x21BA968", VA = "0x7BBC9BA968")]
		public GeoipDesc()
		{
		}

		// Token: 0x04002F3A RID: 12090
		[Token(Token = "0x4002F3A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111ED70", Offset = "0x111ED70")]
		public bool enable_geoip;
	}
}
