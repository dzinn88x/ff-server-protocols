using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000690 RID: 1680
	[Token(Token = "0x2000690")]
	[ProtoContract]
	public class BlacklistRes
	{
		// Token: 0x060023CE RID: 9166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CE")]
		[Address(RVA = "0x21AFB28", Offset = "0x21AFB28", VA = "0x7BBC9AFB28")]
		public BlacklistRes()
		{
		}

		// Token: 0x0400210C RID: 8460
		[Token(Token = "0x400210C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108DCC", Offset = "0x1108DCC")]
		public ulong account_id;

		// Token: 0x0400210D RID: 8461
		[Token(Token = "0x400210D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1108DE0", Offset = "0x1108DE0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108DE0", Offset = "0x1108DE0")]
		public string device_id;

		// Token: 0x0400210E RID: 8462
		[Token(Token = "0x400210E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108E30", Offset = "0x1108E30")]
		public uint ban_reason;

		// Token: 0x0400210F RID: 8463
		[Token(Token = "0x400210F")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108E44", Offset = "0x1108E44")]
		public uint ban_time;

		// Token: 0x04002110 RID: 8464
		[Token(Token = "0x4002110")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1108E58", Offset = "0x1108E58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108E58", Offset = "0x1108E58")]
		public string ban_reason_detail;

		// Token: 0x04002111 RID: 8465
		[Token(Token = "0x4002111")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108EA8", Offset = "0x1108EA8")]
		public bool is_in_blacklist;

		// Token: 0x04002112 RID: 8466
		[Token(Token = "0x4002112")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108EBC", Offset = "0x1108EBC")]
		public uint ban_expire_duration;
	}
}
