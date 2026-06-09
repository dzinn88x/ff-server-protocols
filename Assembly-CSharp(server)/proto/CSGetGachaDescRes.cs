using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000862 RID: 2146
	[Token(Token = "0x2000862")]
	[ProtoContract]
	public class CSGetGachaDescRes
	{
		// Token: 0x06002570 RID: 9584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002570")]
		[Address(RVA = "0x21B3CF8", Offset = "0x21B3CF8", VA = "0x7BBC9B3CF8")]
		public CSGetGachaDescRes()
		{
		}

		// Token: 0x0400281D RID: 10269
		[Token(Token = "0x400281D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111273C", Offset = "0x111273C")]
		public List<GachaDesc> gacha_desc_list;
	}
}
