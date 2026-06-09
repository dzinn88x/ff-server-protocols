using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F85 RID: 3973
	[Token(Token = "0x2000F85")]
	public class TracerouteNodeResult
	{
		// Token: 0x060039DF RID: 14815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039DF")]
		[Address(RVA = "0x249922C", Offset = "0x249922C", VA = "0x7BBCC9922C")]
		public TracerouteNodeResult()
		{
		}

		// Token: 0x04004B6D RID: 19309
		[Token(Token = "0x4004B6D")]
		[FieldOffset(Offset = "0x10")]
		public string target_ip;

		// Token: 0x04004B6E RID: 19310
		[Token(Token = "0x4004B6E")]
		[FieldOffset(Offset = "0x18")]
		public string status;

		// Token: 0x04004B6F RID: 19311
		[Token(Token = "0x4004B6F")]
		[FieldOffset(Offset = "0x20")]
		public int hop;

		// Token: 0x04004B70 RID: 19312
		[Token(Token = "0x4004B70")]
		[FieldOffset(Offset = "0x28")]
		public string route_ip;

		// Token: 0x04004B71 RID: 19313
		[Token(Token = "0x4004B71")]
		[FieldOffset(Offset = "0x30")]
		public bool is_final_route;

		// Token: 0x04004B72 RID: 19314
		[Token(Token = "0x4004B72")]
		[FieldOffset(Offset = "0x34")]
		public int average_delay;

		// Token: 0x04004B73 RID: 19315
		[Token(Token = "0x4004B73")]
		[FieldOffset(Offset = "0x38")]
		public int loss_rate;
	}
}
