using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A28 RID: 2600
	[Token(Token = "0x2000A28")]
	[ProtoContract]
	public class NewPlayerRewardDesc
	{
		// Token: 0x06002732 RID: 10034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002732")]
		[Address(RVA = "0x249EA30", Offset = "0x249EA30", VA = "0x7BBCC9EA30")]
		public NewPlayerRewardDesc()
		{
		}

		// Token: 0x04002F60 RID: 12128
		[Token(Token = "0x4002F60")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F3B0", Offset = "0x111F3B0")]
		public uint id;

		// Token: 0x04002F61 RID: 12129
		[Token(Token = "0x4002F61")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F3C4", Offset = "0x111F3C4")]
		public List<AwardDesc> awards;
	}
}
