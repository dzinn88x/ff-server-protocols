using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004A0 RID: 1184
	[Token(Token = "0x20004A0")]
	[ProtoContract]
	public class GroupLeaveReq
	{
		// Token: 0x06001DC2 RID: 7618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC2")]
		[Address(RVA = "0x24A3D10", Offset = "0x24A3D10", VA = "0x7BBCCA3D10")]
		public GroupLeaveReq()
		{
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x0000CB10 File Offset: 0x0000AD10
		// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FF")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155DB8", Offset = "0x1155DB8")]
		public ulong group_id
		{
			[Token(Token = "0x6001DC3")]
			[Address(RVA = "0x24A3D18", Offset = "0x24A3D18", VA = "0x7BBCCA3D18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11363C4", Offset = "0x11363C4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001DC4")]
			[Address(RVA = "0x24A3D20", Offset = "0x24A3D20", VA = "0x7BBCCA3D20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11363D4", Offset = "0x11363D4")]
			set
			{
			}
		}

		// Token: 0x04001624 RID: 5668
		[Token(Token = "0x4001624")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11027A4", Offset = "0x11027A4")]
		private ulong <group_id>k__BackingField;
	}
}
