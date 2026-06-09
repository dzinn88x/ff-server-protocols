using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000932 RID: 2354
	[Token(Token = "0x2000932")]
	[ProtoContract]
	public class CSGetFreshActivityInfoRes
	{
		// Token: 0x06002640 RID: 9792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002640")]
		[Address(RVA = "0x21B3824", Offset = "0x21B3824", VA = "0x7BBC9B3824")]
		public CSGetFreshActivityInfoRes()
		{
		}

		// Token: 0x04002B84 RID: 11140
		[Token(Token = "0x4002B84")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118BB4", Offset = "0x1118BB4")]
		public uint day;

		// Token: 0x04002B85 RID: 11141
		[Token(Token = "0x4002B85")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118BC8", Offset = "0x1118BC8")]
		public List<ActivityInfo> activitys;

		// Token: 0x04002B86 RID: 11142
		[Token(Token = "0x4002B86")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118BDC", Offset = "0x1118BDC")]
		public ulong expire_time;
	}
}
