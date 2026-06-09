using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FC9 RID: 4041
	[Token(Token = "0x2000FC9")]
	public class ResWithTimeoutFileLoader : ResFileLoader
	{
		// Token: 0x06003B1D RID: 15133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1D")]
		[Address(RVA = "0x24815E0", Offset = "0x24815E0", VA = "0x7BBCC815E0", Slot = "7")]
		protected override void OnStart(float time)
		{
		}

		// Token: 0x06003B1E RID: 15134 RVA: 0x00012648 File Offset: 0x00010848
		[Token(Token = "0x6003B1E")]
		[Address(RVA = "0x24819E8", Offset = "0x24819E8", VA = "0x7BBCC819E8", Slot = "5")]
		public override bool IsTimeout(float time)
		{
			return default(bool);
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1F")]
		[Address(RVA = "0x248172C", Offset = "0x248172C", VA = "0x7BBCC8172C")]
		protected void ResetTimer(float time, float time_out = 5f)
		{
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B20")]
		[Address(RVA = "0x2481914", Offset = "0x2481914", VA = "0x7BBCC81914")]
		public ResWithTimeoutFileLoader()
		{
		}

		// Token: 0x04004CA4 RID: 19620
		[Token(Token = "0x4004CA4")]
		protected const float DEFAULT_TIMEOUT = 5f;

		// Token: 0x04004CA5 RID: 19621
		[Token(Token = "0x4004CA5")]
		[FieldOffset(Offset = "0x48")]
		private ResWithTimeoutFileLoader.TimeoutTimer m_Timeout;

		// Token: 0x02000FCA RID: 4042
		[Token(Token = "0x2000FCA")]
		private class TimeoutTimer
		{
			// Token: 0x06003B21 RID: 15137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B21")]
			[Address(RVA = "0x2481A9C", Offset = "0x2481A9C", VA = "0x7BBCC81A9C")]
			public void Start(float gameTime, float timeout)
			{
			}

			// Token: 0x06003B22 RID: 15138 RVA: 0x00012660 File Offset: 0x00010860
			[Token(Token = "0x6003B22")]
			[Address(RVA = "0x2481A8C", Offset = "0x2481A8C", VA = "0x7BBCC81A8C")]
			public bool IsExpired(float gameTime)
			{
				return default(bool);
			}

			// Token: 0x06003B23 RID: 15139 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B23")]
			[Address(RVA = "0x24819E0", Offset = "0x24819E0", VA = "0x7BBCC819E0")]
			public TimeoutTimer()
			{
			}

			// Token: 0x04004CA6 RID: 19622
			[Token(Token = "0x4004CA6")]
			[FieldOffset(Offset = "0x10")]
			private float m_EndTime;
		}
	}
}
