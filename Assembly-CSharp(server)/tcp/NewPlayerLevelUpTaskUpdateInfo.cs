using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000452 RID: 1106
	[Token(Token = "0x2000452")]
	[ProtoContract]
	public class NewPlayerLevelUpTaskUpdateInfo
	{
		// Token: 0x06001C38 RID: 7224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C38")]
		[Address(RVA = "0x24A562C", Offset = "0x24A562C", VA = "0x7BBCCA562C")]
		public NewPlayerLevelUpTaskUpdateInfo()
		{
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
		// (set) Token: 0x06001C3A RID: 7226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000353")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115483C", Offset = "0x115483C")]
		public uint id
		{
			[Token(Token = "0x6001C39")]
			[Address(RVA = "0x24A5634", Offset = "0x24A5634", VA = "0x7BBCCA5634")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134E44", Offset = "0x1134E44")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C3A")]
			[Address(RVA = "0x24A563C", Offset = "0x24A563C", VA = "0x7BBCCA563C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134E54", Offset = "0x1134E54")]
			set
			{
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		// (set) Token: 0x06001C3C RID: 7228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000354")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154850", Offset = "0x1154850")]
		public uint state
		{
			[Token(Token = "0x6001C3B")]
			[Address(RVA = "0x24A5644", Offset = "0x24A5644", VA = "0x7BBCCA5644")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134E64", Offset = "0x1134E64")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C3C")]
			[Address(RVA = "0x24A564C", Offset = "0x24A564C", VA = "0x7BBCCA564C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134E74", Offset = "0x1134E74")]
			set
			{
			}
		}

		// Token: 0x04001489 RID: 5257
		[Token(Token = "0x4001489")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101CE4", Offset = "0x1101CE4")]
		private uint <id>k__BackingField;

		// Token: 0x0400148A RID: 5258
		[Token(Token = "0x400148A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101CF4", Offset = "0x1101CF4")]
		private uint <state>k__BackingField;
	}
}
