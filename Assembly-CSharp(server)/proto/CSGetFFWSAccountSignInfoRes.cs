using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009C2 RID: 2498
	[Token(Token = "0x20009C2")]
	[ProtoContract]
	public class CSGetFFWSAccountSignInfoRes
	{
		// Token: 0x060026D0 RID: 9936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D0")]
		[Address(RVA = "0x21B3548", Offset = "0x21B3548", VA = "0x7BBC9B3548")]
		public CSGetFFWSAccountSignInfoRes()
		{
		}

		// Token: 0x04002CC5 RID: 11461
		[Token(Token = "0x4002CC5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AA68", Offset = "0x111AA68")]
		public uint is_sign_in;
	}
}
