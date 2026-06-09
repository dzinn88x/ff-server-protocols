using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000931 RID: 2353
	[Token(Token = "0x2000931")]
	[ProtoContract]
	public class CSGetActivenessRewardRes
	{
		// Token: 0x0600263F RID: 9791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263F")]
		[Address(RVA = "0x21B1968", Offset = "0x21B1968", VA = "0x7BBC9B1968")]
		public CSGetActivenessRewardRes()
		{
		}

		// Token: 0x04002B83 RID: 11139
		[Token(Token = "0x4002B83")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118BA0", Offset = "0x1118BA0")]
		public AwardData awards;
	}
}
