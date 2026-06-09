using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004F4 RID: 1268
	[Token(Token = "0x20004F4")]
	[ProtoContract]
	public class PresenceListRes
	{
		// Token: 0x06001FAD RID: 8109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FAD")]
		[Address(RVA = "0x24A5960", Offset = "0x24A5960", VA = "0x7BBCCA5960")]
		public PresenceListRes()
		{
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001FAE RID: 8110 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FAF RID: 8111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157820", Offset = "0x1157820")]
		public List<PresenceInfo> presences
		{
			[Token(Token = "0x6001FAE")]
			[Address(RVA = "0x24A59DC", Offset = "0x24A59DC", VA = "0x7BBCCA59DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137E84", Offset = "0x1137E84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FAF")]
			[Address(RVA = "0x24A59D4", Offset = "0x24A59D4", VA = "0x7BBCCA59D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137E94", Offset = "0x1137E94")]
			private set
			{
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x0000D908 File Offset: 0x0000BB08
		// (set) Token: 0x06001FB1 RID: 8113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D6")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157834", Offset = "0x1157834")]
		public uint account_list_type
		{
			[Token(Token = "0x6001FB0")]
			[Address(RVA = "0x24A59E4", Offset = "0x24A59E4", VA = "0x7BBCCA59E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137EA4", Offset = "0x1137EA4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001FB1")]
			[Address(RVA = "0x24A59EC", Offset = "0x24A59EC", VA = "0x7BBCCA59EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137EB4", Offset = "0x1137EB4")]
			set
			{
			}
		}

		// Token: 0x0400176B RID: 5995
		[Token(Token = "0x400176B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103504", Offset = "0x1103504")]
		private List<PresenceInfo> <presences>k__BackingField;

		// Token: 0x0400176C RID: 5996
		[Token(Token = "0x400176C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103514", Offset = "0x1103514")]
		private uint <account_list_type>k__BackingField;
	}
}
