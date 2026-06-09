using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FB5 RID: 4021
	[Token(Token = "0x2000FB5")]
	public static class UDPParameters
	{
		// Token: 0x04004C13 RID: 19475
		[Token(Token = "0x4004C13")]
		[FieldOffset(Offset = "0x0")]
		public static int MAX_RESEND_COUNT;

		// Token: 0x04004C14 RID: 19476
		[Token(Token = "0x4004C14")]
		[FieldOffset(Offset = "0x8")]
		public static double RESEND_TIMEOUT;

		// Token: 0x04004C15 RID: 19477
		[Token(Token = "0x4004C15")]
		[FieldOffset(Offset = "0x10")]
		public static double FIRST_RESEND_TIMEOUT;

		// Token: 0x04004C16 RID: 19478
		[Token(Token = "0x4004C16")]
		[FieldOffset(Offset = "0x18")]
		public static double MAX_RESEND_TIMEOUT;

		// Token: 0x04004C17 RID: 19479
		[Token(Token = "0x4004C17")]
		[FieldOffset(Offset = "0x20")]
		public static double DEFAULT_DEACTIVE_TIME;

		// Token: 0x04004C18 RID: 19480
		[Token(Token = "0x4004C18")]
		[FieldOffset(Offset = "0x28")]
		public static int MTU_LIMIT;

		// Token: 0x04004C19 RID: 19481
		[Token(Token = "0x4004C19")]
		[FieldOffset(Offset = "0x30")]
		public static byte[] SECRET_KEY;

		// Token: 0x04004C1A RID: 19482
		[Token(Token = "0x4004C1A")]
		[FieldOffset(Offset = "0x38")]
		public static int JOIN_TIMEOUT;

		// Token: 0x04004C1B RID: 19483
		[Token(Token = "0x4004C1B")]
		[FieldOffset(Offset = "0x40")]
		public static double RECONNECT_DELAY;

		// Token: 0x04004C1C RID: 19484
		[Token(Token = "0x4004C1C")]
		[FieldOffset(Offset = "0x48")]
		public static int MIN_RECV_SLEEP_TIME;

		// Token: 0x04004C1D RID: 19485
		[Token(Token = "0x4004C1D")]
		[FieldOffset(Offset = "0x50")]
		public static double FLUSH_RESEND_DEACTIVVE_TIME;

		// Token: 0x04004C1E RID: 19486
		[Token(Token = "0x4004C1E")]
		[FieldOffset(Offset = "0x58")]
		public static double FLUSH_RESEND_DELTA_TIME;

		// Token: 0x04004C1F RID: 19487
		[Token(Token = "0x4004C1F")]
		[FieldOffset(Offset = "0x60")]
		public static double FLUSH_RESEND_INTERVAL_TIME;

		// Token: 0x04004C20 RID: 19488
		[Token(Token = "0x4004C20")]
		[FieldOffset(Offset = "0x68")]
		public static bool ENABLE_PACKAGE_POOL;

		// Token: 0x04004C21 RID: 19489
		[Token(Token = "0x4004C21")]
		[FieldOffset(Offset = "0x69")]
		public static bool ENABLE_MESSAGE_POOL;

		// Token: 0x04004C22 RID: 19490
		[Token(Token = "0x4004C22")]
		[FieldOffset(Offset = "0x6C")]
		public static float FORCE_RECONNECT_TIMEOUT;

		// Token: 0x04004C23 RID: 19491
		[Token(Token = "0x4004C23")]
		[FieldOffset(Offset = "0x70")]
		public static bool ENABEL_MESSAGE_POOL_OPTIMIZATION;
	}
}
