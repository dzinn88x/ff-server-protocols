using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006DF RID: 1759
	[Token(Token = "0x20006DF")]
	[ProtoContract]
	public class CSModifyNicknameReq
	{
		// Token: 0x060023ED RID: 9197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023ED")]
		[Address(RVA = "0x21B6A14", Offset = "0x21B6A14", VA = "0x7BBC9B6A14")]
		public CSModifyNicknameReq()
		{
		}

		// Token: 0x04002292 RID: 8850
		[Token(Token = "0x4002292")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110986C", Offset = "0x110986C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110986C", Offset = "0x110986C")]
		public string nickname;

		// Token: 0x04002293 RID: 8851
		[Token(Token = "0x4002293")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11098BC", Offset = "0x11098BC")]
		public bool use_card;
	}
}
