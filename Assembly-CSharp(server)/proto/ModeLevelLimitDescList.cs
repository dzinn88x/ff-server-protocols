using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A0A RID: 2570
	[Token(Token = "0x2000A0A")]
	[ProtoContract]
	public class ModeLevelLimitDescList
	{
		// Token: 0x06002714 RID: 10004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002714")]
		[Address(RVA = "0x21BCB80", Offset = "0x21BCB80", VA = "0x7BBC9BCB80")]
		public ModeLevelLimitDescList()
		{
		}

		// Token: 0x04002EF4 RID: 12020
		[Token(Token = "0x4002EF4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E5C8", Offset = "0x111E5C8")]
		public List<ModeLevelLimitDesc> mode_level_limits;
	}
}
