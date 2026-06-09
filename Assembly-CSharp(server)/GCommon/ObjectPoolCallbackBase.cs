using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000ECB RID: 3787
	[Token(Token = "0x2000ECB")]
	public class ObjectPoolCallbackBase : IObjectPoolCallback
	{
		// Token: 0x06003438 RID: 13368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003438")]
		[Address(RVA = "0x246C47C", Offset = "0x246C47C", VA = "0x7BBCC6C47C", Slot = "7")]
		public virtual void OnAllocated()
		{
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003439")]
		[Address(RVA = "0x246C484", Offset = "0x246C484", VA = "0x7BBCC6C484", Slot = "8")]
		public virtual void OnCollected()
		{
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
		[Token(Token = "0x600343A")]
		[Address(RVA = "0x246C490", Offset = "0x246C490", VA = "0x7BBCC6C490", Slot = "9")]
		public virtual bool IsInPool()
		{
			return default(bool);
		}

		// Token: 0x0600343B RID: 13371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343B")]
		[Address(RVA = "0x246C498", Offset = "0x246C498", VA = "0x7BBCC6C498")]
		public ObjectPoolCallbackBase()
		{
		}

		// Token: 0x04004803 RID: 18435
		[Token(Token = "0x4004803")]
		[FieldOffset(Offset = "0x10")]
		private bool m_IsInPool;
	}
}
