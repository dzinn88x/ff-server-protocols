using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005FD RID: 1533
	[Token(Token = "0x20005FD")]
	[ProtoContract]
	public class AvatarAwakenRefreshCount
	{
		// Token: 0x0600237D RID: 9085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237D")]
		[Address(RVA = "0x21AF488", Offset = "0x21AF488", VA = "0x7BBC9AF488")]
		public AvatarAwakenRefreshCount()
		{
		}

		// Token: 0x04001E97 RID: 7831
		[Token(Token = "0x4001E97")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106F7C", Offset = "0x1106F7C")]
		public uint original_avatar_id;

		// Token: 0x04001E98 RID: 7832
		[Token(Token = "0x4001E98")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106F90", Offset = "0x1106F90")]
		public uint refresh_count;
	}
}
