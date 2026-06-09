using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F84 RID: 3972
	[Token(Token = "0x2000F84")]
	public class TracerouteResult : NetDetectionResult
	{
		// Token: 0x060039DE RID: 14814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039DE")]
		[Address(RVA = "0x2499234", Offset = "0x2499234", VA = "0x7BBCC99234")]
		public TracerouteResult()
		{
		}

		// Token: 0x04004B6A RID: 19306
		[Token(Token = "0x4004B6A")]
		[FieldOffset(Offset = "0x18")]
		public TracerouteNodeResult[] traceroute_node_results;

		// Token: 0x04004B6B RID: 19307
		[Token(Token = "0x4004B6B")]
		[FieldOffset(Offset = "0x20")]
		public long time_stamp;

		// Token: 0x04004B6C RID: 19308
		[Token(Token = "0x4004B6C")]
		[FieldOffset(Offset = "0x28")]
		public ETraceRouteError err_code;
	}
}
