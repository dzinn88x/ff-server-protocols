using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000480 RID: 1152
	[Token(Token = "0x2000480")]
	[ProtoContract]
	public class FreshActivityUpdateNtf
	{
		// Token: 0x06001CEB RID: 7403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CEB")]
		[Address(RVA = "0x24A2E68", Offset = "0x24A2E68", VA = "0x7BBCCA2E68")]
		public FreshActivityUpdateNtf()
		{
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001CED RID: 7405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11550FC", Offset = "0x11550FC")]
		public List<FreshActivityUpdateInfo> activitys
		{
			[Token(Token = "0x6001CEC")]
			[Address(RVA = "0x24A2EE4", Offset = "0x24A2EE4", VA = "0x7BBCCA2EE4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135784", Offset = "0x1135784")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CED")]
			[Address(RVA = "0x24A2EDC", Offset = "0x24A2EDC", VA = "0x7BBCCA2EDC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135794", Offset = "0x1135794")]
			private set
			{
			}
		}

		// Token: 0x04001524 RID: 5412
		[Token(Token = "0x4001524")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102184", Offset = "0x1102184")]
		private List<FreshActivityUpdateInfo> <activitys>k__BackingField;
	}
}
