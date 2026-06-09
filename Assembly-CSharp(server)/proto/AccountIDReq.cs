using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005DB RID: 1499
	[Token(Token = "0x20005DB")]
	[ProtoContract]
	public class AccountIDReq
	{
		// Token: 0x0600235B RID: 9051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235B")]
		[Address(RVA = "0x21AE41C", Offset = "0x21AE41C", VA = "0x7BBC9AE41C")]
		public AccountIDReq()
		{
		}

		// Token: 0x04001DC2 RID: 7618
		[Token(Token = "0x4001DC2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105410", Offset = "0x1105410")]
		public ulong account_id;
	}
}
