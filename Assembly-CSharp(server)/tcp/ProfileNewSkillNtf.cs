using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004F9 RID: 1273
	[Token(Token = "0x20004F9")]
	[ProtoContract]
	public class ProfileNewSkillNtf
	{
		// Token: 0x06001FC4 RID: 8132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC4")]
		[Address(RVA = "0x24A59F4", Offset = "0x24A59F4", VA = "0x7BBCCA59F4")]
		public ProfileNewSkillNtf()
		{
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DF")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157924", Offset = "0x1157924")]
		public uint new_skill_id
		{
			[Token(Token = "0x6001FC5")]
			[Address(RVA = "0x24A59FC", Offset = "0x24A59FC", VA = "0x7BBCCA59FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137FC4", Offset = "0x1137FC4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001FC6")]
			[Address(RVA = "0x24A5A04", Offset = "0x24A5A04", VA = "0x7BBCCA5A04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137FD4", Offset = "0x1137FD4")]
			set
			{
			}
		}

		// Token: 0x0400177D RID: 6013
		[Token(Token = "0x400177D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11035A4", Offset = "0x11035A4")]
		private uint <new_skill_id>k__BackingField;
	}
}
