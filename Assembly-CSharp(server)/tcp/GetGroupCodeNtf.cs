using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004B6 RID: 1206
	[Token(Token = "0x20004B6")]
	[ProtoContract]
	public class GetGroupCodeNtf
	{
		// Token: 0x06001E8E RID: 7822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E8E")]
		[Address(RVA = "0x24A3004", Offset = "0x24A3004", VA = "0x7BBCCA3004")]
		public GetGroupCodeNtf()
		{
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E90 RID: 7824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045A")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11568E4", Offset = "0x11568E4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11568E4", Offset = "0x11568E4")]
		public string group_code
		{
			[Token(Token = "0x6001E8F")]
			[Address(RVA = "0x24A3068", Offset = "0x24A3068", VA = "0x7BBCCA3068")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136F24", Offset = "0x1136F24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E90")]
			[Address(RVA = "0x24A3060", Offset = "0x24A3060", VA = "0x7BBCCA3060")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136F34", Offset = "0x1136F34")]
			set
			{
			}
		}

		// Token: 0x0400167F RID: 5759
		[Token(Token = "0x400167F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102D54", Offset = "0x1102D54")]
		private string <group_code>k__BackingField;
	}
}
