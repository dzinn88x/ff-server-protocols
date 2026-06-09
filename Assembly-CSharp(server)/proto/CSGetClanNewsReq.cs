using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007F6 RID: 2038
	[Token(Token = "0x20007F6")]
	[ProtoContract]
	public class CSGetClanNewsReq
	{
		// Token: 0x06002505 RID: 9477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002505")]
		[Address(RVA = "0x21B2C1C", Offset = "0x21B2C1C", VA = "0x7BBC9B2C1C")]
		public CSGetClanNewsReq()
		{
		}

		// Token: 0x040026CA RID: 9930
		[Token(Token = "0x40026CA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11106F8", Offset = "0x11106F8")]
		public ulong clan_id;
	}
}
