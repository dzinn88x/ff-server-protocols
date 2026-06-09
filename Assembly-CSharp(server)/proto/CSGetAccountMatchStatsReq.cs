using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006EC RID: 1772
	[Token(Token = "0x20006EC")]
	[ProtoContract]
	public class CSGetAccountMatchStatsReq
	{
		// Token: 0x060023FA RID: 9210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FA")]
		[Address(RVA = "0x21B1768", Offset = "0x21B1768", VA = "0x7BBC9B1768")]
		public CSGetAccountMatchStatsReq()
		{
		}

		// Token: 0x040022A9 RID: 8873
		[Token(Token = "0x40022A9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109CF4", Offset = "0x1109CF4")]
		public ulong match_id;

		// Token: 0x040022AA RID: 8874
		[Token(Token = "0x40022AA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109D08", Offset = "0x1109D08")]
		public bool is_pve;
	}
}
