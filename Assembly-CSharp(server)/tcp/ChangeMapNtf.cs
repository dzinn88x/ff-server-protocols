using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004B2 RID: 1202
	[Token(Token = "0x20004B2")]
	[ProtoContract]
	public class ChangeMapNtf
	{
		// Token: 0x06001E7E RID: 7806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E7E")]
		[Address(RVA = "0x24A29B4", Offset = "0x24A29B4", VA = "0x7BBCCA29B4")]
		public ChangeMapNtf()
		{
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E80 RID: 7808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000454")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11567F4", Offset = "0x11567F4")]
		public uint[] map_ids
		{
			[Token(Token = "0x6001E7F")]
			[Address(RVA = "0x24A29BC", Offset = "0x24A29BC", VA = "0x7BBCCA29BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136E64", Offset = "0x1136E64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E80")]
			[Address(RVA = "0x24A29C4", Offset = "0x24A29C4", VA = "0x7BBCCA29C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136E74", Offset = "0x1136E74")]
			set
			{
			}
		}

		// Token: 0x04001679 RID: 5753
		[Token(Token = "0x4001679")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102CF4", Offset = "0x1102CF4")]
		private uint[] <map_ids>k__BackingField;
	}
}
