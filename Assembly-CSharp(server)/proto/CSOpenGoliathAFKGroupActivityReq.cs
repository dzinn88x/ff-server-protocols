using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000988 RID: 2440
	[Token(Token = "0x2000988")]
	[ProtoContract]
	public class CSOpenGoliathAFKGroupActivityReq
	{
		// Token: 0x06002696 RID: 9878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002696")]
		[Address(RVA = "0x21B6CA4", Offset = "0x21B6CA4", VA = "0x7BBC9B6CA4")]
		public CSOpenGoliathAFKGroupActivityReq()
		{
		}

		// Token: 0x04002C38 RID: 11320
		[Token(Token = "0x4002C38")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119C80", Offset = "0x1119C80")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1119C80", Offset = "0x1119C80")]
		public string language;
	}
}
