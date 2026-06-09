using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AF2 RID: 2802
	[Token(Token = "0x2000AF2")]
	[ProtoContract]
	public class WhiteListConfigDesc
	{
		// Token: 0x060027FA RID: 10234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FA")]
		[Address(RVA = "0x24A1A40", Offset = "0x24A1A40", VA = "0x7BBCCA1A40")]
		public WhiteListConfigDesc()
		{
		}

		// Token: 0x040034D1 RID: 13521
		[Token(Token = "0x40034D1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11294DC", Offset = "0x11294DC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11294DC", Offset = "0x11294DC")]
		public string region;

		// Token: 0x040034D2 RID: 13522
		[Token(Token = "0x40034D2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112952C", Offset = "0x112952C")]
		public bool is_open;
	}
}
