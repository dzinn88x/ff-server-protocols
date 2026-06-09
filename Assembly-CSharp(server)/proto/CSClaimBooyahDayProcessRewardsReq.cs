using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000972 RID: 2418
	[Token(Token = "0x2000972")]
	[ProtoContract]
	public class CSClaimBooyahDayProcessRewardsReq
	{
		// Token: 0x06002680 RID: 9856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002680")]
		[Address(RVA = "0x21B0790", Offset = "0x21B0790", VA = "0x7BBC9B0790")]
		public CSClaimBooyahDayProcessRewardsReq()
		{
		}

		// Token: 0x04002C0E RID: 11278
		[Token(Token = "0x4002C0E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11198FC", Offset = "0x11198FC")]
		public uint process_id;
	}
}
