using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200089C RID: 2204
	[Token(Token = "0x200089C")]
	[ProtoContract]
	public class CSGetRateAppSwitchRes
	{
		// Token: 0x060025AA RID: 9642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025AA")]
		[Address(RVA = "0x21B5834", Offset = "0x21B5834", VA = "0x7BBC9B5834")]
		public CSGetRateAppSwitchRes()
		{
		}

		// Token: 0x040028FB RID: 10491
		[Token(Token = "0x40028FB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113E34", Offset = "0x1113E34")]
		public RateAppSwitchDesc switch_desc;
	}
}
