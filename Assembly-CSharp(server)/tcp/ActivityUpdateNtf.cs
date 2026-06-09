using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000443 RID: 1091
	[Token(Token = "0x2000443")]
	[ProtoContract]
	public class ActivityUpdateNtf
	{
		// Token: 0x06001C05 RID: 7173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C05")]
		[Address(RVA = "0x24A2364", Offset = "0x24A2364", VA = "0x7BBCCA2364")]
		public ActivityUpdateNtf()
		{
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C07 RID: 7175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115456C", Offset = "0x115456C")]
		public List<ActivityUpdateInfo> activitys
		{
			[Token(Token = "0x6001C06")]
			[Address(RVA = "0x24A23E0", Offset = "0x24A23E0", VA = "0x7BBCCA23E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134BA4", Offset = "0x1134BA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C07")]
			[Address(RVA = "0x24A23D8", Offset = "0x24A23D8", VA = "0x7BBCCA23D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134BB4", Offset = "0x1134BB4")]
			private set
			{
			}
		}

		// Token: 0x04001462 RID: 5218
		[Token(Token = "0x4001462")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101B94", Offset = "0x1101B94")]
		private List<ActivityUpdateInfo> <activitys>k__BackingField;
	}
}
