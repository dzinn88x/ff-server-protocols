using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200044F RID: 1103
	[Token(Token = "0x200044F")]
	[ProtoContract]
	public class VeteranTaskUpdateNtf
	{
		// Token: 0x06001C27 RID: 7207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C27")]
		[Address(RVA = "0x24A73D0", Offset = "0x24A73D0", VA = "0x7BBCCA73D0")]
		public VeteranTaskUpdateNtf()
		{
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C29 RID: 7209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700034C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154774", Offset = "0x1154774")]
		public List<VeteranTaskUpdateInfo> tasks
		{
			[Token(Token = "0x6001C28")]
			[Address(RVA = "0x24A744C", Offset = "0x24A744C", VA = "0x7BBCCA744C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134D64", Offset = "0x1134D64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C29")]
			[Address(RVA = "0x24A7444", Offset = "0x24A7444", VA = "0x7BBCCA7444")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134D74", Offset = "0x1134D74")]
			private set
			{
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x0000BF40 File Offset: 0x0000A140
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700034D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154788", Offset = "0x1154788")]
		public uint finished_task_cnt
		{
			[Token(Token = "0x6001C2A")]
			[Address(RVA = "0x24A7454", Offset = "0x24A7454", VA = "0x7BBCCA7454")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134D84", Offset = "0x1134D84")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C2B")]
			[Address(RVA = "0x24A745C", Offset = "0x24A745C", VA = "0x7BBCCA745C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134D94", Offset = "0x1134D94")]
			set
			{
			}
		}

		// Token: 0x04001482 RID: 5250
		[Token(Token = "0x4001482")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101C74", Offset = "0x1101C74")]
		private List<VeteranTaskUpdateInfo> <tasks>k__BackingField;

		// Token: 0x04001483 RID: 5251
		[Token(Token = "0x4001483")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101C84", Offset = "0x1101C84")]
		private uint <finished_task_cnt>k__BackingField;
	}
}
