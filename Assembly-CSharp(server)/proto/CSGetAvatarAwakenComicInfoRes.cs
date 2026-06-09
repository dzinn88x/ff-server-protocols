using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000821 RID: 2081
	[Token(Token = "0x2000821")]
	[ProtoContract]
	public class CSGetAvatarAwakenComicInfoRes
	{
		// Token: 0x06002530 RID: 9520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002530")]
		[Address(RVA = "0x21B20F8", Offset = "0x21B20F8", VA = "0x7BBC9B20F8")]
		public CSGetAvatarAwakenComicInfoRes()
		{
		}

		// Token: 0x0400272A RID: 10026
		[Token(Token = "0x400272A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110F18", Offset = "0x1110F18")]
		public List<AwakenComic> awaken_comic_info;
	}
}
