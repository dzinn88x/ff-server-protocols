using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000959 RID: 2393
	[Token(Token = "0x2000959")]
	[ProtoContract]
	public class CSGetAnniversarySettingRes
	{
		// Token: 0x06002667 RID: 9831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002667")]
		[Address(RVA = "0x21B206C", Offset = "0x21B206C", VA = "0x7BBC9B206C")]
		public CSGetAnniversarySettingRes()
		{
		}

		// Token: 0x04002BD7 RID: 11223
		[Token(Token = "0x4002BD7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11193D4", Offset = "0x11193D4")]
		public AnniversarySettingDesc setting;
	}
}
