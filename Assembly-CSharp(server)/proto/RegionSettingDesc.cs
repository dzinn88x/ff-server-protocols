using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A19 RID: 2585
	[Token(Token = "0x2000A19")]
	[ProtoContract]
	public class RegionSettingDesc
	{
		// Token: 0x06002723 RID: 10019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002723")]
		[Address(RVA = "0x24A0008", Offset = "0x24A0008", VA = "0x7BBCCA0008")]
		public RegionSettingDesc()
		{
		}

		// Token: 0x04002F2F RID: 12079
		[Token(Token = "0x4002F2F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EBA4", Offset = "0x111EBA4")]
		public uint id;

		// Token: 0x04002F30 RID: 12080
		[Token(Token = "0x4002F30")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EBB8", Offset = "0x111EBB8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111EBB8", Offset = "0x111EBB8")]
		public string region_server;
	}
}
