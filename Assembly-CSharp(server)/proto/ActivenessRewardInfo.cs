using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200092C RID: 2348
	[Token(Token = "0x200092C")]
	[ProtoContract]
	public class ActivenessRewardInfo
	{
		// Token: 0x0600263A RID: 9786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263A")]
		[Address(RVA = "0x21AE9B4", Offset = "0x21AE9B4", VA = "0x7BBC9AE9B4")]
		public ActivenessRewardInfo()
		{
		}

		// Token: 0x04002B7C RID: 11132
		[Token(Token = "0x4002B7C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118B14", Offset = "0x1118B14")]
		public List<BoxState> box_state;
	}
}
