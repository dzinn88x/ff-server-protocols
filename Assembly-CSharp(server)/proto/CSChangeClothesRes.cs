using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000808 RID: 2056
	[Token(Token = "0x2000808")]
	[ProtoContract]
	public class CSChangeClothesRes
	{
		// Token: 0x06002517 RID: 9495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002517")]
		[Address(RVA = "0x21B0640", Offset = "0x21B0640", VA = "0x7BBC9B0640")]
		public CSChangeClothesRes()
		{
		}

		// Token: 0x040026F9 RID: 9977
		[Token(Token = "0x40026F9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110AF4", Offset = "0x1110AF4")]
		public AvatarProfile profile;
	}
}
