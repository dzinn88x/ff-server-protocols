using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004E9 RID: 1257
	[Token(Token = "0x20004E9")]
	[ProtoContract]
	public class LightFeatureNtf
	{
		// Token: 0x06001F7D RID: 8061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7D")]
		[Address(RVA = "0x24A4670", Offset = "0x24A4670", VA = "0x7BBCCA4670")]
		public LightFeatureNtf()
		{
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F7F RID: 8063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157564", Offset = "0x1157564")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1157564", Offset = "0x1157564")]
		public string feature_name
		{
			[Token(Token = "0x6001F7E")]
			[Address(RVA = "0x24A46D4", Offset = "0x24A46D4", VA = "0x7BBCCA46D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137BE4", Offset = "0x1137BE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F7F")]
			[Address(RVA = "0x24A46CC", Offset = "0x24A46CC", VA = "0x7BBCCA46CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137BF4", Offset = "0x1137BF4")]
			set
			{
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001F80 RID: 8064 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F81 RID: 8065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11575B4", Offset = "0x11575B4")]
		public byte[] feature_data
		{
			[Token(Token = "0x6001F80")]
			[Address(RVA = "0x24A46DC", Offset = "0x24A46DC", VA = "0x7BBCCA46DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137C04", Offset = "0x1137C04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F81")]
			[Address(RVA = "0x24A46E4", Offset = "0x24A46E4", VA = "0x7BBCCA46E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137C14", Offset = "0x1137C14")]
			set
			{
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001F82 RID: 8066 RVA: 0x0000D7A0 File Offset: 0x0000B9A0
		// (set) Token: 0x06001F83 RID: 8067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C2")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11575C8", Offset = "0x11575C8")]
		public uint data_len
		{
			[Token(Token = "0x6001F82")]
			[Address(RVA = "0x24A46EC", Offset = "0x24A46EC", VA = "0x7BBCCA46EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137C24", Offset = "0x1137C24")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F83")]
			[Address(RVA = "0x24A46F4", Offset = "0x24A46F4", VA = "0x7BBCCA46F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137C34", Offset = "0x1137C34")]
			set
			{
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001F84 RID: 8068 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
		// (set) Token: 0x06001F85 RID: 8069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C3")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11575DC", Offset = "0x11575DC")]
		public uint data_crc
		{
			[Token(Token = "0x6001F84")]
			[Address(RVA = "0x24A46FC", Offset = "0x24A46FC", VA = "0x7BBCCA46FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137C44", Offset = "0x1137C44")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F85")]
			[Address(RVA = "0x24A4704", Offset = "0x24A4704", VA = "0x7BBCCA4704")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137C54", Offset = "0x1137C54")]
			set
			{
			}
		}

		// Token: 0x04001748 RID: 5960
		[Token(Token = "0x4001748")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11033B4", Offset = "0x11033B4")]
		private string <feature_name>k__BackingField;

		// Token: 0x04001749 RID: 5961
		[Token(Token = "0x4001749")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11033C4", Offset = "0x11033C4")]
		private byte[] <feature_data>k__BackingField;

		// Token: 0x0400174A RID: 5962
		[Token(Token = "0x400174A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11033D4", Offset = "0x11033D4")]
		private uint <data_len>k__BackingField;

		// Token: 0x0400174B RID: 5963
		[Token(Token = "0x400174B")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11033E4", Offset = "0x11033E4")]
		private uint <data_crc>k__BackingField;
	}
}
