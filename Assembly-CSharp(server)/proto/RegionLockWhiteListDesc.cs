using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A1F RID: 2591
	[Token(Token = "0x2000A1F")]
	[ProtoContract]
	public class RegionLockWhiteListDesc
	{
		// Token: 0x06002729 RID: 10025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002729")]
		[Address(RVA = "0x249FF28", Offset = "0x249FF28", VA = "0x7BBCC9FF28")]
		public RegionLockWhiteListDesc()
		{
		}

		// Token: 0x04002F40 RID: 12096
		[Token(Token = "0x4002F40")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EE60", Offset = "0x111EE60")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111EE60", Offset = "0x111EE60")]
		public string ip;

		// Token: 0x04002F41 RID: 12097
		[Token(Token = "0x4002F41")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111EEB0", Offset = "0x111EEB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EEB0", Offset = "0x111EEB0")]
		public string lock_region;
	}
}
