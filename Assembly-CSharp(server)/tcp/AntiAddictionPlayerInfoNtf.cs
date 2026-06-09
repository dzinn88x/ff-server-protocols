using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200044B RID: 1099
	[Token(Token = "0x200044B")]
	[ProtoContract]
	public class AntiAddictionPlayerInfoNtf
	{
		// Token: 0x06001C21 RID: 7201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C21")]
		[Address(RVA = "0x24A2560", Offset = "0x24A2560", VA = "0x7BBCCA2560")]
		public AntiAddictionPlayerInfoNtf()
		{
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C23 RID: 7203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700034A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154710", Offset = "0x1154710")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1154710", Offset = "0x1154710")]
		public string nick_name
		{
			[Token(Token = "0x6001C22")]
			[Address(RVA = "0x24A25C4", Offset = "0x24A25C4", VA = "0x7BBCCA25C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134D24", Offset = "0x1134D24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C23")]
			[Address(RVA = "0x24A25BC", Offset = "0x24A25BC", VA = "0x7BBCCA25BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134D34", Offset = "0x1134D34")]
			set
			{
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x0000BF28 File Offset: 0x0000A128
		// (set) Token: 0x06001C25 RID: 7205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700034B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154760", Offset = "0x1154760")]
		public uint ban_mode
		{
			[Token(Token = "0x6001C24")]
			[Address(RVA = "0x24A25CC", Offset = "0x24A25CC", VA = "0x7BBCCA25CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134D44", Offset = "0x1134D44")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C25")]
			[Address(RVA = "0x24A25D4", Offset = "0x24A25D4", VA = "0x7BBCCA25D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134D54", Offset = "0x1134D54")]
			set
			{
			}
		}

		// Token: 0x0400147B RID: 5243
		[Token(Token = "0x400147B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101C54", Offset = "0x1101C54")]
		private string <nick_name>k__BackingField;

		// Token: 0x0400147C RID: 5244
		[Token(Token = "0x400147C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101C64", Offset = "0x1101C64")]
		private uint <ban_mode>k__BackingField;
	}
}
