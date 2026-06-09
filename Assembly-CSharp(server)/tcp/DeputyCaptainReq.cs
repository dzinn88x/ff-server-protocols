using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000478 RID: 1144
	[Token(Token = "0x2000478")]
	[ProtoContract]
	public class DeputyCaptainReq
	{
		// Token: 0x06001CDB RID: 7387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CDB")]
		[Address(RVA = "0x24A2BA0", Offset = "0x24A2BA0", VA = "0x7BBCCA2BA0")]
		public DeputyCaptainReq()
		{
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		// (set) Token: 0x06001CDD RID: 7389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000397")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115505C", Offset = "0x115505C")]
		public ulong clan_id
		{
			[Token(Token = "0x6001CDC")]
			[Address(RVA = "0x24A2BA8", Offset = "0x24A2BA8", VA = "0x7BBCCA2BA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11356C4", Offset = "0x11356C4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CDD")]
			[Address(RVA = "0x24A2BB0", Offset = "0x24A2BB0", VA = "0x7BBCCA2BB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11356D4", Offset = "0x11356D4")]
			set
			{
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		// (set) Token: 0x06001CDF RID: 7391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000398")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155070", Offset = "0x1155070")]
		public ulong deputy_id
		{
			[Token(Token = "0x6001CDE")]
			[Address(RVA = "0x24A2BB8", Offset = "0x24A2BB8", VA = "0x7BBCCA2BB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11356E4", Offset = "0x11356E4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CDF")]
			[Address(RVA = "0x24A2BC0", Offset = "0x24A2BC0", VA = "0x7BBCCA2BC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11356F4", Offset = "0x11356F4")]
			set
			{
			}
		}

		// Token: 0x04001512 RID: 5394
		[Token(Token = "0x4001512")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102124", Offset = "0x1102124")]
		private ulong <clan_id>k__BackingField;

		// Token: 0x04001513 RID: 5395
		[Token(Token = "0x4001513")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102134", Offset = "0x1102134")]
		private ulong <deputy_id>k__BackingField;
	}
}
