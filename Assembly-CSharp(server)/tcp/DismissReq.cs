using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000474 RID: 1140
	[Token(Token = "0x2000474")]
	[ProtoContract]
	public class DismissReq
	{
		// Token: 0x06001CC1 RID: 7361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC1")]
		[Address(RVA = "0x24A2C54", Offset = "0x24A2C54", VA = "0x7BBCCA2C54")]
		public DismissReq()
		{
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		// (set) Token: 0x06001CC3 RID: 7363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154F44", Offset = "0x1154F44")]
		public ulong clan_id
		{
			[Token(Token = "0x6001CC2")]
			[Address(RVA = "0x24A2CB8", Offset = "0x24A2CB8", VA = "0x7BBCCA2CB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135564", Offset = "0x1135564")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CC3")]
			[Address(RVA = "0x24A2CC0", Offset = "0x24A2CC0", VA = "0x7BBCCA2CC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135574", Offset = "0x1135574")]
			set
			{
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154F58", Offset = "0x1154F58")]
		public ulong dismisser_id
		{
			[Token(Token = "0x6001CC4")]
			[Address(RVA = "0x24A2CC8", Offset = "0x24A2CC8", VA = "0x7BBCCA2CC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135584", Offset = "0x1135584")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CC5")]
			[Address(RVA = "0x24A2CD0", Offset = "0x24A2CD0", VA = "0x7BBCCA2CD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135594", Offset = "0x1135594")]
			set
			{
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700038E")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1154F6C", Offset = "0x1154F6C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154F6C", Offset = "0x1154F6C")]
		public string clan_name
		{
			[Token(Token = "0x6001CC6")]
			[Address(RVA = "0x24A2CD8", Offset = "0x24A2CD8", VA = "0x7BBCCA2CD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11355A4", Offset = "0x11355A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CC7")]
			[Address(RVA = "0x24A2CB0", Offset = "0x24A2CB0", VA = "0x7BBCCA2CB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11355B4", Offset = "0x11355B4")]
			set
			{
			}
		}

		// Token: 0x04001507 RID: 5383
		[Token(Token = "0x4001507")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102074", Offset = "0x1102074")]
		private ulong <clan_id>k__BackingField;

		// Token: 0x04001508 RID: 5384
		[Token(Token = "0x4001508")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102084", Offset = "0x1102084")]
		private ulong <dismisser_id>k__BackingField;

		// Token: 0x04001509 RID: 5385
		[Token(Token = "0x4001509")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102094", Offset = "0x1102094")]
		private string <clan_name>k__BackingField;
	}
}
