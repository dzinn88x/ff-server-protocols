using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200079A RID: 1946
	[Token(Token = "0x200079A")]
	[ProtoContract]
	public class CSGetPayLevelConfigRes
	{
		// Token: 0x060024A9 RID: 9385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A9")]
		[Address(RVA = "0x21B5140", Offset = "0x21B5140", VA = "0x7BBC9B5140")]
		public CSGetPayLevelConfigRes()
		{
		}

		// Token: 0x040025AA RID: 9642
		[Token(Token = "0x40025AA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E4C0", Offset = "0x110E4C0")]
		public List<PayLevelConfig> pay_level_config;
	}
}
