using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008EB RID: 2283
	[Token(Token = "0x20008EB")]
	[ProtoContract]
	public class CSGetManualAllMapRewardStatesRes
	{
		// Token: 0x060025F9 RID: 9721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F9")]
		[Address(RVA = "0x21B49CC", Offset = "0x21B49CC", VA = "0x7BBC9B49CC")]
		public CSGetManualAllMapRewardStatesRes()
		{
		}

		// Token: 0x04002A95 RID: 10901
		[Token(Token = "0x4002A95")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117480", Offset = "0x1117480")]
		public List<ManualMapReward> map_rewards;
	}
}
