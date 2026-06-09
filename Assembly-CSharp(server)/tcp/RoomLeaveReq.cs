using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200050B RID: 1291
	[Token(Token = "0x200050B")]
	[ProtoContract]
	public class RoomLeaveReq
	{
		// Token: 0x0600203F RID: 8255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600203F")]
		[Address(RVA = "0x24A69F4", Offset = "0x24A69F4", VA = "0x7BBCCA69F4")]
		public RoomLeaveReq()
		{
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06002040 RID: 8256 RVA: 0x0000DD70 File Offset: 0x0000BF70
		// (set) Token: 0x06002041 RID: 8257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000518")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157FA0", Offset = "0x1157FA0")]
		public ulong room_id
		{
			[Token(Token = "0x6002040")]
			[Address(RVA = "0x24A69FC", Offset = "0x24A69FC", VA = "0x7BBCCA69FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11386E4", Offset = "0x11386E4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002041")]
			[Address(RVA = "0x24A6A04", Offset = "0x24A6A04", VA = "0x7BBCCA6A04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11386F4", Offset = "0x11386F4")]
			set
			{
			}
		}

		// Token: 0x04001832 RID: 6194
		[Token(Token = "0x4001832")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103934", Offset = "0x1103934")]
		private ulong <room_id>k__BackingField;
	}
}
