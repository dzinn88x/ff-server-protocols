using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000894 RID: 2196
	[Token(Token = "0x2000894")]
	[ProtoContract]
	public class CSGetDailyQuestRewardsReq
	{
		// Token: 0x060025A2 RID: 9634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A2")]
		[Address(RVA = "0x21B303C", Offset = "0x21B303C", VA = "0x7BBC9B303C")]
		public CSGetDailyQuestRewardsReq()
		{
		}

		// Token: 0x040028F2 RID: 10482
		[Token(Token = "0x40028F2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113D80", Offset = "0x1113D80")]
		public uint process_id;
	}
}
