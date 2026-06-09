using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200092F RID: 2351
	[Token(Token = "0x200092F")]
	[ProtoContract]
	public class CSGetActivenessDescRes
	{
		// Token: 0x0600263D RID: 9789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263D")]
		[Address(RVA = "0x21B18EC", Offset = "0x21B18EC", VA = "0x7BBC9B18EC")]
		public CSGetActivenessDescRes()
		{
		}

		// Token: 0x04002B80 RID: 11136
		[Token(Token = "0x4002B80")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118B64", Offset = "0x1118B64")]
		public ActivenessTimeDesc activeness_time;

		// Token: 0x04002B81 RID: 11137
		[Token(Token = "0x4002B81")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118B78", Offset = "0x1118B78")]
		public List<ActivenessRewardDesc> activeness_reward;
	}
}
