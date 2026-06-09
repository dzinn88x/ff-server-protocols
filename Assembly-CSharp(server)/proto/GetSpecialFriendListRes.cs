using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000638 RID: 1592
	[Token(Token = "0x2000638")]
	[ProtoContract]
	public class GetSpecialFriendListRes
	{
		// Token: 0x060023A2 RID: 9122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A2")]
		[Address(RVA = "0x21BAB68", Offset = "0x21BAB68", VA = "0x7BBC9BAB68")]
		public GetSpecialFriendListRes()
		{
		}

		// Token: 0x04001F98 RID: 8088
		[Token(Token = "0x4001F98")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108110", Offset = "0x1108110")]
		public List<IntimacyState> intimacy_state;
	}
}
