using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000815 RID: 2069
	[Token(Token = "0x2000815")]
	[ProtoContract]
	public class CSGetAvatarAwakenTaskInfoRes
	{
		// Token: 0x06002524 RID: 9508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002524")]
		[Address(RVA = "0x21B21E0", Offset = "0x21B21E0", VA = "0x7BBC9B21E0")]
		public CSGetAvatarAwakenTaskInfoRes()
		{
		}

		// Token: 0x04002714 RID: 10004
		[Token(Token = "0x4002714")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110D38", Offset = "0x1110D38")]
		public List<AwakenTask> awaken_task_info;

		// Token: 0x04002715 RID: 10005
		[Token(Token = "0x4002715")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110D4C", Offset = "0x1110D4C")]
		public List<AvatarAwakenRefreshCount> refresh_count;
	}
}
