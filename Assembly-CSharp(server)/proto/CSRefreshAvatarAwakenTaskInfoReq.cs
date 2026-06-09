using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000820 RID: 2080
	[Token(Token = "0x2000820")]
	[ProtoContract]
	public class CSRefreshAvatarAwakenTaskInfoReq
	{
		// Token: 0x0600252F RID: 9519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252F")]
		[Address(RVA = "0x21B726C", Offset = "0x21B726C", VA = "0x7BBC9B726C")]
		public CSRefreshAvatarAwakenTaskInfoReq()
		{
		}

		// Token: 0x04002729 RID: 10025
		[Token(Token = "0x4002729")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110F04", Offset = "0x1110F04")]
		public uint original_avatar_id;
	}
}
