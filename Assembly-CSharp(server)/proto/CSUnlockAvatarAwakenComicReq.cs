using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000822 RID: 2082
	[Token(Token = "0x2000822")]
	[ProtoContract]
	public class CSUnlockAvatarAwakenComicReq
	{
		// Token: 0x06002531 RID: 9521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002531")]
		[Address(RVA = "0x21B7AAC", Offset = "0x21B7AAC", VA = "0x7BBC9B7AAC")]
		public CSUnlockAvatarAwakenComicReq()
		{
		}

		// Token: 0x0400272B RID: 10027
		[Token(Token = "0x400272B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110F2C", Offset = "0x1110F2C")]
		public uint original_avatar_id;

		// Token: 0x0400272C RID: 10028
		[Token(Token = "0x400272C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110F40", Offset = "0x1110F40")]
		public uint comic_id;
	}
}
