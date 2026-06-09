using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AD9 RID: 2777
	[Token(Token = "0x2000AD9")]
	[ProtoContract]
	public class OpenIDWhiteListDesc
	{
		// Token: 0x060027E1 RID: 10209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E1")]
		[Address(RVA = "0x249ED34", Offset = "0x249ED34", VA = "0x7BBCC9ED34")]
		public OpenIDWhiteListDesc()
		{
		}

		// Token: 0x04003429 RID: 13353
		[Token(Token = "0x4003429")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127E98", Offset = "0x1127E98")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1127E98", Offset = "0x1127E98")]
		public string open_id;
	}
}
