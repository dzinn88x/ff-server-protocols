using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000957 RID: 2391
	[Token(Token = "0x2000957")]
	[ProtoContract]
	public class CSGetLimitedEventOpenInfoRes
	{
		// Token: 0x06002665 RID: 9829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002665")]
		[Address(RVA = "0x21B44B8", Offset = "0x21B44B8", VA = "0x7BBC9B44B8")]
		public CSGetLimitedEventOpenInfoRes()
		{
		}

		// Token: 0x04002BD4 RID: 11220
		[Token(Token = "0x4002BD4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119398", Offset = "0x1119398")]
		public List<BigEventOpenInfoDesc> open_infos;

		// Token: 0x04002BD5 RID: 11221
		[Token(Token = "0x4002BD5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11193AC", Offset = "0x11193AC")]
		public List<BigEventCDNDesc> cdns;
	}
}
