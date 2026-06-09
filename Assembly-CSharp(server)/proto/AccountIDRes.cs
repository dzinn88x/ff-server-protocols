using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005DC RID: 1500
	[Token(Token = "0x20005DC")]
	[ProtoContract]
	public class AccountIDRes
	{
		// Token: 0x0600235C RID: 9052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235C")]
		[Address(RVA = "0x21AE424", Offset = "0x21AE424", VA = "0x7BBC9AE424")]
		public AccountIDRes()
		{
		}

		// Token: 0x04001DC3 RID: 7619
		[Token(Token = "0x4001DC3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105424", Offset = "0x1105424")]
		public ulong account_id;
	}
}
