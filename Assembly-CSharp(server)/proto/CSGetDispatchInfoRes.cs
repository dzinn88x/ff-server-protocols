using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200081C RID: 2076
	[Token(Token = "0x200081C")]
	[ProtoContract]
	public class CSGetDispatchInfoRes
	{
		// Token: 0x0600252B RID: 9515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252B")]
		[Address(RVA = "0x21B30D0", Offset = "0x21B30D0", VA = "0x7BBC9B30D0")]
		public CSGetDispatchInfoRes()
		{
		}

		// Token: 0x04002722 RID: 10018
		[Token(Token = "0x4002722")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110E78", Offset = "0x1110E78")]
		public List<AvatarDispatchStatus> avatar_dispatch_status;

		// Token: 0x04002723 RID: 10019
		[Token(Token = "0x4002723")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110E8C", Offset = "0x1110E8C")]
		public List<AvatarDispatchQuest> avatar_dispatch_quest;
	}
}
