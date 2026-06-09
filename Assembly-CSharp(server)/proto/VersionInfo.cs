using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000684 RID: 1668
	[Token(Token = "0x2000684")]
	[ProtoContract]
	public class VersionInfo
	{
		// Token: 0x060023C5 RID: 9157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C5")]
		[Address(RVA = "0x24A1450", Offset = "0x24A1450", VA = "0x7BBCCA1450")]
		public VersionInfo()
		{
		}

		// Token: 0x040020E2 RID: 8418
		[Token(Token = "0x40020E2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11089F8", Offset = "0x11089F8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11089F8", Offset = "0x11089F8")]
		public string node;

		// Token: 0x040020E3 RID: 8419
		[Token(Token = "0x40020E3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108A48", Offset = "0x1108A48")]
		public long version;
	}
}
