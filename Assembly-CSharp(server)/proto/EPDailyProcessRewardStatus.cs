using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A81 RID: 2689
	[Token(Token = "0x2000A81")]
	[ProtoContract]
	public class EPDailyProcessRewardStatus
	{
		// Token: 0x0600278B RID: 10123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278B")]
		[Address(RVA = "0x21B9898", Offset = "0x21B9898", VA = "0x7BBC9B9898")]
		public EPDailyProcessRewardStatus()
		{
		}

		// Token: 0x04003178 RID: 12664
		[Token(Token = "0x4003178")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122DA8", Offset = "0x1122DA8")]
		public uint process_id;

		// Token: 0x04003179 RID: 12665
		[Token(Token = "0x4003179")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122DBC", Offset = "0x1122DBC")]
		public EPProcess_Status status;
	}
}
