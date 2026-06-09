using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004D5 RID: 1237
	[Token(Token = "0x20004D5")]
	[ProtoContract]
	public class ManualMapRewardUpdateNtf
	{
		// Token: 0x06001EF3 RID: 7923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF3")]
		[Address(RVA = "0x24A4850", Offset = "0x24A4850", VA = "0x7BBCCA4850")]
		public ManualMapRewardUpdateNtf()
		{
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EF5 RID: 7925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000482")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156DA8", Offset = "0x1156DA8")]
		public ManualMapRewardUpdateInfo map_info
		{
			[Token(Token = "0x6001EF4")]
			[Address(RVA = "0x24A4858", Offset = "0x24A4858", VA = "0x7BBCCA4858")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137424", Offset = "0x1137424")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EF5")]
			[Address(RVA = "0x24A4860", Offset = "0x24A4860", VA = "0x7BBCCA4860")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137434", Offset = "0x1137434")]
			set
			{
			}
		}

		// Token: 0x040016D1 RID: 5841
		[Token(Token = "0x40016D1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102FD4", Offset = "0x1102FD4")]
		private ManualMapRewardUpdateInfo <map_info>k__BackingField;
	}
}
