using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006DD RID: 1757
	[Token(Token = "0x20006DD")]
	[ProtoContract]
	public class CSChooseRegionReq
	{
		// Token: 0x060023EB RID: 9195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EB")]
		[Address(RVA = "0x21B0698", Offset = "0x21B0698", VA = "0x7BBC9B0698")]
		public CSChooseRegionReq()
		{
		}

		// Token: 0x04002290 RID: 8848
		[Token(Token = "0x4002290")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11097CC", Offset = "0x11097CC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11097CC", Offset = "0x11097CC")]
		public string region;
	}
}
