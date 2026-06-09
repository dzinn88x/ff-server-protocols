using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009FB RID: 2555
	[Token(Token = "0x20009FB")]
	[ProtoContract]
	public class ActivityBingoRewardsDesc
	{
		// Token: 0x06002705 RID: 9989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002705")]
		[Address(RVA = "0x21AEAE0", Offset = "0x21AEAE0", VA = "0x7BBC9AEAE0")]
		public ActivityBingoRewardsDesc()
		{
		}

		// Token: 0x04002E6F RID: 11887
		[Token(Token = "0x4002E6F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D394", Offset = "0x111D394")]
		public uint id;

		// Token: 0x04002E70 RID: 11888
		[Token(Token = "0x4002E70")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D3A8", Offset = "0x111D3A8")]
		public uint level;

		// Token: 0x04002E71 RID: 11889
		[Token(Token = "0x4002E71")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D3BC", Offset = "0x111D3BC")]
		public uint[] activity_ids;

		// Token: 0x04002E72 RID: 11890
		[Token(Token = "0x4002E72")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D3F8", Offset = "0x111D3F8")]
		public List<AwardDesc> awards;
	}
}
