using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004E2 RID: 1250
	[Token(Token = "0x20004E2")]
	[ProtoContract]
	public class EmulatorPlayerNtf
	{
		// Token: 0x06001F64 RID: 8036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F64")]
		[Address(RVA = "0x24A2E18", Offset = "0x24A2E18", VA = "0x7BBCCA2E18")]
		public EmulatorPlayerNtf()
		{
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001F65 RID: 8037 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
		// (set) Token: 0x06001F66 RID: 8038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B6")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157474", Offset = "0x1157474")]
		public ulong emulator_account_id
		{
			[Token(Token = "0x6001F65")]
			[Address(RVA = "0x24A2E20", Offset = "0x24A2E20", VA = "0x7BBCCA2E20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137AA4", Offset = "0x1137AA4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001F66")]
			[Address(RVA = "0x24A2E28", Offset = "0x24A2E28", VA = "0x7BBCCA2E28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137AB4", Offset = "0x1137AB4")]
			set
			{
			}
		}

		// Token: 0x04001735 RID: 5941
		[Token(Token = "0x4001735")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103314", Offset = "0x1103314")]
		private ulong <emulator_account_id>k__BackingField;
	}
}
