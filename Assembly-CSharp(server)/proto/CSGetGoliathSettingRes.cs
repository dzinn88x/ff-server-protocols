using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200097F RID: 2431
	[Token(Token = "0x200097F")]
	[ProtoContract]
	public class CSGetGoliathSettingRes
	{
		// Token: 0x0600268D RID: 9869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268D")]
		[Address(RVA = "0x21B40E0", Offset = "0x21B40E0", VA = "0x7BBC9B40E0")]
		public CSGetGoliathSettingRes()
		{
		}

		// Token: 0x04002C24 RID: 11300
		[Token(Token = "0x4002C24")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119AB4", Offset = "0x1119AB4")]
		public GoliathSettingDesc desc;

		// Token: 0x04002C25 RID: 11301
		[Token(Token = "0x4002C25")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119AC8", Offset = "0x1119AC8")]
		public List<GoliathAFKTaskDesc> task_list;
	}
}
