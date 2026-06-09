using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009B4 RID: 2484
	[Token(Token = "0x20009B4")]
	[ProtoContract]
	public class CSGetMVPInfoRes
	{
		// Token: 0x060026C2 RID: 9922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C2")]
		[Address(RVA = "0x21B4880", Offset = "0x21B4880", VA = "0x7BBC9B4880")]
		public CSGetMVPInfoRes()
		{
		}

		// Token: 0x04002CAD RID: 11437
		[Token(Token = "0x4002CAD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A75C", Offset = "0x111A75C")]
		public uint[] process;
	}
}
