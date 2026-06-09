using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F5C RID: 3932
	[Token(Token = "0x2000F5C")]
	public class Timer
	{
		// Token: 0x060038F4 RID: 14580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F4")]
		[Address(RVA = "0x2499080", Offset = "0x2499080", VA = "0x7BBCC99080")]
		public void Reset()
		{
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F5")]
		[Address(RVA = "0x249908C", Offset = "0x249908C", VA = "0x7BBCC9908C")]
		public void SetExpiredTime(float expiredTime)
		{
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x00011AD8 File Offset: 0x0000FCD8
		[Token(Token = "0x60038F6")]
		[Address(RVA = "0x2499094", Offset = "0x2499094", VA = "0x7BBCC99094")]
		public bool IsExpired(float gameTime)
		{
			return default(bool);
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F7")]
		[Address(RVA = "0x24990B0", Offset = "0x24990B0", VA = "0x7BBCC990B0")]
		public void Copy(Timer t)
		{
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F8")]
		[Address(RVA = "0x24990E4", Offset = "0x24990E4", VA = "0x7BBCC990E4")]
		public Timer()
		{
		}

		// Token: 0x04004AD1 RID: 19153
		[Token(Token = "0x4004AD1")]
		[FieldOffset(Offset = "0x10")]
		protected float m_ExpiredTime;
	}
}
