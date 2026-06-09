using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007D3 RID: 2003
	[Token(Token = "0x20007D3")]
	[ProtoContract]
	public class CSGetMailListReq
	{
		// Token: 0x060024E2 RID: 9442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E2")]
		[Address(RVA = "0x21B48FC", Offset = "0x21B48FC", VA = "0x7BBC9B48FC")]
		public CSGetMailListReq()
		{
		}

		// Token: 0x0400265B RID: 9819
		[Token(Token = "0x400265B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FA50", Offset = "0x110FA50")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110FA50", Offset = "0x110FA50")]
		public string language;
	}
}
