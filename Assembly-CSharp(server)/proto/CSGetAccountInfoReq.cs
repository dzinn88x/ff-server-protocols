using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006D9 RID: 1753
	[Token(Token = "0x20006D9")]
	[ProtoContract]
	public class CSGetAccountInfoReq
	{
		// Token: 0x060023E7 RID: 9191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E7")]
		[Address(RVA = "0x21B170C", Offset = "0x21B170C", VA = "0x7BBC9B170C")]
		public CSGetAccountInfoReq()
		{
		}

		// Token: 0x04002284 RID: 8836
		[Token(Token = "0x4002284")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11094FC", Offset = "0x11094FC")]
		public int input_type;

		// Token: 0x04002285 RID: 8837
		[Token(Token = "0x4002285")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109510", Offset = "0x1109510")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1109510", Offset = "0x1109510")]
		public string input_value;
	}
}
