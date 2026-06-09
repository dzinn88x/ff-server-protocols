using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200078E RID: 1934
	[Token(Token = "0x200078E")]
	[ProtoContract]
	public class CSGetRoleDebrisDescRes
	{
		// Token: 0x0600249D RID: 9373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249D")]
		[Address(RVA = "0x21B5A34", Offset = "0x21B5A34", VA = "0x7BBC9B5A34")]
		public CSGetRoleDebrisDescRes()
		{
		}

		// Token: 0x04002594 RID: 9620
		[Token(Token = "0x4002594")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E2B8", Offset = "0x110E2B8")]
		public List<RoleDebrisPurchaseDesc> role_debris_tables;
	}
}
