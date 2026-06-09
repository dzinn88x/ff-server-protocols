using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000888 RID: 2184
	[Token(Token = "0x2000888")]
	[ProtoContract]
	public class CSEPVideoAdPortalReq
	{
		// Token: 0x06002596 RID: 9622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002596")]
		[Address(RVA = "0x21B10B0", Offset = "0x21B10B0", VA = "0x7BBC9B10B0")]
		public CSEPVideoAdPortalReq()
		{
		}

		// Token: 0x040028C2 RID: 10434
		[Token(Token = "0x40028C2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11138F8", Offset = "0x11138F8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11138F8", Offset = "0x11138F8")]
		public string language;
	}
}
