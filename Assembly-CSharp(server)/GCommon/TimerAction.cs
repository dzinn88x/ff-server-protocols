using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F5D RID: 3933
	[Token(Token = "0x2000F5D")]
	public class TimerAction : Timer, IObjectPoolCallback
	{
		// Token: 0x060038F9 RID: 14585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F9")]
		[Address(RVA = "0x24990EC", Offset = "0x24990EC", VA = "0x7BBCC990EC")]
		public void SetActionAt(float gameTime, float expiredTime, Action action, bool isRepeated)
		{
		}

		// Token: 0x060038FA RID: 14586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038FA")]
		[Address(RVA = "0x2499108", Offset = "0x2499108", VA = "0x7BBCC99108")]
		public void MoveFront()
		{
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x00011AF0 File Offset: 0x0000FCF0
		[Token(Token = "0x60038FB")]
		[Address(RVA = "0x2499110", Offset = "0x2499110", VA = "0x7BBCC99110")]
		public bool Update(float gameTime, uint actionId, Dictionary<uint, Action> timerActionsToBeCalled)
		{
			return default(bool);
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038FC")]
		[Address(RVA = "0x24991EC", Offset = "0x24991EC", VA = "0x7BBCC991EC", Slot = "4")]
		public void OnAllocated()
		{
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038FD")]
		[Address(RVA = "0x24991F4", Offset = "0x24991F4", VA = "0x7BBCC991F4", Slot = "5")]
		public void OnCollected()
		{
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x00011B08 File Offset: 0x0000FD08
		[Token(Token = "0x60038FE")]
		[Address(RVA = "0x2499214", Offset = "0x2499214", VA = "0x7BBCC99214", Slot = "6")]
		public bool IsInPool()
		{
			return default(bool);
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038FF")]
		[Address(RVA = "0x249921C", Offset = "0x249921C", VA = "0x7BBCC9921C")]
		public TimerAction()
		{
		}

		// Token: 0x04004AD2 RID: 19154
		[Token(Token = "0x4004AD2")]
		[FieldOffset(Offset = "0x18")]
		private Action m_Action;

		// Token: 0x04004AD3 RID: 19155
		[Token(Token = "0x4004AD3")]
		[FieldOffset(Offset = "0x20")]
		private bool m_IsRepeated;

		// Token: 0x04004AD4 RID: 19156
		[Token(Token = "0x4004AD4")]
		[FieldOffset(Offset = "0x24")]
		private float m_Duration;

		// Token: 0x04004AD5 RID: 19157
		[Token(Token = "0x4004AD5")]
		[FieldOffset(Offset = "0x28")]
		private bool m_IsInPool;
	}
}
