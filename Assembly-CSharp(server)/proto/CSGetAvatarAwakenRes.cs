using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200080E RID: 2062
	[Token(Token = "0x200080E")]
	[ProtoContract]
	public class CSGetAvatarAwakenRes
	{
		// Token: 0x0600251D RID: 9501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251D")]
		[Address(RVA = "0x21B216C", Offset = "0x21B216C", VA = "0x7BBC9B216C")]
		public CSGetAvatarAwakenRes()
		{
		}

		// Token: 0x04002702 RID: 9986
		[Token(Token = "0x4002702")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110BD0", Offset = "0x1110BD0")]
		public List<AvatarAwaken> infos;
	}
}
