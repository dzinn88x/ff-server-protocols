using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007FF RID: 2047
	[Token(Token = "0x20007FF")]
	[ProtoContract]
	public class CSGetProfileListRes
	{
		// Token: 0x0600250E RID: 9486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250E")]
		[Address(RVA = "0x21B56B8", Offset = "0x21B56B8", VA = "0x7BBC9B56B8")]
		public CSGetProfileListRes()
		{
		}

		// Token: 0x040026E4 RID: 9956
		[Token(Token = "0x40026E4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110900", Offset = "0x1110900")]
		public List<AvatarProfile> profiles;
	}
}
