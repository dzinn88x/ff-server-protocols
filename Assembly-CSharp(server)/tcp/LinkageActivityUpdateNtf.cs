using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004CA RID: 1226
	[Token(Token = "0x20004CA")]
	[ProtoContract]
	public class LinkageActivityUpdateNtf
	{
		// Token: 0x06001EDA RID: 7898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDA")]
		[Address(RVA = "0x24A4754", Offset = "0x24A4754", VA = "0x7BBCCA4754")]
		public LinkageActivityUpdateNtf()
		{
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EDC RID: 7900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000479")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156CF4", Offset = "0x1156CF4")]
		public LinkageActivityUpdateInfo activity
		{
			[Token(Token = "0x6001EDB")]
			[Address(RVA = "0x24A475C", Offset = "0x24A475C", VA = "0x7BBCCA475C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137304", Offset = "0x1137304")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EDC")]
			[Address(RVA = "0x24A4764", Offset = "0x24A4764", VA = "0x7BBCCA4764")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137314", Offset = "0x1137314")]
			set
			{
			}
		}

		// Token: 0x040016BD RID: 5821
		[Token(Token = "0x40016BD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102F44", Offset = "0x1102F44")]
		private LinkageActivityUpdateInfo <activity>k__BackingField;
	}
}
