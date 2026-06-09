using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004E8 RID: 1256
	[Token(Token = "0x20004E8")]
	[ProtoContract]
	public class SendDataToClientNtf
	{
		// Token: 0x06001F78 RID: 8056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F78")]
		[Address(RVA = "0x24A708C", Offset = "0x24A708C", VA = "0x7BBCCA708C")]
		public SendDataToClientNtf()
		{
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F7A RID: 8058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BE")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115753C", Offset = "0x115753C")]
		public byte[] anti_data
		{
			[Token(Token = "0x6001F79")]
			[Address(RVA = "0x24A7094", Offset = "0x24A7094", VA = "0x7BBCCA7094")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137BA4", Offset = "0x1137BA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F7A")]
			[Address(RVA = "0x24A709C", Offset = "0x24A709C", VA = "0x7BBCCA709C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137BB4", Offset = "0x1137BB4")]
			set
			{
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x0000D788 File Offset: 0x0000B988
		// (set) Token: 0x06001F7C RID: 8060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BF")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157550", Offset = "0x1157550")]
		public uint data_len
		{
			[Token(Token = "0x6001F7B")]
			[Address(RVA = "0x24A70A4", Offset = "0x24A70A4", VA = "0x7BBCCA70A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137BC4", Offset = "0x1137BC4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F7C")]
			[Address(RVA = "0x24A70AC", Offset = "0x24A70AC", VA = "0x7BBCCA70AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137BD4", Offset = "0x1137BD4")]
			set
			{
			}
		}

		// Token: 0x04001746 RID: 5958
		[Token(Token = "0x4001746")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103394", Offset = "0x1103394")]
		private byte[] <anti_data>k__BackingField;

		// Token: 0x04001747 RID: 5959
		[Token(Token = "0x4001747")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11033A4", Offset = "0x11033A4")]
		private uint <data_len>k__BackingField;
	}
}
