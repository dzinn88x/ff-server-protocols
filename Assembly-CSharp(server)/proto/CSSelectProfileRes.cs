using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000802 RID: 2050
	[Token(Token = "0x2000802")]
	[ProtoContract]
	public class CSSelectProfileRes
	{
		// Token: 0x06002511 RID: 9489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002511")]
		[Address(RVA = "0x21B75F8", Offset = "0x21B75F8", VA = "0x7BBC9B75F8")]
		public CSSelectProfileRes()
		{
		}

		// Token: 0x040026E8 RID: 9960
		[Token(Token = "0x40026E8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110978", Offset = "0x1110978")]
		public AvatarProfile profile;
	}
}
