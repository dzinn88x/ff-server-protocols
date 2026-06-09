using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200073D RID: 1853
	[Token(Token = "0x200073D")]
	[ProtoContract]
	public class CSGetAccountCupInfoReq
	{
		// Token: 0x0600244A RID: 9290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244A")]
		[Address(RVA = "0x21B1614", Offset = "0x21B1614", VA = "0x7BBC9B1614")]
		public CSGetAccountCupInfoReq()
		{
		}

		// Token: 0x040024A8 RID: 9384
		[Token(Token = "0x40024A8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CA58", Offset = "0x110CA58")]
		public uint cup_type;

		// Token: 0x040024A9 RID: 9385
		[Token(Token = "0x40024A9")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CA6C", Offset = "0x110CA6C")]
		public uint cup_id;
	}
}
