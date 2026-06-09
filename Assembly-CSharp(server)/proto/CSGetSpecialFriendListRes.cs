using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000840 RID: 2112
	[Token(Token = "0x2000840")]
	[ProtoContract]
	public class CSGetSpecialFriendListRes
	{
		// Token: 0x06002555 RID: 9557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002555")]
		[Address(RVA = "0x21B5AD0", Offset = "0x21B5AD0", VA = "0x7BBC9B5AD0")]
		public CSGetSpecialFriendListRes()
		{
		}

		// Token: 0x04002773 RID: 10099
		[Token(Token = "0x4002773")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111160C", Offset = "0x111160C")]
		public List<IntimacyState> intimacy_state;
	}
}
