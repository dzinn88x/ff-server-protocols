using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200074A RID: 1866
	[Token(Token = "0x200074A")]
	[ProtoContract]
	public class CSGetAccountCupMatchInfoReq
	{
		// Token: 0x06002457 RID: 9303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002457")]
		[Address(RVA = "0x21B161C", Offset = "0x21B161C", VA = "0x7BBC9B161C")]
		public CSGetAccountCupMatchInfoReq()
		{
		}

		// Token: 0x040024D4 RID: 9428
		[Token(Token = "0x40024D4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CECC", Offset = "0x110CECC")]
		public uint cup_type;

		// Token: 0x040024D5 RID: 9429
		[Token(Token = "0x40024D5")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CEE0", Offset = "0x110CEE0")]
		public uint cup_id;
	}
}
