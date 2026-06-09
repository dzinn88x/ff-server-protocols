using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000765 RID: 1893
	[Token(Token = "0x2000765")]
	[ProtoContract]
	public class CSUseCupTicketReq
	{
		// Token: 0x06002472 RID: 9330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002472")]
		[Address(RVA = "0x21B7D4C", Offset = "0x21B7D4C", VA = "0x7BBC9B7D4C")]
		public CSUseCupTicketReq()
		{
		}

		// Token: 0x0400251B RID: 9499
		[Token(Token = "0x400251B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D660", Offset = "0x110D660")]
		public uint cup_type;

		// Token: 0x0400251C RID: 9500
		[Token(Token = "0x400251C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D674", Offset = "0x110D674")]
		public uint cup_id;
	}
}
