using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000824 RID: 2084
	[Token(Token = "0x2000824")]
	[ProtoContract]
	public class CSGetAwakenAvatarByAwakenComicReq
	{
		// Token: 0x06002533 RID: 9523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002533")]
		[Address(RVA = "0x21B227C", Offset = "0x21B227C", VA = "0x7BBC9B227C")]
		public CSGetAwakenAvatarByAwakenComicReq()
		{
		}

		// Token: 0x0400272E RID: 10030
		[Token(Token = "0x400272E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110F68", Offset = "0x1110F68")]
		public uint original_avatar_id;
	}
}
