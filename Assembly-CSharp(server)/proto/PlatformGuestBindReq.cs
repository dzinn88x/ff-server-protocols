using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000616 RID: 1558
	[Token(Token = "0x2000616")]
	[ProtoContract]
	public class PlatformGuestBindReq
	{
		// Token: 0x06002391 RID: 9105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002391")]
		[Address(RVA = "0x249F3F0", Offset = "0x249F3F0", VA = "0x7BBCC9F3F0")]
		public PlatformGuestBindReq()
		{
		}

		// Token: 0x04001F05 RID: 7941
		[Token(Token = "0x4001F05")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11078C8", Offset = "0x11078C8")]
		public ulong account_id;

		// Token: 0x04001F06 RID: 7942
		[Token(Token = "0x4001F06")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11078DC", Offset = "0x11078DC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11078DC", Offset = "0x11078DC")]
		public string region;

		// Token: 0x04001F07 RID: 7943
		[Token(Token = "0x4001F07")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110792C", Offset = "0x110792C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110792C", Offset = "0x110792C")]
		public string guest_open_id;

		// Token: 0x04001F08 RID: 7944
		[Token(Token = "0x4001F08")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110797C", Offset = "0x110797C")]
		public uint guest_platform_type;

		// Token: 0x04001F09 RID: 7945
		[Token(Token = "0x4001F09")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1107990", Offset = "0x1107990")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107990", Offset = "0x1107990")]
		public string guest_access_token;

		// Token: 0x04001F0A RID: 7946
		[Token(Token = "0x4001F0A")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11079E0", Offset = "0x11079E0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11079E0", Offset = "0x11079E0")]
		public string access_token;

		// Token: 0x04001F0B RID: 7947
		[Token(Token = "0x4001F0B")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1107A30", Offset = "0x1107A30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107A30", Offset = "0x1107A30")]
		public string open_id;

		// Token: 0x04001F0C RID: 7948
		[Token(Token = "0x4001F0C")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107A80", Offset = "0x1107A80")]
		public uint platform_type;

		// Token: 0x04001F0D RID: 7949
		[Token(Token = "0x4001F0D")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107A94", Offset = "0x1107A94")]
		public uint platform_sdk_id;

		// Token: 0x04001F0E RID: 7950
		[Token(Token = "0x4001F0E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107AA8", Offset = "0x1107AA8")]
		public ulong uid;

		// Token: 0x04001F0F RID: 7951
		[Token(Token = "0x4001F0F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1107ABC", Offset = "0x1107ABC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107ABC", Offset = "0x1107ABC")]
		public string lock_region;

		// Token: 0x04001F10 RID: 7952
		[Token(Token = "0x4001F10")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107B0C", Offset = "0x1107B0C")]
		public uint client_type;

		// Token: 0x04001F11 RID: 7953
		[Token(Token = "0x4001F11")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107B20", Offset = "0x1107B20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1107B20", Offset = "0x1107B20")]
		public string nickname;

		// Token: 0x04001F12 RID: 7954
		[Token(Token = "0x4001F12")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1107B70", Offset = "0x1107B70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107B70", Offset = "0x1107B70")]
		public string ip_address;
	}
}
