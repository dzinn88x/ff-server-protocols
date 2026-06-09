using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007B1 RID: 1969
	[Token(Token = "0x20007B1")]
	[ProtoContract]
	public class CSGetNewPlayerLevelUpTaskInfoRes
	{
		// Token: 0x060024C0 RID: 9408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C0")]
		[Address(RVA = "0x21B4EDC", Offset = "0x21B4EDC", VA = "0x7BBC9B4EDC")]
		public CSGetNewPlayerLevelUpTaskInfoRes()
		{
		}

		// Token: 0x040025E1 RID: 9697
		[Token(Token = "0x40025E1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E9C0", Offset = "0x110E9C0")]
		public List<NewPlayerLevelUpTaskInfo> tasks;
	}
}
