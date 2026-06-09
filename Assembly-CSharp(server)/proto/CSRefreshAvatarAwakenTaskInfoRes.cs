using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200081F RID: 2079
	[Token(Token = "0x200081F")]
	[ProtoContract]
	public class CSRefreshAvatarAwakenTaskInfoRes
	{
		// Token: 0x0600252E RID: 9518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252E")]
		[Address(RVA = "0x21B7274", Offset = "0x21B7274", VA = "0x7BBC9B7274")]
		public CSRefreshAvatarAwakenTaskInfoRes()
		{
		}

		// Token: 0x04002727 RID: 10023
		[Token(Token = "0x4002727")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110EDC", Offset = "0x1110EDC")]
		public List<AwakenTask> awaken_task_info;

		// Token: 0x04002728 RID: 10024
		[Token(Token = "0x4002728")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110EF0", Offset = "0x1110EF0")]
		public uint refresh_count;
	}
}
