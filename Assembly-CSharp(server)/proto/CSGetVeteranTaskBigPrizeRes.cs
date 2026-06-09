using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200094B RID: 2379
	[Token(Token = "0x200094B")]
	[ProtoContract]
	public class CSGetVeteranTaskBigPrizeRes
	{
		// Token: 0x06002659 RID: 9817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002659")]
		[Address(RVA = "0x21B6190", Offset = "0x21B6190", VA = "0x7BBC9B6190")]
		public CSGetVeteranTaskBigPrizeRes()
		{
		}

		// Token: 0x04002BBC RID: 11196
		[Token(Token = "0x4002BBC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119154", Offset = "0x1119154")]
		public AwardData awards;
	}
}
