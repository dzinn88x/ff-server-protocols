using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A1E RID: 2590
	[Token(Token = "0x2000A1E")]
	[ProtoContract]
	public class RegionLockDesc
	{
		// Token: 0x06002728 RID: 10024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002728")]
		[Address(RVA = "0x249FE84", Offset = "0x249FE84", VA = "0x7BBCC9FE84")]
		public RegionLockDesc()
		{
		}

		// Token: 0x04002F3C RID: 12092
		[Token(Token = "0x4002F3C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EDD4", Offset = "0x111EDD4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111EDD4", Offset = "0x111EDD4")]
		public string region_server;

		// Token: 0x04002F3D RID: 12093
		[Token(Token = "0x4002F3D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EE24", Offset = "0x111EE24")]
		public List<string> ip_regions;

		// Token: 0x04002F3E RID: 12094
		[Token(Token = "0x4002F3E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EE38", Offset = "0x111EE38")]
		public List<string> languages;

		// Token: 0x04002F3F RID: 12095
		[Token(Token = "0x4002F3F")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EE4C", Offset = "0x111EE4C")]
		public long active_time;
	}
}
