using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000823 RID: 2083
	[Token(Token = "0x2000823")]
	[ProtoContract]
	public class CSGetAwakenAvatarByAwakenComicRes
	{
		// Token: 0x06002532 RID: 9522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002532")]
		[Address(RVA = "0x21B2284", Offset = "0x21B2284", VA = "0x7BBC9B2284")]
		public CSGetAwakenAvatarByAwakenComicRes()
		{
		}

		// Token: 0x0400272D RID: 10029
		[Token(Token = "0x400272D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110F54", Offset = "0x1110F54")]
		public AwardData awards;
	}
}
