using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000746 RID: 1862
	[Token(Token = "0x2000746")]
	[ProtoContract]
	public class CSGetCupTeamMemberByMemberIDReq
	{
		// Token: 0x06002453 RID: 9299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002453")]
		[Address(RVA = "0x21B2F4C", Offset = "0x21B2F4C", VA = "0x7BBC9B2F4C")]
		public CSGetCupTeamMemberByMemberIDReq()
		{
		}

		// Token: 0x040024CF RID: 9423
		[Token(Token = "0x40024CF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CE40", Offset = "0x110CE40")]
		public uint cup_type;

		// Token: 0x040024D0 RID: 9424
		[Token(Token = "0x40024D0")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CE54", Offset = "0x110CE54")]
		public uint cup_id;
	}
}
