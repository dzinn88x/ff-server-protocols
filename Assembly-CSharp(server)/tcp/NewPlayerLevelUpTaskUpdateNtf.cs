using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000451 RID: 1105
	[Token(Token = "0x2000451")]
	[ProtoContract]
	public class NewPlayerLevelUpTaskUpdateNtf
	{
		// Token: 0x06001C35 RID: 7221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C35")]
		[Address(RVA = "0x24A5654", Offset = "0x24A5654", VA = "0x7BBCCA5654")]
		public NewPlayerLevelUpTaskUpdateNtf()
		{
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C37 RID: 7223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000352")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154828", Offset = "0x1154828")]
		public List<NewPlayerLevelUpTaskUpdateInfo> tasks
		{
			[Token(Token = "0x6001C36")]
			[Address(RVA = "0x24A56D0", Offset = "0x24A56D0", VA = "0x7BBCCA56D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134E24", Offset = "0x1134E24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C37")]
			[Address(RVA = "0x24A56C8", Offset = "0x24A56C8", VA = "0x7BBCCA56C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134E34", Offset = "0x1134E34")]
			private set
			{
			}
		}

		// Token: 0x04001488 RID: 5256
		[Token(Token = "0x4001488")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101CD4", Offset = "0x1101CD4")]
		private List<NewPlayerLevelUpTaskUpdateInfo> <tasks>k__BackingField;
	}
}
