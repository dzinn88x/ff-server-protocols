using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006E4 RID: 1764
	[Token(Token = "0x20006E4")]
	[ProtoContract]
	public class CSDelAccountReq
	{
		// Token: 0x060023F2 RID: 9202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F2")]
		[Address(RVA = "0x21B0EE4", Offset = "0x21B0EE4", VA = "0x7BBC9B0EE4")]
		public CSDelAccountReq()
		{
		}

		// Token: 0x0400229A RID: 8858
		[Token(Token = "0x400229A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109A38", Offset = "0x1109A38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1109A38", Offset = "0x1109A38")]
		public string login_token;
	}
}
