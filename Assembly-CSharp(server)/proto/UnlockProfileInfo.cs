using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A5C RID: 2652
	[Token(Token = "0x2000A5C")]
	[ProtoContract]
	public class UnlockProfileInfo
	{
		// Token: 0x06002766 RID: 10086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002766")]
		[Address(RVA = "0x24A13C4", Offset = "0x24A13C4", VA = "0x7BBCCA13C4")]
		public UnlockProfileInfo()
		{
		}

		// Token: 0x0400307C RID: 12412
		[Token(Token = "0x400307C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121250", Offset = "0x1121250")]
		public uint avatar_id;

		// Token: 0x0400307D RID: 12413
		[Token(Token = "0x400307D")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121264", Offset = "0x1121264")]
		public uint unlock_level;

		// Token: 0x0400307E RID: 12414
		[Token(Token = "0x400307E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121278", Offset = "0x1121278")]
		public uint required_level;

		// Token: 0x0400307F RID: 12415
		[Token(Token = "0x400307F")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112128C", Offset = "0x112128C")]
		public uint avatar_debris_id;

		// Token: 0x04003080 RID: 12416
		[Token(Token = "0x4003080")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11212A0", Offset = "0x11212A0")]
		public uint avatar_debris_num;

		// Token: 0x04003081 RID: 12417
		[Token(Token = "0x4003081")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11212B4", Offset = "0x11212B4")]
		public List<AwardDesc> awards;
	}
}
