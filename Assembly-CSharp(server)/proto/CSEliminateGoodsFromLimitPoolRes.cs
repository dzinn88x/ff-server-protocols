using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000866 RID: 2150
	[Token(Token = "0x2000866")]
	[ProtoContract]
	public class CSEliminateGoodsFromLimitPoolRes
	{
		// Token: 0x06002574 RID: 9588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002574")]
		[Address(RVA = "0x21B1170", Offset = "0x21B1170", VA = "0x7BBC9B1170")]
		public CSEliminateGoodsFromLimitPoolRes()
		{
		}

		// Token: 0x04002826 RID: 10278
		[Token(Token = "0x4002826")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112840", Offset = "0x1112840")]
		public uint after_eliminate;
	}
}
