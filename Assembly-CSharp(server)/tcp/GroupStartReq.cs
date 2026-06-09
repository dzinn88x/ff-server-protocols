using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004A2 RID: 1186
	[Token(Token = "0x20004A2")]
	[ProtoContract]
	public class GroupStartReq
	{
		// Token: 0x06001DCC RID: 7628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DCC")]
		[Address(RVA = "0x24A40F4", Offset = "0x24A40F4", VA = "0x7BBCCA40F4")]
		public GroupStartReq()
		{
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001DCD RID: 7629 RVA: 0x0000CB58 File Offset: 0x0000AD58
		// (set) Token: 0x06001DCE RID: 7630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000403")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155E08", Offset = "0x1155E08")]
		public ulong group_id
		{
			[Token(Token = "0x6001DCD")]
			[Address(RVA = "0x24A40FC", Offset = "0x24A40FC", VA = "0x7BBCCA40FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136444", Offset = "0x1136444")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001DCE")]
			[Address(RVA = "0x24A4104", Offset = "0x24A4104", VA = "0x7BBCCA4104")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136454", Offset = "0x1136454")]
			set
			{
			}
		}

		// Token: 0x04001628 RID: 5672
		[Token(Token = "0x4001628")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11027E4", Offset = "0x11027E4")]
		private ulong <group_id>k__BackingField;
	}
}
