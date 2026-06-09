using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009C4 RID: 2500
	[Token(Token = "0x20009C4")]
	[ProtoContract]
	public class CSAccusationCountReq
	{
		// Token: 0x060026D2 RID: 9938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D2")]
		[Address(RVA = "0x21B01A0", Offset = "0x21B01A0", VA = "0x7BBC9B01A0")]
		public CSAccusationCountReq()
		{
		}

		// Token: 0x04002CC7 RID: 11463
		[Token(Token = "0x4002CC7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AA90", Offset = "0x111AA90")]
		public List<AccusationCount> accusation_counts;

		// Token: 0x04002CC8 RID: 11464
		[Token(Token = "0x4002CC8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111AAA4", Offset = "0x111AAA4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AAA4", Offset = "0x111AAA4")]
		public string noti_region;
	}
}
