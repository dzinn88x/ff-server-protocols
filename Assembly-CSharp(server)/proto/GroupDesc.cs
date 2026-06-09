using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A13 RID: 2579
	[Token(Token = "0x2000A13")]
	[ProtoContract]
	public class GroupDesc
	{
		// Token: 0x0600271D RID: 10013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271D")]
		[Address(RVA = "0x21BB15C", Offset = "0x21BB15C", VA = "0x7BBC9BB15C")]
		public GroupDesc()
		{
		}

		// Token: 0x04002F11 RID: 12049
		[Token(Token = "0x4002F11")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E848", Offset = "0x111E848")]
		public bool enable_region;

		// Token: 0x04002F12 RID: 12050
		[Token(Token = "0x4002F12")]
		[FieldOffset(Offset = "0x11")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E85C", Offset = "0x111E85C")]
		public bool enable_hacker_auto_group;

		// Token: 0x04002F13 RID: 12051
		[Token(Token = "0x4002F13")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E870", Offset = "0x111E870")]
		public uint idc_auto_group_timeout;
	}
}
