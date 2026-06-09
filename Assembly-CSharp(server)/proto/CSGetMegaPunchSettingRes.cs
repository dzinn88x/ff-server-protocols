using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009A8 RID: 2472
	[Token(Token = "0x20009A8")]
	[ProtoContract]
	public class CSGetMegaPunchSettingRes
	{
		// Token: 0x060026B6 RID: 9910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B6")]
		[Address(RVA = "0x21B4B50", Offset = "0x21B4B50", VA = "0x7BBC9B4B50")]
		public CSGetMegaPunchSettingRes()
		{
		}

		// Token: 0x04002C94 RID: 11412
		[Token(Token = "0x4002C94")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A4DC", Offset = "0x111A4DC")]
		public List<MegaPunchMonsterDesc> monster_descs;
	}
}
