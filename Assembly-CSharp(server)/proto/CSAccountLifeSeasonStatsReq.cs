using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200091B RID: 2331
	[Token(Token = "0x200091B")]
	[ProtoContract]
	public class CSAccountLifeSeasonStatsReq
	{
		// Token: 0x06002629 RID: 9769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002629")]
		[Address(RVA = "0x21B0190", Offset = "0x21B0190", VA = "0x7BBC9B0190")]
		public CSAccountLifeSeasonStatsReq()
		{
		}

		// Token: 0x04002B44 RID: 11076
		[Token(Token = "0x4002B44")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111863C", Offset = "0x111863C")]
		public ulong account_id;

		// Token: 0x04002B45 RID: 11077
		[Token(Token = "0x4002B45")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118650", Offset = "0x1118650")]
		public uint championship_type;
	}
}
