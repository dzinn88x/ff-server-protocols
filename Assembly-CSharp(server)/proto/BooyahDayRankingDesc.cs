using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B30 RID: 2864
	[Token(Token = "0x2000B30")]
	[ProtoContract]
	public class BooyahDayRankingDesc
	{
		// Token: 0x06002838 RID: 10296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002838")]
		[Address(RVA = "0x21AFD3C", Offset = "0x21AFD3C", VA = "0x7BBC9AFD3C")]
		public BooyahDayRankingDesc()
		{
		}

		// Token: 0x04003657 RID: 13911
		[Token(Token = "0x4003657")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C830", Offset = "0x112C830")]
		public uint start_time_stamp;

		// Token: 0x04003658 RID: 13912
		[Token(Token = "0x4003658")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C844", Offset = "0x112C844")]
		public uint end_time_stamp;

		// Token: 0x04003659 RID: 13913
		[Token(Token = "0x4003659")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C858", Offset = "0x112C858")]
		public List<ModeRecord> modes;
	}
}
