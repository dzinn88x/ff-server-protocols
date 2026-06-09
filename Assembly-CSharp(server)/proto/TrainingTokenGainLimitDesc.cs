using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A50 RID: 2640
	[Token(Token = "0x2000A50")]
	[ProtoContract]
	public class TrainingTokenGainLimitDesc
	{
		// Token: 0x0600275A RID: 10074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275A")]
		[Address(RVA = "0x24A1118", Offset = "0x24A1118", VA = "0x7BBCCA1118")]
		public TrainingTokenGainLimitDesc()
		{
		}

		// Token: 0x04003029 RID: 12329
		[Token(Token = "0x4003029")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120A30", Offset = "0x1120A30")]
		public uint training_token_gain_limit;
	}
}
