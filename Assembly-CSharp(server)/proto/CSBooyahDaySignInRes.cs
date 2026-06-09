using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000975 RID: 2421
	[Token(Token = "0x2000975")]
	[ProtoContract]
	public class CSBooyahDaySignInRes
	{
		// Token: 0x06002683 RID: 9859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002683")]
		[Address(RVA = "0x21B04E4", Offset = "0x21B04E4", VA = "0x7BBC9B04E4")]
		public CSBooyahDaySignInRes()
		{
		}

		// Token: 0x04002C11 RID: 11281
		[Token(Token = "0x4002C11")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119938", Offset = "0x1119938")]
		public AwardData awards;
	}
}
