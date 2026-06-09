using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008BB RID: 2235
	[Token(Token = "0x20008BB")]
	[ProtoContract]
	public class CSGetPBWSpecialStoreRes
	{
		// Token: 0x060025C9 RID: 9673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C9")]
		[Address(RVA = "0x21B5058", Offset = "0x21B5058", VA = "0x7BBC9B5058")]
		public CSGetPBWSpecialStoreRes()
		{
		}

		// Token: 0x04002A0B RID: 10763
		[Token(Token = "0x4002A0B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111651C", Offset = "0x111651C")]
		public List<SpecialStoreDesc> special_stores;
	}
}
