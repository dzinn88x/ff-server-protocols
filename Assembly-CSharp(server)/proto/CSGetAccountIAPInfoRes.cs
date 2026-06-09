using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008AF RID: 2223
	[Token(Token = "0x20008AF")]
	[ProtoContract]
	public class CSGetAccountIAPInfoRes
	{
		// Token: 0x060025BD RID: 9661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025BD")]
		[Address(RVA = "0x21B1698", Offset = "0x21B1698", VA = "0x7BBC9B1698")]
		public CSGetAccountIAPInfoRes()
		{
		}

		// Token: 0x040029E3 RID: 10723
		[Token(Token = "0x40029E3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116094", Offset = "0x1116094")]
		public List<IAPInfoItem> iap_info_res;
	}
}
