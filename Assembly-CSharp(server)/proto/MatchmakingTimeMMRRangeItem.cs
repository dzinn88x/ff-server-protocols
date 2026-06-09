using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A04 RID: 2564
	[Token(Token = "0x2000A04")]
	[ProtoContract]
	public class MatchmakingTimeMMRRangeItem
	{
		// Token: 0x0600270E RID: 9998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270E")]
		[Address(RVA = "0x21BCA34", Offset = "0x21BCA34", VA = "0x7BBC9BCA34")]
		public MatchmakingTimeMMRRangeItem()
		{
		}

		// Token: 0x04002EBB RID: 11963
		[Token(Token = "0x4002EBB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DDD0", Offset = "0x111DDD0")]
		public uint time_sec;

		// Token: 0x04002EBC RID: 11964
		[Token(Token = "0x4002EBC")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DDE4", Offset = "0x111DDE4")]
		public uint mmr_delta;
	}
}
