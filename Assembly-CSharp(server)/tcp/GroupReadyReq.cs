using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004A5 RID: 1189
	[Token(Token = "0x20004A5")]
	[ProtoContract]
	public class GroupReadyReq
	{
		// Token: 0x06001DD7 RID: 7639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD7")]
		[Address(RVA = "0x24A3FD8", Offset = "0x24A3FD8", VA = "0x7BBCCA3FD8")]
		public GroupReadyReq()
		{
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x0000CB88 File Offset: 0x0000AD88
		// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000407")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155E58", Offset = "0x1155E58")]
		public ulong group_id
		{
			[Token(Token = "0x6001DD8")]
			[Address(RVA = "0x24A3FE0", Offset = "0x24A3FE0", VA = "0x7BBCCA3FE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11364C4", Offset = "0x11364C4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001DD9")]
			[Address(RVA = "0x24A3FE8", Offset = "0x24A3FE8", VA = "0x7BBCCA3FE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11364D4", Offset = "0x11364D4")]
			set
			{
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
		// (set) Token: 0x06001DDB RID: 7643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000408")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155E6C", Offset = "0x1155E6C")]
		public bool ready
		{
			[Token(Token = "0x6001DDA")]
			[Address(RVA = "0x24A3FF0", Offset = "0x24A3FF0", VA = "0x7BBCCA3FF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11364E4", Offset = "0x11364E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001DDB")]
			[Address(RVA = "0x24A3FF8", Offset = "0x24A3FF8", VA = "0x7BBCCA3FF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11364F4", Offset = "0x11364F4")]
			set
			{
			}
		}

		// Token: 0x0400162C RID: 5676
		[Token(Token = "0x400162C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102824", Offset = "0x1102824")]
		private ulong <group_id>k__BackingField;

		// Token: 0x0400162D RID: 5677
		[Token(Token = "0x400162D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102834", Offset = "0x1102834")]
		private bool <ready>k__BackingField;
	}
}
