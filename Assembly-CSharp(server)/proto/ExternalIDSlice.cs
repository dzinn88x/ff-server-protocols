using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005DE RID: 1502
	[Token(Token = "0x20005DE")]
	[ProtoContract]
	public class ExternalIDSlice
	{
		// Token: 0x0600235E RID: 9054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235E")]
		[Address(RVA = "0x21B9FB4", Offset = "0x21B9FB4", VA = "0x7BBC9B9FB4")]
		public ExternalIDSlice()
		{
		}

		// Token: 0x04001DC5 RID: 7621
		[Token(Token = "0x4001DC5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105474", Offset = "0x1105474")]
		public List<string> external_ids;

		// Token: 0x04001DC6 RID: 7622
		[Token(Token = "0x4001DC6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105488", Offset = "0x1105488")]
		public EAccount.PlatformType platform_type;
	}
}
