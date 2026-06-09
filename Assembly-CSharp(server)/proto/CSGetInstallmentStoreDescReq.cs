using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008C4 RID: 2244
	[Token(Token = "0x20008C4")]
	[ProtoContract]
	public class CSGetInstallmentStoreDescReq
	{
		// Token: 0x060025D2 RID: 9682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D2")]
		[Address(RVA = "0x21B42C8", Offset = "0x21B42C8", VA = "0x7BBC9B42C8")]
		public CSGetInstallmentStoreDescReq()
		{
		}

		// Token: 0x04002A2D RID: 10797
		[Token(Token = "0x4002A2D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116878", Offset = "0x1116878")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1116878", Offset = "0x1116878")]
		public string language;
	}
}
