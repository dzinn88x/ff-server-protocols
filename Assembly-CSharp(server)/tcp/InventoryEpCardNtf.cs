using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004BF RID: 1215
	[Token(Token = "0x20004BF")]
	[ProtoContract]
	public class InventoryEpCardNtf
	{
		// Token: 0x06001EB7 RID: 7863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB7")]
		[Address(RVA = "0x24A41BC", Offset = "0x24A41BC", VA = "0x7BBCCA41BC")]
		public InventoryEpCardNtf()
		{
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046B")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1156B64", Offset = "0x1156B64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156B64", Offset = "0x1156B64")]
		public string code
		{
			[Token(Token = "0x6001EB8")]
			[Address(RVA = "0x24A4220", Offset = "0x24A4220", VA = "0x7BBCCA4220")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137144", Offset = "0x1137144")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EB9")]
			[Address(RVA = "0x24A4218", Offset = "0x24A4218", VA = "0x7BBCCA4218")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137154", Offset = "0x1137154")]
			set
			{
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x0000D230 File Offset: 0x0000B430
		// (set) Token: 0x06001EBB RID: 7867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156BB4", Offset = "0x1156BB4")]
		public bool is_active
		{
			[Token(Token = "0x6001EBA")]
			[Address(RVA = "0x24A4228", Offset = "0x24A4228", VA = "0x7BBCCA4228")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137164", Offset = "0x1137164")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EBB")]
			[Address(RVA = "0x24A4230", Offset = "0x24A4230", VA = "0x7BBCCA4230")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137174", Offset = "0x1137174")]
			set
			{
			}
		}

		// Token: 0x040016A1 RID: 5793
		[Token(Token = "0x40016A1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102E64", Offset = "0x1102E64")]
		private string <code>k__BackingField;

		// Token: 0x040016A2 RID: 5794
		[Token(Token = "0x40016A2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102E74", Offset = "0x1102E74")]
		private bool <is_active>k__BackingField;
	}
}
