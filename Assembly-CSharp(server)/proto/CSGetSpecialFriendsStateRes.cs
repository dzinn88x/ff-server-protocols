using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200083F RID: 2111
	[Token(Token = "0x200083F")]
	[ProtoContract]
	public class CSGetSpecialFriendsStateRes
	{
		// Token: 0x06002554 RID: 9556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002554")]
		[Address(RVA = "0x21B5B4C", Offset = "0x21B5B4C", VA = "0x7BBC9B5B4C")]
		public CSGetSpecialFriendsStateRes()
		{
		}

		// Token: 0x04002772 RID: 10098
		[Token(Token = "0x4002772")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11115F8", Offset = "0x11115F8")]
		public List<IntimacyState> intimacy_state;
	}
}
