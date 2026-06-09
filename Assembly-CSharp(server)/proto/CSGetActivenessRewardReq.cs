using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000930 RID: 2352
	[Token(Token = "0x2000930")]
	[ProtoContract]
	public class CSGetActivenessRewardReq
	{
		// Token: 0x0600263E RID: 9790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263E")]
		[Address(RVA = "0x21B1960", Offset = "0x21B1960", VA = "0x7BBC9B1960")]
		public CSGetActivenessRewardReq()
		{
		}

		// Token: 0x04002B82 RID: 11138
		[Token(Token = "0x4002B82")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118B8C", Offset = "0x1118B8C")]
		public BoxInfo box_info;
	}
}
