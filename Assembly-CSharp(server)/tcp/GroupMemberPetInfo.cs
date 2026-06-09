using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004AD RID: 1197
	[Token(Token = "0x20004AD")]
	[ProtoContract]
	public class GroupMemberPetInfo
	{
		// Token: 0x06001E61 RID: 7777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E61")]
		[Address(RVA = "0x24A3F3C", Offset = "0x24A3F3C", VA = "0x7BBCCA3F3C")]
		public GroupMemberPetInfo()
		{
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		// (set) Token: 0x06001E63 RID: 7779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000448")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11566C8", Offset = "0x11566C8")]
		public uint id
		{
			[Token(Token = "0x6001E62")]
			[Address(RVA = "0x24A3FA0", Offset = "0x24A3FA0", VA = "0x7BBCCA3FA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136CE4", Offset = "0x1136CE4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E63")]
			[Address(RVA = "0x24A3FA8", Offset = "0x24A3FA8", VA = "0x7BBCCA3FA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136CF4", Offset = "0x1136CF4")]
			set
			{
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E65 RID: 7781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000449")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11566DC", Offset = "0x11566DC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11566DC", Offset = "0x11566DC")]
		public string name
		{
			[Token(Token = "0x6001E64")]
			[Address(RVA = "0x24A3FB0", Offset = "0x24A3FB0", VA = "0x7BBCCA3FB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136D04", Offset = "0x1136D04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E65")]
			[Address(RVA = "0x24A3F98", Offset = "0x24A3F98", VA = "0x7BBCCA3F98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136D14", Offset = "0x1136D14")]
			set
			{
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115672C", Offset = "0x115672C")]
		public uint level
		{
			[Token(Token = "0x6001E66")]
			[Address(RVA = "0x24A3FB8", Offset = "0x24A3FB8", VA = "0x7BBCCA3FB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136D24", Offset = "0x1136D24")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E67")]
			[Address(RVA = "0x24A3FC0", Offset = "0x24A3FC0", VA = "0x7BBCCA3FC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136D34", Offset = "0x1136D34")]
			set
			{
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x0000D008 File Offset: 0x0000B208
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156740", Offset = "0x1156740")]
		public uint skin_id
		{
			[Token(Token = "0x6001E68")]
			[Address(RVA = "0x24A3FC8", Offset = "0x24A3FC8", VA = "0x7BBCCA3FC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136D44", Offset = "0x1136D44")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E69")]
			[Address(RVA = "0x24A3FD0", Offset = "0x24A3FD0", VA = "0x7BBCCA3FD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136D54", Offset = "0x1136D54")]
			set
			{
			}
		}

		// Token: 0x0400166D RID: 5741
		[Token(Token = "0x400166D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102C34", Offset = "0x1102C34")]
		private uint <id>k__BackingField;

		// Token: 0x0400166E RID: 5742
		[Token(Token = "0x400166E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102C44", Offset = "0x1102C44")]
		private string <name>k__BackingField;

		// Token: 0x0400166F RID: 5743
		[Token(Token = "0x400166F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102C54", Offset = "0x1102C54")]
		private uint <level>k__BackingField;

		// Token: 0x04001670 RID: 5744
		[Token(Token = "0x4001670")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102C64", Offset = "0x1102C64")]
		private uint <skin_id>k__BackingField;
	}
}
