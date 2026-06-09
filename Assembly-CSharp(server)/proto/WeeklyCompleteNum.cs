using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200088E RID: 2190
	[Token(Token = "0x200088E")]
	[ProtoContract]
	public class WeeklyCompleteNum
	{
		// Token: 0x0600259C RID: 9628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259C")]
		[Address(RVA = "0x24A19BC", Offset = "0x24A19BC", VA = "0x7BBCCA19BC")]
		public WeeklyCompleteNum()
		{
		}

		// Token: 0x040028CE RID: 10446
		[Token(Token = "0x40028CE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113A60", Offset = "0x1113A60")]
		public uint week_id;

		// Token: 0x040028CF RID: 10447
		[Token(Token = "0x40028CF")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113A74", Offset = "0x1113A74")]
		public uint completed_num;
	}
}
