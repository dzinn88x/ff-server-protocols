using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000908 RID: 2312
	[Token(Token = "0x2000908")]
	[ProtoContract]
	public class TeamMemberListWithAccountInfo
	{
		// Token: 0x06002616 RID: 9750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002616")]
		[Address(RVA = "0x24A0E9C", Offset = "0x24A0E9C", VA = "0x7BBCCA0E9C")]
		public TeamMemberListWithAccountInfo()
		{
		}

		// Token: 0x04002ADB RID: 10971
		[Token(Token = "0x4002ADB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117D04", Offset = "0x1117D04")]
		public List<TeamMemberWithAccountInfo> member_list;
	}
}
