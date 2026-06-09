using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004FA RID: 1274
	[Token(Token = "0x20004FA")]
	[ProtoContract]
	public class AwakenTaskChangeNtf
	{
		// Token: 0x06001FC7 RID: 8135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC7")]
		[Address(RVA = "0x24A26A4", Offset = "0x24A26A4", VA = "0x7BBCCA26A4")]
		public AwakenTaskChangeNtf()
		{
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FC9 RID: 8137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157938", Offset = "0x1157938")]
		public List<AwakenTaskChangeInfo> awaken_tasks
		{
			[Token(Token = "0x6001FC8")]
			[Address(RVA = "0x24A2720", Offset = "0x24A2720", VA = "0x7BBCCA2720")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137FE4", Offset = "0x1137FE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FC9")]
			[Address(RVA = "0x24A2718", Offset = "0x24A2718", VA = "0x7BBCCA2718")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137FF4", Offset = "0x1137FF4")]
			private set
			{
			}
		}

		// Token: 0x0400177E RID: 6014
		[Token(Token = "0x400177E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11035B4", Offset = "0x11035B4")]
		private List<AwakenTaskChangeInfo> <awaken_tasks>k__BackingField;
	}
}
