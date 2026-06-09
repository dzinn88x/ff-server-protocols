using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004E7 RID: 1255
	[Token(Token = "0x20004E7")]
	[ProtoContract]
	public class RecvAntiDataReq
	{
		// Token: 0x06001F73 RID: 8051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F73")]
		[Address(RVA = "0x24A5A84", Offset = "0x24A5A84", VA = "0x7BBCCA5A84")]
		public RecvAntiDataReq()
		{
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F75 RID: 8053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157514", Offset = "0x1157514")]
		public byte[] anti_data
		{
			[Token(Token = "0x6001F74")]
			[Address(RVA = "0x24A5A8C", Offset = "0x24A5A8C", VA = "0x7BBCCA5A8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137B64", Offset = "0x1137B64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F75")]
			[Address(RVA = "0x24A5A94", Offset = "0x24A5A94", VA = "0x7BBCCA5A94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137B74", Offset = "0x1137B74")]
			set
			{
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001F76 RID: 8054 RVA: 0x0000D770 File Offset: 0x0000B970
		// (set) Token: 0x06001F77 RID: 8055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BD")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157528", Offset = "0x1157528")]
		public uint data_len
		{
			[Token(Token = "0x6001F76")]
			[Address(RVA = "0x24A5A9C", Offset = "0x24A5A9C", VA = "0x7BBCCA5A9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137B84", Offset = "0x1137B84")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F77")]
			[Address(RVA = "0x24A5AA4", Offset = "0x24A5AA4", VA = "0x7BBCCA5AA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137B94", Offset = "0x1137B94")]
			set
			{
			}
		}

		// Token: 0x04001744 RID: 5956
		[Token(Token = "0x4001744")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103374", Offset = "0x1103374")]
		private byte[] <anti_data>k__BackingField;

		// Token: 0x04001745 RID: 5957
		[Token(Token = "0x4001745")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103384", Offset = "0x1103384")]
		private uint <data_len>k__BackingField;
	}
}
