using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000958 RID: 2392
	[Token(Token = "0x2000958")]
	[ProtoContract]
	public class CSGetRampageSettingRes
	{
		// Token: 0x06002666 RID: 9830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002666")]
		[Address(RVA = "0x21B57A8", Offset = "0x21B57A8", VA = "0x7BBC9B57A8")]
		public CSGetRampageSettingRes()
		{
		}

		// Token: 0x04002BD6 RID: 11222
		[Token(Token = "0x4002BD6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11193C0", Offset = "0x11193C0")]
		public RampageSettingDesc setting;
	}
}
