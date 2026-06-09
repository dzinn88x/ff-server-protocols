using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000948 RID: 2376
	[Token(Token = "0x2000948")]
	[ProtoContract]
	public class CSGetVeteranTaskRewardsRes
	{
		// Token: 0x06002656 RID: 9814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002656")]
		[Address(RVA = "0x21B6288", Offset = "0x21B6288", VA = "0x7BBC9B6288")]
		public CSGetVeteranTaskRewardsRes()
		{
		}

		// Token: 0x04002BB7 RID: 11191
		[Token(Token = "0x4002BB7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11190B4", Offset = "0x11190B4")]
		public AwardData awards;
	}
}
