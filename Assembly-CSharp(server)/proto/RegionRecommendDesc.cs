using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A20 RID: 2592
	[Token(Token = "0x2000A20")]
	[ProtoContract]
	public class RegionRecommendDesc
	{
		// Token: 0x0600272A RID: 10026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272A")]
		[Address(RVA = "0x249FF84", Offset = "0x249FF84", VA = "0x7BBCC9FF84")]
		public RegionRecommendDesc()
		{
		}

		// Token: 0x04002F42 RID: 12098
		[Token(Token = "0x4002F42")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EF00", Offset = "0x111EF00")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111EF00", Offset = "0x111EF00")]
		public string language;

		// Token: 0x04002F43 RID: 12099
		[Token(Token = "0x4002F43")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EF50", Offset = "0x111EF50")]
		public List<string> recommend_region_servers;
	}
}
