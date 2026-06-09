using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200080B RID: 2059
	[Token(Token = "0x200080B")]
	[ProtoContract]
	public class CSGetUnlockProfileInfoRes
	{
		// Token: 0x0600251A RID: 9498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251A")]
		[Address(RVA = "0x21B60A0", Offset = "0x21B60A0", VA = "0x7BBC9B60A0")]
		public CSGetUnlockProfileInfoRes()
		{
		}

		// Token: 0x040026FF RID: 9983
		[Token(Token = "0x40026FF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110B6C", Offset = "0x1110B6C")]
		public List<UnlockProfileConfig> infos;
	}
}
