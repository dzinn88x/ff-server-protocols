using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A83 RID: 2691
	[Token(Token = "0x2000A83")]
	[ProtoContract]
	public class EPWeeklyProcessRewardStatus
	{
		// Token: 0x0600278D RID: 10125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278D")]
		[Address(RVA = "0x21B9A1C", Offset = "0x21B9A1C", VA = "0x7BBC9B9A1C")]
		public EPWeeklyProcessRewardStatus()
		{
		}

		// Token: 0x0400317B RID: 12667
		[Token(Token = "0x400317B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122DE4", Offset = "0x1122DE4")]
		public uint node_id;

		// Token: 0x0400317C RID: 12668
		[Token(Token = "0x400317C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122DF8", Offset = "0x1122DF8")]
		public EPProcess_Status status;
	}
}
