using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006E5 RID: 1765
	[Token(Token = "0x20006E5")]
	[ProtoContract]
	public class CSActivateAccountReq
	{
		// Token: 0x060023F3 RID: 9203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F3")]
		[Address(RVA = "0x21B0224", Offset = "0x21B0224", VA = "0x7BBC9B0224")]
		public CSActivateAccountReq()
		{
		}

		// Token: 0x0400229B RID: 8859
		[Token(Token = "0x400229B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1109A88", Offset = "0x1109A88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109A88", Offset = "0x1109A88")]
		public string email;

		// Token: 0x0400229C RID: 8860
		[Token(Token = "0x400229C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1109AD8", Offset = "0x1109AD8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109AD8", Offset = "0x1109AD8")]
		public string code;
	}
}
