using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007B2 RID: 1970
	[Token(Token = "0x20007B2")]
	[ProtoContract]
	public class CSGetNewPlayerLevelUpTaskRewardsReq
	{
		// Token: 0x060024C1 RID: 9409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C1")]
		[Address(RVA = "0x21B4F50", Offset = "0x21B4F50", VA = "0x7BBC9B4F50")]
		public CSGetNewPlayerLevelUpTaskRewardsReq()
		{
		}

		// Token: 0x040025E2 RID: 9698
		[Token(Token = "0x40025E2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E9D4", Offset = "0x110E9D4")]
		public ulong[] task_ids;
	}
}
