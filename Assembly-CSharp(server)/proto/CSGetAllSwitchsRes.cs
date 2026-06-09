using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000899 RID: 2201
	[Token(Token = "0x2000899")]
	[ProtoContract]
	public class CSGetAllSwitchsRes
	{
		// Token: 0x060025A7 RID: 9639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A7")]
		[Address(RVA = "0x21B1E38", Offset = "0x21B1E38", VA = "0x7BBC9B1E38")]
		public CSGetAllSwitchsRes()
		{
		}

		// Token: 0x040028F8 RID: 10488
		[Token(Token = "0x40028F8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113DF8", Offset = "0x1113DF8")]
		public List<SwitchDesc> switchs;
	}
}
