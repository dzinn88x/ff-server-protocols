using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006E1 RID: 1761
	[Token(Token = "0x20006E1")]
	[ProtoContract]
	public class CSFuzzySearchAccountByNameReq
	{
		// Token: 0x060023EF RID: 9199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EF")]
		[Address(RVA = "0x21B15B0", Offset = "0x21B15B0", VA = "0x7BBC9B15B0")]
		public CSFuzzySearchAccountByNameReq()
		{
		}

		// Token: 0x04002295 RID: 8853
		[Token(Token = "0x4002295")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1109920", Offset = "0x1109920")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109920", Offset = "0x1109920")]
		public string nickname;
	}
}
