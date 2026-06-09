using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005DD RID: 1501
	[Token(Token = "0x20005DD")]
	[ProtoContract]
	public class AccountIDSlice
	{
		// Token: 0x0600235D RID: 9053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235D")]
		[Address(RVA = "0x21AE42C", Offset = "0x21AE42C", VA = "0x7BBC9AE42C")]
		public AccountIDSlice()
		{
		}

		// Token: 0x04001DC4 RID: 7620
		[Token(Token = "0x4001DC4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105438", Offset = "0x1105438")]
		public ulong[] account_ids;
	}
}
