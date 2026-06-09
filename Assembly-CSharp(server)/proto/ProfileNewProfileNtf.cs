using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000811 RID: 2065
	[Token(Token = "0x2000811")]
	[ProtoContract]
	public class ProfileNewProfileNtf
	{
		// Token: 0x06002520 RID: 9504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002520")]
		[Address(RVA = "0x249F74C", Offset = "0x249F74C", VA = "0x7BBCC9F74C")]
		public ProfileNewProfileNtf()
		{
		}

		// Token: 0x0400270B RID: 9995
		[Token(Token = "0x400270B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110C84", Offset = "0x1110C84")]
		public AvatarProfile new_profile;

		// Token: 0x0400270C RID: 9996
		[Token(Token = "0x400270C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110C98", Offset = "0x1110C98")]
		public List<Item> rewards;
	}
}
