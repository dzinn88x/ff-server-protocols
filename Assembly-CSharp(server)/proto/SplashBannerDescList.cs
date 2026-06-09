using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008D5 RID: 2261
	[Token(Token = "0x20008D5")]
	[ProtoContract]
	public class SplashBannerDescList
	{
		// Token: 0x060025E3 RID: 9699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E3")]
		[Address(RVA = "0x24A07EC", Offset = "0x24A07EC", VA = "0x7BBCCA07EC")]
		public SplashBannerDescList()
		{
		}

		// Token: 0x04002A5F RID: 10847
		[Token(Token = "0x4002A5F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116E04", Offset = "0x1116E04")]
		public List<SplashBannerDesc> splashBanners;
	}
}
