using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000858 RID: 2136
	[Token(Token = "0x2000858")]
	[ProtoContract]
	public class CSGetAdvertReq
	{
		// Token: 0x06002566 RID: 9574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002566")]
		[Address(RVA = "0x21B1BE0", Offset = "0x21B1BE0", VA = "0x7BBC9B1BE0")]
		public CSGetAdvertReq()
		{
		}

		// Token: 0x040027FB RID: 10235
		[Token(Token = "0x40027FB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1112408", Offset = "0x1112408")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112408", Offset = "0x1112408")]
		public string language;
	}
}
