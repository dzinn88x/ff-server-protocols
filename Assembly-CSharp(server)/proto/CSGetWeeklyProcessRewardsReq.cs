using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000897 RID: 2199
	[Token(Token = "0x2000897")]
	[ProtoContract]
	public class CSGetWeeklyProcessRewardsReq
	{
		// Token: 0x060025A5 RID: 9637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A5")]
		[Address(RVA = "0x21B63E4", Offset = "0x21B63E4", VA = "0x7BBC9B63E4")]
		public CSGetWeeklyProcessRewardsReq()
		{
		}

		// Token: 0x040028F5 RID: 10485
		[Token(Token = "0x40028F5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113DBC", Offset = "0x1113DBC")]
		public uint week_id;

		// Token: 0x040028F6 RID: 10486
		[Token(Token = "0x40028F6")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113DD0", Offset = "0x1113DD0")]
		public uint node_id;
	}
}
