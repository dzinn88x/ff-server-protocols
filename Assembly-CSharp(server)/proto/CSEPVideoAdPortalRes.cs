using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000889 RID: 2185
	[Token(Token = "0x2000889")]
	[ProtoContract]
	public class CSEPVideoAdPortalRes
	{
		// Token: 0x06002597 RID: 9623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002597")]
		[Address(RVA = "0x21B110C", Offset = "0x21B110C", VA = "0x7BBC9B110C")]
		public CSEPVideoAdPortalRes()
		{
		}

		// Token: 0x040028C3 RID: 10435
		[Token(Token = "0x40028C3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113948", Offset = "0x1113948")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1113948", Offset = "0x1113948")]
		public string video_url;
	}
}
