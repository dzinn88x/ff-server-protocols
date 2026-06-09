using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200088B RID: 2187
	[Token(Token = "0x200088B")]
	[ProtoContract]
	public class DailyQuestRewardsStatus
	{
		// Token: 0x06002599 RID: 9625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002599")]
		[Address(RVA = "0x21B9460", Offset = "0x21B9460", VA = "0x7BBC9B9460")]
		public DailyQuestRewardsStatus()
		{
		}

		// Token: 0x040028C7 RID: 10439
		[Token(Token = "0x40028C7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11139D4", Offset = "0x11139D4")]
		public uint process_id;

		// Token: 0x040028C8 RID: 10440
		[Token(Token = "0x40028C8")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11139E8", Offset = "0x11139E8")]
		public EPTarget_Status status;
	}
}
